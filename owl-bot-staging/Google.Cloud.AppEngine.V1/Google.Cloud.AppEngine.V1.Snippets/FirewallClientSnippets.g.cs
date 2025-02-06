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
    using Google.Cloud.AppEngine.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFirewallClientSnippets
    {
        /// <summary>Snippet for ListIngressRules</summary>
        public void ListIngressRulesRequestObject()
        {
            // Snippet: ListIngressRules(ListIngressRulesRequest, CallSettings)
            // Create client
            FirewallClient firewallClient = FirewallClient.Create();
            // Initialize request argument(s)
            ListIngressRulesRequest request = new ListIngressRulesRequest
            {
                Parent = "",
                MatchingAddress = "",
            };
            // Make the request
            PagedEnumerable<ListIngressRulesResponse, FirewallRule> response = firewallClient.ListIngressRules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListIngressRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListIngressRulesAsync</summary>
        public async Task ListIngressRulesRequestObjectAsync()
        {
            // Snippet: ListIngressRulesAsync(ListIngressRulesRequest, CallSettings)
            // Create client
            FirewallClient firewallClient = await FirewallClient.CreateAsync();
            // Initialize request argument(s)
            ListIngressRulesRequest request = new ListIngressRulesRequest
            {
                Parent = "",
                MatchingAddress = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListIngressRulesResponse, FirewallRule> response = firewallClient.ListIngressRulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FirewallRule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListIngressRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIngressRules</summary>
        public void BatchUpdateIngressRulesRequestObject()
        {
            // Snippet: BatchUpdateIngressRules(BatchUpdateIngressRulesRequest, CallSettings)
            // Create client
            FirewallClient firewallClient = FirewallClient.Create();
            // Initialize request argument(s)
            BatchUpdateIngressRulesRequest request = new BatchUpdateIngressRulesRequest
            {
                Name = "",
                IngressRules = { new FirewallRule(), },
            };
            // Make the request
            BatchUpdateIngressRulesResponse response = firewallClient.BatchUpdateIngressRules(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateIngressRulesAsync</summary>
        public async Task BatchUpdateIngressRulesRequestObjectAsync()
        {
            // Snippet: BatchUpdateIngressRulesAsync(BatchUpdateIngressRulesRequest, CallSettings)
            // Additional: BatchUpdateIngressRulesAsync(BatchUpdateIngressRulesRequest, CancellationToken)
            // Create client
            FirewallClient firewallClient = await FirewallClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateIngressRulesRequest request = new BatchUpdateIngressRulesRequest
            {
                Name = "",
                IngressRules = { new FirewallRule(), },
            };
            // Make the request
            BatchUpdateIngressRulesResponse response = await firewallClient.BatchUpdateIngressRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIngressRule</summary>
        public void CreateIngressRuleRequestObject()
        {
            // Snippet: CreateIngressRule(CreateIngressRuleRequest, CallSettings)
            // Create client
            FirewallClient firewallClient = FirewallClient.Create();
            // Initialize request argument(s)
            CreateIngressRuleRequest request = new CreateIngressRuleRequest
            {
                Parent = "",
                Rule = new FirewallRule(),
            };
            // Make the request
            FirewallRule response = firewallClient.CreateIngressRule(request);
            // End snippet
        }

        /// <summary>Snippet for CreateIngressRuleAsync</summary>
        public async Task CreateIngressRuleRequestObjectAsync()
        {
            // Snippet: CreateIngressRuleAsync(CreateIngressRuleRequest, CallSettings)
            // Additional: CreateIngressRuleAsync(CreateIngressRuleRequest, CancellationToken)
            // Create client
            FirewallClient firewallClient = await FirewallClient.CreateAsync();
            // Initialize request argument(s)
            CreateIngressRuleRequest request = new CreateIngressRuleRequest
            {
                Parent = "",
                Rule = new FirewallRule(),
            };
            // Make the request
            FirewallRule response = await firewallClient.CreateIngressRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIngressRule</summary>
        public void GetIngressRuleRequestObject()
        {
            // Snippet: GetIngressRule(GetIngressRuleRequest, CallSettings)
            // Create client
            FirewallClient firewallClient = FirewallClient.Create();
            // Initialize request argument(s)
            GetIngressRuleRequest request = new GetIngressRuleRequest { Name = "", };
            // Make the request
            FirewallRule response = firewallClient.GetIngressRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetIngressRuleAsync</summary>
        public async Task GetIngressRuleRequestObjectAsync()
        {
            // Snippet: GetIngressRuleAsync(GetIngressRuleRequest, CallSettings)
            // Additional: GetIngressRuleAsync(GetIngressRuleRequest, CancellationToken)
            // Create client
            FirewallClient firewallClient = await FirewallClient.CreateAsync();
            // Initialize request argument(s)
            GetIngressRuleRequest request = new GetIngressRuleRequest { Name = "", };
            // Make the request
            FirewallRule response = await firewallClient.GetIngressRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIngressRule</summary>
        public void UpdateIngressRuleRequestObject()
        {
            // Snippet: UpdateIngressRule(UpdateIngressRuleRequest, CallSettings)
            // Create client
            FirewallClient firewallClient = FirewallClient.Create();
            // Initialize request argument(s)
            UpdateIngressRuleRequest request = new UpdateIngressRuleRequest
            {
                Name = "",
                Rule = new FirewallRule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FirewallRule response = firewallClient.UpdateIngressRule(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIngressRuleAsync</summary>
        public async Task UpdateIngressRuleRequestObjectAsync()
        {
            // Snippet: UpdateIngressRuleAsync(UpdateIngressRuleRequest, CallSettings)
            // Additional: UpdateIngressRuleAsync(UpdateIngressRuleRequest, CancellationToken)
            // Create client
            FirewallClient firewallClient = await FirewallClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIngressRuleRequest request = new UpdateIngressRuleRequest
            {
                Name = "",
                Rule = new FirewallRule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            FirewallRule response = await firewallClient.UpdateIngressRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIngressRule</summary>
        public void DeleteIngressRuleRequestObject()
        {
            // Snippet: DeleteIngressRule(DeleteIngressRuleRequest, CallSettings)
            // Create client
            FirewallClient firewallClient = FirewallClient.Create();
            // Initialize request argument(s)
            DeleteIngressRuleRequest request = new DeleteIngressRuleRequest { Name = "", };
            // Make the request
            firewallClient.DeleteIngressRule(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIngressRuleAsync</summary>
        public async Task DeleteIngressRuleRequestObjectAsync()
        {
            // Snippet: DeleteIngressRuleAsync(DeleteIngressRuleRequest, CallSettings)
            // Additional: DeleteIngressRuleAsync(DeleteIngressRuleRequest, CancellationToken)
            // Create client
            FirewallClient firewallClient = await FirewallClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIngressRuleRequest request = new DeleteIngressRuleRequest { Name = "", };
            // Make the request
            await firewallClient.DeleteIngressRuleAsync(request);
            // End snippet
        }
    }
}
