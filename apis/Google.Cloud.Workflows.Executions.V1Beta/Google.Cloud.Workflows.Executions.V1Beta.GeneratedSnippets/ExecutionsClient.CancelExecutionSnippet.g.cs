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
    // [START workflowexecutions_v1beta_generated_Executions_CancelExecution_sync_flattened]
    using Google.Cloud.Workflows.Executions.V1Beta;

    public sealed partial class GeneratedExecutionsClientSnippets
    {
        /// <summary>Snippet for CancelExecution</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CancelExecution()
        {
            // Create client
            ExecutionsClient executionsClient = ExecutionsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workflows/[WORKFLOW]/executions/[EXECUTION]";
            // Make the request
            Execution response = executionsClient.CancelExecution(name);
        }
    }
    // [END workflowexecutions_v1beta_generated_Executions_CancelExecution_sync_flattened]
}
