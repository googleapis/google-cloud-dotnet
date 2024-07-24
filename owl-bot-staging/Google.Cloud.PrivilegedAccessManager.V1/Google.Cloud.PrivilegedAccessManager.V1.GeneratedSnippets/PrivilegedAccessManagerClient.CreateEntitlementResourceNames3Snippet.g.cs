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

namespace GoogleCSharpSnippets
{
    // [START privilegedaccessmanager_v1_generated_PrivilegedAccessManager_CreateEntitlement_sync_flattened_resourceNames3]
    using Google.Cloud.PrivilegedAccessManager.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedPrivilegedAccessManagerClientSnippets
    {
        /// <summary>Snippet for CreateEntitlement</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateEntitlementResourceNames3()
        {
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            Entitlement entitlement = new Entitlement();
            string entitlementId = "";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.CreateEntitlement(parent, entitlement, entitlementId);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceCreateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END privilegedaccessmanager_v1_generated_PrivilegedAccessManager_CreateEntitlement_sync_flattened_resourceNames3]
}
