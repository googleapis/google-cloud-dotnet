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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V3;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPolicyBindingsClientSnippets
    {
        /// <summary>Snippet for CreatePolicyBinding</summary>
        public void CreatePolicyBindingRequestObject()
        {
            // Snippet: CreatePolicyBinding(CreatePolicyBindingRequest, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            CreatePolicyBindingRequest request = new CreatePolicyBindingRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                PolicyBindingId = "",
                PolicyBinding = new PolicyBinding(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = policyBindingsClient.CreatePolicyBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceCreatePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBindingAsync</summary>
        public async Task CreatePolicyBindingRequestObjectAsync()
        {
            // Snippet: CreatePolicyBindingAsync(CreatePolicyBindingRequest, CallSettings)
            // Additional: CreatePolicyBindingAsync(CreatePolicyBindingRequest, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            CreatePolicyBindingRequest request = new CreatePolicyBindingRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                PolicyBindingId = "",
                PolicyBinding = new PolicyBinding(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = await policyBindingsClient.CreatePolicyBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceCreatePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBinding</summary>
        public void CreatePolicyBinding()
        {
            // Snippet: CreatePolicyBinding(string, PolicyBinding, string, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            PolicyBinding policyBinding = new PolicyBinding();
            string policyBindingId = "";
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = policyBindingsClient.CreatePolicyBinding(parent, policyBinding, policyBindingId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceCreatePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBindingAsync</summary>
        public async Task CreatePolicyBindingAsync()
        {
            // Snippet: CreatePolicyBindingAsync(string, PolicyBinding, string, CallSettings)
            // Additional: CreatePolicyBindingAsync(string, PolicyBinding, string, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            PolicyBinding policyBinding = new PolicyBinding();
            string policyBindingId = "";
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = await policyBindingsClient.CreatePolicyBindingAsync(parent, policyBinding, policyBindingId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceCreatePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBinding</summary>
        public void CreatePolicyBindingResourceNames1()
        {
            // Snippet: CreatePolicyBinding(OrganizationLocationName, PolicyBinding, string, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            PolicyBinding policyBinding = new PolicyBinding();
            string policyBindingId = "";
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = policyBindingsClient.CreatePolicyBinding(parent, policyBinding, policyBindingId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceCreatePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBindingAsync</summary>
        public async Task CreatePolicyBindingResourceNames1Async()
        {
            // Snippet: CreatePolicyBindingAsync(OrganizationLocationName, PolicyBinding, string, CallSettings)
            // Additional: CreatePolicyBindingAsync(OrganizationLocationName, PolicyBinding, string, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            PolicyBinding policyBinding = new PolicyBinding();
            string policyBindingId = "";
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = await policyBindingsClient.CreatePolicyBindingAsync(parent, policyBinding, policyBindingId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceCreatePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBinding</summary>
        public void CreatePolicyBindingResourceNames2()
        {
            // Snippet: CreatePolicyBinding(FolderLocationName, PolicyBinding, string, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            PolicyBinding policyBinding = new PolicyBinding();
            string policyBindingId = "";
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = policyBindingsClient.CreatePolicyBinding(parent, policyBinding, policyBindingId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceCreatePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBindingAsync</summary>
        public async Task CreatePolicyBindingResourceNames2Async()
        {
            // Snippet: CreatePolicyBindingAsync(FolderLocationName, PolicyBinding, string, CallSettings)
            // Additional: CreatePolicyBindingAsync(FolderLocationName, PolicyBinding, string, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            PolicyBinding policyBinding = new PolicyBinding();
            string policyBindingId = "";
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = await policyBindingsClient.CreatePolicyBindingAsync(parent, policyBinding, policyBindingId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceCreatePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBinding</summary>
        public void CreatePolicyBindingResourceNames3()
        {
            // Snippet: CreatePolicyBinding(LocationName, PolicyBinding, string, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PolicyBinding policyBinding = new PolicyBinding();
            string policyBindingId = "";
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = policyBindingsClient.CreatePolicyBinding(parent, policyBinding, policyBindingId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceCreatePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyBindingAsync</summary>
        public async Task CreatePolicyBindingResourceNames3Async()
        {
            // Snippet: CreatePolicyBindingAsync(LocationName, PolicyBinding, string, CallSettings)
            // Additional: CreatePolicyBindingAsync(LocationName, PolicyBinding, string, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PolicyBinding policyBinding = new PolicyBinding();
            string policyBindingId = "";
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = await policyBindingsClient.CreatePolicyBindingAsync(parent, policyBinding, policyBindingId);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceCreatePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBinding</summary>
        public void GetPolicyBindingRequestObject()
        {
            // Snippet: GetPolicyBinding(GetPolicyBindingRequest, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            GetPolicyBindingRequest request = new GetPolicyBindingRequest
            {
                PolicyBindingName = PolicyBindingName.FromOrganizationLocationPolicyBinding("[ORGANIZATION]", "[LOCATION]", "[POLICY_BINDING]"),
            };
            // Make the request
            PolicyBinding response = policyBindingsClient.GetPolicyBinding(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBindingAsync</summary>
        public async Task GetPolicyBindingRequestObjectAsync()
        {
            // Snippet: GetPolicyBindingAsync(GetPolicyBindingRequest, CallSettings)
            // Additional: GetPolicyBindingAsync(GetPolicyBindingRequest, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            GetPolicyBindingRequest request = new GetPolicyBindingRequest
            {
                PolicyBindingName = PolicyBindingName.FromOrganizationLocationPolicyBinding("[ORGANIZATION]", "[LOCATION]", "[POLICY_BINDING]"),
            };
            // Make the request
            PolicyBinding response = await policyBindingsClient.GetPolicyBindingAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBinding</summary>
        public void GetPolicyBinding()
        {
            // Snippet: GetPolicyBinding(string, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/policyBindings/[POLICY_BINDING]";
            // Make the request
            PolicyBinding response = policyBindingsClient.GetPolicyBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBindingAsync</summary>
        public async Task GetPolicyBindingAsync()
        {
            // Snippet: GetPolicyBindingAsync(string, CallSettings)
            // Additional: GetPolicyBindingAsync(string, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/policyBindings/[POLICY_BINDING]";
            // Make the request
            PolicyBinding response = await policyBindingsClient.GetPolicyBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBinding</summary>
        public void GetPolicyBindingResourceNames()
        {
            // Snippet: GetPolicyBinding(PolicyBindingName, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            PolicyBindingName name = PolicyBindingName.FromOrganizationLocationPolicyBinding("[ORGANIZATION]", "[LOCATION]", "[POLICY_BINDING]");
            // Make the request
            PolicyBinding response = policyBindingsClient.GetPolicyBinding(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyBindingAsync</summary>
        public async Task GetPolicyBindingResourceNamesAsync()
        {
            // Snippet: GetPolicyBindingAsync(PolicyBindingName, CallSettings)
            // Additional: GetPolicyBindingAsync(PolicyBindingName, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            PolicyBindingName name = PolicyBindingName.FromOrganizationLocationPolicyBinding("[ORGANIZATION]", "[LOCATION]", "[POLICY_BINDING]");
            // Make the request
            PolicyBinding response = await policyBindingsClient.GetPolicyBindingAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyBinding</summary>
        public void UpdatePolicyBindingRequestObject()
        {
            // Snippet: UpdatePolicyBinding(UpdatePolicyBindingRequest, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            UpdatePolicyBindingRequest request = new UpdatePolicyBindingRequest
            {
                PolicyBinding = new PolicyBinding(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = policyBindingsClient.UpdatePolicyBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceUpdatePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyBindingAsync</summary>
        public async Task UpdatePolicyBindingRequestObjectAsync()
        {
            // Snippet: UpdatePolicyBindingAsync(UpdatePolicyBindingRequest, CallSettings)
            // Additional: UpdatePolicyBindingAsync(UpdatePolicyBindingRequest, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePolicyBindingRequest request = new UpdatePolicyBindingRequest
            {
                PolicyBinding = new PolicyBinding(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = await policyBindingsClient.UpdatePolicyBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceUpdatePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyBinding</summary>
        public void UpdatePolicyBinding()
        {
            // Snippet: UpdatePolicyBinding(PolicyBinding, FieldMask, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            PolicyBinding policyBinding = new PolicyBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = policyBindingsClient.UpdatePolicyBinding(policyBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceUpdatePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyBindingAsync</summary>
        public async Task UpdatePolicyBindingAsync()
        {
            // Snippet: UpdatePolicyBindingAsync(PolicyBinding, FieldMask, CallSettings)
            // Additional: UpdatePolicyBindingAsync(PolicyBinding, FieldMask, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            PolicyBinding policyBinding = new PolicyBinding();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<PolicyBinding, OperationMetadata> response = await policyBindingsClient.UpdatePolicyBindingAsync(policyBinding, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<PolicyBinding, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PolicyBinding result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PolicyBinding, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceUpdatePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PolicyBinding retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBinding</summary>
        public void DeletePolicyBindingRequestObject()
        {
            // Snippet: DeletePolicyBinding(DeletePolicyBindingRequest, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            DeletePolicyBindingRequest request = new DeletePolicyBindingRequest
            {
                PolicyBindingName = PolicyBindingName.FromOrganizationLocationPolicyBinding("[ORGANIZATION]", "[LOCATION]", "[POLICY_BINDING]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = policyBindingsClient.DeletePolicyBinding(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceDeletePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBindingAsync</summary>
        public async Task DeletePolicyBindingRequestObjectAsync()
        {
            // Snippet: DeletePolicyBindingAsync(DeletePolicyBindingRequest, CallSettings)
            // Additional: DeletePolicyBindingAsync(DeletePolicyBindingRequest, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            DeletePolicyBindingRequest request = new DeletePolicyBindingRequest
            {
                PolicyBindingName = PolicyBindingName.FromOrganizationLocationPolicyBinding("[ORGANIZATION]", "[LOCATION]", "[POLICY_BINDING]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await policyBindingsClient.DeletePolicyBindingAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceDeletePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBinding</summary>
        public void DeletePolicyBinding()
        {
            // Snippet: DeletePolicyBinding(string, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/policyBindings/[POLICY_BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = policyBindingsClient.DeletePolicyBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceDeletePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBindingAsync</summary>
        public async Task DeletePolicyBindingAsync()
        {
            // Snippet: DeletePolicyBindingAsync(string, CallSettings)
            // Additional: DeletePolicyBindingAsync(string, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "organizations/[ORGANIZATION]/locations/[LOCATION]/policyBindings/[POLICY_BINDING]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await policyBindingsClient.DeletePolicyBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceDeletePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBinding</summary>
        public void DeletePolicyBindingResourceNames()
        {
            // Snippet: DeletePolicyBinding(PolicyBindingName, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            PolicyBindingName name = PolicyBindingName.FromOrganizationLocationPolicyBinding("[ORGANIZATION]", "[LOCATION]", "[POLICY_BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = policyBindingsClient.DeletePolicyBinding(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = policyBindingsClient.PollOnceDeletePolicyBinding(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyBindingAsync</summary>
        public async Task DeletePolicyBindingResourceNamesAsync()
        {
            // Snippet: DeletePolicyBindingAsync(PolicyBindingName, CallSettings)
            // Additional: DeletePolicyBindingAsync(PolicyBindingName, CancellationToken)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            PolicyBindingName name = PolicyBindingName.FromOrganizationLocationPolicyBinding("[ORGANIZATION]", "[LOCATION]", "[POLICY_BINDING]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await policyBindingsClient.DeletePolicyBindingAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await policyBindingsClient.PollOnceDeletePolicyBindingAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListPolicyBindings</summary>
        public void ListPolicyBindingsRequestObject()
        {
            // Snippet: ListPolicyBindings(ListPolicyBindingsRequest, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListPolicyBindingsAsync</summary>
        public async Task ListPolicyBindingsRequestObjectAsync()
        {
            // Snippet: ListPolicyBindingsAsync(ListPolicyBindingsRequest, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            ListPolicyBindingsRequest request = new ListPolicyBindingsRequest
            {
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyBindingsResponse page) =>
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

        /// <summary>Snippet for ListPolicyBindings</summary>
        public void ListPolicyBindings()
        {
            // Snippet: ListPolicyBindings(string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListPolicyBindingsAsync</summary>
        public async Task ListPolicyBindingsAsync()
        {
            // Snippet: ListPolicyBindingsAsync(string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyBindingsResponse page) =>
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

        /// <summary>Snippet for ListPolicyBindings</summary>
        public void ListPolicyBindingsResourceNames1()
        {
            // Snippet: ListPolicyBindings(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListPolicyBindingsAsync</summary>
        public async Task ListPolicyBindingsResourceNames1Async()
        {
            // Snippet: ListPolicyBindingsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyBindingsResponse page) =>
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

        /// <summary>Snippet for ListPolicyBindings</summary>
        public void ListPolicyBindingsResourceNames2()
        {
            // Snippet: ListPolicyBindings(FolderLocationName, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListPolicyBindingsAsync</summary>
        public async Task ListPolicyBindingsResourceNames2Async()
        {
            // Snippet: ListPolicyBindingsAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyBindingsResponse page) =>
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

        /// <summary>Snippet for ListPolicyBindings</summary>
        public void ListPolicyBindingsResourceNames3()
        {
            // Snippet: ListPolicyBindings(LocationName, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindings(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListPolicyBindingsAsync</summary>
        public async Task ListPolicyBindingsResourceNames3Async()
        {
            // Snippet: ListPolicyBindingsAsync(LocationName, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.ListPolicyBindingsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPolicyBindingsResponse page) =>
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

        /// <summary>Snippet for SearchTargetPolicyBindings</summary>
        public void SearchTargetPolicyBindingsRequestObject()
        {
            // Snippet: SearchTargetPolicyBindings(SearchTargetPolicyBindingsRequest, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = "",
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindings(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchTargetPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchTargetPolicyBindingsAsync</summary>
        public async Task SearchTargetPolicyBindingsRequestObjectAsync()
        {
            // Snippet: SearchTargetPolicyBindingsAsync(SearchTargetPolicyBindingsRequest, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            SearchTargetPolicyBindingsRequest request = new SearchTargetPolicyBindingsRequest
            {
                Target = "",
                ParentAsOrganizationLocationName = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindingsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchTargetPolicyBindingsResponse page) =>
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

        /// <summary>Snippet for SearchTargetPolicyBindings</summary>
        public void SearchTargetPolicyBindings()
        {
            // Snippet: SearchTargetPolicyBindings(string, string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            string target = "";
            // Make the request
            PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindings(parent, target);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchTargetPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchTargetPolicyBindingsAsync</summary>
        public async Task SearchTargetPolicyBindingsAsync()
        {
            // Snippet: SearchTargetPolicyBindingsAsync(string, string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "organizations/[ORGANIZATION]/locations/[LOCATION]";
            string target = "";
            // Make the request
            PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindingsAsync(parent, target);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchTargetPolicyBindingsResponse page) =>
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

        /// <summary>Snippet for SearchTargetPolicyBindings</summary>
        public void SearchTargetPolicyBindingsResourceNames1()
        {
            // Snippet: SearchTargetPolicyBindings(OrganizationLocationName, string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            string target = "";
            // Make the request
            PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindings(parent, target);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchTargetPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchTargetPolicyBindingsAsync</summary>
        public async Task SearchTargetPolicyBindingsResourceNames1Async()
        {
            // Snippet: SearchTargetPolicyBindingsAsync(OrganizationLocationName, string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            string target = "";
            // Make the request
            PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindingsAsync(parent, target);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchTargetPolicyBindingsResponse page) =>
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

        /// <summary>Snippet for SearchTargetPolicyBindings</summary>
        public void SearchTargetPolicyBindingsResourceNames2()
        {
            // Snippet: SearchTargetPolicyBindings(FolderLocationName, string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            string target = "";
            // Make the request
            PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindings(parent, target);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchTargetPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchTargetPolicyBindingsAsync</summary>
        public async Task SearchTargetPolicyBindingsResourceNames2Async()
        {
            // Snippet: SearchTargetPolicyBindingsAsync(FolderLocationName, string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            string target = "";
            // Make the request
            PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindingsAsync(parent, target);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchTargetPolicyBindingsResponse page) =>
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

        /// <summary>Snippet for SearchTargetPolicyBindings</summary>
        public void SearchTargetPolicyBindingsResourceNames3()
        {
            // Snippet: SearchTargetPolicyBindings(LocationName, string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = PolicyBindingsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string target = "";
            // Make the request
            PagedEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindings(parent, target);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PolicyBinding item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchTargetPolicyBindingsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for SearchTargetPolicyBindingsAsync</summary>
        public async Task SearchTargetPolicyBindingsResourceNames3Async()
        {
            // Snippet: SearchTargetPolicyBindingsAsync(LocationName, string, string, int?, CallSettings)
            // Create client
            PolicyBindingsClient policyBindingsClient = await PolicyBindingsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string target = "";
            // Make the request
            PagedAsyncEnumerable<SearchTargetPolicyBindingsResponse, PolicyBinding> response = policyBindingsClient.SearchTargetPolicyBindingsAsync(parent, target);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PolicyBinding item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchTargetPolicyBindingsResponse page) =>
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
