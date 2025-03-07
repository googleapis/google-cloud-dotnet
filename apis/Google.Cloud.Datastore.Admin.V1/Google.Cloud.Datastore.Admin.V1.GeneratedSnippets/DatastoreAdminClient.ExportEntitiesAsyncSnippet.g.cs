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
    // [START datastore_v1_generated_DatastoreAdmin_ExportEntities_async_flattened]
    using Google.Cloud.Datastore.Admin.V1;
    using Google.LongRunning;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDatastoreAdminClientSnippets
    {
        /// <summary>Snippet for ExportEntitiesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ExportEntitiesAsync()
        {
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            IDictionary<string, string> labels = new Dictionary<string, string> { { "", "" }, };
            EntityFilter entityFilter = new EntityFilter();
            string outputUrlPrefix = "";
            // Make the request
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> response = await datastoreAdminClient.ExportEntitiesAsync(projectId, labels, entityFilter, outputUrlPrefix);

            // Poll until the returned long-running operation is complete
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportEntitiesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportEntitiesResponse, ExportEntitiesMetadata> retrievedResponse = await datastoreAdminClient.PollOnceExportEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportEntitiesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END datastore_v1_generated_DatastoreAdmin_ExportEntities_async_flattened]
}
