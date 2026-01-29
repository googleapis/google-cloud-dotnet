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
    // [START auditmanager_v1_generated_AuditManager_GetResourceEnrollmentStatus_async_flattened]
    using Google.Cloud.AuditManager.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedAuditManagerClientSnippets
    {
        /// <summary>Snippet for GetResourceEnrollmentStatusAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task GetResourceEnrollmentStatusAsync()
        {
            // Create client
            AuditManagerClient auditManagerClient = await AuditManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "folders/[FOLDER]/locations/[LOCATION]/resourceEnrollmentStatuses/[RESOURCE_ENROLLMENT_STATUS]";
            // Make the request
            ResourceEnrollmentStatus response = await auditManagerClient.GetResourceEnrollmentStatusAsync(name);
        }
    }
    // [END auditmanager_v1_generated_AuditManager_GetResourceEnrollmentStatus_async_flattened]
}
