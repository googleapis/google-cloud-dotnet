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
    // [START configdelivery_v1beta_generated_ConfigDelivery_CreateFleetPackage_sync_flattened]
    using Google.Cloud.ConfigDelivery.V1Beta;
    using Google.LongRunning;

    public sealed partial class GeneratedConfigDeliveryClientSnippets
    {
        /// <summary>Snippet for CreateFleetPackage</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateFleetPackage()
        {
            // Create client
            ConfigDeliveryClient configDeliveryClient = ConfigDeliveryClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            FleetPackage fleetPackage = new FleetPackage();
            string fleetPackageId = "";
            // Make the request
            Operation<FleetPackage, OperationMetadata> response = configDeliveryClient.CreateFleetPackage(parent, fleetPackage, fleetPackageId);

            // Poll until the returned long-running operation is complete
            Operation<FleetPackage, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FleetPackage result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FleetPackage, OperationMetadata> retrievedResponse = configDeliveryClient.PollOnceCreateFleetPackage(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FleetPackage retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END configdelivery_v1beta_generated_ConfigDelivery_CreateFleetPackage_sync_flattened]
}
