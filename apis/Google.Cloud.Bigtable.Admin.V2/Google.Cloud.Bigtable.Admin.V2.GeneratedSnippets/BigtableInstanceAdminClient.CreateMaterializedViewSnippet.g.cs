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
    // [START bigtableadmin_v2_generated_BigtableInstanceAdmin_CreateMaterializedView_sync_flattened]
    using Google.Cloud.Bigtable.Admin.V2;
    using Google.LongRunning;

    public sealed partial class GeneratedBigtableInstanceAdminClientSnippets
    {
        /// <summary>Snippet for CreateMaterializedView</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateMaterializedView()
        {
            // Create client
            BigtableInstanceAdminClient bigtableInstanceAdminClient = BigtableInstanceAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            MaterializedView materializedView = new MaterializedView();
            string materializedViewId = "";
            // Make the request
            Operation<MaterializedView, CreateMaterializedViewMetadata> response = bigtableInstanceAdminClient.CreateMaterializedView(parent, materializedView, materializedViewId);

            // Poll until the returned long-running operation is complete
            Operation<MaterializedView, CreateMaterializedViewMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MaterializedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MaterializedView, CreateMaterializedViewMetadata> retrievedResponse = bigtableInstanceAdminClient.PollOnceCreateMaterializedView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MaterializedView retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END bigtableadmin_v2_generated_BigtableInstanceAdmin_CreateMaterializedView_sync_flattened]
}
