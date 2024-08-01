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
    using Google.Analytics.Admin.V1Alpha;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAnalyticsAdminServiceClientSnippets
    {
        /// <summary>Snippet for GetAccount</summary>
        public void GetAccountRequestObject()
        {
            // Snippet: GetAccount(GetAccountRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Account response = analyticsAdminServiceClient.GetAccount(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountAsync</summary>
        public async Task GetAccountRequestObjectAsync()
        {
            // Snippet: GetAccountAsync(GetAccountRequest, CallSettings)
            // Additional: GetAccountAsync(GetAccountRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Account response = await analyticsAdminServiceClient.GetAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccount</summary>
        public void GetAccount()
        {
            // Snippet: GetAccount(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            Account response = analyticsAdminServiceClient.GetAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountAsync</summary>
        public async Task GetAccountAsync()
        {
            // Snippet: GetAccountAsync(string, CallSettings)
            // Additional: GetAccountAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            Account response = await analyticsAdminServiceClient.GetAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccount</summary>
        public void GetAccountResourceNames()
        {
            // Snippet: GetAccount(AccountName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            Account response = analyticsAdminServiceClient.GetAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountAsync</summary>
        public async Task GetAccountResourceNamesAsync()
        {
            // Snippet: GetAccountAsync(AccountName, CallSettings)
            // Additional: GetAccountAsync(AccountName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            Account response = await analyticsAdminServiceClient.GetAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAccounts</summary>
        public void ListAccountsRequestObject()
        {
            // Snippet: ListAccounts(ListAccountsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListAccountsRequest request = new ListAccountsRequest { ShowDeleted = false, };
            // Make the request
            PagedEnumerable<ListAccountsResponse, Account> response = analyticsAdminServiceClient.ListAccounts(request);

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
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccountsRequest request = new ListAccountsRequest { ShowDeleted = false, };
            // Make the request
            PagedAsyncEnumerable<ListAccountsResponse, Account> response = analyticsAdminServiceClient.ListAccountsAsync(request);

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

        /// <summary>Snippet for DeleteAccount</summary>
        public void DeleteAccountRequestObject()
        {
            // Snippet: DeleteAccount(DeleteAccountRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteAccount(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountAsync</summary>
        public async Task DeleteAccountRequestObjectAsync()
        {
            // Snippet: DeleteAccountAsync(DeleteAccountRequest, CallSettings)
            // Additional: DeleteAccountAsync(DeleteAccountRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccount</summary>
        public void DeleteAccount()
        {
            // Snippet: DeleteAccount(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            analyticsAdminServiceClient.DeleteAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountAsync</summary>
        public async Task DeleteAccountAsync()
        {
            // Snippet: DeleteAccountAsync(string, CallSettings)
            // Additional: DeleteAccountAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            await analyticsAdminServiceClient.DeleteAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccount</summary>
        public void DeleteAccountResourceNames()
        {
            // Snippet: DeleteAccount(AccountName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            analyticsAdminServiceClient.DeleteAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountAsync</summary>
        public async Task DeleteAccountResourceNamesAsync()
        {
            // Snippet: DeleteAccountAsync(AccountName, CallSettings)
            // Additional: DeleteAccountAsync(AccountName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            await analyticsAdminServiceClient.DeleteAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccount</summary>
        public void UpdateAccountRequestObject()
        {
            // Snippet: UpdateAccount(UpdateAccountRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateAccountRequest request = new UpdateAccountRequest
            {
                Account = new Account(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Account response = analyticsAdminServiceClient.UpdateAccount(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountAsync</summary>
        public async Task UpdateAccountRequestObjectAsync()
        {
            // Snippet: UpdateAccountAsync(UpdateAccountRequest, CallSettings)
            // Additional: UpdateAccountAsync(UpdateAccountRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccountRequest request = new UpdateAccountRequest
            {
                Account = new Account(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Account response = await analyticsAdminServiceClient.UpdateAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccount</summary>
        public void UpdateAccount()
        {
            // Snippet: UpdateAccount(Account, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            Account account = new Account();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Account response = analyticsAdminServiceClient.UpdateAccount(account, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountAsync</summary>
        public async Task UpdateAccountAsync()
        {
            // Snippet: UpdateAccountAsync(Account, FieldMask, CallSettings)
            // Additional: UpdateAccountAsync(Account, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            Account account = new Account();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Account response = await analyticsAdminServiceClient.UpdateAccountAsync(account, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ProvisionAccountTicket</summary>
        public void ProvisionAccountTicketRequestObject()
        {
            // Snippet: ProvisionAccountTicket(ProvisionAccountTicketRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ProvisionAccountTicketRequest request = new ProvisionAccountTicketRequest
            {
                Account = new Account(),
                RedirectUri = "",
            };
            // Make the request
            ProvisionAccountTicketResponse response = analyticsAdminServiceClient.ProvisionAccountTicket(request);
            // End snippet
        }

        /// <summary>Snippet for ProvisionAccountTicketAsync</summary>
        public async Task ProvisionAccountTicketRequestObjectAsync()
        {
            // Snippet: ProvisionAccountTicketAsync(ProvisionAccountTicketRequest, CallSettings)
            // Additional: ProvisionAccountTicketAsync(ProvisionAccountTicketRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProvisionAccountTicketRequest request = new ProvisionAccountTicketRequest
            {
                Account = new Account(),
                RedirectUri = "",
            };
            // Make the request
            ProvisionAccountTicketResponse response = await analyticsAdminServiceClient.ProvisionAccountTicketAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListAccountSummaries</summary>
        public void ListAccountSummariesRequestObject()
        {
            // Snippet: ListAccountSummaries(ListAccountSummariesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListAccountSummariesRequest request = new ListAccountSummariesRequest { };
            // Make the request
            PagedEnumerable<ListAccountSummariesResponse, AccountSummary> response = analyticsAdminServiceClient.ListAccountSummaries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountSummary item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountSummariesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountSummary> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountSummariesAsync</summary>
        public async Task ListAccountSummariesRequestObjectAsync()
        {
            // Snippet: ListAccountSummariesAsync(ListAccountSummariesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccountSummariesRequest request = new ListAccountSummariesRequest { };
            // Make the request
            PagedAsyncEnumerable<ListAccountSummariesResponse, AccountSummary> response = analyticsAdminServiceClient.ListAccountSummariesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountSummary item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountSummariesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountSummary item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountSummary> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountSummary item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProperty</summary>
        public void GetPropertyRequestObject()
        {
            // Snippet: GetProperty(GetPropertyRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetPropertyRequest request = new GetPropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            Property response = analyticsAdminServiceClient.GetProperty(request);
            // End snippet
        }

        /// <summary>Snippet for GetPropertyAsync</summary>
        public async Task GetPropertyRequestObjectAsync()
        {
            // Snippet: GetPropertyAsync(GetPropertyRequest, CallSettings)
            // Additional: GetPropertyAsync(GetPropertyRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetPropertyRequest request = new GetPropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            Property response = await analyticsAdminServiceClient.GetPropertyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProperty</summary>
        public void GetProperty()
        {
            // Snippet: GetProperty(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]";
            // Make the request
            Property response = analyticsAdminServiceClient.GetProperty(name);
            // End snippet
        }

        /// <summary>Snippet for GetPropertyAsync</summary>
        public async Task GetPropertyAsync()
        {
            // Snippet: GetPropertyAsync(string, CallSettings)
            // Additional: GetPropertyAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]";
            // Make the request
            Property response = await analyticsAdminServiceClient.GetPropertyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProperty</summary>
        public void GetPropertyResourceNames()
        {
            // Snippet: GetProperty(PropertyName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName name = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            Property response = analyticsAdminServiceClient.GetProperty(name);
            // End snippet
        }

        /// <summary>Snippet for GetPropertyAsync</summary>
        public async Task GetPropertyResourceNamesAsync()
        {
            // Snippet: GetPropertyAsync(PropertyName, CallSettings)
            // Additional: GetPropertyAsync(PropertyName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName name = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            Property response = await analyticsAdminServiceClient.GetPropertyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListProperties</summary>
        public void ListPropertiesRequestObject()
        {
            // Snippet: ListProperties(ListPropertiesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListPropertiesRequest request = new ListPropertiesRequest
            {
                Filter = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListPropertiesResponse, Property> response = analyticsAdminServiceClient.ListProperties(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Property item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPropertiesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Property item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Property> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Property item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPropertiesAsync</summary>
        public async Task ListPropertiesRequestObjectAsync()
        {
            // Snippet: ListPropertiesAsync(ListPropertiesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListPropertiesRequest request = new ListPropertiesRequest
            {
                Filter = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListPropertiesResponse, Property> response = analyticsAdminServiceClient.ListPropertiesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Property item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPropertiesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Property item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Property> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Property item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateProperty</summary>
        public void CreatePropertyRequestObject()
        {
            // Snippet: CreateProperty(CreatePropertyRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreatePropertyRequest request = new CreatePropertyRequest
            {
                Property = new Property(),
            };
            // Make the request
            Property response = analyticsAdminServiceClient.CreateProperty(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePropertyAsync</summary>
        public async Task CreatePropertyRequestObjectAsync()
        {
            // Snippet: CreatePropertyAsync(CreatePropertyRequest, CallSettings)
            // Additional: CreatePropertyAsync(CreatePropertyRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePropertyRequest request = new CreatePropertyRequest
            {
                Property = new Property(),
            };
            // Make the request
            Property response = await analyticsAdminServiceClient.CreatePropertyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateProperty</summary>
        public void CreateProperty()
        {
            // Snippet: CreateProperty(Property, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            Property property = new Property();
            // Make the request
            Property response = analyticsAdminServiceClient.CreateProperty(property);
            // End snippet
        }

        /// <summary>Snippet for CreatePropertyAsync</summary>
        public async Task CreatePropertyAsync()
        {
            // Snippet: CreatePropertyAsync(Property, CallSettings)
            // Additional: CreatePropertyAsync(Property, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            Property property = new Property();
            // Make the request
            Property response = await analyticsAdminServiceClient.CreatePropertyAsync(property);
            // End snippet
        }

        /// <summary>Snippet for DeleteProperty</summary>
        public void DeletePropertyRequestObject()
        {
            // Snippet: DeleteProperty(DeletePropertyRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeletePropertyRequest request = new DeletePropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            Property response = analyticsAdminServiceClient.DeleteProperty(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePropertyAsync</summary>
        public async Task DeletePropertyRequestObjectAsync()
        {
            // Snippet: DeletePropertyAsync(DeletePropertyRequest, CallSettings)
            // Additional: DeletePropertyAsync(DeletePropertyRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePropertyRequest request = new DeletePropertyRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            Property response = await analyticsAdminServiceClient.DeletePropertyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteProperty</summary>
        public void DeleteProperty()
        {
            // Snippet: DeleteProperty(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]";
            // Make the request
            Property response = analyticsAdminServiceClient.DeleteProperty(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePropertyAsync</summary>
        public async Task DeletePropertyAsync()
        {
            // Snippet: DeletePropertyAsync(string, CallSettings)
            // Additional: DeletePropertyAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]";
            // Make the request
            Property response = await analyticsAdminServiceClient.DeletePropertyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteProperty</summary>
        public void DeletePropertyResourceNames()
        {
            // Snippet: DeleteProperty(PropertyName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName name = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            Property response = analyticsAdminServiceClient.DeleteProperty(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePropertyAsync</summary>
        public async Task DeletePropertyResourceNamesAsync()
        {
            // Snippet: DeletePropertyAsync(PropertyName, CallSettings)
            // Additional: DeletePropertyAsync(PropertyName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName name = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            Property response = await analyticsAdminServiceClient.DeletePropertyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateProperty</summary>
        public void UpdatePropertyRequestObject()
        {
            // Snippet: UpdateProperty(UpdatePropertyRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdatePropertyRequest request = new UpdatePropertyRequest
            {
                Property = new Property(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Property response = analyticsAdminServiceClient.UpdateProperty(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePropertyAsync</summary>
        public async Task UpdatePropertyRequestObjectAsync()
        {
            // Snippet: UpdatePropertyAsync(UpdatePropertyRequest, CallSettings)
            // Additional: UpdatePropertyAsync(UpdatePropertyRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePropertyRequest request = new UpdatePropertyRequest
            {
                Property = new Property(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Property response = await analyticsAdminServiceClient.UpdatePropertyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateProperty</summary>
        public void UpdateProperty()
        {
            // Snippet: UpdateProperty(Property, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            Property property = new Property();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Property response = analyticsAdminServiceClient.UpdateProperty(property, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePropertyAsync</summary>
        public async Task UpdatePropertyAsync()
        {
            // Snippet: UpdatePropertyAsync(Property, FieldMask, CallSettings)
            // Additional: UpdatePropertyAsync(Property, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            Property property = new Property();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Property response = await analyticsAdminServiceClient.UpdatePropertyAsync(property, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreateFirebaseLink</summary>
        public void CreateFirebaseLinkRequestObject()
        {
            // Snippet: CreateFirebaseLink(CreateFirebaseLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateFirebaseLinkRequest request = new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                FirebaseLink = new FirebaseLink(),
            };
            // Make the request
            FirebaseLink response = analyticsAdminServiceClient.CreateFirebaseLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFirebaseLinkAsync</summary>
        public async Task CreateFirebaseLinkRequestObjectAsync()
        {
            // Snippet: CreateFirebaseLinkAsync(CreateFirebaseLinkRequest, CallSettings)
            // Additional: CreateFirebaseLinkAsync(CreateFirebaseLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateFirebaseLinkRequest request = new CreateFirebaseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                FirebaseLink = new FirebaseLink(),
            };
            // Make the request
            FirebaseLink response = await analyticsAdminServiceClient.CreateFirebaseLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateFirebaseLink</summary>
        public void CreateFirebaseLink()
        {
            // Snippet: CreateFirebaseLink(string, FirebaseLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            FirebaseLink firebaseLink = new FirebaseLink();
            // Make the request
            FirebaseLink response = analyticsAdminServiceClient.CreateFirebaseLink(parent, firebaseLink);
            // End snippet
        }

        /// <summary>Snippet for CreateFirebaseLinkAsync</summary>
        public async Task CreateFirebaseLinkAsync()
        {
            // Snippet: CreateFirebaseLinkAsync(string, FirebaseLink, CallSettings)
            // Additional: CreateFirebaseLinkAsync(string, FirebaseLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            FirebaseLink firebaseLink = new FirebaseLink();
            // Make the request
            FirebaseLink response = await analyticsAdminServiceClient.CreateFirebaseLinkAsync(parent, firebaseLink);
            // End snippet
        }

        /// <summary>Snippet for CreateFirebaseLink</summary>
        public void CreateFirebaseLinkResourceNames()
        {
            // Snippet: CreateFirebaseLink(PropertyName, FirebaseLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            FirebaseLink firebaseLink = new FirebaseLink();
            // Make the request
            FirebaseLink response = analyticsAdminServiceClient.CreateFirebaseLink(parent, firebaseLink);
            // End snippet
        }

        /// <summary>Snippet for CreateFirebaseLinkAsync</summary>
        public async Task CreateFirebaseLinkResourceNamesAsync()
        {
            // Snippet: CreateFirebaseLinkAsync(PropertyName, FirebaseLink, CallSettings)
            // Additional: CreateFirebaseLinkAsync(PropertyName, FirebaseLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            FirebaseLink firebaseLink = new FirebaseLink();
            // Make the request
            FirebaseLink response = await analyticsAdminServiceClient.CreateFirebaseLinkAsync(parent, firebaseLink);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirebaseLink</summary>
        public void DeleteFirebaseLinkRequestObject()
        {
            // Snippet: DeleteFirebaseLink(DeleteFirebaseLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteFirebaseLinkRequest request = new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteFirebaseLink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirebaseLinkAsync</summary>
        public async Task DeleteFirebaseLinkRequestObjectAsync()
        {
            // Snippet: DeleteFirebaseLinkAsync(DeleteFirebaseLinkRequest, CallSettings)
            // Additional: DeleteFirebaseLinkAsync(DeleteFirebaseLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFirebaseLinkRequest request = new DeleteFirebaseLinkRequest
            {
                FirebaseLinkName = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteFirebaseLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirebaseLink</summary>
        public void DeleteFirebaseLink()
        {
            // Snippet: DeleteFirebaseLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/firebaseLinks/[FIREBASE_LINK]";
            // Make the request
            analyticsAdminServiceClient.DeleteFirebaseLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirebaseLinkAsync</summary>
        public async Task DeleteFirebaseLinkAsync()
        {
            // Snippet: DeleteFirebaseLinkAsync(string, CallSettings)
            // Additional: DeleteFirebaseLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/firebaseLinks/[FIREBASE_LINK]";
            // Make the request
            await analyticsAdminServiceClient.DeleteFirebaseLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirebaseLink</summary>
        public void DeleteFirebaseLinkResourceNames()
        {
            // Snippet: DeleteFirebaseLink(FirebaseLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            FirebaseLinkName name = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]");
            // Make the request
            analyticsAdminServiceClient.DeleteFirebaseLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteFirebaseLinkAsync</summary>
        public async Task DeleteFirebaseLinkResourceNamesAsync()
        {
            // Snippet: DeleteFirebaseLinkAsync(FirebaseLinkName, CallSettings)
            // Additional: DeleteFirebaseLinkAsync(FirebaseLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FirebaseLinkName name = FirebaseLinkName.FromPropertyFirebaseLink("[PROPERTY]", "[FIREBASE_LINK]");
            // Make the request
            await analyticsAdminServiceClient.DeleteFirebaseLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListFirebaseLinks</summary>
        public void ListFirebaseLinksRequestObject()
        {
            // Snippet: ListFirebaseLinks(ListFirebaseLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListFirebaseLinksRequest request = new ListFirebaseLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListFirebaseLinksResponse, FirebaseLink> response = analyticsAdminServiceClient.ListFirebaseLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirebaseLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirebaseLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirebaseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirebaseLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirebaseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirebaseLinksAsync</summary>
        public async Task ListFirebaseLinksRequestObjectAsync()
        {
            // Snippet: ListFirebaseLinksAsync(ListFirebaseLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListFirebaseLinksRequest request = new ListFirebaseLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListFirebaseLinksResponse, FirebaseLink> response = analyticsAdminServiceClient.ListFirebaseLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FirebaseLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFirebaseLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirebaseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirebaseLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirebaseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirebaseLinks</summary>
        public void ListFirebaseLinks()
        {
            // Snippet: ListFirebaseLinks(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListFirebaseLinksResponse, FirebaseLink> response = analyticsAdminServiceClient.ListFirebaseLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirebaseLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirebaseLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirebaseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirebaseLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirebaseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirebaseLinksAsync</summary>
        public async Task ListFirebaseLinksAsync()
        {
            // Snippet: ListFirebaseLinksAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListFirebaseLinksResponse, FirebaseLink> response = analyticsAdminServiceClient.ListFirebaseLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FirebaseLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFirebaseLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirebaseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirebaseLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirebaseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirebaseLinks</summary>
        public void ListFirebaseLinksResourceNames()
        {
            // Snippet: ListFirebaseLinks(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListFirebaseLinksResponse, FirebaseLink> response = analyticsAdminServiceClient.ListFirebaseLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirebaseLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListFirebaseLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirebaseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirebaseLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirebaseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListFirebaseLinksAsync</summary>
        public async Task ListFirebaseLinksResourceNamesAsync()
        {
            // Snippet: ListFirebaseLinksAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListFirebaseLinksResponse, FirebaseLink> response = analyticsAdminServiceClient.ListFirebaseLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FirebaseLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListFirebaseLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirebaseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirebaseLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirebaseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSiteTag</summary>
        public void GetGlobalSiteTagRequestObject()
        {
            // Snippet: GetGlobalSiteTag(GetGlobalSiteTagRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetGlobalSiteTagRequest request = new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            GlobalSiteTag response = analyticsAdminServiceClient.GetGlobalSiteTag(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSiteTagAsync</summary>
        public async Task GetGlobalSiteTagRequestObjectAsync()
        {
            // Snippet: GetGlobalSiteTagAsync(GetGlobalSiteTagRequest, CallSettings)
            // Additional: GetGlobalSiteTagAsync(GetGlobalSiteTagRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalSiteTagRequest request = new GetGlobalSiteTagRequest
            {
                GlobalSiteTagName = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            GlobalSiteTag response = await analyticsAdminServiceClient.GetGlobalSiteTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSiteTag</summary>
        public void GetGlobalSiteTag()
        {
            // Snippet: GetGlobalSiteTag(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/globalSiteTag";
            // Make the request
            GlobalSiteTag response = analyticsAdminServiceClient.GetGlobalSiteTag(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSiteTagAsync</summary>
        public async Task GetGlobalSiteTagAsync()
        {
            // Snippet: GetGlobalSiteTagAsync(string, CallSettings)
            // Additional: GetGlobalSiteTagAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/globalSiteTag";
            // Make the request
            GlobalSiteTag response = await analyticsAdminServiceClient.GetGlobalSiteTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSiteTag</summary>
        public void GetGlobalSiteTagResourceNames()
        {
            // Snippet: GetGlobalSiteTag(GlobalSiteTagName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GlobalSiteTagName name = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            GlobalSiteTag response = analyticsAdminServiceClient.GetGlobalSiteTag(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSiteTagAsync</summary>
        public async Task GetGlobalSiteTagResourceNamesAsync()
        {
            // Snippet: GetGlobalSiteTagAsync(GlobalSiteTagName, CallSettings)
            // Additional: GetGlobalSiteTagAsync(GlobalSiteTagName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GlobalSiteTagName name = GlobalSiteTagName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            GlobalSiteTag response = await analyticsAdminServiceClient.GetGlobalSiteTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleAdsLink</summary>
        public void CreateGoogleAdsLinkRequestObject()
        {
            // Snippet: CreateGoogleAdsLink(CreateGoogleAdsLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateGoogleAdsLinkRequest request = new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                GoogleAdsLink = new GoogleAdsLink(),
            };
            // Make the request
            GoogleAdsLink response = analyticsAdminServiceClient.CreateGoogleAdsLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleAdsLinkAsync</summary>
        public async Task CreateGoogleAdsLinkRequestObjectAsync()
        {
            // Snippet: CreateGoogleAdsLinkAsync(CreateGoogleAdsLinkRequest, CallSettings)
            // Additional: CreateGoogleAdsLinkAsync(CreateGoogleAdsLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGoogleAdsLinkRequest request = new CreateGoogleAdsLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                GoogleAdsLink = new GoogleAdsLink(),
            };
            // Make the request
            GoogleAdsLink response = await analyticsAdminServiceClient.CreateGoogleAdsLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleAdsLink</summary>
        public void CreateGoogleAdsLink()
        {
            // Snippet: CreateGoogleAdsLink(string, GoogleAdsLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            GoogleAdsLink googleAdsLink = new GoogleAdsLink();
            // Make the request
            GoogleAdsLink response = analyticsAdminServiceClient.CreateGoogleAdsLink(parent, googleAdsLink);
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleAdsLinkAsync</summary>
        public async Task CreateGoogleAdsLinkAsync()
        {
            // Snippet: CreateGoogleAdsLinkAsync(string, GoogleAdsLink, CallSettings)
            // Additional: CreateGoogleAdsLinkAsync(string, GoogleAdsLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            GoogleAdsLink googleAdsLink = new GoogleAdsLink();
            // Make the request
            GoogleAdsLink response = await analyticsAdminServiceClient.CreateGoogleAdsLinkAsync(parent, googleAdsLink);
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleAdsLink</summary>
        public void CreateGoogleAdsLinkResourceNames()
        {
            // Snippet: CreateGoogleAdsLink(PropertyName, GoogleAdsLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            GoogleAdsLink googleAdsLink = new GoogleAdsLink();
            // Make the request
            GoogleAdsLink response = analyticsAdminServiceClient.CreateGoogleAdsLink(parent, googleAdsLink);
            // End snippet
        }

        /// <summary>Snippet for CreateGoogleAdsLinkAsync</summary>
        public async Task CreateGoogleAdsLinkResourceNamesAsync()
        {
            // Snippet: CreateGoogleAdsLinkAsync(PropertyName, GoogleAdsLink, CallSettings)
            // Additional: CreateGoogleAdsLinkAsync(PropertyName, GoogleAdsLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            GoogleAdsLink googleAdsLink = new GoogleAdsLink();
            // Make the request
            GoogleAdsLink response = await analyticsAdminServiceClient.CreateGoogleAdsLinkAsync(parent, googleAdsLink);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleAdsLink</summary>
        public void UpdateGoogleAdsLinkRequestObject()
        {
            // Snippet: UpdateGoogleAdsLink(UpdateGoogleAdsLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateGoogleAdsLinkRequest request = new UpdateGoogleAdsLinkRequest
            {
                GoogleAdsLink = new GoogleAdsLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GoogleAdsLink response = analyticsAdminServiceClient.UpdateGoogleAdsLink(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleAdsLinkAsync</summary>
        public async Task UpdateGoogleAdsLinkRequestObjectAsync()
        {
            // Snippet: UpdateGoogleAdsLinkAsync(UpdateGoogleAdsLinkRequest, CallSettings)
            // Additional: UpdateGoogleAdsLinkAsync(UpdateGoogleAdsLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGoogleAdsLinkRequest request = new UpdateGoogleAdsLinkRequest
            {
                GoogleAdsLink = new GoogleAdsLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GoogleAdsLink response = await analyticsAdminServiceClient.UpdateGoogleAdsLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleAdsLink</summary>
        public void UpdateGoogleAdsLink()
        {
            // Snippet: UpdateGoogleAdsLink(GoogleAdsLink, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GoogleAdsLink googleAdsLink = new GoogleAdsLink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GoogleAdsLink response = analyticsAdminServiceClient.UpdateGoogleAdsLink(googleAdsLink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleAdsLinkAsync</summary>
        public async Task UpdateGoogleAdsLinkAsync()
        {
            // Snippet: UpdateGoogleAdsLinkAsync(GoogleAdsLink, FieldMask, CallSettings)
            // Additional: UpdateGoogleAdsLinkAsync(GoogleAdsLink, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GoogleAdsLink googleAdsLink = new GoogleAdsLink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GoogleAdsLink response = await analyticsAdminServiceClient.UpdateGoogleAdsLinkAsync(googleAdsLink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleAdsLink</summary>
        public void DeleteGoogleAdsLinkRequestObject()
        {
            // Snippet: DeleteGoogleAdsLink(DeleteGoogleAdsLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteGoogleAdsLinkRequest request = new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteGoogleAdsLink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleAdsLinkAsync</summary>
        public async Task DeleteGoogleAdsLinkRequestObjectAsync()
        {
            // Snippet: DeleteGoogleAdsLinkAsync(DeleteGoogleAdsLinkRequest, CallSettings)
            // Additional: DeleteGoogleAdsLinkAsync(DeleteGoogleAdsLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGoogleAdsLinkRequest request = new DeleteGoogleAdsLinkRequest
            {
                GoogleAdsLinkName = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteGoogleAdsLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleAdsLink</summary>
        public void DeleteGoogleAdsLink()
        {
            // Snippet: DeleteGoogleAdsLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/googleAdsLinks/[GOOGLE_ADS_LINK]";
            // Make the request
            analyticsAdminServiceClient.DeleteGoogleAdsLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleAdsLinkAsync</summary>
        public async Task DeleteGoogleAdsLinkAsync()
        {
            // Snippet: DeleteGoogleAdsLinkAsync(string, CallSettings)
            // Additional: DeleteGoogleAdsLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/googleAdsLinks/[GOOGLE_ADS_LINK]";
            // Make the request
            await analyticsAdminServiceClient.DeleteGoogleAdsLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleAdsLink</summary>
        public void DeleteGoogleAdsLinkResourceNames()
        {
            // Snippet: DeleteGoogleAdsLink(GoogleAdsLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GoogleAdsLinkName name = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]");
            // Make the request
            analyticsAdminServiceClient.DeleteGoogleAdsLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteGoogleAdsLinkAsync</summary>
        public async Task DeleteGoogleAdsLinkResourceNamesAsync()
        {
            // Snippet: DeleteGoogleAdsLinkAsync(GoogleAdsLinkName, CallSettings)
            // Additional: DeleteGoogleAdsLinkAsync(GoogleAdsLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GoogleAdsLinkName name = GoogleAdsLinkName.FromPropertyGoogleAdsLink("[PROPERTY]", "[GOOGLE_ADS_LINK]");
            // Make the request
            await analyticsAdminServiceClient.DeleteGoogleAdsLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListGoogleAdsLinks</summary>
        public void ListGoogleAdsLinksRequestObject()
        {
            // Snippet: ListGoogleAdsLinks(ListGoogleAdsLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListGoogleAdsLinksRequest request = new ListGoogleAdsLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> response = analyticsAdminServiceClient.ListGoogleAdsLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GoogleAdsLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGoogleAdsLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleAdsLinksAsync</summary>
        public async Task ListGoogleAdsLinksRequestObjectAsync()
        {
            // Snippet: ListGoogleAdsLinksAsync(ListGoogleAdsLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGoogleAdsLinksRequest request = new ListGoogleAdsLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> response = analyticsAdminServiceClient.ListGoogleAdsLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GoogleAdsLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGoogleAdsLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleAdsLinks</summary>
        public void ListGoogleAdsLinks()
        {
            // Snippet: ListGoogleAdsLinks(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> response = analyticsAdminServiceClient.ListGoogleAdsLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GoogleAdsLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGoogleAdsLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleAdsLinksAsync</summary>
        public async Task ListGoogleAdsLinksAsync()
        {
            // Snippet: ListGoogleAdsLinksAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> response = analyticsAdminServiceClient.ListGoogleAdsLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GoogleAdsLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGoogleAdsLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleAdsLinks</summary>
        public void ListGoogleAdsLinksResourceNames()
        {
            // Snippet: ListGoogleAdsLinks(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> response = analyticsAdminServiceClient.ListGoogleAdsLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GoogleAdsLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGoogleAdsLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGoogleAdsLinksAsync</summary>
        public async Task ListGoogleAdsLinksResourceNamesAsync()
        {
            // Snippet: ListGoogleAdsLinksAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListGoogleAdsLinksResponse, GoogleAdsLink> response = analyticsAdminServiceClient.ListGoogleAdsLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GoogleAdsLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGoogleAdsLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GoogleAdsLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GoogleAdsLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GoogleAdsLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataSharingSettings</summary>
        public void GetDataSharingSettingsRequestObject()
        {
            // Snippet: GetDataSharingSettings(GetDataSharingSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetDataSharingSettingsRequest request = new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            DataSharingSettings response = analyticsAdminServiceClient.GetDataSharingSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSharingSettingsAsync</summary>
        public async Task GetDataSharingSettingsRequestObjectAsync()
        {
            // Snippet: GetDataSharingSettingsAsync(GetDataSharingSettingsRequest, CallSettings)
            // Additional: GetDataSharingSettingsAsync(GetDataSharingSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataSharingSettingsRequest request = new GetDataSharingSettingsRequest
            {
                DataSharingSettingsName = DataSharingSettingsName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            DataSharingSettings response = await analyticsAdminServiceClient.GetDataSharingSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSharingSettings</summary>
        public void GetDataSharingSettings()
        {
            // Snippet: GetDataSharingSettings(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/dataSharingSettings";
            // Make the request
            DataSharingSettings response = analyticsAdminServiceClient.GetDataSharingSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSharingSettingsAsync</summary>
        public async Task GetDataSharingSettingsAsync()
        {
            // Snippet: GetDataSharingSettingsAsync(string, CallSettings)
            // Additional: GetDataSharingSettingsAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/dataSharingSettings";
            // Make the request
            DataSharingSettings response = await analyticsAdminServiceClient.GetDataSharingSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSharingSettings</summary>
        public void GetDataSharingSettingsResourceNames()
        {
            // Snippet: GetDataSharingSettings(DataSharingSettingsName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataSharingSettingsName name = DataSharingSettingsName.FromAccount("[ACCOUNT]");
            // Make the request
            DataSharingSettings response = analyticsAdminServiceClient.GetDataSharingSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSharingSettingsAsync</summary>
        public async Task GetDataSharingSettingsResourceNamesAsync()
        {
            // Snippet: GetDataSharingSettingsAsync(DataSharingSettingsName, CallSettings)
            // Additional: GetDataSharingSettingsAsync(DataSharingSettingsName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataSharingSettingsName name = DataSharingSettingsName.FromAccount("[ACCOUNT]");
            // Make the request
            DataSharingSettings response = await analyticsAdminServiceClient.GetDataSharingSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeasurementProtocolSecret</summary>
        public void GetMeasurementProtocolSecretRequestObject()
        {
            // Snippet: GetMeasurementProtocolSecret(GetMeasurementProtocolSecretRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetMeasurementProtocolSecretRequest request = new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            // Make the request
            MeasurementProtocolSecret response = analyticsAdminServiceClient.GetMeasurementProtocolSecret(request);
            // End snippet
        }

        /// <summary>Snippet for GetMeasurementProtocolSecretAsync</summary>
        public async Task GetMeasurementProtocolSecretRequestObjectAsync()
        {
            // Snippet: GetMeasurementProtocolSecretAsync(GetMeasurementProtocolSecretRequest, CallSettings)
            // Additional: GetMeasurementProtocolSecretAsync(GetMeasurementProtocolSecretRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMeasurementProtocolSecretRequest request = new GetMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            // Make the request
            MeasurementProtocolSecret response = await analyticsAdminServiceClient.GetMeasurementProtocolSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMeasurementProtocolSecret</summary>
        public void GetMeasurementProtocolSecret()
        {
            // Snippet: GetMeasurementProtocolSecret(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/measurementProtocolSecrets/[MEASUREMENT_PROTOCOL_SECRET]";
            // Make the request
            MeasurementProtocolSecret response = analyticsAdminServiceClient.GetMeasurementProtocolSecret(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeasurementProtocolSecretAsync</summary>
        public async Task GetMeasurementProtocolSecretAsync()
        {
            // Snippet: GetMeasurementProtocolSecretAsync(string, CallSettings)
            // Additional: GetMeasurementProtocolSecretAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/measurementProtocolSecrets/[MEASUREMENT_PROTOCOL_SECRET]";
            // Make the request
            MeasurementProtocolSecret response = await analyticsAdminServiceClient.GetMeasurementProtocolSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeasurementProtocolSecret</summary>
        public void GetMeasurementProtocolSecretResourceNames()
        {
            // Snippet: GetMeasurementProtocolSecret(MeasurementProtocolSecretName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            MeasurementProtocolSecretName name = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]");
            // Make the request
            MeasurementProtocolSecret response = analyticsAdminServiceClient.GetMeasurementProtocolSecret(name);
            // End snippet
        }

        /// <summary>Snippet for GetMeasurementProtocolSecretAsync</summary>
        public async Task GetMeasurementProtocolSecretResourceNamesAsync()
        {
            // Snippet: GetMeasurementProtocolSecretAsync(MeasurementProtocolSecretName, CallSettings)
            // Additional: GetMeasurementProtocolSecretAsync(MeasurementProtocolSecretName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            MeasurementProtocolSecretName name = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]");
            // Make the request
            MeasurementProtocolSecret response = await analyticsAdminServiceClient.GetMeasurementProtocolSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMeasurementProtocolSecrets</summary>
        public void ListMeasurementProtocolSecretsRequestObject()
        {
            // Snippet: ListMeasurementProtocolSecrets(ListMeasurementProtocolSecretsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListMeasurementProtocolSecretsRequest request = new ListMeasurementProtocolSecretsRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            PagedEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> response = analyticsAdminServiceClient.ListMeasurementProtocolSecrets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MeasurementProtocolSecret item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMeasurementProtocolSecretsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeasurementProtocolSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeasurementProtocolSecret> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeasurementProtocolSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeasurementProtocolSecretsAsync</summary>
        public async Task ListMeasurementProtocolSecretsRequestObjectAsync()
        {
            // Snippet: ListMeasurementProtocolSecretsAsync(ListMeasurementProtocolSecretsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMeasurementProtocolSecretsRequest request = new ListMeasurementProtocolSecretsRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> response = analyticsAdminServiceClient.ListMeasurementProtocolSecretsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MeasurementProtocolSecret item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMeasurementProtocolSecretsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeasurementProtocolSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeasurementProtocolSecret> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeasurementProtocolSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeasurementProtocolSecrets</summary>
        public void ListMeasurementProtocolSecrets()
        {
            // Snippet: ListMeasurementProtocolSecrets(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            PagedEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> response = analyticsAdminServiceClient.ListMeasurementProtocolSecrets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MeasurementProtocolSecret item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMeasurementProtocolSecretsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeasurementProtocolSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeasurementProtocolSecret> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeasurementProtocolSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeasurementProtocolSecretsAsync</summary>
        public async Task ListMeasurementProtocolSecretsAsync()
        {
            // Snippet: ListMeasurementProtocolSecretsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            PagedAsyncEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> response = analyticsAdminServiceClient.ListMeasurementProtocolSecretsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MeasurementProtocolSecret item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMeasurementProtocolSecretsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeasurementProtocolSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeasurementProtocolSecret> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeasurementProtocolSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeasurementProtocolSecrets</summary>
        public void ListMeasurementProtocolSecretsResourceNames()
        {
            // Snippet: ListMeasurementProtocolSecrets(DataStreamName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            PagedEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> response = analyticsAdminServiceClient.ListMeasurementProtocolSecrets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MeasurementProtocolSecret item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMeasurementProtocolSecretsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeasurementProtocolSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeasurementProtocolSecret> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeasurementProtocolSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMeasurementProtocolSecretsAsync</summary>
        public async Task ListMeasurementProtocolSecretsResourceNamesAsync()
        {
            // Snippet: ListMeasurementProtocolSecretsAsync(DataStreamName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            PagedAsyncEnumerable<ListMeasurementProtocolSecretsResponse, MeasurementProtocolSecret> response = analyticsAdminServiceClient.ListMeasurementProtocolSecretsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MeasurementProtocolSecret item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMeasurementProtocolSecretsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MeasurementProtocolSecret item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MeasurementProtocolSecret> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MeasurementProtocolSecret item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateMeasurementProtocolSecret</summary>
        public void CreateMeasurementProtocolSecretRequestObject()
        {
            // Snippet: CreateMeasurementProtocolSecret(CreateMeasurementProtocolSecretRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateMeasurementProtocolSecretRequest request = new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
            };
            // Make the request
            MeasurementProtocolSecret response = analyticsAdminServiceClient.CreateMeasurementProtocolSecret(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMeasurementProtocolSecretAsync</summary>
        public async Task CreateMeasurementProtocolSecretRequestObjectAsync()
        {
            // Snippet: CreateMeasurementProtocolSecretAsync(CreateMeasurementProtocolSecretRequest, CallSettings)
            // Additional: CreateMeasurementProtocolSecretAsync(CreateMeasurementProtocolSecretRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMeasurementProtocolSecretRequest request = new CreateMeasurementProtocolSecretRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
            };
            // Make the request
            MeasurementProtocolSecret response = await analyticsAdminServiceClient.CreateMeasurementProtocolSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMeasurementProtocolSecret</summary>
        public void CreateMeasurementProtocolSecret()
        {
            // Snippet: CreateMeasurementProtocolSecret(string, MeasurementProtocolSecret, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            MeasurementProtocolSecret measurementProtocolSecret = new MeasurementProtocolSecret();
            // Make the request
            MeasurementProtocolSecret response = analyticsAdminServiceClient.CreateMeasurementProtocolSecret(parent, measurementProtocolSecret);
            // End snippet
        }

        /// <summary>Snippet for CreateMeasurementProtocolSecretAsync</summary>
        public async Task CreateMeasurementProtocolSecretAsync()
        {
            // Snippet: CreateMeasurementProtocolSecretAsync(string, MeasurementProtocolSecret, CallSettings)
            // Additional: CreateMeasurementProtocolSecretAsync(string, MeasurementProtocolSecret, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            MeasurementProtocolSecret measurementProtocolSecret = new MeasurementProtocolSecret();
            // Make the request
            MeasurementProtocolSecret response = await analyticsAdminServiceClient.CreateMeasurementProtocolSecretAsync(parent, measurementProtocolSecret);
            // End snippet
        }

        /// <summary>Snippet for CreateMeasurementProtocolSecret</summary>
        public void CreateMeasurementProtocolSecretResourceNames()
        {
            // Snippet: CreateMeasurementProtocolSecret(DataStreamName, MeasurementProtocolSecret, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            MeasurementProtocolSecret measurementProtocolSecret = new MeasurementProtocolSecret();
            // Make the request
            MeasurementProtocolSecret response = analyticsAdminServiceClient.CreateMeasurementProtocolSecret(parent, measurementProtocolSecret);
            // End snippet
        }

        /// <summary>Snippet for CreateMeasurementProtocolSecretAsync</summary>
        public async Task CreateMeasurementProtocolSecretResourceNamesAsync()
        {
            // Snippet: CreateMeasurementProtocolSecretAsync(DataStreamName, MeasurementProtocolSecret, CallSettings)
            // Additional: CreateMeasurementProtocolSecretAsync(DataStreamName, MeasurementProtocolSecret, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            MeasurementProtocolSecret measurementProtocolSecret = new MeasurementProtocolSecret();
            // Make the request
            MeasurementProtocolSecret response = await analyticsAdminServiceClient.CreateMeasurementProtocolSecretAsync(parent, measurementProtocolSecret);
            // End snippet
        }

        /// <summary>Snippet for DeleteMeasurementProtocolSecret</summary>
        public void DeleteMeasurementProtocolSecretRequestObject()
        {
            // Snippet: DeleteMeasurementProtocolSecret(DeleteMeasurementProtocolSecretRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteMeasurementProtocolSecretRequest request = new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteMeasurementProtocolSecret(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMeasurementProtocolSecretAsync</summary>
        public async Task DeleteMeasurementProtocolSecretRequestObjectAsync()
        {
            // Snippet: DeleteMeasurementProtocolSecretAsync(DeleteMeasurementProtocolSecretRequest, CallSettings)
            // Additional: DeleteMeasurementProtocolSecretAsync(DeleteMeasurementProtocolSecretRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMeasurementProtocolSecretRequest request = new DeleteMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecretName = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteMeasurementProtocolSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMeasurementProtocolSecret</summary>
        public void DeleteMeasurementProtocolSecret()
        {
            // Snippet: DeleteMeasurementProtocolSecret(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/measurementProtocolSecrets/[MEASUREMENT_PROTOCOL_SECRET]";
            // Make the request
            analyticsAdminServiceClient.DeleteMeasurementProtocolSecret(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMeasurementProtocolSecretAsync</summary>
        public async Task DeleteMeasurementProtocolSecretAsync()
        {
            // Snippet: DeleteMeasurementProtocolSecretAsync(string, CallSettings)
            // Additional: DeleteMeasurementProtocolSecretAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/measurementProtocolSecrets/[MEASUREMENT_PROTOCOL_SECRET]";
            // Make the request
            await analyticsAdminServiceClient.DeleteMeasurementProtocolSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMeasurementProtocolSecret</summary>
        public void DeleteMeasurementProtocolSecretResourceNames()
        {
            // Snippet: DeleteMeasurementProtocolSecret(MeasurementProtocolSecretName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            MeasurementProtocolSecretName name = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]");
            // Make the request
            analyticsAdminServiceClient.DeleteMeasurementProtocolSecret(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMeasurementProtocolSecretAsync</summary>
        public async Task DeleteMeasurementProtocolSecretResourceNamesAsync()
        {
            // Snippet: DeleteMeasurementProtocolSecretAsync(MeasurementProtocolSecretName, CallSettings)
            // Additional: DeleteMeasurementProtocolSecretAsync(MeasurementProtocolSecretName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            MeasurementProtocolSecretName name = MeasurementProtocolSecretName.FromPropertyDataStreamMeasurementProtocolSecret("[PROPERTY]", "[DATA_STREAM]", "[MEASUREMENT_PROTOCOL_SECRET]");
            // Make the request
            await analyticsAdminServiceClient.DeleteMeasurementProtocolSecretAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateMeasurementProtocolSecret</summary>
        public void UpdateMeasurementProtocolSecretRequestObject()
        {
            // Snippet: UpdateMeasurementProtocolSecret(UpdateMeasurementProtocolSecretRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateMeasurementProtocolSecretRequest request = new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            MeasurementProtocolSecret response = analyticsAdminServiceClient.UpdateMeasurementProtocolSecret(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMeasurementProtocolSecretAsync</summary>
        public async Task UpdateMeasurementProtocolSecretRequestObjectAsync()
        {
            // Snippet: UpdateMeasurementProtocolSecretAsync(UpdateMeasurementProtocolSecretRequest, CallSettings)
            // Additional: UpdateMeasurementProtocolSecretAsync(UpdateMeasurementProtocolSecretRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMeasurementProtocolSecretRequest request = new UpdateMeasurementProtocolSecretRequest
            {
                MeasurementProtocolSecret = new MeasurementProtocolSecret(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            MeasurementProtocolSecret response = await analyticsAdminServiceClient.UpdateMeasurementProtocolSecretAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMeasurementProtocolSecret</summary>
        public void UpdateMeasurementProtocolSecret()
        {
            // Snippet: UpdateMeasurementProtocolSecret(MeasurementProtocolSecret, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            MeasurementProtocolSecret measurementProtocolSecret = new MeasurementProtocolSecret();
            FieldMask updateMask = new FieldMask();
            // Make the request
            MeasurementProtocolSecret response = analyticsAdminServiceClient.UpdateMeasurementProtocolSecret(measurementProtocolSecret, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateMeasurementProtocolSecretAsync</summary>
        public async Task UpdateMeasurementProtocolSecretAsync()
        {
            // Snippet: UpdateMeasurementProtocolSecretAsync(MeasurementProtocolSecret, FieldMask, CallSettings)
            // Additional: UpdateMeasurementProtocolSecretAsync(MeasurementProtocolSecret, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            MeasurementProtocolSecret measurementProtocolSecret = new MeasurementProtocolSecret();
            FieldMask updateMask = new FieldMask();
            // Make the request
            MeasurementProtocolSecret response = await analyticsAdminServiceClient.UpdateMeasurementProtocolSecretAsync(measurementProtocolSecret, updateMask);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeUserDataCollection</summary>
        public void AcknowledgeUserDataCollectionRequestObject()
        {
            // Snippet: AcknowledgeUserDataCollection(AcknowledgeUserDataCollectionRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AcknowledgeUserDataCollectionRequest request = new AcknowledgeUserDataCollectionRequest
            {
                PropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Acknowledgement = "",
            };
            // Make the request
            AcknowledgeUserDataCollectionResponse response = analyticsAdminServiceClient.AcknowledgeUserDataCollection(request);
            // End snippet
        }

        /// <summary>Snippet for AcknowledgeUserDataCollectionAsync</summary>
        public async Task AcknowledgeUserDataCollectionRequestObjectAsync()
        {
            // Snippet: AcknowledgeUserDataCollectionAsync(AcknowledgeUserDataCollectionRequest, CallSettings)
            // Additional: AcknowledgeUserDataCollectionAsync(AcknowledgeUserDataCollectionRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AcknowledgeUserDataCollectionRequest request = new AcknowledgeUserDataCollectionRequest
            {
                PropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Acknowledgement = "",
            };
            // Make the request
            AcknowledgeUserDataCollectionResponse response = await analyticsAdminServiceClient.AcknowledgeUserDataCollectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSKAdNetworkConversionValueSchema</summary>
        public void GetSKAdNetworkConversionValueSchemaRequestObject()
        {
            // Snippet: GetSKAdNetworkConversionValueSchema(GetSKAdNetworkConversionValueSchemaRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetSKAdNetworkConversionValueSchemaRequest request = new GetSKAdNetworkConversionValueSchemaRequest
            {
                SKAdNetworkConversionValueSchemaName = SKAdNetworkConversionValueSchemaName.FromPropertyDataStreamSkadnetworkConversionValueSchema("[PROPERTY]", "[DATA_STREAM]", "[SKADNETWORK_CONVERSION_VALUE_SCHEMA]"),
            };
            // Make the request
            SKAdNetworkConversionValueSchema response = analyticsAdminServiceClient.GetSKAdNetworkConversionValueSchema(request);
            // End snippet
        }

        /// <summary>Snippet for GetSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task GetSKAdNetworkConversionValueSchemaRequestObjectAsync()
        {
            // Snippet: GetSKAdNetworkConversionValueSchemaAsync(GetSKAdNetworkConversionValueSchemaRequest, CallSettings)
            // Additional: GetSKAdNetworkConversionValueSchemaAsync(GetSKAdNetworkConversionValueSchemaRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSKAdNetworkConversionValueSchemaRequest request = new GetSKAdNetworkConversionValueSchemaRequest
            {
                SKAdNetworkConversionValueSchemaName = SKAdNetworkConversionValueSchemaName.FromPropertyDataStreamSkadnetworkConversionValueSchema("[PROPERTY]", "[DATA_STREAM]", "[SKADNETWORK_CONVERSION_VALUE_SCHEMA]"),
            };
            // Make the request
            SKAdNetworkConversionValueSchema response = await analyticsAdminServiceClient.GetSKAdNetworkConversionValueSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSKAdNetworkConversionValueSchema</summary>
        public void GetSKAdNetworkConversionValueSchema()
        {
            // Snippet: GetSKAdNetworkConversionValueSchema(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/sKAdNetworkConversionValueSchema/[SKADNETWORK_CONVERSION_VALUE_SCHEMA]";
            // Make the request
            SKAdNetworkConversionValueSchema response = analyticsAdminServiceClient.GetSKAdNetworkConversionValueSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task GetSKAdNetworkConversionValueSchemaAsync()
        {
            // Snippet: GetSKAdNetworkConversionValueSchemaAsync(string, CallSettings)
            // Additional: GetSKAdNetworkConversionValueSchemaAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/sKAdNetworkConversionValueSchema/[SKADNETWORK_CONVERSION_VALUE_SCHEMA]";
            // Make the request
            SKAdNetworkConversionValueSchema response = await analyticsAdminServiceClient.GetSKAdNetworkConversionValueSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSKAdNetworkConversionValueSchema</summary>
        public void GetSKAdNetworkConversionValueSchemaResourceNames()
        {
            // Snippet: GetSKAdNetworkConversionValueSchema(SKAdNetworkConversionValueSchemaName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SKAdNetworkConversionValueSchemaName name = SKAdNetworkConversionValueSchemaName.FromPropertyDataStreamSkadnetworkConversionValueSchema("[PROPERTY]", "[DATA_STREAM]", "[SKADNETWORK_CONVERSION_VALUE_SCHEMA]");
            // Make the request
            SKAdNetworkConversionValueSchema response = analyticsAdminServiceClient.GetSKAdNetworkConversionValueSchema(name);
            // End snippet
        }

        /// <summary>Snippet for GetSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task GetSKAdNetworkConversionValueSchemaResourceNamesAsync()
        {
            // Snippet: GetSKAdNetworkConversionValueSchemaAsync(SKAdNetworkConversionValueSchemaName, CallSettings)
            // Additional: GetSKAdNetworkConversionValueSchemaAsync(SKAdNetworkConversionValueSchemaName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SKAdNetworkConversionValueSchemaName name = SKAdNetworkConversionValueSchemaName.FromPropertyDataStreamSkadnetworkConversionValueSchema("[PROPERTY]", "[DATA_STREAM]", "[SKADNETWORK_CONVERSION_VALUE_SCHEMA]");
            // Make the request
            SKAdNetworkConversionValueSchema response = await analyticsAdminServiceClient.GetSKAdNetworkConversionValueSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSKAdNetworkConversionValueSchema</summary>
        public void CreateSKAdNetworkConversionValueSchemaRequestObject()
        {
            // Snippet: CreateSKAdNetworkConversionValueSchema(CreateSKAdNetworkConversionValueSchemaRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateSKAdNetworkConversionValueSchemaRequest request = new CreateSKAdNetworkConversionValueSchemaRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                SkadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema(),
            };
            // Make the request
            SKAdNetworkConversionValueSchema response = analyticsAdminServiceClient.CreateSKAdNetworkConversionValueSchema(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task CreateSKAdNetworkConversionValueSchemaRequestObjectAsync()
        {
            // Snippet: CreateSKAdNetworkConversionValueSchemaAsync(CreateSKAdNetworkConversionValueSchemaRequest, CallSettings)
            // Additional: CreateSKAdNetworkConversionValueSchemaAsync(CreateSKAdNetworkConversionValueSchemaRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSKAdNetworkConversionValueSchemaRequest request = new CreateSKAdNetworkConversionValueSchemaRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                SkadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema(),
            };
            // Make the request
            SKAdNetworkConversionValueSchema response = await analyticsAdminServiceClient.CreateSKAdNetworkConversionValueSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSKAdNetworkConversionValueSchema</summary>
        public void CreateSKAdNetworkConversionValueSchema()
        {
            // Snippet: CreateSKAdNetworkConversionValueSchema(string, SKAdNetworkConversionValueSchema, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            SKAdNetworkConversionValueSchema skadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema();
            // Make the request
            SKAdNetworkConversionValueSchema response = analyticsAdminServiceClient.CreateSKAdNetworkConversionValueSchema(parent, skadnetworkConversionValueSchema);
            // End snippet
        }

        /// <summary>Snippet for CreateSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task CreateSKAdNetworkConversionValueSchemaAsync()
        {
            // Snippet: CreateSKAdNetworkConversionValueSchemaAsync(string, SKAdNetworkConversionValueSchema, CallSettings)
            // Additional: CreateSKAdNetworkConversionValueSchemaAsync(string, SKAdNetworkConversionValueSchema, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            SKAdNetworkConversionValueSchema skadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema();
            // Make the request
            SKAdNetworkConversionValueSchema response = await analyticsAdminServiceClient.CreateSKAdNetworkConversionValueSchemaAsync(parent, skadnetworkConversionValueSchema);
            // End snippet
        }

        /// <summary>Snippet for CreateSKAdNetworkConversionValueSchema</summary>
        public void CreateSKAdNetworkConversionValueSchemaResourceNames()
        {
            // Snippet: CreateSKAdNetworkConversionValueSchema(DataStreamName, SKAdNetworkConversionValueSchema, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            SKAdNetworkConversionValueSchema skadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema();
            // Make the request
            SKAdNetworkConversionValueSchema response = analyticsAdminServiceClient.CreateSKAdNetworkConversionValueSchema(parent, skadnetworkConversionValueSchema);
            // End snippet
        }

        /// <summary>Snippet for CreateSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task CreateSKAdNetworkConversionValueSchemaResourceNamesAsync()
        {
            // Snippet: CreateSKAdNetworkConversionValueSchemaAsync(DataStreamName, SKAdNetworkConversionValueSchema, CallSettings)
            // Additional: CreateSKAdNetworkConversionValueSchemaAsync(DataStreamName, SKAdNetworkConversionValueSchema, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            SKAdNetworkConversionValueSchema skadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema();
            // Make the request
            SKAdNetworkConversionValueSchema response = await analyticsAdminServiceClient.CreateSKAdNetworkConversionValueSchemaAsync(parent, skadnetworkConversionValueSchema);
            // End snippet
        }

        /// <summary>Snippet for DeleteSKAdNetworkConversionValueSchema</summary>
        public void DeleteSKAdNetworkConversionValueSchemaRequestObject()
        {
            // Snippet: DeleteSKAdNetworkConversionValueSchema(DeleteSKAdNetworkConversionValueSchemaRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteSKAdNetworkConversionValueSchemaRequest request = new DeleteSKAdNetworkConversionValueSchemaRequest
            {
                SKAdNetworkConversionValueSchemaName = SKAdNetworkConversionValueSchemaName.FromPropertyDataStreamSkadnetworkConversionValueSchema("[PROPERTY]", "[DATA_STREAM]", "[SKADNETWORK_CONVERSION_VALUE_SCHEMA]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteSKAdNetworkConversionValueSchema(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task DeleteSKAdNetworkConversionValueSchemaRequestObjectAsync()
        {
            // Snippet: DeleteSKAdNetworkConversionValueSchemaAsync(DeleteSKAdNetworkConversionValueSchemaRequest, CallSettings)
            // Additional: DeleteSKAdNetworkConversionValueSchemaAsync(DeleteSKAdNetworkConversionValueSchemaRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSKAdNetworkConversionValueSchemaRequest request = new DeleteSKAdNetworkConversionValueSchemaRequest
            {
                SKAdNetworkConversionValueSchemaName = SKAdNetworkConversionValueSchemaName.FromPropertyDataStreamSkadnetworkConversionValueSchema("[PROPERTY]", "[DATA_STREAM]", "[SKADNETWORK_CONVERSION_VALUE_SCHEMA]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteSKAdNetworkConversionValueSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSKAdNetworkConversionValueSchema</summary>
        public void DeleteSKAdNetworkConversionValueSchema()
        {
            // Snippet: DeleteSKAdNetworkConversionValueSchema(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/sKAdNetworkConversionValueSchema/[SKADNETWORK_CONVERSION_VALUE_SCHEMA]";
            // Make the request
            analyticsAdminServiceClient.DeleteSKAdNetworkConversionValueSchema(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task DeleteSKAdNetworkConversionValueSchemaAsync()
        {
            // Snippet: DeleteSKAdNetworkConversionValueSchemaAsync(string, CallSettings)
            // Additional: DeleteSKAdNetworkConversionValueSchemaAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/sKAdNetworkConversionValueSchema/[SKADNETWORK_CONVERSION_VALUE_SCHEMA]";
            // Make the request
            await analyticsAdminServiceClient.DeleteSKAdNetworkConversionValueSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSKAdNetworkConversionValueSchema</summary>
        public void DeleteSKAdNetworkConversionValueSchemaResourceNames()
        {
            // Snippet: DeleteSKAdNetworkConversionValueSchema(SKAdNetworkConversionValueSchemaName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SKAdNetworkConversionValueSchemaName name = SKAdNetworkConversionValueSchemaName.FromPropertyDataStreamSkadnetworkConversionValueSchema("[PROPERTY]", "[DATA_STREAM]", "[SKADNETWORK_CONVERSION_VALUE_SCHEMA]");
            // Make the request
            analyticsAdminServiceClient.DeleteSKAdNetworkConversionValueSchema(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task DeleteSKAdNetworkConversionValueSchemaResourceNamesAsync()
        {
            // Snippet: DeleteSKAdNetworkConversionValueSchemaAsync(SKAdNetworkConversionValueSchemaName, CallSettings)
            // Additional: DeleteSKAdNetworkConversionValueSchemaAsync(SKAdNetworkConversionValueSchemaName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SKAdNetworkConversionValueSchemaName name = SKAdNetworkConversionValueSchemaName.FromPropertyDataStreamSkadnetworkConversionValueSchema("[PROPERTY]", "[DATA_STREAM]", "[SKADNETWORK_CONVERSION_VALUE_SCHEMA]");
            // Make the request
            await analyticsAdminServiceClient.DeleteSKAdNetworkConversionValueSchemaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSKAdNetworkConversionValueSchema</summary>
        public void UpdateSKAdNetworkConversionValueSchemaRequestObject()
        {
            // Snippet: UpdateSKAdNetworkConversionValueSchema(UpdateSKAdNetworkConversionValueSchemaRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateSKAdNetworkConversionValueSchemaRequest request = new UpdateSKAdNetworkConversionValueSchemaRequest
            {
                SkadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SKAdNetworkConversionValueSchema response = analyticsAdminServiceClient.UpdateSKAdNetworkConversionValueSchema(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task UpdateSKAdNetworkConversionValueSchemaRequestObjectAsync()
        {
            // Snippet: UpdateSKAdNetworkConversionValueSchemaAsync(UpdateSKAdNetworkConversionValueSchemaRequest, CallSettings)
            // Additional: UpdateSKAdNetworkConversionValueSchemaAsync(UpdateSKAdNetworkConversionValueSchemaRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSKAdNetworkConversionValueSchemaRequest request = new UpdateSKAdNetworkConversionValueSchemaRequest
            {
                SkadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SKAdNetworkConversionValueSchema response = await analyticsAdminServiceClient.UpdateSKAdNetworkConversionValueSchemaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSKAdNetworkConversionValueSchema</summary>
        public void UpdateSKAdNetworkConversionValueSchema()
        {
            // Snippet: UpdateSKAdNetworkConversionValueSchema(SKAdNetworkConversionValueSchema, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SKAdNetworkConversionValueSchema skadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SKAdNetworkConversionValueSchema response = analyticsAdminServiceClient.UpdateSKAdNetworkConversionValueSchema(skadnetworkConversionValueSchema, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSKAdNetworkConversionValueSchemaAsync</summary>
        public async Task UpdateSKAdNetworkConversionValueSchemaAsync()
        {
            // Snippet: UpdateSKAdNetworkConversionValueSchemaAsync(SKAdNetworkConversionValueSchema, FieldMask, CallSettings)
            // Additional: UpdateSKAdNetworkConversionValueSchemaAsync(SKAdNetworkConversionValueSchema, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SKAdNetworkConversionValueSchema skadnetworkConversionValueSchema = new SKAdNetworkConversionValueSchema();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SKAdNetworkConversionValueSchema response = await analyticsAdminServiceClient.UpdateSKAdNetworkConversionValueSchemaAsync(skadnetworkConversionValueSchema, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListSKAdNetworkConversionValueSchemas</summary>
        public void ListSKAdNetworkConversionValueSchemasRequestObject()
        {
            // Snippet: ListSKAdNetworkConversionValueSchemas(ListSKAdNetworkConversionValueSchemasRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListSKAdNetworkConversionValueSchemasRequest request = new ListSKAdNetworkConversionValueSchemasRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            PagedEnumerable<ListSKAdNetworkConversionValueSchemasResponse, SKAdNetworkConversionValueSchema> response = analyticsAdminServiceClient.ListSKAdNetworkConversionValueSchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SKAdNetworkConversionValueSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSKAdNetworkConversionValueSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SKAdNetworkConversionValueSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SKAdNetworkConversionValueSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SKAdNetworkConversionValueSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSKAdNetworkConversionValueSchemasAsync</summary>
        public async Task ListSKAdNetworkConversionValueSchemasRequestObjectAsync()
        {
            // Snippet: ListSKAdNetworkConversionValueSchemasAsync(ListSKAdNetworkConversionValueSchemasRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSKAdNetworkConversionValueSchemasRequest request = new ListSKAdNetworkConversionValueSchemasRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSKAdNetworkConversionValueSchemasResponse, SKAdNetworkConversionValueSchema> response = analyticsAdminServiceClient.ListSKAdNetworkConversionValueSchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SKAdNetworkConversionValueSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSKAdNetworkConversionValueSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SKAdNetworkConversionValueSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SKAdNetworkConversionValueSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SKAdNetworkConversionValueSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSKAdNetworkConversionValueSchemas</summary>
        public void ListSKAdNetworkConversionValueSchemas()
        {
            // Snippet: ListSKAdNetworkConversionValueSchemas(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            PagedEnumerable<ListSKAdNetworkConversionValueSchemasResponse, SKAdNetworkConversionValueSchema> response = analyticsAdminServiceClient.ListSKAdNetworkConversionValueSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SKAdNetworkConversionValueSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSKAdNetworkConversionValueSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SKAdNetworkConversionValueSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SKAdNetworkConversionValueSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SKAdNetworkConversionValueSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSKAdNetworkConversionValueSchemasAsync</summary>
        public async Task ListSKAdNetworkConversionValueSchemasAsync()
        {
            // Snippet: ListSKAdNetworkConversionValueSchemasAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            PagedAsyncEnumerable<ListSKAdNetworkConversionValueSchemasResponse, SKAdNetworkConversionValueSchema> response = analyticsAdminServiceClient.ListSKAdNetworkConversionValueSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SKAdNetworkConversionValueSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSKAdNetworkConversionValueSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SKAdNetworkConversionValueSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SKAdNetworkConversionValueSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SKAdNetworkConversionValueSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSKAdNetworkConversionValueSchemas</summary>
        public void ListSKAdNetworkConversionValueSchemasResourceNames()
        {
            // Snippet: ListSKAdNetworkConversionValueSchemas(DataStreamName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            PagedEnumerable<ListSKAdNetworkConversionValueSchemasResponse, SKAdNetworkConversionValueSchema> response = analyticsAdminServiceClient.ListSKAdNetworkConversionValueSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SKAdNetworkConversionValueSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSKAdNetworkConversionValueSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SKAdNetworkConversionValueSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SKAdNetworkConversionValueSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SKAdNetworkConversionValueSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSKAdNetworkConversionValueSchemasAsync</summary>
        public async Task ListSKAdNetworkConversionValueSchemasResourceNamesAsync()
        {
            // Snippet: ListSKAdNetworkConversionValueSchemasAsync(DataStreamName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            PagedAsyncEnumerable<ListSKAdNetworkConversionValueSchemasResponse, SKAdNetworkConversionValueSchema> response = analyticsAdminServiceClient.ListSKAdNetworkConversionValueSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SKAdNetworkConversionValueSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSKAdNetworkConversionValueSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SKAdNetworkConversionValueSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SKAdNetworkConversionValueSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SKAdNetworkConversionValueSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchChangeHistoryEvents</summary>
        public void SearchChangeHistoryEventsRequestObject()
        {
            // Snippet: SearchChangeHistoryEvents(SearchChangeHistoryEventsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SearchChangeHistoryEventsRequest request = new SearchChangeHistoryEventsRequest
            {
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                PropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                ResourceType =
                {
                    ChangeHistoryResourceType.Unspecified,
                },
                Action =
                {
                    ActionType.Unspecified,
                },
                ActorEmail = { "", },
                EarliestChangeTime = new Timestamp(),
                LatestChangeTime = new Timestamp(),
            };
            // Make the request
            PagedEnumerable<SearchChangeHistoryEventsResponse, ChangeHistoryEvent> response = analyticsAdminServiceClient.SearchChangeHistoryEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChangeHistoryEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchChangeHistoryEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeHistoryEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeHistoryEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeHistoryEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchChangeHistoryEventsAsync</summary>
        public async Task SearchChangeHistoryEventsRequestObjectAsync()
        {
            // Snippet: SearchChangeHistoryEventsAsync(SearchChangeHistoryEventsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchChangeHistoryEventsRequest request = new SearchChangeHistoryEventsRequest
            {
                AccountAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                PropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                ResourceType =
                {
                    ChangeHistoryResourceType.Unspecified,
                },
                Action =
                {
                    ActionType.Unspecified,
                },
                ActorEmail = { "", },
                EarliestChangeTime = new Timestamp(),
                LatestChangeTime = new Timestamp(),
            };
            // Make the request
            PagedAsyncEnumerable<SearchChangeHistoryEventsResponse, ChangeHistoryEvent> response = analyticsAdminServiceClient.SearchChangeHistoryEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChangeHistoryEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchChangeHistoryEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeHistoryEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeHistoryEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeHistoryEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGoogleSignalsSettings</summary>
        public void GetGoogleSignalsSettingsRequestObject()
        {
            // Snippet: GetGoogleSignalsSettings(GetGoogleSignalsSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetGoogleSignalsSettingsRequest request = new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            GoogleSignalsSettings response = analyticsAdminServiceClient.GetGoogleSignalsSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleSignalsSettingsAsync</summary>
        public async Task GetGoogleSignalsSettingsRequestObjectAsync()
        {
            // Snippet: GetGoogleSignalsSettingsAsync(GetGoogleSignalsSettingsRequest, CallSettings)
            // Additional: GetGoogleSignalsSettingsAsync(GetGoogleSignalsSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGoogleSignalsSettingsRequest request = new GetGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettingsName = GoogleSignalsSettingsName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            GoogleSignalsSettings response = await analyticsAdminServiceClient.GetGoogleSignalsSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleSignalsSettings</summary>
        public void GetGoogleSignalsSettings()
        {
            // Snippet: GetGoogleSignalsSettings(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/googleSignalsSettings";
            // Make the request
            GoogleSignalsSettings response = analyticsAdminServiceClient.GetGoogleSignalsSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleSignalsSettingsAsync</summary>
        public async Task GetGoogleSignalsSettingsAsync()
        {
            // Snippet: GetGoogleSignalsSettingsAsync(string, CallSettings)
            // Additional: GetGoogleSignalsSettingsAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/googleSignalsSettings";
            // Make the request
            GoogleSignalsSettings response = await analyticsAdminServiceClient.GetGoogleSignalsSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleSignalsSettings</summary>
        public void GetGoogleSignalsSettingsResourceNames()
        {
            // Snippet: GetGoogleSignalsSettings(GoogleSignalsSettingsName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GoogleSignalsSettingsName name = GoogleSignalsSettingsName.FromProperty("[PROPERTY]");
            // Make the request
            GoogleSignalsSettings response = analyticsAdminServiceClient.GetGoogleSignalsSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetGoogleSignalsSettingsAsync</summary>
        public async Task GetGoogleSignalsSettingsResourceNamesAsync()
        {
            // Snippet: GetGoogleSignalsSettingsAsync(GoogleSignalsSettingsName, CallSettings)
            // Additional: GetGoogleSignalsSettingsAsync(GoogleSignalsSettingsName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GoogleSignalsSettingsName name = GoogleSignalsSettingsName.FromProperty("[PROPERTY]");
            // Make the request
            GoogleSignalsSettings response = await analyticsAdminServiceClient.GetGoogleSignalsSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleSignalsSettings</summary>
        public void UpdateGoogleSignalsSettingsRequestObject()
        {
            // Snippet: UpdateGoogleSignalsSettings(UpdateGoogleSignalsSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateGoogleSignalsSettingsRequest request = new UpdateGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettings = new GoogleSignalsSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GoogleSignalsSettings response = analyticsAdminServiceClient.UpdateGoogleSignalsSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleSignalsSettingsAsync</summary>
        public async Task UpdateGoogleSignalsSettingsRequestObjectAsync()
        {
            // Snippet: UpdateGoogleSignalsSettingsAsync(UpdateGoogleSignalsSettingsRequest, CallSettings)
            // Additional: UpdateGoogleSignalsSettingsAsync(UpdateGoogleSignalsSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGoogleSignalsSettingsRequest request = new UpdateGoogleSignalsSettingsRequest
            {
                GoogleSignalsSettings = new GoogleSignalsSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            GoogleSignalsSettings response = await analyticsAdminServiceClient.UpdateGoogleSignalsSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleSignalsSettings</summary>
        public void UpdateGoogleSignalsSettings()
        {
            // Snippet: UpdateGoogleSignalsSettings(GoogleSignalsSettings, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GoogleSignalsSettings googleSignalsSettings = new GoogleSignalsSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GoogleSignalsSettings response = analyticsAdminServiceClient.UpdateGoogleSignalsSettings(googleSignalsSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateGoogleSignalsSettingsAsync</summary>
        public async Task UpdateGoogleSignalsSettingsAsync()
        {
            // Snippet: UpdateGoogleSignalsSettingsAsync(GoogleSignalsSettings, FieldMask, CallSettings)
            // Additional: UpdateGoogleSignalsSettingsAsync(GoogleSignalsSettings, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GoogleSignalsSettings googleSignalsSettings = new GoogleSignalsSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            GoogleSignalsSettings response = await analyticsAdminServiceClient.UpdateGoogleSignalsSettingsAsync(googleSignalsSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreateConversionEvent</summary>
        public void CreateConversionEventRequestObject()
        {
            // Snippet: CreateConversionEvent(CreateConversionEventRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateConversionEventRequest request = new CreateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = analyticsAdminServiceClient.CreateConversionEvent(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateConversionEventAsync</summary>
        public async Task CreateConversionEventRequestObjectAsync()
        {
            // Snippet: CreateConversionEventAsync(CreateConversionEventRequest, CallSettings)
            // Additional: CreateConversionEventAsync(CreateConversionEventRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversionEventRequest request = new CreateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = await analyticsAdminServiceClient.CreateConversionEventAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateConversionEvent</summary>
        public void CreateConversionEvent()
        {
            // Snippet: CreateConversionEvent(string, ConversionEvent, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            ConversionEvent conversionEvent = new ConversionEvent();
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = analyticsAdminServiceClient.CreateConversionEvent(parent, conversionEvent);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateConversionEventAsync</summary>
        public async Task CreateConversionEventAsync()
        {
            // Snippet: CreateConversionEventAsync(string, ConversionEvent, CallSettings)
            // Additional: CreateConversionEventAsync(string, ConversionEvent, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            ConversionEvent conversionEvent = new ConversionEvent();
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = await analyticsAdminServiceClient.CreateConversionEventAsync(parent, conversionEvent);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateConversionEvent</summary>
        public void CreateConversionEventResourceNames()
        {
            // Snippet: CreateConversionEvent(PropertyName, ConversionEvent, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            ConversionEvent conversionEvent = new ConversionEvent();
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = analyticsAdminServiceClient.CreateConversionEvent(parent, conversionEvent);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateConversionEventAsync</summary>
        public async Task CreateConversionEventResourceNamesAsync()
        {
            // Snippet: CreateConversionEventAsync(PropertyName, ConversionEvent, CallSettings)
            // Additional: CreateConversionEventAsync(PropertyName, ConversionEvent, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            ConversionEvent conversionEvent = new ConversionEvent();
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = await analyticsAdminServiceClient.CreateConversionEventAsync(parent, conversionEvent);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionEvent</summary>
        public void UpdateConversionEventRequestObject()
        {
            // Snippet: UpdateConversionEvent(UpdateConversionEventRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateConversionEventRequest request = new UpdateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = analyticsAdminServiceClient.UpdateConversionEvent(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionEventAsync</summary>
        public async Task UpdateConversionEventRequestObjectAsync()
        {
            // Snippet: UpdateConversionEventAsync(UpdateConversionEventRequest, CallSettings)
            // Additional: UpdateConversionEventAsync(UpdateConversionEventRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConversionEventRequest request = new UpdateConversionEventRequest
            {
                ConversionEvent = new ConversionEvent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = await analyticsAdminServiceClient.UpdateConversionEventAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionEvent</summary>
        public void UpdateConversionEvent()
        {
            // Snippet: UpdateConversionEvent(ConversionEvent, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ConversionEvent conversionEvent = new ConversionEvent();
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = analyticsAdminServiceClient.UpdateConversionEvent(conversionEvent, updateMask);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for UpdateConversionEventAsync</summary>
        public async Task UpdateConversionEventAsync()
        {
            // Snippet: UpdateConversionEventAsync(ConversionEvent, FieldMask, CallSettings)
            // Additional: UpdateConversionEventAsync(ConversionEvent, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionEvent conversionEvent = new ConversionEvent();
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = await analyticsAdminServiceClient.UpdateConversionEventAsync(conversionEvent, updateMask);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetConversionEvent</summary>
        public void GetConversionEventRequestObject()
        {
            // Snippet: GetConversionEvent(GetConversionEventRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetConversionEventRequest request = new GetConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = analyticsAdminServiceClient.GetConversionEvent(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetConversionEventAsync</summary>
        public async Task GetConversionEventRequestObjectAsync()
        {
            // Snippet: GetConversionEventAsync(GetConversionEventRequest, CallSettings)
            // Additional: GetConversionEventAsync(GetConversionEventRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConversionEventRequest request = new GetConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = await analyticsAdminServiceClient.GetConversionEventAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetConversionEvent</summary>
        public void GetConversionEvent()
        {
            // Snippet: GetConversionEvent(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/conversionEvents/[CONVERSION_EVENT]";
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = analyticsAdminServiceClient.GetConversionEvent(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetConversionEventAsync</summary>
        public async Task GetConversionEventAsync()
        {
            // Snippet: GetConversionEventAsync(string, CallSettings)
            // Additional: GetConversionEventAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/conversionEvents/[CONVERSION_EVENT]";
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = await analyticsAdminServiceClient.GetConversionEventAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetConversionEvent</summary>
        public void GetConversionEventResourceNames()
        {
            // Snippet: GetConversionEvent(ConversionEventName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ConversionEventName name = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]");
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = analyticsAdminServiceClient.GetConversionEvent(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetConversionEventAsync</summary>
        public async Task GetConversionEventResourceNamesAsync()
        {
            // Snippet: GetConversionEventAsync(ConversionEventName, CallSettings)
            // Additional: GetConversionEventAsync(ConversionEventName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionEventName name = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]");
            // Make the request
#pragma warning disable CS0612
            ConversionEvent response = await analyticsAdminServiceClient.GetConversionEventAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionEvent</summary>
        public void DeleteConversionEventRequestObject()
        {
            // Snippet: DeleteConversionEvent(DeleteConversionEventRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteConversionEventRequest request = new DeleteConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            // Make the request
#pragma warning disable CS0612
            analyticsAdminServiceClient.DeleteConversionEvent(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionEventAsync</summary>
        public async Task DeleteConversionEventRequestObjectAsync()
        {
            // Snippet: DeleteConversionEventAsync(DeleteConversionEventRequest, CallSettings)
            // Additional: DeleteConversionEventAsync(DeleteConversionEventRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConversionEventRequest request = new DeleteConversionEventRequest
            {
                ConversionEventName = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]"),
            };
            // Make the request
#pragma warning disable CS0612
            await analyticsAdminServiceClient.DeleteConversionEventAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionEvent</summary>
        public void DeleteConversionEvent()
        {
            // Snippet: DeleteConversionEvent(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/conversionEvents/[CONVERSION_EVENT]";
            // Make the request
#pragma warning disable CS0612
            analyticsAdminServiceClient.DeleteConversionEvent(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionEventAsync</summary>
        public async Task DeleteConversionEventAsync()
        {
            // Snippet: DeleteConversionEventAsync(string, CallSettings)
            // Additional: DeleteConversionEventAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/conversionEvents/[CONVERSION_EVENT]";
            // Make the request
#pragma warning disable CS0612
            await analyticsAdminServiceClient.DeleteConversionEventAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionEvent</summary>
        public void DeleteConversionEventResourceNames()
        {
            // Snippet: DeleteConversionEvent(ConversionEventName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ConversionEventName name = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]");
            // Make the request
#pragma warning disable CS0612
            analyticsAdminServiceClient.DeleteConversionEvent(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for DeleteConversionEventAsync</summary>
        public async Task DeleteConversionEventResourceNamesAsync()
        {
            // Snippet: DeleteConversionEventAsync(ConversionEventName, CallSettings)
            // Additional: DeleteConversionEventAsync(ConversionEventName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversionEventName name = ConversionEventName.FromPropertyConversionEvent("[PROPERTY]", "[CONVERSION_EVENT]");
            // Make the request
#pragma warning disable CS0612
            await analyticsAdminServiceClient.DeleteConversionEventAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListConversionEvents</summary>
        public void ListConversionEventsRequestObject()
        {
            // Snippet: ListConversionEvents(ListConversionEventsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListConversionEventsRequest request = new ListConversionEventsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListConversionEventsResponse, ConversionEvent> response = analyticsAdminServiceClient.ListConversionEvents(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversionEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversionEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionEventsAsync</summary>
        public async Task ListConversionEventsRequestObjectAsync()
        {
            // Snippet: ListConversionEventsAsync(ListConversionEventsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConversionEventsRequest request = new ListConversionEventsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> response = analyticsAdminServiceClient.ListConversionEventsAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversionEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversionEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionEvents</summary>
        public void ListConversionEvents()
        {
            // Snippet: ListConversionEvents(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListConversionEventsResponse, ConversionEvent> response = analyticsAdminServiceClient.ListConversionEvents(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversionEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversionEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionEventsAsync</summary>
        public async Task ListConversionEventsAsync()
        {
            // Snippet: ListConversionEventsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> response = analyticsAdminServiceClient.ListConversionEventsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversionEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversionEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionEvents</summary>
        public void ListConversionEventsResourceNames()
        {
            // Snippet: ListConversionEvents(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListConversionEventsResponse, ConversionEvent> response = analyticsAdminServiceClient.ListConversionEvents(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversionEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversionEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversionEventsAsync</summary>
        public async Task ListConversionEventsResourceNamesAsync()
        {
            // Snippet: ListConversionEventsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListConversionEventsResponse, ConversionEvent> response = analyticsAdminServiceClient.ListConversionEventsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversionEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversionEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversionEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateKeyEvent</summary>
        public void CreateKeyEventRequestObject()
        {
            // Snippet: CreateKeyEvent(CreateKeyEventRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateKeyEventRequest request = new CreateKeyEventRequest
            {
                KeyEvent = new KeyEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            KeyEvent response = analyticsAdminServiceClient.CreateKeyEvent(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyEventAsync</summary>
        public async Task CreateKeyEventRequestObjectAsync()
        {
            // Snippet: CreateKeyEventAsync(CreateKeyEventRequest, CallSettings)
            // Additional: CreateKeyEventAsync(CreateKeyEventRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateKeyEventRequest request = new CreateKeyEventRequest
            {
                KeyEvent = new KeyEvent(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            KeyEvent response = await analyticsAdminServiceClient.CreateKeyEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyEvent</summary>
        public void CreateKeyEvent()
        {
            // Snippet: CreateKeyEvent(string, KeyEvent, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            KeyEvent keyEvent = new KeyEvent();
            // Make the request
            KeyEvent response = analyticsAdminServiceClient.CreateKeyEvent(parent, keyEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyEventAsync</summary>
        public async Task CreateKeyEventAsync()
        {
            // Snippet: CreateKeyEventAsync(string, KeyEvent, CallSettings)
            // Additional: CreateKeyEventAsync(string, KeyEvent, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            KeyEvent keyEvent = new KeyEvent();
            // Make the request
            KeyEvent response = await analyticsAdminServiceClient.CreateKeyEventAsync(parent, keyEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyEvent</summary>
        public void CreateKeyEventResourceNames()
        {
            // Snippet: CreateKeyEvent(PropertyName, KeyEvent, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            KeyEvent keyEvent = new KeyEvent();
            // Make the request
            KeyEvent response = analyticsAdminServiceClient.CreateKeyEvent(parent, keyEvent);
            // End snippet
        }

        /// <summary>Snippet for CreateKeyEventAsync</summary>
        public async Task CreateKeyEventResourceNamesAsync()
        {
            // Snippet: CreateKeyEventAsync(PropertyName, KeyEvent, CallSettings)
            // Additional: CreateKeyEventAsync(PropertyName, KeyEvent, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            KeyEvent keyEvent = new KeyEvent();
            // Make the request
            KeyEvent response = await analyticsAdminServiceClient.CreateKeyEventAsync(parent, keyEvent);
            // End snippet
        }

        /// <summary>Snippet for UpdateKeyEvent</summary>
        public void UpdateKeyEventRequestObject()
        {
            // Snippet: UpdateKeyEvent(UpdateKeyEventRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateKeyEventRequest request = new UpdateKeyEventRequest
            {
                KeyEvent = new KeyEvent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            KeyEvent response = analyticsAdminServiceClient.UpdateKeyEvent(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateKeyEventAsync</summary>
        public async Task UpdateKeyEventRequestObjectAsync()
        {
            // Snippet: UpdateKeyEventAsync(UpdateKeyEventRequest, CallSettings)
            // Additional: UpdateKeyEventAsync(UpdateKeyEventRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateKeyEventRequest request = new UpdateKeyEventRequest
            {
                KeyEvent = new KeyEvent(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            KeyEvent response = await analyticsAdminServiceClient.UpdateKeyEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateKeyEvent</summary>
        public void UpdateKeyEvent()
        {
            // Snippet: UpdateKeyEvent(KeyEvent, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            KeyEvent keyEvent = new KeyEvent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            KeyEvent response = analyticsAdminServiceClient.UpdateKeyEvent(keyEvent, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateKeyEventAsync</summary>
        public async Task UpdateKeyEventAsync()
        {
            // Snippet: UpdateKeyEventAsync(KeyEvent, FieldMask, CallSettings)
            // Additional: UpdateKeyEventAsync(KeyEvent, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyEvent keyEvent = new KeyEvent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            KeyEvent response = await analyticsAdminServiceClient.UpdateKeyEventAsync(keyEvent, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetKeyEvent</summary>
        public void GetKeyEventRequestObject()
        {
            // Snippet: GetKeyEvent(GetKeyEventRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetKeyEventRequest request = new GetKeyEventRequest
            {
                KeyEventName = KeyEventName.FromPropertyKeyEvent("[PROPERTY]", "[KEY_EVENT]"),
            };
            // Make the request
            KeyEvent response = analyticsAdminServiceClient.GetKeyEvent(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyEventAsync</summary>
        public async Task GetKeyEventRequestObjectAsync()
        {
            // Snippet: GetKeyEventAsync(GetKeyEventRequest, CallSettings)
            // Additional: GetKeyEventAsync(GetKeyEventRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetKeyEventRequest request = new GetKeyEventRequest
            {
                KeyEventName = KeyEventName.FromPropertyKeyEvent("[PROPERTY]", "[KEY_EVENT]"),
            };
            // Make the request
            KeyEvent response = await analyticsAdminServiceClient.GetKeyEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetKeyEvent</summary>
        public void GetKeyEvent()
        {
            // Snippet: GetKeyEvent(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/keyEvents/[KEY_EVENT]";
            // Make the request
            KeyEvent response = analyticsAdminServiceClient.GetKeyEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyEventAsync</summary>
        public async Task GetKeyEventAsync()
        {
            // Snippet: GetKeyEventAsync(string, CallSettings)
            // Additional: GetKeyEventAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/keyEvents/[KEY_EVENT]";
            // Make the request
            KeyEvent response = await analyticsAdminServiceClient.GetKeyEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyEvent</summary>
        public void GetKeyEventResourceNames()
        {
            // Snippet: GetKeyEvent(KeyEventName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            KeyEventName name = KeyEventName.FromPropertyKeyEvent("[PROPERTY]", "[KEY_EVENT]");
            // Make the request
            KeyEvent response = analyticsAdminServiceClient.GetKeyEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetKeyEventAsync</summary>
        public async Task GetKeyEventResourceNamesAsync()
        {
            // Snippet: GetKeyEventAsync(KeyEventName, CallSettings)
            // Additional: GetKeyEventAsync(KeyEventName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyEventName name = KeyEventName.FromPropertyKeyEvent("[PROPERTY]", "[KEY_EVENT]");
            // Make the request
            KeyEvent response = await analyticsAdminServiceClient.GetKeyEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyEvent</summary>
        public void DeleteKeyEventRequestObject()
        {
            // Snippet: DeleteKeyEvent(DeleteKeyEventRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteKeyEventRequest request = new DeleteKeyEventRequest
            {
                KeyEventName = KeyEventName.FromPropertyKeyEvent("[PROPERTY]", "[KEY_EVENT]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteKeyEvent(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyEventAsync</summary>
        public async Task DeleteKeyEventRequestObjectAsync()
        {
            // Snippet: DeleteKeyEventAsync(DeleteKeyEventRequest, CallSettings)
            // Additional: DeleteKeyEventAsync(DeleteKeyEventRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteKeyEventRequest request = new DeleteKeyEventRequest
            {
                KeyEventName = KeyEventName.FromPropertyKeyEvent("[PROPERTY]", "[KEY_EVENT]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteKeyEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyEvent</summary>
        public void DeleteKeyEvent()
        {
            // Snippet: DeleteKeyEvent(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/keyEvents/[KEY_EVENT]";
            // Make the request
            analyticsAdminServiceClient.DeleteKeyEvent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyEventAsync</summary>
        public async Task DeleteKeyEventAsync()
        {
            // Snippet: DeleteKeyEventAsync(string, CallSettings)
            // Additional: DeleteKeyEventAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/keyEvents/[KEY_EVENT]";
            // Make the request
            await analyticsAdminServiceClient.DeleteKeyEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyEvent</summary>
        public void DeleteKeyEventResourceNames()
        {
            // Snippet: DeleteKeyEvent(KeyEventName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            KeyEventName name = KeyEventName.FromPropertyKeyEvent("[PROPERTY]", "[KEY_EVENT]");
            // Make the request
            analyticsAdminServiceClient.DeleteKeyEvent(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteKeyEventAsync</summary>
        public async Task DeleteKeyEventResourceNamesAsync()
        {
            // Snippet: DeleteKeyEventAsync(KeyEventName, CallSettings)
            // Additional: DeleteKeyEventAsync(KeyEventName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            KeyEventName name = KeyEventName.FromPropertyKeyEvent("[PROPERTY]", "[KEY_EVENT]");
            // Make the request
            await analyticsAdminServiceClient.DeleteKeyEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListKeyEvents</summary>
        public void ListKeyEventsRequestObject()
        {
            // Snippet: ListKeyEvents(ListKeyEventsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListKeyEventsRequest request = new ListKeyEventsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListKeyEventsResponse, KeyEvent> response = analyticsAdminServiceClient.ListKeyEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyEventsAsync</summary>
        public async Task ListKeyEventsRequestObjectAsync()
        {
            // Snippet: ListKeyEventsAsync(ListKeyEventsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListKeyEventsRequest request = new ListKeyEventsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListKeyEventsResponse, KeyEvent> response = analyticsAdminServiceClient.ListKeyEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyEvents</summary>
        public void ListKeyEvents()
        {
            // Snippet: ListKeyEvents(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListKeyEventsResponse, KeyEvent> response = analyticsAdminServiceClient.ListKeyEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyEventsAsync</summary>
        public async Task ListKeyEventsAsync()
        {
            // Snippet: ListKeyEventsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListKeyEventsResponse, KeyEvent> response = analyticsAdminServiceClient.ListKeyEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyEvents</summary>
        public void ListKeyEventsResourceNames()
        {
            // Snippet: ListKeyEvents(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListKeyEventsResponse, KeyEvent> response = analyticsAdminServiceClient.ListKeyEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListKeyEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListKeyEventsAsync</summary>
        public async Task ListKeyEventsResourceNamesAsync()
        {
            // Snippet: ListKeyEventsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListKeyEventsResponse, KeyEvent> response = analyticsAdminServiceClient.ListKeyEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListKeyEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLink</summary>
        public void GetDisplayVideo360AdvertiserLinkRequestObject()
        {
            // Snippet: GetDisplayVideo360AdvertiserLink(GetDisplayVideo360AdvertiserLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetDisplayVideo360AdvertiserLinkRequest request = new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            // Make the request
            DisplayVideo360AdvertiserLink response = analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task GetDisplayVideo360AdvertiserLinkRequestObjectAsync()
        {
            // Snippet: GetDisplayVideo360AdvertiserLinkAsync(GetDisplayVideo360AdvertiserLinkRequest, CallSettings)
            // Additional: GetDisplayVideo360AdvertiserLinkAsync(GetDisplayVideo360AdvertiserLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDisplayVideo360AdvertiserLinkRequest request = new GetDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            // Make the request
            DisplayVideo360AdvertiserLink response = await analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLink</summary>
        public void GetDisplayVideo360AdvertiserLink()
        {
            // Snippet: GetDisplayVideo360AdvertiserLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/displayVideo360AdvertiserLinks/[DISPLAY_VIDEO_360_ADVERTISER_LINK]";
            // Make the request
            DisplayVideo360AdvertiserLink response = analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task GetDisplayVideo360AdvertiserLinkAsync()
        {
            // Snippet: GetDisplayVideo360AdvertiserLinkAsync(string, CallSettings)
            // Additional: GetDisplayVideo360AdvertiserLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/displayVideo360AdvertiserLinks/[DISPLAY_VIDEO_360_ADVERTISER_LINK]";
            // Make the request
            DisplayVideo360AdvertiserLink response = await analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLink</summary>
        public void GetDisplayVideo360AdvertiserLinkResourceNames()
        {
            // Snippet: GetDisplayVideo360AdvertiserLink(DisplayVideo360AdvertiserLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLinkName name = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]");
            // Make the request
            DisplayVideo360AdvertiserLink response = analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task GetDisplayVideo360AdvertiserLinkResourceNamesAsync()
        {
            // Snippet: GetDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLinkName, CallSettings)
            // Additional: GetDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLinkName name = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]");
            // Make the request
            DisplayVideo360AdvertiserLink response = await analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinks</summary>
        public void ListDisplayVideo360AdvertiserLinksRequestObject()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinks(ListDisplayVideo360AdvertiserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListDisplayVideo360AdvertiserLinksRequest request = new ListDisplayVideo360AdvertiserLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DisplayVideo360AdvertiserLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDisplayVideo360AdvertiserLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinksAsync</summary>
        public async Task ListDisplayVideo360AdvertiserLinksRequestObjectAsync()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinksAsync(ListDisplayVideo360AdvertiserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDisplayVideo360AdvertiserLinksRequest request = new ListDisplayVideo360AdvertiserLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DisplayVideo360AdvertiserLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDisplayVideo360AdvertiserLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinks</summary>
        public void ListDisplayVideo360AdvertiserLinks()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinks(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DisplayVideo360AdvertiserLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDisplayVideo360AdvertiserLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinksAsync</summary>
        public async Task ListDisplayVideo360AdvertiserLinksAsync()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinksAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DisplayVideo360AdvertiserLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDisplayVideo360AdvertiserLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinks</summary>
        public void ListDisplayVideo360AdvertiserLinksResourceNames()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinks(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DisplayVideo360AdvertiserLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDisplayVideo360AdvertiserLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinksAsync</summary>
        public async Task ListDisplayVideo360AdvertiserLinksResourceNamesAsync()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinksAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinksResponse, DisplayVideo360AdvertiserLink> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DisplayVideo360AdvertiserLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDisplayVideo360AdvertiserLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLink</summary>
        public void CreateDisplayVideo360AdvertiserLinkRequestObject()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLink(CreateDisplayVideo360AdvertiserLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateDisplayVideo360AdvertiserLinkRequest request = new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            // Make the request
            DisplayVideo360AdvertiserLink response = analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task CreateDisplayVideo360AdvertiserLinkRequestObjectAsync()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLinkAsync(CreateDisplayVideo360AdvertiserLinkRequest, CallSettings)
            // Additional: CreateDisplayVideo360AdvertiserLinkAsync(CreateDisplayVideo360AdvertiserLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDisplayVideo360AdvertiserLinkRequest request = new CreateDisplayVideo360AdvertiserLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
            };
            // Make the request
            DisplayVideo360AdvertiserLink response = await analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLink</summary>
        public void CreateDisplayVideo360AdvertiserLink()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLink(string, DisplayVideo360AdvertiserLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink();
            // Make the request
            DisplayVideo360AdvertiserLink response = analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLink(parent, displayVideo360AdvertiserLink);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task CreateDisplayVideo360AdvertiserLinkAsync()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLinkAsync(string, DisplayVideo360AdvertiserLink, CallSettings)
            // Additional: CreateDisplayVideo360AdvertiserLinkAsync(string, DisplayVideo360AdvertiserLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink();
            // Make the request
            DisplayVideo360AdvertiserLink response = await analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkAsync(parent, displayVideo360AdvertiserLink);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLink</summary>
        public void CreateDisplayVideo360AdvertiserLinkResourceNames()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLink(PropertyName, DisplayVideo360AdvertiserLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink();
            // Make the request
            DisplayVideo360AdvertiserLink response = analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLink(parent, displayVideo360AdvertiserLink);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task CreateDisplayVideo360AdvertiserLinkResourceNamesAsync()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLinkAsync(PropertyName, DisplayVideo360AdvertiserLink, CallSettings)
            // Additional: CreateDisplayVideo360AdvertiserLinkAsync(PropertyName, DisplayVideo360AdvertiserLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink();
            // Make the request
            DisplayVideo360AdvertiserLink response = await analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkAsync(parent, displayVideo360AdvertiserLink);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLink</summary>
        public void DeleteDisplayVideo360AdvertiserLinkRequestObject()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLink(DeleteDisplayVideo360AdvertiserLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteDisplayVideo360AdvertiserLinkRequest request = new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task DeleteDisplayVideo360AdvertiserLinkRequestObjectAsync()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLinkAsync(DeleteDisplayVideo360AdvertiserLinkRequest, CallSettings)
            // Additional: DeleteDisplayVideo360AdvertiserLinkAsync(DeleteDisplayVideo360AdvertiserLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDisplayVideo360AdvertiserLinkRequest request = new DeleteDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLinkName = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLink</summary>
        public void DeleteDisplayVideo360AdvertiserLink()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/displayVideo360AdvertiserLinks/[DISPLAY_VIDEO_360_ADVERTISER_LINK]";
            // Make the request
            analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task DeleteDisplayVideo360AdvertiserLinkAsync()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLinkAsync(string, CallSettings)
            // Additional: DeleteDisplayVideo360AdvertiserLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/displayVideo360AdvertiserLinks/[DISPLAY_VIDEO_360_ADVERTISER_LINK]";
            // Make the request
            await analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLink</summary>
        public void DeleteDisplayVideo360AdvertiserLinkResourceNames()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLink(DisplayVideo360AdvertiserLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLinkName name = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]");
            // Make the request
            analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task DeleteDisplayVideo360AdvertiserLinkResourceNamesAsync()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLinkName, CallSettings)
            // Additional: DeleteDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLinkName name = DisplayVideo360AdvertiserLinkName.FromPropertyDisplayVideo360AdvertiserLink("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK]");
            // Make the request
            await analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDisplayVideo360AdvertiserLink</summary>
        public void UpdateDisplayVideo360AdvertiserLinkRequestObject()
        {
            // Snippet: UpdateDisplayVideo360AdvertiserLink(UpdateDisplayVideo360AdvertiserLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateDisplayVideo360AdvertiserLinkRequest request = new UpdateDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DisplayVideo360AdvertiserLink response = analyticsAdminServiceClient.UpdateDisplayVideo360AdvertiserLink(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task UpdateDisplayVideo360AdvertiserLinkRequestObjectAsync()
        {
            // Snippet: UpdateDisplayVideo360AdvertiserLinkAsync(UpdateDisplayVideo360AdvertiserLinkRequest, CallSettings)
            // Additional: UpdateDisplayVideo360AdvertiserLinkAsync(UpdateDisplayVideo360AdvertiserLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDisplayVideo360AdvertiserLinkRequest request = new UpdateDisplayVideo360AdvertiserLinkRequest
            {
                DisplayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DisplayVideo360AdvertiserLink response = await analyticsAdminServiceClient.UpdateDisplayVideo360AdvertiserLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDisplayVideo360AdvertiserLink</summary>
        public void UpdateDisplayVideo360AdvertiserLink()
        {
            // Snippet: UpdateDisplayVideo360AdvertiserLink(DisplayVideo360AdvertiserLink, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DisplayVideo360AdvertiserLink response = analyticsAdminServiceClient.UpdateDisplayVideo360AdvertiserLink(displayVideo360AdvertiserLink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDisplayVideo360AdvertiserLinkAsync</summary>
        public async Task UpdateDisplayVideo360AdvertiserLinkAsync()
        {
            // Snippet: UpdateDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLink, FieldMask, CallSettings)
            // Additional: UpdateDisplayVideo360AdvertiserLinkAsync(DisplayVideo360AdvertiserLink, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLink displayVideo360AdvertiserLink = new DisplayVideo360AdvertiserLink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DisplayVideo360AdvertiserLink response = await analyticsAdminServiceClient.UpdateDisplayVideo360AdvertiserLinkAsync(displayVideo360AdvertiserLink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkProposal</summary>
        public void GetDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            // Snippet: GetDisplayVideo360AdvertiserLinkProposal(GetDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetDisplayVideo360AdvertiserLinkProposalRequest request = new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkProposal(request);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task GetDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            // Snippet: GetDisplayVideo360AdvertiserLinkProposalAsync(GetDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Additional: GetDisplayVideo360AdvertiserLinkProposalAsync(GetDisplayVideo360AdvertiserLinkProposalRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDisplayVideo360AdvertiserLinkProposalRequest request = new GetDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = await analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkProposal</summary>
        public void GetDisplayVideo360AdvertiserLinkProposal()
        {
            // Snippet: GetDisplayVideo360AdvertiserLinkProposal(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/displayVideo360AdvertiserLinkProposals/[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]";
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkProposal(name);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task GetDisplayVideo360AdvertiserLinkProposalAsync()
        {
            // Snippet: GetDisplayVideo360AdvertiserLinkProposalAsync(string, CallSettings)
            // Additional: GetDisplayVideo360AdvertiserLinkProposalAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/displayVideo360AdvertiserLinkProposals/[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]";
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = await analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkProposalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkProposal</summary>
        public void GetDisplayVideo360AdvertiserLinkProposalResourceNames()
        {
            // Snippet: GetDisplayVideo360AdvertiserLinkProposal(DisplayVideo360AdvertiserLinkProposalName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLinkProposalName name = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]");
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkProposal(name);
            // End snippet
        }

        /// <summary>Snippet for GetDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task GetDisplayVideo360AdvertiserLinkProposalResourceNamesAsync()
        {
            // Snippet: GetDisplayVideo360AdvertiserLinkProposalAsync(DisplayVideo360AdvertiserLinkProposalName, CallSettings)
            // Additional: GetDisplayVideo360AdvertiserLinkProposalAsync(DisplayVideo360AdvertiserLinkProposalName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLinkProposalName name = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]");
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = await analyticsAdminServiceClient.GetDisplayVideo360AdvertiserLinkProposalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinkProposals</summary>
        public void ListDisplayVideo360AdvertiserLinkProposalsRequestObject()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinkProposals(ListDisplayVideo360AdvertiserLinkProposalsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListDisplayVideo360AdvertiserLinkProposalsRequest request = new ListDisplayVideo360AdvertiserLinkProposalsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinkProposals(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DisplayVideo360AdvertiserLinkProposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDisplayVideo360AdvertiserLinkProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLinkProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLinkProposal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLinkProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinkProposalsAsync</summary>
        public async Task ListDisplayVideo360AdvertiserLinkProposalsRequestObjectAsync()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinkProposalsAsync(ListDisplayVideo360AdvertiserLinkProposalsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDisplayVideo360AdvertiserLinkProposalsRequest request = new ListDisplayVideo360AdvertiserLinkProposalsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinkProposalsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DisplayVideo360AdvertiserLinkProposal item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDisplayVideo360AdvertiserLinkProposalsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLinkProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLinkProposal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLinkProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinkProposals</summary>
        public void ListDisplayVideo360AdvertiserLinkProposals()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinkProposals(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinkProposals(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DisplayVideo360AdvertiserLinkProposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDisplayVideo360AdvertiserLinkProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLinkProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLinkProposal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLinkProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinkProposalsAsync</summary>
        public async Task ListDisplayVideo360AdvertiserLinkProposalsAsync()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinkProposalsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinkProposalsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DisplayVideo360AdvertiserLinkProposal item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDisplayVideo360AdvertiserLinkProposalsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLinkProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLinkProposal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLinkProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinkProposals</summary>
        public void ListDisplayVideo360AdvertiserLinkProposalsResourceNames()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinkProposals(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinkProposals(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DisplayVideo360AdvertiserLinkProposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDisplayVideo360AdvertiserLinkProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLinkProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLinkProposal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLinkProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisplayVideo360AdvertiserLinkProposalsAsync</summary>
        public async Task ListDisplayVideo360AdvertiserLinkProposalsResourceNamesAsync()
        {
            // Snippet: ListDisplayVideo360AdvertiserLinkProposalsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListDisplayVideo360AdvertiserLinkProposalsResponse, DisplayVideo360AdvertiserLinkProposal> response = analyticsAdminServiceClient.ListDisplayVideo360AdvertiserLinkProposalsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DisplayVideo360AdvertiserLinkProposal item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDisplayVideo360AdvertiserLinkProposalsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DisplayVideo360AdvertiserLinkProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DisplayVideo360AdvertiserLinkProposal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DisplayVideo360AdvertiserLinkProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkProposal</summary>
        public void CreateDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLinkProposal(CreateDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateDisplayVideo360AdvertiserLinkProposalRequest request = new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal(),
            };
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkProposal(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task CreateDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLinkProposalAsync(CreateDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Additional: CreateDisplayVideo360AdvertiserLinkProposalAsync(CreateDisplayVideo360AdvertiserLinkProposalRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDisplayVideo360AdvertiserLinkProposalRequest request = new CreateDisplayVideo360AdvertiserLinkProposalRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DisplayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal(),
            };
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = await analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkProposal</summary>
        public void CreateDisplayVideo360AdvertiserLinkProposal()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLinkProposal(string, DisplayVideo360AdvertiserLinkProposal, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal();
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkProposal(parent, displayVideo360AdvertiserLinkProposal);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task CreateDisplayVideo360AdvertiserLinkProposalAsync()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLinkProposalAsync(string, DisplayVideo360AdvertiserLinkProposal, CallSettings)
            // Additional: CreateDisplayVideo360AdvertiserLinkProposalAsync(string, DisplayVideo360AdvertiserLinkProposal, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal();
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = await analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkProposalAsync(parent, displayVideo360AdvertiserLinkProposal);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkProposal</summary>
        public void CreateDisplayVideo360AdvertiserLinkProposalResourceNames()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLinkProposal(PropertyName, DisplayVideo360AdvertiserLinkProposal, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal();
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkProposal(parent, displayVideo360AdvertiserLinkProposal);
            // End snippet
        }

        /// <summary>Snippet for CreateDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task CreateDisplayVideo360AdvertiserLinkProposalResourceNamesAsync()
        {
            // Snippet: CreateDisplayVideo360AdvertiserLinkProposalAsync(PropertyName, DisplayVideo360AdvertiserLinkProposal, CallSettings)
            // Additional: CreateDisplayVideo360AdvertiserLinkProposalAsync(PropertyName, DisplayVideo360AdvertiserLinkProposal, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            DisplayVideo360AdvertiserLinkProposal displayVideo360AdvertiserLinkProposal = new DisplayVideo360AdvertiserLinkProposal();
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = await analyticsAdminServiceClient.CreateDisplayVideo360AdvertiserLinkProposalAsync(parent, displayVideo360AdvertiserLinkProposal);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLinkProposal</summary>
        public void DeleteDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLinkProposal(DeleteDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteDisplayVideo360AdvertiserLinkProposalRequest request = new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkProposal(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task DeleteDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLinkProposalAsync(DeleteDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Additional: DeleteDisplayVideo360AdvertiserLinkProposalAsync(DeleteDisplayVideo360AdvertiserLinkProposalRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDisplayVideo360AdvertiserLinkProposalRequest request = new DeleteDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLinkProposal</summary>
        public void DeleteDisplayVideo360AdvertiserLinkProposal()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLinkProposal(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/displayVideo360AdvertiserLinkProposals/[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]";
            // Make the request
            analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkProposal(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task DeleteDisplayVideo360AdvertiserLinkProposalAsync()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLinkProposalAsync(string, CallSettings)
            // Additional: DeleteDisplayVideo360AdvertiserLinkProposalAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/displayVideo360AdvertiserLinkProposals/[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]";
            // Make the request
            await analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkProposalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLinkProposal</summary>
        public void DeleteDisplayVideo360AdvertiserLinkProposalResourceNames()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLinkProposal(DisplayVideo360AdvertiserLinkProposalName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLinkProposalName name = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]");
            // Make the request
            analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkProposal(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task DeleteDisplayVideo360AdvertiserLinkProposalResourceNamesAsync()
        {
            // Snippet: DeleteDisplayVideo360AdvertiserLinkProposalAsync(DisplayVideo360AdvertiserLinkProposalName, CallSettings)
            // Additional: DeleteDisplayVideo360AdvertiserLinkProposalAsync(DisplayVideo360AdvertiserLinkProposalName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DisplayVideo360AdvertiserLinkProposalName name = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]");
            // Make the request
            await analyticsAdminServiceClient.DeleteDisplayVideo360AdvertiserLinkProposalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveDisplayVideo360AdvertiserLinkProposal</summary>
        public void ApproveDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            // Snippet: ApproveDisplayVideo360AdvertiserLinkProposal(ApproveDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ApproveDisplayVideo360AdvertiserLinkProposalRequest request = new ApproveDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            // Make the request
            ApproveDisplayVideo360AdvertiserLinkProposalResponse response = analyticsAdminServiceClient.ApproveDisplayVideo360AdvertiserLinkProposal(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task ApproveDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            // Snippet: ApproveDisplayVideo360AdvertiserLinkProposalAsync(ApproveDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Additional: ApproveDisplayVideo360AdvertiserLinkProposalAsync(ApproveDisplayVideo360AdvertiserLinkProposalRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApproveDisplayVideo360AdvertiserLinkProposalRequest request = new ApproveDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            // Make the request
            ApproveDisplayVideo360AdvertiserLinkProposalResponse response = await analyticsAdminServiceClient.ApproveDisplayVideo360AdvertiserLinkProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CancelDisplayVideo360AdvertiserLinkProposal</summary>
        public void CancelDisplayVideo360AdvertiserLinkProposalRequestObject()
        {
            // Snippet: CancelDisplayVideo360AdvertiserLinkProposal(CancelDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CancelDisplayVideo360AdvertiserLinkProposalRequest request = new CancelDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = analyticsAdminServiceClient.CancelDisplayVideo360AdvertiserLinkProposal(request);
            // End snippet
        }

        /// <summary>Snippet for CancelDisplayVideo360AdvertiserLinkProposalAsync</summary>
        public async Task CancelDisplayVideo360AdvertiserLinkProposalRequestObjectAsync()
        {
            // Snippet: CancelDisplayVideo360AdvertiserLinkProposalAsync(CancelDisplayVideo360AdvertiserLinkProposalRequest, CallSettings)
            // Additional: CancelDisplayVideo360AdvertiserLinkProposalAsync(CancelDisplayVideo360AdvertiserLinkProposalRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CancelDisplayVideo360AdvertiserLinkProposalRequest request = new CancelDisplayVideo360AdvertiserLinkProposalRequest
            {
                DisplayVideo360AdvertiserLinkProposalName = DisplayVideo360AdvertiserLinkProposalName.FromPropertyDisplayVideo360AdvertiserLinkProposal("[PROPERTY]", "[DISPLAY_VIDEO_360_ADVERTISER_LINK_PROPOSAL]"),
            };
            // Make the request
            DisplayVideo360AdvertiserLinkProposal response = await analyticsAdminServiceClient.CancelDisplayVideo360AdvertiserLinkProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomDimension</summary>
        public void CreateCustomDimensionRequestObject()
        {
            // Snippet: CreateCustomDimension(CreateCustomDimensionRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateCustomDimensionRequest request = new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomDimension = new CustomDimension(),
            };
            // Make the request
            CustomDimension response = analyticsAdminServiceClient.CreateCustomDimension(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomDimensionAsync</summary>
        public async Task CreateCustomDimensionRequestObjectAsync()
        {
            // Snippet: CreateCustomDimensionAsync(CreateCustomDimensionRequest, CallSettings)
            // Additional: CreateCustomDimensionAsync(CreateCustomDimensionRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomDimensionRequest request = new CreateCustomDimensionRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomDimension = new CustomDimension(),
            };
            // Make the request
            CustomDimension response = await analyticsAdminServiceClient.CreateCustomDimensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomDimension</summary>
        public void CreateCustomDimension()
        {
            // Snippet: CreateCustomDimension(string, CustomDimension, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            CustomDimension customDimension = new CustomDimension();
            // Make the request
            CustomDimension response = analyticsAdminServiceClient.CreateCustomDimension(parent, customDimension);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomDimensionAsync</summary>
        public async Task CreateCustomDimensionAsync()
        {
            // Snippet: CreateCustomDimensionAsync(string, CustomDimension, CallSettings)
            // Additional: CreateCustomDimensionAsync(string, CustomDimension, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            CustomDimension customDimension = new CustomDimension();
            // Make the request
            CustomDimension response = await analyticsAdminServiceClient.CreateCustomDimensionAsync(parent, customDimension);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomDimension</summary>
        public void CreateCustomDimensionResourceNames()
        {
            // Snippet: CreateCustomDimension(PropertyName, CustomDimension, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            CustomDimension customDimension = new CustomDimension();
            // Make the request
            CustomDimension response = analyticsAdminServiceClient.CreateCustomDimension(parent, customDimension);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomDimensionAsync</summary>
        public async Task CreateCustomDimensionResourceNamesAsync()
        {
            // Snippet: CreateCustomDimensionAsync(PropertyName, CustomDimension, CallSettings)
            // Additional: CreateCustomDimensionAsync(PropertyName, CustomDimension, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            CustomDimension customDimension = new CustomDimension();
            // Make the request
            CustomDimension response = await analyticsAdminServiceClient.CreateCustomDimensionAsync(parent, customDimension);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomDimension</summary>
        public void UpdateCustomDimensionRequestObject()
        {
            // Snippet: UpdateCustomDimension(UpdateCustomDimensionRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateCustomDimensionRequest request = new UpdateCustomDimensionRequest
            {
                CustomDimension = new CustomDimension(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomDimension response = analyticsAdminServiceClient.UpdateCustomDimension(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomDimensionAsync</summary>
        public async Task UpdateCustomDimensionRequestObjectAsync()
        {
            // Snippet: UpdateCustomDimensionAsync(UpdateCustomDimensionRequest, CallSettings)
            // Additional: UpdateCustomDimensionAsync(UpdateCustomDimensionRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomDimensionRequest request = new UpdateCustomDimensionRequest
            {
                CustomDimension = new CustomDimension(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomDimension response = await analyticsAdminServiceClient.UpdateCustomDimensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomDimension</summary>
        public void UpdateCustomDimension()
        {
            // Snippet: UpdateCustomDimension(CustomDimension, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CustomDimension customDimension = new CustomDimension();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomDimension response = analyticsAdminServiceClient.UpdateCustomDimension(customDimension, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomDimensionAsync</summary>
        public async Task UpdateCustomDimensionAsync()
        {
            // Snippet: UpdateCustomDimensionAsync(CustomDimension, FieldMask, CallSettings)
            // Additional: UpdateCustomDimensionAsync(CustomDimension, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomDimension customDimension = new CustomDimension();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomDimension response = await analyticsAdminServiceClient.UpdateCustomDimensionAsync(customDimension, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListCustomDimensions</summary>
        public void ListCustomDimensionsRequestObject()
        {
            // Snippet: ListCustomDimensions(ListCustomDimensionsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListCustomDimensionsRequest request = new ListCustomDimensionsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListCustomDimensionsResponse, CustomDimension> response = analyticsAdminServiceClient.ListCustomDimensions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomDimension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomDimensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomDimension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomDimension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomDimension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomDimensionsAsync</summary>
        public async Task ListCustomDimensionsRequestObjectAsync()
        {
            // Snippet: ListCustomDimensionsAsync(ListCustomDimensionsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomDimensionsRequest request = new ListCustomDimensionsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomDimensionsResponse, CustomDimension> response = analyticsAdminServiceClient.ListCustomDimensionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomDimension item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomDimensionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomDimension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomDimension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomDimension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomDimensions</summary>
        public void ListCustomDimensions()
        {
            // Snippet: ListCustomDimensions(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListCustomDimensionsResponse, CustomDimension> response = analyticsAdminServiceClient.ListCustomDimensions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomDimension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomDimensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomDimension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomDimension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomDimension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomDimensionsAsync</summary>
        public async Task ListCustomDimensionsAsync()
        {
            // Snippet: ListCustomDimensionsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListCustomDimensionsResponse, CustomDimension> response = analyticsAdminServiceClient.ListCustomDimensionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomDimension item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomDimensionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomDimension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomDimension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomDimension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomDimensions</summary>
        public void ListCustomDimensionsResourceNames()
        {
            // Snippet: ListCustomDimensions(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListCustomDimensionsResponse, CustomDimension> response = analyticsAdminServiceClient.ListCustomDimensions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomDimension item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomDimensionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomDimension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomDimension> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomDimension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomDimensionsAsync</summary>
        public async Task ListCustomDimensionsResourceNamesAsync()
        {
            // Snippet: ListCustomDimensionsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListCustomDimensionsResponse, CustomDimension> response = analyticsAdminServiceClient.ListCustomDimensionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomDimension item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomDimensionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomDimension item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomDimension> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomDimension item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomDimension</summary>
        public void ArchiveCustomDimensionRequestObject()
        {
            // Snippet: ArchiveCustomDimension(ArchiveCustomDimensionRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ArchiveCustomDimensionRequest request = new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            // Make the request
            analyticsAdminServiceClient.ArchiveCustomDimension(request);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomDimensionAsync</summary>
        public async Task ArchiveCustomDimensionRequestObjectAsync()
        {
            // Snippet: ArchiveCustomDimensionAsync(ArchiveCustomDimensionRequest, CallSettings)
            // Additional: ArchiveCustomDimensionAsync(ArchiveCustomDimensionRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ArchiveCustomDimensionRequest request = new ArchiveCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            // Make the request
            await analyticsAdminServiceClient.ArchiveCustomDimensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomDimension</summary>
        public void ArchiveCustomDimension()
        {
            // Snippet: ArchiveCustomDimension(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/customDimensions/[CUSTOM_DIMENSION]";
            // Make the request
            analyticsAdminServiceClient.ArchiveCustomDimension(name);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomDimensionAsync</summary>
        public async Task ArchiveCustomDimensionAsync()
        {
            // Snippet: ArchiveCustomDimensionAsync(string, CallSettings)
            // Additional: ArchiveCustomDimensionAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/customDimensions/[CUSTOM_DIMENSION]";
            // Make the request
            await analyticsAdminServiceClient.ArchiveCustomDimensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomDimension</summary>
        public void ArchiveCustomDimensionResourceNames()
        {
            // Snippet: ArchiveCustomDimension(CustomDimensionName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CustomDimensionName name = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]");
            // Make the request
            analyticsAdminServiceClient.ArchiveCustomDimension(name);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomDimensionAsync</summary>
        public async Task ArchiveCustomDimensionResourceNamesAsync()
        {
            // Snippet: ArchiveCustomDimensionAsync(CustomDimensionName, CallSettings)
            // Additional: ArchiveCustomDimensionAsync(CustomDimensionName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomDimensionName name = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]");
            // Make the request
            await analyticsAdminServiceClient.ArchiveCustomDimensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomDimension</summary>
        public void GetCustomDimensionRequestObject()
        {
            // Snippet: GetCustomDimension(GetCustomDimensionRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetCustomDimensionRequest request = new GetCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            // Make the request
            CustomDimension response = analyticsAdminServiceClient.GetCustomDimension(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomDimensionAsync</summary>
        public async Task GetCustomDimensionRequestObjectAsync()
        {
            // Snippet: GetCustomDimensionAsync(GetCustomDimensionRequest, CallSettings)
            // Additional: GetCustomDimensionAsync(GetCustomDimensionRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomDimensionRequest request = new GetCustomDimensionRequest
            {
                CustomDimensionName = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]"),
            };
            // Make the request
            CustomDimension response = await analyticsAdminServiceClient.GetCustomDimensionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomDimension</summary>
        public void GetCustomDimension()
        {
            // Snippet: GetCustomDimension(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/customDimensions/[CUSTOM_DIMENSION]";
            // Make the request
            CustomDimension response = analyticsAdminServiceClient.GetCustomDimension(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomDimensionAsync</summary>
        public async Task GetCustomDimensionAsync()
        {
            // Snippet: GetCustomDimensionAsync(string, CallSettings)
            // Additional: GetCustomDimensionAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/customDimensions/[CUSTOM_DIMENSION]";
            // Make the request
            CustomDimension response = await analyticsAdminServiceClient.GetCustomDimensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomDimension</summary>
        public void GetCustomDimensionResourceNames()
        {
            // Snippet: GetCustomDimension(CustomDimensionName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CustomDimensionName name = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]");
            // Make the request
            CustomDimension response = analyticsAdminServiceClient.GetCustomDimension(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomDimensionAsync</summary>
        public async Task GetCustomDimensionResourceNamesAsync()
        {
            // Snippet: GetCustomDimensionAsync(CustomDimensionName, CallSettings)
            // Additional: GetCustomDimensionAsync(CustomDimensionName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomDimensionName name = CustomDimensionName.FromPropertyCustomDimension("[PROPERTY]", "[CUSTOM_DIMENSION]");
            // Make the request
            CustomDimension response = await analyticsAdminServiceClient.GetCustomDimensionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomMetric</summary>
        public void CreateCustomMetricRequestObject()
        {
            // Snippet: CreateCustomMetric(CreateCustomMetricRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateCustomMetricRequest request = new CreateCustomMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomMetric = new CustomMetric(),
            };
            // Make the request
            CustomMetric response = analyticsAdminServiceClient.CreateCustomMetric(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomMetricAsync</summary>
        public async Task CreateCustomMetricRequestObjectAsync()
        {
            // Snippet: CreateCustomMetricAsync(CreateCustomMetricRequest, CallSettings)
            // Additional: CreateCustomMetricAsync(CreateCustomMetricRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCustomMetricRequest request = new CreateCustomMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CustomMetric = new CustomMetric(),
            };
            // Make the request
            CustomMetric response = await analyticsAdminServiceClient.CreateCustomMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomMetric</summary>
        public void CreateCustomMetric()
        {
            // Snippet: CreateCustomMetric(string, CustomMetric, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            CustomMetric customMetric = new CustomMetric();
            // Make the request
            CustomMetric response = analyticsAdminServiceClient.CreateCustomMetric(parent, customMetric);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomMetricAsync</summary>
        public async Task CreateCustomMetricAsync()
        {
            // Snippet: CreateCustomMetricAsync(string, CustomMetric, CallSettings)
            // Additional: CreateCustomMetricAsync(string, CustomMetric, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            CustomMetric customMetric = new CustomMetric();
            // Make the request
            CustomMetric response = await analyticsAdminServiceClient.CreateCustomMetricAsync(parent, customMetric);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomMetric</summary>
        public void CreateCustomMetricResourceNames()
        {
            // Snippet: CreateCustomMetric(PropertyName, CustomMetric, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            CustomMetric customMetric = new CustomMetric();
            // Make the request
            CustomMetric response = analyticsAdminServiceClient.CreateCustomMetric(parent, customMetric);
            // End snippet
        }

        /// <summary>Snippet for CreateCustomMetricAsync</summary>
        public async Task CreateCustomMetricResourceNamesAsync()
        {
            // Snippet: CreateCustomMetricAsync(PropertyName, CustomMetric, CallSettings)
            // Additional: CreateCustomMetricAsync(PropertyName, CustomMetric, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            CustomMetric customMetric = new CustomMetric();
            // Make the request
            CustomMetric response = await analyticsAdminServiceClient.CreateCustomMetricAsync(parent, customMetric);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomMetric</summary>
        public void UpdateCustomMetricRequestObject()
        {
            // Snippet: UpdateCustomMetric(UpdateCustomMetricRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateCustomMetricRequest request = new UpdateCustomMetricRequest
            {
                CustomMetric = new CustomMetric(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomMetric response = analyticsAdminServiceClient.UpdateCustomMetric(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomMetricAsync</summary>
        public async Task UpdateCustomMetricRequestObjectAsync()
        {
            // Snippet: UpdateCustomMetricAsync(UpdateCustomMetricRequest, CallSettings)
            // Additional: UpdateCustomMetricAsync(UpdateCustomMetricRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCustomMetricRequest request = new UpdateCustomMetricRequest
            {
                CustomMetric = new CustomMetric(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CustomMetric response = await analyticsAdminServiceClient.UpdateCustomMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomMetric</summary>
        public void UpdateCustomMetric()
        {
            // Snippet: UpdateCustomMetric(CustomMetric, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CustomMetric customMetric = new CustomMetric();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomMetric response = analyticsAdminServiceClient.UpdateCustomMetric(customMetric, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCustomMetricAsync</summary>
        public async Task UpdateCustomMetricAsync()
        {
            // Snippet: UpdateCustomMetricAsync(CustomMetric, FieldMask, CallSettings)
            // Additional: UpdateCustomMetricAsync(CustomMetric, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomMetric customMetric = new CustomMetric();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CustomMetric response = await analyticsAdminServiceClient.UpdateCustomMetricAsync(customMetric, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListCustomMetrics</summary>
        public void ListCustomMetricsRequestObject()
        {
            // Snippet: ListCustomMetrics(ListCustomMetricsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListCustomMetricsRequest request = new ListCustomMetricsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListCustomMetricsResponse, CustomMetric> response = analyticsAdminServiceClient.ListCustomMetrics(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomMetricsAsync</summary>
        public async Task ListCustomMetricsRequestObjectAsync()
        {
            // Snippet: ListCustomMetricsAsync(ListCustomMetricsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCustomMetricsRequest request = new ListCustomMetricsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCustomMetricsResponse, CustomMetric> response = analyticsAdminServiceClient.ListCustomMetricsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomMetrics</summary>
        public void ListCustomMetrics()
        {
            // Snippet: ListCustomMetrics(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListCustomMetricsResponse, CustomMetric> response = analyticsAdminServiceClient.ListCustomMetrics(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomMetricsAsync</summary>
        public async Task ListCustomMetricsAsync()
        {
            // Snippet: ListCustomMetricsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListCustomMetricsResponse, CustomMetric> response = analyticsAdminServiceClient.ListCustomMetricsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomMetrics</summary>
        public void ListCustomMetricsResourceNames()
        {
            // Snippet: ListCustomMetrics(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListCustomMetricsResponse, CustomMetric> response = analyticsAdminServiceClient.ListCustomMetrics(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CustomMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCustomMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCustomMetricsAsync</summary>
        public async Task ListCustomMetricsResourceNamesAsync()
        {
            // Snippet: ListCustomMetricsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListCustomMetricsResponse, CustomMetric> response = analyticsAdminServiceClient.ListCustomMetricsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CustomMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCustomMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CustomMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CustomMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CustomMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomMetric</summary>
        public void ArchiveCustomMetricRequestObject()
        {
            // Snippet: ArchiveCustomMetric(ArchiveCustomMetricRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ArchiveCustomMetricRequest request = new ArchiveCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            // Make the request
            analyticsAdminServiceClient.ArchiveCustomMetric(request);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomMetricAsync</summary>
        public async Task ArchiveCustomMetricRequestObjectAsync()
        {
            // Snippet: ArchiveCustomMetricAsync(ArchiveCustomMetricRequest, CallSettings)
            // Additional: ArchiveCustomMetricAsync(ArchiveCustomMetricRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ArchiveCustomMetricRequest request = new ArchiveCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            // Make the request
            await analyticsAdminServiceClient.ArchiveCustomMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomMetric</summary>
        public void ArchiveCustomMetric()
        {
            // Snippet: ArchiveCustomMetric(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/customMetrics/[CUSTOM_METRIC]";
            // Make the request
            analyticsAdminServiceClient.ArchiveCustomMetric(name);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomMetricAsync</summary>
        public async Task ArchiveCustomMetricAsync()
        {
            // Snippet: ArchiveCustomMetricAsync(string, CallSettings)
            // Additional: ArchiveCustomMetricAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/customMetrics/[CUSTOM_METRIC]";
            // Make the request
            await analyticsAdminServiceClient.ArchiveCustomMetricAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomMetric</summary>
        public void ArchiveCustomMetricResourceNames()
        {
            // Snippet: ArchiveCustomMetric(CustomMetricName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CustomMetricName name = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]");
            // Make the request
            analyticsAdminServiceClient.ArchiveCustomMetric(name);
            // End snippet
        }

        /// <summary>Snippet for ArchiveCustomMetricAsync</summary>
        public async Task ArchiveCustomMetricResourceNamesAsync()
        {
            // Snippet: ArchiveCustomMetricAsync(CustomMetricName, CallSettings)
            // Additional: ArchiveCustomMetricAsync(CustomMetricName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomMetricName name = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]");
            // Make the request
            await analyticsAdminServiceClient.ArchiveCustomMetricAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomMetric</summary>
        public void GetCustomMetricRequestObject()
        {
            // Snippet: GetCustomMetric(GetCustomMetricRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetCustomMetricRequest request = new GetCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            // Make the request
            CustomMetric response = analyticsAdminServiceClient.GetCustomMetric(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomMetricAsync</summary>
        public async Task GetCustomMetricRequestObjectAsync()
        {
            // Snippet: GetCustomMetricAsync(GetCustomMetricRequest, CallSettings)
            // Additional: GetCustomMetricAsync(GetCustomMetricRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCustomMetricRequest request = new GetCustomMetricRequest
            {
                CustomMetricName = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]"),
            };
            // Make the request
            CustomMetric response = await analyticsAdminServiceClient.GetCustomMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCustomMetric</summary>
        public void GetCustomMetric()
        {
            // Snippet: GetCustomMetric(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/customMetrics/[CUSTOM_METRIC]";
            // Make the request
            CustomMetric response = analyticsAdminServiceClient.GetCustomMetric(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomMetricAsync</summary>
        public async Task GetCustomMetricAsync()
        {
            // Snippet: GetCustomMetricAsync(string, CallSettings)
            // Additional: GetCustomMetricAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/customMetrics/[CUSTOM_METRIC]";
            // Make the request
            CustomMetric response = await analyticsAdminServiceClient.GetCustomMetricAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomMetric</summary>
        public void GetCustomMetricResourceNames()
        {
            // Snippet: GetCustomMetric(CustomMetricName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CustomMetricName name = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]");
            // Make the request
            CustomMetric response = analyticsAdminServiceClient.GetCustomMetric(name);
            // End snippet
        }

        /// <summary>Snippet for GetCustomMetricAsync</summary>
        public async Task GetCustomMetricResourceNamesAsync()
        {
            // Snippet: GetCustomMetricAsync(CustomMetricName, CallSettings)
            // Additional: GetCustomMetricAsync(CustomMetricName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CustomMetricName name = CustomMetricName.FromPropertyCustomMetric("[PROPERTY]", "[CUSTOM_METRIC]");
            // Make the request
            CustomMetric response = await analyticsAdminServiceClient.GetCustomMetricAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataRetentionSettings</summary>
        public void GetDataRetentionSettingsRequestObject()
        {
            // Snippet: GetDataRetentionSettings(GetDataRetentionSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetDataRetentionSettingsRequest request = new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            DataRetentionSettings response = analyticsAdminServiceClient.GetDataRetentionSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataRetentionSettingsAsync</summary>
        public async Task GetDataRetentionSettingsRequestObjectAsync()
        {
            // Snippet: GetDataRetentionSettingsAsync(GetDataRetentionSettingsRequest, CallSettings)
            // Additional: GetDataRetentionSettingsAsync(GetDataRetentionSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataRetentionSettingsRequest request = new GetDataRetentionSettingsRequest
            {
                DataRetentionSettingsName = DataRetentionSettingsName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            DataRetentionSettings response = await analyticsAdminServiceClient.GetDataRetentionSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataRetentionSettings</summary>
        public void GetDataRetentionSettings()
        {
            // Snippet: GetDataRetentionSettings(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataRetentionSettings";
            // Make the request
            DataRetentionSettings response = analyticsAdminServiceClient.GetDataRetentionSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataRetentionSettingsAsync</summary>
        public async Task GetDataRetentionSettingsAsync()
        {
            // Snippet: GetDataRetentionSettingsAsync(string, CallSettings)
            // Additional: GetDataRetentionSettingsAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataRetentionSettings";
            // Make the request
            DataRetentionSettings response = await analyticsAdminServiceClient.GetDataRetentionSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataRetentionSettings</summary>
        public void GetDataRetentionSettingsResourceNames()
        {
            // Snippet: GetDataRetentionSettings(DataRetentionSettingsName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataRetentionSettingsName name = DataRetentionSettingsName.FromProperty("[PROPERTY]");
            // Make the request
            DataRetentionSettings response = analyticsAdminServiceClient.GetDataRetentionSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataRetentionSettingsAsync</summary>
        public async Task GetDataRetentionSettingsResourceNamesAsync()
        {
            // Snippet: GetDataRetentionSettingsAsync(DataRetentionSettingsName, CallSettings)
            // Additional: GetDataRetentionSettingsAsync(DataRetentionSettingsName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataRetentionSettingsName name = DataRetentionSettingsName.FromProperty("[PROPERTY]");
            // Make the request
            DataRetentionSettings response = await analyticsAdminServiceClient.GetDataRetentionSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataRetentionSettings</summary>
        public void UpdateDataRetentionSettingsRequestObject()
        {
            // Snippet: UpdateDataRetentionSettings(UpdateDataRetentionSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataRetentionSettingsRequest request = new UpdateDataRetentionSettingsRequest
            {
                DataRetentionSettings = new DataRetentionSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataRetentionSettings response = analyticsAdminServiceClient.UpdateDataRetentionSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataRetentionSettingsAsync</summary>
        public async Task UpdateDataRetentionSettingsRequestObjectAsync()
        {
            // Snippet: UpdateDataRetentionSettingsAsync(UpdateDataRetentionSettingsRequest, CallSettings)
            // Additional: UpdateDataRetentionSettingsAsync(UpdateDataRetentionSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataRetentionSettingsRequest request = new UpdateDataRetentionSettingsRequest
            {
                DataRetentionSettings = new DataRetentionSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataRetentionSettings response = await analyticsAdminServiceClient.UpdateDataRetentionSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataRetentionSettings</summary>
        public void UpdateDataRetentionSettings()
        {
            // Snippet: UpdateDataRetentionSettings(DataRetentionSettings, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataRetentionSettings dataRetentionSettings = new DataRetentionSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataRetentionSettings response = analyticsAdminServiceClient.UpdateDataRetentionSettings(dataRetentionSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataRetentionSettingsAsync</summary>
        public async Task UpdateDataRetentionSettingsAsync()
        {
            // Snippet: UpdateDataRetentionSettingsAsync(DataRetentionSettings, FieldMask, CallSettings)
            // Additional: UpdateDataRetentionSettingsAsync(DataRetentionSettings, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataRetentionSettings dataRetentionSettings = new DataRetentionSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataRetentionSettings response = await analyticsAdminServiceClient.UpdateDataRetentionSettingsAsync(dataRetentionSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreateDataStream</summary>
        public void CreateDataStreamRequestObject()
        {
            // Snippet: CreateDataStream(CreateDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateDataStreamRequest request = new CreateDataStreamRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DataStream = new DataStream(),
            };
            // Make the request
            DataStream response = analyticsAdminServiceClient.CreateDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataStreamAsync</summary>
        public async Task CreateDataStreamRequestObjectAsync()
        {
            // Snippet: CreateDataStreamAsync(CreateDataStreamRequest, CallSettings)
            // Additional: CreateDataStreamAsync(CreateDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataStreamRequest request = new CreateDataStreamRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                DataStream = new DataStream(),
            };
            // Make the request
            DataStream response = await analyticsAdminServiceClient.CreateDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataStream</summary>
        public void CreateDataStream()
        {
            // Snippet: CreateDataStream(string, DataStream, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            DataStream dataStream = new DataStream();
            // Make the request
            DataStream response = analyticsAdminServiceClient.CreateDataStream(parent, dataStream);
            // End snippet
        }

        /// <summary>Snippet for CreateDataStreamAsync</summary>
        public async Task CreateDataStreamAsync()
        {
            // Snippet: CreateDataStreamAsync(string, DataStream, CallSettings)
            // Additional: CreateDataStreamAsync(string, DataStream, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            DataStream dataStream = new DataStream();
            // Make the request
            DataStream response = await analyticsAdminServiceClient.CreateDataStreamAsync(parent, dataStream);
            // End snippet
        }

        /// <summary>Snippet for CreateDataStream</summary>
        public void CreateDataStreamResourceNames()
        {
            // Snippet: CreateDataStream(PropertyName, DataStream, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            DataStream dataStream = new DataStream();
            // Make the request
            DataStream response = analyticsAdminServiceClient.CreateDataStream(parent, dataStream);
            // End snippet
        }

        /// <summary>Snippet for CreateDataStreamAsync</summary>
        public async Task CreateDataStreamResourceNamesAsync()
        {
            // Snippet: CreateDataStreamAsync(PropertyName, DataStream, CallSettings)
            // Additional: CreateDataStreamAsync(PropertyName, DataStream, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            DataStream dataStream = new DataStream();
            // Make the request
            DataStream response = await analyticsAdminServiceClient.CreateDataStreamAsync(parent, dataStream);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStream</summary>
        public void DeleteDataStreamRequestObject()
        {
            // Snippet: DeleteDataStream(DeleteDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataStreamRequest request = new DeleteDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStreamAsync</summary>
        public async Task DeleteDataStreamRequestObjectAsync()
        {
            // Snippet: DeleteDataStreamAsync(DeleteDataStreamRequest, CallSettings)
            // Additional: DeleteDataStreamAsync(DeleteDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataStreamRequest request = new DeleteDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStream</summary>
        public void DeleteDataStream()
        {
            // Snippet: DeleteDataStream(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            analyticsAdminServiceClient.DeleteDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStreamAsync</summary>
        public async Task DeleteDataStreamAsync()
        {
            // Snippet: DeleteDataStreamAsync(string, CallSettings)
            // Additional: DeleteDataStreamAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            await analyticsAdminServiceClient.DeleteDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStream</summary>
        public void DeleteDataStreamResourceNames()
        {
            // Snippet: DeleteDataStream(DataStreamName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName name = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            analyticsAdminServiceClient.DeleteDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataStreamAsync</summary>
        public async Task DeleteDataStreamResourceNamesAsync()
        {
            // Snippet: DeleteDataStreamAsync(DataStreamName, CallSettings)
            // Additional: DeleteDataStreamAsync(DataStreamName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName name = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            await analyticsAdminServiceClient.DeleteDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataStream</summary>
        public void UpdateDataStreamRequestObject()
        {
            // Snippet: UpdateDataStream(UpdateDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataStreamRequest request = new UpdateDataStreamRequest
            {
                DataStream = new DataStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataStream response = analyticsAdminServiceClient.UpdateDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataStreamAsync</summary>
        public async Task UpdateDataStreamRequestObjectAsync()
        {
            // Snippet: UpdateDataStreamAsync(UpdateDataStreamRequest, CallSettings)
            // Additional: UpdateDataStreamAsync(UpdateDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataStreamRequest request = new UpdateDataStreamRequest
            {
                DataStream = new DataStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataStream response = await analyticsAdminServiceClient.UpdateDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataStream</summary>
        public void UpdateDataStream()
        {
            // Snippet: UpdateDataStream(DataStream, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStream dataStream = new DataStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataStream response = analyticsAdminServiceClient.UpdateDataStream(dataStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataStreamAsync</summary>
        public async Task UpdateDataStreamAsync()
        {
            // Snippet: UpdateDataStreamAsync(DataStream, FieldMask, CallSettings)
            // Additional: UpdateDataStreamAsync(DataStream, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStream dataStream = new DataStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataStream response = await analyticsAdminServiceClient.UpdateDataStreamAsync(dataStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListDataStreams</summary>
        public void ListDataStreamsRequestObject()
        {
            // Snippet: ListDataStreams(ListDataStreamsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListDataStreamsRequest request = new ListDataStreamsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListDataStreamsResponse, DataStream> response = analyticsAdminServiceClient.ListDataStreams(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStreamsAsync</summary>
        public async Task ListDataStreamsRequestObjectAsync()
        {
            // Snippet: ListDataStreamsAsync(ListDataStreamsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataStreamsRequest request = new ListDataStreamsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDataStreamsResponse, DataStream> response = analyticsAdminServiceClient.ListDataStreamsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStreams</summary>
        public void ListDataStreams()
        {
            // Snippet: ListDataStreams(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListDataStreamsResponse, DataStream> response = analyticsAdminServiceClient.ListDataStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStreamsAsync</summary>
        public async Task ListDataStreamsAsync()
        {
            // Snippet: ListDataStreamsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListDataStreamsResponse, DataStream> response = analyticsAdminServiceClient.ListDataStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStreams</summary>
        public void ListDataStreamsResourceNames()
        {
            // Snippet: ListDataStreams(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListDataStreamsResponse, DataStream> response = analyticsAdminServiceClient.ListDataStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataStreamsAsync</summary>
        public async Task ListDataStreamsResourceNamesAsync()
        {
            // Snippet: ListDataStreamsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListDataStreamsResponse, DataStream> response = analyticsAdminServiceClient.ListDataStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataStream</summary>
        public void GetDataStreamRequestObject()
        {
            // Snippet: GetDataStream(GetDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetDataStreamRequest request = new GetDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            DataStream response = analyticsAdminServiceClient.GetDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataStreamAsync</summary>
        public async Task GetDataStreamRequestObjectAsync()
        {
            // Snippet: GetDataStreamAsync(GetDataStreamRequest, CallSettings)
            // Additional: GetDataStreamAsync(GetDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataStreamRequest request = new GetDataStreamRequest
            {
                DataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            DataStream response = await analyticsAdminServiceClient.GetDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataStream</summary>
        public void GetDataStream()
        {
            // Snippet: GetDataStream(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            DataStream response = analyticsAdminServiceClient.GetDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataStreamAsync</summary>
        public async Task GetDataStreamAsync()
        {
            // Snippet: GetDataStreamAsync(string, CallSettings)
            // Additional: GetDataStreamAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            DataStream response = await analyticsAdminServiceClient.GetDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataStream</summary>
        public void GetDataStreamResourceNames()
        {
            // Snippet: GetDataStream(DataStreamName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName name = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            DataStream response = analyticsAdminServiceClient.GetDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataStreamAsync</summary>
        public async Task GetDataStreamResourceNamesAsync()
        {
            // Snippet: GetDataStreamAsync(DataStreamName, CallSettings)
            // Additional: GetDataStreamAsync(DataStreamName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName name = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            DataStream response = await analyticsAdminServiceClient.GetDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudience</summary>
        public void GetAudienceRequestObject()
        {
            // Snippet: GetAudience(GetAudienceRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetAudienceRequest request = new GetAudienceRequest
            {
                AudienceName = AudienceName.FromPropertyAudience("[PROPERTY]", "[AUDIENCE]"),
            };
            // Make the request
            Audience response = analyticsAdminServiceClient.GetAudience(request);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceAsync</summary>
        public async Task GetAudienceRequestObjectAsync()
        {
            // Snippet: GetAudienceAsync(GetAudienceRequest, CallSettings)
            // Additional: GetAudienceAsync(GetAudienceRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAudienceRequest request = new GetAudienceRequest
            {
                AudienceName = AudienceName.FromPropertyAudience("[PROPERTY]", "[AUDIENCE]"),
            };
            // Make the request
            Audience response = await analyticsAdminServiceClient.GetAudienceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAudience</summary>
        public void GetAudience()
        {
            // Snippet: GetAudience(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/audiences/[AUDIENCE]";
            // Make the request
            Audience response = analyticsAdminServiceClient.GetAudience(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceAsync</summary>
        public async Task GetAudienceAsync()
        {
            // Snippet: GetAudienceAsync(string, CallSettings)
            // Additional: GetAudienceAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/audiences/[AUDIENCE]";
            // Make the request
            Audience response = await analyticsAdminServiceClient.GetAudienceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudience</summary>
        public void GetAudienceResourceNames()
        {
            // Snippet: GetAudience(AudienceName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AudienceName name = AudienceName.FromPropertyAudience("[PROPERTY]", "[AUDIENCE]");
            // Make the request
            Audience response = analyticsAdminServiceClient.GetAudience(name);
            // End snippet
        }

        /// <summary>Snippet for GetAudienceAsync</summary>
        public async Task GetAudienceResourceNamesAsync()
        {
            // Snippet: GetAudienceAsync(AudienceName, CallSettings)
            // Additional: GetAudienceAsync(AudienceName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AudienceName name = AudienceName.FromPropertyAudience("[PROPERTY]", "[AUDIENCE]");
            // Make the request
            Audience response = await analyticsAdminServiceClient.GetAudienceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAudiences</summary>
        public void ListAudiencesRequestObject()
        {
            // Snippet: ListAudiences(ListAudiencesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListAudiencesRequest request = new ListAudiencesRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListAudiencesResponse, Audience> response = analyticsAdminServiceClient.ListAudiences(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Audience item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudiencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Audience item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Audience> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Audience item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudiencesAsync</summary>
        public async Task ListAudiencesRequestObjectAsync()
        {
            // Snippet: ListAudiencesAsync(ListAudiencesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAudiencesRequest request = new ListAudiencesRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAudiencesResponse, Audience> response = analyticsAdminServiceClient.ListAudiencesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Audience item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAudiencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Audience item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Audience> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Audience item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudiences</summary>
        public void ListAudiences()
        {
            // Snippet: ListAudiences(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListAudiencesResponse, Audience> response = analyticsAdminServiceClient.ListAudiences(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Audience item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudiencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Audience item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Audience> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Audience item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudiencesAsync</summary>
        public async Task ListAudiencesAsync()
        {
            // Snippet: ListAudiencesAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListAudiencesResponse, Audience> response = analyticsAdminServiceClient.ListAudiencesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Audience item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAudiencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Audience item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Audience> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Audience item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudiences</summary>
        public void ListAudiencesResourceNames()
        {
            // Snippet: ListAudiences(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListAudiencesResponse, Audience> response = analyticsAdminServiceClient.ListAudiences(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Audience item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAudiencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Audience item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Audience> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Audience item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAudiencesAsync</summary>
        public async Task ListAudiencesResourceNamesAsync()
        {
            // Snippet: ListAudiencesAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListAudiencesResponse, Audience> response = analyticsAdminServiceClient.ListAudiencesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Audience item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAudiencesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Audience item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Audience> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Audience item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAudience</summary>
        public void CreateAudienceRequestObject()
        {
            // Snippet: CreateAudience(CreateAudienceRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateAudienceRequest request = new CreateAudienceRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Audience = new Audience(),
            };
            // Make the request
            Audience response = analyticsAdminServiceClient.CreateAudience(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAudienceAsync</summary>
        public async Task CreateAudienceRequestObjectAsync()
        {
            // Snippet: CreateAudienceAsync(CreateAudienceRequest, CallSettings)
            // Additional: CreateAudienceAsync(CreateAudienceRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAudienceRequest request = new CreateAudienceRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                Audience = new Audience(),
            };
            // Make the request
            Audience response = await analyticsAdminServiceClient.CreateAudienceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAudience</summary>
        public void CreateAudience()
        {
            // Snippet: CreateAudience(string, Audience, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            Audience audience = new Audience();
            // Make the request
            Audience response = analyticsAdminServiceClient.CreateAudience(parent, audience);
            // End snippet
        }

        /// <summary>Snippet for CreateAudienceAsync</summary>
        public async Task CreateAudienceAsync()
        {
            // Snippet: CreateAudienceAsync(string, Audience, CallSettings)
            // Additional: CreateAudienceAsync(string, Audience, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            Audience audience = new Audience();
            // Make the request
            Audience response = await analyticsAdminServiceClient.CreateAudienceAsync(parent, audience);
            // End snippet
        }

        /// <summary>Snippet for CreateAudience</summary>
        public void CreateAudienceResourceNames()
        {
            // Snippet: CreateAudience(PropertyName, Audience, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            Audience audience = new Audience();
            // Make the request
            Audience response = analyticsAdminServiceClient.CreateAudience(parent, audience);
            // End snippet
        }

        /// <summary>Snippet for CreateAudienceAsync</summary>
        public async Task CreateAudienceResourceNamesAsync()
        {
            // Snippet: CreateAudienceAsync(PropertyName, Audience, CallSettings)
            // Additional: CreateAudienceAsync(PropertyName, Audience, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            Audience audience = new Audience();
            // Make the request
            Audience response = await analyticsAdminServiceClient.CreateAudienceAsync(parent, audience);
            // End snippet
        }

        /// <summary>Snippet for UpdateAudience</summary>
        public void UpdateAudienceRequestObject()
        {
            // Snippet: UpdateAudience(UpdateAudienceRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateAudienceRequest request = new UpdateAudienceRequest
            {
                Audience = new Audience(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Audience response = analyticsAdminServiceClient.UpdateAudience(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAudienceAsync</summary>
        public async Task UpdateAudienceRequestObjectAsync()
        {
            // Snippet: UpdateAudienceAsync(UpdateAudienceRequest, CallSettings)
            // Additional: UpdateAudienceAsync(UpdateAudienceRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAudienceRequest request = new UpdateAudienceRequest
            {
                Audience = new Audience(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Audience response = await analyticsAdminServiceClient.UpdateAudienceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAudience</summary>
        public void UpdateAudience()
        {
            // Snippet: UpdateAudience(Audience, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            Audience audience = new Audience();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Audience response = analyticsAdminServiceClient.UpdateAudience(audience, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAudienceAsync</summary>
        public async Task UpdateAudienceAsync()
        {
            // Snippet: UpdateAudienceAsync(Audience, FieldMask, CallSettings)
            // Additional: UpdateAudienceAsync(Audience, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            Audience audience = new Audience();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Audience response = await analyticsAdminServiceClient.UpdateAudienceAsync(audience, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ArchiveAudience</summary>
        public void ArchiveAudienceRequestObject()
        {
            // Snippet: ArchiveAudience(ArchiveAudienceRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ArchiveAudienceRequest request = new ArchiveAudienceRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            analyticsAdminServiceClient.ArchiveAudience(request);
            // End snippet
        }

        /// <summary>Snippet for ArchiveAudienceAsync</summary>
        public async Task ArchiveAudienceRequestObjectAsync()
        {
            // Snippet: ArchiveAudienceAsync(ArchiveAudienceRequest, CallSettings)
            // Additional: ArchiveAudienceAsync(ArchiveAudienceRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ArchiveAudienceRequest request = new ArchiveAudienceRequest
            {
                PropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            await analyticsAdminServiceClient.ArchiveAudienceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSearchAds360Link</summary>
        public void GetSearchAds360LinkRequestObject()
        {
            // Snippet: GetSearchAds360Link(GetSearchAds360LinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetSearchAds360LinkRequest request = new GetSearchAds360LinkRequest
            {
                SearchAds360LinkName = SearchAds360LinkName.FromPropertySearchAds360Link("[PROPERTY]", "[SEARCH_ADS_360_LINK]"),
            };
            // Make the request
            SearchAds360Link response = analyticsAdminServiceClient.GetSearchAds360Link(request);
            // End snippet
        }

        /// <summary>Snippet for GetSearchAds360LinkAsync</summary>
        public async Task GetSearchAds360LinkRequestObjectAsync()
        {
            // Snippet: GetSearchAds360LinkAsync(GetSearchAds360LinkRequest, CallSettings)
            // Additional: GetSearchAds360LinkAsync(GetSearchAds360LinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSearchAds360LinkRequest request = new GetSearchAds360LinkRequest
            {
                SearchAds360LinkName = SearchAds360LinkName.FromPropertySearchAds360Link("[PROPERTY]", "[SEARCH_ADS_360_LINK]"),
            };
            // Make the request
            SearchAds360Link response = await analyticsAdminServiceClient.GetSearchAds360LinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSearchAds360Link</summary>
        public void GetSearchAds360Link()
        {
            // Snippet: GetSearchAds360Link(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/searchAds360Links/[SEARCH_ADS_360_LINK]";
            // Make the request
            SearchAds360Link response = analyticsAdminServiceClient.GetSearchAds360Link(name);
            // End snippet
        }

        /// <summary>Snippet for GetSearchAds360LinkAsync</summary>
        public async Task GetSearchAds360LinkAsync()
        {
            // Snippet: GetSearchAds360LinkAsync(string, CallSettings)
            // Additional: GetSearchAds360LinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/searchAds360Links/[SEARCH_ADS_360_LINK]";
            // Make the request
            SearchAds360Link response = await analyticsAdminServiceClient.GetSearchAds360LinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSearchAds360Link</summary>
        public void GetSearchAds360LinkResourceNames()
        {
            // Snippet: GetSearchAds360Link(SearchAds360LinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SearchAds360LinkName name = SearchAds360LinkName.FromPropertySearchAds360Link("[PROPERTY]", "[SEARCH_ADS_360_LINK]");
            // Make the request
            SearchAds360Link response = analyticsAdminServiceClient.GetSearchAds360Link(name);
            // End snippet
        }

        /// <summary>Snippet for GetSearchAds360LinkAsync</summary>
        public async Task GetSearchAds360LinkResourceNamesAsync()
        {
            // Snippet: GetSearchAds360LinkAsync(SearchAds360LinkName, CallSettings)
            // Additional: GetSearchAds360LinkAsync(SearchAds360LinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAds360LinkName name = SearchAds360LinkName.FromPropertySearchAds360Link("[PROPERTY]", "[SEARCH_ADS_360_LINK]");
            // Make the request
            SearchAds360Link response = await analyticsAdminServiceClient.GetSearchAds360LinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSearchAds360Links</summary>
        public void ListSearchAds360LinksRequestObject()
        {
            // Snippet: ListSearchAds360Links(ListSearchAds360LinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListSearchAds360LinksRequest request = new ListSearchAds360LinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListSearchAds360LinksResponse, SearchAds360Link> response = analyticsAdminServiceClient.ListSearchAds360Links(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchAds360Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSearchAds360LinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchAds360Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchAds360Link> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchAds360Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchAds360LinksAsync</summary>
        public async Task ListSearchAds360LinksRequestObjectAsync()
        {
            // Snippet: ListSearchAds360LinksAsync(ListSearchAds360LinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSearchAds360LinksRequest request = new ListSearchAds360LinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSearchAds360LinksResponse, SearchAds360Link> response = analyticsAdminServiceClient.ListSearchAds360LinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchAds360Link item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSearchAds360LinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchAds360Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchAds360Link> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchAds360Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchAds360Links</summary>
        public void ListSearchAds360Links()
        {
            // Snippet: ListSearchAds360Links(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListSearchAds360LinksResponse, SearchAds360Link> response = analyticsAdminServiceClient.ListSearchAds360Links(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchAds360Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSearchAds360LinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchAds360Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchAds360Link> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchAds360Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchAds360LinksAsync</summary>
        public async Task ListSearchAds360LinksAsync()
        {
            // Snippet: ListSearchAds360LinksAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListSearchAds360LinksResponse, SearchAds360Link> response = analyticsAdminServiceClient.ListSearchAds360LinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchAds360Link item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSearchAds360LinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchAds360Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchAds360Link> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchAds360Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchAds360Links</summary>
        public void ListSearchAds360LinksResourceNames()
        {
            // Snippet: ListSearchAds360Links(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListSearchAds360LinksResponse, SearchAds360Link> response = analyticsAdminServiceClient.ListSearchAds360Links(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchAds360Link item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSearchAds360LinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchAds360Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchAds360Link> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchAds360Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSearchAds360LinksAsync</summary>
        public async Task ListSearchAds360LinksResourceNamesAsync()
        {
            // Snippet: ListSearchAds360LinksAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListSearchAds360LinksResponse, SearchAds360Link> response = analyticsAdminServiceClient.ListSearchAds360LinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchAds360Link item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSearchAds360LinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchAds360Link item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchAds360Link> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchAds360Link item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateSearchAds360Link</summary>
        public void CreateSearchAds360LinkRequestObject()
        {
            // Snippet: CreateSearchAds360Link(CreateSearchAds360LinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateSearchAds360LinkRequest request = new CreateSearchAds360LinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                SearchAds360Link = new SearchAds360Link(),
            };
            // Make the request
            SearchAds360Link response = analyticsAdminServiceClient.CreateSearchAds360Link(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchAds360LinkAsync</summary>
        public async Task CreateSearchAds360LinkRequestObjectAsync()
        {
            // Snippet: CreateSearchAds360LinkAsync(CreateSearchAds360LinkRequest, CallSettings)
            // Additional: CreateSearchAds360LinkAsync(CreateSearchAds360LinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSearchAds360LinkRequest request = new CreateSearchAds360LinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                SearchAds360Link = new SearchAds360Link(),
            };
            // Make the request
            SearchAds360Link response = await analyticsAdminServiceClient.CreateSearchAds360LinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchAds360Link</summary>
        public void CreateSearchAds360Link()
        {
            // Snippet: CreateSearchAds360Link(string, SearchAds360Link, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            SearchAds360Link searchAds360Link = new SearchAds360Link();
            // Make the request
            SearchAds360Link response = analyticsAdminServiceClient.CreateSearchAds360Link(parent, searchAds360Link);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchAds360LinkAsync</summary>
        public async Task CreateSearchAds360LinkAsync()
        {
            // Snippet: CreateSearchAds360LinkAsync(string, SearchAds360Link, CallSettings)
            // Additional: CreateSearchAds360LinkAsync(string, SearchAds360Link, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            SearchAds360Link searchAds360Link = new SearchAds360Link();
            // Make the request
            SearchAds360Link response = await analyticsAdminServiceClient.CreateSearchAds360LinkAsync(parent, searchAds360Link);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchAds360Link</summary>
        public void CreateSearchAds360LinkResourceNames()
        {
            // Snippet: CreateSearchAds360Link(PropertyName, SearchAds360Link, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            SearchAds360Link searchAds360Link = new SearchAds360Link();
            // Make the request
            SearchAds360Link response = analyticsAdminServiceClient.CreateSearchAds360Link(parent, searchAds360Link);
            // End snippet
        }

        /// <summary>Snippet for CreateSearchAds360LinkAsync</summary>
        public async Task CreateSearchAds360LinkResourceNamesAsync()
        {
            // Snippet: CreateSearchAds360LinkAsync(PropertyName, SearchAds360Link, CallSettings)
            // Additional: CreateSearchAds360LinkAsync(PropertyName, SearchAds360Link, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            SearchAds360Link searchAds360Link = new SearchAds360Link();
            // Make the request
            SearchAds360Link response = await analyticsAdminServiceClient.CreateSearchAds360LinkAsync(parent, searchAds360Link);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchAds360Link</summary>
        public void DeleteSearchAds360LinkRequestObject()
        {
            // Snippet: DeleteSearchAds360Link(DeleteSearchAds360LinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteSearchAds360LinkRequest request = new DeleteSearchAds360LinkRequest
            {
                SearchAds360LinkName = SearchAds360LinkName.FromPropertySearchAds360Link("[PROPERTY]", "[SEARCH_ADS_360_LINK]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteSearchAds360Link(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchAds360LinkAsync</summary>
        public async Task DeleteSearchAds360LinkRequestObjectAsync()
        {
            // Snippet: DeleteSearchAds360LinkAsync(DeleteSearchAds360LinkRequest, CallSettings)
            // Additional: DeleteSearchAds360LinkAsync(DeleteSearchAds360LinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSearchAds360LinkRequest request = new DeleteSearchAds360LinkRequest
            {
                SearchAds360LinkName = SearchAds360LinkName.FromPropertySearchAds360Link("[PROPERTY]", "[SEARCH_ADS_360_LINK]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteSearchAds360LinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchAds360Link</summary>
        public void DeleteSearchAds360Link()
        {
            // Snippet: DeleteSearchAds360Link(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/searchAds360Links/[SEARCH_ADS_360_LINK]";
            // Make the request
            analyticsAdminServiceClient.DeleteSearchAds360Link(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchAds360LinkAsync</summary>
        public async Task DeleteSearchAds360LinkAsync()
        {
            // Snippet: DeleteSearchAds360LinkAsync(string, CallSettings)
            // Additional: DeleteSearchAds360LinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/searchAds360Links/[SEARCH_ADS_360_LINK]";
            // Make the request
            await analyticsAdminServiceClient.DeleteSearchAds360LinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchAds360Link</summary>
        public void DeleteSearchAds360LinkResourceNames()
        {
            // Snippet: DeleteSearchAds360Link(SearchAds360LinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SearchAds360LinkName name = SearchAds360LinkName.FromPropertySearchAds360Link("[PROPERTY]", "[SEARCH_ADS_360_LINK]");
            // Make the request
            analyticsAdminServiceClient.DeleteSearchAds360Link(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSearchAds360LinkAsync</summary>
        public async Task DeleteSearchAds360LinkResourceNamesAsync()
        {
            // Snippet: DeleteSearchAds360LinkAsync(SearchAds360LinkName, CallSettings)
            // Additional: DeleteSearchAds360LinkAsync(SearchAds360LinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAds360LinkName name = SearchAds360LinkName.FromPropertySearchAds360Link("[PROPERTY]", "[SEARCH_ADS_360_LINK]");
            // Make the request
            await analyticsAdminServiceClient.DeleteSearchAds360LinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchAds360Link</summary>
        public void UpdateSearchAds360LinkRequestObject()
        {
            // Snippet: UpdateSearchAds360Link(UpdateSearchAds360LinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateSearchAds360LinkRequest request = new UpdateSearchAds360LinkRequest
            {
                SearchAds360Link = new SearchAds360Link(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SearchAds360Link response = analyticsAdminServiceClient.UpdateSearchAds360Link(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchAds360LinkAsync</summary>
        public async Task UpdateSearchAds360LinkRequestObjectAsync()
        {
            // Snippet: UpdateSearchAds360LinkAsync(UpdateSearchAds360LinkRequest, CallSettings)
            // Additional: UpdateSearchAds360LinkAsync(UpdateSearchAds360LinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSearchAds360LinkRequest request = new UpdateSearchAds360LinkRequest
            {
                SearchAds360Link = new SearchAds360Link(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SearchAds360Link response = await analyticsAdminServiceClient.UpdateSearchAds360LinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchAds360Link</summary>
        public void UpdateSearchAds360Link()
        {
            // Snippet: UpdateSearchAds360Link(SearchAds360Link, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SearchAds360Link searchAds360Link = new SearchAds360Link();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SearchAds360Link response = analyticsAdminServiceClient.UpdateSearchAds360Link(searchAds360Link, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSearchAds360LinkAsync</summary>
        public async Task UpdateSearchAds360LinkAsync()
        {
            // Snippet: UpdateSearchAds360LinkAsync(SearchAds360Link, FieldMask, CallSettings)
            // Additional: UpdateSearchAds360LinkAsync(SearchAds360Link, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchAds360Link searchAds360Link = new SearchAds360Link();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SearchAds360Link response = await analyticsAdminServiceClient.UpdateSearchAds360LinkAsync(searchAds360Link, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetAttributionSettings</summary>
        public void GetAttributionSettingsRequestObject()
        {
            // Snippet: GetAttributionSettings(GetAttributionSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetAttributionSettingsRequest request = new GetAttributionSettingsRequest
            {
                AttributionSettingsName = AttributionSettingsName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            AttributionSettings response = analyticsAdminServiceClient.GetAttributionSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttributionSettingsAsync</summary>
        public async Task GetAttributionSettingsRequestObjectAsync()
        {
            // Snippet: GetAttributionSettingsAsync(GetAttributionSettingsRequest, CallSettings)
            // Additional: GetAttributionSettingsAsync(GetAttributionSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAttributionSettingsRequest request = new GetAttributionSettingsRequest
            {
                AttributionSettingsName = AttributionSettingsName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            AttributionSettings response = await analyticsAdminServiceClient.GetAttributionSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttributionSettings</summary>
        public void GetAttributionSettings()
        {
            // Snippet: GetAttributionSettings(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/attributionSettings";
            // Make the request
            AttributionSettings response = analyticsAdminServiceClient.GetAttributionSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttributionSettingsAsync</summary>
        public async Task GetAttributionSettingsAsync()
        {
            // Snippet: GetAttributionSettingsAsync(string, CallSettings)
            // Additional: GetAttributionSettingsAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/attributionSettings";
            // Make the request
            AttributionSettings response = await analyticsAdminServiceClient.GetAttributionSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttributionSettings</summary>
        public void GetAttributionSettingsResourceNames()
        {
            // Snippet: GetAttributionSettings(AttributionSettingsName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AttributionSettingsName name = AttributionSettingsName.FromProperty("[PROPERTY]");
            // Make the request
            AttributionSettings response = analyticsAdminServiceClient.GetAttributionSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttributionSettingsAsync</summary>
        public async Task GetAttributionSettingsResourceNamesAsync()
        {
            // Snippet: GetAttributionSettingsAsync(AttributionSettingsName, CallSettings)
            // Additional: GetAttributionSettingsAsync(AttributionSettingsName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AttributionSettingsName name = AttributionSettingsName.FromProperty("[PROPERTY]");
            // Make the request
            AttributionSettings response = await analyticsAdminServiceClient.GetAttributionSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttributionSettings</summary>
        public void UpdateAttributionSettingsRequestObject()
        {
            // Snippet: UpdateAttributionSettings(UpdateAttributionSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateAttributionSettingsRequest request = new UpdateAttributionSettingsRequest
            {
                AttributionSettings = new AttributionSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AttributionSettings response = analyticsAdminServiceClient.UpdateAttributionSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttributionSettingsAsync</summary>
        public async Task UpdateAttributionSettingsRequestObjectAsync()
        {
            // Snippet: UpdateAttributionSettingsAsync(UpdateAttributionSettingsRequest, CallSettings)
            // Additional: UpdateAttributionSettingsAsync(UpdateAttributionSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAttributionSettingsRequest request = new UpdateAttributionSettingsRequest
            {
                AttributionSettings = new AttributionSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AttributionSettings response = await analyticsAdminServiceClient.UpdateAttributionSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttributionSettings</summary>
        public void UpdateAttributionSettings()
        {
            // Snippet: UpdateAttributionSettings(AttributionSettings, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AttributionSettings attributionSettings = new AttributionSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AttributionSettings response = analyticsAdminServiceClient.UpdateAttributionSettings(attributionSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAttributionSettingsAsync</summary>
        public async Task UpdateAttributionSettingsAsync()
        {
            // Snippet: UpdateAttributionSettingsAsync(AttributionSettings, FieldMask, CallSettings)
            // Additional: UpdateAttributionSettingsAsync(AttributionSettings, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AttributionSettings attributionSettings = new AttributionSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AttributionSettings response = await analyticsAdminServiceClient.UpdateAttributionSettingsAsync(attributionSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for RunAccessReport</summary>
        public void RunAccessReportRequestObject()
        {
            // Snippet: RunAccessReport(RunAccessReportRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            RunAccessReportRequest request = new RunAccessReportRequest
            {
                Entity = "",
                Dimensions =
                {
                    new AccessDimension(),
                },
                Metrics = { new AccessMetric(), },
                DateRanges =
                {
                    new AccessDateRange(),
                },
                DimensionFilter = new AccessFilterExpression(),
                MetricFilter = new AccessFilterExpression(),
                Offset = 0L,
                Limit = 0L,
                TimeZone = "",
                OrderBys =
                {
                    new AccessOrderBy(),
                },
                ReturnEntityQuota = false,
                IncludeAllUsers = false,
                ExpandGroups = false,
            };
            // Make the request
            RunAccessReportResponse response = analyticsAdminServiceClient.RunAccessReport(request);
            // End snippet
        }

        /// <summary>Snippet for RunAccessReportAsync</summary>
        public async Task RunAccessReportRequestObjectAsync()
        {
            // Snippet: RunAccessReportAsync(RunAccessReportRequest, CallSettings)
            // Additional: RunAccessReportAsync(RunAccessReportRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunAccessReportRequest request = new RunAccessReportRequest
            {
                Entity = "",
                Dimensions =
                {
                    new AccessDimension(),
                },
                Metrics = { new AccessMetric(), },
                DateRanges =
                {
                    new AccessDateRange(),
                },
                DimensionFilter = new AccessFilterExpression(),
                MetricFilter = new AccessFilterExpression(),
                Offset = 0L,
                Limit = 0L,
                TimeZone = "",
                OrderBys =
                {
                    new AccessOrderBy(),
                },
                ReturnEntityQuota = false,
                IncludeAllUsers = false,
                ExpandGroups = false,
            };
            // Make the request
            RunAccessReportResponse response = await analyticsAdminServiceClient.RunAccessReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessBinding</summary>
        public void CreateAccessBindingRequestObject()
        {
            // Snippet: CreateAccessBinding(CreateAccessBindingRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateAccessBindingRequest request = new CreateAccessBindingRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                AccessBinding = new AccessBinding(),
            };
            // Make the request
            AccessBinding response = analyticsAdminServiceClient.CreateAccessBinding(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessBindingAsync</summary>
        public async Task CreateAccessBindingRequestObjectAsync()
        {
            // Snippet: CreateAccessBindingAsync(CreateAccessBindingRequest, CallSettings)
            // Additional: CreateAccessBindingAsync(CreateAccessBindingRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAccessBindingRequest request = new CreateAccessBindingRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                AccessBinding = new AccessBinding(),
            };
            // Make the request
            AccessBinding response = await analyticsAdminServiceClient.CreateAccessBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessBinding</summary>
        public void CreateAccessBinding()
        {
            // Snippet: CreateAccessBinding(string, AccessBinding, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            AccessBinding accessBinding = new AccessBinding();
            // Make the request
            AccessBinding response = analyticsAdminServiceClient.CreateAccessBinding(parent, accessBinding);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessBindingAsync</summary>
        public async Task CreateAccessBindingAsync()
        {
            // Snippet: CreateAccessBindingAsync(string, AccessBinding, CallSettings)
            // Additional: CreateAccessBindingAsync(string, AccessBinding, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            AccessBinding accessBinding = new AccessBinding();
            // Make the request
            AccessBinding response = await analyticsAdminServiceClient.CreateAccessBindingAsync(parent, accessBinding);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessBinding</summary>
        public void CreateAccessBindingResourceNames1()
        {
            // Snippet: CreateAccessBinding(AccountName, AccessBinding, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            AccessBinding accessBinding = new AccessBinding();
            // Make the request
            AccessBinding response = analyticsAdminServiceClient.CreateAccessBinding(parent, accessBinding);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessBindingAsync</summary>
        public async Task CreateAccessBindingResourceNames1Async()
        {
            // Snippet: CreateAccessBindingAsync(AccountName, AccessBinding, CallSettings)
            // Additional: CreateAccessBindingAsync(AccountName, AccessBinding, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            AccessBinding accessBinding = new AccessBinding();
            // Make the request
            AccessBinding response = await analyticsAdminServiceClient.CreateAccessBindingAsync(parent, accessBinding);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessBinding</summary>
        public void CreateAccessBindingResourceNames2()
        {
            // Snippet: CreateAccessBinding(PropertyName, AccessBinding, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            AccessBinding accessBinding = new AccessBinding();
            // Make the request
            AccessBinding response = analyticsAdminServiceClient.CreateAccessBinding(parent, accessBinding);
            // End snippet
        }

        /// <summary>Snippet for CreateAccessBindingAsync</summary>
        public async Task CreateAccessBindingResourceNames2Async()
        {
            // Snippet: CreateAccessBindingAsync(PropertyName, AccessBinding, CallSettings)
            // Additional: CreateAccessBindingAsync(PropertyName, AccessBinding, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            AccessBinding accessBinding = new AccessBinding();
            // Make the request
            AccessBinding response = await analyticsAdminServiceClient.CreateAccessBindingAsync(parent, accessBinding);
            // End snippet
        }

        /// <summary>Snippet for GetAccessBinding</summary>
        public void GetAccessBindingRequestObject()
        {
            // Snippet: GetAccessBinding(GetAccessBindingRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetAccessBindingRequest request = new GetAccessBindingRequest
            {
                AccessBindingName = AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]"),
            };
            // Make the request
            AccessBinding response = analyticsAdminServiceClient.GetAccessBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessBindingAsync</summary>
        public async Task GetAccessBindingRequestObjectAsync()
        {
            // Snippet: GetAccessBindingAsync(GetAccessBindingRequest, CallSettings)
            // Additional: GetAccessBindingAsync(GetAccessBindingRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccessBindingRequest request = new GetAccessBindingRequest
            {
                AccessBindingName = AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]"),
            };
            // Make the request
            AccessBinding response = await analyticsAdminServiceClient.GetAccessBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessBinding</summary>
        public void GetAccessBinding()
        {
            // Snippet: GetAccessBinding(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/accessBindings/[ACCESS_BINDING]";
            // Make the request
            AccessBinding response = analyticsAdminServiceClient.GetAccessBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessBindingAsync</summary>
        public async Task GetAccessBindingAsync()
        {
            // Snippet: GetAccessBindingAsync(string, CallSettings)
            // Additional: GetAccessBindingAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/accessBindings/[ACCESS_BINDING]";
            // Make the request
            AccessBinding response = await analyticsAdminServiceClient.GetAccessBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessBinding</summary>
        public void GetAccessBindingResourceNames()
        {
            // Snippet: GetAccessBinding(AccessBindingName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AccessBindingName name = AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]");
            // Make the request
            AccessBinding response = analyticsAdminServiceClient.GetAccessBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessBindingAsync</summary>
        public async Task GetAccessBindingResourceNamesAsync()
        {
            // Snippet: GetAccessBindingAsync(AccessBindingName, CallSettings)
            // Additional: GetAccessBindingAsync(AccessBindingName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccessBindingName name = AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]");
            // Make the request
            AccessBinding response = await analyticsAdminServiceClient.GetAccessBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessBinding</summary>
        public void UpdateAccessBindingRequestObject()
        {
            // Snippet: UpdateAccessBinding(UpdateAccessBindingRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateAccessBindingRequest request = new UpdateAccessBindingRequest
            {
                AccessBinding = new AccessBinding(),
            };
            // Make the request
            AccessBinding response = analyticsAdminServiceClient.UpdateAccessBinding(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessBindingAsync</summary>
        public async Task UpdateAccessBindingRequestObjectAsync()
        {
            // Snippet: UpdateAccessBindingAsync(UpdateAccessBindingRequest, CallSettings)
            // Additional: UpdateAccessBindingAsync(UpdateAccessBindingRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccessBindingRequest request = new UpdateAccessBindingRequest
            {
                AccessBinding = new AccessBinding(),
            };
            // Make the request
            AccessBinding response = await analyticsAdminServiceClient.UpdateAccessBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessBinding</summary>
        public void UpdateAccessBinding()
        {
            // Snippet: UpdateAccessBinding(AccessBinding, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AccessBinding accessBinding = new AccessBinding();
            // Make the request
            AccessBinding response = analyticsAdminServiceClient.UpdateAccessBinding(accessBinding);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessBindingAsync</summary>
        public async Task UpdateAccessBindingAsync()
        {
            // Snippet: UpdateAccessBindingAsync(AccessBinding, CallSettings)
            // Additional: UpdateAccessBindingAsync(AccessBinding, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccessBinding accessBinding = new AccessBinding();
            // Make the request
            AccessBinding response = await analyticsAdminServiceClient.UpdateAccessBindingAsync(accessBinding);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessBinding</summary>
        public void DeleteAccessBindingRequestObject()
        {
            // Snippet: DeleteAccessBinding(DeleteAccessBindingRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteAccessBindingRequest request = new DeleteAccessBindingRequest
            {
                AccessBindingName = AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteAccessBinding(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessBindingAsync</summary>
        public async Task DeleteAccessBindingRequestObjectAsync()
        {
            // Snippet: DeleteAccessBindingAsync(DeleteAccessBindingRequest, CallSettings)
            // Additional: DeleteAccessBindingAsync(DeleteAccessBindingRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccessBindingRequest request = new DeleteAccessBindingRequest
            {
                AccessBindingName = AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteAccessBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessBinding</summary>
        public void DeleteAccessBinding()
        {
            // Snippet: DeleteAccessBinding(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/accessBindings/[ACCESS_BINDING]";
            // Make the request
            analyticsAdminServiceClient.DeleteAccessBinding(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessBindingAsync</summary>
        public async Task DeleteAccessBindingAsync()
        {
            // Snippet: DeleteAccessBindingAsync(string, CallSettings)
            // Additional: DeleteAccessBindingAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/accessBindings/[ACCESS_BINDING]";
            // Make the request
            await analyticsAdminServiceClient.DeleteAccessBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessBinding</summary>
        public void DeleteAccessBindingResourceNames()
        {
            // Snippet: DeleteAccessBinding(AccessBindingName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AccessBindingName name = AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]");
            // Make the request
            analyticsAdminServiceClient.DeleteAccessBinding(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessBindingAsync</summary>
        public async Task DeleteAccessBindingResourceNamesAsync()
        {
            // Snippet: DeleteAccessBindingAsync(AccessBindingName, CallSettings)
            // Additional: DeleteAccessBindingAsync(AccessBindingName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccessBindingName name = AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]");
            // Make the request
            await analyticsAdminServiceClient.DeleteAccessBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAccessBindings</summary>
        public void ListAccessBindingsRequestObject()
        {
            // Snippet: ListAccessBindings(ListAccessBindingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListAccessBindingsRequest request = new ListAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListAccessBindingsResponse, AccessBinding> response = analyticsAdminServiceClient.ListAccessBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessBindingsAsync</summary>
        public async Task ListAccessBindingsRequestObjectAsync()
        {
            // Snippet: ListAccessBindingsAsync(ListAccessBindingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccessBindingsRequest request = new ListAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAccessBindingsResponse, AccessBinding> response = analyticsAdminServiceClient.ListAccessBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessBindings</summary>
        public void ListAccessBindings()
        {
            // Snippet: ListAccessBindings(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListAccessBindingsResponse, AccessBinding> response = analyticsAdminServiceClient.ListAccessBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessBindingsAsync</summary>
        public async Task ListAccessBindingsAsync()
        {
            // Snippet: ListAccessBindingsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListAccessBindingsResponse, AccessBinding> response = analyticsAdminServiceClient.ListAccessBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessBindings</summary>
        public void ListAccessBindingsResourceNames1()
        {
            // Snippet: ListAccessBindings(AccountName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListAccessBindingsResponse, AccessBinding> response = analyticsAdminServiceClient.ListAccessBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessBindingsAsync</summary>
        public async Task ListAccessBindingsResourceNames1Async()
        {
            // Snippet: ListAccessBindingsAsync(AccountName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListAccessBindingsResponse, AccessBinding> response = analyticsAdminServiceClient.ListAccessBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessBindings</summary>
        public void ListAccessBindingsResourceNames2()
        {
            // Snippet: ListAccessBindings(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListAccessBindingsResponse, AccessBinding> response = analyticsAdminServiceClient.ListAccessBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessBindingsAsync</summary>
        public async Task ListAccessBindingsResourceNames2Async()
        {
            // Snippet: ListAccessBindingsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListAccessBindingsResponse, AccessBinding> response = analyticsAdminServiceClient.ListAccessBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccessBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAccessBindings</summary>
        public void BatchCreateAccessBindingsRequestObject()
        {
            // Snippet: BatchCreateAccessBindings(BatchCreateAccessBindingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateAccessBindingsRequest request = new BatchCreateAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new CreateAccessBindingRequest(),
                },
            };
            // Make the request
            BatchCreateAccessBindingsResponse response = analyticsAdminServiceClient.BatchCreateAccessBindings(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAccessBindingsAsync</summary>
        public async Task BatchCreateAccessBindingsRequestObjectAsync()
        {
            // Snippet: BatchCreateAccessBindingsAsync(BatchCreateAccessBindingsRequest, CallSettings)
            // Additional: BatchCreateAccessBindingsAsync(BatchCreateAccessBindingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateAccessBindingsRequest request = new BatchCreateAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new CreateAccessBindingRequest(),
                },
            };
            // Make the request
            BatchCreateAccessBindingsResponse response = await analyticsAdminServiceClient.BatchCreateAccessBindingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetAccessBindings</summary>
        public void BatchGetAccessBindingsRequestObject()
        {
            // Snippet: BatchGetAccessBindings(BatchGetAccessBindingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BatchGetAccessBindingsRequest request = new BatchGetAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                AccessBindingNames =
                {
                    AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]"),
                },
            };
            // Make the request
            BatchGetAccessBindingsResponse response = analyticsAdminServiceClient.BatchGetAccessBindings(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetAccessBindingsAsync</summary>
        public async Task BatchGetAccessBindingsRequestObjectAsync()
        {
            // Snippet: BatchGetAccessBindingsAsync(BatchGetAccessBindingsRequest, CallSettings)
            // Additional: BatchGetAccessBindingsAsync(BatchGetAccessBindingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetAccessBindingsRequest request = new BatchGetAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                AccessBindingNames =
                {
                    AccessBindingName.FromAccountAccessBinding("[ACCOUNT]", "[ACCESS_BINDING]"),
                },
            };
            // Make the request
            BatchGetAccessBindingsResponse response = await analyticsAdminServiceClient.BatchGetAccessBindingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAccessBindings</summary>
        public void BatchUpdateAccessBindingsRequestObject()
        {
            // Snippet: BatchUpdateAccessBindings(BatchUpdateAccessBindingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateAccessBindingsRequest request = new BatchUpdateAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new UpdateAccessBindingRequest(),
                },
            };
            // Make the request
            BatchUpdateAccessBindingsResponse response = analyticsAdminServiceClient.BatchUpdateAccessBindings(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAccessBindingsAsync</summary>
        public async Task BatchUpdateAccessBindingsRequestObjectAsync()
        {
            // Snippet: BatchUpdateAccessBindingsAsync(BatchUpdateAccessBindingsRequest, CallSettings)
            // Additional: BatchUpdateAccessBindingsAsync(BatchUpdateAccessBindingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateAccessBindingsRequest request = new BatchUpdateAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new UpdateAccessBindingRequest(),
                },
            };
            // Make the request
            BatchUpdateAccessBindingsResponse response = await analyticsAdminServiceClient.BatchUpdateAccessBindingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAccessBindings</summary>
        public void BatchDeleteAccessBindingsRequestObject()
        {
            // Snippet: BatchDeleteAccessBindings(BatchDeleteAccessBindingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteAccessBindingsRequest request = new BatchDeleteAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new DeleteAccessBindingRequest(),
                },
            };
            // Make the request
            analyticsAdminServiceClient.BatchDeleteAccessBindings(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAccessBindingsAsync</summary>
        public async Task BatchDeleteAccessBindingsRequestObjectAsync()
        {
            // Snippet: BatchDeleteAccessBindingsAsync(BatchDeleteAccessBindingsRequest, CallSettings)
            // Additional: BatchDeleteAccessBindingsAsync(BatchDeleteAccessBindingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteAccessBindingsRequest request = new BatchDeleteAccessBindingsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new DeleteAccessBindingRequest(),
                },
            };
            // Make the request
            await analyticsAdminServiceClient.BatchDeleteAccessBindingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedDataSet</summary>
        public void GetExpandedDataSetRequestObject()
        {
            // Snippet: GetExpandedDataSet(GetExpandedDataSetRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetExpandedDataSetRequest request = new GetExpandedDataSetRequest
            {
                ExpandedDataSetName = ExpandedDataSetName.FromPropertyExpandedDataSet("[PROPERTY]", "[EXPANDED_DATA_SET]"),
            };
            // Make the request
            ExpandedDataSet response = analyticsAdminServiceClient.GetExpandedDataSet(request);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedDataSetAsync</summary>
        public async Task GetExpandedDataSetRequestObjectAsync()
        {
            // Snippet: GetExpandedDataSetAsync(GetExpandedDataSetRequest, CallSettings)
            // Additional: GetExpandedDataSetAsync(GetExpandedDataSetRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetExpandedDataSetRequest request = new GetExpandedDataSetRequest
            {
                ExpandedDataSetName = ExpandedDataSetName.FromPropertyExpandedDataSet("[PROPERTY]", "[EXPANDED_DATA_SET]"),
            };
            // Make the request
            ExpandedDataSet response = await analyticsAdminServiceClient.GetExpandedDataSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedDataSet</summary>
        public void GetExpandedDataSet()
        {
            // Snippet: GetExpandedDataSet(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/expandedDataSets/[EXPANDED_DATA_SET]";
            // Make the request
            ExpandedDataSet response = analyticsAdminServiceClient.GetExpandedDataSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedDataSetAsync</summary>
        public async Task GetExpandedDataSetAsync()
        {
            // Snippet: GetExpandedDataSetAsync(string, CallSettings)
            // Additional: GetExpandedDataSetAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/expandedDataSets/[EXPANDED_DATA_SET]";
            // Make the request
            ExpandedDataSet response = await analyticsAdminServiceClient.GetExpandedDataSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedDataSet</summary>
        public void GetExpandedDataSetResourceNames()
        {
            // Snippet: GetExpandedDataSet(ExpandedDataSetName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ExpandedDataSetName name = ExpandedDataSetName.FromPropertyExpandedDataSet("[PROPERTY]", "[EXPANDED_DATA_SET]");
            // Make the request
            ExpandedDataSet response = analyticsAdminServiceClient.GetExpandedDataSet(name);
            // End snippet
        }

        /// <summary>Snippet for GetExpandedDataSetAsync</summary>
        public async Task GetExpandedDataSetResourceNamesAsync()
        {
            // Snippet: GetExpandedDataSetAsync(ExpandedDataSetName, CallSettings)
            // Additional: GetExpandedDataSetAsync(ExpandedDataSetName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExpandedDataSetName name = ExpandedDataSetName.FromPropertyExpandedDataSet("[PROPERTY]", "[EXPANDED_DATA_SET]");
            // Make the request
            ExpandedDataSet response = await analyticsAdminServiceClient.GetExpandedDataSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListExpandedDataSets</summary>
        public void ListExpandedDataSetsRequestObject()
        {
            // Snippet: ListExpandedDataSets(ListExpandedDataSetsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListExpandedDataSetsRequest request = new ListExpandedDataSetsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListExpandedDataSetsResponse, ExpandedDataSet> response = analyticsAdminServiceClient.ListExpandedDataSets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExpandedDataSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExpandedDataSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExpandedDataSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExpandedDataSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExpandedDataSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExpandedDataSetsAsync</summary>
        public async Task ListExpandedDataSetsRequestObjectAsync()
        {
            // Snippet: ListExpandedDataSetsAsync(ListExpandedDataSetsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListExpandedDataSetsRequest request = new ListExpandedDataSetsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListExpandedDataSetsResponse, ExpandedDataSet> response = analyticsAdminServiceClient.ListExpandedDataSetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExpandedDataSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExpandedDataSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExpandedDataSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExpandedDataSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExpandedDataSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExpandedDataSets</summary>
        public void ListExpandedDataSets()
        {
            // Snippet: ListExpandedDataSets(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListExpandedDataSetsResponse, ExpandedDataSet> response = analyticsAdminServiceClient.ListExpandedDataSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExpandedDataSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExpandedDataSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExpandedDataSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExpandedDataSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExpandedDataSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExpandedDataSetsAsync</summary>
        public async Task ListExpandedDataSetsAsync()
        {
            // Snippet: ListExpandedDataSetsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListExpandedDataSetsResponse, ExpandedDataSet> response = analyticsAdminServiceClient.ListExpandedDataSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExpandedDataSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExpandedDataSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExpandedDataSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExpandedDataSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExpandedDataSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExpandedDataSets</summary>
        public void ListExpandedDataSetsResourceNames()
        {
            // Snippet: ListExpandedDataSets(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListExpandedDataSetsResponse, ExpandedDataSet> response = analyticsAdminServiceClient.ListExpandedDataSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExpandedDataSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExpandedDataSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExpandedDataSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExpandedDataSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExpandedDataSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExpandedDataSetsAsync</summary>
        public async Task ListExpandedDataSetsResourceNamesAsync()
        {
            // Snippet: ListExpandedDataSetsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListExpandedDataSetsResponse, ExpandedDataSet> response = analyticsAdminServiceClient.ListExpandedDataSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExpandedDataSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExpandedDataSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExpandedDataSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExpandedDataSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExpandedDataSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateExpandedDataSet</summary>
        public void CreateExpandedDataSetRequestObject()
        {
            // Snippet: CreateExpandedDataSet(CreateExpandedDataSetRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateExpandedDataSetRequest request = new CreateExpandedDataSetRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                ExpandedDataSet = new ExpandedDataSet(),
            };
            // Make the request
            ExpandedDataSet response = analyticsAdminServiceClient.CreateExpandedDataSet(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExpandedDataSetAsync</summary>
        public async Task CreateExpandedDataSetRequestObjectAsync()
        {
            // Snippet: CreateExpandedDataSetAsync(CreateExpandedDataSetRequest, CallSettings)
            // Additional: CreateExpandedDataSetAsync(CreateExpandedDataSetRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateExpandedDataSetRequest request = new CreateExpandedDataSetRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                ExpandedDataSet = new ExpandedDataSet(),
            };
            // Make the request
            ExpandedDataSet response = await analyticsAdminServiceClient.CreateExpandedDataSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateExpandedDataSet</summary>
        public void CreateExpandedDataSet()
        {
            // Snippet: CreateExpandedDataSet(string, ExpandedDataSet, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            ExpandedDataSet expandedDataSet = new ExpandedDataSet();
            // Make the request
            ExpandedDataSet response = analyticsAdminServiceClient.CreateExpandedDataSet(parent, expandedDataSet);
            // End snippet
        }

        /// <summary>Snippet for CreateExpandedDataSetAsync</summary>
        public async Task CreateExpandedDataSetAsync()
        {
            // Snippet: CreateExpandedDataSetAsync(string, ExpandedDataSet, CallSettings)
            // Additional: CreateExpandedDataSetAsync(string, ExpandedDataSet, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            ExpandedDataSet expandedDataSet = new ExpandedDataSet();
            // Make the request
            ExpandedDataSet response = await analyticsAdminServiceClient.CreateExpandedDataSetAsync(parent, expandedDataSet);
            // End snippet
        }

        /// <summary>Snippet for CreateExpandedDataSet</summary>
        public void CreateExpandedDataSetResourceNames()
        {
            // Snippet: CreateExpandedDataSet(PropertyName, ExpandedDataSet, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            ExpandedDataSet expandedDataSet = new ExpandedDataSet();
            // Make the request
            ExpandedDataSet response = analyticsAdminServiceClient.CreateExpandedDataSet(parent, expandedDataSet);
            // End snippet
        }

        /// <summary>Snippet for CreateExpandedDataSetAsync</summary>
        public async Task CreateExpandedDataSetResourceNamesAsync()
        {
            // Snippet: CreateExpandedDataSetAsync(PropertyName, ExpandedDataSet, CallSettings)
            // Additional: CreateExpandedDataSetAsync(PropertyName, ExpandedDataSet, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            ExpandedDataSet expandedDataSet = new ExpandedDataSet();
            // Make the request
            ExpandedDataSet response = await analyticsAdminServiceClient.CreateExpandedDataSetAsync(parent, expandedDataSet);
            // End snippet
        }

        /// <summary>Snippet for UpdateExpandedDataSet</summary>
        public void UpdateExpandedDataSetRequestObject()
        {
            // Snippet: UpdateExpandedDataSet(UpdateExpandedDataSetRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateExpandedDataSetRequest request = new UpdateExpandedDataSetRequest
            {
                ExpandedDataSet = new ExpandedDataSet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ExpandedDataSet response = analyticsAdminServiceClient.UpdateExpandedDataSet(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExpandedDataSetAsync</summary>
        public async Task UpdateExpandedDataSetRequestObjectAsync()
        {
            // Snippet: UpdateExpandedDataSetAsync(UpdateExpandedDataSetRequest, CallSettings)
            // Additional: UpdateExpandedDataSetAsync(UpdateExpandedDataSetRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExpandedDataSetRequest request = new UpdateExpandedDataSetRequest
            {
                ExpandedDataSet = new ExpandedDataSet(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ExpandedDataSet response = await analyticsAdminServiceClient.UpdateExpandedDataSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateExpandedDataSet</summary>
        public void UpdateExpandedDataSet()
        {
            // Snippet: UpdateExpandedDataSet(ExpandedDataSet, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ExpandedDataSet expandedDataSet = new ExpandedDataSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ExpandedDataSet response = analyticsAdminServiceClient.UpdateExpandedDataSet(expandedDataSet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateExpandedDataSetAsync</summary>
        public async Task UpdateExpandedDataSetAsync()
        {
            // Snippet: UpdateExpandedDataSetAsync(ExpandedDataSet, FieldMask, CallSettings)
            // Additional: UpdateExpandedDataSetAsync(ExpandedDataSet, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExpandedDataSet expandedDataSet = new ExpandedDataSet();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ExpandedDataSet response = await analyticsAdminServiceClient.UpdateExpandedDataSetAsync(expandedDataSet, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteExpandedDataSet</summary>
        public void DeleteExpandedDataSetRequestObject()
        {
            // Snippet: DeleteExpandedDataSet(DeleteExpandedDataSetRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteExpandedDataSetRequest request = new DeleteExpandedDataSetRequest
            {
                ExpandedDataSetName = ExpandedDataSetName.FromPropertyExpandedDataSet("[PROPERTY]", "[EXPANDED_DATA_SET]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteExpandedDataSet(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExpandedDataSetAsync</summary>
        public async Task DeleteExpandedDataSetRequestObjectAsync()
        {
            // Snippet: DeleteExpandedDataSetAsync(DeleteExpandedDataSetRequest, CallSettings)
            // Additional: DeleteExpandedDataSetAsync(DeleteExpandedDataSetRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExpandedDataSetRequest request = new DeleteExpandedDataSetRequest
            {
                ExpandedDataSetName = ExpandedDataSetName.FromPropertyExpandedDataSet("[PROPERTY]", "[EXPANDED_DATA_SET]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteExpandedDataSetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteExpandedDataSet</summary>
        public void DeleteExpandedDataSet()
        {
            // Snippet: DeleteExpandedDataSet(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/expandedDataSets/[EXPANDED_DATA_SET]";
            // Make the request
            analyticsAdminServiceClient.DeleteExpandedDataSet(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExpandedDataSetAsync</summary>
        public async Task DeleteExpandedDataSetAsync()
        {
            // Snippet: DeleteExpandedDataSetAsync(string, CallSettings)
            // Additional: DeleteExpandedDataSetAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/expandedDataSets/[EXPANDED_DATA_SET]";
            // Make the request
            await analyticsAdminServiceClient.DeleteExpandedDataSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExpandedDataSet</summary>
        public void DeleteExpandedDataSetResourceNames()
        {
            // Snippet: DeleteExpandedDataSet(ExpandedDataSetName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ExpandedDataSetName name = ExpandedDataSetName.FromPropertyExpandedDataSet("[PROPERTY]", "[EXPANDED_DATA_SET]");
            // Make the request
            analyticsAdminServiceClient.DeleteExpandedDataSet(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteExpandedDataSetAsync</summary>
        public async Task DeleteExpandedDataSetResourceNamesAsync()
        {
            // Snippet: DeleteExpandedDataSetAsync(ExpandedDataSetName, CallSettings)
            // Additional: DeleteExpandedDataSetAsync(ExpandedDataSetName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExpandedDataSetName name = ExpandedDataSetName.FromPropertyExpandedDataSet("[PROPERTY]", "[EXPANDED_DATA_SET]");
            // Make the request
            await analyticsAdminServiceClient.DeleteExpandedDataSetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelGroup</summary>
        public void GetChannelGroupRequestObject()
        {
            // Snippet: GetChannelGroup(GetChannelGroupRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetChannelGroupRequest request = new GetChannelGroupRequest
            {
                ChannelGroupName = ChannelGroupName.FromPropertyChannelGroup("[PROPERTY]", "[CHANNEL_GROUP]"),
            };
            // Make the request
            ChannelGroup response = analyticsAdminServiceClient.GetChannelGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetChannelGroupAsync</summary>
        public async Task GetChannelGroupRequestObjectAsync()
        {
            // Snippet: GetChannelGroupAsync(GetChannelGroupRequest, CallSettings)
            // Additional: GetChannelGroupAsync(GetChannelGroupRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetChannelGroupRequest request = new GetChannelGroupRequest
            {
                ChannelGroupName = ChannelGroupName.FromPropertyChannelGroup("[PROPERTY]", "[CHANNEL_GROUP]"),
            };
            // Make the request
            ChannelGroup response = await analyticsAdminServiceClient.GetChannelGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChannelGroup</summary>
        public void GetChannelGroup()
        {
            // Snippet: GetChannelGroup(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/channelGroups/[CHANNEL_GROUP]";
            // Make the request
            ChannelGroup response = analyticsAdminServiceClient.GetChannelGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelGroupAsync</summary>
        public async Task GetChannelGroupAsync()
        {
            // Snippet: GetChannelGroupAsync(string, CallSettings)
            // Additional: GetChannelGroupAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/channelGroups/[CHANNEL_GROUP]";
            // Make the request
            ChannelGroup response = await analyticsAdminServiceClient.GetChannelGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelGroup</summary>
        public void GetChannelGroupResourceNames()
        {
            // Snippet: GetChannelGroup(ChannelGroupName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ChannelGroupName name = ChannelGroupName.FromPropertyChannelGroup("[PROPERTY]", "[CHANNEL_GROUP]");
            // Make the request
            ChannelGroup response = analyticsAdminServiceClient.GetChannelGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetChannelGroupAsync</summary>
        public async Task GetChannelGroupResourceNamesAsync()
        {
            // Snippet: GetChannelGroupAsync(ChannelGroupName, CallSettings)
            // Additional: GetChannelGroupAsync(ChannelGroupName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChannelGroupName name = ChannelGroupName.FromPropertyChannelGroup("[PROPERTY]", "[CHANNEL_GROUP]");
            // Make the request
            ChannelGroup response = await analyticsAdminServiceClient.GetChannelGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListChannelGroups</summary>
        public void ListChannelGroupsRequestObject()
        {
            // Snippet: ListChannelGroups(ListChannelGroupsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListChannelGroupsRequest request = new ListChannelGroupsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListChannelGroupsResponse, ChannelGroup> response = analyticsAdminServiceClient.ListChannelGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChannelGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelGroupsAsync</summary>
        public async Task ListChannelGroupsRequestObjectAsync()
        {
            // Snippet: ListChannelGroupsAsync(ListChannelGroupsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListChannelGroupsRequest request = new ListChannelGroupsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListChannelGroupsResponse, ChannelGroup> response = analyticsAdminServiceClient.ListChannelGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChannelGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelGroups</summary>
        public void ListChannelGroups()
        {
            // Snippet: ListChannelGroups(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListChannelGroupsResponse, ChannelGroup> response = analyticsAdminServiceClient.ListChannelGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChannelGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelGroupsAsync</summary>
        public async Task ListChannelGroupsAsync()
        {
            // Snippet: ListChannelGroupsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListChannelGroupsResponse, ChannelGroup> response = analyticsAdminServiceClient.ListChannelGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChannelGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelGroups</summary>
        public void ListChannelGroupsResourceNames()
        {
            // Snippet: ListChannelGroups(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListChannelGroupsResponse, ChannelGroup> response = analyticsAdminServiceClient.ListChannelGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChannelGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChannelGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChannelGroupsAsync</summary>
        public async Task ListChannelGroupsResourceNamesAsync()
        {
            // Snippet: ListChannelGroupsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListChannelGroupsResponse, ChannelGroup> response = analyticsAdminServiceClient.ListChannelGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ChannelGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChannelGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChannelGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChannelGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChannelGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateChannelGroup</summary>
        public void CreateChannelGroupRequestObject()
        {
            // Snippet: CreateChannelGroup(CreateChannelGroupRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateChannelGroupRequest request = new CreateChannelGroupRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                ChannelGroup = new ChannelGroup(),
            };
            // Make the request
            ChannelGroup response = analyticsAdminServiceClient.CreateChannelGroup(request);
            // End snippet
        }

        /// <summary>Snippet for CreateChannelGroupAsync</summary>
        public async Task CreateChannelGroupRequestObjectAsync()
        {
            // Snippet: CreateChannelGroupAsync(CreateChannelGroupRequest, CallSettings)
            // Additional: CreateChannelGroupAsync(CreateChannelGroupRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateChannelGroupRequest request = new CreateChannelGroupRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                ChannelGroup = new ChannelGroup(),
            };
            // Make the request
            ChannelGroup response = await analyticsAdminServiceClient.CreateChannelGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateChannelGroup</summary>
        public void CreateChannelGroup()
        {
            // Snippet: CreateChannelGroup(string, ChannelGroup, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            ChannelGroup channelGroup = new ChannelGroup();
            // Make the request
            ChannelGroup response = analyticsAdminServiceClient.CreateChannelGroup(parent, channelGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateChannelGroupAsync</summary>
        public async Task CreateChannelGroupAsync()
        {
            // Snippet: CreateChannelGroupAsync(string, ChannelGroup, CallSettings)
            // Additional: CreateChannelGroupAsync(string, ChannelGroup, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            ChannelGroup channelGroup = new ChannelGroup();
            // Make the request
            ChannelGroup response = await analyticsAdminServiceClient.CreateChannelGroupAsync(parent, channelGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateChannelGroup</summary>
        public void CreateChannelGroupResourceNames()
        {
            // Snippet: CreateChannelGroup(PropertyName, ChannelGroup, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            ChannelGroup channelGroup = new ChannelGroup();
            // Make the request
            ChannelGroup response = analyticsAdminServiceClient.CreateChannelGroup(parent, channelGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateChannelGroupAsync</summary>
        public async Task CreateChannelGroupResourceNamesAsync()
        {
            // Snippet: CreateChannelGroupAsync(PropertyName, ChannelGroup, CallSettings)
            // Additional: CreateChannelGroupAsync(PropertyName, ChannelGroup, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            ChannelGroup channelGroup = new ChannelGroup();
            // Make the request
            ChannelGroup response = await analyticsAdminServiceClient.CreateChannelGroupAsync(parent, channelGroup);
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelGroup</summary>
        public void UpdateChannelGroupRequestObject()
        {
            // Snippet: UpdateChannelGroup(UpdateChannelGroupRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateChannelGroupRequest request = new UpdateChannelGroupRequest
            {
                ChannelGroup = new ChannelGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ChannelGroup response = analyticsAdminServiceClient.UpdateChannelGroup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelGroupAsync</summary>
        public async Task UpdateChannelGroupRequestObjectAsync()
        {
            // Snippet: UpdateChannelGroupAsync(UpdateChannelGroupRequest, CallSettings)
            // Additional: UpdateChannelGroupAsync(UpdateChannelGroupRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateChannelGroupRequest request = new UpdateChannelGroupRequest
            {
                ChannelGroup = new ChannelGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ChannelGroup response = await analyticsAdminServiceClient.UpdateChannelGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelGroup</summary>
        public void UpdateChannelGroup()
        {
            // Snippet: UpdateChannelGroup(ChannelGroup, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ChannelGroup channelGroup = new ChannelGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ChannelGroup response = analyticsAdminServiceClient.UpdateChannelGroup(channelGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateChannelGroupAsync</summary>
        public async Task UpdateChannelGroupAsync()
        {
            // Snippet: UpdateChannelGroupAsync(ChannelGroup, FieldMask, CallSettings)
            // Additional: UpdateChannelGroupAsync(ChannelGroup, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChannelGroup channelGroup = new ChannelGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ChannelGroup response = await analyticsAdminServiceClient.UpdateChannelGroupAsync(channelGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelGroup</summary>
        public void DeleteChannelGroupRequestObject()
        {
            // Snippet: DeleteChannelGroup(DeleteChannelGroupRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteChannelGroupRequest request = new DeleteChannelGroupRequest
            {
                ChannelGroupName = ChannelGroupName.FromPropertyChannelGroup("[PROPERTY]", "[CHANNEL_GROUP]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteChannelGroup(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelGroupAsync</summary>
        public async Task DeleteChannelGroupRequestObjectAsync()
        {
            // Snippet: DeleteChannelGroupAsync(DeleteChannelGroupRequest, CallSettings)
            // Additional: DeleteChannelGroupAsync(DeleteChannelGroupRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteChannelGroupRequest request = new DeleteChannelGroupRequest
            {
                ChannelGroupName = ChannelGroupName.FromPropertyChannelGroup("[PROPERTY]", "[CHANNEL_GROUP]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteChannelGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelGroup</summary>
        public void DeleteChannelGroup()
        {
            // Snippet: DeleteChannelGroup(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/channelGroups/[CHANNEL_GROUP]";
            // Make the request
            analyticsAdminServiceClient.DeleteChannelGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelGroupAsync</summary>
        public async Task DeleteChannelGroupAsync()
        {
            // Snippet: DeleteChannelGroupAsync(string, CallSettings)
            // Additional: DeleteChannelGroupAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/channelGroups/[CHANNEL_GROUP]";
            // Make the request
            await analyticsAdminServiceClient.DeleteChannelGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelGroup</summary>
        public void DeleteChannelGroupResourceNames()
        {
            // Snippet: DeleteChannelGroup(ChannelGroupName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ChannelGroupName name = ChannelGroupName.FromPropertyChannelGroup("[PROPERTY]", "[CHANNEL_GROUP]");
            // Make the request
            analyticsAdminServiceClient.DeleteChannelGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteChannelGroupAsync</summary>
        public async Task DeleteChannelGroupResourceNamesAsync()
        {
            // Snippet: DeleteChannelGroupAsync(ChannelGroupName, CallSettings)
            // Additional: DeleteChannelGroupAsync(ChannelGroupName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChannelGroupName name = ChannelGroupName.FromPropertyChannelGroup("[PROPERTY]", "[CHANNEL_GROUP]");
            // Make the request
            await analyticsAdminServiceClient.DeleteChannelGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetAutomatedGa4ConfigurationOptOut</summary>
        public void SetAutomatedGa4ConfigurationOptOutRequestObject()
        {
            // Snippet: SetAutomatedGa4ConfigurationOptOut(SetAutomatedGa4ConfigurationOptOutRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SetAutomatedGa4ConfigurationOptOutRequest request = new SetAutomatedGa4ConfigurationOptOutRequest
            {
                Property = "",
                OptOut = false,
            };
            // Make the request
            SetAutomatedGa4ConfigurationOptOutResponse response = analyticsAdminServiceClient.SetAutomatedGa4ConfigurationOptOut(request);
            // End snippet
        }

        /// <summary>Snippet for SetAutomatedGa4ConfigurationOptOutAsync</summary>
        public async Task SetAutomatedGa4ConfigurationOptOutRequestObjectAsync()
        {
            // Snippet: SetAutomatedGa4ConfigurationOptOutAsync(SetAutomatedGa4ConfigurationOptOutRequest, CallSettings)
            // Additional: SetAutomatedGa4ConfigurationOptOutAsync(SetAutomatedGa4ConfigurationOptOutRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetAutomatedGa4ConfigurationOptOutRequest request = new SetAutomatedGa4ConfigurationOptOutRequest
            {
                Property = "",
                OptOut = false,
            };
            // Make the request
            SetAutomatedGa4ConfigurationOptOutResponse response = await analyticsAdminServiceClient.SetAutomatedGa4ConfigurationOptOutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchAutomatedGa4ConfigurationOptOut</summary>
        public void FetchAutomatedGa4ConfigurationOptOutRequestObject()
        {
            // Snippet: FetchAutomatedGa4ConfigurationOptOut(FetchAutomatedGa4ConfigurationOptOutRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            FetchAutomatedGa4ConfigurationOptOutRequest request = new FetchAutomatedGa4ConfigurationOptOutRequest { Property = "", };
            // Make the request
            FetchAutomatedGa4ConfigurationOptOutResponse response = analyticsAdminServiceClient.FetchAutomatedGa4ConfigurationOptOut(request);
            // End snippet
        }

        /// <summary>Snippet for FetchAutomatedGa4ConfigurationOptOutAsync</summary>
        public async Task FetchAutomatedGa4ConfigurationOptOutRequestObjectAsync()
        {
            // Snippet: FetchAutomatedGa4ConfigurationOptOutAsync(FetchAutomatedGa4ConfigurationOptOutRequest, CallSettings)
            // Additional: FetchAutomatedGa4ConfigurationOptOutAsync(FetchAutomatedGa4ConfigurationOptOutRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchAutomatedGa4ConfigurationOptOutRequest request = new FetchAutomatedGa4ConfigurationOptOutRequest { Property = "", };
            // Make the request
            FetchAutomatedGa4ConfigurationOptOutResponse response = await analyticsAdminServiceClient.FetchAutomatedGa4ConfigurationOptOutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryLink</summary>
        public void CreateBigQueryLinkRequestObject()
        {
            // Snippet: CreateBigQueryLink(CreateBigQueryLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateBigQueryLinkRequest request = new CreateBigQueryLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                BigqueryLink = new BigQueryLink(),
            };
            // Make the request
            BigQueryLink response = analyticsAdminServiceClient.CreateBigQueryLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryLinkAsync</summary>
        public async Task CreateBigQueryLinkRequestObjectAsync()
        {
            // Snippet: CreateBigQueryLinkAsync(CreateBigQueryLinkRequest, CallSettings)
            // Additional: CreateBigQueryLinkAsync(CreateBigQueryLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateBigQueryLinkRequest request = new CreateBigQueryLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                BigqueryLink = new BigQueryLink(),
            };
            // Make the request
            BigQueryLink response = await analyticsAdminServiceClient.CreateBigQueryLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryLink</summary>
        public void CreateBigQueryLink()
        {
            // Snippet: CreateBigQueryLink(string, BigQueryLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            BigQueryLink bigqueryLink = new BigQueryLink();
            // Make the request
            BigQueryLink response = analyticsAdminServiceClient.CreateBigQueryLink(parent, bigqueryLink);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryLinkAsync</summary>
        public async Task CreateBigQueryLinkAsync()
        {
            // Snippet: CreateBigQueryLinkAsync(string, BigQueryLink, CallSettings)
            // Additional: CreateBigQueryLinkAsync(string, BigQueryLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            BigQueryLink bigqueryLink = new BigQueryLink();
            // Make the request
            BigQueryLink response = await analyticsAdminServiceClient.CreateBigQueryLinkAsync(parent, bigqueryLink);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryLink</summary>
        public void CreateBigQueryLinkResourceNames()
        {
            // Snippet: CreateBigQueryLink(PropertyName, BigQueryLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            BigQueryLink bigqueryLink = new BigQueryLink();
            // Make the request
            BigQueryLink response = analyticsAdminServiceClient.CreateBigQueryLink(parent, bigqueryLink);
            // End snippet
        }

        /// <summary>Snippet for CreateBigQueryLinkAsync</summary>
        public async Task CreateBigQueryLinkResourceNamesAsync()
        {
            // Snippet: CreateBigQueryLinkAsync(PropertyName, BigQueryLink, CallSettings)
            // Additional: CreateBigQueryLinkAsync(PropertyName, BigQueryLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            BigQueryLink bigqueryLink = new BigQueryLink();
            // Make the request
            BigQueryLink response = await analyticsAdminServiceClient.CreateBigQueryLinkAsync(parent, bigqueryLink);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryLink</summary>
        public void GetBigQueryLinkRequestObject()
        {
            // Snippet: GetBigQueryLink(GetBigQueryLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetBigQueryLinkRequest request = new GetBigQueryLinkRequest
            {
                BigQueryLinkName = BigQueryLinkName.FromPropertyBigqueryLink("[PROPERTY]", "[BIGQUERY_LINK]"),
            };
            // Make the request
            BigQueryLink response = analyticsAdminServiceClient.GetBigQueryLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryLinkAsync</summary>
        public async Task GetBigQueryLinkRequestObjectAsync()
        {
            // Snippet: GetBigQueryLinkAsync(GetBigQueryLinkRequest, CallSettings)
            // Additional: GetBigQueryLinkAsync(GetBigQueryLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetBigQueryLinkRequest request = new GetBigQueryLinkRequest
            {
                BigQueryLinkName = BigQueryLinkName.FromPropertyBigqueryLink("[PROPERTY]", "[BIGQUERY_LINK]"),
            };
            // Make the request
            BigQueryLink response = await analyticsAdminServiceClient.GetBigQueryLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryLink</summary>
        public void GetBigQueryLink()
        {
            // Snippet: GetBigQueryLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/bigQueryLinks/[BIGQUERY_LINK]";
            // Make the request
            BigQueryLink response = analyticsAdminServiceClient.GetBigQueryLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryLinkAsync</summary>
        public async Task GetBigQueryLinkAsync()
        {
            // Snippet: GetBigQueryLinkAsync(string, CallSettings)
            // Additional: GetBigQueryLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/bigQueryLinks/[BIGQUERY_LINK]";
            // Make the request
            BigQueryLink response = await analyticsAdminServiceClient.GetBigQueryLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryLink</summary>
        public void GetBigQueryLinkResourceNames()
        {
            // Snippet: GetBigQueryLink(BigQueryLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BigQueryLinkName name = BigQueryLinkName.FromPropertyBigqueryLink("[PROPERTY]", "[BIGQUERY_LINK]");
            // Make the request
            BigQueryLink response = analyticsAdminServiceClient.GetBigQueryLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetBigQueryLinkAsync</summary>
        public async Task GetBigQueryLinkResourceNamesAsync()
        {
            // Snippet: GetBigQueryLinkAsync(BigQueryLinkName, CallSettings)
            // Additional: GetBigQueryLinkAsync(BigQueryLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BigQueryLinkName name = BigQueryLinkName.FromPropertyBigqueryLink("[PROPERTY]", "[BIGQUERY_LINK]");
            // Make the request
            BigQueryLink response = await analyticsAdminServiceClient.GetBigQueryLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryLinks</summary>
        public void ListBigQueryLinksRequestObject()
        {
            // Snippet: ListBigQueryLinks(ListBigQueryLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListBigQueryLinksRequest request = new ListBigQueryLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListBigQueryLinksResponse, BigQueryLink> response = analyticsAdminServiceClient.ListBigQueryLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BigQueryLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBigQueryLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryLinksAsync</summary>
        public async Task ListBigQueryLinksRequestObjectAsync()
        {
            // Snippet: ListBigQueryLinksAsync(ListBigQueryLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListBigQueryLinksRequest request = new ListBigQueryLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBigQueryLinksResponse, BigQueryLink> response = analyticsAdminServiceClient.ListBigQueryLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BigQueryLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBigQueryLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryLinks</summary>
        public void ListBigQueryLinks()
        {
            // Snippet: ListBigQueryLinks(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListBigQueryLinksResponse, BigQueryLink> response = analyticsAdminServiceClient.ListBigQueryLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BigQueryLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBigQueryLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryLinksAsync</summary>
        public async Task ListBigQueryLinksAsync()
        {
            // Snippet: ListBigQueryLinksAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListBigQueryLinksResponse, BigQueryLink> response = analyticsAdminServiceClient.ListBigQueryLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BigQueryLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBigQueryLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryLinks</summary>
        public void ListBigQueryLinksResourceNames()
        {
            // Snippet: ListBigQueryLinks(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListBigQueryLinksResponse, BigQueryLink> response = analyticsAdminServiceClient.ListBigQueryLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BigQueryLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBigQueryLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBigQueryLinksAsync</summary>
        public async Task ListBigQueryLinksResourceNamesAsync()
        {
            // Snippet: ListBigQueryLinksAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListBigQueryLinksResponse, BigQueryLink> response = analyticsAdminServiceClient.ListBigQueryLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BigQueryLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBigQueryLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BigQueryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BigQueryLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BigQueryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryLink</summary>
        public void DeleteBigQueryLinkRequestObject()
        {
            // Snippet: DeleteBigQueryLink(DeleteBigQueryLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteBigQueryLinkRequest request = new DeleteBigQueryLinkRequest
            {
                BigQueryLinkName = BigQueryLinkName.FromPropertyBigqueryLink("[PROPERTY]", "[BIGQUERY_LINK]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteBigQueryLink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryLinkAsync</summary>
        public async Task DeleteBigQueryLinkRequestObjectAsync()
        {
            // Snippet: DeleteBigQueryLinkAsync(DeleteBigQueryLinkRequest, CallSettings)
            // Additional: DeleteBigQueryLinkAsync(DeleteBigQueryLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBigQueryLinkRequest request = new DeleteBigQueryLinkRequest
            {
                BigQueryLinkName = BigQueryLinkName.FromPropertyBigqueryLink("[PROPERTY]", "[BIGQUERY_LINK]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteBigQueryLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryLink</summary>
        public void DeleteBigQueryLink()
        {
            // Snippet: DeleteBigQueryLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/bigQueryLinks/[BIGQUERY_LINK]";
            // Make the request
            analyticsAdminServiceClient.DeleteBigQueryLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryLinkAsync</summary>
        public async Task DeleteBigQueryLinkAsync()
        {
            // Snippet: DeleteBigQueryLinkAsync(string, CallSettings)
            // Additional: DeleteBigQueryLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/bigQueryLinks/[BIGQUERY_LINK]";
            // Make the request
            await analyticsAdminServiceClient.DeleteBigQueryLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryLink</summary>
        public void DeleteBigQueryLinkResourceNames()
        {
            // Snippet: DeleteBigQueryLink(BigQueryLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BigQueryLinkName name = BigQueryLinkName.FromPropertyBigqueryLink("[PROPERTY]", "[BIGQUERY_LINK]");
            // Make the request
            analyticsAdminServiceClient.DeleteBigQueryLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBigQueryLinkAsync</summary>
        public async Task DeleteBigQueryLinkResourceNamesAsync()
        {
            // Snippet: DeleteBigQueryLinkAsync(BigQueryLinkName, CallSettings)
            // Additional: DeleteBigQueryLinkAsync(BigQueryLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BigQueryLinkName name = BigQueryLinkName.FromPropertyBigqueryLink("[PROPERTY]", "[BIGQUERY_LINK]");
            // Make the request
            await analyticsAdminServiceClient.DeleteBigQueryLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryLink</summary>
        public void UpdateBigQueryLinkRequestObject()
        {
            // Snippet: UpdateBigQueryLink(UpdateBigQueryLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateBigQueryLinkRequest request = new UpdateBigQueryLinkRequest
            {
                BigqueryLink = new BigQueryLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BigQueryLink response = analyticsAdminServiceClient.UpdateBigQueryLink(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryLinkAsync</summary>
        public async Task UpdateBigQueryLinkRequestObjectAsync()
        {
            // Snippet: UpdateBigQueryLinkAsync(UpdateBigQueryLinkRequest, CallSettings)
            // Additional: UpdateBigQueryLinkAsync(UpdateBigQueryLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBigQueryLinkRequest request = new UpdateBigQueryLinkRequest
            {
                BigqueryLink = new BigQueryLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            BigQueryLink response = await analyticsAdminServiceClient.UpdateBigQueryLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryLink</summary>
        public void UpdateBigQueryLink()
        {
            // Snippet: UpdateBigQueryLink(BigQueryLink, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BigQueryLink bigqueryLink = new BigQueryLink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BigQueryLink response = analyticsAdminServiceClient.UpdateBigQueryLink(bigqueryLink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBigQueryLinkAsync</summary>
        public async Task UpdateBigQueryLinkAsync()
        {
            // Snippet: UpdateBigQueryLinkAsync(BigQueryLink, FieldMask, CallSettings)
            // Additional: UpdateBigQueryLinkAsync(BigQueryLink, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BigQueryLink bigqueryLink = new BigQueryLink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            BigQueryLink response = await analyticsAdminServiceClient.UpdateBigQueryLinkAsync(bigqueryLink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetEnhancedMeasurementSettings</summary>
        public void GetEnhancedMeasurementSettingsRequestObject()
        {
            // Snippet: GetEnhancedMeasurementSettings(GetEnhancedMeasurementSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetEnhancedMeasurementSettingsRequest request = new GetEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            EnhancedMeasurementSettings response = analyticsAdminServiceClient.GetEnhancedMeasurementSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnhancedMeasurementSettingsAsync</summary>
        public async Task GetEnhancedMeasurementSettingsRequestObjectAsync()
        {
            // Snippet: GetEnhancedMeasurementSettingsAsync(GetEnhancedMeasurementSettingsRequest, CallSettings)
            // Additional: GetEnhancedMeasurementSettingsAsync(GetEnhancedMeasurementSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEnhancedMeasurementSettingsRequest request = new GetEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            EnhancedMeasurementSettings response = await analyticsAdminServiceClient.GetEnhancedMeasurementSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEnhancedMeasurementSettings</summary>
        public void GetEnhancedMeasurementSettings()
        {
            // Snippet: GetEnhancedMeasurementSettings(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/enhancedMeasurementSettings";
            // Make the request
            EnhancedMeasurementSettings response = analyticsAdminServiceClient.GetEnhancedMeasurementSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnhancedMeasurementSettingsAsync</summary>
        public async Task GetEnhancedMeasurementSettingsAsync()
        {
            // Snippet: GetEnhancedMeasurementSettingsAsync(string, CallSettings)
            // Additional: GetEnhancedMeasurementSettingsAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/enhancedMeasurementSettings";
            // Make the request
            EnhancedMeasurementSettings response = await analyticsAdminServiceClient.GetEnhancedMeasurementSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnhancedMeasurementSettings</summary>
        public void GetEnhancedMeasurementSettingsResourceNames()
        {
            // Snippet: GetEnhancedMeasurementSettings(EnhancedMeasurementSettingsName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            EnhancedMeasurementSettingsName name = EnhancedMeasurementSettingsName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            EnhancedMeasurementSettings response = analyticsAdminServiceClient.GetEnhancedMeasurementSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetEnhancedMeasurementSettingsAsync</summary>
        public async Task GetEnhancedMeasurementSettingsResourceNamesAsync()
        {
            // Snippet: GetEnhancedMeasurementSettingsAsync(EnhancedMeasurementSettingsName, CallSettings)
            // Additional: GetEnhancedMeasurementSettingsAsync(EnhancedMeasurementSettingsName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnhancedMeasurementSettingsName name = EnhancedMeasurementSettingsName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            EnhancedMeasurementSettings response = await analyticsAdminServiceClient.GetEnhancedMeasurementSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateEnhancedMeasurementSettings</summary>
        public void UpdateEnhancedMeasurementSettingsRequestObject()
        {
            // Snippet: UpdateEnhancedMeasurementSettings(UpdateEnhancedMeasurementSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateEnhancedMeasurementSettingsRequest request = new UpdateEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettings = new EnhancedMeasurementSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EnhancedMeasurementSettings response = analyticsAdminServiceClient.UpdateEnhancedMeasurementSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEnhancedMeasurementSettingsAsync</summary>
        public async Task UpdateEnhancedMeasurementSettingsRequestObjectAsync()
        {
            // Snippet: UpdateEnhancedMeasurementSettingsAsync(UpdateEnhancedMeasurementSettingsRequest, CallSettings)
            // Additional: UpdateEnhancedMeasurementSettingsAsync(UpdateEnhancedMeasurementSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEnhancedMeasurementSettingsRequest request = new UpdateEnhancedMeasurementSettingsRequest
            {
                EnhancedMeasurementSettings = new EnhancedMeasurementSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EnhancedMeasurementSettings response = await analyticsAdminServiceClient.UpdateEnhancedMeasurementSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEnhancedMeasurementSettings</summary>
        public void UpdateEnhancedMeasurementSettings()
        {
            // Snippet: UpdateEnhancedMeasurementSettings(EnhancedMeasurementSettings, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            EnhancedMeasurementSettings enhancedMeasurementSettings = new EnhancedMeasurementSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EnhancedMeasurementSettings response = analyticsAdminServiceClient.UpdateEnhancedMeasurementSettings(enhancedMeasurementSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEnhancedMeasurementSettingsAsync</summary>
        public async Task UpdateEnhancedMeasurementSettingsAsync()
        {
            // Snippet: UpdateEnhancedMeasurementSettingsAsync(EnhancedMeasurementSettings, FieldMask, CallSettings)
            // Additional: UpdateEnhancedMeasurementSettingsAsync(EnhancedMeasurementSettings, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            EnhancedMeasurementSettings enhancedMeasurementSettings = new EnhancedMeasurementSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EnhancedMeasurementSettings response = await analyticsAdminServiceClient.UpdateEnhancedMeasurementSettingsAsync(enhancedMeasurementSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectedSiteTag</summary>
        public void CreateConnectedSiteTagRequestObject()
        {
            // Snippet: CreateConnectedSiteTag(CreateConnectedSiteTagRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateConnectedSiteTagRequest request = new CreateConnectedSiteTagRequest
            {
                Property = "",
                ConnectedSiteTag = new ConnectedSiteTag(),
            };
            // Make the request
            CreateConnectedSiteTagResponse response = analyticsAdminServiceClient.CreateConnectedSiteTag(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectedSiteTagAsync</summary>
        public async Task CreateConnectedSiteTagRequestObjectAsync()
        {
            // Snippet: CreateConnectedSiteTagAsync(CreateConnectedSiteTagRequest, CallSettings)
            // Additional: CreateConnectedSiteTagAsync(CreateConnectedSiteTagRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectedSiteTagRequest request = new CreateConnectedSiteTagRequest
            {
                Property = "",
                ConnectedSiteTag = new ConnectedSiteTag(),
            };
            // Make the request
            CreateConnectedSiteTagResponse response = await analyticsAdminServiceClient.CreateConnectedSiteTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectedSiteTag</summary>
        public void DeleteConnectedSiteTagRequestObject()
        {
            // Snippet: DeleteConnectedSiteTag(DeleteConnectedSiteTagRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteConnectedSiteTagRequest request = new DeleteConnectedSiteTagRequest
            {
                Property = "",
                TagId = "",
            };
            // Make the request
            analyticsAdminServiceClient.DeleteConnectedSiteTag(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectedSiteTagAsync</summary>
        public async Task DeleteConnectedSiteTagRequestObjectAsync()
        {
            // Snippet: DeleteConnectedSiteTagAsync(DeleteConnectedSiteTagRequest, CallSettings)
            // Additional: DeleteConnectedSiteTagAsync(DeleteConnectedSiteTagRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectedSiteTagRequest request = new DeleteConnectedSiteTagRequest
            {
                Property = "",
                TagId = "",
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteConnectedSiteTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListConnectedSiteTags</summary>
        public void ListConnectedSiteTagsRequestObject()
        {
            // Snippet: ListConnectedSiteTags(ListConnectedSiteTagsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListConnectedSiteTagsRequest request = new ListConnectedSiteTagsRequest { Property = "", };
            // Make the request
            ListConnectedSiteTagsResponse response = analyticsAdminServiceClient.ListConnectedSiteTags(request);
            // End snippet
        }

        /// <summary>Snippet for ListConnectedSiteTagsAsync</summary>
        public async Task ListConnectedSiteTagsRequestObjectAsync()
        {
            // Snippet: ListConnectedSiteTagsAsync(ListConnectedSiteTagsRequest, CallSettings)
            // Additional: ListConnectedSiteTagsAsync(ListConnectedSiteTagsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectedSiteTagsRequest request = new ListConnectedSiteTagsRequest { Property = "", };
            // Make the request
            ListConnectedSiteTagsResponse response = await analyticsAdminServiceClient.ListConnectedSiteTagsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchConnectedGa4Property</summary>
        public void FetchConnectedGa4PropertyRequestObject()
        {
            // Snippet: FetchConnectedGa4Property(FetchConnectedGa4PropertyRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            FetchConnectedGa4PropertyRequest request = new FetchConnectedGa4PropertyRequest
            {
                PropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            FetchConnectedGa4PropertyResponse response = analyticsAdminServiceClient.FetchConnectedGa4Property(request);
            // End snippet
        }

        /// <summary>Snippet for FetchConnectedGa4PropertyAsync</summary>
        public async Task FetchConnectedGa4PropertyRequestObjectAsync()
        {
            // Snippet: FetchConnectedGa4PropertyAsync(FetchConnectedGa4PropertyRequest, CallSettings)
            // Additional: FetchConnectedGa4PropertyAsync(FetchConnectedGa4PropertyRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchConnectedGa4PropertyRequest request = new FetchConnectedGa4PropertyRequest
            {
                PropertyAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            FetchConnectedGa4PropertyResponse response = await analyticsAdminServiceClient.FetchConnectedGa4PropertyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdSenseLink</summary>
        public void GetAdSenseLinkRequestObject()
        {
            // Snippet: GetAdSenseLink(GetAdSenseLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetAdSenseLinkRequest request = new GetAdSenseLinkRequest
            {
                AdSenseLinkName = AdSenseLinkName.FromPropertyAdsenseLink("[PROPERTY]", "[ADSENSE_LINK]"),
            };
            // Make the request
            AdSenseLink response = analyticsAdminServiceClient.GetAdSenseLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdSenseLinkAsync</summary>
        public async Task GetAdSenseLinkRequestObjectAsync()
        {
            // Snippet: GetAdSenseLinkAsync(GetAdSenseLinkRequest, CallSettings)
            // Additional: GetAdSenseLinkAsync(GetAdSenseLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdSenseLinkRequest request = new GetAdSenseLinkRequest
            {
                AdSenseLinkName = AdSenseLinkName.FromPropertyAdsenseLink("[PROPERTY]", "[ADSENSE_LINK]"),
            };
            // Make the request
            AdSenseLink response = await analyticsAdminServiceClient.GetAdSenseLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdSenseLink</summary>
        public void GetAdSenseLink()
        {
            // Snippet: GetAdSenseLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/adSenseLinks/[ADSENSE_LINK]";
            // Make the request
            AdSenseLink response = analyticsAdminServiceClient.GetAdSenseLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdSenseLinkAsync</summary>
        public async Task GetAdSenseLinkAsync()
        {
            // Snippet: GetAdSenseLinkAsync(string, CallSettings)
            // Additional: GetAdSenseLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/adSenseLinks/[ADSENSE_LINK]";
            // Make the request
            AdSenseLink response = await analyticsAdminServiceClient.GetAdSenseLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdSenseLink</summary>
        public void GetAdSenseLinkResourceNames()
        {
            // Snippet: GetAdSenseLink(AdSenseLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AdSenseLinkName name = AdSenseLinkName.FromPropertyAdsenseLink("[PROPERTY]", "[ADSENSE_LINK]");
            // Make the request
            AdSenseLink response = analyticsAdminServiceClient.GetAdSenseLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdSenseLinkAsync</summary>
        public async Task GetAdSenseLinkResourceNamesAsync()
        {
            // Snippet: GetAdSenseLinkAsync(AdSenseLinkName, CallSettings)
            // Additional: GetAdSenseLinkAsync(AdSenseLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdSenseLinkName name = AdSenseLinkName.FromPropertyAdsenseLink("[PROPERTY]", "[ADSENSE_LINK]");
            // Make the request
            AdSenseLink response = await analyticsAdminServiceClient.GetAdSenseLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSenseLink</summary>
        public void CreateAdSenseLinkRequestObject()
        {
            // Snippet: CreateAdSenseLink(CreateAdSenseLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateAdSenseLinkRequest request = new CreateAdSenseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                AdsenseLink = new AdSenseLink(),
            };
            // Make the request
            AdSenseLink response = analyticsAdminServiceClient.CreateAdSenseLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSenseLinkAsync</summary>
        public async Task CreateAdSenseLinkRequestObjectAsync()
        {
            // Snippet: CreateAdSenseLinkAsync(CreateAdSenseLinkRequest, CallSettings)
            // Additional: CreateAdSenseLinkAsync(CreateAdSenseLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAdSenseLinkRequest request = new CreateAdSenseLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                AdsenseLink = new AdSenseLink(),
            };
            // Make the request
            AdSenseLink response = await analyticsAdminServiceClient.CreateAdSenseLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSenseLink</summary>
        public void CreateAdSenseLink()
        {
            // Snippet: CreateAdSenseLink(string, AdSenseLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            AdSenseLink adsenseLink = new AdSenseLink();
            // Make the request
            AdSenseLink response = analyticsAdminServiceClient.CreateAdSenseLink(parent, adsenseLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSenseLinkAsync</summary>
        public async Task CreateAdSenseLinkAsync()
        {
            // Snippet: CreateAdSenseLinkAsync(string, AdSenseLink, CallSettings)
            // Additional: CreateAdSenseLinkAsync(string, AdSenseLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            AdSenseLink adsenseLink = new AdSenseLink();
            // Make the request
            AdSenseLink response = await analyticsAdminServiceClient.CreateAdSenseLinkAsync(parent, adsenseLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSenseLink</summary>
        public void CreateAdSenseLinkResourceNames()
        {
            // Snippet: CreateAdSenseLink(PropertyName, AdSenseLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            AdSenseLink adsenseLink = new AdSenseLink();
            // Make the request
            AdSenseLink response = analyticsAdminServiceClient.CreateAdSenseLink(parent, adsenseLink);
            // End snippet
        }

        /// <summary>Snippet for CreateAdSenseLinkAsync</summary>
        public async Task CreateAdSenseLinkResourceNamesAsync()
        {
            // Snippet: CreateAdSenseLinkAsync(PropertyName, AdSenseLink, CallSettings)
            // Additional: CreateAdSenseLinkAsync(PropertyName, AdSenseLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            AdSenseLink adsenseLink = new AdSenseLink();
            // Make the request
            AdSenseLink response = await analyticsAdminServiceClient.CreateAdSenseLinkAsync(parent, adsenseLink);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdSenseLink</summary>
        public void DeleteAdSenseLinkRequestObject()
        {
            // Snippet: DeleteAdSenseLink(DeleteAdSenseLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteAdSenseLinkRequest request = new DeleteAdSenseLinkRequest
            {
                AdSenseLinkName = AdSenseLinkName.FromPropertyAdsenseLink("[PROPERTY]", "[ADSENSE_LINK]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteAdSenseLink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdSenseLinkAsync</summary>
        public async Task DeleteAdSenseLinkRequestObjectAsync()
        {
            // Snippet: DeleteAdSenseLinkAsync(DeleteAdSenseLinkRequest, CallSettings)
            // Additional: DeleteAdSenseLinkAsync(DeleteAdSenseLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAdSenseLinkRequest request = new DeleteAdSenseLinkRequest
            {
                AdSenseLinkName = AdSenseLinkName.FromPropertyAdsenseLink("[PROPERTY]", "[ADSENSE_LINK]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteAdSenseLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdSenseLink</summary>
        public void DeleteAdSenseLink()
        {
            // Snippet: DeleteAdSenseLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/adSenseLinks/[ADSENSE_LINK]";
            // Make the request
            analyticsAdminServiceClient.DeleteAdSenseLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdSenseLinkAsync</summary>
        public async Task DeleteAdSenseLinkAsync()
        {
            // Snippet: DeleteAdSenseLinkAsync(string, CallSettings)
            // Additional: DeleteAdSenseLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/adSenseLinks/[ADSENSE_LINK]";
            // Make the request
            await analyticsAdminServiceClient.DeleteAdSenseLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdSenseLink</summary>
        public void DeleteAdSenseLinkResourceNames()
        {
            // Snippet: DeleteAdSenseLink(AdSenseLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AdSenseLinkName name = AdSenseLinkName.FromPropertyAdsenseLink("[PROPERTY]", "[ADSENSE_LINK]");
            // Make the request
            analyticsAdminServiceClient.DeleteAdSenseLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAdSenseLinkAsync</summary>
        public async Task DeleteAdSenseLinkResourceNamesAsync()
        {
            // Snippet: DeleteAdSenseLinkAsync(AdSenseLinkName, CallSettings)
            // Additional: DeleteAdSenseLinkAsync(AdSenseLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdSenseLinkName name = AdSenseLinkName.FromPropertyAdsenseLink("[PROPERTY]", "[ADSENSE_LINK]");
            // Make the request
            await analyticsAdminServiceClient.DeleteAdSenseLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAdSenseLinks</summary>
        public void ListAdSenseLinksRequestObject()
        {
            // Snippet: ListAdSenseLinks(ListAdSenseLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListAdSenseLinksRequest request = new ListAdSenseLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListAdSenseLinksResponse, AdSenseLink> response = analyticsAdminServiceClient.ListAdSenseLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdSenseLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdSenseLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSenseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSenseLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSenseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSenseLinksAsync</summary>
        public async Task ListAdSenseLinksRequestObjectAsync()
        {
            // Snippet: ListAdSenseLinksAsync(ListAdSenseLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdSenseLinksRequest request = new ListAdSenseLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAdSenseLinksResponse, AdSenseLink> response = analyticsAdminServiceClient.ListAdSenseLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdSenseLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdSenseLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSenseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSenseLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSenseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSenseLinks</summary>
        public void ListAdSenseLinks()
        {
            // Snippet: ListAdSenseLinks(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListAdSenseLinksResponse, AdSenseLink> response = analyticsAdminServiceClient.ListAdSenseLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdSenseLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdSenseLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSenseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSenseLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSenseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSenseLinksAsync</summary>
        public async Task ListAdSenseLinksAsync()
        {
            // Snippet: ListAdSenseLinksAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListAdSenseLinksResponse, AdSenseLink> response = analyticsAdminServiceClient.ListAdSenseLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdSenseLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdSenseLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSenseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSenseLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSenseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSenseLinks</summary>
        public void ListAdSenseLinksResourceNames()
        {
            // Snippet: ListAdSenseLinks(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListAdSenseLinksResponse, AdSenseLink> response = analyticsAdminServiceClient.ListAdSenseLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdSenseLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdSenseLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSenseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSenseLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSenseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdSenseLinksAsync</summary>
        public async Task ListAdSenseLinksResourceNamesAsync()
        {
            // Snippet: ListAdSenseLinksAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListAdSenseLinksResponse, AdSenseLink> response = analyticsAdminServiceClient.ListAdSenseLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AdSenseLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAdSenseLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdSenseLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdSenseLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdSenseLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEventCreateRule</summary>
        public void GetEventCreateRuleRequestObject()
        {
            // Snippet: GetEventCreateRule(GetEventCreateRuleRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetEventCreateRuleRequest request = new GetEventCreateRuleRequest
            {
                EventCreateRuleName = EventCreateRuleName.FromPropertyDataStreamEventCreateRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_CREATE_RULE]"),
            };
            // Make the request
            EventCreateRule response = analyticsAdminServiceClient.GetEventCreateRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetEventCreateRuleAsync</summary>
        public async Task GetEventCreateRuleRequestObjectAsync()
        {
            // Snippet: GetEventCreateRuleAsync(GetEventCreateRuleRequest, CallSettings)
            // Additional: GetEventCreateRuleAsync(GetEventCreateRuleRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEventCreateRuleRequest request = new GetEventCreateRuleRequest
            {
                EventCreateRuleName = EventCreateRuleName.FromPropertyDataStreamEventCreateRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_CREATE_RULE]"),
            };
            // Make the request
            EventCreateRule response = await analyticsAdminServiceClient.GetEventCreateRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEventCreateRule</summary>
        public void GetEventCreateRule()
        {
            // Snippet: GetEventCreateRule(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/eventCreateRules/[EVENT_CREATE_RULE]";
            // Make the request
            EventCreateRule response = analyticsAdminServiceClient.GetEventCreateRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventCreateRuleAsync</summary>
        public async Task GetEventCreateRuleAsync()
        {
            // Snippet: GetEventCreateRuleAsync(string, CallSettings)
            // Additional: GetEventCreateRuleAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/eventCreateRules/[EVENT_CREATE_RULE]";
            // Make the request
            EventCreateRule response = await analyticsAdminServiceClient.GetEventCreateRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventCreateRule</summary>
        public void GetEventCreateRuleResourceNames()
        {
            // Snippet: GetEventCreateRule(EventCreateRuleName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            EventCreateRuleName name = EventCreateRuleName.FromPropertyDataStreamEventCreateRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_CREATE_RULE]");
            // Make the request
            EventCreateRule response = analyticsAdminServiceClient.GetEventCreateRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventCreateRuleAsync</summary>
        public async Task GetEventCreateRuleResourceNamesAsync()
        {
            // Snippet: GetEventCreateRuleAsync(EventCreateRuleName, CallSettings)
            // Additional: GetEventCreateRuleAsync(EventCreateRuleName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventCreateRuleName name = EventCreateRuleName.FromPropertyDataStreamEventCreateRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_CREATE_RULE]");
            // Make the request
            EventCreateRule response = await analyticsAdminServiceClient.GetEventCreateRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEventCreateRules</summary>
        public void ListEventCreateRulesRequestObject()
        {
            // Snippet: ListEventCreateRules(ListEventCreateRulesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListEventCreateRulesRequest request = new ListEventCreateRulesRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            PagedEnumerable<ListEventCreateRulesResponse, EventCreateRule> response = analyticsAdminServiceClient.ListEventCreateRules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventCreateRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventCreateRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventCreateRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventCreateRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventCreateRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventCreateRulesAsync</summary>
        public async Task ListEventCreateRulesRequestObjectAsync()
        {
            // Snippet: ListEventCreateRulesAsync(ListEventCreateRulesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEventCreateRulesRequest request = new ListEventCreateRulesRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEventCreateRulesResponse, EventCreateRule> response = analyticsAdminServiceClient.ListEventCreateRulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventCreateRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventCreateRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventCreateRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventCreateRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventCreateRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventCreateRules</summary>
        public void ListEventCreateRules()
        {
            // Snippet: ListEventCreateRules(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            PagedEnumerable<ListEventCreateRulesResponse, EventCreateRule> response = analyticsAdminServiceClient.ListEventCreateRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventCreateRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventCreateRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventCreateRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventCreateRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventCreateRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventCreateRulesAsync</summary>
        public async Task ListEventCreateRulesAsync()
        {
            // Snippet: ListEventCreateRulesAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            PagedAsyncEnumerable<ListEventCreateRulesResponse, EventCreateRule> response = analyticsAdminServiceClient.ListEventCreateRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventCreateRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventCreateRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventCreateRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventCreateRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventCreateRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventCreateRules</summary>
        public void ListEventCreateRulesResourceNames()
        {
            // Snippet: ListEventCreateRules(DataStreamName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            PagedEnumerable<ListEventCreateRulesResponse, EventCreateRule> response = analyticsAdminServiceClient.ListEventCreateRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventCreateRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventCreateRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventCreateRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventCreateRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventCreateRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventCreateRulesAsync</summary>
        public async Task ListEventCreateRulesResourceNamesAsync()
        {
            // Snippet: ListEventCreateRulesAsync(DataStreamName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            PagedAsyncEnumerable<ListEventCreateRulesResponse, EventCreateRule> response = analyticsAdminServiceClient.ListEventCreateRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventCreateRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventCreateRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventCreateRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventCreateRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventCreateRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateEventCreateRule</summary>
        public void CreateEventCreateRuleRequestObject()
        {
            // Snippet: CreateEventCreateRule(CreateEventCreateRuleRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateEventCreateRuleRequest request = new CreateEventCreateRuleRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                EventCreateRule = new EventCreateRule(),
            };
            // Make the request
            EventCreateRule response = analyticsAdminServiceClient.CreateEventCreateRule(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEventCreateRuleAsync</summary>
        public async Task CreateEventCreateRuleRequestObjectAsync()
        {
            // Snippet: CreateEventCreateRuleAsync(CreateEventCreateRuleRequest, CallSettings)
            // Additional: CreateEventCreateRuleAsync(CreateEventCreateRuleRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEventCreateRuleRequest request = new CreateEventCreateRuleRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                EventCreateRule = new EventCreateRule(),
            };
            // Make the request
            EventCreateRule response = await analyticsAdminServiceClient.CreateEventCreateRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEventCreateRule</summary>
        public void CreateEventCreateRule()
        {
            // Snippet: CreateEventCreateRule(string, EventCreateRule, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            EventCreateRule eventCreateRule = new EventCreateRule();
            // Make the request
            EventCreateRule response = analyticsAdminServiceClient.CreateEventCreateRule(parent, eventCreateRule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventCreateRuleAsync</summary>
        public async Task CreateEventCreateRuleAsync()
        {
            // Snippet: CreateEventCreateRuleAsync(string, EventCreateRule, CallSettings)
            // Additional: CreateEventCreateRuleAsync(string, EventCreateRule, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            EventCreateRule eventCreateRule = new EventCreateRule();
            // Make the request
            EventCreateRule response = await analyticsAdminServiceClient.CreateEventCreateRuleAsync(parent, eventCreateRule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventCreateRule</summary>
        public void CreateEventCreateRuleResourceNames()
        {
            // Snippet: CreateEventCreateRule(DataStreamName, EventCreateRule, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            EventCreateRule eventCreateRule = new EventCreateRule();
            // Make the request
            EventCreateRule response = analyticsAdminServiceClient.CreateEventCreateRule(parent, eventCreateRule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventCreateRuleAsync</summary>
        public async Task CreateEventCreateRuleResourceNamesAsync()
        {
            // Snippet: CreateEventCreateRuleAsync(DataStreamName, EventCreateRule, CallSettings)
            // Additional: CreateEventCreateRuleAsync(DataStreamName, EventCreateRule, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            EventCreateRule eventCreateRule = new EventCreateRule();
            // Make the request
            EventCreateRule response = await analyticsAdminServiceClient.CreateEventCreateRuleAsync(parent, eventCreateRule);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventCreateRule</summary>
        public void UpdateEventCreateRuleRequestObject()
        {
            // Snippet: UpdateEventCreateRule(UpdateEventCreateRuleRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateEventCreateRuleRequest request = new UpdateEventCreateRuleRequest
            {
                EventCreateRule = new EventCreateRule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EventCreateRule response = analyticsAdminServiceClient.UpdateEventCreateRule(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventCreateRuleAsync</summary>
        public async Task UpdateEventCreateRuleRequestObjectAsync()
        {
            // Snippet: UpdateEventCreateRuleAsync(UpdateEventCreateRuleRequest, CallSettings)
            // Additional: UpdateEventCreateRuleAsync(UpdateEventCreateRuleRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEventCreateRuleRequest request = new UpdateEventCreateRuleRequest
            {
                EventCreateRule = new EventCreateRule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EventCreateRule response = await analyticsAdminServiceClient.UpdateEventCreateRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventCreateRule</summary>
        public void UpdateEventCreateRule()
        {
            // Snippet: UpdateEventCreateRule(EventCreateRule, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            EventCreateRule eventCreateRule = new EventCreateRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EventCreateRule response = analyticsAdminServiceClient.UpdateEventCreateRule(eventCreateRule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventCreateRuleAsync</summary>
        public async Task UpdateEventCreateRuleAsync()
        {
            // Snippet: UpdateEventCreateRuleAsync(EventCreateRule, FieldMask, CallSettings)
            // Additional: UpdateEventCreateRuleAsync(EventCreateRule, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventCreateRule eventCreateRule = new EventCreateRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EventCreateRule response = await analyticsAdminServiceClient.UpdateEventCreateRuleAsync(eventCreateRule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventCreateRule</summary>
        public void DeleteEventCreateRuleRequestObject()
        {
            // Snippet: DeleteEventCreateRule(DeleteEventCreateRuleRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteEventCreateRuleRequest request = new DeleteEventCreateRuleRequest
            {
                EventCreateRuleName = EventCreateRuleName.FromPropertyDataStreamEventCreateRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_CREATE_RULE]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteEventCreateRule(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventCreateRuleAsync</summary>
        public async Task DeleteEventCreateRuleRequestObjectAsync()
        {
            // Snippet: DeleteEventCreateRuleAsync(DeleteEventCreateRuleRequest, CallSettings)
            // Additional: DeleteEventCreateRuleAsync(DeleteEventCreateRuleRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEventCreateRuleRequest request = new DeleteEventCreateRuleRequest
            {
                EventCreateRuleName = EventCreateRuleName.FromPropertyDataStreamEventCreateRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_CREATE_RULE]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteEventCreateRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventCreateRule</summary>
        public void DeleteEventCreateRule()
        {
            // Snippet: DeleteEventCreateRule(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/eventCreateRules/[EVENT_CREATE_RULE]";
            // Make the request
            analyticsAdminServiceClient.DeleteEventCreateRule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventCreateRuleAsync</summary>
        public async Task DeleteEventCreateRuleAsync()
        {
            // Snippet: DeleteEventCreateRuleAsync(string, CallSettings)
            // Additional: DeleteEventCreateRuleAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/eventCreateRules/[EVENT_CREATE_RULE]";
            // Make the request
            await analyticsAdminServiceClient.DeleteEventCreateRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventCreateRule</summary>
        public void DeleteEventCreateRuleResourceNames()
        {
            // Snippet: DeleteEventCreateRule(EventCreateRuleName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            EventCreateRuleName name = EventCreateRuleName.FromPropertyDataStreamEventCreateRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_CREATE_RULE]");
            // Make the request
            analyticsAdminServiceClient.DeleteEventCreateRule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventCreateRuleAsync</summary>
        public async Task DeleteEventCreateRuleResourceNamesAsync()
        {
            // Snippet: DeleteEventCreateRuleAsync(EventCreateRuleName, CallSettings)
            // Additional: DeleteEventCreateRuleAsync(EventCreateRuleName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventCreateRuleName name = EventCreateRuleName.FromPropertyDataStreamEventCreateRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_CREATE_RULE]");
            // Make the request
            await analyticsAdminServiceClient.DeleteEventCreateRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventEditRule</summary>
        public void GetEventEditRuleRequestObject()
        {
            // Snippet: GetEventEditRule(GetEventEditRuleRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetEventEditRuleRequest request = new GetEventEditRuleRequest
            {
                EventEditRuleName = EventEditRuleName.FromPropertyDataStreamEventEditRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_EDIT_RULE]"),
            };
            // Make the request
            EventEditRule response = analyticsAdminServiceClient.GetEventEditRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetEventEditRuleAsync</summary>
        public async Task GetEventEditRuleRequestObjectAsync()
        {
            // Snippet: GetEventEditRuleAsync(GetEventEditRuleRequest, CallSettings)
            // Additional: GetEventEditRuleAsync(GetEventEditRuleRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEventEditRuleRequest request = new GetEventEditRuleRequest
            {
                EventEditRuleName = EventEditRuleName.FromPropertyDataStreamEventEditRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_EDIT_RULE]"),
            };
            // Make the request
            EventEditRule response = await analyticsAdminServiceClient.GetEventEditRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEventEditRule</summary>
        public void GetEventEditRule()
        {
            // Snippet: GetEventEditRule(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/eventEditRules/[EVENT_EDIT_RULE]";
            // Make the request
            EventEditRule response = analyticsAdminServiceClient.GetEventEditRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventEditRuleAsync</summary>
        public async Task GetEventEditRuleAsync()
        {
            // Snippet: GetEventEditRuleAsync(string, CallSettings)
            // Additional: GetEventEditRuleAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/eventEditRules/[EVENT_EDIT_RULE]";
            // Make the request
            EventEditRule response = await analyticsAdminServiceClient.GetEventEditRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventEditRule</summary>
        public void GetEventEditRuleResourceNames()
        {
            // Snippet: GetEventEditRule(EventEditRuleName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            EventEditRuleName name = EventEditRuleName.FromPropertyDataStreamEventEditRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_EDIT_RULE]");
            // Make the request
            EventEditRule response = analyticsAdminServiceClient.GetEventEditRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventEditRuleAsync</summary>
        public async Task GetEventEditRuleResourceNamesAsync()
        {
            // Snippet: GetEventEditRuleAsync(EventEditRuleName, CallSettings)
            // Additional: GetEventEditRuleAsync(EventEditRuleName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventEditRuleName name = EventEditRuleName.FromPropertyDataStreamEventEditRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_EDIT_RULE]");
            // Make the request
            EventEditRule response = await analyticsAdminServiceClient.GetEventEditRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEventEditRules</summary>
        public void ListEventEditRulesRequestObject()
        {
            // Snippet: ListEventEditRules(ListEventEditRulesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListEventEditRulesRequest request = new ListEventEditRulesRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            PagedEnumerable<ListEventEditRulesResponse, EventEditRule> response = analyticsAdminServiceClient.ListEventEditRules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventEditRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventEditRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventEditRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventEditRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventEditRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventEditRulesAsync</summary>
        public async Task ListEventEditRulesRequestObjectAsync()
        {
            // Snippet: ListEventEditRulesAsync(ListEventEditRulesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEventEditRulesRequest request = new ListEventEditRulesRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEventEditRulesResponse, EventEditRule> response = analyticsAdminServiceClient.ListEventEditRulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventEditRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventEditRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventEditRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventEditRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventEditRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventEditRules</summary>
        public void ListEventEditRules()
        {
            // Snippet: ListEventEditRules(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            PagedEnumerable<ListEventEditRulesResponse, EventEditRule> response = analyticsAdminServiceClient.ListEventEditRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventEditRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventEditRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventEditRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventEditRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventEditRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventEditRulesAsync</summary>
        public async Task ListEventEditRulesAsync()
        {
            // Snippet: ListEventEditRulesAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            // Make the request
            PagedAsyncEnumerable<ListEventEditRulesResponse, EventEditRule> response = analyticsAdminServiceClient.ListEventEditRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventEditRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventEditRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventEditRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventEditRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventEditRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventEditRules</summary>
        public void ListEventEditRulesResourceNames()
        {
            // Snippet: ListEventEditRules(DataStreamName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            PagedEnumerable<ListEventEditRulesResponse, EventEditRule> response = analyticsAdminServiceClient.ListEventEditRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EventEditRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventEditRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventEditRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventEditRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventEditRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventEditRulesAsync</summary>
        public async Task ListEventEditRulesResourceNamesAsync()
        {
            // Snippet: ListEventEditRulesAsync(DataStreamName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            PagedAsyncEnumerable<ListEventEditRulesResponse, EventEditRule> response = analyticsAdminServiceClient.ListEventEditRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EventEditRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventEditRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EventEditRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EventEditRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EventEditRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateEventEditRule</summary>
        public void CreateEventEditRuleRequestObject()
        {
            // Snippet: CreateEventEditRule(CreateEventEditRuleRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateEventEditRuleRequest request = new CreateEventEditRuleRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                EventEditRule = new EventEditRule(),
            };
            // Make the request
            EventEditRule response = analyticsAdminServiceClient.CreateEventEditRule(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEventEditRuleAsync</summary>
        public async Task CreateEventEditRuleRequestObjectAsync()
        {
            // Snippet: CreateEventEditRuleAsync(CreateEventEditRuleRequest, CallSettings)
            // Additional: CreateEventEditRuleAsync(CreateEventEditRuleRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEventEditRuleRequest request = new CreateEventEditRuleRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                EventEditRule = new EventEditRule(),
            };
            // Make the request
            EventEditRule response = await analyticsAdminServiceClient.CreateEventEditRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEventEditRule</summary>
        public void CreateEventEditRule()
        {
            // Snippet: CreateEventEditRule(string, EventEditRule, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            EventEditRule eventEditRule = new EventEditRule();
            // Make the request
            EventEditRule response = analyticsAdminServiceClient.CreateEventEditRule(parent, eventEditRule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventEditRuleAsync</summary>
        public async Task CreateEventEditRuleAsync()
        {
            // Snippet: CreateEventEditRuleAsync(string, EventEditRule, CallSettings)
            // Additional: CreateEventEditRuleAsync(string, EventEditRule, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]";
            EventEditRule eventEditRule = new EventEditRule();
            // Make the request
            EventEditRule response = await analyticsAdminServiceClient.CreateEventEditRuleAsync(parent, eventEditRule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventEditRule</summary>
        public void CreateEventEditRuleResourceNames()
        {
            // Snippet: CreateEventEditRule(DataStreamName, EventEditRule, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            EventEditRule eventEditRule = new EventEditRule();
            // Make the request
            EventEditRule response = analyticsAdminServiceClient.CreateEventEditRule(parent, eventEditRule);
            // End snippet
        }

        /// <summary>Snippet for CreateEventEditRuleAsync</summary>
        public async Task CreateEventEditRuleResourceNamesAsync()
        {
            // Snippet: CreateEventEditRuleAsync(DataStreamName, EventEditRule, CallSettings)
            // Additional: CreateEventEditRuleAsync(DataStreamName, EventEditRule, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStreamName parent = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            EventEditRule eventEditRule = new EventEditRule();
            // Make the request
            EventEditRule response = await analyticsAdminServiceClient.CreateEventEditRuleAsync(parent, eventEditRule);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventEditRule</summary>
        public void UpdateEventEditRuleRequestObject()
        {
            // Snippet: UpdateEventEditRule(UpdateEventEditRuleRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateEventEditRuleRequest request = new UpdateEventEditRuleRequest
            {
                EventEditRule = new EventEditRule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EventEditRule response = analyticsAdminServiceClient.UpdateEventEditRule(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventEditRuleAsync</summary>
        public async Task UpdateEventEditRuleRequestObjectAsync()
        {
            // Snippet: UpdateEventEditRuleAsync(UpdateEventEditRuleRequest, CallSettings)
            // Additional: UpdateEventEditRuleAsync(UpdateEventEditRuleRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEventEditRuleRequest request = new UpdateEventEditRuleRequest
            {
                EventEditRule = new EventEditRule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EventEditRule response = await analyticsAdminServiceClient.UpdateEventEditRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventEditRule</summary>
        public void UpdateEventEditRule()
        {
            // Snippet: UpdateEventEditRule(EventEditRule, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            EventEditRule eventEditRule = new EventEditRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EventEditRule response = analyticsAdminServiceClient.UpdateEventEditRule(eventEditRule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEventEditRuleAsync</summary>
        public async Task UpdateEventEditRuleAsync()
        {
            // Snippet: UpdateEventEditRuleAsync(EventEditRule, FieldMask, CallSettings)
            // Additional: UpdateEventEditRuleAsync(EventEditRule, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventEditRule eventEditRule = new EventEditRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EventEditRule response = await analyticsAdminServiceClient.UpdateEventEditRuleAsync(eventEditRule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventEditRule</summary>
        public void DeleteEventEditRuleRequestObject()
        {
            // Snippet: DeleteEventEditRule(DeleteEventEditRuleRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteEventEditRuleRequest request = new DeleteEventEditRuleRequest
            {
                EventEditRuleName = EventEditRuleName.FromPropertyDataStreamEventEditRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_EDIT_RULE]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteEventEditRule(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventEditRuleAsync</summary>
        public async Task DeleteEventEditRuleRequestObjectAsync()
        {
            // Snippet: DeleteEventEditRuleAsync(DeleteEventEditRuleRequest, CallSettings)
            // Additional: DeleteEventEditRuleAsync(DeleteEventEditRuleRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEventEditRuleRequest request = new DeleteEventEditRuleRequest
            {
                EventEditRuleName = EventEditRuleName.FromPropertyDataStreamEventEditRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_EDIT_RULE]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteEventEditRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventEditRule</summary>
        public void DeleteEventEditRule()
        {
            // Snippet: DeleteEventEditRule(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/eventEditRules/[EVENT_EDIT_RULE]";
            // Make the request
            analyticsAdminServiceClient.DeleteEventEditRule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventEditRuleAsync</summary>
        public async Task DeleteEventEditRuleAsync()
        {
            // Snippet: DeleteEventEditRuleAsync(string, CallSettings)
            // Additional: DeleteEventEditRuleAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/eventEditRules/[EVENT_EDIT_RULE]";
            // Make the request
            await analyticsAdminServiceClient.DeleteEventEditRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventEditRule</summary>
        public void DeleteEventEditRuleResourceNames()
        {
            // Snippet: DeleteEventEditRule(EventEditRuleName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            EventEditRuleName name = EventEditRuleName.FromPropertyDataStreamEventEditRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_EDIT_RULE]");
            // Make the request
            analyticsAdminServiceClient.DeleteEventEditRule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEventEditRuleAsync</summary>
        public async Task DeleteEventEditRuleResourceNamesAsync()
        {
            // Snippet: DeleteEventEditRuleAsync(EventEditRuleName, CallSettings)
            // Additional: DeleteEventEditRuleAsync(EventEditRuleName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventEditRuleName name = EventEditRuleName.FromPropertyDataStreamEventEditRule("[PROPERTY]", "[DATA_STREAM]", "[EVENT_EDIT_RULE]");
            // Make the request
            await analyticsAdminServiceClient.DeleteEventEditRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ReorderEventEditRules</summary>
        public void ReorderEventEditRulesRequestObject()
        {
            // Snippet: ReorderEventEditRules(ReorderEventEditRulesRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ReorderEventEditRulesRequest request = new ReorderEventEditRulesRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                EventEditRules = { "", },
            };
            // Make the request
            analyticsAdminServiceClient.ReorderEventEditRules(request);
            // End snippet
        }

        /// <summary>Snippet for ReorderEventEditRulesAsync</summary>
        public async Task ReorderEventEditRulesRequestObjectAsync()
        {
            // Snippet: ReorderEventEditRulesAsync(ReorderEventEditRulesRequest, CallSettings)
            // Additional: ReorderEventEditRulesAsync(ReorderEventEditRulesRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReorderEventEditRulesRequest request = new ReorderEventEditRulesRequest
            {
                ParentAsDataStreamName = DataStreamName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
                EventEditRules = { "", },
            };
            // Make the request
            await analyticsAdminServiceClient.ReorderEventEditRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataRedactionSettings</summary>
        public void UpdateDataRedactionSettingsRequestObject()
        {
            // Snippet: UpdateDataRedactionSettings(UpdateDataRedactionSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataRedactionSettingsRequest request = new UpdateDataRedactionSettingsRequest
            {
                DataRedactionSettings = new DataRedactionSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataRedactionSettings response = analyticsAdminServiceClient.UpdateDataRedactionSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataRedactionSettingsAsync</summary>
        public async Task UpdateDataRedactionSettingsRequestObjectAsync()
        {
            // Snippet: UpdateDataRedactionSettingsAsync(UpdateDataRedactionSettingsRequest, CallSettings)
            // Additional: UpdateDataRedactionSettingsAsync(UpdateDataRedactionSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataRedactionSettingsRequest request = new UpdateDataRedactionSettingsRequest
            {
                DataRedactionSettings = new DataRedactionSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataRedactionSettings response = await analyticsAdminServiceClient.UpdateDataRedactionSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataRedactionSettings</summary>
        public void UpdateDataRedactionSettings()
        {
            // Snippet: UpdateDataRedactionSettings(DataRedactionSettings, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataRedactionSettings dataRedactionSettings = new DataRedactionSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataRedactionSettings response = analyticsAdminServiceClient.UpdateDataRedactionSettings(dataRedactionSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataRedactionSettingsAsync</summary>
        public async Task UpdateDataRedactionSettingsAsync()
        {
            // Snippet: UpdateDataRedactionSettingsAsync(DataRedactionSettings, FieldMask, CallSettings)
            // Additional: UpdateDataRedactionSettingsAsync(DataRedactionSettings, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataRedactionSettings dataRedactionSettings = new DataRedactionSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataRedactionSettings response = await analyticsAdminServiceClient.UpdateDataRedactionSettingsAsync(dataRedactionSettings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetDataRedactionSettings</summary>
        public void GetDataRedactionSettingsRequestObject()
        {
            // Snippet: GetDataRedactionSettings(GetDataRedactionSettingsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetDataRedactionSettingsRequest request = new GetDataRedactionSettingsRequest
            {
                DataRedactionSettingsName = DataRedactionSettingsName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            DataRedactionSettings response = analyticsAdminServiceClient.GetDataRedactionSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataRedactionSettingsAsync</summary>
        public async Task GetDataRedactionSettingsRequestObjectAsync()
        {
            // Snippet: GetDataRedactionSettingsAsync(GetDataRedactionSettingsRequest, CallSettings)
            // Additional: GetDataRedactionSettingsAsync(GetDataRedactionSettingsRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataRedactionSettingsRequest request = new GetDataRedactionSettingsRequest
            {
                DataRedactionSettingsName = DataRedactionSettingsName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]"),
            };
            // Make the request
            DataRedactionSettings response = await analyticsAdminServiceClient.GetDataRedactionSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataRedactionSettings</summary>
        public void GetDataRedactionSettings()
        {
            // Snippet: GetDataRedactionSettings(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/dataRedactionSettings";
            // Make the request
            DataRedactionSettings response = analyticsAdminServiceClient.GetDataRedactionSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataRedactionSettingsAsync</summary>
        public async Task GetDataRedactionSettingsAsync()
        {
            // Snippet: GetDataRedactionSettingsAsync(string, CallSettings)
            // Additional: GetDataRedactionSettingsAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/dataStreams/[DATA_STREAM]/dataRedactionSettings";
            // Make the request
            DataRedactionSettings response = await analyticsAdminServiceClient.GetDataRedactionSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataRedactionSettings</summary>
        public void GetDataRedactionSettingsResourceNames()
        {
            // Snippet: GetDataRedactionSettings(DataRedactionSettingsName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DataRedactionSettingsName name = DataRedactionSettingsName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            DataRedactionSettings response = analyticsAdminServiceClient.GetDataRedactionSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataRedactionSettingsAsync</summary>
        public async Task GetDataRedactionSettingsResourceNamesAsync()
        {
            // Snippet: GetDataRedactionSettingsAsync(DataRedactionSettingsName, CallSettings)
            // Additional: GetDataRedactionSettingsAsync(DataRedactionSettingsName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataRedactionSettingsName name = DataRedactionSettingsName.FromPropertyDataStream("[PROPERTY]", "[DATA_STREAM]");
            // Make the request
            DataRedactionSettings response = await analyticsAdminServiceClient.GetDataRedactionSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCalculatedMetric</summary>
        public void GetCalculatedMetricRequestObject()
        {
            // Snippet: GetCalculatedMetric(GetCalculatedMetricRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetCalculatedMetricRequest request = new GetCalculatedMetricRequest
            {
                CalculatedMetricName = CalculatedMetricName.FromPropertyCalculatedMetric("[PROPERTY]", "[CALCULATED_METRIC]"),
            };
            // Make the request
            CalculatedMetric response = analyticsAdminServiceClient.GetCalculatedMetric(request);
            // End snippet
        }

        /// <summary>Snippet for GetCalculatedMetricAsync</summary>
        public async Task GetCalculatedMetricRequestObjectAsync()
        {
            // Snippet: GetCalculatedMetricAsync(GetCalculatedMetricRequest, CallSettings)
            // Additional: GetCalculatedMetricAsync(GetCalculatedMetricRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetCalculatedMetricRequest request = new GetCalculatedMetricRequest
            {
                CalculatedMetricName = CalculatedMetricName.FromPropertyCalculatedMetric("[PROPERTY]", "[CALCULATED_METRIC]"),
            };
            // Make the request
            CalculatedMetric response = await analyticsAdminServiceClient.GetCalculatedMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCalculatedMetric</summary>
        public void GetCalculatedMetric()
        {
            // Snippet: GetCalculatedMetric(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/calculatedMetrics/[CALCULATED_METRIC]";
            // Make the request
            CalculatedMetric response = analyticsAdminServiceClient.GetCalculatedMetric(name);
            // End snippet
        }

        /// <summary>Snippet for GetCalculatedMetricAsync</summary>
        public async Task GetCalculatedMetricAsync()
        {
            // Snippet: GetCalculatedMetricAsync(string, CallSettings)
            // Additional: GetCalculatedMetricAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/calculatedMetrics/[CALCULATED_METRIC]";
            // Make the request
            CalculatedMetric response = await analyticsAdminServiceClient.GetCalculatedMetricAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCalculatedMetric</summary>
        public void GetCalculatedMetricResourceNames()
        {
            // Snippet: GetCalculatedMetric(CalculatedMetricName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CalculatedMetricName name = CalculatedMetricName.FromPropertyCalculatedMetric("[PROPERTY]", "[CALCULATED_METRIC]");
            // Make the request
            CalculatedMetric response = analyticsAdminServiceClient.GetCalculatedMetric(name);
            // End snippet
        }

        /// <summary>Snippet for GetCalculatedMetricAsync</summary>
        public async Task GetCalculatedMetricResourceNamesAsync()
        {
            // Snippet: GetCalculatedMetricAsync(CalculatedMetricName, CallSettings)
            // Additional: GetCalculatedMetricAsync(CalculatedMetricName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CalculatedMetricName name = CalculatedMetricName.FromPropertyCalculatedMetric("[PROPERTY]", "[CALCULATED_METRIC]");
            // Make the request
            CalculatedMetric response = await analyticsAdminServiceClient.GetCalculatedMetricAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCalculatedMetric</summary>
        public void CreateCalculatedMetricRequestObject()
        {
            // Snippet: CreateCalculatedMetric(CreateCalculatedMetricRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateCalculatedMetricRequest request = new CreateCalculatedMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CalculatedMetricId = "",
                CalculatedMetric = new CalculatedMetric(),
            };
            // Make the request
            CalculatedMetric response = analyticsAdminServiceClient.CreateCalculatedMetric(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCalculatedMetricAsync</summary>
        public async Task CreateCalculatedMetricRequestObjectAsync()
        {
            // Snippet: CreateCalculatedMetricAsync(CreateCalculatedMetricRequest, CallSettings)
            // Additional: CreateCalculatedMetricAsync(CreateCalculatedMetricRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateCalculatedMetricRequest request = new CreateCalculatedMetricRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                CalculatedMetricId = "",
                CalculatedMetric = new CalculatedMetric(),
            };
            // Make the request
            CalculatedMetric response = await analyticsAdminServiceClient.CreateCalculatedMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateCalculatedMetric</summary>
        public void CreateCalculatedMetric()
        {
            // Snippet: CreateCalculatedMetric(string, CalculatedMetric, string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            CalculatedMetric calculatedMetric = new CalculatedMetric();
            string calculatedMetricId = "";
            // Make the request
            CalculatedMetric response = analyticsAdminServiceClient.CreateCalculatedMetric(parent, calculatedMetric, calculatedMetricId);
            // End snippet
        }

        /// <summary>Snippet for CreateCalculatedMetricAsync</summary>
        public async Task CreateCalculatedMetricAsync()
        {
            // Snippet: CreateCalculatedMetricAsync(string, CalculatedMetric, string, CallSettings)
            // Additional: CreateCalculatedMetricAsync(string, CalculatedMetric, string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            CalculatedMetric calculatedMetric = new CalculatedMetric();
            string calculatedMetricId = "";
            // Make the request
            CalculatedMetric response = await analyticsAdminServiceClient.CreateCalculatedMetricAsync(parent, calculatedMetric, calculatedMetricId);
            // End snippet
        }

        /// <summary>Snippet for CreateCalculatedMetric</summary>
        public void CreateCalculatedMetricResourceNames()
        {
            // Snippet: CreateCalculatedMetric(PropertyName, CalculatedMetric, string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            CalculatedMetric calculatedMetric = new CalculatedMetric();
            string calculatedMetricId = "";
            // Make the request
            CalculatedMetric response = analyticsAdminServiceClient.CreateCalculatedMetric(parent, calculatedMetric, calculatedMetricId);
            // End snippet
        }

        /// <summary>Snippet for CreateCalculatedMetricAsync</summary>
        public async Task CreateCalculatedMetricResourceNamesAsync()
        {
            // Snippet: CreateCalculatedMetricAsync(PropertyName, CalculatedMetric, string, CallSettings)
            // Additional: CreateCalculatedMetricAsync(PropertyName, CalculatedMetric, string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            CalculatedMetric calculatedMetric = new CalculatedMetric();
            string calculatedMetricId = "";
            // Make the request
            CalculatedMetric response = await analyticsAdminServiceClient.CreateCalculatedMetricAsync(parent, calculatedMetric, calculatedMetricId);
            // End snippet
        }

        /// <summary>Snippet for ListCalculatedMetrics</summary>
        public void ListCalculatedMetricsRequestObject()
        {
            // Snippet: ListCalculatedMetrics(ListCalculatedMetricsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListCalculatedMetricsRequest request = new ListCalculatedMetricsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListCalculatedMetricsResponse, CalculatedMetric> response = analyticsAdminServiceClient.ListCalculatedMetrics(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CalculatedMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCalculatedMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CalculatedMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CalculatedMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CalculatedMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCalculatedMetricsAsync</summary>
        public async Task ListCalculatedMetricsRequestObjectAsync()
        {
            // Snippet: ListCalculatedMetricsAsync(ListCalculatedMetricsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListCalculatedMetricsRequest request = new ListCalculatedMetricsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCalculatedMetricsResponse, CalculatedMetric> response = analyticsAdminServiceClient.ListCalculatedMetricsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CalculatedMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCalculatedMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CalculatedMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CalculatedMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CalculatedMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCalculatedMetrics</summary>
        public void ListCalculatedMetrics()
        {
            // Snippet: ListCalculatedMetrics(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListCalculatedMetricsResponse, CalculatedMetric> response = analyticsAdminServiceClient.ListCalculatedMetrics(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CalculatedMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCalculatedMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CalculatedMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CalculatedMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CalculatedMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCalculatedMetricsAsync</summary>
        public async Task ListCalculatedMetricsAsync()
        {
            // Snippet: ListCalculatedMetricsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListCalculatedMetricsResponse, CalculatedMetric> response = analyticsAdminServiceClient.ListCalculatedMetricsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CalculatedMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCalculatedMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CalculatedMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CalculatedMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CalculatedMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCalculatedMetrics</summary>
        public void ListCalculatedMetricsResourceNames()
        {
            // Snippet: ListCalculatedMetrics(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListCalculatedMetricsResponse, CalculatedMetric> response = analyticsAdminServiceClient.ListCalculatedMetrics(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CalculatedMetric item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCalculatedMetricsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CalculatedMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CalculatedMetric> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CalculatedMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCalculatedMetricsAsync</summary>
        public async Task ListCalculatedMetricsResourceNamesAsync()
        {
            // Snippet: ListCalculatedMetricsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListCalculatedMetricsResponse, CalculatedMetric> response = analyticsAdminServiceClient.ListCalculatedMetricsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CalculatedMetric item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCalculatedMetricsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CalculatedMetric item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CalculatedMetric> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CalculatedMetric item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateCalculatedMetric</summary>
        public void UpdateCalculatedMetricRequestObject()
        {
            // Snippet: UpdateCalculatedMetric(UpdateCalculatedMetricRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateCalculatedMetricRequest request = new UpdateCalculatedMetricRequest
            {
                CalculatedMetric = new CalculatedMetric(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CalculatedMetric response = analyticsAdminServiceClient.UpdateCalculatedMetric(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCalculatedMetricAsync</summary>
        public async Task UpdateCalculatedMetricRequestObjectAsync()
        {
            // Snippet: UpdateCalculatedMetricAsync(UpdateCalculatedMetricRequest, CallSettings)
            // Additional: UpdateCalculatedMetricAsync(UpdateCalculatedMetricRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateCalculatedMetricRequest request = new UpdateCalculatedMetricRequest
            {
                CalculatedMetric = new CalculatedMetric(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            CalculatedMetric response = await analyticsAdminServiceClient.UpdateCalculatedMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateCalculatedMetric</summary>
        public void UpdateCalculatedMetric()
        {
            // Snippet: UpdateCalculatedMetric(CalculatedMetric, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CalculatedMetric calculatedMetric = new CalculatedMetric();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CalculatedMetric response = analyticsAdminServiceClient.UpdateCalculatedMetric(calculatedMetric, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateCalculatedMetricAsync</summary>
        public async Task UpdateCalculatedMetricAsync()
        {
            // Snippet: UpdateCalculatedMetricAsync(CalculatedMetric, FieldMask, CallSettings)
            // Additional: UpdateCalculatedMetricAsync(CalculatedMetric, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CalculatedMetric calculatedMetric = new CalculatedMetric();
            FieldMask updateMask = new FieldMask();
            // Make the request
            CalculatedMetric response = await analyticsAdminServiceClient.UpdateCalculatedMetricAsync(calculatedMetric, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteCalculatedMetric</summary>
        public void DeleteCalculatedMetricRequestObject()
        {
            // Snippet: DeleteCalculatedMetric(DeleteCalculatedMetricRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteCalculatedMetricRequest request = new DeleteCalculatedMetricRequest
            {
                CalculatedMetricName = CalculatedMetricName.FromPropertyCalculatedMetric("[PROPERTY]", "[CALCULATED_METRIC]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteCalculatedMetric(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCalculatedMetricAsync</summary>
        public async Task DeleteCalculatedMetricRequestObjectAsync()
        {
            // Snippet: DeleteCalculatedMetricAsync(DeleteCalculatedMetricRequest, CallSettings)
            // Additional: DeleteCalculatedMetricAsync(DeleteCalculatedMetricRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCalculatedMetricRequest request = new DeleteCalculatedMetricRequest
            {
                CalculatedMetricName = CalculatedMetricName.FromPropertyCalculatedMetric("[PROPERTY]", "[CALCULATED_METRIC]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteCalculatedMetricAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteCalculatedMetric</summary>
        public void DeleteCalculatedMetric()
        {
            // Snippet: DeleteCalculatedMetric(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/calculatedMetrics/[CALCULATED_METRIC]";
            // Make the request
            analyticsAdminServiceClient.DeleteCalculatedMetric(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCalculatedMetricAsync</summary>
        public async Task DeleteCalculatedMetricAsync()
        {
            // Snippet: DeleteCalculatedMetricAsync(string, CallSettings)
            // Additional: DeleteCalculatedMetricAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/calculatedMetrics/[CALCULATED_METRIC]";
            // Make the request
            await analyticsAdminServiceClient.DeleteCalculatedMetricAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCalculatedMetric</summary>
        public void DeleteCalculatedMetricResourceNames()
        {
            // Snippet: DeleteCalculatedMetric(CalculatedMetricName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CalculatedMetricName name = CalculatedMetricName.FromPropertyCalculatedMetric("[PROPERTY]", "[CALCULATED_METRIC]");
            // Make the request
            analyticsAdminServiceClient.DeleteCalculatedMetric(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteCalculatedMetricAsync</summary>
        public async Task DeleteCalculatedMetricResourceNamesAsync()
        {
            // Snippet: DeleteCalculatedMetricAsync(CalculatedMetricName, CallSettings)
            // Additional: DeleteCalculatedMetricAsync(CalculatedMetricName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CalculatedMetricName name = CalculatedMetricName.FromPropertyCalculatedMetric("[PROPERTY]", "[CALCULATED_METRIC]");
            // Make the request
            await analyticsAdminServiceClient.DeleteCalculatedMetricAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateRollupProperty</summary>
        public void CreateRollupPropertyRequestObject()
        {
            // Snippet: CreateRollupProperty(CreateRollupPropertyRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateRollupPropertyRequest request = new CreateRollupPropertyRequest
            {
                RollupProperty = new Property(),
                SourceProperties = { "", },
            };
            // Make the request
            CreateRollupPropertyResponse response = analyticsAdminServiceClient.CreateRollupProperty(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRollupPropertyAsync</summary>
        public async Task CreateRollupPropertyRequestObjectAsync()
        {
            // Snippet: CreateRollupPropertyAsync(CreateRollupPropertyRequest, CallSettings)
            // Additional: CreateRollupPropertyAsync(CreateRollupPropertyRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRollupPropertyRequest request = new CreateRollupPropertyRequest
            {
                RollupProperty = new Property(),
                SourceProperties = { "", },
            };
            // Make the request
            CreateRollupPropertyResponse response = await analyticsAdminServiceClient.CreateRollupPropertyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRollupPropertySourceLink</summary>
        public void GetRollupPropertySourceLinkRequestObject()
        {
            // Snippet: GetRollupPropertySourceLink(GetRollupPropertySourceLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetRollupPropertySourceLinkRequest request = new GetRollupPropertySourceLinkRequest
            {
                RollupPropertySourceLinkName = RollupPropertySourceLinkName.FromPropertyRollupPropertySourceLink("[PROPERTY]", "[ROLLUP_PROPERTY_SOURCE_LINK]"),
            };
            // Make the request
            RollupPropertySourceLink response = analyticsAdminServiceClient.GetRollupPropertySourceLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetRollupPropertySourceLinkAsync</summary>
        public async Task GetRollupPropertySourceLinkRequestObjectAsync()
        {
            // Snippet: GetRollupPropertySourceLinkAsync(GetRollupPropertySourceLinkRequest, CallSettings)
            // Additional: GetRollupPropertySourceLinkAsync(GetRollupPropertySourceLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRollupPropertySourceLinkRequest request = new GetRollupPropertySourceLinkRequest
            {
                RollupPropertySourceLinkName = RollupPropertySourceLinkName.FromPropertyRollupPropertySourceLink("[PROPERTY]", "[ROLLUP_PROPERTY_SOURCE_LINK]"),
            };
            // Make the request
            RollupPropertySourceLink response = await analyticsAdminServiceClient.GetRollupPropertySourceLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRollupPropertySourceLink</summary>
        public void GetRollupPropertySourceLink()
        {
            // Snippet: GetRollupPropertySourceLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/rollupPropertySourceLinks/[ROLLUP_PROPERTY_SOURCE_LINK]";
            // Make the request
            RollupPropertySourceLink response = analyticsAdminServiceClient.GetRollupPropertySourceLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetRollupPropertySourceLinkAsync</summary>
        public async Task GetRollupPropertySourceLinkAsync()
        {
            // Snippet: GetRollupPropertySourceLinkAsync(string, CallSettings)
            // Additional: GetRollupPropertySourceLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/rollupPropertySourceLinks/[ROLLUP_PROPERTY_SOURCE_LINK]";
            // Make the request
            RollupPropertySourceLink response = await analyticsAdminServiceClient.GetRollupPropertySourceLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRollupPropertySourceLink</summary>
        public void GetRollupPropertySourceLinkResourceNames()
        {
            // Snippet: GetRollupPropertySourceLink(RollupPropertySourceLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            RollupPropertySourceLinkName name = RollupPropertySourceLinkName.FromPropertyRollupPropertySourceLink("[PROPERTY]", "[ROLLUP_PROPERTY_SOURCE_LINK]");
            // Make the request
            RollupPropertySourceLink response = analyticsAdminServiceClient.GetRollupPropertySourceLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetRollupPropertySourceLinkAsync</summary>
        public async Task GetRollupPropertySourceLinkResourceNamesAsync()
        {
            // Snippet: GetRollupPropertySourceLinkAsync(RollupPropertySourceLinkName, CallSettings)
            // Additional: GetRollupPropertySourceLinkAsync(RollupPropertySourceLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            RollupPropertySourceLinkName name = RollupPropertySourceLinkName.FromPropertyRollupPropertySourceLink("[PROPERTY]", "[ROLLUP_PROPERTY_SOURCE_LINK]");
            // Make the request
            RollupPropertySourceLink response = await analyticsAdminServiceClient.GetRollupPropertySourceLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRollupPropertySourceLinks</summary>
        public void ListRollupPropertySourceLinksRequestObject()
        {
            // Snippet: ListRollupPropertySourceLinks(ListRollupPropertySourceLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListRollupPropertySourceLinksRequest request = new ListRollupPropertySourceLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListRollupPropertySourceLinksResponse, RollupPropertySourceLink> response = analyticsAdminServiceClient.ListRollupPropertySourceLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RollupPropertySourceLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRollupPropertySourceLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RollupPropertySourceLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RollupPropertySourceLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RollupPropertySourceLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollupPropertySourceLinksAsync</summary>
        public async Task ListRollupPropertySourceLinksRequestObjectAsync()
        {
            // Snippet: ListRollupPropertySourceLinksAsync(ListRollupPropertySourceLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRollupPropertySourceLinksRequest request = new ListRollupPropertySourceLinksRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListRollupPropertySourceLinksResponse, RollupPropertySourceLink> response = analyticsAdminServiceClient.ListRollupPropertySourceLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RollupPropertySourceLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRollupPropertySourceLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RollupPropertySourceLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RollupPropertySourceLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RollupPropertySourceLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollupPropertySourceLinks</summary>
        public void ListRollupPropertySourceLinks()
        {
            // Snippet: ListRollupPropertySourceLinks(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListRollupPropertySourceLinksResponse, RollupPropertySourceLink> response = analyticsAdminServiceClient.ListRollupPropertySourceLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RollupPropertySourceLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRollupPropertySourceLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RollupPropertySourceLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RollupPropertySourceLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RollupPropertySourceLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollupPropertySourceLinksAsync</summary>
        public async Task ListRollupPropertySourceLinksAsync()
        {
            // Snippet: ListRollupPropertySourceLinksAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListRollupPropertySourceLinksResponse, RollupPropertySourceLink> response = analyticsAdminServiceClient.ListRollupPropertySourceLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RollupPropertySourceLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRollupPropertySourceLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RollupPropertySourceLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RollupPropertySourceLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RollupPropertySourceLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollupPropertySourceLinks</summary>
        public void ListRollupPropertySourceLinksResourceNames()
        {
            // Snippet: ListRollupPropertySourceLinks(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListRollupPropertySourceLinksResponse, RollupPropertySourceLink> response = analyticsAdminServiceClient.ListRollupPropertySourceLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RollupPropertySourceLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRollupPropertySourceLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RollupPropertySourceLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RollupPropertySourceLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RollupPropertySourceLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRollupPropertySourceLinksAsync</summary>
        public async Task ListRollupPropertySourceLinksResourceNamesAsync()
        {
            // Snippet: ListRollupPropertySourceLinksAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListRollupPropertySourceLinksResponse, RollupPropertySourceLink> response = analyticsAdminServiceClient.ListRollupPropertySourceLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RollupPropertySourceLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRollupPropertySourceLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RollupPropertySourceLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RollupPropertySourceLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RollupPropertySourceLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateRollupPropertySourceLink</summary>
        public void CreateRollupPropertySourceLinkRequestObject()
        {
            // Snippet: CreateRollupPropertySourceLink(CreateRollupPropertySourceLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateRollupPropertySourceLinkRequest request = new CreateRollupPropertySourceLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                RollupPropertySourceLink = new RollupPropertySourceLink(),
            };
            // Make the request
            RollupPropertySourceLink response = analyticsAdminServiceClient.CreateRollupPropertySourceLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRollupPropertySourceLinkAsync</summary>
        public async Task CreateRollupPropertySourceLinkRequestObjectAsync()
        {
            // Snippet: CreateRollupPropertySourceLinkAsync(CreateRollupPropertySourceLinkRequest, CallSettings)
            // Additional: CreateRollupPropertySourceLinkAsync(CreateRollupPropertySourceLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRollupPropertySourceLinkRequest request = new CreateRollupPropertySourceLinkRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                RollupPropertySourceLink = new RollupPropertySourceLink(),
            };
            // Make the request
            RollupPropertySourceLink response = await analyticsAdminServiceClient.CreateRollupPropertySourceLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRollupPropertySourceLink</summary>
        public void CreateRollupPropertySourceLink()
        {
            // Snippet: CreateRollupPropertySourceLink(string, RollupPropertySourceLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            RollupPropertySourceLink rollupPropertySourceLink = new RollupPropertySourceLink();
            // Make the request
            RollupPropertySourceLink response = analyticsAdminServiceClient.CreateRollupPropertySourceLink(parent, rollupPropertySourceLink);
            // End snippet
        }

        /// <summary>Snippet for CreateRollupPropertySourceLinkAsync</summary>
        public async Task CreateRollupPropertySourceLinkAsync()
        {
            // Snippet: CreateRollupPropertySourceLinkAsync(string, RollupPropertySourceLink, CallSettings)
            // Additional: CreateRollupPropertySourceLinkAsync(string, RollupPropertySourceLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            RollupPropertySourceLink rollupPropertySourceLink = new RollupPropertySourceLink();
            // Make the request
            RollupPropertySourceLink response = await analyticsAdminServiceClient.CreateRollupPropertySourceLinkAsync(parent, rollupPropertySourceLink);
            // End snippet
        }

        /// <summary>Snippet for CreateRollupPropertySourceLink</summary>
        public void CreateRollupPropertySourceLinkResourceNames()
        {
            // Snippet: CreateRollupPropertySourceLink(PropertyName, RollupPropertySourceLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            RollupPropertySourceLink rollupPropertySourceLink = new RollupPropertySourceLink();
            // Make the request
            RollupPropertySourceLink response = analyticsAdminServiceClient.CreateRollupPropertySourceLink(parent, rollupPropertySourceLink);
            // End snippet
        }

        /// <summary>Snippet for CreateRollupPropertySourceLinkAsync</summary>
        public async Task CreateRollupPropertySourceLinkResourceNamesAsync()
        {
            // Snippet: CreateRollupPropertySourceLinkAsync(PropertyName, RollupPropertySourceLink, CallSettings)
            // Additional: CreateRollupPropertySourceLinkAsync(PropertyName, RollupPropertySourceLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            RollupPropertySourceLink rollupPropertySourceLink = new RollupPropertySourceLink();
            // Make the request
            RollupPropertySourceLink response = await analyticsAdminServiceClient.CreateRollupPropertySourceLinkAsync(parent, rollupPropertySourceLink);
            // End snippet
        }

        /// <summary>Snippet for DeleteRollupPropertySourceLink</summary>
        public void DeleteRollupPropertySourceLinkRequestObject()
        {
            // Snippet: DeleteRollupPropertySourceLink(DeleteRollupPropertySourceLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteRollupPropertySourceLinkRequest request = new DeleteRollupPropertySourceLinkRequest
            {
                RollupPropertySourceLinkName = RollupPropertySourceLinkName.FromPropertyRollupPropertySourceLink("[PROPERTY]", "[ROLLUP_PROPERTY_SOURCE_LINK]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteRollupPropertySourceLink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRollupPropertySourceLinkAsync</summary>
        public async Task DeleteRollupPropertySourceLinkRequestObjectAsync()
        {
            // Snippet: DeleteRollupPropertySourceLinkAsync(DeleteRollupPropertySourceLinkRequest, CallSettings)
            // Additional: DeleteRollupPropertySourceLinkAsync(DeleteRollupPropertySourceLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRollupPropertySourceLinkRequest request = new DeleteRollupPropertySourceLinkRequest
            {
                RollupPropertySourceLinkName = RollupPropertySourceLinkName.FromPropertyRollupPropertySourceLink("[PROPERTY]", "[ROLLUP_PROPERTY_SOURCE_LINK]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteRollupPropertySourceLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRollupPropertySourceLink</summary>
        public void DeleteRollupPropertySourceLink()
        {
            // Snippet: DeleteRollupPropertySourceLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/rollupPropertySourceLinks/[ROLLUP_PROPERTY_SOURCE_LINK]";
            // Make the request
            analyticsAdminServiceClient.DeleteRollupPropertySourceLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRollupPropertySourceLinkAsync</summary>
        public async Task DeleteRollupPropertySourceLinkAsync()
        {
            // Snippet: DeleteRollupPropertySourceLinkAsync(string, CallSettings)
            // Additional: DeleteRollupPropertySourceLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/rollupPropertySourceLinks/[ROLLUP_PROPERTY_SOURCE_LINK]";
            // Make the request
            await analyticsAdminServiceClient.DeleteRollupPropertySourceLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRollupPropertySourceLink</summary>
        public void DeleteRollupPropertySourceLinkResourceNames()
        {
            // Snippet: DeleteRollupPropertySourceLink(RollupPropertySourceLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            RollupPropertySourceLinkName name = RollupPropertySourceLinkName.FromPropertyRollupPropertySourceLink("[PROPERTY]", "[ROLLUP_PROPERTY_SOURCE_LINK]");
            // Make the request
            analyticsAdminServiceClient.DeleteRollupPropertySourceLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRollupPropertySourceLinkAsync</summary>
        public async Task DeleteRollupPropertySourceLinkResourceNamesAsync()
        {
            // Snippet: DeleteRollupPropertySourceLinkAsync(RollupPropertySourceLinkName, CallSettings)
            // Additional: DeleteRollupPropertySourceLinkAsync(RollupPropertySourceLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            RollupPropertySourceLinkName name = RollupPropertySourceLinkName.FromPropertyRollupPropertySourceLink("[PROPERTY]", "[ROLLUP_PROPERTY_SOURCE_LINK]");
            // Make the request
            await analyticsAdminServiceClient.DeleteRollupPropertySourceLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ProvisionSubproperty</summary>
        public void ProvisionSubpropertyRequestObject()
        {
            // Snippet: ProvisionSubproperty(ProvisionSubpropertyRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ProvisionSubpropertyRequest request = new ProvisionSubpropertyRequest
            {
                Subproperty = new Property(),
                SubpropertyEventFilter = new SubpropertyEventFilter(),
            };
            // Make the request
            ProvisionSubpropertyResponse response = analyticsAdminServiceClient.ProvisionSubproperty(request);
            // End snippet
        }

        /// <summary>Snippet for ProvisionSubpropertyAsync</summary>
        public async Task ProvisionSubpropertyRequestObjectAsync()
        {
            // Snippet: ProvisionSubpropertyAsync(ProvisionSubpropertyRequest, CallSettings)
            // Additional: ProvisionSubpropertyAsync(ProvisionSubpropertyRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProvisionSubpropertyRequest request = new ProvisionSubpropertyRequest
            {
                Subproperty = new Property(),
                SubpropertyEventFilter = new SubpropertyEventFilter(),
            };
            // Make the request
            ProvisionSubpropertyResponse response = await analyticsAdminServiceClient.ProvisionSubpropertyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubpropertyEventFilter</summary>
        public void CreateSubpropertyEventFilterRequestObject()
        {
            // Snippet: CreateSubpropertyEventFilter(CreateSubpropertyEventFilterRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateSubpropertyEventFilterRequest request = new CreateSubpropertyEventFilterRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                SubpropertyEventFilter = new SubpropertyEventFilter(),
            };
            // Make the request
            SubpropertyEventFilter response = analyticsAdminServiceClient.CreateSubpropertyEventFilter(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubpropertyEventFilterAsync</summary>
        public async Task CreateSubpropertyEventFilterRequestObjectAsync()
        {
            // Snippet: CreateSubpropertyEventFilterAsync(CreateSubpropertyEventFilterRequest, CallSettings)
            // Additional: CreateSubpropertyEventFilterAsync(CreateSubpropertyEventFilterRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSubpropertyEventFilterRequest request = new CreateSubpropertyEventFilterRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
                SubpropertyEventFilter = new SubpropertyEventFilter(),
            };
            // Make the request
            SubpropertyEventFilter response = await analyticsAdminServiceClient.CreateSubpropertyEventFilterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSubpropertyEventFilter</summary>
        public void CreateSubpropertyEventFilter()
        {
            // Snippet: CreateSubpropertyEventFilter(string, SubpropertyEventFilter, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            SubpropertyEventFilter subpropertyEventFilter = new SubpropertyEventFilter();
            // Make the request
            SubpropertyEventFilter response = analyticsAdminServiceClient.CreateSubpropertyEventFilter(parent, subpropertyEventFilter);
            // End snippet
        }

        /// <summary>Snippet for CreateSubpropertyEventFilterAsync</summary>
        public async Task CreateSubpropertyEventFilterAsync()
        {
            // Snippet: CreateSubpropertyEventFilterAsync(string, SubpropertyEventFilter, CallSettings)
            // Additional: CreateSubpropertyEventFilterAsync(string, SubpropertyEventFilter, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            SubpropertyEventFilter subpropertyEventFilter = new SubpropertyEventFilter();
            // Make the request
            SubpropertyEventFilter response = await analyticsAdminServiceClient.CreateSubpropertyEventFilterAsync(parent, subpropertyEventFilter);
            // End snippet
        }

        /// <summary>Snippet for CreateSubpropertyEventFilter</summary>
        public void CreateSubpropertyEventFilterResourceNames()
        {
            // Snippet: CreateSubpropertyEventFilter(PropertyName, SubpropertyEventFilter, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            SubpropertyEventFilter subpropertyEventFilter = new SubpropertyEventFilter();
            // Make the request
            SubpropertyEventFilter response = analyticsAdminServiceClient.CreateSubpropertyEventFilter(parent, subpropertyEventFilter);
            // End snippet
        }

        /// <summary>Snippet for CreateSubpropertyEventFilterAsync</summary>
        public async Task CreateSubpropertyEventFilterResourceNamesAsync()
        {
            // Snippet: CreateSubpropertyEventFilterAsync(PropertyName, SubpropertyEventFilter, CallSettings)
            // Additional: CreateSubpropertyEventFilterAsync(PropertyName, SubpropertyEventFilter, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            SubpropertyEventFilter subpropertyEventFilter = new SubpropertyEventFilter();
            // Make the request
            SubpropertyEventFilter response = await analyticsAdminServiceClient.CreateSubpropertyEventFilterAsync(parent, subpropertyEventFilter);
            // End snippet
        }

        /// <summary>Snippet for GetSubpropertyEventFilter</summary>
        public void GetSubpropertyEventFilterRequestObject()
        {
            // Snippet: GetSubpropertyEventFilter(GetSubpropertyEventFilterRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetSubpropertyEventFilterRequest request = new GetSubpropertyEventFilterRequest
            {
                SubpropertyEventFilterName = SubpropertyEventFilterName.FromPropertySubPropertyEventFilter("[PROPERTY]", "[SUB_PROPERTY_EVENT_FILTER]"),
            };
            // Make the request
            SubpropertyEventFilter response = analyticsAdminServiceClient.GetSubpropertyEventFilter(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubpropertyEventFilterAsync</summary>
        public async Task GetSubpropertyEventFilterRequestObjectAsync()
        {
            // Snippet: GetSubpropertyEventFilterAsync(GetSubpropertyEventFilterRequest, CallSettings)
            // Additional: GetSubpropertyEventFilterAsync(GetSubpropertyEventFilterRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSubpropertyEventFilterRequest request = new GetSubpropertyEventFilterRequest
            {
                SubpropertyEventFilterName = SubpropertyEventFilterName.FromPropertySubPropertyEventFilter("[PROPERTY]", "[SUB_PROPERTY_EVENT_FILTER]"),
            };
            // Make the request
            SubpropertyEventFilter response = await analyticsAdminServiceClient.GetSubpropertyEventFilterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSubpropertyEventFilter</summary>
        public void GetSubpropertyEventFilter()
        {
            // Snippet: GetSubpropertyEventFilter(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/subpropertyEventFilters/[SUB_PROPERTY_EVENT_FILTER]";
            // Make the request
            SubpropertyEventFilter response = analyticsAdminServiceClient.GetSubpropertyEventFilter(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubpropertyEventFilterAsync</summary>
        public async Task GetSubpropertyEventFilterAsync()
        {
            // Snippet: GetSubpropertyEventFilterAsync(string, CallSettings)
            // Additional: GetSubpropertyEventFilterAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/subpropertyEventFilters/[SUB_PROPERTY_EVENT_FILTER]";
            // Make the request
            SubpropertyEventFilter response = await analyticsAdminServiceClient.GetSubpropertyEventFilterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubpropertyEventFilter</summary>
        public void GetSubpropertyEventFilterResourceNames()
        {
            // Snippet: GetSubpropertyEventFilter(SubpropertyEventFilterName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SubpropertyEventFilterName name = SubpropertyEventFilterName.FromPropertySubPropertyEventFilter("[PROPERTY]", "[SUB_PROPERTY_EVENT_FILTER]");
            // Make the request
            SubpropertyEventFilter response = analyticsAdminServiceClient.GetSubpropertyEventFilter(name);
            // End snippet
        }

        /// <summary>Snippet for GetSubpropertyEventFilterAsync</summary>
        public async Task GetSubpropertyEventFilterResourceNamesAsync()
        {
            // Snippet: GetSubpropertyEventFilterAsync(SubpropertyEventFilterName, CallSettings)
            // Additional: GetSubpropertyEventFilterAsync(SubpropertyEventFilterName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubpropertyEventFilterName name = SubpropertyEventFilterName.FromPropertySubPropertyEventFilter("[PROPERTY]", "[SUB_PROPERTY_EVENT_FILTER]");
            // Make the request
            SubpropertyEventFilter response = await analyticsAdminServiceClient.GetSubpropertyEventFilterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSubpropertyEventFilters</summary>
        public void ListSubpropertyEventFiltersRequestObject()
        {
            // Snippet: ListSubpropertyEventFilters(ListSubpropertyEventFiltersRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListSubpropertyEventFiltersRequest request = new ListSubpropertyEventFiltersRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListSubpropertyEventFiltersResponse, SubpropertyEventFilter> response = analyticsAdminServiceClient.ListSubpropertyEventFilters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SubpropertyEventFilter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubpropertyEventFiltersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubpropertyEventFilter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubpropertyEventFilter> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubpropertyEventFilter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubpropertyEventFiltersAsync</summary>
        public async Task ListSubpropertyEventFiltersRequestObjectAsync()
        {
            // Snippet: ListSubpropertyEventFiltersAsync(ListSubpropertyEventFiltersRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSubpropertyEventFiltersRequest request = new ListSubpropertyEventFiltersRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSubpropertyEventFiltersResponse, SubpropertyEventFilter> response = analyticsAdminServiceClient.ListSubpropertyEventFiltersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SubpropertyEventFilter item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubpropertyEventFiltersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubpropertyEventFilter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubpropertyEventFilter> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubpropertyEventFilter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubpropertyEventFilters</summary>
        public void ListSubpropertyEventFilters()
        {
            // Snippet: ListSubpropertyEventFilters(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListSubpropertyEventFiltersResponse, SubpropertyEventFilter> response = analyticsAdminServiceClient.ListSubpropertyEventFilters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SubpropertyEventFilter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubpropertyEventFiltersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubpropertyEventFilter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubpropertyEventFilter> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubpropertyEventFilter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubpropertyEventFiltersAsync</summary>
        public async Task ListSubpropertyEventFiltersAsync()
        {
            // Snippet: ListSubpropertyEventFiltersAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListSubpropertyEventFiltersResponse, SubpropertyEventFilter> response = analyticsAdminServiceClient.ListSubpropertyEventFiltersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SubpropertyEventFilter item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubpropertyEventFiltersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubpropertyEventFilter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubpropertyEventFilter> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubpropertyEventFilter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubpropertyEventFilters</summary>
        public void ListSubpropertyEventFiltersResourceNames()
        {
            // Snippet: ListSubpropertyEventFilters(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListSubpropertyEventFiltersResponse, SubpropertyEventFilter> response = analyticsAdminServiceClient.ListSubpropertyEventFilters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SubpropertyEventFilter item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubpropertyEventFiltersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubpropertyEventFilter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubpropertyEventFilter> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubpropertyEventFilter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSubpropertyEventFiltersAsync</summary>
        public async Task ListSubpropertyEventFiltersResourceNamesAsync()
        {
            // Snippet: ListSubpropertyEventFiltersAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListSubpropertyEventFiltersResponse, SubpropertyEventFilter> response = analyticsAdminServiceClient.ListSubpropertyEventFiltersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SubpropertyEventFilter item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubpropertyEventFiltersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SubpropertyEventFilter item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SubpropertyEventFilter> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SubpropertyEventFilter item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateSubpropertyEventFilter</summary>
        public void UpdateSubpropertyEventFilterRequestObject()
        {
            // Snippet: UpdateSubpropertyEventFilter(UpdateSubpropertyEventFilterRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateSubpropertyEventFilterRequest request = new UpdateSubpropertyEventFilterRequest
            {
                SubpropertyEventFilter = new SubpropertyEventFilter(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SubpropertyEventFilter response = analyticsAdminServiceClient.UpdateSubpropertyEventFilter(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubpropertyEventFilterAsync</summary>
        public async Task UpdateSubpropertyEventFilterRequestObjectAsync()
        {
            // Snippet: UpdateSubpropertyEventFilterAsync(UpdateSubpropertyEventFilterRequest, CallSettings)
            // Additional: UpdateSubpropertyEventFilterAsync(UpdateSubpropertyEventFilterRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSubpropertyEventFilterRequest request = new UpdateSubpropertyEventFilterRequest
            {
                SubpropertyEventFilter = new SubpropertyEventFilter(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SubpropertyEventFilter response = await analyticsAdminServiceClient.UpdateSubpropertyEventFilterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubpropertyEventFilter</summary>
        public void UpdateSubpropertyEventFilter()
        {
            // Snippet: UpdateSubpropertyEventFilter(SubpropertyEventFilter, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SubpropertyEventFilter subpropertyEventFilter = new SubpropertyEventFilter();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SubpropertyEventFilter response = analyticsAdminServiceClient.UpdateSubpropertyEventFilter(subpropertyEventFilter, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSubpropertyEventFilterAsync</summary>
        public async Task UpdateSubpropertyEventFilterAsync()
        {
            // Snippet: UpdateSubpropertyEventFilterAsync(SubpropertyEventFilter, FieldMask, CallSettings)
            // Additional: UpdateSubpropertyEventFilterAsync(SubpropertyEventFilter, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubpropertyEventFilter subpropertyEventFilter = new SubpropertyEventFilter();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SubpropertyEventFilter response = await analyticsAdminServiceClient.UpdateSubpropertyEventFilterAsync(subpropertyEventFilter, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubpropertyEventFilter</summary>
        public void DeleteSubpropertyEventFilterRequestObject()
        {
            // Snippet: DeleteSubpropertyEventFilter(DeleteSubpropertyEventFilterRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteSubpropertyEventFilterRequest request = new DeleteSubpropertyEventFilterRequest
            {
                SubpropertyEventFilterName = SubpropertyEventFilterName.FromPropertySubPropertyEventFilter("[PROPERTY]", "[SUB_PROPERTY_EVENT_FILTER]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteSubpropertyEventFilter(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubpropertyEventFilterAsync</summary>
        public async Task DeleteSubpropertyEventFilterRequestObjectAsync()
        {
            // Snippet: DeleteSubpropertyEventFilterAsync(DeleteSubpropertyEventFilterRequest, CallSettings)
            // Additional: DeleteSubpropertyEventFilterAsync(DeleteSubpropertyEventFilterRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSubpropertyEventFilterRequest request = new DeleteSubpropertyEventFilterRequest
            {
                SubpropertyEventFilterName = SubpropertyEventFilterName.FromPropertySubPropertyEventFilter("[PROPERTY]", "[SUB_PROPERTY_EVENT_FILTER]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteSubpropertyEventFilterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubpropertyEventFilter</summary>
        public void DeleteSubpropertyEventFilter()
        {
            // Snippet: DeleteSubpropertyEventFilter(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/subpropertyEventFilters/[SUB_PROPERTY_EVENT_FILTER]";
            // Make the request
            analyticsAdminServiceClient.DeleteSubpropertyEventFilter(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubpropertyEventFilterAsync</summary>
        public async Task DeleteSubpropertyEventFilterAsync()
        {
            // Snippet: DeleteSubpropertyEventFilterAsync(string, CallSettings)
            // Additional: DeleteSubpropertyEventFilterAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/subpropertyEventFilters/[SUB_PROPERTY_EVENT_FILTER]";
            // Make the request
            await analyticsAdminServiceClient.DeleteSubpropertyEventFilterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubpropertyEventFilter</summary>
        public void DeleteSubpropertyEventFilterResourceNames()
        {
            // Snippet: DeleteSubpropertyEventFilter(SubpropertyEventFilterName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            SubpropertyEventFilterName name = SubpropertyEventFilterName.FromPropertySubPropertyEventFilter("[PROPERTY]", "[SUB_PROPERTY_EVENT_FILTER]");
            // Make the request
            analyticsAdminServiceClient.DeleteSubpropertyEventFilter(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSubpropertyEventFilterAsync</summary>
        public async Task DeleteSubpropertyEventFilterResourceNamesAsync()
        {
            // Snippet: DeleteSubpropertyEventFilterAsync(SubpropertyEventFilterName, CallSettings)
            // Additional: DeleteSubpropertyEventFilterAsync(SubpropertyEventFilterName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            SubpropertyEventFilterName name = SubpropertyEventFilterName.FromPropertySubPropertyEventFilter("[PROPERTY]", "[SUB_PROPERTY_EVENT_FILTER]");
            // Make the request
            await analyticsAdminServiceClient.DeleteSubpropertyEventFilterAsync(name);
            // End snippet
        }
    }
}
