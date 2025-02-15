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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNetworkFirewallPoliciesClientSnippets
    {
        /// <summary>Snippet for AddAssociation</summary>
        public void AddAssociationRequestObject()
        {
            // Snippet: AddAssociation(AddAssociationNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            AddAssociationNetworkFirewallPolicyRequest request = new AddAssociationNetworkFirewallPolicyRequest
            {
                RequestId = "",
                ReplaceExistingAssociation = false,
                Project = "",
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.AddAssociation(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceAddAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAssociationAsync</summary>
        public async Task AddAssociationRequestObjectAsync()
        {
            // Snippet: AddAssociationAsync(AddAssociationNetworkFirewallPolicyRequest, CallSettings)
            // Additional: AddAssociationAsync(AddAssociationNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddAssociationNetworkFirewallPolicyRequest request = new AddAssociationNetworkFirewallPolicyRequest
            {
                RequestId = "",
                ReplaceExistingAssociation = false,
                Project = "",
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.AddAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceAddAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAssociation</summary>
        public void AddAssociation()
        {
            // Snippet: AddAssociation(string, string, FirewallPolicyAssociation, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyAssociation firewallPolicyAssociationResource = new FirewallPolicyAssociation();
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.AddAssociation(project, firewallPolicy, firewallPolicyAssociationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceAddAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAssociationAsync</summary>
        public async Task AddAssociationAsync()
        {
            // Snippet: AddAssociationAsync(string, string, FirewallPolicyAssociation, CallSettings)
            // Additional: AddAssociationAsync(string, string, FirewallPolicyAssociation, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyAssociation firewallPolicyAssociationResource = new FirewallPolicyAssociation();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.AddAssociationAsync(project, firewallPolicy, firewallPolicyAssociationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceAddAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddPacketMirroringRule</summary>
        public void AddPacketMirroringRuleRequestObject()
        {
            // Snippet: AddPacketMirroringRule(AddPacketMirroringRuleNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            AddPacketMirroringRuleNetworkFirewallPolicyRequest request = new AddPacketMirroringRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                MinPriority = 0,
                MaxPriority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.AddPacketMirroringRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceAddPacketMirroringRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddPacketMirroringRuleAsync</summary>
        public async Task AddPacketMirroringRuleRequestObjectAsync()
        {
            // Snippet: AddPacketMirroringRuleAsync(AddPacketMirroringRuleNetworkFirewallPolicyRequest, CallSettings)
            // Additional: AddPacketMirroringRuleAsync(AddPacketMirroringRuleNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddPacketMirroringRuleNetworkFirewallPolicyRequest request = new AddPacketMirroringRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                MinPriority = 0,
                MaxPriority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.AddPacketMirroringRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceAddPacketMirroringRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddPacketMirroringRule</summary>
        public void AddPacketMirroringRule()
        {
            // Snippet: AddPacketMirroringRule(string, string, FirewallPolicyRule, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.AddPacketMirroringRule(project, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceAddPacketMirroringRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddPacketMirroringRuleAsync</summary>
        public async Task AddPacketMirroringRuleAsync()
        {
            // Snippet: AddPacketMirroringRuleAsync(string, string, FirewallPolicyRule, CallSettings)
            // Additional: AddPacketMirroringRuleAsync(string, string, FirewallPolicyRule, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.AddPacketMirroringRuleAsync(project, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceAddPacketMirroringRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddRule</summary>
        public void AddRuleRequestObject()
        {
            // Snippet: AddRule(AddRuleNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            AddRuleNetworkFirewallPolicyRequest request = new AddRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                MinPriority = 0,
                MaxPriority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.AddRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceAddRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddRuleAsync</summary>
        public async Task AddRuleRequestObjectAsync()
        {
            // Snippet: AddRuleAsync(AddRuleNetworkFirewallPolicyRequest, CallSettings)
            // Additional: AddRuleAsync(AddRuleNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddRuleNetworkFirewallPolicyRequest request = new AddRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                MinPriority = 0,
                MaxPriority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.AddRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceAddRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddRule</summary>
        public void AddRule()
        {
            // Snippet: AddRule(string, string, FirewallPolicyRule, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.AddRule(project, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceAddRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddRuleAsync</summary>
        public async Task AddRuleAsync()
        {
            // Snippet: AddRuleAsync(string, string, FirewallPolicyRule, CallSettings)
            // Additional: AddRuleAsync(string, string, FirewallPolicyRule, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.AddRuleAsync(project, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceAddRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListNetworkFirewallPoliciesRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            AggregatedListNetworkFirewallPoliciesRequest request = new AggregatedListNetworkFirewallPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<NetworkFirewallPolicyAggregatedList, KeyValuePair<string, FirewallPoliciesScopedList>> response = networkFirewallPoliciesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkFirewallPolicyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, FirewallPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListNetworkFirewallPoliciesRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListNetworkFirewallPoliciesRequest request = new AggregatedListNetworkFirewallPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<NetworkFirewallPolicyAggregatedList, KeyValuePair<string, FirewallPoliciesScopedList>> response = networkFirewallPoliciesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, FirewallPoliciesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkFirewallPolicyAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, FirewallPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, string, int?, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<NetworkFirewallPolicyAggregatedList, KeyValuePair<string, FirewallPoliciesScopedList>> response = networkFirewallPoliciesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (NetworkFirewallPolicyAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, FirewallPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, string, int?, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<NetworkFirewallPolicyAggregatedList, KeyValuePair<string, FirewallPoliciesScopedList>> response = networkFirewallPoliciesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, FirewallPoliciesScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((NetworkFirewallPolicyAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, FirewallPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, FirewallPoliciesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CloneRules</summary>
        public void CloneRulesRequestObject()
        {
            // Snippet: CloneRules(CloneRulesNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            CloneRulesNetworkFirewallPolicyRequest request = new CloneRulesNetworkFirewallPolicyRequest
            {
                SourceFirewallPolicy = "",
                RequestId = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.CloneRules(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceCloneRules(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneRulesAsync</summary>
        public async Task CloneRulesRequestObjectAsync()
        {
            // Snippet: CloneRulesAsync(CloneRulesNetworkFirewallPolicyRequest, CallSettings)
            // Additional: CloneRulesAsync(CloneRulesNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            CloneRulesNetworkFirewallPolicyRequest request = new CloneRulesNetworkFirewallPolicyRequest
            {
                SourceFirewallPolicy = "",
                RequestId = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.CloneRulesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceCloneRulesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneRules</summary>
        public void CloneRules()
        {
            // Snippet: CloneRules(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.CloneRules(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceCloneRules(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneRulesAsync</summary>
        public async Task CloneRulesAsync()
        {
            // Snippet: CloneRulesAsync(string, string, CallSettings)
            // Additional: CloneRulesAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.CloneRulesAsync(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceCloneRulesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteNetworkFirewallPolicyRequest request = new DeleteNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteNetworkFirewallPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNetworkFirewallPolicyRequest request = new DeleteNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.Delete(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.DeleteAsync(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetNetworkFirewallPolicyRequest request = new GetNetworkFirewallPolicyRequest
            {
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicy response = networkFirewallPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetAsync(GetNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetNetworkFirewallPolicyRequest request = new GetNetworkFirewallPolicyRequest
            {
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicy response = await networkFirewallPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicy response = networkFirewallPoliciesClient.Get(project, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicy response = await networkFirewallPoliciesClient.GetAsync(project, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAssociation</summary>
        public void GetAssociationRequestObject()
        {
            // Snippet: GetAssociation(GetAssociationNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetAssociationNetworkFirewallPolicyRequest request = new GetAssociationNetworkFirewallPolicyRequest
            {
                Name = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyAssociation response = networkFirewallPoliciesClient.GetAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssociationAsync</summary>
        public async Task GetAssociationRequestObjectAsync()
        {
            // Snippet: GetAssociationAsync(GetAssociationNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetAssociationAsync(GetAssociationNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetAssociationNetworkFirewallPolicyRequest request = new GetAssociationNetworkFirewallPolicyRequest
            {
                Name = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyAssociation response = await networkFirewallPoliciesClient.GetAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssociation</summary>
        public void GetAssociation()
        {
            // Snippet: GetAssociation(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyAssociation response = networkFirewallPoliciesClient.GetAssociation(project, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAssociationAsync</summary>
        public async Task GetAssociationAsync()
        {
            // Snippet: GetAssociationAsync(string, string, CallSettings)
            // Additional: GetAssociationAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyAssociation response = await networkFirewallPoliciesClient.GetAssociationAsync(project, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyNetworkFirewallPolicyRequest request = new GetIamPolicyNetworkFirewallPolicyRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = networkFirewallPoliciesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyNetworkFirewallPolicyRequest request = new GetIamPolicyNetworkFirewallPolicyRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await networkFirewallPoliciesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = networkFirewallPoliciesClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await networkFirewallPoliciesClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetPacketMirroringRule</summary>
        public void GetPacketMirroringRuleRequestObject()
        {
            // Snippet: GetPacketMirroringRule(GetPacketMirroringRuleNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetPacketMirroringRuleNetworkFirewallPolicyRequest request = new GetPacketMirroringRuleNetworkFirewallPolicyRequest
            {
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyRule response = networkFirewallPoliciesClient.GetPacketMirroringRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetPacketMirroringRuleAsync</summary>
        public async Task GetPacketMirroringRuleRequestObjectAsync()
        {
            // Snippet: GetPacketMirroringRuleAsync(GetPacketMirroringRuleNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetPacketMirroringRuleAsync(GetPacketMirroringRuleNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetPacketMirroringRuleNetworkFirewallPolicyRequest request = new GetPacketMirroringRuleNetworkFirewallPolicyRequest
            {
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyRule response = await networkFirewallPoliciesClient.GetPacketMirroringRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPacketMirroringRule</summary>
        public void GetPacketMirroringRule()
        {
            // Snippet: GetPacketMirroringRule(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyRule response = networkFirewallPoliciesClient.GetPacketMirroringRule(project, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetPacketMirroringRuleAsync</summary>
        public async Task GetPacketMirroringRuleAsync()
        {
            // Snippet: GetPacketMirroringRuleAsync(string, string, CallSettings)
            // Additional: GetPacketMirroringRuleAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyRule response = await networkFirewallPoliciesClient.GetPacketMirroringRuleAsync(project, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRuleRequestObject()
        {
            // Snippet: GetRule(GetRuleNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetRuleNetworkFirewallPolicyRequest request = new GetRuleNetworkFirewallPolicyRequest
            {
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyRule response = networkFirewallPoliciesClient.GetRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleRequestObjectAsync()
        {
            // Snippet: GetRuleAsync(GetRuleNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetRuleAsync(GetRuleNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRuleNetworkFirewallPolicyRequest request = new GetRuleNetworkFirewallPolicyRequest
            {
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyRule response = await networkFirewallPoliciesClient.GetRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRule()
        {
            // Snippet: GetRule(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyRule response = networkFirewallPoliciesClient.GetRule(project, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleAsync()
        {
            // Snippet: GetRuleAsync(string, string, CallSettings)
            // Additional: GetRuleAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyRule response = await networkFirewallPoliciesClient.GetRuleAsync(project, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            InsertNetworkFirewallPolicyRequest request = new InsertNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyResource = new FirewallPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertNetworkFirewallPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertNetworkFirewallPolicyRequest request = new InsertNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyResource = new FirewallPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, FirewallPolicy, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.Insert(project, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, FirewallPolicy, CallSettings)
            // Additional: InsertAsync(string, FirewallPolicy, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.InsertAsync(project, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListNetworkFirewallPoliciesRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            ListNetworkFirewallPoliciesRequest request = new ListNetworkFirewallPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<FirewallPolicyList, FirewallPolicy> response = networkFirewallPoliciesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FirewallPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
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
            // Snippet: ListAsync(ListNetworkFirewallPoliciesRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListNetworkFirewallPoliciesRequest request = new ListNetworkFirewallPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<FirewallPolicyList, FirewallPolicy> response = networkFirewallPoliciesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FirewallPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FirewallPolicyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
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
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<FirewallPolicyList, FirewallPolicy> response = networkFirewallPoliciesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FirewallPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FirewallPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
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
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<FirewallPolicyList, FirewallPolicy> response = networkFirewallPoliciesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FirewallPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FirewallPolicyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FirewallPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FirewallPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FirewallPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            PatchNetworkFirewallPolicyRequest request = new PatchNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchNetworkFirewallPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchNetworkFirewallPolicyRequest request = new PatchNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, FirewallPolicy, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.Patch(project, firewallPolicy, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, FirewallPolicy, CallSettings)
            // Additional: PatchAsync(string, string, FirewallPolicy, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.PatchAsync(project, firewallPolicy, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPacketMirroringRule</summary>
        public void PatchPacketMirroringRuleRequestObject()
        {
            // Snippet: PatchPacketMirroringRule(PatchPacketMirroringRuleNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            PatchPacketMirroringRuleNetworkFirewallPolicyRequest request = new PatchPacketMirroringRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.PatchPacketMirroringRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOncePatchPacketMirroringRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPacketMirroringRuleAsync</summary>
        public async Task PatchPacketMirroringRuleRequestObjectAsync()
        {
            // Snippet: PatchPacketMirroringRuleAsync(PatchPacketMirroringRuleNetworkFirewallPolicyRequest, CallSettings)
            // Additional: PatchPacketMirroringRuleAsync(PatchPacketMirroringRuleNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchPacketMirroringRuleNetworkFirewallPolicyRequest request = new PatchPacketMirroringRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.PatchPacketMirroringRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOncePatchPacketMirroringRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPacketMirroringRule</summary>
        public void PatchPacketMirroringRule()
        {
            // Snippet: PatchPacketMirroringRule(string, string, FirewallPolicyRule, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.PatchPacketMirroringRule(project, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOncePatchPacketMirroringRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchPacketMirroringRuleAsync</summary>
        public async Task PatchPacketMirroringRuleAsync()
        {
            // Snippet: PatchPacketMirroringRuleAsync(string, string, FirewallPolicyRule, CallSettings)
            // Additional: PatchPacketMirroringRuleAsync(string, string, FirewallPolicyRule, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.PatchPacketMirroringRuleAsync(project, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOncePatchPacketMirroringRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchRule</summary>
        public void PatchRuleRequestObject()
        {
            // Snippet: PatchRule(PatchRuleNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRuleNetworkFirewallPolicyRequest request = new PatchRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.PatchRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOncePatchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchRuleAsync</summary>
        public async Task PatchRuleRequestObjectAsync()
        {
            // Snippet: PatchRuleAsync(PatchRuleNetworkFirewallPolicyRequest, CallSettings)
            // Additional: PatchRuleAsync(PatchRuleNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRuleNetworkFirewallPolicyRequest request = new PatchRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.PatchRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOncePatchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchRule</summary>
        public void PatchRule()
        {
            // Snippet: PatchRule(string, string, FirewallPolicyRule, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.PatchRule(project, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOncePatchRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchRuleAsync</summary>
        public async Task PatchRuleAsync()
        {
            // Snippet: PatchRuleAsync(string, string, FirewallPolicyRule, CallSettings)
            // Additional: PatchRuleAsync(string, string, FirewallPolicyRule, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.PatchRuleAsync(project, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOncePatchRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssociation</summary>
        public void RemoveAssociationRequestObject()
        {
            // Snippet: RemoveAssociation(RemoveAssociationNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveAssociationNetworkFirewallPolicyRequest request = new RemoveAssociationNetworkFirewallPolicyRequest
            {
                Name = "",
                RequestId = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.RemoveAssociation(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceRemoveAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssociationAsync</summary>
        public async Task RemoveAssociationRequestObjectAsync()
        {
            // Snippet: RemoveAssociationAsync(RemoveAssociationNetworkFirewallPolicyRequest, CallSettings)
            // Additional: RemoveAssociationAsync(RemoveAssociationNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveAssociationNetworkFirewallPolicyRequest request = new RemoveAssociationNetworkFirewallPolicyRequest
            {
                Name = "",
                RequestId = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.RemoveAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceRemoveAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssociation</summary>
        public void RemoveAssociation()
        {
            // Snippet: RemoveAssociation(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.RemoveAssociation(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceRemoveAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAssociationAsync</summary>
        public async Task RemoveAssociationAsync()
        {
            // Snippet: RemoveAssociationAsync(string, string, CallSettings)
            // Additional: RemoveAssociationAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.RemoveAssociationAsync(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceRemoveAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemovePacketMirroringRule</summary>
        public void RemovePacketMirroringRuleRequestObject()
        {
            // Snippet: RemovePacketMirroringRule(RemovePacketMirroringRuleNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            RemovePacketMirroringRuleNetworkFirewallPolicyRequest request = new RemovePacketMirroringRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.RemovePacketMirroringRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceRemovePacketMirroringRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemovePacketMirroringRuleAsync</summary>
        public async Task RemovePacketMirroringRuleRequestObjectAsync()
        {
            // Snippet: RemovePacketMirroringRuleAsync(RemovePacketMirroringRuleNetworkFirewallPolicyRequest, CallSettings)
            // Additional: RemovePacketMirroringRuleAsync(RemovePacketMirroringRuleNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemovePacketMirroringRuleNetworkFirewallPolicyRequest request = new RemovePacketMirroringRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.RemovePacketMirroringRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceRemovePacketMirroringRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemovePacketMirroringRule</summary>
        public void RemovePacketMirroringRule()
        {
            // Snippet: RemovePacketMirroringRule(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.RemovePacketMirroringRule(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceRemovePacketMirroringRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemovePacketMirroringRuleAsync</summary>
        public async Task RemovePacketMirroringRuleAsync()
        {
            // Snippet: RemovePacketMirroringRuleAsync(string, string, CallSettings)
            // Additional: RemovePacketMirroringRuleAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.RemovePacketMirroringRuleAsync(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceRemovePacketMirroringRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveRule</summary>
        public void RemoveRuleRequestObject()
        {
            // Snippet: RemoveRule(RemoveRuleNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveRuleNetworkFirewallPolicyRequest request = new RemoveRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.RemoveRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceRemoveRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveRuleAsync</summary>
        public async Task RemoveRuleRequestObjectAsync()
        {
            // Snippet: RemoveRuleAsync(RemoveRuleNetworkFirewallPolicyRequest, CallSettings)
            // Additional: RemoveRuleAsync(RemoveRuleNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveRuleNetworkFirewallPolicyRequest request = new RemoveRuleNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.RemoveRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceRemoveRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveRule</summary>
        public void RemoveRule()
        {
            // Snippet: RemoveRule(string, string, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = networkFirewallPoliciesClient.RemoveRule(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = networkFirewallPoliciesClient.PollOnceRemoveRule(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveRuleAsync</summary>
        public async Task RemoveRuleAsync()
        {
            // Snippet: RemoveRuleAsync(string, string, CallSettings)
            // Additional: RemoveRuleAsync(string, string, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await networkFirewallPoliciesClient.RemoveRuleAsync(project, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await networkFirewallPoliciesClient.PollOnceRemoveRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyNetworkFirewallPolicyRequest request = new SetIamPolicyNetworkFirewallPolicyRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = networkFirewallPoliciesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyNetworkFirewallPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyNetworkFirewallPolicyRequest request = new SetIamPolicyNetworkFirewallPolicyRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = await networkFirewallPoliciesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = networkFirewallPoliciesClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await networkFirewallPoliciesClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsNetworkFirewallPolicyRequest request = new TestIamPermissionsNetworkFirewallPolicyRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = networkFirewallPoliciesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsNetworkFirewallPolicyRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsNetworkFirewallPolicyRequest request = new TestIamPermissionsNetworkFirewallPolicyRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await networkFirewallPoliciesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = NetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = networkFirewallPoliciesClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            NetworkFirewallPoliciesClient networkFirewallPoliciesClient = await NetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await networkFirewallPoliciesClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
