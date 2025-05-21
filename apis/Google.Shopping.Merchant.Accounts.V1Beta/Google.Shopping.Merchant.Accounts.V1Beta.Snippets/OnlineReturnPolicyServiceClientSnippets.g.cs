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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOnlineReturnPolicyServiceClientSnippets
    {
        /// <summary>Snippet for GetOnlineReturnPolicy</summary>
        public void GetOnlineReturnPolicyRequestObject()
        {
            // Snippet: GetOnlineReturnPolicy(GetOnlineReturnPolicyRequest, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            GetOnlineReturnPolicyRequest request = new GetOnlineReturnPolicyRequest
            {
                OnlineReturnPolicyName = OnlineReturnPolicyName.FromAccountReturnPolicy("[ACCOUNT]", "[RETURN_POLICY]"),
            };
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.GetOnlineReturnPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineReturnPolicyAsync</summary>
        public async Task GetOnlineReturnPolicyRequestObjectAsync()
        {
            // Snippet: GetOnlineReturnPolicyAsync(GetOnlineReturnPolicyRequest, CallSettings)
            // Additional: GetOnlineReturnPolicyAsync(GetOnlineReturnPolicyRequest, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetOnlineReturnPolicyRequest request = new GetOnlineReturnPolicyRequest
            {
                OnlineReturnPolicyName = OnlineReturnPolicyName.FromAccountReturnPolicy("[ACCOUNT]", "[RETURN_POLICY]"),
            };
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.GetOnlineReturnPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineReturnPolicy</summary>
        public void GetOnlineReturnPolicy()
        {
            // Snippet: GetOnlineReturnPolicy(string, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/onlineReturnPolicies/[RETURN_POLICY]";
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.GetOnlineReturnPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineReturnPolicyAsync</summary>
        public async Task GetOnlineReturnPolicyAsync()
        {
            // Snippet: GetOnlineReturnPolicyAsync(string, CallSettings)
            // Additional: GetOnlineReturnPolicyAsync(string, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/onlineReturnPolicies/[RETURN_POLICY]";
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.GetOnlineReturnPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineReturnPolicy</summary>
        public void GetOnlineReturnPolicyResourceNames()
        {
            // Snippet: GetOnlineReturnPolicy(OnlineReturnPolicyName, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            OnlineReturnPolicyName name = OnlineReturnPolicyName.FromAccountReturnPolicy("[ACCOUNT]", "[RETURN_POLICY]");
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.GetOnlineReturnPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetOnlineReturnPolicyAsync</summary>
        public async Task GetOnlineReturnPolicyResourceNamesAsync()
        {
            // Snippet: GetOnlineReturnPolicyAsync(OnlineReturnPolicyName, CallSettings)
            // Additional: GetOnlineReturnPolicyAsync(OnlineReturnPolicyName, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            OnlineReturnPolicyName name = OnlineReturnPolicyName.FromAccountReturnPolicy("[ACCOUNT]", "[RETURN_POLICY]");
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.GetOnlineReturnPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListOnlineReturnPolicies</summary>
        public void ListOnlineReturnPoliciesRequestObject()
        {
            // Snippet: ListOnlineReturnPolicies(ListOnlineReturnPoliciesRequest, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            ListOnlineReturnPoliciesRequest request = new ListOnlineReturnPoliciesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> response = onlineReturnPolicyServiceClient.ListOnlineReturnPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OnlineReturnPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOnlineReturnPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineReturnPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineReturnPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineReturnPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineReturnPoliciesAsync</summary>
        public async Task ListOnlineReturnPoliciesRequestObjectAsync()
        {
            // Snippet: ListOnlineReturnPoliciesAsync(ListOnlineReturnPoliciesRequest, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListOnlineReturnPoliciesRequest request = new ListOnlineReturnPoliciesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> response = onlineReturnPolicyServiceClient.ListOnlineReturnPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OnlineReturnPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOnlineReturnPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineReturnPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineReturnPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineReturnPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineReturnPolicies</summary>
        public void ListOnlineReturnPolicies()
        {
            // Snippet: ListOnlineReturnPolicies(string, string, int?, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> response = onlineReturnPolicyServiceClient.ListOnlineReturnPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OnlineReturnPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOnlineReturnPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineReturnPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineReturnPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineReturnPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineReturnPoliciesAsync</summary>
        public async Task ListOnlineReturnPoliciesAsync()
        {
            // Snippet: ListOnlineReturnPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> response = onlineReturnPolicyServiceClient.ListOnlineReturnPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OnlineReturnPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOnlineReturnPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineReturnPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineReturnPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineReturnPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineReturnPolicies</summary>
        public void ListOnlineReturnPoliciesResourceNames()
        {
            // Snippet: ListOnlineReturnPolicies(AccountName, string, int?, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> response = onlineReturnPolicyServiceClient.ListOnlineReturnPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OnlineReturnPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOnlineReturnPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineReturnPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineReturnPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineReturnPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOnlineReturnPoliciesAsync</summary>
        public async Task ListOnlineReturnPoliciesResourceNamesAsync()
        {
            // Snippet: ListOnlineReturnPoliciesAsync(AccountName, string, int?, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListOnlineReturnPoliciesResponse, OnlineReturnPolicy> response = onlineReturnPolicyServiceClient.ListOnlineReturnPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OnlineReturnPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOnlineReturnPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OnlineReturnPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OnlineReturnPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OnlineReturnPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicy</summary>
        public void CreateOnlineReturnPolicyRequestObject()
        {
            // Snippet: CreateOnlineReturnPolicy(CreateOnlineReturnPolicyRequest, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            CreateOnlineReturnPolicyRequest request = new CreateOnlineReturnPolicyRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                OnlineReturnPolicy = new OnlineReturnPolicy(),
            };
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.CreateOnlineReturnPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicyAsync</summary>
        public async Task CreateOnlineReturnPolicyRequestObjectAsync()
        {
            // Snippet: CreateOnlineReturnPolicyAsync(CreateOnlineReturnPolicyRequest, CallSettings)
            // Additional: CreateOnlineReturnPolicyAsync(CreateOnlineReturnPolicyRequest, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateOnlineReturnPolicyRequest request = new CreateOnlineReturnPolicyRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                OnlineReturnPolicy = new OnlineReturnPolicy(),
            };
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.CreateOnlineReturnPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicy</summary>
        public void CreateOnlineReturnPolicy1()
        {
            // Snippet: CreateOnlineReturnPolicy(string, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.CreateOnlineReturnPolicy(parent);
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicyAsync</summary>
        public async Task CreateOnlineReturnPolicy1Async()
        {
            // Snippet: CreateOnlineReturnPolicyAsync(string, CallSettings)
            // Additional: CreateOnlineReturnPolicyAsync(string, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.CreateOnlineReturnPolicyAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicy</summary>
        public void CreateOnlineReturnPolicy1ResourceNames()
        {
            // Snippet: CreateOnlineReturnPolicy(AccountName, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.CreateOnlineReturnPolicy(parent);
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicyAsync</summary>
        public async Task CreateOnlineReturnPolicy1ResourceNamesAsync()
        {
            // Snippet: CreateOnlineReturnPolicyAsync(AccountName, CallSettings)
            // Additional: CreateOnlineReturnPolicyAsync(AccountName, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.CreateOnlineReturnPolicyAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicy</summary>
        public void CreateOnlineReturnPolicy2()
        {
            // Snippet: CreateOnlineReturnPolicy(string, OnlineReturnPolicy, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            OnlineReturnPolicy onlineReturnPolicy = new OnlineReturnPolicy();
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.CreateOnlineReturnPolicy(parent, onlineReturnPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicyAsync</summary>
        public async Task CreateOnlineReturnPolicy2Async()
        {
            // Snippet: CreateOnlineReturnPolicyAsync(string, OnlineReturnPolicy, CallSettings)
            // Additional: CreateOnlineReturnPolicyAsync(string, OnlineReturnPolicy, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            OnlineReturnPolicy onlineReturnPolicy = new OnlineReturnPolicy();
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.CreateOnlineReturnPolicyAsync(parent, onlineReturnPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicy</summary>
        public void CreateOnlineReturnPolicy2ResourceNames()
        {
            // Snippet: CreateOnlineReturnPolicy(AccountName, OnlineReturnPolicy, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            OnlineReturnPolicy onlineReturnPolicy = new OnlineReturnPolicy();
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.CreateOnlineReturnPolicy(parent, onlineReturnPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateOnlineReturnPolicyAsync</summary>
        public async Task CreateOnlineReturnPolicy2ResourceNamesAsync()
        {
            // Snippet: CreateOnlineReturnPolicyAsync(AccountName, OnlineReturnPolicy, CallSettings)
            // Additional: CreateOnlineReturnPolicyAsync(AccountName, OnlineReturnPolicy, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            OnlineReturnPolicy onlineReturnPolicy = new OnlineReturnPolicy();
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.CreateOnlineReturnPolicyAsync(parent, onlineReturnPolicy);
            // End snippet
        }

        /// <summary>Snippet for UpdateOnlineReturnPolicy</summary>
        public void UpdateOnlineReturnPolicyRequestObject()
        {
            // Snippet: UpdateOnlineReturnPolicy(UpdateOnlineReturnPolicyRequest, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            UpdateOnlineReturnPolicyRequest request = new UpdateOnlineReturnPolicyRequest
            {
                OnlineReturnPolicy = new OnlineReturnPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.UpdateOnlineReturnPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOnlineReturnPolicyAsync</summary>
        public async Task UpdateOnlineReturnPolicyRequestObjectAsync()
        {
            // Snippet: UpdateOnlineReturnPolicyAsync(UpdateOnlineReturnPolicyRequest, CallSettings)
            // Additional: UpdateOnlineReturnPolicyAsync(UpdateOnlineReturnPolicyRequest, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateOnlineReturnPolicyRequest request = new UpdateOnlineReturnPolicyRequest
            {
                OnlineReturnPolicy = new OnlineReturnPolicy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.UpdateOnlineReturnPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateOnlineReturnPolicy</summary>
        public void UpdateOnlineReturnPolicy()
        {
            // Snippet: UpdateOnlineReturnPolicy(OnlineReturnPolicy, FieldMask, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            OnlineReturnPolicy onlineReturnPolicy = new OnlineReturnPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            OnlineReturnPolicy response = onlineReturnPolicyServiceClient.UpdateOnlineReturnPolicy(onlineReturnPolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateOnlineReturnPolicyAsync</summary>
        public async Task UpdateOnlineReturnPolicyAsync()
        {
            // Snippet: UpdateOnlineReturnPolicyAsync(OnlineReturnPolicy, FieldMask, CallSettings)
            // Additional: UpdateOnlineReturnPolicyAsync(OnlineReturnPolicy, FieldMask, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            OnlineReturnPolicy onlineReturnPolicy = new OnlineReturnPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            OnlineReturnPolicy response = await onlineReturnPolicyServiceClient.UpdateOnlineReturnPolicyAsync(onlineReturnPolicy, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineReturnPolicy</summary>
        public void DeleteOnlineReturnPolicyRequestObject()
        {
            // Snippet: DeleteOnlineReturnPolicy(DeleteOnlineReturnPolicyRequest, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            DeleteOnlineReturnPolicyRequest request = new DeleteOnlineReturnPolicyRequest
            {
                OnlineReturnPolicyName = OnlineReturnPolicyName.FromAccountReturnPolicy("[ACCOUNT]", "[RETURN_POLICY]"),
            };
            // Make the request
            onlineReturnPolicyServiceClient.DeleteOnlineReturnPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineReturnPolicyAsync</summary>
        public async Task DeleteOnlineReturnPolicyRequestObjectAsync()
        {
            // Snippet: DeleteOnlineReturnPolicyAsync(DeleteOnlineReturnPolicyRequest, CallSettings)
            // Additional: DeleteOnlineReturnPolicyAsync(DeleteOnlineReturnPolicyRequest, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOnlineReturnPolicyRequest request = new DeleteOnlineReturnPolicyRequest
            {
                OnlineReturnPolicyName = OnlineReturnPolicyName.FromAccountReturnPolicy("[ACCOUNT]", "[RETURN_POLICY]"),
            };
            // Make the request
            await onlineReturnPolicyServiceClient.DeleteOnlineReturnPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineReturnPolicy</summary>
        public void DeleteOnlineReturnPolicy()
        {
            // Snippet: DeleteOnlineReturnPolicy(string, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/onlineReturnPolicies/[RETURN_POLICY]";
            // Make the request
            onlineReturnPolicyServiceClient.DeleteOnlineReturnPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineReturnPolicyAsync</summary>
        public async Task DeleteOnlineReturnPolicyAsync()
        {
            // Snippet: DeleteOnlineReturnPolicyAsync(string, CallSettings)
            // Additional: DeleteOnlineReturnPolicyAsync(string, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/onlineReturnPolicies/[RETURN_POLICY]";
            // Make the request
            await onlineReturnPolicyServiceClient.DeleteOnlineReturnPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineReturnPolicy</summary>
        public void DeleteOnlineReturnPolicyResourceNames()
        {
            // Snippet: DeleteOnlineReturnPolicy(OnlineReturnPolicyName, CallSettings)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = OnlineReturnPolicyServiceClient.Create();
            // Initialize request argument(s)
            OnlineReturnPolicyName name = OnlineReturnPolicyName.FromAccountReturnPolicy("[ACCOUNT]", "[RETURN_POLICY]");
            // Make the request
            onlineReturnPolicyServiceClient.DeleteOnlineReturnPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteOnlineReturnPolicyAsync</summary>
        public async Task DeleteOnlineReturnPolicyResourceNamesAsync()
        {
            // Snippet: DeleteOnlineReturnPolicyAsync(OnlineReturnPolicyName, CallSettings)
            // Additional: DeleteOnlineReturnPolicyAsync(OnlineReturnPolicyName, CancellationToken)
            // Create client
            OnlineReturnPolicyServiceClient onlineReturnPolicyServiceClient = await OnlineReturnPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            OnlineReturnPolicyName name = OnlineReturnPolicyName.FromAccountReturnPolicy("[ACCOUNT]", "[RETURN_POLICY]");
            // Make the request
            await onlineReturnPolicyServiceClient.DeleteOnlineReturnPolicyAsync(name);
            // End snippet
        }
    }
}
