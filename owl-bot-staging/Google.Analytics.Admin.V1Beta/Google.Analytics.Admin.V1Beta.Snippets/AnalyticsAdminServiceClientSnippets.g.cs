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
    using Google.Analytics.Admin.V1Beta;
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
    }
}
