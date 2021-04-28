// Copyright 2021 Google LLC
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

namespace Google.Analytics.Admin.V1Alpha.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAnalyticsAdminServiceClientSnippets
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

        /// <summary>Snippet for GetUserLink</summary>
        public void GetUserLinkRequestObject()
        {
            // Snippet: GetUserLink(GetUserLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetUserLinkRequest request = new GetUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            // Make the request
            UserLink response = analyticsAdminServiceClient.GetUserLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserLinkAsync</summary>
        public async Task GetUserLinkRequestObjectAsync()
        {
            // Snippet: GetUserLinkAsync(GetUserLinkRequest, CallSettings)
            // Additional: GetUserLinkAsync(GetUserLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetUserLinkRequest request = new GetUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            // Make the request
            UserLink response = await analyticsAdminServiceClient.GetUserLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserLink</summary>
        public void GetUserLink()
        {
            // Snippet: GetUserLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/userLinks/[USER_LINK]";
            // Make the request
            UserLink response = analyticsAdminServiceClient.GetUserLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserLinkAsync</summary>
        public async Task GetUserLinkAsync()
        {
            // Snippet: GetUserLinkAsync(string, CallSettings)
            // Additional: GetUserLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/userLinks/[USER_LINK]";
            // Make the request
            UserLink response = await analyticsAdminServiceClient.GetUserLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserLink</summary>
        public void GetUserLinkResourceNames()
        {
            // Snippet: GetUserLink(UserLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UserLinkName name = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]");
            // Make the request
            UserLink response = analyticsAdminServiceClient.GetUserLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserLinkAsync</summary>
        public async Task GetUserLinkResourceNamesAsync()
        {
            // Snippet: GetUserLinkAsync(UserLinkName, CallSettings)
            // Additional: GetUserLinkAsync(UserLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserLinkName name = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]");
            // Make the request
            UserLink response = await analyticsAdminServiceClient.GetUserLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchGetUserLinks</summary>
        public void BatchGetUserLinksRequestObject()
        {
            // Snippet: BatchGetUserLinks(BatchGetUserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BatchGetUserLinksRequest request = new BatchGetUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLinkNames =
                {
                    UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                },
            };
            // Make the request
            BatchGetUserLinksResponse response = analyticsAdminServiceClient.BatchGetUserLinks(request);
            // End snippet
        }

        /// <summary>Snippet for BatchGetUserLinksAsync</summary>
        public async Task BatchGetUserLinksRequestObjectAsync()
        {
            // Snippet: BatchGetUserLinksAsync(BatchGetUserLinksRequest, CallSettings)
            // Additional: BatchGetUserLinksAsync(BatchGetUserLinksRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchGetUserLinksRequest request = new BatchGetUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                UserLinkNames =
                {
                    UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
                },
            };
            // Make the request
            BatchGetUserLinksResponse response = await analyticsAdminServiceClient.BatchGetUserLinksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListUserLinks</summary>
        public void ListUserLinksRequestObject()
        {
            // Snippet: ListUserLinks(ListUserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListUserLinksRequest request = new ListUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListUserLinksResponse, UserLink> response = analyticsAdminServiceClient.ListUserLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLinksAsync</summary>
        public async Task ListUserLinksRequestObjectAsync()
        {
            // Snippet: ListUserLinksAsync(ListUserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUserLinksRequest request = new ListUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListUserLinksResponse, UserLink> response = analyticsAdminServiceClient.ListUserLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLinks</summary>
        public void ListUserLinks()
        {
            // Snippet: ListUserLinks(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListUserLinksResponse, UserLink> response = analyticsAdminServiceClient.ListUserLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLinksAsync</summary>
        public async Task ListUserLinksAsync()
        {
            // Snippet: ListUserLinksAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListUserLinksResponse, UserLink> response = analyticsAdminServiceClient.ListUserLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLinks</summary>
        public void ListUserLinksResourceNames1()
        {
            // Snippet: ListUserLinks(AccountName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListUserLinksResponse, UserLink> response = analyticsAdminServiceClient.ListUserLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLinksAsync</summary>
        public async Task ListUserLinksResourceNames1Async()
        {
            // Snippet: ListUserLinksAsync(AccountName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListUserLinksResponse, UserLink> response = analyticsAdminServiceClient.ListUserLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLinks</summary>
        public void ListUserLinksResourceNames2()
        {
            // Snippet: ListUserLinks(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListUserLinksResponse, UserLink> response = analyticsAdminServiceClient.ListUserLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLinksAsync</summary>
        public async Task ListUserLinksResourceNames2Async()
        {
            // Snippet: ListUserLinksAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListUserLinksResponse, UserLink> response = analyticsAdminServiceClient.ListUserLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AuditUserLinks</summary>
        public void AuditUserLinksRequestObject()
        {
            // Snippet: AuditUserLinks(AuditUserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AuditUserLinksRequest request = new AuditUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<AuditUserLinksResponse, AuditUserLink> response = analyticsAdminServiceClient.AuditUserLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuditUserLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (AuditUserLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditUserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditUserLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditUserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AuditUserLinksAsync</summary>
        public async Task AuditUserLinksRequestObjectAsync()
        {
            // Snippet: AuditUserLinksAsync(AuditUserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AuditUserLinksRequest request = new AuditUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<AuditUserLinksResponse, AuditUserLink> response = analyticsAdminServiceClient.AuditUserLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AuditUserLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((AuditUserLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuditUserLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuditUserLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuditUserLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateUserLink</summary>
        public void CreateUserLinkRequestObject()
        {
            // Snippet: CreateUserLink(CreateUserLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotifyNewUser = false,
                UserLink = new UserLink(),
            };
            // Make the request
            UserLink response = analyticsAdminServiceClient.CreateUserLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserLinkAsync</summary>
        public async Task CreateUserLinkRequestObjectAsync()
        {
            // Snippet: CreateUserLinkAsync(CreateUserLinkRequest, CallSettings)
            // Additional: CreateUserLinkAsync(CreateUserLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateUserLinkRequest request = new CreateUserLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotifyNewUser = false,
                UserLink = new UserLink(),
            };
            // Make the request
            UserLink response = await analyticsAdminServiceClient.CreateUserLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserLink</summary>
        public void CreateUserLink()
        {
            // Snippet: CreateUserLink(string, UserLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            UserLink userLink = new UserLink();
            // Make the request
            UserLink response = analyticsAdminServiceClient.CreateUserLink(parent, userLink);
            // End snippet
        }

        /// <summary>Snippet for CreateUserLinkAsync</summary>
        public async Task CreateUserLinkAsync()
        {
            // Snippet: CreateUserLinkAsync(string, UserLink, CallSettings)
            // Additional: CreateUserLinkAsync(string, UserLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            UserLink userLink = new UserLink();
            // Make the request
            UserLink response = await analyticsAdminServiceClient.CreateUserLinkAsync(parent, userLink);
            // End snippet
        }

        /// <summary>Snippet for CreateUserLink</summary>
        public void CreateUserLinkResourceNames1()
        {
            // Snippet: CreateUserLink(AccountName, UserLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            UserLink userLink = new UserLink();
            // Make the request
            UserLink response = analyticsAdminServiceClient.CreateUserLink(parent, userLink);
            // End snippet
        }

        /// <summary>Snippet for CreateUserLinkAsync</summary>
        public async Task CreateUserLinkResourceNames1Async()
        {
            // Snippet: CreateUserLinkAsync(AccountName, UserLink, CallSettings)
            // Additional: CreateUserLinkAsync(AccountName, UserLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            UserLink userLink = new UserLink();
            // Make the request
            UserLink response = await analyticsAdminServiceClient.CreateUserLinkAsync(parent, userLink);
            // End snippet
        }

        /// <summary>Snippet for CreateUserLink</summary>
        public void CreateUserLinkResourceNames2()
        {
            // Snippet: CreateUserLink(PropertyName, UserLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            UserLink userLink = new UserLink();
            // Make the request
            UserLink response = analyticsAdminServiceClient.CreateUserLink(parent, userLink);
            // End snippet
        }

        /// <summary>Snippet for CreateUserLinkAsync</summary>
        public async Task CreateUserLinkResourceNames2Async()
        {
            // Snippet: CreateUserLinkAsync(PropertyName, UserLink, CallSettings)
            // Additional: CreateUserLinkAsync(PropertyName, UserLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            UserLink userLink = new UserLink();
            // Make the request
            UserLink response = await analyticsAdminServiceClient.CreateUserLinkAsync(parent, userLink);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateUserLinks</summary>
        public void BatchCreateUserLinksRequestObject()
        {
            // Snippet: BatchCreateUserLinks(BatchCreateUserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateUserLinksRequest request = new BatchCreateUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotifyNewUsers = false,
                Requests =
                {
                    new CreateUserLinkRequest(),
                },
            };
            // Make the request
            BatchCreateUserLinksResponse response = analyticsAdminServiceClient.BatchCreateUserLinks(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateUserLinksAsync</summary>
        public async Task BatchCreateUserLinksRequestObjectAsync()
        {
            // Snippet: BatchCreateUserLinksAsync(BatchCreateUserLinksRequest, CallSettings)
            // Additional: BatchCreateUserLinksAsync(BatchCreateUserLinksRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateUserLinksRequest request = new BatchCreateUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                NotifyNewUsers = false,
                Requests =
                {
                    new CreateUserLinkRequest(),
                },
            };
            // Make the request
            BatchCreateUserLinksResponse response = await analyticsAdminServiceClient.BatchCreateUserLinksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserLink</summary>
        public void UpdateUserLinkRequestObject()
        {
            // Snippet: UpdateUserLink(UpdateUserLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateUserLinkRequest request = new UpdateUserLinkRequest
            {
                UserLink = new UserLink(),
            };
            // Make the request
            UserLink response = analyticsAdminServiceClient.UpdateUserLink(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserLinkAsync</summary>
        public async Task UpdateUserLinkRequestObjectAsync()
        {
            // Snippet: UpdateUserLinkAsync(UpdateUserLinkRequest, CallSettings)
            // Additional: UpdateUserLinkAsync(UpdateUserLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserLinkRequest request = new UpdateUserLinkRequest
            {
                UserLink = new UserLink(),
            };
            // Make the request
            UserLink response = await analyticsAdminServiceClient.UpdateUserLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserLink</summary>
        public void UpdateUserLink()
        {
            // Snippet: UpdateUserLink(UserLink, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UserLink userLink = new UserLink();
            // Make the request
            UserLink response = analyticsAdminServiceClient.UpdateUserLink(userLink);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserLinkAsync</summary>
        public async Task UpdateUserLinkAsync()
        {
            // Snippet: UpdateUserLinkAsync(UserLink, CallSettings)
            // Additional: UpdateUserLinkAsync(UserLink, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserLink userLink = new UserLink();
            // Make the request
            UserLink response = await analyticsAdminServiceClient.UpdateUserLinkAsync(userLink);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateUserLinks</summary>
        public void BatchUpdateUserLinksRequestObject()
        {
            // Snippet: BatchUpdateUserLinks(BatchUpdateUserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateUserLinksRequest request = new BatchUpdateUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new UpdateUserLinkRequest(),
                },
            };
            // Make the request
            BatchUpdateUserLinksResponse response = analyticsAdminServiceClient.BatchUpdateUserLinks(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateUserLinksAsync</summary>
        public async Task BatchUpdateUserLinksRequestObjectAsync()
        {
            // Snippet: BatchUpdateUserLinksAsync(BatchUpdateUserLinksRequest, CallSettings)
            // Additional: BatchUpdateUserLinksAsync(BatchUpdateUserLinksRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateUserLinksRequest request = new BatchUpdateUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new UpdateUserLinkRequest(),
                },
            };
            // Make the request
            BatchUpdateUserLinksResponse response = await analyticsAdminServiceClient.BatchUpdateUserLinksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserLink</summary>
        public void DeleteUserLinkRequestObject()
        {
            // Snippet: DeleteUserLink(DeleteUserLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteUserLinkRequest request = new DeleteUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteUserLink(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserLinkAsync</summary>
        public async Task DeleteUserLinkRequestObjectAsync()
        {
            // Snippet: DeleteUserLinkAsync(DeleteUserLinkRequest, CallSettings)
            // Additional: DeleteUserLinkAsync(DeleteUserLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUserLinkRequest request = new DeleteUserLinkRequest
            {
                UserLinkName = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteUserLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserLink</summary>
        public void DeleteUserLink()
        {
            // Snippet: DeleteUserLink(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/userLinks/[USER_LINK]";
            // Make the request
            analyticsAdminServiceClient.DeleteUserLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserLinkAsync</summary>
        public async Task DeleteUserLinkAsync()
        {
            // Snippet: DeleteUserLinkAsync(string, CallSettings)
            // Additional: DeleteUserLinkAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/userLinks/[USER_LINK]";
            // Make the request
            await analyticsAdminServiceClient.DeleteUserLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserLink</summary>
        public void DeleteUserLinkResourceNames()
        {
            // Snippet: DeleteUserLink(UserLinkName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UserLinkName name = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]");
            // Make the request
            analyticsAdminServiceClient.DeleteUserLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserLinkAsync</summary>
        public async Task DeleteUserLinkResourceNamesAsync()
        {
            // Snippet: DeleteUserLinkAsync(UserLinkName, CallSettings)
            // Additional: DeleteUserLinkAsync(UserLinkName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserLinkName name = UserLinkName.FromAccountUserLink("[ACCOUNT]", "[USER_LINK]");
            // Make the request
            await analyticsAdminServiceClient.DeleteUserLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteUserLinks</summary>
        public void BatchDeleteUserLinksRequestObject()
        {
            // Snippet: BatchDeleteUserLinks(BatchDeleteUserLinksRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteUserLinksRequest request = new BatchDeleteUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new DeleteUserLinkRequest(),
                },
            };
            // Make the request
            analyticsAdminServiceClient.BatchDeleteUserLinks(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteUserLinksAsync</summary>
        public async Task BatchDeleteUserLinksRequestObjectAsync()
        {
            // Snippet: BatchDeleteUserLinksAsync(BatchDeleteUserLinksRequest, CallSettings)
            // Additional: BatchDeleteUserLinksAsync(BatchDeleteUserLinksRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteUserLinksRequest request = new BatchDeleteUserLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Requests =
                {
                    new DeleteUserLinkRequest(),
                },
            };
            // Make the request
            await analyticsAdminServiceClient.BatchDeleteUserLinksAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWebDataStream</summary>
        public void GetWebDataStreamRequestObject()
        {
            // Snippet: GetWebDataStream(GetWebDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetWebDataStreamRequest request = new GetWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            // Make the request
            WebDataStream response = analyticsAdminServiceClient.GetWebDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for GetWebDataStreamAsync</summary>
        public async Task GetWebDataStreamRequestObjectAsync()
        {
            // Snippet: GetWebDataStreamAsync(GetWebDataStreamRequest, CallSettings)
            // Additional: GetWebDataStreamAsync(GetWebDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetWebDataStreamRequest request = new GetWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            // Make the request
            WebDataStream response = await analyticsAdminServiceClient.GetWebDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWebDataStream</summary>
        public void GetWebDataStream()
        {
            // Snippet: GetWebDataStream(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/webDataStreams/[WEB_DATA_STREAM]";
            // Make the request
            WebDataStream response = analyticsAdminServiceClient.GetWebDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetWebDataStreamAsync</summary>
        public async Task GetWebDataStreamAsync()
        {
            // Snippet: GetWebDataStreamAsync(string, CallSettings)
            // Additional: GetWebDataStreamAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/webDataStreams/[WEB_DATA_STREAM]";
            // Make the request
            WebDataStream response = await analyticsAdminServiceClient.GetWebDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWebDataStream</summary>
        public void GetWebDataStreamResourceNames()
        {
            // Snippet: GetWebDataStream(WebDataStreamName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            WebDataStreamName name = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]");
            // Make the request
            WebDataStream response = analyticsAdminServiceClient.GetWebDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetWebDataStreamAsync</summary>
        public async Task GetWebDataStreamResourceNamesAsync()
        {
            // Snippet: GetWebDataStreamAsync(WebDataStreamName, CallSettings)
            // Additional: GetWebDataStreamAsync(WebDataStreamName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            WebDataStreamName name = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]");
            // Make the request
            WebDataStream response = await analyticsAdminServiceClient.GetWebDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebDataStream</summary>
        public void DeleteWebDataStreamRequestObject()
        {
            // Snippet: DeleteWebDataStream(DeleteWebDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteWebDataStreamRequest request = new DeleteWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteWebDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebDataStreamAsync</summary>
        public async Task DeleteWebDataStreamRequestObjectAsync()
        {
            // Snippet: DeleteWebDataStreamAsync(DeleteWebDataStreamRequest, CallSettings)
            // Additional: DeleteWebDataStreamAsync(DeleteWebDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWebDataStreamRequest request = new DeleteWebDataStreamRequest
            {
                WebDataStreamName = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteWebDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebDataStream</summary>
        public void DeleteWebDataStream()
        {
            // Snippet: DeleteWebDataStream(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/webDataStreams/[WEB_DATA_STREAM]";
            // Make the request
            analyticsAdminServiceClient.DeleteWebDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebDataStreamAsync</summary>
        public async Task DeleteWebDataStreamAsync()
        {
            // Snippet: DeleteWebDataStreamAsync(string, CallSettings)
            // Additional: DeleteWebDataStreamAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/webDataStreams/[WEB_DATA_STREAM]";
            // Make the request
            await analyticsAdminServiceClient.DeleteWebDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebDataStream</summary>
        public void DeleteWebDataStreamResourceNames()
        {
            // Snippet: DeleteWebDataStream(WebDataStreamName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            WebDataStreamName name = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]");
            // Make the request
            analyticsAdminServiceClient.DeleteWebDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteWebDataStreamAsync</summary>
        public async Task DeleteWebDataStreamResourceNamesAsync()
        {
            // Snippet: DeleteWebDataStreamAsync(WebDataStreamName, CallSettings)
            // Additional: DeleteWebDataStreamAsync(WebDataStreamName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            WebDataStreamName name = WebDataStreamName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]");
            // Make the request
            await analyticsAdminServiceClient.DeleteWebDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateWebDataStream</summary>
        public void UpdateWebDataStreamRequestObject()
        {
            // Snippet: UpdateWebDataStream(UpdateWebDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateWebDataStreamRequest request = new UpdateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            WebDataStream response = analyticsAdminServiceClient.UpdateWebDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWebDataStreamAsync</summary>
        public async Task UpdateWebDataStreamRequestObjectAsync()
        {
            // Snippet: UpdateWebDataStreamAsync(UpdateWebDataStreamRequest, CallSettings)
            // Additional: UpdateWebDataStreamAsync(UpdateWebDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWebDataStreamRequest request = new UpdateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            WebDataStream response = await analyticsAdminServiceClient.UpdateWebDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWebDataStream</summary>
        public void UpdateWebDataStream()
        {
            // Snippet: UpdateWebDataStream(WebDataStream, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            WebDataStream webDataStream = new WebDataStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            WebDataStream response = analyticsAdminServiceClient.UpdateWebDataStream(webDataStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateWebDataStreamAsync</summary>
        public async Task UpdateWebDataStreamAsync()
        {
            // Snippet: UpdateWebDataStreamAsync(WebDataStream, FieldMask, CallSettings)
            // Additional: UpdateWebDataStreamAsync(WebDataStream, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            WebDataStream webDataStream = new WebDataStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            WebDataStream response = await analyticsAdminServiceClient.UpdateWebDataStreamAsync(webDataStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreateWebDataStream</summary>
        public void CreateWebDataStreamRequestObject()
        {
            // Snippet: CreateWebDataStream(CreateWebDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            CreateWebDataStreamRequest request = new CreateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            WebDataStream response = analyticsAdminServiceClient.CreateWebDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWebDataStreamAsync</summary>
        public async Task CreateWebDataStreamRequestObjectAsync()
        {
            // Snippet: CreateWebDataStreamAsync(CreateWebDataStreamRequest, CallSettings)
            // Additional: CreateWebDataStreamAsync(CreateWebDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateWebDataStreamRequest request = new CreateWebDataStreamRequest
            {
                WebDataStream = new WebDataStream(),
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            WebDataStream response = await analyticsAdminServiceClient.CreateWebDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWebDataStream</summary>
        public void CreateWebDataStream()
        {
            // Snippet: CreateWebDataStream(string, WebDataStream, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            WebDataStream webDataStream = new WebDataStream();
            // Make the request
            WebDataStream response = analyticsAdminServiceClient.CreateWebDataStream(parent, webDataStream);
            // End snippet
        }

        /// <summary>Snippet for CreateWebDataStreamAsync</summary>
        public async Task CreateWebDataStreamAsync()
        {
            // Snippet: CreateWebDataStreamAsync(string, WebDataStream, CallSettings)
            // Additional: CreateWebDataStreamAsync(string, WebDataStream, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            WebDataStream webDataStream = new WebDataStream();
            // Make the request
            WebDataStream response = await analyticsAdminServiceClient.CreateWebDataStreamAsync(parent, webDataStream);
            // End snippet
        }

        /// <summary>Snippet for CreateWebDataStream</summary>
        public void CreateWebDataStreamResourceNames()
        {
            // Snippet: CreateWebDataStream(PropertyName, WebDataStream, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            WebDataStream webDataStream = new WebDataStream();
            // Make the request
            WebDataStream response = analyticsAdminServiceClient.CreateWebDataStream(parent, webDataStream);
            // End snippet
        }

        /// <summary>Snippet for CreateWebDataStreamAsync</summary>
        public async Task CreateWebDataStreamResourceNamesAsync()
        {
            // Snippet: CreateWebDataStreamAsync(PropertyName, WebDataStream, CallSettings)
            // Additional: CreateWebDataStreamAsync(PropertyName, WebDataStream, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            WebDataStream webDataStream = new WebDataStream();
            // Make the request
            WebDataStream response = await analyticsAdminServiceClient.CreateWebDataStreamAsync(parent, webDataStream);
            // End snippet
        }

        /// <summary>Snippet for ListWebDataStreams</summary>
        public void ListWebDataStreamsRequestObject()
        {
            // Snippet: ListWebDataStreams(ListWebDataStreamsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListWebDataStreamsRequest request = new ListWebDataStreamsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListWebDataStreamsResponse, WebDataStream> response = analyticsAdminServiceClient.ListWebDataStreams(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WebDataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWebDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WebDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WebDataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WebDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebDataStreamsAsync</summary>
        public async Task ListWebDataStreamsRequestObjectAsync()
        {
            // Snippet: ListWebDataStreamsAsync(ListWebDataStreamsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListWebDataStreamsRequest request = new ListWebDataStreamsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListWebDataStreamsResponse, WebDataStream> response = analyticsAdminServiceClient.ListWebDataStreamsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WebDataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWebDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WebDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WebDataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WebDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebDataStreams</summary>
        public void ListWebDataStreams()
        {
            // Snippet: ListWebDataStreams(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListWebDataStreamsResponse, WebDataStream> response = analyticsAdminServiceClient.ListWebDataStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WebDataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWebDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WebDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WebDataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WebDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebDataStreamsAsync</summary>
        public async Task ListWebDataStreamsAsync()
        {
            // Snippet: ListWebDataStreamsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListWebDataStreamsResponse, WebDataStream> response = analyticsAdminServiceClient.ListWebDataStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WebDataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWebDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WebDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WebDataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WebDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebDataStreams</summary>
        public void ListWebDataStreamsResourceNames()
        {
            // Snippet: ListWebDataStreams(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListWebDataStreamsResponse, WebDataStream> response = analyticsAdminServiceClient.ListWebDataStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WebDataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWebDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WebDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WebDataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WebDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWebDataStreamsAsync</summary>
        public async Task ListWebDataStreamsResourceNamesAsync()
        {
            // Snippet: ListWebDataStreamsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListWebDataStreamsResponse, WebDataStream> response = analyticsAdminServiceClient.ListWebDataStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WebDataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWebDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WebDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WebDataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WebDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetIosAppDataStream</summary>
        public void GetIosAppDataStreamRequestObject()
        {
            // Snippet: GetIosAppDataStream(GetIosAppDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetIosAppDataStreamRequest request = new GetIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            // Make the request
            IosAppDataStream response = analyticsAdminServiceClient.GetIosAppDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for GetIosAppDataStreamAsync</summary>
        public async Task GetIosAppDataStreamRequestObjectAsync()
        {
            // Snippet: GetIosAppDataStreamAsync(GetIosAppDataStreamRequest, CallSettings)
            // Additional: GetIosAppDataStreamAsync(GetIosAppDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIosAppDataStreamRequest request = new GetIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            // Make the request
            IosAppDataStream response = await analyticsAdminServiceClient.GetIosAppDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIosAppDataStream</summary>
        public void GetIosAppDataStream()
        {
            // Snippet: GetIosAppDataStream(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/iosAppDataStreams/[IOS_APP_DATA_STREAM]";
            // Make the request
            IosAppDataStream response = analyticsAdminServiceClient.GetIosAppDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetIosAppDataStreamAsync</summary>
        public async Task GetIosAppDataStreamAsync()
        {
            // Snippet: GetIosAppDataStreamAsync(string, CallSettings)
            // Additional: GetIosAppDataStreamAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/iosAppDataStreams/[IOS_APP_DATA_STREAM]";
            // Make the request
            IosAppDataStream response = await analyticsAdminServiceClient.GetIosAppDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIosAppDataStream</summary>
        public void GetIosAppDataStreamResourceNames()
        {
            // Snippet: GetIosAppDataStream(IosAppDataStreamName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            IosAppDataStreamName name = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]");
            // Make the request
            IosAppDataStream response = analyticsAdminServiceClient.GetIosAppDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetIosAppDataStreamAsync</summary>
        public async Task GetIosAppDataStreamResourceNamesAsync()
        {
            // Snippet: GetIosAppDataStreamAsync(IosAppDataStreamName, CallSettings)
            // Additional: GetIosAppDataStreamAsync(IosAppDataStreamName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            IosAppDataStreamName name = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]");
            // Make the request
            IosAppDataStream response = await analyticsAdminServiceClient.GetIosAppDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIosAppDataStream</summary>
        public void DeleteIosAppDataStreamRequestObject()
        {
            // Snippet: DeleteIosAppDataStream(DeleteIosAppDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteIosAppDataStreamRequest request = new DeleteIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteIosAppDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIosAppDataStreamAsync</summary>
        public async Task DeleteIosAppDataStreamRequestObjectAsync()
        {
            // Snippet: DeleteIosAppDataStreamAsync(DeleteIosAppDataStreamRequest, CallSettings)
            // Additional: DeleteIosAppDataStreamAsync(DeleteIosAppDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIosAppDataStreamRequest request = new DeleteIosAppDataStreamRequest
            {
                IosAppDataStreamName = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteIosAppDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIosAppDataStream</summary>
        public void DeleteIosAppDataStream()
        {
            // Snippet: DeleteIosAppDataStream(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/iosAppDataStreams/[IOS_APP_DATA_STREAM]";
            // Make the request
            analyticsAdminServiceClient.DeleteIosAppDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIosAppDataStreamAsync</summary>
        public async Task DeleteIosAppDataStreamAsync()
        {
            // Snippet: DeleteIosAppDataStreamAsync(string, CallSettings)
            // Additional: DeleteIosAppDataStreamAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/iosAppDataStreams/[IOS_APP_DATA_STREAM]";
            // Make the request
            await analyticsAdminServiceClient.DeleteIosAppDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIosAppDataStream</summary>
        public void DeleteIosAppDataStreamResourceNames()
        {
            // Snippet: DeleteIosAppDataStream(IosAppDataStreamName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            IosAppDataStreamName name = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]");
            // Make the request
            analyticsAdminServiceClient.DeleteIosAppDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIosAppDataStreamAsync</summary>
        public async Task DeleteIosAppDataStreamResourceNamesAsync()
        {
            // Snippet: DeleteIosAppDataStreamAsync(IosAppDataStreamName, CallSettings)
            // Additional: DeleteIosAppDataStreamAsync(IosAppDataStreamName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            IosAppDataStreamName name = IosAppDataStreamName.FromPropertyIosAppDataStream("[PROPERTY]", "[IOS_APP_DATA_STREAM]");
            // Make the request
            await analyticsAdminServiceClient.DeleteIosAppDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateIosAppDataStream</summary>
        public void UpdateIosAppDataStreamRequestObject()
        {
            // Snippet: UpdateIosAppDataStream(UpdateIosAppDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateIosAppDataStreamRequest request = new UpdateIosAppDataStreamRequest
            {
                IosAppDataStream = new IosAppDataStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IosAppDataStream response = analyticsAdminServiceClient.UpdateIosAppDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIosAppDataStreamAsync</summary>
        public async Task UpdateIosAppDataStreamRequestObjectAsync()
        {
            // Snippet: UpdateIosAppDataStreamAsync(UpdateIosAppDataStreamRequest, CallSettings)
            // Additional: UpdateIosAppDataStreamAsync(UpdateIosAppDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIosAppDataStreamRequest request = new UpdateIosAppDataStreamRequest
            {
                IosAppDataStream = new IosAppDataStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IosAppDataStream response = await analyticsAdminServiceClient.UpdateIosAppDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIosAppDataStream</summary>
        public void UpdateIosAppDataStream()
        {
            // Snippet: UpdateIosAppDataStream(IosAppDataStream, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            IosAppDataStream iosAppDataStream = new IosAppDataStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            IosAppDataStream response = analyticsAdminServiceClient.UpdateIosAppDataStream(iosAppDataStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateIosAppDataStreamAsync</summary>
        public async Task UpdateIosAppDataStreamAsync()
        {
            // Snippet: UpdateIosAppDataStreamAsync(IosAppDataStream, FieldMask, CallSettings)
            // Additional: UpdateIosAppDataStreamAsync(IosAppDataStream, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            IosAppDataStream iosAppDataStream = new IosAppDataStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            IosAppDataStream response = await analyticsAdminServiceClient.UpdateIosAppDataStreamAsync(iosAppDataStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListIosAppDataStreams</summary>
        public void ListIosAppDataStreamsRequestObject()
        {
            // Snippet: ListIosAppDataStreams(ListIosAppDataStreamsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListIosAppDataStreamsRequest request = new ListIosAppDataStreamsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListIosAppDataStreamsResponse, IosAppDataStream> response = analyticsAdminServiceClient.ListIosAppDataStreams(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IosAppDataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIosAppDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IosAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IosAppDataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IosAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIosAppDataStreamsAsync</summary>
        public async Task ListIosAppDataStreamsRequestObjectAsync()
        {
            // Snippet: ListIosAppDataStreamsAsync(ListIosAppDataStreamsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListIosAppDataStreamsRequest request = new ListIosAppDataStreamsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListIosAppDataStreamsResponse, IosAppDataStream> response = analyticsAdminServiceClient.ListIosAppDataStreamsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IosAppDataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIosAppDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IosAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IosAppDataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IosAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIosAppDataStreams</summary>
        public void ListIosAppDataStreams()
        {
            // Snippet: ListIosAppDataStreams(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListIosAppDataStreamsResponse, IosAppDataStream> response = analyticsAdminServiceClient.ListIosAppDataStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IosAppDataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIosAppDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IosAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IosAppDataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IosAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIosAppDataStreamsAsync</summary>
        public async Task ListIosAppDataStreamsAsync()
        {
            // Snippet: ListIosAppDataStreamsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListIosAppDataStreamsResponse, IosAppDataStream> response = analyticsAdminServiceClient.ListIosAppDataStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IosAppDataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIosAppDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IosAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IosAppDataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IosAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIosAppDataStreams</summary>
        public void ListIosAppDataStreamsResourceNames()
        {
            // Snippet: ListIosAppDataStreams(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListIosAppDataStreamsResponse, IosAppDataStream> response = analyticsAdminServiceClient.ListIosAppDataStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (IosAppDataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIosAppDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IosAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IosAppDataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IosAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIosAppDataStreamsAsync</summary>
        public async Task ListIosAppDataStreamsResourceNamesAsync()
        {
            // Snippet: ListIosAppDataStreamsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListIosAppDataStreamsResponse, IosAppDataStream> response = analyticsAdminServiceClient.ListIosAppDataStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((IosAppDataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIosAppDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (IosAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<IosAppDataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (IosAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAndroidAppDataStream</summary>
        public void GetAndroidAppDataStreamRequestObject()
        {
            // Snippet: GetAndroidAppDataStream(GetAndroidAppDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            GetAndroidAppDataStreamRequest request = new GetAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            // Make the request
            AndroidAppDataStream response = analyticsAdminServiceClient.GetAndroidAppDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for GetAndroidAppDataStreamAsync</summary>
        public async Task GetAndroidAppDataStreamRequestObjectAsync()
        {
            // Snippet: GetAndroidAppDataStreamAsync(GetAndroidAppDataStreamRequest, CallSettings)
            // Additional: GetAndroidAppDataStreamAsync(GetAndroidAppDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAndroidAppDataStreamRequest request = new GetAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            // Make the request
            AndroidAppDataStream response = await analyticsAdminServiceClient.GetAndroidAppDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAndroidAppDataStream</summary>
        public void GetAndroidAppDataStream()
        {
            // Snippet: GetAndroidAppDataStream(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/androidAppDataStreams/[ANDROID_APP_DATA_STREAM]";
            // Make the request
            AndroidAppDataStream response = analyticsAdminServiceClient.GetAndroidAppDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetAndroidAppDataStreamAsync</summary>
        public async Task GetAndroidAppDataStreamAsync()
        {
            // Snippet: GetAndroidAppDataStreamAsync(string, CallSettings)
            // Additional: GetAndroidAppDataStreamAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/androidAppDataStreams/[ANDROID_APP_DATA_STREAM]";
            // Make the request
            AndroidAppDataStream response = await analyticsAdminServiceClient.GetAndroidAppDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAndroidAppDataStream</summary>
        public void GetAndroidAppDataStreamResourceNames()
        {
            // Snippet: GetAndroidAppDataStream(AndroidAppDataStreamName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AndroidAppDataStreamName name = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]");
            // Make the request
            AndroidAppDataStream response = analyticsAdminServiceClient.GetAndroidAppDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetAndroidAppDataStreamAsync</summary>
        public async Task GetAndroidAppDataStreamResourceNamesAsync()
        {
            // Snippet: GetAndroidAppDataStreamAsync(AndroidAppDataStreamName, CallSettings)
            // Additional: GetAndroidAppDataStreamAsync(AndroidAppDataStreamName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AndroidAppDataStreamName name = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]");
            // Make the request
            AndroidAppDataStream response = await analyticsAdminServiceClient.GetAndroidAppDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAndroidAppDataStream</summary>
        public void DeleteAndroidAppDataStreamRequestObject()
        {
            // Snippet: DeleteAndroidAppDataStream(DeleteAndroidAppDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            DeleteAndroidAppDataStreamRequest request = new DeleteAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            // Make the request
            analyticsAdminServiceClient.DeleteAndroidAppDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAndroidAppDataStreamAsync</summary>
        public async Task DeleteAndroidAppDataStreamRequestObjectAsync()
        {
            // Snippet: DeleteAndroidAppDataStreamAsync(DeleteAndroidAppDataStreamRequest, CallSettings)
            // Additional: DeleteAndroidAppDataStreamAsync(DeleteAndroidAppDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAndroidAppDataStreamRequest request = new DeleteAndroidAppDataStreamRequest
            {
                AndroidAppDataStreamName = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]"),
            };
            // Make the request
            await analyticsAdminServiceClient.DeleteAndroidAppDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAndroidAppDataStream</summary>
        public void DeleteAndroidAppDataStream()
        {
            // Snippet: DeleteAndroidAppDataStream(string, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/androidAppDataStreams/[ANDROID_APP_DATA_STREAM]";
            // Make the request
            analyticsAdminServiceClient.DeleteAndroidAppDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAndroidAppDataStreamAsync</summary>
        public async Task DeleteAndroidAppDataStreamAsync()
        {
            // Snippet: DeleteAndroidAppDataStreamAsync(string, CallSettings)
            // Additional: DeleteAndroidAppDataStreamAsync(string, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "properties/[PROPERTY]/androidAppDataStreams/[ANDROID_APP_DATA_STREAM]";
            // Make the request
            await analyticsAdminServiceClient.DeleteAndroidAppDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAndroidAppDataStream</summary>
        public void DeleteAndroidAppDataStreamResourceNames()
        {
            // Snippet: DeleteAndroidAppDataStream(AndroidAppDataStreamName, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AndroidAppDataStreamName name = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]");
            // Make the request
            analyticsAdminServiceClient.DeleteAndroidAppDataStream(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAndroidAppDataStreamAsync</summary>
        public async Task DeleteAndroidAppDataStreamResourceNamesAsync()
        {
            // Snippet: DeleteAndroidAppDataStreamAsync(AndroidAppDataStreamName, CallSettings)
            // Additional: DeleteAndroidAppDataStreamAsync(AndroidAppDataStreamName, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AndroidAppDataStreamName name = AndroidAppDataStreamName.FromPropertyAndroidAppDataStream("[PROPERTY]", "[ANDROID_APP_DATA_STREAM]");
            // Make the request
            await analyticsAdminServiceClient.DeleteAndroidAppDataStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAndroidAppDataStream</summary>
        public void UpdateAndroidAppDataStreamRequestObject()
        {
            // Snippet: UpdateAndroidAppDataStream(UpdateAndroidAppDataStreamRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateAndroidAppDataStreamRequest request = new UpdateAndroidAppDataStreamRequest
            {
                AndroidAppDataStream = new AndroidAppDataStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AndroidAppDataStream response = analyticsAdminServiceClient.UpdateAndroidAppDataStream(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAndroidAppDataStreamAsync</summary>
        public async Task UpdateAndroidAppDataStreamRequestObjectAsync()
        {
            // Snippet: UpdateAndroidAppDataStreamAsync(UpdateAndroidAppDataStreamRequest, CallSettings)
            // Additional: UpdateAndroidAppDataStreamAsync(UpdateAndroidAppDataStreamRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAndroidAppDataStreamRequest request = new UpdateAndroidAppDataStreamRequest
            {
                AndroidAppDataStream = new AndroidAppDataStream(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AndroidAppDataStream response = await analyticsAdminServiceClient.UpdateAndroidAppDataStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAndroidAppDataStream</summary>
        public void UpdateAndroidAppDataStream()
        {
            // Snippet: UpdateAndroidAppDataStream(AndroidAppDataStream, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            AndroidAppDataStream androidAppDataStream = new AndroidAppDataStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AndroidAppDataStream response = analyticsAdminServiceClient.UpdateAndroidAppDataStream(androidAppDataStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAndroidAppDataStreamAsync</summary>
        public async Task UpdateAndroidAppDataStreamAsync()
        {
            // Snippet: UpdateAndroidAppDataStreamAsync(AndroidAppDataStream, FieldMask, CallSettings)
            // Additional: UpdateAndroidAppDataStreamAsync(AndroidAppDataStream, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            AndroidAppDataStream androidAppDataStream = new AndroidAppDataStream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AndroidAppDataStream response = await analyticsAdminServiceClient.UpdateAndroidAppDataStreamAsync(androidAppDataStream, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListAndroidAppDataStreams</summary>
        public void ListAndroidAppDataStreamsRequestObject()
        {
            // Snippet: ListAndroidAppDataStreams(ListAndroidAppDataStreamsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            ListAndroidAppDataStreamsRequest request = new ListAndroidAppDataStreamsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedEnumerable<ListAndroidAppDataStreamsResponse, AndroidAppDataStream> response = analyticsAdminServiceClient.ListAndroidAppDataStreams(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AndroidAppDataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAndroidAppDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AndroidAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AndroidAppDataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AndroidAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAndroidAppDataStreamsAsync</summary>
        public async Task ListAndroidAppDataStreamsRequestObjectAsync()
        {
            // Snippet: ListAndroidAppDataStreamsAsync(ListAndroidAppDataStreamsRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAndroidAppDataStreamsRequest request = new ListAndroidAppDataStreamsRequest
            {
                ParentAsPropertyName = PropertyName.FromProperty("[PROPERTY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAndroidAppDataStreamsResponse, AndroidAppDataStream> response = analyticsAdminServiceClient.ListAndroidAppDataStreamsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AndroidAppDataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAndroidAppDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AndroidAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AndroidAppDataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AndroidAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAndroidAppDataStreams</summary>
        public void ListAndroidAppDataStreams()
        {
            // Snippet: ListAndroidAppDataStreams(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedEnumerable<ListAndroidAppDataStreamsResponse, AndroidAppDataStream> response = analyticsAdminServiceClient.ListAndroidAppDataStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AndroidAppDataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAndroidAppDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AndroidAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AndroidAppDataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AndroidAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAndroidAppDataStreamsAsync</summary>
        public async Task ListAndroidAppDataStreamsAsync()
        {
            // Snippet: ListAndroidAppDataStreamsAsync(string, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "properties/[PROPERTY]";
            // Make the request
            PagedAsyncEnumerable<ListAndroidAppDataStreamsResponse, AndroidAppDataStream> response = analyticsAdminServiceClient.ListAndroidAppDataStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AndroidAppDataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAndroidAppDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AndroidAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AndroidAppDataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AndroidAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAndroidAppDataStreams</summary>
        public void ListAndroidAppDataStreamsResourceNames()
        {
            // Snippet: ListAndroidAppDataStreams(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedEnumerable<ListAndroidAppDataStreamsResponse, AndroidAppDataStream> response = analyticsAdminServiceClient.ListAndroidAppDataStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AndroidAppDataStream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAndroidAppDataStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AndroidAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AndroidAppDataStream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AndroidAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAndroidAppDataStreamsAsync</summary>
        public async Task ListAndroidAppDataStreamsResourceNamesAsync()
        {
            // Snippet: ListAndroidAppDataStreamsAsync(PropertyName, string, int?, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            PropertyName parent = PropertyName.FromProperty("[PROPERTY]");
            // Make the request
            PagedAsyncEnumerable<ListAndroidAppDataStreamsResponse, AndroidAppDataStream> response = analyticsAdminServiceClient.ListAndroidAppDataStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AndroidAppDataStream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAndroidAppDataStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AndroidAppDataStream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AndroidAppDataStream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AndroidAppDataStream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
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
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
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
                EnhancedMeasurementSettingsName = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]"),
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
            string name = "properties/[PROPERTY]/webDataStreams/[WEB_DATA_STREAM]/enhancedMeasurementSettings";
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
            string name = "properties/[PROPERTY]/webDataStreams/[WEB_DATA_STREAM]/enhancedMeasurementSettings";
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
            EnhancedMeasurementSettingsName name = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]");
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
            EnhancedMeasurementSettingsName name = EnhancedMeasurementSettingsName.FromPropertyWebDataStream("[PROPERTY]", "[WEB_DATA_STREAM]");
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

        /// <summary>Snippet for UpdateFirebaseLink</summary>
        public void UpdateFirebaseLinkRequestObject()
        {
            // Snippet: UpdateFirebaseLink(UpdateFirebaseLinkRequest, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            UpdateFirebaseLinkRequest request = new UpdateFirebaseLinkRequest
            {
                FirebaseLink = new FirebaseLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FirebaseLink response = analyticsAdminServiceClient.UpdateFirebaseLink(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFirebaseLinkAsync</summary>
        public async Task UpdateFirebaseLinkRequestObjectAsync()
        {
            // Snippet: UpdateFirebaseLinkAsync(UpdateFirebaseLinkRequest, CallSettings)
            // Additional: UpdateFirebaseLinkAsync(UpdateFirebaseLinkRequest, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFirebaseLinkRequest request = new UpdateFirebaseLinkRequest
            {
                FirebaseLink = new FirebaseLink(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FirebaseLink response = await analyticsAdminServiceClient.UpdateFirebaseLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateFirebaseLink</summary>
        public void UpdateFirebaseLink()
        {
            // Snippet: UpdateFirebaseLink(FirebaseLink, FieldMask, CallSettings)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = AnalyticsAdminServiceClient.Create();
            // Initialize request argument(s)
            FirebaseLink firebaseLink = new FirebaseLink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FirebaseLink response = analyticsAdminServiceClient.UpdateFirebaseLink(firebaseLink, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateFirebaseLinkAsync</summary>
        public async Task UpdateFirebaseLinkAsync()
        {
            // Snippet: UpdateFirebaseLinkAsync(FirebaseLink, FieldMask, CallSettings)
            // Additional: UpdateFirebaseLinkAsync(FirebaseLink, FieldMask, CancellationToken)
            // Create client
            AnalyticsAdminServiceClient analyticsAdminServiceClient = await AnalyticsAdminServiceClient.CreateAsync();
            // Initialize request argument(s)
            FirebaseLink firebaseLink = new FirebaseLink();
            FieldMask updateMask = new FieldMask();
            // Make the request
            FirebaseLink response = await analyticsAdminServiceClient.UpdateFirebaseLinkAsync(firebaseLink, updateMask);
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
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
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
                GlobalSiteTagName = GlobalSiteTagName.FromProperty("[PROPERTY]"),
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
            string name = "properties/[PROPERTY]/globalSiteTag";
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
            string name = "properties/[PROPERTY]/globalSiteTag";
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
            GlobalSiteTagName name = GlobalSiteTagName.FromProperty("[PROPERTY]");
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
            GlobalSiteTagName name = GlobalSiteTagName.FromProperty("[PROPERTY]");
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
    }
}
