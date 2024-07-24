// Copyright 2024 Google LLC
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
    public sealed class AllGeneratedFirewallPoliciesClientSnippets
    {
        /// <summary>Snippet for AddAssociation</summary>
        public void AddAssociationRequestObject()
        {
            // Snippet: AddAssociation(AddAssociationFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            AddAssociationFirewallPolicyRequest request = new AddAssociationFirewallPolicyRequest
            {
                RequestId = "",
                ReplaceExistingAssociation = false,
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.AddAssociation(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceAddAssociation(operationName);
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
            // Snippet: AddAssociationAsync(AddAssociationFirewallPolicyRequest, CallSettings)
            // Additional: AddAssociationAsync(AddAssociationFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddAssociationFirewallPolicyRequest request = new AddAssociationFirewallPolicyRequest
            {
                RequestId = "",
                ReplaceExistingAssociation = false,
                FirewallPolicyAssociationResource = new FirewallPolicyAssociation(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.AddAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceAddAssociationAsync(operationName);
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
            // Snippet: AddAssociation(string, FirewallPolicyAssociation, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            FirewallPolicyAssociation firewallPolicyAssociationResource = new FirewallPolicyAssociation();
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.AddAssociation(firewallPolicy, firewallPolicyAssociationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceAddAssociation(operationName);
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
            // Snippet: AddAssociationAsync(string, FirewallPolicyAssociation, CallSettings)
            // Additional: AddAssociationAsync(string, FirewallPolicyAssociation, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            FirewallPolicyAssociation firewallPolicyAssociationResource = new FirewallPolicyAssociation();
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.AddAssociationAsync(firewallPolicy, firewallPolicyAssociationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceAddAssociationAsync(operationName);
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
            // Snippet: AddRule(AddRuleFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            AddRuleFirewallPolicyRequest request = new AddRuleFirewallPolicyRequest
            {
                RequestId = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.AddRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceAddRule(operationName);
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
            // Snippet: AddRuleAsync(AddRuleFirewallPolicyRequest, CallSettings)
            // Additional: AddRuleAsync(AddRuleFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddRuleFirewallPolicyRequest request = new AddRuleFirewallPolicyRequest
            {
                RequestId = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.AddRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceAddRuleAsync(operationName);
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
            // Snippet: AddRule(string, FirewallPolicyRule, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.AddRule(firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceAddRule(operationName);
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
            // Snippet: AddRuleAsync(string, FirewallPolicyRule, CallSettings)
            // Additional: AddRuleAsync(string, FirewallPolicyRule, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.AddRuleAsync(firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceAddRuleAsync(operationName);
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
            // Snippet: CloneRules(CloneRulesFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            CloneRulesFirewallPolicyRequest request = new CloneRulesFirewallPolicyRequest
            {
                SourceFirewallPolicy = "",
                RequestId = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.CloneRules(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceCloneRules(operationName);
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
            // Snippet: CloneRulesAsync(CloneRulesFirewallPolicyRequest, CallSettings)
            // Additional: CloneRulesAsync(CloneRulesFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            CloneRulesFirewallPolicyRequest request = new CloneRulesFirewallPolicyRequest
            {
                SourceFirewallPolicy = "",
                RequestId = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.CloneRulesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceCloneRulesAsync(operationName);
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
            // Snippet: CloneRules(string, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.CloneRules(firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceCloneRules(operationName);
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
            // Snippet: CloneRulesAsync(string, CallSettings)
            // Additional: CloneRulesAsync(string, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.CloneRulesAsync(firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceCloneRulesAsync(operationName);
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
            // Snippet: Delete(DeleteFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteFirewallPolicyRequest request = new DeleteFirewallPolicyRequest
            {
                RequestId = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteFirewallPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFirewallPolicyRequest request = new DeleteFirewallPolicyRequest
            {
                RequestId = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.Delete(firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, CallSettings)
            // Additional: DeleteAsync(string, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.DeleteAsync(firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetFirewallPolicyRequest request = new GetFirewallPolicyRequest { FirewallPolicy = "", };
            // Make the request
            FirewallPolicy response = firewallPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetFirewallPolicyRequest, CallSettings)
            // Additional: GetAsync(GetFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetFirewallPolicyRequest request = new GetFirewallPolicyRequest { FirewallPolicy = "", };
            // Make the request
            FirewallPolicy response = await firewallPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            FirewallPolicy response = firewallPoliciesClient.Get(firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, CallSettings)
            // Additional: GetAsync(string, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            FirewallPolicy response = await firewallPoliciesClient.GetAsync(firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAssociation</summary>
        public void GetAssociationRequestObject()
        {
            // Snippet: GetAssociation(GetAssociationFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetAssociationFirewallPolicyRequest request = new GetAssociationFirewallPolicyRequest
            {
                Name = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyAssociation response = firewallPoliciesClient.GetAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssociationAsync</summary>
        public async Task GetAssociationRequestObjectAsync()
        {
            // Snippet: GetAssociationAsync(GetAssociationFirewallPolicyRequest, CallSettings)
            // Additional: GetAssociationAsync(GetAssociationFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetAssociationFirewallPolicyRequest request = new GetAssociationFirewallPolicyRequest
            {
                Name = "",
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyAssociation response = await firewallPoliciesClient.GetAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssociation</summary>
        public void GetAssociation()
        {
            // Snippet: GetAssociation(string, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyAssociation response = firewallPoliciesClient.GetAssociation(firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAssociationAsync</summary>
        public async Task GetAssociationAsync()
        {
            // Snippet: GetAssociationAsync(string, CallSettings)
            // Additional: GetAssociationAsync(string, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyAssociation response = await firewallPoliciesClient.GetAssociationAsync(firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyFirewallPolicyRequest request = new GetIamPolicyFirewallPolicyRequest
            {
                Resource = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = firewallPoliciesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyFirewallPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyFirewallPolicyRequest request = new GetIamPolicyFirewallPolicyRequest
            {
                Resource = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await firewallPoliciesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string resource = "";
            // Make the request
            Policy response = firewallPoliciesClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "";
            // Make the request
            Policy response = await firewallPoliciesClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRuleRequestObject()
        {
            // Snippet: GetRule(GetRuleFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyRule response = firewallPoliciesClient.GetRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleRequestObjectAsync()
        {
            // Snippet: GetRuleAsync(GetRuleFirewallPolicyRequest, CallSettings)
            // Additional: GetRuleAsync(GetRuleFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRuleFirewallPolicyRequest request = new GetRuleFirewallPolicyRequest
            {
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            FirewallPolicyRule response = await firewallPoliciesClient.GetRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRule()
        {
            // Snippet: GetRule(string, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyRule response = firewallPoliciesClient.GetRule(firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleAsync()
        {
            // Snippet: GetRuleAsync(string, CallSettings)
            // Additional: GetRuleAsync(string, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            FirewallPolicyRule response = await firewallPoliciesClient.GetRuleAsync(firewallPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            InsertFirewallPolicyRequest request = new InsertFirewallPolicyRequest
            {
                RequestId = "",
                ParentId = "",
                FirewallPolicyResource = new FirewallPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertFirewallPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertFirewallPolicyRequest request = new InsertFirewallPolicyRequest
            {
                RequestId = "",
                ParentId = "",
                FirewallPolicyResource = new FirewallPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceInsertAsync(operationName);
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
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string parentId = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.Insert(parentId, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceInsert(operationName);
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
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string parentId = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.InsertAsync(parentId, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListFirewallPoliciesRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            ListFirewallPoliciesRequest request = new ListFirewallPoliciesRequest
            {
                OrderBy = "",
                Filter = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<FirewallPolicyList, FirewallPolicy> response = firewallPoliciesClient.List(request);

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
            // Snippet: ListAsync(ListFirewallPoliciesRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListFirewallPoliciesRequest request = new ListFirewallPoliciesRequest
            {
                OrderBy = "",
                Filter = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<FirewallPolicyList, FirewallPolicy> response = firewallPoliciesClient.ListAsync(request);

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
            // Snippet: List(string, int?, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Make the request
            PagedEnumerable<FirewallPolicyList, FirewallPolicy> response = firewallPoliciesClient.List();

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
            // Snippet: ListAsync(string, int?, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Make the request
            PagedAsyncEnumerable<FirewallPolicyList, FirewallPolicy> response = firewallPoliciesClient.ListAsync();

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

        /// <summary>Snippet for ListAssociations</summary>
        public void ListAssociationsRequestObject()
        {
            // Snippet: ListAssociations(ListAssociationsFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            ListAssociationsFirewallPolicyRequest request = new ListAssociationsFirewallPolicyRequest { TargetResource = "", };
            // Make the request
            FirewallPoliciesListAssociationsResponse response = firewallPoliciesClient.ListAssociations(request);
            // End snippet
        }

        /// <summary>Snippet for ListAssociationsAsync</summary>
        public async Task ListAssociationsRequestObjectAsync()
        {
            // Snippet: ListAssociationsAsync(ListAssociationsFirewallPolicyRequest, CallSettings)
            // Additional: ListAssociationsAsync(ListAssociationsFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListAssociationsFirewallPolicyRequest request = new ListAssociationsFirewallPolicyRequest { TargetResource = "", };
            // Make the request
            FirewallPoliciesListAssociationsResponse response = await firewallPoliciesClient.ListAssociationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListAssociations</summary>
        public void ListAssociations()
        {
            // Snippet: ListAssociations(CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Make the request
            FirewallPoliciesListAssociationsResponse response = firewallPoliciesClient.ListAssociations();
            // End snippet
        }

        /// <summary>Snippet for ListAssociationsAsync</summary>
        public async Task ListAssociationsAsync()
        {
            // Snippet: ListAssociationsAsync(CallSettings)
            // Additional: ListAssociationsAsync(CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Make the request
            FirewallPoliciesListAssociationsResponse response = await firewallPoliciesClient.ListAssociationsAsync();
            // End snippet
        }

        /// <summary>Snippet for Move</summary>
        public void MoveRequestObject()
        {
            // Snippet: Move(MoveFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            MoveFirewallPolicyRequest request = new MoveFirewallPolicyRequest
            {
                RequestId = "",
                ParentId = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.Move(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceMove(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveAsync</summary>
        public async Task MoveRequestObjectAsync()
        {
            // Snippet: MoveAsync(MoveFirewallPolicyRequest, CallSettings)
            // Additional: MoveAsync(MoveFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            MoveFirewallPolicyRequest request = new MoveFirewallPolicyRequest
            {
                RequestId = "",
                ParentId = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.MoveAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceMoveAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Move</summary>
        public void Move()
        {
            // Snippet: Move(string, string, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            string parentId = "";
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.Move(firewallPolicy, parentId);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceMove(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MoveAsync</summary>
        public async Task MoveAsync()
        {
            // Snippet: MoveAsync(string, string, CallSettings)
            // Additional: MoveAsync(string, string, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            string parentId = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.MoveAsync(firewallPolicy, parentId);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceMoveAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            PatchFirewallPolicyRequest request = new PatchFirewallPolicyRequest
            {
                RequestId = "",
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchFirewallPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchFirewallPolicyRequest request = new PatchFirewallPolicyRequest
            {
                RequestId = "",
                FirewallPolicyResource = new FirewallPolicy(),
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, FirewallPolicy, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.Patch(firewallPolicy, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, FirewallPolicy, CallSettings)
            // Additional: PatchAsync(string, FirewallPolicy, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            FirewallPolicy firewallPolicyResource = new FirewallPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.PatchAsync(firewallPolicy, firewallPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: PatchRule(PatchRuleFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRuleFirewallPolicyRequest request = new PatchRuleFirewallPolicyRequest
            {
                RequestId = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.PatchRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOncePatchRule(operationName);
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
            // Snippet: PatchRuleAsync(PatchRuleFirewallPolicyRequest, CallSettings)
            // Additional: PatchRuleAsync(PatchRuleFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRuleFirewallPolicyRequest request = new PatchRuleFirewallPolicyRequest
            {
                RequestId = "",
                FirewallPolicyRuleResource = new FirewallPolicyRule(),
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.PatchRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOncePatchRuleAsync(operationName);
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
            // Snippet: PatchRule(string, FirewallPolicyRule, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.PatchRule(firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOncePatchRule(operationName);
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
            // Snippet: PatchRuleAsync(string, FirewallPolicyRule, CallSettings)
            // Additional: PatchRuleAsync(string, FirewallPolicyRule, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            FirewallPolicyRule firewallPolicyRuleResource = new FirewallPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.PatchRuleAsync(firewallPolicy, firewallPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOncePatchRuleAsync(operationName);
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
            // Snippet: RemoveAssociation(RemoveAssociationFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveAssociationFirewallPolicyRequest request = new RemoveAssociationFirewallPolicyRequest
            {
                Name = "",
                RequestId = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.RemoveAssociation(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceRemoveAssociation(operationName);
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
            // Snippet: RemoveAssociationAsync(RemoveAssociationFirewallPolicyRequest, CallSettings)
            // Additional: RemoveAssociationAsync(RemoveAssociationFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveAssociationFirewallPolicyRequest request = new RemoveAssociationFirewallPolicyRequest
            {
                Name = "",
                RequestId = "",
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.RemoveAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceRemoveAssociationAsync(operationName);
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
            // Snippet: RemoveAssociation(string, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.RemoveAssociation(firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceRemoveAssociation(operationName);
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
            // Snippet: RemoveAssociationAsync(string, CallSettings)
            // Additional: RemoveAssociationAsync(string, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.RemoveAssociationAsync(firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceRemoveAssociationAsync(operationName);
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
            // Snippet: RemoveRule(RemoveRuleFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveRuleFirewallPolicyRequest request = new RemoveRuleFirewallPolicyRequest
            {
                RequestId = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.RemoveRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceRemoveRule(operationName);
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
            // Snippet: RemoveRuleAsync(RemoveRuleFirewallPolicyRequest, CallSettings)
            // Additional: RemoveRuleAsync(RemoveRuleFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveRuleFirewallPolicyRequest request = new RemoveRuleFirewallPolicyRequest
            {
                RequestId = "",
                Priority = 0,
                FirewallPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.RemoveRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceRemoveRuleAsync(operationName);
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
            // Snippet: RemoveRule(string, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = firewallPoliciesClient.RemoveRule(firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = firewallPoliciesClient.PollOnceRemoveRule(operationName);
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
            // Snippet: RemoveRuleAsync(string, CallSettings)
            // Additional: RemoveRuleAsync(string, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string firewallPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await firewallPoliciesClient.RemoveRuleAsync(firewallPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await firewallPoliciesClient.PollOnceRemoveRuleAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyFirewallPolicyRequest request = new SetIamPolicyFirewallPolicyRequest
            {
                GlobalOrganizationSetPolicyRequestResource = new GlobalOrganizationSetPolicyRequest(),
                Resource = "",
            };
            // Make the request
            Policy response = firewallPoliciesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyFirewallPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyFirewallPolicyRequest request = new SetIamPolicyFirewallPolicyRequest
            {
                GlobalOrganizationSetPolicyRequestResource = new GlobalOrganizationSetPolicyRequest(),
                Resource = "",
            };
            // Make the request
            Policy response = await firewallPoliciesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, GlobalOrganizationSetPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string resource = "";
            GlobalOrganizationSetPolicyRequest globalOrganizationSetPolicyRequestResource = new GlobalOrganizationSetPolicyRequest();
            // Make the request
            Policy response = firewallPoliciesClient.SetIamPolicy(resource, globalOrganizationSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, GlobalOrganizationSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, GlobalOrganizationSetPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "";
            GlobalOrganizationSetPolicyRequest globalOrganizationSetPolicyRequestResource = new GlobalOrganizationSetPolicyRequest();
            // Make the request
            Policy response = await firewallPoliciesClient.SetIamPolicyAsync(resource, globalOrganizationSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsFirewallPolicyRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsFirewallPolicyRequest request = new TestIamPermissionsFirewallPolicyRequest
            {
                Resource = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = firewallPoliciesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsFirewallPolicyRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsFirewallPolicyRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsFirewallPolicyRequest request = new TestIamPermissionsFirewallPolicyRequest
            {
                Resource = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await firewallPoliciesClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, TestPermissionsRequest, CallSettings)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = FirewallPoliciesClient.Create();
            // Initialize request argument(s)
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = firewallPoliciesClient.TestIamPermissions(resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, TestPermissionsRequest, CancellationToken)
            // Create client
            FirewallPoliciesClient firewallPoliciesClient = await FirewallPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await firewallPoliciesClient.TestIamPermissionsAsync(resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
