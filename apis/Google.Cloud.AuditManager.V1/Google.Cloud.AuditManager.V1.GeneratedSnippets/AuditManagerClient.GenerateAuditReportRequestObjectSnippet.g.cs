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
    // [START auditmanager_v1_generated_AuditManager_GenerateAuditReport_sync]
    using Google.Cloud.AuditManager.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedAuditManagerClientSnippets
    {
        /// <summary>Snippet for GenerateAuditReport</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GenerateAuditReportRequestObject()
        {
            // Create client
            AuditManagerClient auditManagerClient = AuditManagerClient.Create();
            // Initialize request argument(s)
            GenerateAuditReportRequest request = new GenerateAuditReportRequest
            {
                Scope = "",
                GcsUri = "",
                ComplianceStandard = "",
                ReportFormat = GenerateAuditReportRequest.Types.AuditReportFormat.Unspecified,
                ComplianceFramework = "",
            };
            // Make the request
            Operation<AuditReport, OperationMetadata> response = auditManagerClient.GenerateAuditReport(request);

            // Poll until the returned long-running operation is complete
            Operation<AuditReport, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuditReport result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuditReport, OperationMetadata> retrievedResponse = auditManagerClient.PollOnceGenerateAuditReport(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuditReport retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END auditmanager_v1_generated_AuditManager_GenerateAuditReport_sync]
}
