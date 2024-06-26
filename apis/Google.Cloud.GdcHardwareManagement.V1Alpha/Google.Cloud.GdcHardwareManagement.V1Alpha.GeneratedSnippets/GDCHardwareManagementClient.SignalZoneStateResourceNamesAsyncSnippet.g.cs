// Copyright 2024 Google LLC
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
    // [START gdchardwaremanagement_v1alpha_generated_GDCHardwareManagement_SignalZoneState_async_flattened_resourceNames]
    using Google.Cloud.GdcHardwareManagement.V1Alpha;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGDCHardwareManagementClientSnippets
    {
        /// <summary>Snippet for SignalZoneStateAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task SignalZoneStateResourceNamesAsync()
        {
            // Create client
            GDCHardwareManagementClient gDCHardwareManagementClient = await GDCHardwareManagementClient.CreateAsync();
            // Initialize request argument(s)
            ZoneName name = ZoneName.FromProjectLocationZone("[PROJECT]", "[LOCATION]", "[ZONE]");
            SignalZoneStateRequest.Types.StateSignal stateSignal = SignalZoneStateRequest.Types.StateSignal.Unspecified;
            // Make the request
            Operation<Zone, OperationMetadata> response = await gDCHardwareManagementClient.SignalZoneStateAsync(name, stateSignal);

            // Poll until the returned long-running operation is complete
            Operation<Zone, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Zone result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Zone, OperationMetadata> retrievedResponse = await gDCHardwareManagementClient.PollOnceSignalZoneStateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Zone retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END gdchardwaremanagement_v1alpha_generated_GDCHardwareManagement_SignalZoneState_async_flattened_resourceNames]
}
