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
    // [START gdchardwaremanagement_v1alpha_generated_GDCHardwareManagement_CancelOrder_sync_flattened_resourceNames]
    using Google.Cloud.GdcHardwareManagement.V1Alpha;
    using Google.LongRunning;

    public sealed partial class GeneratedGDCHardwareManagementClientSnippets
    {
        /// <summary>Snippet for CancelOrder</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CancelOrderResourceNames()
        {
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = GDCHardwareManagementClient.Create();
            // Initialize request argument(s)
            OrderName name = OrderName.FromProjectLocationOrder("[PROJECT]", "[LOCATION]", "[ORDER]");
            // Make the request
            Operation<Order, OperationMetadata> response = gDCHardwareManagementClient.CancelOrder(name);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = gDCHardwareManagementClient.PollOnceCancelOrder(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gdchardwaremanagement_v1alpha_generated_GDCHardwareManagement_CancelOrder_sync_flattened_resourceNames]
}
