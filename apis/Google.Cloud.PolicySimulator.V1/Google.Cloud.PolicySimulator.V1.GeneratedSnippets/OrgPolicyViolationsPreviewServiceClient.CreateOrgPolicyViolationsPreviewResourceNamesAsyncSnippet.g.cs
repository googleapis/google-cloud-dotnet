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
    // [START policysimulator_v1_generated_OrgPolicyViolationsPreviewService_CreateOrgPolicyViolationsPreview_async_flattened_resourceNames]
    using Google.Cloud.PolicySimulator.V1;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedOrgPolicyViolationsPreviewServiceClientSnippets
    {
        /// <summary>Snippet for CreateOrgPolicyViolationsPreviewAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateOrgPolicyViolationsPreviewResourceNamesAsync()
        {
            // Create client
            OrgPolicyViolationsPreviewServiceClient orgPolicyViolationsPreviewServiceClient = await OrgPolicyViolationsPreviewServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            OrgPolicyViolationsPreview orgPolicyViolationsPreview = new OrgPolicyViolationsPreview();
            string orgPolicyViolationsPreviewId = "";
            // Make the request
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> response = await orgPolicyViolationsPreviewServiceClient.CreateOrgPolicyViolationsPreviewAsync(parent, orgPolicyViolationsPreview, orgPolicyViolationsPreviewId);

            // Poll until the returned long-running operation is complete
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OrgPolicyViolationsPreview result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrgPolicyViolationsPreview, CreateOrgPolicyViolationsPreviewOperationMetadata> retrievedResponse = await orgPolicyViolationsPreviewServiceClient.PollOnceCreateOrgPolicyViolationsPreviewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrgPolicyViolationsPreview retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END policysimulator_v1_generated_OrgPolicyViolationsPreviewService_CreateOrgPolicyViolationsPreview_async_flattened_resourceNames]
}
