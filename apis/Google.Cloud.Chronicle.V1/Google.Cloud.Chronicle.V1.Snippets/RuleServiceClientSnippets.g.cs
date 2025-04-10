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
    using Google.Cloud.Chronicle.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRuleServiceClientSnippets
    {
        /// <summary>Snippet for CreateRule</summary>
        public void CreateRuleRequestObject()
        {
            // Snippet: CreateRule(CreateRuleRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            CreateRuleRequest request = new CreateRuleRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Rule = new Rule(),
            };
            // Make the request
            Rule response = ruleServiceClient.CreateRule(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRuleAsync</summary>
        public async Task CreateRuleRequestObjectAsync()
        {
            // Snippet: CreateRuleAsync(CreateRuleRequest, CallSettings)
            // Additional: CreateRuleAsync(CreateRuleRequest, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRuleRequest request = new CreateRuleRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Rule = new Rule(),
            };
            // Make the request
            Rule response = await ruleServiceClient.CreateRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRule</summary>
        public void CreateRule()
        {
            // Snippet: CreateRule(string, Rule, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Rule rule = new Rule();
            // Make the request
            Rule response = ruleServiceClient.CreateRule(parent, rule);
            // End snippet
        }

        /// <summary>Snippet for CreateRuleAsync</summary>
        public async Task CreateRuleAsync()
        {
            // Snippet: CreateRuleAsync(string, Rule, CallSettings)
            // Additional: CreateRuleAsync(string, Rule, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Rule rule = new Rule();
            // Make the request
            Rule response = await ruleServiceClient.CreateRuleAsync(parent, rule);
            // End snippet
        }

        /// <summary>Snippet for CreateRule</summary>
        public void CreateRuleResourceNames()
        {
            // Snippet: CreateRule(InstanceName, Rule, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Rule rule = new Rule();
            // Make the request
            Rule response = ruleServiceClient.CreateRule(parent, rule);
            // End snippet
        }

        /// <summary>Snippet for CreateRuleAsync</summary>
        public async Task CreateRuleResourceNamesAsync()
        {
            // Snippet: CreateRuleAsync(InstanceName, Rule, CallSettings)
            // Additional: CreateRuleAsync(InstanceName, Rule, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Rule rule = new Rule();
            // Make the request
            Rule response = await ruleServiceClient.CreateRuleAsync(parent, rule);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRuleRequestObject()
        {
            // Snippet: GetRule(GetRuleRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            GetRuleRequest request = new GetRuleRequest
            {
                RuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                View = RuleView.Unspecified,
            };
            // Make the request
            Rule response = ruleServiceClient.GetRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleRequestObjectAsync()
        {
            // Snippet: GetRuleAsync(GetRuleRequest, CallSettings)
            // Additional: GetRuleAsync(GetRuleRequest, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRuleRequest request = new GetRuleRequest
            {
                RuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                View = RuleView.Unspecified,
            };
            // Make the request
            Rule response = await ruleServiceClient.GetRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRule()
        {
            // Snippet: GetRule(string, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            Rule response = ruleServiceClient.GetRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleAsync()
        {
            // Snippet: GetRuleAsync(string, CallSettings)
            // Additional: GetRuleAsync(string, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            Rule response = await ruleServiceClient.GetRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRuleResourceNames()
        {
            // Snippet: GetRule(RuleName, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            RuleName name = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            Rule response = ruleServiceClient.GetRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleResourceNamesAsync()
        {
            // Snippet: GetRuleAsync(RuleName, CallSettings)
            // Additional: GetRuleAsync(RuleName, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuleName name = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            Rule response = await ruleServiceClient.GetRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRules</summary>
        public void ListRulesRequestObject()
        {
            // Snippet: ListRules(ListRulesRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            ListRulesRequest request = new ListRulesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = RuleView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRulesResponse, Rule> response = ruleServiceClient.ListRules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRulesAsync</summary>
        public async Task ListRulesRequestObjectAsync()
        {
            // Snippet: ListRulesAsync(ListRulesRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRulesRequest request = new ListRulesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = RuleView.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRulesResponse, Rule> response = ruleServiceClient.ListRulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRules</summary>
        public void ListRules()
        {
            // Snippet: ListRules(string, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListRulesResponse, Rule> response = ruleServiceClient.ListRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRulesAsync</summary>
        public async Task ListRulesAsync()
        {
            // Snippet: ListRulesAsync(string, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListRulesResponse, Rule> response = ruleServiceClient.ListRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRules</summary>
        public void ListRulesResourceNames()
        {
            // Snippet: ListRules(InstanceName, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListRulesResponse, Rule> response = ruleServiceClient.ListRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRulesAsync</summary>
        public async Task ListRulesResourceNamesAsync()
        {
            // Snippet: ListRulesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListRulesResponse, Rule> response = ruleServiceClient.ListRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRulesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateRule</summary>
        public void UpdateRuleRequestObject()
        {
            // Snippet: UpdateRule(UpdateRuleRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            UpdateRuleRequest request = new UpdateRuleRequest
            {
                Rule = new Rule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Rule response = ruleServiceClient.UpdateRule(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRuleAsync</summary>
        public async Task UpdateRuleRequestObjectAsync()
        {
            // Snippet: UpdateRuleAsync(UpdateRuleRequest, CallSettings)
            // Additional: UpdateRuleAsync(UpdateRuleRequest, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRuleRequest request = new UpdateRuleRequest
            {
                Rule = new Rule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Rule response = await ruleServiceClient.UpdateRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRule</summary>
        public void UpdateRule()
        {
            // Snippet: UpdateRule(Rule, FieldMask, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            Rule rule = new Rule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Rule response = ruleServiceClient.UpdateRule(rule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRuleAsync</summary>
        public async Task UpdateRuleAsync()
        {
            // Snippet: UpdateRuleAsync(Rule, FieldMask, CallSettings)
            // Additional: UpdateRuleAsync(Rule, FieldMask, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            Rule rule = new Rule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Rule response = await ruleServiceClient.UpdateRuleAsync(rule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteRule</summary>
        public void DeleteRuleRequestObject()
        {
            // Snippet: DeleteRule(DeleteRuleRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            DeleteRuleRequest request = new DeleteRuleRequest
            {
                RuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                Force = false,
            };
            // Make the request
            ruleServiceClient.DeleteRule(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRuleAsync</summary>
        public async Task DeleteRuleRequestObjectAsync()
        {
            // Snippet: DeleteRuleAsync(DeleteRuleRequest, CallSettings)
            // Additional: DeleteRuleAsync(DeleteRuleRequest, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRuleRequest request = new DeleteRuleRequest
            {
                RuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                Force = false,
            };
            // Make the request
            await ruleServiceClient.DeleteRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRule</summary>
        public void DeleteRule()
        {
            // Snippet: DeleteRule(string, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            ruleServiceClient.DeleteRule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRuleAsync</summary>
        public async Task DeleteRuleAsync()
        {
            // Snippet: DeleteRuleAsync(string, CallSettings)
            // Additional: DeleteRuleAsync(string, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            await ruleServiceClient.DeleteRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRule</summary>
        public void DeleteRuleResourceNames()
        {
            // Snippet: DeleteRule(RuleName, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            RuleName name = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            ruleServiceClient.DeleteRule(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRuleAsync</summary>
        public async Task DeleteRuleResourceNamesAsync()
        {
            // Snippet: DeleteRuleAsync(RuleName, CallSettings)
            // Additional: DeleteRuleAsync(RuleName, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuleName name = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            await ruleServiceClient.DeleteRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRuleRevisions</summary>
        public void ListRuleRevisionsRequestObject()
        {
            // Snippet: ListRuleRevisions(ListRuleRevisionsRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            ListRuleRevisionsRequest request = new ListRuleRevisionsRequest
            {
                RuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                View = RuleView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListRuleRevisionsResponse, Rule> response = ruleServiceClient.ListRuleRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuleRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleRevisionsAsync</summary>
        public async Task ListRuleRevisionsRequestObjectAsync()
        {
            // Snippet: ListRuleRevisionsAsync(ListRuleRevisionsRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRuleRevisionsRequest request = new ListRuleRevisionsRequest
            {
                RuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                View = RuleView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListRuleRevisionsResponse, Rule> response = ruleServiceClient.ListRuleRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuleRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleRevisions</summary>
        public void ListRuleRevisions()
        {
            // Snippet: ListRuleRevisions(string, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            PagedEnumerable<ListRuleRevisionsResponse, Rule> response = ruleServiceClient.ListRuleRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuleRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleRevisionsAsync</summary>
        public async Task ListRuleRevisionsAsync()
        {
            // Snippet: ListRuleRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            PagedAsyncEnumerable<ListRuleRevisionsResponse, Rule> response = ruleServiceClient.ListRuleRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuleRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleRevisions</summary>
        public void ListRuleRevisionsResourceNames()
        {
            // Snippet: ListRuleRevisions(RuleName, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            RuleName name = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            PagedEnumerable<ListRuleRevisionsResponse, Rule> response = ruleServiceClient.ListRuleRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuleRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleRevisionsAsync</summary>
        public async Task ListRuleRevisionsResourceNamesAsync()
        {
            // Snippet: ListRuleRevisionsAsync(RuleName, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuleName name = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            PagedAsyncEnumerable<ListRuleRevisionsResponse, Rule> response = ruleServiceClient.ListRuleRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rule item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuleRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateRetrohunt</summary>
        public void CreateRetrohuntRequestObject()
        {
            // Snippet: CreateRetrohunt(CreateRetrohuntRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            CreateRetrohuntRequest request = new CreateRetrohuntRequest
            {
                ParentAsRuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                Retrohunt = new Retrohunt(),
            };
            // Make the request
            Operation<Retrohunt, RetrohuntMetadata> response = ruleServiceClient.CreateRetrohunt(request);

            // Poll until the returned long-running operation is complete
            Operation<Retrohunt, RetrohuntMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Retrohunt result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Retrohunt, RetrohuntMetadata> retrievedResponse = ruleServiceClient.PollOnceCreateRetrohunt(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Retrohunt retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRetrohuntAsync</summary>
        public async Task CreateRetrohuntRequestObjectAsync()
        {
            // Snippet: CreateRetrohuntAsync(CreateRetrohuntRequest, CallSettings)
            // Additional: CreateRetrohuntAsync(CreateRetrohuntRequest, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRetrohuntRequest request = new CreateRetrohuntRequest
            {
                ParentAsRuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                Retrohunt = new Retrohunt(),
            };
            // Make the request
            Operation<Retrohunt, RetrohuntMetadata> response = await ruleServiceClient.CreateRetrohuntAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Retrohunt, RetrohuntMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Retrohunt result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Retrohunt, RetrohuntMetadata> retrievedResponse = await ruleServiceClient.PollOnceCreateRetrohuntAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Retrohunt retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRetrohunt</summary>
        public void CreateRetrohunt()
        {
            // Snippet: CreateRetrohunt(string, Retrohunt, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            Retrohunt retrohunt = new Retrohunt();
            // Make the request
            Operation<Retrohunt, RetrohuntMetadata> response = ruleServiceClient.CreateRetrohunt(parent, retrohunt);

            // Poll until the returned long-running operation is complete
            Operation<Retrohunt, RetrohuntMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Retrohunt result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Retrohunt, RetrohuntMetadata> retrievedResponse = ruleServiceClient.PollOnceCreateRetrohunt(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Retrohunt retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRetrohuntAsync</summary>
        public async Task CreateRetrohuntAsync()
        {
            // Snippet: CreateRetrohuntAsync(string, Retrohunt, CallSettings)
            // Additional: CreateRetrohuntAsync(string, Retrohunt, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            Retrohunt retrohunt = new Retrohunt();
            // Make the request
            Operation<Retrohunt, RetrohuntMetadata> response = await ruleServiceClient.CreateRetrohuntAsync(parent, retrohunt);

            // Poll until the returned long-running operation is complete
            Operation<Retrohunt, RetrohuntMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Retrohunt result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Retrohunt, RetrohuntMetadata> retrievedResponse = await ruleServiceClient.PollOnceCreateRetrohuntAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Retrohunt retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRetrohunt</summary>
        public void CreateRetrohuntResourceNames()
        {
            // Snippet: CreateRetrohunt(RuleName, Retrohunt, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            RuleName parent = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            Retrohunt retrohunt = new Retrohunt();
            // Make the request
            Operation<Retrohunt, RetrohuntMetadata> response = ruleServiceClient.CreateRetrohunt(parent, retrohunt);

            // Poll until the returned long-running operation is complete
            Operation<Retrohunt, RetrohuntMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Retrohunt result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Retrohunt, RetrohuntMetadata> retrievedResponse = ruleServiceClient.PollOnceCreateRetrohunt(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Retrohunt retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRetrohuntAsync</summary>
        public async Task CreateRetrohuntResourceNamesAsync()
        {
            // Snippet: CreateRetrohuntAsync(RuleName, Retrohunt, CallSettings)
            // Additional: CreateRetrohuntAsync(RuleName, Retrohunt, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuleName parent = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            Retrohunt retrohunt = new Retrohunt();
            // Make the request
            Operation<Retrohunt, RetrohuntMetadata> response = await ruleServiceClient.CreateRetrohuntAsync(parent, retrohunt);

            // Poll until the returned long-running operation is complete
            Operation<Retrohunt, RetrohuntMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Retrohunt result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Retrohunt, RetrohuntMetadata> retrievedResponse = await ruleServiceClient.PollOnceCreateRetrohuntAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Retrohunt retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetRetrohunt</summary>
        public void GetRetrohuntRequestObject()
        {
            // Snippet: GetRetrohunt(GetRetrohuntRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            GetRetrohuntRequest request = new GetRetrohuntRequest
            {
                RetrohuntName = RetrohuntName.FromProjectLocationInstanceRuleRetrohunt("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]", "[RETROHUNT]"),
            };
            // Make the request
            Retrohunt response = ruleServiceClient.GetRetrohunt(request);
            // End snippet
        }

        /// <summary>Snippet for GetRetrohuntAsync</summary>
        public async Task GetRetrohuntRequestObjectAsync()
        {
            // Snippet: GetRetrohuntAsync(GetRetrohuntRequest, CallSettings)
            // Additional: GetRetrohuntAsync(GetRetrohuntRequest, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRetrohuntRequest request = new GetRetrohuntRequest
            {
                RetrohuntName = RetrohuntName.FromProjectLocationInstanceRuleRetrohunt("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]", "[RETROHUNT]"),
            };
            // Make the request
            Retrohunt response = await ruleServiceClient.GetRetrohuntAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRetrohunt</summary>
        public void GetRetrohunt()
        {
            // Snippet: GetRetrohunt(string, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]/retrohunts/[RETROHUNT]";
            // Make the request
            Retrohunt response = ruleServiceClient.GetRetrohunt(name);
            // End snippet
        }

        /// <summary>Snippet for GetRetrohuntAsync</summary>
        public async Task GetRetrohuntAsync()
        {
            // Snippet: GetRetrohuntAsync(string, CallSettings)
            // Additional: GetRetrohuntAsync(string, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]/retrohunts/[RETROHUNT]";
            // Make the request
            Retrohunt response = await ruleServiceClient.GetRetrohuntAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRetrohunt</summary>
        public void GetRetrohuntResourceNames()
        {
            // Snippet: GetRetrohunt(RetrohuntName, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            RetrohuntName name = RetrohuntName.FromProjectLocationInstanceRuleRetrohunt("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]", "[RETROHUNT]");
            // Make the request
            Retrohunt response = ruleServiceClient.GetRetrohunt(name);
            // End snippet
        }

        /// <summary>Snippet for GetRetrohuntAsync</summary>
        public async Task GetRetrohuntResourceNamesAsync()
        {
            // Snippet: GetRetrohuntAsync(RetrohuntName, CallSettings)
            // Additional: GetRetrohuntAsync(RetrohuntName, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RetrohuntName name = RetrohuntName.FromProjectLocationInstanceRuleRetrohunt("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]", "[RETROHUNT]");
            // Make the request
            Retrohunt response = await ruleServiceClient.GetRetrohuntAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRetrohunts</summary>
        public void ListRetrohuntsRequestObject()
        {
            // Snippet: ListRetrohunts(ListRetrohuntsRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            ListRetrohuntsRequest request = new ListRetrohuntsRequest
            {
                ParentAsRuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRetrohuntsResponse, Retrohunt> response = ruleServiceClient.ListRetrohunts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Retrohunt item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRetrohuntsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Retrohunt item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Retrohunt> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Retrohunt item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRetrohuntsAsync</summary>
        public async Task ListRetrohuntsRequestObjectAsync()
        {
            // Snippet: ListRetrohuntsAsync(ListRetrohuntsRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRetrohuntsRequest request = new ListRetrohuntsRequest
            {
                ParentAsRuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRetrohuntsResponse, Retrohunt> response = ruleServiceClient.ListRetrohuntsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Retrohunt item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRetrohuntsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Retrohunt item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Retrohunt> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Retrohunt item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRetrohunts</summary>
        public void ListRetrohunts()
        {
            // Snippet: ListRetrohunts(string, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            PagedEnumerable<ListRetrohuntsResponse, Retrohunt> response = ruleServiceClient.ListRetrohunts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Retrohunt item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRetrohuntsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Retrohunt item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Retrohunt> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Retrohunt item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRetrohuntsAsync</summary>
        public async Task ListRetrohuntsAsync()
        {
            // Snippet: ListRetrohuntsAsync(string, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            PagedAsyncEnumerable<ListRetrohuntsResponse, Retrohunt> response = ruleServiceClient.ListRetrohuntsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Retrohunt item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRetrohuntsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Retrohunt item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Retrohunt> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Retrohunt item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRetrohunts</summary>
        public void ListRetrohuntsResourceNames()
        {
            // Snippet: ListRetrohunts(RuleName, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            RuleName parent = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            PagedEnumerable<ListRetrohuntsResponse, Retrohunt> response = ruleServiceClient.ListRetrohunts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Retrohunt item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRetrohuntsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Retrohunt item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Retrohunt> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Retrohunt item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRetrohuntsAsync</summary>
        public async Task ListRetrohuntsResourceNamesAsync()
        {
            // Snippet: ListRetrohuntsAsync(RuleName, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuleName parent = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            PagedAsyncEnumerable<ListRetrohuntsResponse, Retrohunt> response = ruleServiceClient.ListRetrohuntsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Retrohunt item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRetrohuntsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Retrohunt item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Retrohunt> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Retrohunt item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRuleDeployment</summary>
        public void GetRuleDeploymentRequestObject()
        {
            // Snippet: GetRuleDeployment(GetRuleDeploymentRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            GetRuleDeploymentRequest request = new GetRuleDeploymentRequest
            {
                RuleDeploymentName = RuleDeploymentName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
            };
            // Make the request
            RuleDeployment response = ruleServiceClient.GetRuleDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuleDeploymentAsync</summary>
        public async Task GetRuleDeploymentRequestObjectAsync()
        {
            // Snippet: GetRuleDeploymentAsync(GetRuleDeploymentRequest, CallSettings)
            // Additional: GetRuleDeploymentAsync(GetRuleDeploymentRequest, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRuleDeploymentRequest request = new GetRuleDeploymentRequest
            {
                RuleDeploymentName = RuleDeploymentName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
            };
            // Make the request
            RuleDeployment response = await ruleServiceClient.GetRuleDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuleDeployment</summary>
        public void GetRuleDeployment()
        {
            // Snippet: GetRuleDeployment(string, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]/deployment";
            // Make the request
            RuleDeployment response = ruleServiceClient.GetRuleDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuleDeploymentAsync</summary>
        public async Task GetRuleDeploymentAsync()
        {
            // Snippet: GetRuleDeploymentAsync(string, CallSettings)
            // Additional: GetRuleDeploymentAsync(string, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]/deployment";
            // Make the request
            RuleDeployment response = await ruleServiceClient.GetRuleDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuleDeployment</summary>
        public void GetRuleDeploymentResourceNames()
        {
            // Snippet: GetRuleDeployment(RuleDeploymentName, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            RuleDeploymentName name = RuleDeploymentName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            RuleDeployment response = ruleServiceClient.GetRuleDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuleDeploymentAsync</summary>
        public async Task GetRuleDeploymentResourceNamesAsync()
        {
            // Snippet: GetRuleDeploymentAsync(RuleDeploymentName, CallSettings)
            // Additional: GetRuleDeploymentAsync(RuleDeploymentName, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuleDeploymentName name = RuleDeploymentName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            RuleDeployment response = await ruleServiceClient.GetRuleDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRuleDeployments</summary>
        public void ListRuleDeploymentsRequestObject()
        {
            // Snippet: ListRuleDeployments(ListRuleDeploymentsRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            ListRuleDeploymentsRequest request = new ListRuleDeploymentsRequest
            {
                ParentAsRuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRuleDeploymentsResponse, RuleDeployment> response = ruleServiceClient.ListRuleDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuleDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuleDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleDeploymentsAsync</summary>
        public async Task ListRuleDeploymentsRequestObjectAsync()
        {
            // Snippet: ListRuleDeploymentsAsync(ListRuleDeploymentsRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRuleDeploymentsRequest request = new ListRuleDeploymentsRequest
            {
                ParentAsRuleName = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRuleDeploymentsResponse, RuleDeployment> response = ruleServiceClient.ListRuleDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuleDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuleDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleDeployments</summary>
        public void ListRuleDeployments()
        {
            // Snippet: ListRuleDeployments(string, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            PagedEnumerable<ListRuleDeploymentsResponse, RuleDeployment> response = ruleServiceClient.ListRuleDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuleDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuleDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleDeploymentsAsync</summary>
        public async Task ListRuleDeploymentsAsync()
        {
            // Snippet: ListRuleDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/rules/[RULE]";
            // Make the request
            PagedAsyncEnumerable<ListRuleDeploymentsResponse, RuleDeployment> response = ruleServiceClient.ListRuleDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuleDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuleDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleDeployments</summary>
        public void ListRuleDeploymentsResourceNames()
        {
            // Snippet: ListRuleDeployments(RuleName, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            RuleName parent = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            PagedEnumerable<ListRuleDeploymentsResponse, RuleDeployment> response = ruleServiceClient.ListRuleDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuleDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuleDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleDeploymentsAsync</summary>
        public async Task ListRuleDeploymentsResourceNamesAsync()
        {
            // Snippet: ListRuleDeploymentsAsync(RuleName, string, int?, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuleName parent = RuleName.FromProjectLocationInstanceRule("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[RULE]");
            // Make the request
            PagedAsyncEnumerable<ListRuleDeploymentsResponse, RuleDeployment> response = ruleServiceClient.ListRuleDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuleDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuleDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateRuleDeployment</summary>
        public void UpdateRuleDeploymentRequestObject()
        {
            // Snippet: UpdateRuleDeployment(UpdateRuleDeploymentRequest, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            UpdateRuleDeploymentRequest request = new UpdateRuleDeploymentRequest
            {
                RuleDeployment = new RuleDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            RuleDeployment response = ruleServiceClient.UpdateRuleDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRuleDeploymentAsync</summary>
        public async Task UpdateRuleDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateRuleDeploymentAsync(UpdateRuleDeploymentRequest, CallSettings)
            // Additional: UpdateRuleDeploymentAsync(UpdateRuleDeploymentRequest, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRuleDeploymentRequest request = new UpdateRuleDeploymentRequest
            {
                RuleDeployment = new RuleDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            RuleDeployment response = await ruleServiceClient.UpdateRuleDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRuleDeployment</summary>
        public void UpdateRuleDeployment()
        {
            // Snippet: UpdateRuleDeployment(RuleDeployment, FieldMask, CallSettings)
            // Create client
            RuleServiceClient ruleServiceClient = RuleServiceClient.Create();
            // Initialize request argument(s)
            RuleDeployment ruleDeployment = new RuleDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            RuleDeployment response = ruleServiceClient.UpdateRuleDeployment(ruleDeployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRuleDeploymentAsync</summary>
        public async Task UpdateRuleDeploymentAsync()
        {
            // Snippet: UpdateRuleDeploymentAsync(RuleDeployment, FieldMask, CallSettings)
            // Additional: UpdateRuleDeploymentAsync(RuleDeployment, FieldMask, CancellationToken)
            // Create client
            RuleServiceClient ruleServiceClient = await RuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            RuleDeployment ruleDeployment = new RuleDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            RuleDeployment response = await ruleServiceClient.UpdateRuleDeploymentAsync(ruleDeployment, updateMask);
            // End snippet
        }
    }
}
