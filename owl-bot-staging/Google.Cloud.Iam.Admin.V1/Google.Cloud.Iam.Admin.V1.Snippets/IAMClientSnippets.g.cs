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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.Admin.V1;
    using Google.Cloud.Iam.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Google.Type;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIAMClientSnippets
    {
        /// <summary>Snippet for ListServiceAccounts</summary>
        public void ListServiceAccountsRequestObject()
        {
            // Snippet: ListServiceAccounts(ListServiceAccountsRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ListServiceAccountsRequest request = new ListServiceAccountsRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> response = iAMClient.ListServiceAccounts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccountsAsync</summary>
        public async Task ListServiceAccountsRequestObjectAsync()
        {
            // Snippet: ListServiceAccountsAsync(ListServiceAccountsRequest, CallSettings)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceAccountsRequest request = new ListServiceAccountsRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> response = iAMClient.ListServiceAccountsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccounts</summary>
        public void ListServiceAccounts()
        {
            // Snippet: ListServiceAccounts(string, string, int?, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> response = iAMClient.ListServiceAccounts(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccountsAsync</summary>
        public async Task ListServiceAccountsAsync()
        {
            // Snippet: ListServiceAccountsAsync(string, string, int?, CallSettings)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> response = iAMClient.ListServiceAccountsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccounts</summary>
        public void ListServiceAccountsResourceNames()
        {
            // Snippet: ListServiceAccounts(ProjectName, string, int?, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListServiceAccountsResponse, ServiceAccount> response = iAMClient.ListServiceAccounts(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceAccount item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAccount> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccountsAsync</summary>
        public async Task ListServiceAccountsResourceNamesAsync()
        {
            // Snippet: ListServiceAccountsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListServiceAccountsResponse, ServiceAccount> response = iAMClient.ListServiceAccountsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceAccount item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceAccount item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceAccount> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceAccount item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccount</summary>
        public void GetServiceAccountRequestObject()
        {
            // Snippet: GetServiceAccount(GetServiceAccountRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            // Make the request
            ServiceAccount response = iAMClient.GetServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountAsync</summary>
        public async Task GetServiceAccountRequestObjectAsync()
        {
            // Snippet: GetServiceAccountAsync(GetServiceAccountRequest, CallSettings)
            // Additional: GetServiceAccountAsync(GetServiceAccountRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceAccountRequest request = new GetServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            // Make the request
            ServiceAccount response = await iAMClient.GetServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccount</summary>
        public void GetServiceAccount()
        {
            // Snippet: GetServiceAccount(string, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            // Make the request
            ServiceAccount response = iAMClient.GetServiceAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountAsync</summary>
        public async Task GetServiceAccountAsync()
        {
            // Snippet: GetServiceAccountAsync(string, CallSettings)
            // Additional: GetServiceAccountAsync(string, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            // Make the request
            ServiceAccount response = await iAMClient.GetServiceAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccount</summary>
        public void GetServiceAccountResourceNames()
        {
            // Snippet: GetServiceAccount(ServiceAccountName, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            // Make the request
            ServiceAccount response = iAMClient.GetServiceAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountAsync</summary>
        public async Task GetServiceAccountResourceNamesAsync()
        {
            // Snippet: GetServiceAccountAsync(ServiceAccountName, CallSettings)
            // Additional: GetServiceAccountAsync(ServiceAccountName, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            // Make the request
            ServiceAccount response = await iAMClient.GetServiceAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccount</summary>
        public void CreateServiceAccountRequestObject()
        {
            // Snippet: CreateServiceAccount(CreateServiceAccountRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            CreateServiceAccountRequest request = new CreateServiceAccountRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                AccountId = "",
                ServiceAccount = new ServiceAccount(),
            };
            // Make the request
            ServiceAccount response = iAMClient.CreateServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccountAsync</summary>
        public async Task CreateServiceAccountRequestObjectAsync()
        {
            // Snippet: CreateServiceAccountAsync(CreateServiceAccountRequest, CallSettings)
            // Additional: CreateServiceAccountAsync(CreateServiceAccountRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceAccountRequest request = new CreateServiceAccountRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                AccountId = "",
                ServiceAccount = new ServiceAccount(),
            };
            // Make the request
            ServiceAccount response = await iAMClient.CreateServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccount</summary>
        public void CreateServiceAccount()
        {
            // Snippet: CreateServiceAccount(string, string, ServiceAccount, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            string accountId = "";
            ServiceAccount serviceAccount = new ServiceAccount();
            // Make the request
            ServiceAccount response = iAMClient.CreateServiceAccount(name, accountId, serviceAccount);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccountAsync</summary>
        public async Task CreateServiceAccountAsync()
        {
            // Snippet: CreateServiceAccountAsync(string, string, ServiceAccount, CallSettings)
            // Additional: CreateServiceAccountAsync(string, string, ServiceAccount, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            string accountId = "";
            ServiceAccount serviceAccount = new ServiceAccount();
            // Make the request
            ServiceAccount response = await iAMClient.CreateServiceAccountAsync(name, accountId, serviceAccount);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccount</summary>
        public void CreateServiceAccountResourceNames()
        {
            // Snippet: CreateServiceAccount(ProjectName, string, ServiceAccount, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            string accountId = "";
            ServiceAccount serviceAccount = new ServiceAccount();
            // Make the request
            ServiceAccount response = iAMClient.CreateServiceAccount(name, accountId, serviceAccount);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccountAsync</summary>
        public async Task CreateServiceAccountResourceNamesAsync()
        {
            // Snippet: CreateServiceAccountAsync(ProjectName, string, ServiceAccount, CallSettings)
            // Additional: CreateServiceAccountAsync(ProjectName, string, ServiceAccount, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            string accountId = "";
            ServiceAccount serviceAccount = new ServiceAccount();
            // Make the request
            ServiceAccount response = await iAMClient.CreateServiceAccountAsync(name, accountId, serviceAccount);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAccount</summary>
        public void UpdateServiceAccountRequestObject()
        {
            // Snippet: UpdateServiceAccount(ServiceAccount, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ServiceAccount request = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "",
                UniqueId = "",
                Email = "",
                DisplayName = "",
                Description = "",
                Oauth2ClientId = "",
                Disabled = false,
            };
            // Make the request
            ServiceAccount response = iAMClient.UpdateServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAccountAsync</summary>
        public async Task UpdateServiceAccountRequestObjectAsync()
        {
            // Snippet: UpdateServiceAccountAsync(ServiceAccount, CallSettings)
            // Additional: UpdateServiceAccountAsync(ServiceAccount, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccount request = new ServiceAccount
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                ProjectId = "",
                UniqueId = "",
                Email = "",
                DisplayName = "",
                Description = "",
                Oauth2ClientId = "",
                Disabled = false,
            };
            // Make the request
            ServiceAccount response = await iAMClient.UpdateServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PatchServiceAccount</summary>
        public void PatchServiceAccountRequestObject()
        {
            // Snippet: PatchServiceAccount(PatchServiceAccountRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            PatchServiceAccountRequest request = new PatchServiceAccountRequest
            {
                ServiceAccount = new ServiceAccount(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ServiceAccount response = iAMClient.PatchServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for PatchServiceAccountAsync</summary>
        public async Task PatchServiceAccountRequestObjectAsync()
        {
            // Snippet: PatchServiceAccountAsync(PatchServiceAccountRequest, CallSettings)
            // Additional: PatchServiceAccountAsync(PatchServiceAccountRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            PatchServiceAccountRequest request = new PatchServiceAccountRequest
            {
                ServiceAccount = new ServiceAccount(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ServiceAccount response = await iAMClient.PatchServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccount</summary>
        public void DeleteServiceAccountRequestObject()
        {
            // Snippet: DeleteServiceAccount(DeleteServiceAccountRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            DeleteServiceAccountRequest request = new DeleteServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            // Make the request
            iAMClient.DeleteServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccountAsync</summary>
        public async Task DeleteServiceAccountRequestObjectAsync()
        {
            // Snippet: DeleteServiceAccountAsync(DeleteServiceAccountRequest, CallSettings)
            // Additional: DeleteServiceAccountAsync(DeleteServiceAccountRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceAccountRequest request = new DeleteServiceAccountRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            // Make the request
            await iAMClient.DeleteServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccount</summary>
        public void DeleteServiceAccount()
        {
            // Snippet: DeleteServiceAccount(string, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            // Make the request
            iAMClient.DeleteServiceAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccountAsync</summary>
        public async Task DeleteServiceAccountAsync()
        {
            // Snippet: DeleteServiceAccountAsync(string, CallSettings)
            // Additional: DeleteServiceAccountAsync(string, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            // Make the request
            await iAMClient.DeleteServiceAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccount</summary>
        public void DeleteServiceAccountResourceNames()
        {
            // Snippet: DeleteServiceAccount(ServiceAccountName, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            // Make the request
            iAMClient.DeleteServiceAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccountAsync</summary>
        public async Task DeleteServiceAccountResourceNamesAsync()
        {
            // Snippet: DeleteServiceAccountAsync(ServiceAccountName, CallSettings)
            // Additional: DeleteServiceAccountAsync(ServiceAccountName, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            // Make the request
            await iAMClient.DeleteServiceAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UndeleteServiceAccount</summary>
        public void UndeleteServiceAccountRequestObject()
        {
            // Snippet: UndeleteServiceAccount(UndeleteServiceAccountRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            UndeleteServiceAccountRequest request = new UndeleteServiceAccountRequest { Name = "", };
            // Make the request
            UndeleteServiceAccountResponse response = iAMClient.UndeleteServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for UndeleteServiceAccountAsync</summary>
        public async Task UndeleteServiceAccountRequestObjectAsync()
        {
            // Snippet: UndeleteServiceAccountAsync(UndeleteServiceAccountRequest, CallSettings)
            // Additional: UndeleteServiceAccountAsync(UndeleteServiceAccountRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteServiceAccountRequest request = new UndeleteServiceAccountRequest { Name = "", };
            // Make the request
            UndeleteServiceAccountResponse response = await iAMClient.UndeleteServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAccount</summary>
        public void EnableServiceAccountRequestObject()
        {
            // Snippet: EnableServiceAccount(EnableServiceAccountRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            EnableServiceAccountRequest request = new EnableServiceAccountRequest { Name = "", };
            // Make the request
            iAMClient.EnableServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAccountAsync</summary>
        public async Task EnableServiceAccountRequestObjectAsync()
        {
            // Snippet: EnableServiceAccountAsync(EnableServiceAccountRequest, CallSettings)
            // Additional: EnableServiceAccountAsync(EnableServiceAccountRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            EnableServiceAccountRequest request = new EnableServiceAccountRequest { Name = "", };
            // Make the request
            await iAMClient.EnableServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAccount</summary>
        public void DisableServiceAccountRequestObject()
        {
            // Snippet: DisableServiceAccount(DisableServiceAccountRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            DisableServiceAccountRequest request = new DisableServiceAccountRequest { Name = "", };
            // Make the request
            iAMClient.DisableServiceAccount(request);
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAccountAsync</summary>
        public async Task DisableServiceAccountRequestObjectAsync()
        {
            // Snippet: DisableServiceAccountAsync(DisableServiceAccountRequest, CallSettings)
            // Additional: DisableServiceAccountAsync(DisableServiceAccountRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            DisableServiceAccountRequest request = new DisableServiceAccountRequest { Name = "", };
            // Make the request
            await iAMClient.DisableServiceAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccountKeys</summary>
        public void ListServiceAccountKeysRequestObject()
        {
            // Snippet: ListServiceAccountKeys(ListServiceAccountKeysRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ListServiceAccountKeysRequest request = new ListServiceAccountKeysRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                KeyTypes =
                {
                    ListServiceAccountKeysRequest.Types.KeyType.Unspecified,
                },
            };
            // Make the request
            ListServiceAccountKeysResponse response = iAMClient.ListServiceAccountKeys(request);
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccountKeysAsync</summary>
        public async Task ListServiceAccountKeysRequestObjectAsync()
        {
            // Snippet: ListServiceAccountKeysAsync(ListServiceAccountKeysRequest, CallSettings)
            // Additional: ListServiceAccountKeysAsync(ListServiceAccountKeysRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceAccountKeysRequest request = new ListServiceAccountKeysRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                KeyTypes =
                {
                    ListServiceAccountKeysRequest.Types.KeyType.Unspecified,
                },
            };
            // Make the request
            ListServiceAccountKeysResponse response = await iAMClient.ListServiceAccountKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccountKeys</summary>
        public void ListServiceAccountKeys()
        {
            // Snippet: ListServiceAccountKeys(string, IEnumerable<ListServiceAccountKeysRequest.Types.KeyType>, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes = new ListServiceAccountKeysRequest.Types.KeyType[]
            {
                ListServiceAccountKeysRequest.Types.KeyType.Unspecified,
            };
            // Make the request
            ListServiceAccountKeysResponse response = iAMClient.ListServiceAccountKeys(name, keyTypes);
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccountKeysAsync</summary>
        public async Task ListServiceAccountKeysAsync()
        {
            // Snippet: ListServiceAccountKeysAsync(string, IEnumerable<ListServiceAccountKeysRequest.Types.KeyType>, CallSettings)
            // Additional: ListServiceAccountKeysAsync(string, IEnumerable<ListServiceAccountKeysRequest.Types.KeyType>, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes = new ListServiceAccountKeysRequest.Types.KeyType[]
            {
                ListServiceAccountKeysRequest.Types.KeyType.Unspecified,
            };
            // Make the request
            ListServiceAccountKeysResponse response = await iAMClient.ListServiceAccountKeysAsync(name, keyTypes);
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccountKeys</summary>
        public void ListServiceAccountKeysResourceNames()
        {
            // Snippet: ListServiceAccountKeys(ServiceAccountName, IEnumerable<ListServiceAccountKeysRequest.Types.KeyType>, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes = new ListServiceAccountKeysRequest.Types.KeyType[]
            {
                ListServiceAccountKeysRequest.Types.KeyType.Unspecified,
            };
            // Make the request
            ListServiceAccountKeysResponse response = iAMClient.ListServiceAccountKeys(name, keyTypes);
            // End snippet
        }

        /// <summary>Snippet for ListServiceAccountKeysAsync</summary>
        public async Task ListServiceAccountKeysResourceNamesAsync()
        {
            // Snippet: ListServiceAccountKeysAsync(ServiceAccountName, IEnumerable<ListServiceAccountKeysRequest.Types.KeyType>, CallSettings)
            // Additional: ListServiceAccountKeysAsync(ServiceAccountName, IEnumerable<ListServiceAccountKeysRequest.Types.KeyType>, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            IEnumerable<ListServiceAccountKeysRequest.Types.KeyType> keyTypes = new ListServiceAccountKeysRequest.Types.KeyType[]
            {
                ListServiceAccountKeysRequest.Types.KeyType.Unspecified,
            };
            // Make the request
            ListServiceAccountKeysResponse response = await iAMClient.ListServiceAccountKeysAsync(name, keyTypes);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountKey</summary>
        public void GetServiceAccountKeyRequestObject()
        {
            // Snippet: GetServiceAccountKey(GetServiceAccountKeyRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            GetServiceAccountKeyRequest request = new GetServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PublicKeyType = ServiceAccountPublicKeyType.TypeNone,
            };
            // Make the request
            ServiceAccountKey response = iAMClient.GetServiceAccountKey(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountKeyAsync</summary>
        public async Task GetServiceAccountKeyRequestObjectAsync()
        {
            // Snippet: GetServiceAccountKeyAsync(GetServiceAccountKeyRequest, CallSettings)
            // Additional: GetServiceAccountKeyAsync(GetServiceAccountKeyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceAccountKeyRequest request = new GetServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
                PublicKeyType = ServiceAccountPublicKeyType.TypeNone,
            };
            // Make the request
            ServiceAccountKey response = await iAMClient.GetServiceAccountKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountKey</summary>
        public void GetServiceAccountKey()
        {
            // Snippet: GetServiceAccountKey(string, ServiceAccountPublicKeyType, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]/keys/[KEY]";
            ServiceAccountPublicKeyType publicKeyType = ServiceAccountPublicKeyType.TypeNone;
            // Make the request
            ServiceAccountKey response = iAMClient.GetServiceAccountKey(name, publicKeyType);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountKeyAsync</summary>
        public async Task GetServiceAccountKeyAsync()
        {
            // Snippet: GetServiceAccountKeyAsync(string, ServiceAccountPublicKeyType, CallSettings)
            // Additional: GetServiceAccountKeyAsync(string, ServiceAccountPublicKeyType, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]/keys/[KEY]";
            ServiceAccountPublicKeyType publicKeyType = ServiceAccountPublicKeyType.TypeNone;
            // Make the request
            ServiceAccountKey response = await iAMClient.GetServiceAccountKeyAsync(name, publicKeyType);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountKey</summary>
        public void GetServiceAccountKeyResourceNames()
        {
            // Snippet: GetServiceAccountKey(KeyName, ServiceAccountPublicKeyType, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]");
            ServiceAccountPublicKeyType publicKeyType = ServiceAccountPublicKeyType.TypeNone;
            // Make the request
            ServiceAccountKey response = iAMClient.GetServiceAccountKey(name, publicKeyType);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAccountKeyAsync</summary>
        public async Task GetServiceAccountKeyResourceNamesAsync()
        {
            // Snippet: GetServiceAccountKeyAsync(KeyName, ServiceAccountPublicKeyType, CallSettings)
            // Additional: GetServiceAccountKeyAsync(KeyName, ServiceAccountPublicKeyType, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]");
            ServiceAccountPublicKeyType publicKeyType = ServiceAccountPublicKeyType.TypeNone;
            // Make the request
            ServiceAccountKey response = await iAMClient.GetServiceAccountKeyAsync(name, publicKeyType);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccountKey</summary>
        public void CreateServiceAccountKeyRequestObject()
        {
            // Snippet: CreateServiceAccountKey(CreateServiceAccountKeyRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            CreateServiceAccountKeyRequest request = new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypeUnspecified,
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
            };
            // Make the request
            ServiceAccountKey response = iAMClient.CreateServiceAccountKey(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccountKeyAsync</summary>
        public async Task CreateServiceAccountKeyRequestObjectAsync()
        {
            // Snippet: CreateServiceAccountKeyAsync(CreateServiceAccountKeyRequest, CallSettings)
            // Additional: CreateServiceAccountKeyAsync(CreateServiceAccountKeyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceAccountKeyRequest request = new CreateServiceAccountKeyRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                PrivateKeyType = ServiceAccountPrivateKeyType.TypeUnspecified,
                KeyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified,
            };
            // Make the request
            ServiceAccountKey response = await iAMClient.CreateServiceAccountKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccountKey</summary>
        public void CreateServiceAccountKey()
        {
            // Snippet: CreateServiceAccountKey(string, ServiceAccountPrivateKeyType, ServiceAccountKeyAlgorithm, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            ServiceAccountPrivateKeyType privateKeyType = ServiceAccountPrivateKeyType.TypeUnspecified;
            ServiceAccountKeyAlgorithm keyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified;
            // Make the request
            ServiceAccountKey response = iAMClient.CreateServiceAccountKey(name, privateKeyType, keyAlgorithm);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccountKeyAsync</summary>
        public async Task CreateServiceAccountKeyAsync()
        {
            // Snippet: CreateServiceAccountKeyAsync(string, ServiceAccountPrivateKeyType, ServiceAccountKeyAlgorithm, CallSettings)
            // Additional: CreateServiceAccountKeyAsync(string, ServiceAccountPrivateKeyType, ServiceAccountKeyAlgorithm, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            ServiceAccountPrivateKeyType privateKeyType = ServiceAccountPrivateKeyType.TypeUnspecified;
            ServiceAccountKeyAlgorithm keyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified;
            // Make the request
            ServiceAccountKey response = await iAMClient.CreateServiceAccountKeyAsync(name, privateKeyType, keyAlgorithm);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccountKey</summary>
        public void CreateServiceAccountKeyResourceNames()
        {
            // Snippet: CreateServiceAccountKey(ServiceAccountName, ServiceAccountPrivateKeyType, ServiceAccountKeyAlgorithm, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            ServiceAccountPrivateKeyType privateKeyType = ServiceAccountPrivateKeyType.TypeUnspecified;
            ServiceAccountKeyAlgorithm keyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified;
            // Make the request
            ServiceAccountKey response = iAMClient.CreateServiceAccountKey(name, privateKeyType, keyAlgorithm);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAccountKeyAsync</summary>
        public async Task CreateServiceAccountKeyResourceNamesAsync()
        {
            // Snippet: CreateServiceAccountKeyAsync(ServiceAccountName, ServiceAccountPrivateKeyType, ServiceAccountKeyAlgorithm, CallSettings)
            // Additional: CreateServiceAccountKeyAsync(ServiceAccountName, ServiceAccountPrivateKeyType, ServiceAccountKeyAlgorithm, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            ServiceAccountPrivateKeyType privateKeyType = ServiceAccountPrivateKeyType.TypeUnspecified;
            ServiceAccountKeyAlgorithm keyAlgorithm = ServiceAccountKeyAlgorithm.KeyAlgUnspecified;
            // Make the request
            ServiceAccountKey response = await iAMClient.CreateServiceAccountKeyAsync(name, privateKeyType, keyAlgorithm);
            // End snippet
        }

        /// <summary>Snippet for UploadServiceAccountKey</summary>
        public void UploadServiceAccountKeyRequestObject()
        {
            // Snippet: UploadServiceAccountKey(UploadServiceAccountKeyRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            UploadServiceAccountKeyRequest request = new UploadServiceAccountKeyRequest
            {
                Name = "",
                PublicKeyData = ByteString.Empty,
            };
            // Make the request
            ServiceAccountKey response = iAMClient.UploadServiceAccountKey(request);
            // End snippet
        }

        /// <summary>Snippet for UploadServiceAccountKeyAsync</summary>
        public async Task UploadServiceAccountKeyRequestObjectAsync()
        {
            // Snippet: UploadServiceAccountKeyAsync(UploadServiceAccountKeyRequest, CallSettings)
            // Additional: UploadServiceAccountKeyAsync(UploadServiceAccountKeyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            UploadServiceAccountKeyRequest request = new UploadServiceAccountKeyRequest
            {
                Name = "",
                PublicKeyData = ByteString.Empty,
            };
            // Make the request
            ServiceAccountKey response = await iAMClient.UploadServiceAccountKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccountKey</summary>
        public void DeleteServiceAccountKeyRequestObject()
        {
            // Snippet: DeleteServiceAccountKey(DeleteServiceAccountKeyRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            DeleteServiceAccountKeyRequest request = new DeleteServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            // Make the request
            iAMClient.DeleteServiceAccountKey(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccountKeyAsync</summary>
        public async Task DeleteServiceAccountKeyRequestObjectAsync()
        {
            // Snippet: DeleteServiceAccountKeyAsync(DeleteServiceAccountKeyRequest, CallSettings)
            // Additional: DeleteServiceAccountKeyAsync(DeleteServiceAccountKeyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceAccountKeyRequest request = new DeleteServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            // Make the request
            await iAMClient.DeleteServiceAccountKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccountKey</summary>
        public void DeleteServiceAccountKey()
        {
            // Snippet: DeleteServiceAccountKey(string, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]/keys/[KEY]";
            // Make the request
            iAMClient.DeleteServiceAccountKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccountKeyAsync</summary>
        public async Task DeleteServiceAccountKeyAsync()
        {
            // Snippet: DeleteServiceAccountKeyAsync(string, CallSettings)
            // Additional: DeleteServiceAccountKeyAsync(string, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]/keys/[KEY]";
            // Make the request
            await iAMClient.DeleteServiceAccountKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccountKey</summary>
        public void DeleteServiceAccountKeyResourceNames()
        {
            // Snippet: DeleteServiceAccountKey(KeyName, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]");
            // Make the request
            iAMClient.DeleteServiceAccountKey(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAccountKeyAsync</summary>
        public async Task DeleteServiceAccountKeyResourceNamesAsync()
        {
            // Snippet: DeleteServiceAccountKeyAsync(KeyName, CallSettings)
            // Additional: DeleteServiceAccountKeyAsync(KeyName, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]");
            // Make the request
            await iAMClient.DeleteServiceAccountKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAccountKey</summary>
        public void DisableServiceAccountKeyRequestObject()
        {
            // Snippet: DisableServiceAccountKey(DisableServiceAccountKeyRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            DisableServiceAccountKeyRequest request = new DisableServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            // Make the request
            iAMClient.DisableServiceAccountKey(request);
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAccountKeyAsync</summary>
        public async Task DisableServiceAccountKeyRequestObjectAsync()
        {
            // Snippet: DisableServiceAccountKeyAsync(DisableServiceAccountKeyRequest, CallSettings)
            // Additional: DisableServiceAccountKeyAsync(DisableServiceAccountKeyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            DisableServiceAccountKeyRequest request = new DisableServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            // Make the request
            await iAMClient.DisableServiceAccountKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAccountKey</summary>
        public void DisableServiceAccountKey()
        {
            // Snippet: DisableServiceAccountKey(string, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]/keys/[KEY]";
            // Make the request
            iAMClient.DisableServiceAccountKey(name);
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAccountKeyAsync</summary>
        public async Task DisableServiceAccountKeyAsync()
        {
            // Snippet: DisableServiceAccountKeyAsync(string, CallSettings)
            // Additional: DisableServiceAccountKeyAsync(string, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]/keys/[KEY]";
            // Make the request
            await iAMClient.DisableServiceAccountKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAccountKey</summary>
        public void DisableServiceAccountKeyResourceNames()
        {
            // Snippet: DisableServiceAccountKey(KeyName, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]");
            // Make the request
            iAMClient.DisableServiceAccountKey(name);
            // End snippet
        }

        /// <summary>Snippet for DisableServiceAccountKeyAsync</summary>
        public async Task DisableServiceAccountKeyResourceNamesAsync()
        {
            // Snippet: DisableServiceAccountKeyAsync(KeyName, CallSettings)
            // Additional: DisableServiceAccountKeyAsync(KeyName, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]");
            // Make the request
            await iAMClient.DisableServiceAccountKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAccountKey</summary>
        public void EnableServiceAccountKeyRequestObject()
        {
            // Snippet: EnableServiceAccountKey(EnableServiceAccountKeyRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            EnableServiceAccountKeyRequest request = new EnableServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            // Make the request
            iAMClient.EnableServiceAccountKey(request);
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAccountKeyAsync</summary>
        public async Task EnableServiceAccountKeyRequestObjectAsync()
        {
            // Snippet: EnableServiceAccountKeyAsync(EnableServiceAccountKeyRequest, CallSettings)
            // Additional: EnableServiceAccountKeyAsync(EnableServiceAccountKeyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            EnableServiceAccountKeyRequest request = new EnableServiceAccountKeyRequest
            {
                KeyName = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]"),
            };
            // Make the request
            await iAMClient.EnableServiceAccountKeyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAccountKey</summary>
        public void EnableServiceAccountKey()
        {
            // Snippet: EnableServiceAccountKey(string, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]/keys/[KEY]";
            // Make the request
            iAMClient.EnableServiceAccountKey(name);
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAccountKeyAsync</summary>
        public async Task EnableServiceAccountKeyAsync()
        {
            // Snippet: EnableServiceAccountKeyAsync(string, CallSettings)
            // Additional: EnableServiceAccountKeyAsync(string, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]/keys/[KEY]";
            // Make the request
            await iAMClient.EnableServiceAccountKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAccountKey</summary>
        public void EnableServiceAccountKeyResourceNames()
        {
            // Snippet: EnableServiceAccountKey(KeyName, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]");
            // Make the request
            iAMClient.EnableServiceAccountKey(name);
            // End snippet
        }

        /// <summary>Snippet for EnableServiceAccountKeyAsync</summary>
        public async Task EnableServiceAccountKeyResourceNamesAsync()
        {
            // Snippet: EnableServiceAccountKeyAsync(KeyName, CallSettings)
            // Additional: EnableServiceAccountKeyAsync(KeyName, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            KeyName name = KeyName.FromProjectServiceAccountKey("[PROJECT]", "[SERVICE_ACCOUNT]", "[KEY]");
            // Make the request
            await iAMClient.EnableServiceAccountKeyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SignBlob</summary>
        public void SignBlobRequestObject()
        {
            // Snippet: SignBlob(SignBlobRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            SignBlobRequest request = new SignBlobRequest { };
            // Make the request
#pragma warning disable CS0612
            SignBlobResponse response = iAMClient.SignBlob(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignBlobAsync</summary>
        public async Task SignBlobRequestObjectAsync()
        {
            // Snippet: SignBlobAsync(SignBlobRequest, CallSettings)
            // Additional: SignBlobAsync(SignBlobRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            SignBlobRequest request = new SignBlobRequest { };
            // Make the request
#pragma warning disable CS0612
            SignBlobResponse response = await iAMClient.SignBlobAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignBlob</summary>
        public void SignBlob()
        {
            // Snippet: SignBlob(string, ByteString, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            ByteString bytesToSign = ByteString.Empty;
            // Make the request
#pragma warning disable CS0612
            SignBlobResponse response = iAMClient.SignBlob(name, bytesToSign);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignBlobAsync</summary>
        public async Task SignBlobAsync()
        {
            // Snippet: SignBlobAsync(string, ByteString, CallSettings)
            // Additional: SignBlobAsync(string, ByteString, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            ByteString bytesToSign = ByteString.Empty;
            // Make the request
#pragma warning disable CS0612
            SignBlobResponse response = await iAMClient.SignBlobAsync(name, bytesToSign);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignBlob</summary>
        public void SignBlobResourceNames()
        {
            // Snippet: SignBlob(ServiceAccountName, ByteString, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            ByteString bytesToSign = ByteString.Empty;
            // Make the request
#pragma warning disable CS0612
            SignBlobResponse response = iAMClient.SignBlob(name, bytesToSign);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignBlobAsync</summary>
        public async Task SignBlobResourceNamesAsync()
        {
            // Snippet: SignBlobAsync(ServiceAccountName, ByteString, CallSettings)
            // Additional: SignBlobAsync(ServiceAccountName, ByteString, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            ByteString bytesToSign = ByteString.Empty;
            // Make the request
#pragma warning disable CS0612
            SignBlobResponse response = await iAMClient.SignBlobAsync(name, bytesToSign);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignJwt</summary>
        public void SignJwtRequestObject()
        {
            // Snippet: SignJwt(SignJwtRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            SignJwtRequest request = new SignJwtRequest { };
            // Make the request
#pragma warning disable CS0612
            SignJwtResponse response = iAMClient.SignJwt(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignJwtAsync</summary>
        public async Task SignJwtRequestObjectAsync()
        {
            // Snippet: SignJwtAsync(SignJwtRequest, CallSettings)
            // Additional: SignJwtAsync(SignJwtRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            SignJwtRequest request = new SignJwtRequest { };
            // Make the request
#pragma warning disable CS0612
            SignJwtResponse response = await iAMClient.SignJwtAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignJwt</summary>
        public void SignJwt()
        {
            // Snippet: SignJwt(string, string, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            string payload = "";
            // Make the request
#pragma warning disable CS0612
            SignJwtResponse response = iAMClient.SignJwt(name, payload);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignJwtAsync</summary>
        public async Task SignJwtAsync()
        {
            // Snippet: SignJwtAsync(string, string, CallSettings)
            // Additional: SignJwtAsync(string, string, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/serviceAccounts/[SERVICE_ACCOUNT]";
            string payload = "";
            // Make the request
#pragma warning disable CS0612
            SignJwtResponse response = await iAMClient.SignJwtAsync(name, payload);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignJwt</summary>
        public void SignJwtResourceNames()
        {
            // Snippet: SignJwt(ServiceAccountName, string, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            string payload = "";
            // Make the request
#pragma warning disable CS0612
            SignJwtResponse response = iAMClient.SignJwt(name, payload);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for SignJwtAsync</summary>
        public async Task SignJwtResourceNamesAsync()
        {
            // Snippet: SignJwtAsync(ServiceAccountName, string, CallSettings)
            // Additional: SignJwtAsync(ServiceAccountName, string, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ServiceAccountName name = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]");
            string payload = "";
            // Make the request
#pragma warning disable CS0612
            SignJwtResponse response = await iAMClient.SignJwtAsync(name, payload);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = iAMClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await iAMClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = iAMClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await iAMClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = iAMClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await iAMClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = iAMClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await iAMClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = iAMClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await iAMClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = iAMClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await iAMClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = iAMClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await iAMClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = iAMClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await iAMClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = iAMClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await iAMClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for QueryGrantableRoles</summary>
        public void QueryGrantableRolesRequestObject()
        {
            // Snippet: QueryGrantableRoles(QueryGrantableRolesRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            QueryGrantableRolesRequest request = new QueryGrantableRolesRequest
            {
                FullResourceName = "",
                View = RoleView.Basic,
            };
            // Make the request
            PagedEnumerable<QueryGrantableRolesResponse, Role> response = iAMClient.QueryGrantableRoles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Role item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryGrantableRolesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryGrantableRolesAsync</summary>
        public async Task QueryGrantableRolesRequestObjectAsync()
        {
            // Snippet: QueryGrantableRolesAsync(QueryGrantableRolesRequest, CallSettings)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            QueryGrantableRolesRequest request = new QueryGrantableRolesRequest
            {
                FullResourceName = "",
                View = RoleView.Basic,
            };
            // Make the request
            PagedAsyncEnumerable<QueryGrantableRolesResponse, Role> response = iAMClient.QueryGrantableRolesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Role item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryGrantableRolesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryGrantableRoles</summary>
        public void QueryGrantableRoles()
        {
            // Snippet: QueryGrantableRoles(string, string, int?, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            string fullResourceName = "";
            // Make the request
            PagedEnumerable<QueryGrantableRolesResponse, Role> response = iAMClient.QueryGrantableRoles(fullResourceName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Role item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryGrantableRolesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryGrantableRolesAsync</summary>
        public async Task QueryGrantableRolesAsync()
        {
            // Snippet: QueryGrantableRolesAsync(string, string, int?, CallSettings)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            string fullResourceName = "";
            // Make the request
            PagedAsyncEnumerable<QueryGrantableRolesResponse, Role> response = iAMClient.QueryGrantableRolesAsync(fullResourceName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Role item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryGrantableRolesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRoles</summary>
        public void ListRolesRequestObject()
        {
            // Snippet: ListRoles(ListRolesRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            ListRolesRequest request = new ListRolesRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                View = RoleView.Basic,
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListRolesResponse, Role> response = iAMClient.ListRoles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Role item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRolesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRolesAsync</summary>
        public async Task ListRolesRequestObjectAsync()
        {
            // Snippet: ListRolesAsync(ListRolesRequest, CallSettings)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            ListRolesRequest request = new ListRolesRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                View = RoleView.Basic,
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListRolesResponse, Role> response = iAMClient.ListRolesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Role item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRolesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Role item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Role> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Role item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRole</summary>
        public void GetRoleRequestObject()
        {
            // Snippet: GetRole(GetRoleRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            GetRoleRequest request = new GetRoleRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            Role response = iAMClient.GetRole(request);
            // End snippet
        }

        /// <summary>Snippet for GetRoleAsync</summary>
        public async Task GetRoleRequestObjectAsync()
        {
            // Snippet: GetRoleAsync(GetRoleRequest, CallSettings)
            // Additional: GetRoleAsync(GetRoleRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            GetRoleRequest request = new GetRoleRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
            };
            // Make the request
            Role response = await iAMClient.GetRoleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRole</summary>
        public void CreateRoleRequestObject()
        {
            // Snippet: CreateRole(CreateRoleRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            CreateRoleRequest request = new CreateRoleRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                RoleId = "",
                Role = new Role(),
            };
            // Make the request
            Role response = iAMClient.CreateRole(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRoleAsync</summary>
        public async Task CreateRoleRequestObjectAsync()
        {
            // Snippet: CreateRoleAsync(CreateRoleRequest, CallSettings)
            // Additional: CreateRoleAsync(CreateRoleRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            CreateRoleRequest request = new CreateRoleRequest
            {
                ParentAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                RoleId = "",
                Role = new Role(),
            };
            // Make the request
            Role response = await iAMClient.CreateRoleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRole</summary>
        public void UpdateRoleRequestObject()
        {
            // Snippet: UpdateRole(UpdateRoleRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            UpdateRoleRequest request = new UpdateRoleRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Role = new Role(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Role response = iAMClient.UpdateRole(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRoleAsync</summary>
        public async Task UpdateRoleRequestObjectAsync()
        {
            // Snippet: UpdateRoleAsync(UpdateRoleRequest, CallSettings)
            // Additional: UpdateRoleAsync(UpdateRoleRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRoleRequest request = new UpdateRoleRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Role = new Role(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Role response = await iAMClient.UpdateRoleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRole</summary>
        public void DeleteRoleRequestObject()
        {
            // Snippet: DeleteRole(DeleteRoleRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            DeleteRoleRequest request = new DeleteRoleRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Etag = ByteString.Empty,
            };
            // Make the request
            Role response = iAMClient.DeleteRole(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRoleAsync</summary>
        public async Task DeleteRoleRequestObjectAsync()
        {
            // Snippet: DeleteRoleAsync(DeleteRoleRequest, CallSettings)
            // Additional: DeleteRoleAsync(DeleteRoleRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRoleRequest request = new DeleteRoleRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Etag = ByteString.Empty,
            };
            // Make the request
            Role response = await iAMClient.DeleteRoleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UndeleteRole</summary>
        public void UndeleteRoleRequestObject()
        {
            // Snippet: UndeleteRole(UndeleteRoleRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            UndeleteRoleRequest request = new UndeleteRoleRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Etag = ByteString.Empty,
            };
            // Make the request
            Role response = iAMClient.UndeleteRole(request);
            // End snippet
        }

        /// <summary>Snippet for UndeleteRoleAsync</summary>
        public async Task UndeleteRoleRequestObjectAsync()
        {
            // Snippet: UndeleteRoleAsync(UndeleteRoleRequest, CallSettings)
            // Additional: UndeleteRoleAsync(UndeleteRoleRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteRoleRequest request = new UndeleteRoleRequest
            {
                ResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Etag = ByteString.Empty,
            };
            // Make the request
            Role response = await iAMClient.UndeleteRoleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for QueryTestablePermissions</summary>
        public void QueryTestablePermissionsRequestObject()
        {
            // Snippet: QueryTestablePermissions(QueryTestablePermissionsRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            QueryTestablePermissionsRequest request = new QueryTestablePermissionsRequest
            {
                FullResourceName = "",
            };
            // Make the request
            PagedEnumerable<QueryTestablePermissionsResponse, Permission> response = iAMClient.QueryTestablePermissions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Permission item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (QueryTestablePermissionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Permission item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Permission> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Permission item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryTestablePermissionsAsync</summary>
        public async Task QueryTestablePermissionsRequestObjectAsync()
        {
            // Snippet: QueryTestablePermissionsAsync(QueryTestablePermissionsRequest, CallSettings)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            QueryTestablePermissionsRequest request = new QueryTestablePermissionsRequest
            {
                FullResourceName = "",
            };
            // Make the request
            PagedAsyncEnumerable<QueryTestablePermissionsResponse, Permission> response = iAMClient.QueryTestablePermissionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Permission item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((QueryTestablePermissionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Permission item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Permission> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Permission item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for QueryAuditableServices</summary>
        public void QueryAuditableServicesRequestObject()
        {
            // Snippet: QueryAuditableServices(QueryAuditableServicesRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            QueryAuditableServicesRequest request = new QueryAuditableServicesRequest
            {
                FullResourceName = "",
            };
            // Make the request
            QueryAuditableServicesResponse response = iAMClient.QueryAuditableServices(request);
            // End snippet
        }

        /// <summary>Snippet for QueryAuditableServicesAsync</summary>
        public async Task QueryAuditableServicesRequestObjectAsync()
        {
            // Snippet: QueryAuditableServicesAsync(QueryAuditableServicesRequest, CallSettings)
            // Additional: QueryAuditableServicesAsync(QueryAuditableServicesRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            QueryAuditableServicesRequest request = new QueryAuditableServicesRequest
            {
                FullResourceName = "",
            };
            // Make the request
            QueryAuditableServicesResponse response = await iAMClient.QueryAuditableServicesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for LintPolicy</summary>
        public void LintPolicyRequestObject()
        {
            // Snippet: LintPolicy(LintPolicyRequest, CallSettings)
            // Create client
            IAMClient iAMClient = IAMClient.Create();
            // Initialize request argument(s)
            LintPolicyRequest request = new LintPolicyRequest
            {
                FullResourceName = "",
                Condition = new Expr(),
            };
            // Make the request
            LintPolicyResponse response = iAMClient.LintPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for LintPolicyAsync</summary>
        public async Task LintPolicyRequestObjectAsync()
        {
            // Snippet: LintPolicyAsync(LintPolicyRequest, CallSettings)
            // Additional: LintPolicyAsync(LintPolicyRequest, CancellationToken)
            // Create client
            IAMClient iAMClient = await IAMClient.CreateAsync();
            // Initialize request argument(s)
            LintPolicyRequest request = new LintPolicyRequest
            {
                FullResourceName = "",
                Condition = new Expr(),
            };
            // Make the request
            LintPolicyResponse response = await iAMClient.LintPolicyAsync(request);
            // End snippet
        }
    }
}
