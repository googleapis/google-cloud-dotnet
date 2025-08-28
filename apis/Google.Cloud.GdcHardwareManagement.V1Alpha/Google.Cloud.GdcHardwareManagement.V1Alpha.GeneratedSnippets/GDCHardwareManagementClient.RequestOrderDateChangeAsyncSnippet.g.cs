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
    // [START gdchardwaremanagement_v1alpha_generated_GDCHardwareManagement_RequestOrderDateChange_async_flattened]
    using Google.Cloud.GdcHardwareManagement.V1Alpha;
    using Google.LongRunning;
    using Google.Type;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGDCHardwareManagementClientSnippets
    {
        /// <summary>Snippet for RequestOrderDateChangeAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task RequestOrderDateChangeAsync()
        {
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orders/[ORDER]";
            Date requestedDate = new Date();
            // Make the request
            Operation<Order, OperationMetadata> response = await gDCHardwareManagementClient.RequestOrderDateChangeAsync(name, requestedDate);

            // Poll until the returned long-running operation is complete
            Operation<Order, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Order result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Order, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceRequestOrderDateChangeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Order retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gdchardwaremanagement_v1alpha_generated_GDCHardwareManagement_RequestOrderDateChange_async_flattened]
}
