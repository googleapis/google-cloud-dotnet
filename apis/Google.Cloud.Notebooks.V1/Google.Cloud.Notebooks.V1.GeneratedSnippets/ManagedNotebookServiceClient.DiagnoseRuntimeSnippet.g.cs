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
    // [START notebooks_v1_generated_ManagedNotebookService_DiagnoseRuntime_sync_flattened]
    using Google.Cloud.Notebooks.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedManagedNotebookServiceClientSnippets
    {
        /// <summary>Snippet for DiagnoseRuntime</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void DiagnoseRuntime()
        {
            // Create client
            ManagedNotebookServiceClient managedNotebookServiceClient = ManagedNotebookServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimes/[RUNTIME]";
            DiagnosticConfig diagnosticConfig = new DiagnosticConfig();
            // Make the request
            Operation<Runtime, OperationMetadata> response = managedNotebookServiceClient.DiagnoseRuntime(name, diagnosticConfig);

            // Poll until the returned long-running operation is complete
            Operation<Runtime, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Runtime result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Runtime, OperationMetadata> retrievedResponse = managedNotebookServiceClient.PollOnceDiagnoseRuntime(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Runtime retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END notebooks_v1_generated_ManagedNotebookService_DiagnoseRuntime_sync_flattened]
}
