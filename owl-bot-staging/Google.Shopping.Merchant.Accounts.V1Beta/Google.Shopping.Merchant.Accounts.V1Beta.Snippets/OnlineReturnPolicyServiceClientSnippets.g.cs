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
    }
}
