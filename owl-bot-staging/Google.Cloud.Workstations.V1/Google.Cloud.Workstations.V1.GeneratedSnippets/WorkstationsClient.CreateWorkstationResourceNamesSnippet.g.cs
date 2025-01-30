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
    // [START workstations_v1_generated_Workstations_CreateWorkstation_sync_flattened_resourceNames]
    using Google.Cloud.Workstations.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedWorkstationsClientSnippets
    {
        /// <summary>Snippet for CreateWorkstation</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateWorkstationResourceNames()
        {
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationConfigName parent = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            Workstation workstation = new Workstation();
            string workstationId = "";
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.CreateWorkstation(parent, workstation, workstationId);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END workstations_v1_generated_Workstations_CreateWorkstation_sync_flattened_resourceNames]
}
