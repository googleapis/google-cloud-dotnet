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
    // [START parallelstore_v1beta_generated_Parallelstore_ImportData_sync]
    using Google.Cloud.Parallelstore.V1Beta;
    using Google.LongRunning;

    public sealed partial class GeneratedParallelstoreClientSnippets
    {
        /// <summary>Snippet for ImportData</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void ImportDataRequestObject()
        {
            // Create client
            ParallelstoreClient parallelstoreClient = ParallelstoreClient.Create();
            // Initialize request argument(s)
            ImportDataRequest request = new ImportDataRequest
            {
                InstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                SourceGcsBucket = new SourceGcsBucket(),
                DestinationParallelstore = new DestinationParallelstore(),
                RequestId = "",
                ServiceAccountAsServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
            };
            // Make the request
            Operation<ImportDataResponse, ImportDataMetadata> response = parallelstoreClient.ImportData(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportDataResponse, ImportDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportDataResponse, ImportDataMetadata> retrievedResponse = parallelstoreClient.PollOnceImportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportDataResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END parallelstore_v1beta_generated_Parallelstore_ImportData_sync]
}
