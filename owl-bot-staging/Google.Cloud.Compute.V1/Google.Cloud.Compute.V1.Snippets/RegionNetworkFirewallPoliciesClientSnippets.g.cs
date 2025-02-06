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
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegionNetworkFirewallPoliciesClientSnippets
    {
        /// <summary>Snippet for AddAssociation</summary>
        public void AddAssociationRequestObject()
        {
            // Snippet: AddAssociation(AddAssociationRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            AddAssociationRegionNetworkFirewallPolicyRequest request = new AddAssociationRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                ReplaceExistingAssociation = false,
                Project = "",
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.AddAssociation(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceAddAssociation(operationName);
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
            // Snippet: AddAssociationAsync(AddAssociationRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: AddAssociationAsync(AddAssociationRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddAssociationRegionNetworkFirewallPolicyRequest request = new AddAssociationRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                ReplaceExistingAssociation = false,
                Project = "",
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.AddAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceAddAssociationAsync(operationName);
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
            // Snippet: AddAssociation(string, string, string, FirewallPolicyAssociation, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            FirewallPolicyAssociation firewallPolicyAssociationResource = new FirewallPolicyAssociation();
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.AddAssociation(project, region, firewallPolicy, firewallPolicyAssociationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceAddAssociation(operationName);
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
            // Snippet: AddAssociationAsync(string, string, string, FirewallPolicyAssociation, CallSettings)
            // Additional: AddAssociationAsync(string, string, string, FirewallPolicyAssociation, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            FirewallPolicyAssociation firewallPolicyAssociationResource = new FirewallPolicyAssociation();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.AddAssociationAsync(project, region, firewallPolicy, firewallPolicyAssociationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceAddAssociationAsync(operationName);
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
            // Snippet: AddRule(AddRuleRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            AddRuleRegionNetworkFirewallPolicyRequest request = new AddRuleRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                MinPriority = 0,
                MaxPriority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.AddRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceAddRule(operationName);
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
            // Snippet: AddRuleAsync(AddRuleRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: AddRuleAsync(AddRuleRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddRuleRegionNetworkFirewallPolicyRequest request = new AddRuleRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                MinPriority = 0,
                MaxPriority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.AddRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceAddRuleAsync(operationName);
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
            // Snippet: AddRule(string, string, string, FirewallPolicyRule, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.AddRule(project, region, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceAddRule(operationName);
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
            // Snippet: AddRuleAsync(string, string, string, FirewallPolicyRule, CallSettings)
            // Additional: AddRuleAsync(string, string, string, FirewallPolicyRule, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.AddRuleAsync(project, region, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceAddRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneRules</summary>
        public void CloneRulesRequestObject()
        {
            // Snippet: CloneRules(CloneRulesRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            CloneRulesRegionNetworkFirewallPolicyRequest request = new CloneRulesRegionNetworkFirewallPolicyRequest
            {
                SourceFirewallPolicy = "",
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.CloneRules(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceCloneRules(operationName);
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
            // Snippet: CloneRulesAsync(CloneRulesRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: CloneRulesAsync(CloneRulesRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            CloneRulesRegionNetworkFirewallPolicyRequest request = new CloneRulesRegionNetworkFirewallPolicyRequest
            {
                SourceFirewallPolicy = "",
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.CloneRulesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceCloneRulesAsync(operationName);
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
            // Snippet: CloneRules(string, string, string, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.CloneRules(project, region, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceCloneRules(operationName);
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
            // Snippet: CloneRulesAsync(string, string, string, CallSettings)
            // Additional: CloneRulesAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.CloneRulesAsync(project, region, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceCloneRulesAsync(operationName);
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
            // Snippet: Delete(DeleteRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteRegionNetworkFirewallPolicyRequest request = new DeleteRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRegionNetworkFirewallPolicyRequest request = new DeleteRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.Delete(project, region, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.DeleteAsync(project, region, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetRegionNetworkFirewallPolicyRequest request = new GetRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicy response = regionNetworkFirewallPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetAsync(GetRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRegionNetworkFirewallPolicyRequest request = new GetRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicy response = await regionNetworkFirewallPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicy response = regionNetworkFirewallPoliciesClient.Get(project, region, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicy response = await regionNetworkFirewallPoliciesClient.GetAsync(project, region, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAssociation</summary>
        public void GetAssociationRequestObject()
        {
            // Snippet: GetAssociation(GetAssociationRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetAssociationRegionNetworkFirewallPolicyRequest request = new GetAssociationRegionNetworkFirewallPolicyRequest
            {
                Name = "",
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyAssociation response = regionNetworkFirewallPoliciesClient.GetAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssociationAsync</summary>
        public async Task GetAssociationRequestObjectAsync()
        {
            // Snippet: GetAssociationAsync(GetAssociationRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetAssociationAsync(GetAssociationRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetAssociationRegionNetworkFirewallPolicyRequest request = new GetAssociationRegionNetworkFirewallPolicyRequest
            {
                Name = "",
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyAssociation response = await regionNetworkFirewallPoliciesClient.GetAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssociation</summary>
        public void GetAssociation()
        {
            // Snippet: GetAssociation(string, string, string, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyAssociation response = regionNetworkFirewallPoliciesClient.GetAssociation(project, region, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAssociationAsync</summary>
        public async Task GetAssociationAsync()
        {
            // Snippet: GetAssociationAsync(string, string, string, CallSettings)
            // Additional: GetAssociationAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyAssociation response = await regionNetworkFirewallPoliciesClient.GetAssociationAsync(project, region, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveFirewalls</summary>
        public void GetEffectiveFirewallsRequestObject()
        {
            // Snippet: GetEffectiveFirewalls(GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest request = new GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Project = "",
                Network = "",
            };
            // Make the request
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse response = regionNetworkFirewallPoliciesClient.GetEffectiveFirewalls(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveFirewallsAsync</summary>
        public async Task GetEffectiveFirewallsRequestObjectAsync()
        {
            // Snippet: GetEffectiveFirewallsAsync(GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetEffectiveFirewallsAsync(GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest request = new GetEffectiveFirewallsRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Project = "",
                Network = "",
            };
            // Make the request
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse response = await regionNetworkFirewallPoliciesClient.GetEffectiveFirewallsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveFirewalls</summary>
        public void GetEffectiveFirewalls()
        {
            // Snippet: GetEffectiveFirewalls(string, string, string, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string network = "";
            // Make the request
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse response = regionNetworkFirewallPoliciesClient.GetEffectiveFirewalls(project, region, network);
            // End snippet
        }

        /// <summary>Snippet for GetEffectiveFirewallsAsync</summary>
        public async Task GetEffectiveFirewallsAsync()
        {
            // Snippet: GetEffectiveFirewallsAsync(string, string, string, CallSettings)
            // Additional: GetEffectiveFirewallsAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string network = "";
            // Make the request
            RegionNetworkFirewallPoliciesGetEffectiveFirewallsResponse response = await regionNetworkFirewallPoliciesClient.GetEffectiveFirewallsAsync(project, region, network);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRegionNetworkFirewallPolicyRequest request = new GetIamPolicyRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = regionNetworkFirewallPoliciesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRegionNetworkFirewallPolicyRequest request = new GetIamPolicyRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await regionNetworkFirewallPoliciesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = regionNetworkFirewallPoliciesClient.GetIamPolicy(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            // Make the request
            Policy response = await regionNetworkFirewallPoliciesClient.GetIamPolicyAsync(project, region, resource);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRuleRequestObject()
        {
            // Snippet: GetRule(GetRuleRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetRuleRegionNetworkFirewallPolicyRequest request = new GetRuleRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyRule response = regionNetworkFirewallPoliciesClient.GetRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleRequestObjectAsync()
        {
            // Snippet: GetRuleAsync(GetRuleRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: GetRuleAsync(GetRuleRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRuleRegionNetworkFirewallPolicyRequest request = new GetRuleRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyRule response = await regionNetworkFirewallPoliciesClient.GetRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRule()
        {
            // Snippet: GetRule(string, string, string, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyRule response = regionNetworkFirewallPoliciesClient.GetRule(project, region, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleAsync()
        {
            // Snippet: GetRuleAsync(string, string, string, CallSettings)
            // Additional: GetRuleAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyRule response = await regionNetworkFirewallPoliciesClient.GetRuleAsync(project, region, firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            InsertRegionNetworkFirewallPolicyRequest request = new InsertRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicyResource = new FirewallPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertRegionNetworkFirewallPolicyRequest request = new InsertRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicyResource = new FirewallPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, FirewallPolicy, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.Insert(project, region, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, FirewallPolicy, CallSettings)
            // Additional: InsertAsync(string, string, FirewallPolicy, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.InsertAsync(project, region, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListRegionNetworkFirewallPoliciesRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            ListRegionNetworkFirewallPoliciesRequest request = new ListRegionNetworkFirewallPoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<FirewallPolicyList, FirewallPolicy> response = regionNetworkFirewallPoliciesClient.List(request);

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
            // Snippet: ListAsync(ListRegionNetworkFirewallPoliciesRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListRegionNetworkFirewallPoliciesRequest request = new ListRegionNetworkFirewallPoliciesRequest
            {
                Region = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<FirewallPolicyList, FirewallPolicy> response = regionNetworkFirewallPoliciesClient.ListAsync(request);

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
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedEnumerable<FirewallPolicyList, FirewallPolicy> response = regionNetworkFirewallPoliciesClient.List(project, region);

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
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<FirewallPolicyList, FirewallPolicy> response = regionNetworkFirewallPoliciesClient.ListAsync(project, region);

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
            // Snippet: Patch(PatchRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRegionNetworkFirewallPolicyRequest request = new PatchRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRegionNetworkFirewallPolicyRequest request = new PatchRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, string, FirewallPolicy, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.Patch(project, region, firewallPolicy, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, string, FirewallPolicy, CallSettings)
            // Additional: PatchAsync(string, string, string, FirewallPolicy, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.PatchAsync(project, region, firewallPolicy, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: PatchRule(PatchRuleRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRuleRegionNetworkFirewallPolicyRequest request = new PatchRuleRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.PatchRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOncePatchRule(operationName);
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
            // Snippet: PatchRuleAsync(PatchRuleRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: PatchRuleAsync(PatchRuleRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRuleRegionNetworkFirewallPolicyRequest request = new PatchRuleRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.PatchRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOncePatchRuleAsync(operationName);
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
            // Snippet: PatchRule(string, string, string, FirewallPolicyRule, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.PatchRule(project, region, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOncePatchRule(operationName);
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
            // Snippet: PatchRuleAsync(string, string, string, FirewallPolicyRule, CallSettings)
            // Additional: PatchRuleAsync(string, string, string, FirewallPolicyRule, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.PatchRuleAsync(project, region, firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOncePatchRuleAsync(operationName);
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
            // Snippet: RemoveAssociation(RemoveAssociationRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveAssociationRegionNetworkFirewallPolicyRequest request = new RemoveAssociationRegionNetworkFirewallPolicyRequest
            {
                Name = "",
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.RemoveAssociation(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceRemoveAssociation(operationName);
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
            // Snippet: RemoveAssociationAsync(RemoveAssociationRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: RemoveAssociationAsync(RemoveAssociationRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveAssociationRegionNetworkFirewallPolicyRequest request = new RemoveAssociationRegionNetworkFirewallPolicyRequest
            {
                Name = "",
                RequestId = "",
                Region = "",
                Project = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.RemoveAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceRemoveAssociationAsync(operationName);
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
            // Snippet: RemoveAssociation(string, string, string, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.RemoveAssociation(project, region, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceRemoveAssociation(operationName);
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
            // Snippet: RemoveAssociationAsync(string, string, string, CallSettings)
            // Additional: RemoveAssociationAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.RemoveAssociationAsync(project, region, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceRemoveAssociationAsync(operationName);
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
            // Snippet: RemoveRule(RemoveRuleRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveRuleRegionNetworkFirewallPolicyRequest request = new RemoveRuleRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.RemoveRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceRemoveRule(operationName);
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
            // Snippet: RemoveRuleAsync(RemoveRuleRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: RemoveRuleAsync(RemoveRuleRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveRuleRegionNetworkFirewallPolicyRequest request = new RemoveRuleRegionNetworkFirewallPolicyRequest
            {
                RequestId = "",
                Region = "",
                Project = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.RemoveRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceRemoveRuleAsync(operationName);
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
            // Snippet: RemoveRule(string, string, string, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = regionNetworkFirewallPoliciesClient.RemoveRule(project, region, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = regionNetworkFirewallPoliciesClient.PollOnceRemoveRule(operationName);
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
            // Snippet: RemoveRuleAsync(string, string, string, CallSettings)
            // Additional: RemoveRuleAsync(string, string, string, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await regionNetworkFirewallPoliciesClient.RemoveRuleAsync(project, region, firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await regionNetworkFirewallPoliciesClient.PollOnceRemoveRuleAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRegionNetworkFirewallPolicyRequest request = new SetIamPolicyRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = regionNetworkFirewallPoliciesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRegionNetworkFirewallPolicyRequest request = new SetIamPolicyRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                RegionSetPolicyRequestResource = new RegionSetPolicyRequest(),
            };
            // Make the request
            Policy response = await regionNetworkFirewallPoliciesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = regionNetworkFirewallPoliciesClient.SetIamPolicy(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, RegionSetPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            RegionSetPolicyRequest regionSetPolicyRequestResource = new RegionSetPolicyRequest();
            // Make the request
            Policy response = await regionNetworkFirewallPoliciesClient.SetIamPolicyAsync(project, region, resource, regionSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRegionNetworkFirewallPolicyRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRegionNetworkFirewallPolicyRequest request = new TestIamPermissionsRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = regionNetworkFirewallPoliciesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRegionNetworkFirewallPolicyRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRegionNetworkFirewallPolicyRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRegionNetworkFirewallPolicyRequest request = new TestIamPermissionsRegionNetworkFirewallPolicyRequest
            {
                Region = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await regionNetworkFirewallPoliciesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = RegionNetworkFirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = regionNetworkFirewallPoliciesClient.TestIamPermissions(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            RegionNetworkFirewallPoliciesClient regionNetworkFirewallPoliciesClient = await RegionNetworkFirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string region = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await regionNetworkFirewallPoliciesClient.TestIamPermissionsAsync(project, region, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
