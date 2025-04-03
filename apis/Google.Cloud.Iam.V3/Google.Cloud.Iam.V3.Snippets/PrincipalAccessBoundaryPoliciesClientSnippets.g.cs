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
    using Google.Cloud.Iam.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPrincipalAccessBoundaryPoliciesClientSnippets
    {
        /// <summary>Snippet for CreatePrincipalAccessBoundaryPolicy</summary>
        public void CreatePrincipalAccessBoundaryPolicyRequestObject()
        {
            // Snippet: CreatePrincipalAccessBoundaryPolicy(CreatePrincipalAccessBoundaryPolicyRequest, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            CreatePrincipalAccessBoundaryPolicyRequest request = new CreatePrincipalAccessBoundaryPolicyRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                PrincipalAccessBoundaryPolicyId = "",
                PrincipalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = principalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = principalAccessBoundaryPoliciesClient.PollOnceCreatePrincipalAccessBoundaryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrincipalAccessBoundaryPolicyAsync</summary>
        public async Task CreatePrincipalAccessBoundaryPolicyRequestObjectAsync()
        {
            // Snippet: CreatePrincipalAccessBoundaryPolicyAsync(CreatePrincipalAccessBoundaryPolicyRequest, CallSettings)
            // Additional: CreatePrincipalAccessBoundaryPolicyAsync(CreatePrincipalAccessBoundaryPolicyRequest, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            CreatePrincipalAccessBoundaryPolicyRequest request = new CreatePrincipalAccessBoundaryPolicyRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                PrincipalAccessBoundaryPolicyId = "",
                PrincipalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = await principalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = await principalAccessBoundaryPoliciesClient.PollOnceCreatePrincipalAccessBoundaryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrincipalAccessBoundaryPolicy</summary>
        public void CreatePrincipalAccessBoundaryPolicy()
        {
            // Snippet: CreatePrincipalAccessBoundaryPolicy(string, PrincipalAccessBoundaryPolicy, string, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy();
            string principalAccessBoundaryPolicyId = "";
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = principalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicy(parent, principalAccessBoundaryPolicy, principalAccessBoundaryPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = principalAccessBoundaryPoliciesClient.PollOnceCreatePrincipalAccessBoundaryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrincipalAccessBoundaryPolicyAsync</summary>
        public async Task CreatePrincipalAccessBoundaryPolicyAsync()
        {
            // Snippet: CreatePrincipalAccessBoundaryPolicyAsync(string, PrincipalAccessBoundaryPolicy, string, CallSettings)
            // Additional: CreatePrincipalAccessBoundaryPolicyAsync(string, PrincipalAccessBoundaryPolicy, string, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy();
            string principalAccessBoundaryPolicyId = "";
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = await principalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicyAsync(parent, principalAccessBoundaryPolicy, principalAccessBoundaryPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = await principalAccessBoundaryPoliciesClient.PollOnceCreatePrincipalAccessBoundaryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrincipalAccessBoundaryPolicy</summary>
        public void CreatePrincipalAccessBoundaryPolicyResourceNames()
        {
            // Snippet: CreatePrincipalAccessBoundaryPolicy(OrganizationLocationName, PrincipalAccessBoundaryPolicy, string, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy();
            string principalAccessBoundaryPolicyId = "";
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = principalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicy(parent, principalAccessBoundaryPolicy, principalAccessBoundaryPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = principalAccessBoundaryPoliciesClient.PollOnceCreatePrincipalAccessBoundaryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePrincipalAccessBoundaryPolicyAsync</summary>
        public async Task CreatePrincipalAccessBoundaryPolicyResourceNamesAsync()
        {
            // Snippet: CreatePrincipalAccessBoundaryPolicyAsync(OrganizationLocationName, PrincipalAccessBoundaryPolicy, string, CallSettings)
            // Additional: CreatePrincipalAccessBoundaryPolicyAsync(OrganizationLocationName, PrincipalAccessBoundaryPolicy, string, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy();
            string principalAccessBoundaryPolicyId = "";
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = await principalAccessBoundaryPoliciesClient.CreatePrincipalAccessBoundaryPolicyAsync(parent, principalAccessBoundaryPolicy, principalAccessBoundaryPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = await principalAccessBoundaryPoliciesClient.PollOnceCreatePrincipalAccessBoundaryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPrincipalAccessBoundaryPolicy</summary>
        public void GetPrincipalAccessBoundaryPolicyRequestObject()
        {
            // Snippet: GetPrincipalAccessBoundaryPolicy(GetPrincipalAccessBoundaryPolicyRequest, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            GetPrincipalAccessBoundaryPolicyRequest request = new GetPrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicyName = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]"),
            };
            // Make the request
            PrincipalAccessBoundaryPolicy response = principalAccessBoundaryPoliciesClient.GetPrincipalAccessBoundaryPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrincipalAccessBoundaryPolicyAsync</summary>
        public async Task GetPrincipalAccessBoundaryPolicyRequestObjectAsync()
        {
            // Snippet: GetPrincipalAccessBoundaryPolicyAsync(GetPrincipalAccessBoundaryPolicyRequest, CallSettings)
            // Additional: GetPrincipalAccessBoundaryPolicyAsync(GetPrincipalAccessBoundaryPolicyRequest, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetPrincipalAccessBoundaryPolicyRequest request = new GetPrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicyName = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]"),
            };
            // Make the request
            PrincipalAccessBoundaryPolicy response = await principalAccessBoundaryPoliciesClient.GetPrincipalAccessBoundaryPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPrincipalAccessBoundaryPolicy</summary>
        public void GetPrincipalAccessBoundaryPolicy()
        {
            // Snippet: GetPrincipalAccessBoundaryPolicy(string, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/principalAccessBoundaryPolicies/[PRINCIPAL_ACCESS_BOUNDARY_POLICY]";
            // Make the request
            PrincipalAccessBoundaryPolicy response = principalAccessBoundaryPoliciesClient.GetPrincipalAccessBoundaryPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrincipalAccessBoundaryPolicyAsync</summary>
        public async Task GetPrincipalAccessBoundaryPolicyAsync()
        {
            // Snippet: GetPrincipalAccessBoundaryPolicyAsync(string, CallSettings)
            // Additional: GetPrincipalAccessBoundaryPolicyAsync(string, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/principalAccessBoundaryPolicies/[PRINCIPAL_ACCESS_BOUNDARY_POLICY]";
            // Make the request
            PrincipalAccessBoundaryPolicy response = await principalAccessBoundaryPoliciesClient.GetPrincipalAccessBoundaryPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrincipalAccessBoundaryPolicy</summary>
        public void GetPrincipalAccessBoundaryPolicyResourceNames()
        {
            // Snippet: GetPrincipalAccessBoundaryPolicy(PrincipalAccessBoundaryPolicyName, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            PrincipalAccessBoundaryPolicyName name = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]");
            // Make the request
            PrincipalAccessBoundaryPolicy response = principalAccessBoundaryPoliciesClient.GetPrincipalAccessBoundaryPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetPrincipalAccessBoundaryPolicyAsync</summary>
        public async Task GetPrincipalAccessBoundaryPolicyResourceNamesAsync()
        {
            // Snippet: GetPrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicyName, CallSettings)
            // Additional: GetPrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicyName, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PrincipalAccessBoundaryPolicyName name = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]");
            // Make the request
            PrincipalAccessBoundaryPolicy response = await principalAccessBoundaryPoliciesClient.GetPrincipalAccessBoundaryPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdatePrincipalAccessBoundaryPolicy</summary>
        public void UpdatePrincipalAccessBoundaryPolicyRequestObject()
        {
            // Snippet: UpdatePrincipalAccessBoundaryPolicy(UpdatePrincipalAccessBoundaryPolicyRequest, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            UpdatePrincipalAccessBoundaryPolicyRequest request = new UpdatePrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = principalAccessBoundaryPoliciesClient.UpdatePrincipalAccessBoundaryPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = principalAccessBoundaryPoliciesClient.PollOnceUpdatePrincipalAccessBoundaryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrincipalAccessBoundaryPolicyAsync</summary>
        public async Task UpdatePrincipalAccessBoundaryPolicyRequestObjectAsync()
        {
            // Snippet: UpdatePrincipalAccessBoundaryPolicyAsync(UpdatePrincipalAccessBoundaryPolicyRequest, CallSettings)
            // Additional: UpdatePrincipalAccessBoundaryPolicyAsync(UpdatePrincipalAccessBoundaryPolicyRequest, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePrincipalAccessBoundaryPolicyRequest request = new UpdatePrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = await principalAccessBoundaryPoliciesClient.UpdatePrincipalAccessBoundaryPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = await principalAccessBoundaryPoliciesClient.PollOnceUpdatePrincipalAccessBoundaryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrincipalAccessBoundaryPolicy</summary>
        public void UpdatePrincipalAccessBoundaryPolicy()
        {
            // Snippet: UpdatePrincipalAccessBoundaryPolicy(PrincipalAccessBoundaryPolicy, FieldMask, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = principalAccessBoundaryPoliciesClient.UpdatePrincipalAccessBoundaryPolicy(principalAccessBoundaryPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = principalAccessBoundaryPoliciesClient.PollOnceUpdatePrincipalAccessBoundaryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePrincipalAccessBoundaryPolicyAsync</summary>
        public async Task UpdatePrincipalAccessBoundaryPolicyAsync()
        {
            // Snippet: UpdatePrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicy, FieldMask, CallSettings)
            // Additional: UpdatePrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicy, FieldMask, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PrincipalAccessBoundaryPolicy principalAccessBoundaryPolicy = new PrincipalAccessBoundaryPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> response = await principalAccessBoundaryPoliciesClient.UpdatePrincipalAccessBoundaryPolicyAsync(principalAccessBoundaryPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PrincipalAccessBoundaryPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PrincipalAccessBoundaryPolicy, OperationMetadata> retrievedResponse = await principalAccessBoundaryPoliciesClient.PollOnceUpdatePrincipalAccessBoundaryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PrincipalAccessBoundaryPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrincipalAccessBoundaryPolicy</summary>
        public void DeletePrincipalAccessBoundaryPolicyRequestObject()
        {
            // Snippet: DeletePrincipalAccessBoundaryPolicy(DeletePrincipalAccessBoundaryPolicyRequest, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            DeletePrincipalAccessBoundaryPolicyRequest request = new DeletePrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicyName = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]"),
                Etag = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = principalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = principalAccessBoundaryPoliciesClient.PollOnceDeletePrincipalAccessBoundaryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrincipalAccessBoundaryPolicyAsync</summary>
        public async Task DeletePrincipalAccessBoundaryPolicyRequestObjectAsync()
        {
            // Snippet: DeletePrincipalAccessBoundaryPolicyAsync(DeletePrincipalAccessBoundaryPolicyRequest, CallSettings)
            // Additional: DeletePrincipalAccessBoundaryPolicyAsync(DeletePrincipalAccessBoundaryPolicyRequest, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeletePrincipalAccessBoundaryPolicyRequest request = new DeletePrincipalAccessBoundaryPolicyRequest
            {
                PrincipalAccessBoundaryPolicyName = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]"),
                Etag = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await principalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await principalAccessBoundaryPoliciesClient.PollOnceDeletePrincipalAccessBoundaryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrincipalAccessBoundaryPolicy</summary>
        public void DeletePrincipalAccessBoundaryPolicy()
        {
            // Snippet: DeletePrincipalAccessBoundaryPolicy(string, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/principalAccessBoundaryPolicies/[PRINCIPAL_ACCESS_BOUNDARY_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = principalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = principalAccessBoundaryPoliciesClient.PollOnceDeletePrincipalAccessBoundaryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrincipalAccessBoundaryPolicyAsync</summary>
        public async Task DeletePrincipalAccessBoundaryPolicyAsync()
        {
            // Snippet: DeletePrincipalAccessBoundaryPolicyAsync(string, CallSettings)
            // Additional: DeletePrincipalAccessBoundaryPolicyAsync(string, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/principalAccessBoundaryPolicies/[PRINCIPAL_ACCESS_BOUNDARY_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await principalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await principalAccessBoundaryPoliciesClient.PollOnceDeletePrincipalAccessBoundaryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrincipalAccessBoundaryPolicy</summary>
        public void DeletePrincipalAccessBoundaryPolicyResourceNames()
        {
            // Snippet: DeletePrincipalAccessBoundaryPolicy(PrincipalAccessBoundaryPolicyName, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            PrincipalAccessBoundaryPolicyName name = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = principalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = principalAccessBoundaryPoliciesClient.PollOnceDeletePrincipalAccessBoundaryPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePrincipalAccessBoundaryPolicyAsync</summary>
        public async Task DeletePrincipalAccessBoundaryPolicyResourceNamesAsync()
        {
            // Snippet: DeletePrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicyName, CallSettings)
            // Additional: DeletePrincipalAccessBoundaryPolicyAsync(PrincipalAccessBoundaryPolicyName, CancellationToken)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PrincipalAccessBoundaryPolicyName name = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await principalAccessBoundaryPoliciesClient.DeletePrincipalAccessBoundaryPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await principalAccessBoundaryPoliciesClient.PollOnceDeletePrincipalAccessBoundaryPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListPrincipalAccessBoundaryPolicies</summary>
        public void ListPrincipalAccessBoundaryPoliciesRequestObject()
        {
            // Snippet: ListPrincipalAccessBoundaryPolicies(ListPrincipalAccessBoundaryPoliciesRequest, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            ListPrincipalAccessBoundaryPoliciesRequest request = new ListPrincipalAccessBoundaryPoliciesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> response = principalAccessBoundaryPoliciesClient.ListPrincipalAccessBoundaryPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrincipalAccessBoundaryPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrincipalAccessBoundaryPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrincipalAccessBoundaryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrincipalAccessBoundaryPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrincipalAccessBoundaryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrincipalAccessBoundaryPoliciesAsync</summary>
        public async Task ListPrincipalAccessBoundaryPoliciesRequestObjectAsync()
        {
            // Snippet: ListPrincipalAccessBoundaryPoliciesAsync(ListPrincipalAccessBoundaryPoliciesRequest, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListPrincipalAccessBoundaryPoliciesRequest request = new ListPrincipalAccessBoundaryPoliciesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> response = principalAccessBoundaryPoliciesClient.ListPrincipalAccessBoundaryPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrincipalAccessBoundaryPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrincipalAccessBoundaryPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrincipalAccessBoundaryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrincipalAccessBoundaryPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrincipalAccessBoundaryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrincipalAccessBoundaryPolicies</summary>
        public void ListPrincipalAccessBoundaryPolicies()
        {
            // Snippet: ListPrincipalAccessBoundaryPolicies(string, string, int?, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> response = principalAccessBoundaryPoliciesClient.ListPrincipalAccessBoundaryPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrincipalAccessBoundaryPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrincipalAccessBoundaryPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrincipalAccessBoundaryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrincipalAccessBoundaryPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrincipalAccessBoundaryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrincipalAccessBoundaryPoliciesAsync</summary>
        public async Task ListPrincipalAccessBoundaryPoliciesAsync()
        {
            // Snippet: ListPrincipalAccessBoundaryPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> response = principalAccessBoundaryPoliciesClient.ListPrincipalAccessBoundaryPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrincipalAccessBoundaryPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrincipalAccessBoundaryPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrincipalAccessBoundaryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrincipalAccessBoundaryPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrincipalAccessBoundaryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrincipalAccessBoundaryPolicies</summary>
        public void ListPrincipalAccessBoundaryPoliciesResourceNames()
        {
            // Snippet: ListPrincipalAccessBoundaryPolicies(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> response = principalAccessBoundaryPoliciesClient.ListPrincipalAccessBoundaryPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PrincipalAccessBoundaryPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPrincipalAccessBoundaryPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrincipalAccessBoundaryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrincipalAccessBoundaryPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrincipalAccessBoundaryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPrincipalAccessBoundaryPoliciesAsync</summary>
        public async Task ListPrincipalAccessBoundaryPoliciesResourceNamesAsync()
        {
            // Snippet: ListPrincipalAccessBoundaryPoliciesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPrincipalAccessBoundaryPoliciesResponse, PrincipalAccessBoundaryPolicy> response = principalAccessBoundaryPoliciesClient.ListPrincipalAccessBoundaryPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PrincipalAccessBoundaryPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPrincipalAccessBoundaryPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PrincipalAccessBoundaryPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PrincipalAccessBoundaryPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PrincipalAccessBoundaryPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPrincipalAccessBoundaryPolicyBindings</summary>
        public void SearchPrincipalAccessBoundaryPolicyBindingsRequestObject()
        {
            // Snippet: SearchPrincipalAccessBoundaryPolicyBindings(SearchPrincipalAccessBoundaryPolicyBindingsRequest, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            SearchPrincipalAccessBoundaryPolicyBindingsRequest request = new SearchPrincipalAccessBoundaryPolicyBindingsRequest
            {
                PrincipalAccessBoundaryPolicyName = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]"),
            };
            // Make the request
            PagedEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> response = principalAccessBoundaryPoliciesClient.SearchPrincipalAccessBoundaryPolicyBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchPrincipalAccessBoundaryPolicyBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPrincipalAccessBoundaryPolicyBindingsAsync</summary>
        public async Task SearchPrincipalAccessBoundaryPolicyBindingsRequestObjectAsync()
        {
            // Snippet: SearchPrincipalAccessBoundaryPolicyBindingsAsync(SearchPrincipalAccessBoundaryPolicyBindingsRequest, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            SearchPrincipalAccessBoundaryPolicyBindingsRequest request = new SearchPrincipalAccessBoundaryPolicyBindingsRequest
            {
                PrincipalAccessBoundaryPolicyName = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]"),
            };
            // Make the request
            PagedAsyncEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> response = principalAccessBoundaryPoliciesClient.SearchPrincipalAccessBoundaryPolicyBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchPrincipalAccessBoundaryPolicyBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPrincipalAccessBoundaryPolicyBindings</summary>
        public void SearchPrincipalAccessBoundaryPolicyBindings()
        {
            // Snippet: SearchPrincipalAccessBoundaryPolicyBindings(string, string, int?, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/principalAccessBoundaryPolicies/[PRINCIPAL_ACCESS_BOUNDARY_POLICY]";
            // Make the request
            PagedEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> response = principalAccessBoundaryPoliciesClient.SearchPrincipalAccessBoundaryPolicyBindings(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchPrincipalAccessBoundaryPolicyBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPrincipalAccessBoundaryPolicyBindingsAsync</summary>
        public async Task SearchPrincipalAccessBoundaryPolicyBindingsAsync()
        {
            // Snippet: SearchPrincipalAccessBoundaryPolicyBindingsAsync(string, string, int?, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/principalAccessBoundaryPolicies/[PRINCIPAL_ACCESS_BOUNDARY_POLICY]";
            // Make the request
            PagedAsyncEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> response = principalAccessBoundaryPoliciesClient.SearchPrincipalAccessBoundaryPolicyBindingsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchPrincipalAccessBoundaryPolicyBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPrincipalAccessBoundaryPolicyBindings</summary>
        public void SearchPrincipalAccessBoundaryPolicyBindingsResourceNames()
        {
            // Snippet: SearchPrincipalAccessBoundaryPolicyBindings(PrincipalAccessBoundaryPolicyName, string, int?, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = PrincipalAccessBoundaryPoliciesClient.Create();
            // Initialize request argument(s)
            PrincipalAccessBoundaryPolicyName name = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]");
            // Make the request
            PagedEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> response = principalAccessBoundaryPoliciesClient.SearchPrincipalAccessBoundaryPolicyBindings(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchPrincipalAccessBoundaryPolicyBindingsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBinding> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBinding item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPrincipalAccessBoundaryPolicyBindingsAsync</summary>
        public async Task SearchPrincipalAccessBoundaryPolicyBindingsResourceNamesAsync()
        {
            // Snippet: SearchPrincipalAccessBoundaryPolicyBindingsAsync(PrincipalAccessBoundaryPolicyName, string, int?, CallSettings)
            // Create client
            PrincipalAccessBoundaryPoliciesClient principalAccessBoundaryPoliciesClient = await PrincipalAccessBoundaryPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            PrincipalAccessBoundaryPolicyName name = PrincipalAccessBoundaryPolicyName.FromOrganizationLocationPrincipalAccessBoundaryPolicy("[ORGANIZATION]", "[LOCATION]", "[PRINCIPAL_ACCESS_BOUNDARY_POLICY]");
            // Make the request
            PagedAsyncEnumerable<SearchPrincipalAccessBoundaryPolicyBindingsResponse, PolicyBinding> response = principalAccessBoundaryPoliciesClient.SearchPrincipalAccessBoundaryPolicyBindingsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchPrincipalAccessBoundaryPolicyBindingsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PolicyBinding item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PolicyBinding> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PolicyBinding item in singlePage)
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
