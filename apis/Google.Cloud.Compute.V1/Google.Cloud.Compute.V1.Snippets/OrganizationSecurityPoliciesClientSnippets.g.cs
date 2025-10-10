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
    public sealed class AllGeneratedOrganizationSecurityPoliciesClientSnippets
    {
        /// <summary>Snippet for AddAssociation</summary>
        public void AddAssociationRequestObject()
        {
            // Snippet: AddAssociation(AddAssociationOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            AddAssociationOrganizationSecurityPolicyRequest request = new AddAssociationOrganizationSecurityPolicyRequest
            {
                SecurityPolicyAssociationResource = new SecurityPolicyAssociation(),
                RequestId = "",
                SecurityPolicy = "",
                ReplaceExistingAssociation = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.AddAssociation(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceAddAssociation(operationName);
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
            // Snippet: AddAssociationAsync(AddAssociationOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: AddAssociationAsync(AddAssociationOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddAssociationOrganizationSecurityPolicyRequest request = new AddAssociationOrganizationSecurityPolicyRequest
            {
                SecurityPolicyAssociationResource = new SecurityPolicyAssociation(),
                RequestId = "",
                SecurityPolicy = "",
                ReplaceExistingAssociation = false,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.AddAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceAddAssociationAsync(operationName);
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
            // Snippet: AddAssociation(string, SecurityPolicyAssociation, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            SecurityPolicyAssociation securityPolicyAssociationResource = new SecurityPolicyAssociation();
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.AddAssociation(securityPolicy, securityPolicyAssociationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceAddAssociation(operationName);
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
            // Snippet: AddAssociationAsync(string, SecurityPolicyAssociation, CallSettings)
            // Additional: AddAssociationAsync(string, SecurityPolicyAssociation, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            SecurityPolicyAssociation securityPolicyAssociationResource = new SecurityPolicyAssociation();
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.AddAssociationAsync(securityPolicy, securityPolicyAssociationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceAddAssociationAsync(operationName);
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
            // Snippet: AddRule(AddRuleOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            AddRuleOrganizationSecurityPolicyRequest request = new AddRuleOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.AddRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceAddRule(operationName);
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
            // Snippet: AddRuleAsync(AddRuleOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: AddRuleAsync(AddRuleOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AddRuleOrganizationSecurityPolicyRequest request = new AddRuleOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.AddRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceAddRuleAsync(operationName);
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
            // Snippet: AddRule(string, SecurityPolicyRule, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.AddRule(securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceAddRule(operationName);
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
            // Snippet: AddRuleAsync(string, SecurityPolicyRule, CallSettings)
            // Additional: AddRuleAsync(string, SecurityPolicyRule, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.AddRuleAsync(securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceAddRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyRules</summary>
        public void CopyRulesRequestObject()
        {
            // Snippet: CopyRules(CopyRulesOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            CopyRulesOrganizationSecurityPolicyRequest request = new CopyRulesOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SourceSecurityPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.CopyRules(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceCopyRules(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyRulesAsync</summary>
        public async Task CopyRulesRequestObjectAsync()
        {
            // Snippet: CopyRulesAsync(CopyRulesOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: CopyRulesAsync(CopyRulesOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            CopyRulesOrganizationSecurityPolicyRequest request = new CopyRulesOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SourceSecurityPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.CopyRulesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceCopyRulesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyRules</summary>
        public void CopyRules()
        {
            // Snippet: CopyRules(string, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.CopyRules(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceCopyRules(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyRulesAsync</summary>
        public async Task CopyRulesAsync()
        {
            // Snippet: CopyRulesAsync(string, CallSettings)
            // Additional: CopyRulesAsync(string, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.CopyRulesAsync(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceCopyRulesAsync(operationName);
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
            // Snippet: Delete(DeleteOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteOrganizationSecurityPolicyRequest request = new DeleteOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOrganizationSecurityPolicyRequest request = new DeleteOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceDeleteAsync(operationName);
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
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.Delete(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceDelete(operationName);
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
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.DeleteAsync(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            GetOrganizationSecurityPolicyRequest request = new GetOrganizationSecurityPolicyRequest { SecurityPolicy = "", };
            // Make the request
            SecurityPolicy response = organizationSecurityPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: GetAsync(GetOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetOrganizationSecurityPolicyRequest request = new GetOrganizationSecurityPolicyRequest { SecurityPolicy = "", };
            // Make the request
            SecurityPolicy response = await organizationSecurityPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            SecurityPolicy response = organizationSecurityPoliciesClient.Get(securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, CallSettings)
            // Additional: GetAsync(string, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            SecurityPolicy response = await organizationSecurityPoliciesClient.GetAsync(securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAssociation</summary>
        public void GetAssociationRequestObject()
        {
            // Snippet: GetAssociation(GetAssociationOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            GetAssociationOrganizationSecurityPolicyRequest request = new GetAssociationOrganizationSecurityPolicyRequest
            {
                Name = "",
                SecurityPolicy = "",
            };
            // Make the request
            SecurityPolicyAssociation response = organizationSecurityPoliciesClient.GetAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssociationAsync</summary>
        public async Task GetAssociationRequestObjectAsync()
        {
            // Snippet: GetAssociationAsync(GetAssociationOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: GetAssociationAsync(GetAssociationOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetAssociationOrganizationSecurityPolicyRequest request = new GetAssociationOrganizationSecurityPolicyRequest
            {
                Name = "",
                SecurityPolicy = "",
            };
            // Make the request
            SecurityPolicyAssociation response = await organizationSecurityPoliciesClient.GetAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssociation</summary>
        public void GetAssociation()
        {
            // Snippet: GetAssociation(string, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            SecurityPolicyAssociation response = organizationSecurityPoliciesClient.GetAssociation(securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAssociationAsync</summary>
        public async Task GetAssociationAsync()
        {
            // Snippet: GetAssociationAsync(string, CallSettings)
            // Additional: GetAssociationAsync(string, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            SecurityPolicyAssociation response = await organizationSecurityPoliciesClient.GetAssociationAsync(securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRuleRequestObject()
        {
            // Snippet: GetRule(GetRuleOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            GetRuleOrganizationSecurityPolicyRequest request = new GetRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Priority = 0,
            };
            // Make the request
            SecurityPolicyRule response = organizationSecurityPoliciesClient.GetRule(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleRequestObjectAsync()
        {
            // Snippet: GetRuleAsync(GetRuleOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: GetRuleAsync(GetRuleOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetRuleOrganizationSecurityPolicyRequest request = new GetRuleOrganizationSecurityPolicyRequest
            {
                SecurityPolicy = "",
                Priority = 0,
            };
            // Make the request
            SecurityPolicyRule response = await organizationSecurityPoliciesClient.GetRuleAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRule</summary>
        public void GetRule()
        {
            // Snippet: GetRule(string, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            SecurityPolicyRule response = organizationSecurityPoliciesClient.GetRule(securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetRuleAsync</summary>
        public async Task GetRuleAsync()
        {
            // Snippet: GetRuleAsync(string, CallSettings)
            // Additional: GetRuleAsync(string, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            SecurityPolicyRule response = await organizationSecurityPoliciesClient.GetRuleAsync(securityPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            InsertOrganizationSecurityPolicyRequest request = new InsertOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicyResource = new SecurityPolicy(),
                ParentId = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertOrganizationSecurityPolicyRequest request = new InsertOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicyResource = new SecurityPolicy(),
                ParentId = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(SecurityPolicy, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.Insert(securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(SecurityPolicy, CallSettings)
            // Additional: InsertAsync(SecurityPolicy, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.InsertAsync(securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListOrganizationSecurityPoliciesRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            ListOrganizationSecurityPoliciesRequest request = new ListOrganizationSecurityPoliciesRequest
            {
                OrderBy = "",
                Filter = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<SecurityPolicyList, SecurityPolicy> response = organizationSecurityPoliciesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SecurityPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityPolicy item in singlePage)
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
            // Snippet: ListAsync(ListOrganizationSecurityPoliciesRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListOrganizationSecurityPoliciesRequest request = new ListOrganizationSecurityPoliciesRequest
            {
                OrderBy = "",
                Filter = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<SecurityPolicyList, SecurityPolicy> response = organizationSecurityPoliciesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SecurityPolicyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityPolicy item in singlePage)
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
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Make the request
            PagedEnumerable<SecurityPolicyList, SecurityPolicy> response = organizationSecurityPoliciesClient.List();

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SecurityPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SecurityPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityPolicy item in singlePage)
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
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Make the request
            PagedAsyncEnumerable<SecurityPolicyList, SecurityPolicy> response = organizationSecurityPoliciesClient.ListAsync();

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SecurityPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SecurityPolicyList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SecurityPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SecurityPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SecurityPolicy item in singlePage)
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
            // Snippet: ListAssociations(ListAssociationsOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            ListAssociationsOrganizationSecurityPolicyRequest request = new ListAssociationsOrganizationSecurityPolicyRequest { TargetResource = "", };
            // Make the request
            OrganizationSecurityPoliciesListAssociationsResponse response = organizationSecurityPoliciesClient.ListAssociations(request);
            // End snippet
        }

        /// <summary>Snippet for ListAssociationsAsync</summary>
        public async Task ListAssociationsRequestObjectAsync()
        {
            // Snippet: ListAssociationsAsync(ListAssociationsOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: ListAssociationsAsync(ListAssociationsOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListAssociationsOrganizationSecurityPolicyRequest request = new ListAssociationsOrganizationSecurityPolicyRequest { TargetResource = "", };
            // Make the request
            OrganizationSecurityPoliciesListAssociationsResponse response = await organizationSecurityPoliciesClient.ListAssociationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListAssociations</summary>
        public void ListAssociations()
        {
            // Snippet: ListAssociations(CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Make the request
            OrganizationSecurityPoliciesListAssociationsResponse response = organizationSecurityPoliciesClient.ListAssociations();
            // End snippet
        }

        /// <summary>Snippet for ListAssociationsAsync</summary>
        public async Task ListAssociationsAsync()
        {
            // Snippet: ListAssociationsAsync(CallSettings)
            // Additional: ListAssociationsAsync(CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Make the request
            OrganizationSecurityPoliciesListAssociationsResponse response = await organizationSecurityPoliciesClient.ListAssociationsAsync();
            // End snippet
        }

        /// <summary>Snippet for ListPreconfiguredExpressionSets</summary>
        public void ListPreconfiguredExpressionSetsRequestObject()
        {
            // Snippet: ListPreconfiguredExpressionSets(ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest request = new ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Filter = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = organizationSecurityPoliciesClient.ListPreconfiguredExpressionSets(request);
            // End snippet
        }

        /// <summary>Snippet for ListPreconfiguredExpressionSetsAsync</summary>
        public async Task ListPreconfiguredExpressionSetsRequestObjectAsync()
        {
            // Snippet: ListPreconfiguredExpressionSetsAsync(ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest, CallSettings)
            // Additional: ListPreconfiguredExpressionSetsAsync(ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest request = new ListPreconfiguredExpressionSetsOrganizationSecurityPoliciesRequest
            {
                PageToken = "",
                MaxResults = 0U,
                OrderBy = "",
                Filter = "",
                ParentId = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = await organizationSecurityPoliciesClient.ListPreconfiguredExpressionSetsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListPreconfiguredExpressionSets</summary>
        public void ListPreconfiguredExpressionSets()
        {
            // Snippet: ListPreconfiguredExpressionSets(CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Make the request
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = organizationSecurityPoliciesClient.ListPreconfiguredExpressionSets();
            // End snippet
        }

        /// <summary>Snippet for ListPreconfiguredExpressionSetsAsync</summary>
        public async Task ListPreconfiguredExpressionSetsAsync()
        {
            // Snippet: ListPreconfiguredExpressionSetsAsync(CallSettings)
            // Additional: ListPreconfiguredExpressionSetsAsync(CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Make the request
            SecurityPoliciesListPreconfiguredExpressionSetsResponse response = await organizationSecurityPoliciesClient.ListPreconfiguredExpressionSetsAsync();
            // End snippet
        }

        /// <summary>Snippet for Move</summary>
        public void MoveRequestObject()
        {
            // Snippet: Move(MoveOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            MoveOrganizationSecurityPolicyRequest request = new MoveOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                ParentId = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.Move(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceMove(operationName);
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
            // Snippet: MoveAsync(MoveOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: MoveAsync(MoveOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            MoveOrganizationSecurityPolicyRequest request = new MoveOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                ParentId = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.MoveAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceMoveAsync(operationName);
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
            // Snippet: Move(string, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.Move(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceMove(operationName);
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
            // Snippet: MoveAsync(string, CallSettings)
            // Additional: MoveAsync(string, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.MoveAsync(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceMoveAsync(operationName);
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
            // Snippet: Patch(PatchOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            PatchOrganizationSecurityPolicyRequest request = new PatchOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SecurityPolicyResource = new SecurityPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: PatchAsync(PatchOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchOrganizationSecurityPolicyRequest request = new PatchOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SecurityPolicyResource = new SecurityPolicy(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, SecurityPolicy, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.Patch(securityPolicy, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, SecurityPolicy, CallSettings)
            // Additional: PatchAsync(string, SecurityPolicy, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            SecurityPolicy securityPolicyResource = new SecurityPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.PatchAsync(securityPolicy, securityPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOncePatchAsync(operationName);
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
            // Snippet: PatchRule(PatchRuleOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            PatchRuleOrganizationSecurityPolicyRequest request = new PatchRuleOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
                Priority = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.PatchRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOncePatchRule(operationName);
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
            // Snippet: PatchRuleAsync(PatchRuleOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: PatchRuleAsync(PatchRuleOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PatchRuleOrganizationSecurityPolicyRequest request = new PatchRuleOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                SecurityPolicyRuleResource = new SecurityPolicyRule(),
                Priority = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.PatchRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOncePatchRuleAsync(operationName);
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
            // Snippet: PatchRule(string, SecurityPolicyRule, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.PatchRule(securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOncePatchRule(operationName);
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
            // Snippet: PatchRuleAsync(string, SecurityPolicyRule, CallSettings)
            // Additional: PatchRuleAsync(string, SecurityPolicyRule, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            SecurityPolicyRule securityPolicyRuleResource = new SecurityPolicyRule();
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.PatchRuleAsync(securityPolicy, securityPolicyRuleResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOncePatchRuleAsync(operationName);
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
            // Snippet: RemoveAssociation(RemoveAssociationOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveAssociationOrganizationSecurityPolicyRequest request = new RemoveAssociationOrganizationSecurityPolicyRequest
            {
                Name = "",
                RequestId = "",
                SecurityPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.RemoveAssociation(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceRemoveAssociation(operationName);
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
            // Snippet: RemoveAssociationAsync(RemoveAssociationOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: RemoveAssociationAsync(RemoveAssociationOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveAssociationOrganizationSecurityPolicyRequest request = new RemoveAssociationOrganizationSecurityPolicyRequest
            {
                Name = "",
                RequestId = "",
                SecurityPolicy = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.RemoveAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceRemoveAssociationAsync(operationName);
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
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.RemoveAssociation(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceRemoveAssociation(operationName);
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
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.RemoveAssociationAsync(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceRemoveAssociationAsync(operationName);
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
            // Snippet: RemoveRule(RemoveRuleOrganizationSecurityPolicyRequest, CallSettings)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            RemoveRuleOrganizationSecurityPolicyRequest request = new RemoveRuleOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                Priority = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.RemoveRule(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceRemoveRule(operationName);
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
            // Snippet: RemoveRuleAsync(RemoveRuleOrganizationSecurityPolicyRequest, CallSettings)
            // Additional: RemoveRuleAsync(RemoveRuleOrganizationSecurityPolicyRequest, CancellationToken)
            // Create client
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            RemoveRuleOrganizationSecurityPolicyRequest request = new RemoveRuleOrganizationSecurityPolicyRequest
            {
                RequestId = "",
                SecurityPolicy = "",
                Priority = 0,
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.RemoveRuleAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceRemoveRuleAsync(operationName);
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
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = OrganizationSecurityPoliciesClient.Create();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = organizationSecurityPoliciesClient.RemoveRule(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = organizationSecurityPoliciesClient.PollOnceRemoveRule(operationName);
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
            OrganizationSecurityPoliciesClient organizationSecurityPoliciesClient = await OrganizationSecurityPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string securityPolicy = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await organizationSecurityPoliciesClient.RemoveRuleAsync(securityPolicy);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await organizationSecurityPoliciesClient.PollOnceRemoveRuleAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
