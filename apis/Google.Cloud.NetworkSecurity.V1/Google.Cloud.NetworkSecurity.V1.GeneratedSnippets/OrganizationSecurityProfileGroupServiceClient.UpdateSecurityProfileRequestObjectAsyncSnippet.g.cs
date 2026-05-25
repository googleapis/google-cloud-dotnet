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
    // [START networksecurity_v1_generated_OrganizationSecurityProfileGroupService_UpdateSecurityProfile_async]
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedOrganizationSecurityProfileGroupServiceClientSnippets
    {
        /// <summary>Snippet for UpdateSecurityProfileAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateSecurityProfileRequestObjectAsync()
        {
            // Create client
            OrganizationSecurityProfileGroupServiceClient organizationSecurityProfileGroupServiceClient = await OrganizationSecurityProfileGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSecurityProfileRequest request = new UpdateSecurityProfileRequest
            {
                UpdateMask = new FieldMask(),
                SecurityProfile = new SecurityProfile(),
            };
            // Make the request
            Operation<SecurityProfile, OperationMetadata> response = await organizationSecurityProfileGroupServiceClient.UpdateSecurityProfileAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SecurityProfile, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SecurityProfile result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SecurityProfile, OperationMetadata> retrievedResponse = await organizationSecurityProfileGroupServiceClient.PollOnceUpdateSecurityProfileAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SecurityProfile retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END networksecurity_v1_generated_OrganizationSecurityProfileGroupService_UpdateSecurityProfile_async]
}
