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
    // [START gdchardwaremanagement_v1alpha_generated_GDCHardwareManagement_CreateHardware_sync_flattened]
    using Google.Cloud.GdcHardwareManagement.V1Alpha;
    using Google.LongRunning;

    public sealed partial class GeneratedGDCHardwareManagementClientSnippets
    {
        /// <summary>Snippet for CreateHardware</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateHardware()
        {
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Hardware hardware = new Hardware();
            string hardwareId = "";
            // Make the request
            Operation<Hardware, OperationMetadata> response = gDCHardwareManagementClient.CreateHardware(parent, hardware, hardwareId);

            // Poll until the returned long-running operation is complete
            Operation<Hardware, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Hardware result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Hardware, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCreateHardware(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Hardware retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gdchardwaremanagement_v1alpha_generated_GDCHardwareManagement_CreateHardware_sync_flattened]
}
