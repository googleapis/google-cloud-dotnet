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
    // [START securitycentermanagement_v1_generated_SecurityCenterManagement_DeleteSecurityHealthAnalyticsCustomModule_sync]
    using Google.Cloud.SecurityCenterManagement.V1;

    public sealed partial class GeneratedSecurityCenterManagementClientSnippets
    {
        /// <summary>Snippet for DeleteSecurityHealthAnalyticsCustomModule</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void DeleteSecurityHealthAnalyticsCustomModuleRequestObject()
        {
            // Create client
            SecurityCenterManagementClient securityCenterManagementClient = SecurityCenterManagementClient.Create();
            // Initialize request argument(s)
            DeleteSecurityHealthAnalyticsCustomModuleRequest request = new DeleteSecurityHealthAnalyticsCustomModuleRequest
            {
                SecurityHealthAnalyticsCustomModuleName = SecurityHealthAnalyticsCustomModuleName.FromOrganizationLocationSecurityHealthAnalyticsCustomModule("[ORGANIZATION]", "[LOCATION]", "[SECURITY_HEALTH_ANALYTICS_CUSTOM_MODULE]"),
                ValidateOnly = false,
            };
            // Make the request
            securityCenterManagementClient.DeleteSecurityHealthAnalyticsCustomModule(request);
        }
    }
    // [END securitycentermanagement_v1_generated_SecurityCenterManagement_DeleteSecurityHealthAnalyticsCustomModule_sync]
}
