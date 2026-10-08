// Copyright 2026 Google LLC
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
    using Google.Cloud.Compute.V1;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedManagedRulesetsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetManagedRulesetRequest, CallSettings)
            // Create client
            ManagedRulesetsClient managedRulesetsClient = ManagedRulesetsClient.Create();
            // Initialize request argument(s)
            GetManagedRulesetRequest request = new GetManagedRulesetRequest
            {
                Project = "",
                ManagedRuleset = "",
            };
            // Make the request
            ManagedRuleset response = managedRulesetsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetManagedRulesetRequest, CallSettings)
            // Additional: GetAsync(GetManagedRulesetRequest, CancellationToken)
            // Create client
            ManagedRulesetsClient managedRulesetsClient = await ManagedRulesetsClient.CreateAsync();
            // Initialize request argument(s)
            GetManagedRulesetRequest request = new GetManagedRulesetRequest
            {
                Project = "",
                ManagedRuleset = "",
            };
            // Make the request
            ManagedRuleset response = await managedRulesetsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            ManagedRulesetsClient managedRulesetsClient = ManagedRulesetsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string managedRuleset = "";
            // Make the request
            ManagedRuleset response = managedRulesetsClient.Get(project, managedRuleset);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            ManagedRulesetsClient managedRulesetsClient = await ManagedRulesetsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string managedRuleset = "";
            // Make the request
            ManagedRuleset response = await managedRulesetsClient.GetAsync(project, managedRuleset);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListManagedRulesetsRequest, CallSettings)
            // Create client
            ManagedRulesetsClient managedRulesetsClient = ManagedRulesetsClient.Create();
            // Initialize request argument(s)
            ListManagedRulesetsRequest request = new ListManagedRulesetsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ManagedRulesetList, ManagedRuleset> response = managedRulesetsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedRuleset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ManagedRulesetList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedRuleset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedRuleset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedRuleset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListManagedRulesetsRequest, CallSettings)
            // Create client
            ManagedRulesetsClient managedRulesetsClient = await ManagedRulesetsClient.CreateAsync();
            // Initialize request argument(s)
            ListManagedRulesetsRequest request = new ListManagedRulesetsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ManagedRulesetList, ManagedRuleset> response = managedRulesetsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ManagedRuleset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ManagedRulesetList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedRuleset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedRuleset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedRuleset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            ManagedRulesetsClient managedRulesetsClient = ManagedRulesetsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<ManagedRulesetList, ManagedRuleset> response = managedRulesetsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedRuleset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ManagedRulesetList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedRuleset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedRuleset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedRuleset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            ManagedRulesetsClient managedRulesetsClient = await ManagedRulesetsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<ManagedRulesetList, ManagedRuleset> response = managedRulesetsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ManagedRuleset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ManagedRulesetList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedRuleset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedRuleset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedRuleset item in singlePage)
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
