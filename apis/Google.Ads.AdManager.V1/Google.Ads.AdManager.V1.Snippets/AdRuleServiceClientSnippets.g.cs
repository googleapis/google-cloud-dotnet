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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAdRuleServiceClientSnippets
    {
        /// <summary>Snippet for GetAdRule</summary>
        public void GetAdRuleRequestObject()
        {
            // Snippet: GetAdRule(GetAdRuleRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            GetAdRuleRequest request = new GetAdRuleRequest
            {
                AdRuleName = AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
            };
            // Make the request
            AdRule response = adRuleServiceClient.GetAdRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdRuleAsync</summary>
        public async Task GetAdRuleRequestObjectAsync()
        {
            // Snippet: GetAdRuleAsync(GetAdRuleRequest, CallSettings)
            // Additional: GetAdRuleAsync(GetAdRuleRequest, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAdRuleRequest request = new GetAdRuleRequest
            {
                AdRuleName = AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
            };
            // Make the request
            AdRule response = await adRuleServiceClient.GetAdRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAdRule</summary>
        public void GetAdRule()
        {
            // Snippet: GetAdRule(string, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/adRules/[AD_RULE]";
            // Make the request
            AdRule response = adRuleServiceClient.GetAdRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdRuleAsync</summary>
        public async Task GetAdRuleAsync()
        {
            // Snippet: GetAdRuleAsync(string, CallSettings)
            // Additional: GetAdRuleAsync(string, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/adRules/[AD_RULE]";
            // Make the request
            AdRule response = await adRuleServiceClient.GetAdRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdRule</summary>
        public void GetAdRuleResourceNames()
        {
            // Snippet: GetAdRule(AdRuleName, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            AdRuleName name = AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]");
            // Make the request
            AdRule response = adRuleServiceClient.GetAdRule(name);
            // End snippet
        }

        /// <summary>Snippet for GetAdRuleAsync</summary>
        public async Task GetAdRuleResourceNamesAsync()
        {
            // Snippet: GetAdRuleAsync(AdRuleName, CallSettings)
            // Additional: GetAdRuleAsync(AdRuleName, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdRuleName name = AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]");
            // Make the request
            AdRule response = await adRuleServiceClient.GetAdRuleAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAdRules</summary>
        public void ListAdRulesRequestObject()
        {
            // Snippet: ListAdRules(ListAdRulesRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            ListAdRulesRequest request = new ListAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListAdRulesResponse, AdRule> response = adRuleServiceClient.ListAdRules(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdRulesAsync</summary>
        public async Task ListAdRulesRequestObjectAsync()
        {
            // Snippet: ListAdRulesAsync(ListAdRulesRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAdRulesRequest request = new ListAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListAdRulesResponse, AdRule> response = adRuleServiceClient.ListAdRulesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AdRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAdRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdRules</summary>
        public void ListAdRules()
        {
            // Snippet: ListAdRules(string, string, int?, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListAdRulesResponse, AdRule> response = adRuleServiceClient.ListAdRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdRulesAsync</summary>
        public async Task ListAdRulesAsync()
        {
            // Snippet: ListAdRulesAsync(string, string, int?, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListAdRulesResponse, AdRule> response = adRuleServiceClient.ListAdRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AdRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAdRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdRules</summary>
        public void ListAdRulesResourceNames()
        {
            // Snippet: ListAdRules(NetworkName, string, int?, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListAdRulesResponse, AdRule> response = adRuleServiceClient.ListAdRules(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AdRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAdRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdRule> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAdRulesAsync</summary>
        public async Task ListAdRulesResourceNamesAsync()
        {
            // Snippet: ListAdRulesAsync(NetworkName, string, int?, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListAdRulesResponse, AdRule> response = adRuleServiceClient.ListAdRulesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AdRule item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAdRulesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AdRule item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AdRule> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AdRule item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAdRule</summary>
        public void CreateAdRuleRequestObject()
        {
            // Snippet: CreateAdRule(CreateAdRuleRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            CreateAdRuleRequest request = new CreateAdRuleRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdRule = new AdRule(),
            };
            // Make the request
            AdRule response = adRuleServiceClient.CreateAdRule(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdRuleAsync</summary>
        public async Task CreateAdRuleRequestObjectAsync()
        {
            // Snippet: CreateAdRuleAsync(CreateAdRuleRequest, CallSettings)
            // Additional: CreateAdRuleAsync(CreateAdRuleRequest, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAdRuleRequest request = new CreateAdRuleRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdRule = new AdRule(),
            };
            // Make the request
            AdRule response = await adRuleServiceClient.CreateAdRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAdRule</summary>
        public void CreateAdRule()
        {
            // Snippet: CreateAdRule(string, AdRule, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            AdRule adRule = new AdRule();
            // Make the request
            AdRule response = adRuleServiceClient.CreateAdRule(parent, adRule);
            // End snippet
        }

        /// <summary>Snippet for CreateAdRuleAsync</summary>
        public async Task CreateAdRuleAsync()
        {
            // Snippet: CreateAdRuleAsync(string, AdRule, CallSettings)
            // Additional: CreateAdRuleAsync(string, AdRule, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            AdRule adRule = new AdRule();
            // Make the request
            AdRule response = await adRuleServiceClient.CreateAdRuleAsync(parent, adRule);
            // End snippet
        }

        /// <summary>Snippet for CreateAdRule</summary>
        public void CreateAdRuleResourceNames()
        {
            // Snippet: CreateAdRule(NetworkName, AdRule, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            AdRule adRule = new AdRule();
            // Make the request
            AdRule response = adRuleServiceClient.CreateAdRule(parent, adRule);
            // End snippet
        }

        /// <summary>Snippet for CreateAdRuleAsync</summary>
        public async Task CreateAdRuleResourceNamesAsync()
        {
            // Snippet: CreateAdRuleAsync(NetworkName, AdRule, CallSettings)
            // Additional: CreateAdRuleAsync(NetworkName, AdRule, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            AdRule adRule = new AdRule();
            // Make the request
            AdRule response = await adRuleServiceClient.CreateAdRuleAsync(parent, adRule);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdRules</summary>
        public void BatchCreateAdRulesRequestObject()
        {
            // Snippet: BatchCreateAdRules(BatchCreateAdRulesRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateAdRulesRequest request = new BatchCreateAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateAdRuleRequest(),
                },
            };
            // Make the request
            BatchCreateAdRulesResponse response = adRuleServiceClient.BatchCreateAdRules(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdRulesAsync</summary>
        public async Task BatchCreateAdRulesRequestObjectAsync()
        {
            // Snippet: BatchCreateAdRulesAsync(BatchCreateAdRulesRequest, CallSettings)
            // Additional: BatchCreateAdRulesAsync(BatchCreateAdRulesRequest, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateAdRulesRequest request = new BatchCreateAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateAdRuleRequest(),
                },
            };
            // Make the request
            BatchCreateAdRulesResponse response = await adRuleServiceClient.BatchCreateAdRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdRules</summary>
        public void BatchCreateAdRules()
        {
            // Snippet: BatchCreateAdRules(string, IEnumerable<CreateAdRuleRequest>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateAdRuleRequest> requests = new CreateAdRuleRequest[]
            {
                new CreateAdRuleRequest(),
            };
            // Make the request
            BatchCreateAdRulesResponse response = adRuleServiceClient.BatchCreateAdRules(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdRulesAsync</summary>
        public async Task BatchCreateAdRulesAsync()
        {
            // Snippet: BatchCreateAdRulesAsync(string, IEnumerable<CreateAdRuleRequest>, CallSettings)
            // Additional: BatchCreateAdRulesAsync(string, IEnumerable<CreateAdRuleRequest>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateAdRuleRequest> requests = new CreateAdRuleRequest[]
            {
                new CreateAdRuleRequest(),
            };
            // Make the request
            BatchCreateAdRulesResponse response = await adRuleServiceClient.BatchCreateAdRulesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdRules</summary>
        public void BatchCreateAdRulesResourceNames()
        {
            // Snippet: BatchCreateAdRules(NetworkName, IEnumerable<CreateAdRuleRequest>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateAdRuleRequest> requests = new CreateAdRuleRequest[]
            {
                new CreateAdRuleRequest(),
            };
            // Make the request
            BatchCreateAdRulesResponse response = adRuleServiceClient.BatchCreateAdRules(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateAdRulesAsync</summary>
        public async Task BatchCreateAdRulesResourceNamesAsync()
        {
            // Snippet: BatchCreateAdRulesAsync(NetworkName, IEnumerable<CreateAdRuleRequest>, CallSettings)
            // Additional: BatchCreateAdRulesAsync(NetworkName, IEnumerable<CreateAdRuleRequest>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateAdRuleRequest> requests = new CreateAdRuleRequest[]
            {
                new CreateAdRuleRequest(),
            };
            // Make the request
            BatchCreateAdRulesResponse response = await adRuleServiceClient.BatchCreateAdRulesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdRule</summary>
        public void UpdateAdRuleRequestObject()
        {
            // Snippet: UpdateAdRule(UpdateAdRuleRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            UpdateAdRuleRequest request = new UpdateAdRuleRequest
            {
                AdRule = new AdRule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdRule response = adRuleServiceClient.UpdateAdRule(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdRuleAsync</summary>
        public async Task UpdateAdRuleRequestObjectAsync()
        {
            // Snippet: UpdateAdRuleAsync(UpdateAdRuleRequest, CallSettings)
            // Additional: UpdateAdRuleAsync(UpdateAdRuleRequest, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAdRuleRequest request = new UpdateAdRuleRequest
            {
                AdRule = new AdRule(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AdRule response = await adRuleServiceClient.UpdateAdRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdRule</summary>
        public void UpdateAdRule()
        {
            // Snippet: UpdateAdRule(AdRule, FieldMask, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            AdRule adRule = new AdRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdRule response = adRuleServiceClient.UpdateAdRule(adRule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAdRuleAsync</summary>
        public async Task UpdateAdRuleAsync()
        {
            // Snippet: UpdateAdRuleAsync(AdRule, FieldMask, CallSettings)
            // Additional: UpdateAdRuleAsync(AdRule, FieldMask, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            AdRule adRule = new AdRule();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AdRule response = await adRuleServiceClient.UpdateAdRuleAsync(adRule, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdRules</summary>
        public void BatchUpdateAdRulesRequestObject()
        {
            // Snippet: BatchUpdateAdRules(BatchUpdateAdRulesRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateAdRulesRequest request = new BatchUpdateAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateAdRuleRequest(),
                },
            };
            // Make the request
            BatchUpdateAdRulesResponse response = adRuleServiceClient.BatchUpdateAdRules(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdRulesAsync</summary>
        public async Task BatchUpdateAdRulesRequestObjectAsync()
        {
            // Snippet: BatchUpdateAdRulesAsync(BatchUpdateAdRulesRequest, CallSettings)
            // Additional: BatchUpdateAdRulesAsync(BatchUpdateAdRulesRequest, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateAdRulesRequest request = new BatchUpdateAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateAdRuleRequest(),
                },
            };
            // Make the request
            BatchUpdateAdRulesResponse response = await adRuleServiceClient.BatchUpdateAdRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdRules</summary>
        public void BatchUpdateAdRules()
        {
            // Snippet: BatchUpdateAdRules(string, IEnumerable<UpdateAdRuleRequest>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateAdRuleRequest> requests = new UpdateAdRuleRequest[]
            {
                new UpdateAdRuleRequest(),
            };
            // Make the request
            BatchUpdateAdRulesResponse response = adRuleServiceClient.BatchUpdateAdRules(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdRulesAsync</summary>
        public async Task BatchUpdateAdRulesAsync()
        {
            // Snippet: BatchUpdateAdRulesAsync(string, IEnumerable<UpdateAdRuleRequest>, CallSettings)
            // Additional: BatchUpdateAdRulesAsync(string, IEnumerable<UpdateAdRuleRequest>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateAdRuleRequest> requests = new UpdateAdRuleRequest[]
            {
                new UpdateAdRuleRequest(),
            };
            // Make the request
            BatchUpdateAdRulesResponse response = await adRuleServiceClient.BatchUpdateAdRulesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdRules</summary>
        public void BatchUpdateAdRulesResourceNames()
        {
            // Snippet: BatchUpdateAdRules(NetworkName, IEnumerable<UpdateAdRuleRequest>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateAdRuleRequest> requests = new UpdateAdRuleRequest[]
            {
                new UpdateAdRuleRequest(),
            };
            // Make the request
            BatchUpdateAdRulesResponse response = adRuleServiceClient.BatchUpdateAdRules(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateAdRulesAsync</summary>
        public async Task BatchUpdateAdRulesResourceNamesAsync()
        {
            // Snippet: BatchUpdateAdRulesAsync(NetworkName, IEnumerable<UpdateAdRuleRequest>, CallSettings)
            // Additional: BatchUpdateAdRulesAsync(NetworkName, IEnumerable<UpdateAdRuleRequest>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateAdRuleRequest> requests = new UpdateAdRuleRequest[]
            {
                new UpdateAdRuleRequest(),
            };
            // Make the request
            BatchUpdateAdRulesResponse response = await adRuleServiceClient.BatchUpdateAdRulesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdRules</summary>
        public void BatchActivateAdRulesRequestObject()
        {
            // Snippet: BatchActivateAdRules(BatchActivateAdRulesRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            BatchActivateAdRulesRequest request = new BatchActivateAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdRuleNames =
                {
                    AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
                },
            };
            // Make the request
            BatchActivateAdRulesResponse response = adRuleServiceClient.BatchActivateAdRules(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdRulesAsync</summary>
        public async Task BatchActivateAdRulesRequestObjectAsync()
        {
            // Snippet: BatchActivateAdRulesAsync(BatchActivateAdRulesRequest, CallSettings)
            // Additional: BatchActivateAdRulesAsync(BatchActivateAdRulesRequest, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchActivateAdRulesRequest request = new BatchActivateAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdRuleNames =
                {
                    AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
                },
            };
            // Make the request
            BatchActivateAdRulesResponse response = await adRuleServiceClient.BatchActivateAdRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdRules</summary>
        public void BatchActivateAdRules()
        {
            // Snippet: BatchActivateAdRules(string, IEnumerable<string>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adRules/[AD_RULE]",
            };
            // Make the request
            BatchActivateAdRulesResponse response = adRuleServiceClient.BatchActivateAdRules(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdRulesAsync</summary>
        public async Task BatchActivateAdRulesAsync()
        {
            // Snippet: BatchActivateAdRulesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchActivateAdRulesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adRules/[AD_RULE]",
            };
            // Make the request
            BatchActivateAdRulesResponse response = await adRuleServiceClient.BatchActivateAdRulesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdRules</summary>
        public void BatchActivateAdRulesResourceNames()
        {
            // Snippet: BatchActivateAdRules(NetworkName, IEnumerable<AdRuleName>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdRuleName> names = new AdRuleName[]
            {
                AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
            };
            // Make the request
            BatchActivateAdRulesResponse response = adRuleServiceClient.BatchActivateAdRules(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchActivateAdRulesAsync</summary>
        public async Task BatchActivateAdRulesResourceNamesAsync()
        {
            // Snippet: BatchActivateAdRulesAsync(NetworkName, IEnumerable<AdRuleName>, CallSettings)
            // Additional: BatchActivateAdRulesAsync(NetworkName, IEnumerable<AdRuleName>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdRuleName> names = new AdRuleName[]
            {
                AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
            };
            // Make the request
            BatchActivateAdRulesResponse response = await adRuleServiceClient.BatchActivateAdRulesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdRules</summary>
        public void BatchDeactivateAdRulesRequestObject()
        {
            // Snippet: BatchDeactivateAdRules(BatchDeactivateAdRulesRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            BatchDeactivateAdRulesRequest request = new BatchDeactivateAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdRuleNames =
                {
                    AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
                },
            };
            // Make the request
            BatchDeactivateAdRulesResponse response = adRuleServiceClient.BatchDeactivateAdRules(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdRulesAsync</summary>
        public async Task BatchDeactivateAdRulesRequestObjectAsync()
        {
            // Snippet: BatchDeactivateAdRulesAsync(BatchDeactivateAdRulesRequest, CallSettings)
            // Additional: BatchDeactivateAdRulesAsync(BatchDeactivateAdRulesRequest, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeactivateAdRulesRequest request = new BatchDeactivateAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdRuleNames =
                {
                    AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
                },
            };
            // Make the request
            BatchDeactivateAdRulesResponse response = await adRuleServiceClient.BatchDeactivateAdRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdRules</summary>
        public void BatchDeactivateAdRules()
        {
            // Snippet: BatchDeactivateAdRules(string, IEnumerable<string>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adRules/[AD_RULE]",
            };
            // Make the request
            BatchDeactivateAdRulesResponse response = adRuleServiceClient.BatchDeactivateAdRules(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdRulesAsync</summary>
        public async Task BatchDeactivateAdRulesAsync()
        {
            // Snippet: BatchDeactivateAdRulesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeactivateAdRulesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adRules/[AD_RULE]",
            };
            // Make the request
            BatchDeactivateAdRulesResponse response = await adRuleServiceClient.BatchDeactivateAdRulesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdRules</summary>
        public void BatchDeactivateAdRulesResourceNames()
        {
            // Snippet: BatchDeactivateAdRules(NetworkName, IEnumerable<AdRuleName>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdRuleName> names = new AdRuleName[]
            {
                AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
            };
            // Make the request
            BatchDeactivateAdRulesResponse response = adRuleServiceClient.BatchDeactivateAdRules(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeactivateAdRulesAsync</summary>
        public async Task BatchDeactivateAdRulesResourceNamesAsync()
        {
            // Snippet: BatchDeactivateAdRulesAsync(NetworkName, IEnumerable<AdRuleName>, CallSettings)
            // Additional: BatchDeactivateAdRulesAsync(NetworkName, IEnumerable<AdRuleName>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdRuleName> names = new AdRuleName[]
            {
                AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
            };
            // Make the request
            BatchDeactivateAdRulesResponse response = await adRuleServiceClient.BatchDeactivateAdRulesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAdRules</summary>
        public void BatchDeleteAdRulesRequestObject()
        {
            // Snippet: BatchDeleteAdRules(BatchDeleteAdRulesRequest, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteAdRulesRequest request = new BatchDeleteAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdRuleNames =
                {
                    AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
                },
            };
            // Make the request
            adRuleServiceClient.BatchDeleteAdRules(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAdRulesAsync</summary>
        public async Task BatchDeleteAdRulesRequestObjectAsync()
        {
            // Snippet: BatchDeleteAdRulesAsync(BatchDeleteAdRulesRequest, CallSettings)
            // Additional: BatchDeleteAdRulesAsync(BatchDeleteAdRulesRequest, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteAdRulesRequest request = new BatchDeleteAdRulesRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                AdRuleNames =
                {
                    AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
                },
            };
            // Make the request
            await adRuleServiceClient.BatchDeleteAdRulesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAdRules</summary>
        public void BatchDeleteAdRules()
        {
            // Snippet: BatchDeleteAdRules(string, IEnumerable<string>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adRules/[AD_RULE]",
            };
            // Make the request
            adRuleServiceClient.BatchDeleteAdRules(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAdRulesAsync</summary>
        public async Task BatchDeleteAdRulesAsync()
        {
            // Snippet: BatchDeleteAdRulesAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchDeleteAdRulesAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/adRules/[AD_RULE]",
            };
            // Make the request
            await adRuleServiceClient.BatchDeleteAdRulesAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAdRules</summary>
        public void BatchDeleteAdRulesResourceNames()
        {
            // Snippet: BatchDeleteAdRules(NetworkName, IEnumerable<AdRuleName>, CallSettings)
            // Create client
            AdRuleServiceClient adRuleServiceClient = AdRuleServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdRuleName> names = new AdRuleName[]
            {
                AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
            };
            // Make the request
            adRuleServiceClient.BatchDeleteAdRules(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteAdRulesAsync</summary>
        public async Task BatchDeleteAdRulesResourceNamesAsync()
        {
            // Snippet: BatchDeleteAdRulesAsync(NetworkName, IEnumerable<AdRuleName>, CallSettings)
            // Additional: BatchDeleteAdRulesAsync(NetworkName, IEnumerable<AdRuleName>, CancellationToken)
            // Create client
            AdRuleServiceClient adRuleServiceClient = await AdRuleServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<AdRuleName> names = new AdRuleName[]
            {
                AdRuleName.FromNetworkCodeAdRule("[NETWORK_CODE]", "[AD_RULE]"),
            };
            // Make the request
            await adRuleServiceClient.BatchDeleteAdRulesAsync(parent, names);
            // End snippet
        }
    }
}
