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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V3Beta;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAccessPoliciesClientSnippets
    {
        /// <summary>Snippet for CreateAccessPolicy</summary>
        public void CreateAccessPolicyRequestObject()
        {
            // Snippet: CreateAccessPolicy(CreateAccessPolicyRequest, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            CreateAccessPolicyRequest request = new CreateAccessPolicyRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                AccessPolicyId = "",
                AccessPolicy = new AccessPolicy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = accessPoliciesClient.CreateAccessPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = accessPoliciesClient.PollOnceCreateAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicyAsync</summary>
        public async Task CreateAccessPolicyRequestObjectAsync()
        {
            // Snippet: CreateAccessPolicyAsync(CreateAccessPolicyRequest, CallSettings)
            // Additional: CreateAccessPolicyAsync(CreateAccessPolicyRequest, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            CreateAccessPolicyRequest request = new CreateAccessPolicyRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                AccessPolicyId = "",
                AccessPolicy = new AccessPolicy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = await accessPoliciesClient.CreateAccessPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = await accessPoliciesClient.PollOnceCreateAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicy</summary>
        public void CreateAccessPolicy()
        {
            // Snippet: CreateAccessPolicy(string, AccessPolicy, string, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            AccessPolicy accessPolicy = new AccessPolicy();
            string accessPolicyId = "";
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = accessPoliciesClient.CreateAccessPolicy(parent, accessPolicy, accessPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = accessPoliciesClient.PollOnceCreateAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicyAsync</summary>
        public async Task CreateAccessPolicyAsync()
        {
            // Snippet: CreateAccessPolicyAsync(string, AccessPolicy, string, CallSettings)
            // Additional: CreateAccessPolicyAsync(string, AccessPolicy, string, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            AccessPolicy accessPolicy = new AccessPolicy();
            string accessPolicyId = "";
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = await accessPoliciesClient.CreateAccessPolicyAsync(parent, accessPolicy, accessPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = await accessPoliciesClient.PollOnceCreateAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicy</summary>
        public void CreateAccessPolicyResourceNames1()
        {
            // Snippet: CreateAccessPolicy(OrganizationLocationName, AccessPolicy, string, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            AccessPolicy accessPolicy = new AccessPolicy();
            string accessPolicyId = "";
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = accessPoliciesClient.CreateAccessPolicy(parent, accessPolicy, accessPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = accessPoliciesClient.PollOnceCreateAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicyAsync</summary>
        public async Task CreateAccessPolicyResourceNames1Async()
        {
            // Snippet: CreateAccessPolicyAsync(OrganizationLocationName, AccessPolicy, string, CallSettings)
            // Additional: CreateAccessPolicyAsync(OrganizationLocationName, AccessPolicy, string, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            AccessPolicy accessPolicy = new AccessPolicy();
            string accessPolicyId = "";
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = await accessPoliciesClient.CreateAccessPolicyAsync(parent, accessPolicy, accessPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = await accessPoliciesClient.PollOnceCreateAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicy</summary>
        public void CreateAccessPolicyResourceNames2()
        {
            // Snippet: CreateAccessPolicy(FolderLocationName, AccessPolicy, string, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            AccessPolicy accessPolicy = new AccessPolicy();
            string accessPolicyId = "";
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = accessPoliciesClient.CreateAccessPolicy(parent, accessPolicy, accessPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = accessPoliciesClient.PollOnceCreateAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicyAsync</summary>
        public async Task CreateAccessPolicyResourceNames2Async()
        {
            // Snippet: CreateAccessPolicyAsync(FolderLocationName, AccessPolicy, string, CallSettings)
            // Additional: CreateAccessPolicyAsync(FolderLocationName, AccessPolicy, string, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            AccessPolicy accessPolicy = new AccessPolicy();
            string accessPolicyId = "";
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = await accessPoliciesClient.CreateAccessPolicyAsync(parent, accessPolicy, accessPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = await accessPoliciesClient.PollOnceCreateAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicy</summary>
        public void CreateAccessPolicyResourceNames3()
        {
            // Snippet: CreateAccessPolicy(LocationName, AccessPolicy, string, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AccessPolicy accessPolicy = new AccessPolicy();
            string accessPolicyId = "";
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = accessPoliciesClient.CreateAccessPolicy(parent, accessPolicy, accessPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = accessPoliciesClient.PollOnceCreateAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccessPolicyAsync</summary>
        public async Task CreateAccessPolicyResourceNames3Async()
        {
            // Snippet: CreateAccessPolicyAsync(LocationName, AccessPolicy, string, CallSettings)
            // Additional: CreateAccessPolicyAsync(LocationName, AccessPolicy, string, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AccessPolicy accessPolicy = new AccessPolicy();
            string accessPolicyId = "";
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = await accessPoliciesClient.CreateAccessPolicyAsync(parent, accessPolicy, accessPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = await accessPoliciesClient.PollOnceCreateAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicy</summary>
        public void GetAccessPolicyRequestObject()
        {
            // Snippet: GetAccessPolicy(GetAccessPolicyRequest, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]"),
            };
            // Make the request
            AccessPolicy response = accessPoliciesClient.GetAccessPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicyAsync</summary>
        public async Task GetAccessPolicyRequestObjectAsync()
        {
            // Snippet: GetAccessPolicyAsync(GetAccessPolicyRequest, CallSettings)
            // Additional: GetAccessPolicyAsync(GetAccessPolicyRequest, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetAccessPolicyRequest request = new GetAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]"),
            };
            // Make the request
            AccessPolicy response = await accessPoliciesClient.GetAccessPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicy</summary>
        public void GetAccessPolicy()
        {
            // Snippet: GetAccessPolicy(string, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/accessPolicies/[ACCESS_POLICY]";
            // Make the request
            AccessPolicy response = accessPoliciesClient.GetAccessPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicyAsync</summary>
        public async Task GetAccessPolicyAsync()
        {
            // Snippet: GetAccessPolicyAsync(string, CallSettings)
            // Additional: GetAccessPolicyAsync(string, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/accessPolicies/[ACCESS_POLICY]";
            // Make the request
            AccessPolicy response = await accessPoliciesClient.GetAccessPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicy</summary>
        public void GetAccessPolicyResourceNames()
        {
            // Snippet: GetAccessPolicy(AccessPolicyName, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]");
            // Make the request
            AccessPolicy response = accessPoliciesClient.GetAccessPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessPolicyAsync</summary>
        public async Task GetAccessPolicyResourceNamesAsync()
        {
            // Snippet: GetAccessPolicyAsync(AccessPolicyName, CallSettings)
            // Additional: GetAccessPolicyAsync(AccessPolicyName, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]");
            // Make the request
            AccessPolicy response = await accessPoliciesClient.GetAccessPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessPolicy</summary>
        public void UpdateAccessPolicyRequestObject()
        {
            // Snippet: UpdateAccessPolicy(UpdateAccessPolicyRequest, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            UpdateAccessPolicyRequest request = new UpdateAccessPolicyRequest
            {
                AccessPolicy = new AccessPolicy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = accessPoliciesClient.UpdateAccessPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = accessPoliciesClient.PollOnceUpdateAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessPolicyAsync</summary>
        public async Task UpdateAccessPolicyRequestObjectAsync()
        {
            // Snippet: UpdateAccessPolicyAsync(UpdateAccessPolicyRequest, CallSettings)
            // Additional: UpdateAccessPolicyAsync(UpdateAccessPolicyRequest, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccessPolicyRequest request = new UpdateAccessPolicyRequest
            {
                AccessPolicy = new AccessPolicy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<AccessPolicy, OperationMetadata> response = await accessPoliciesClient.UpdateAccessPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AccessPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccessPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccessPolicy, OperationMetadata> retrievedResponse = await accessPoliciesClient.PollOnceUpdateAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccessPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicy</summary>
        public void DeleteAccessPolicyRequestObject()
        {
            // Snippet: DeleteAccessPolicy(DeleteAccessPolicyRequest, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteAccessPolicyRequest request = new DeleteAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]"),
                Etag = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = accessPoliciesClient.DeleteAccessPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = accessPoliciesClient.PollOnceDeleteAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicyAsync</summary>
        public async Task DeleteAccessPolicyRequestObjectAsync()
        {
            // Snippet: DeleteAccessPolicyAsync(DeleteAccessPolicyRequest, CallSettings)
            // Additional: DeleteAccessPolicyAsync(DeleteAccessPolicyRequest, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccessPolicyRequest request = new DeleteAccessPolicyRequest
            {
                AccessPolicyName = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]"),
                Etag = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await accessPoliciesClient.DeleteAccessPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await accessPoliciesClient.PollOnceDeleteAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicy</summary>
        public void DeleteAccessPolicy()
        {
            // Snippet: DeleteAccessPolicy(string, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/accessPolicies/[ACCESS_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = accessPoliciesClient.DeleteAccessPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = accessPoliciesClient.PollOnceDeleteAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicyAsync</summary>
        public async Task DeleteAccessPolicyAsync()
        {
            // Snippet: DeleteAccessPolicyAsync(string, CallSettings)
            // Additional: DeleteAccessPolicyAsync(string, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/accessPolicies/[ACCESS_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await accessPoliciesClient.DeleteAccessPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await accessPoliciesClient.PollOnceDeleteAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicy</summary>
        public void DeleteAccessPolicyResourceNames()
        {
            // Snippet: DeleteAccessPolicy(AccessPolicyName, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = accessPoliciesClient.DeleteAccessPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = accessPoliciesClient.PollOnceDeleteAccessPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessPolicyAsync</summary>
        public async Task DeleteAccessPolicyResourceNamesAsync()
        {
            // Snippet: DeleteAccessPolicyAsync(AccessPolicyName, CallSettings)
            // Additional: DeleteAccessPolicyAsync(AccessPolicyName, CancellationToken)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await accessPoliciesClient.DeleteAccessPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await accessPoliciesClient.PollOnceDeleteAccessPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAccessPolicies</summary>
        public void ListAccessPoliciesRequestObject()
        {
            // Snippet: ListAccessPolicies(ListAccessPoliciesRequest, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPoliciesAsync</summary>
        public async Task ListAccessPoliciesRequestObjectAsync()
        {
            // Snippet: ListAccessPoliciesAsync(ListAccessPoliciesRequest, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListAccessPoliciesRequest request = new ListAccessPoliciesRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPolicies</summary>
        public void ListAccessPolicies()
        {
            // Snippet: ListAccessPolicies(string, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPoliciesAsync</summary>
        public async Task ListAccessPoliciesAsync()
        {
            // Snippet: ListAccessPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPolicies</summary>
        public void ListAccessPoliciesResourceNames1()
        {
            // Snippet: ListAccessPolicies(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPoliciesAsync</summary>
        public async Task ListAccessPoliciesResourceNames1Async()
        {
            // Snippet: ListAccessPoliciesAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPolicies</summary>
        public void ListAccessPoliciesResourceNames2()
        {
            // Snippet: ListAccessPolicies(FolderLocationName, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPoliciesAsync</summary>
        public async Task ListAccessPoliciesResourceNames2Async()
        {
            // Snippet: ListAccessPoliciesAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPolicies</summary>
        public void ListAccessPoliciesResourceNames3()
        {
            // Snippet: ListAccessPolicies(LocationName, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessPoliciesAsync</summary>
        public async Task ListAccessPoliciesResourceNames3Async()
        {
            // Snippet: ListAccessPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAccessPoliciesResponse, AccessPolicy> response = accessPoliciesClient.ListAccessPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AccessPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAccessPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccessPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccessPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccessPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchAccessPolicyBindings</summary>
        public void SearchAccessPolicyBindingsRequestObject()
        {
            // Snippet: SearchAccessPolicyBindings(SearchAccessPolicyBindingsRequest, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            SearchAccessPolicyBindingsRequest request = new SearchAccessPolicyBindingsRequest
            {
                AccessPolicyName = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]"),
            };
            // Make the request
            PagedEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> response = accessPoliciesClient.SearchAccessPolicyBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAccessPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchAccessPolicyBindingsAsync</summary>
        public async Task SearchAccessPolicyBindingsRequestObjectAsync()
        {
            // Snippet: SearchAccessPolicyBindingsAsync(SearchAccessPolicyBindingsRequest, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            SearchAccessPolicyBindingsRequest request = new SearchAccessPolicyBindingsRequest
            {
                AccessPolicyName = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]"),
            };
            // Make the request
            PagedAsyncEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> response = accessPoliciesClient.SearchAccessPolicyBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchAccessPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchAccessPolicyBindings</summary>
        public void SearchAccessPolicyBindings()
        {
            // Snippet: SearchAccessPolicyBindings(string, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/accessPolicies/[ACCESS_POLICY]";
            // Make the request
            PagedEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> response = accessPoliciesClient.SearchAccessPolicyBindings(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAccessPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchAccessPolicyBindingsAsync</summary>
        public async Task SearchAccessPolicyBindingsAsync()
        {
            // Snippet: SearchAccessPolicyBindingsAsync(string, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/accessPolicies/[ACCESS_POLICY]";
            // Make the request
            PagedAsyncEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> response = accessPoliciesClient.SearchAccessPolicyBindingsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchAccessPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchAccessPolicyBindings</summary>
        public void SearchAccessPolicyBindingsResourceNames()
        {
            // Snippet: SearchAccessPolicyBindings(AccessPolicyName, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = AccessPoliciesClient.Create();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]");
            // Make the request
            PagedEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> response = accessPoliciesClient.SearchAccessPolicyBindings(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchAccessPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchAccessPolicyBindingsAsync</summary>
        public async Task SearchAccessPolicyBindingsResourceNamesAsync()
        {
            // Snippet: SearchAccessPolicyBindingsAsync(AccessPolicyName, string, int?, CallSettings)
            // Create client
            AccessPoliciesClient accessPoliciesClient = await AccessPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AccessPolicyName name = AccessPolicyName.FromOrganizationLocationAccessPolicy("[ORGANIZATION]", "[LOCATION]", "[ACCESS_POLICY]");
            // Make the request
            PagedAsyncEnumerable<SearchAccessPolicyBindingsResponse, PolicyBinding> response = accessPoliciesClient.SearchAccessPolicyBindingsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchAccessPolicyBindingsResponse page in response.AsRawResponses())
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
