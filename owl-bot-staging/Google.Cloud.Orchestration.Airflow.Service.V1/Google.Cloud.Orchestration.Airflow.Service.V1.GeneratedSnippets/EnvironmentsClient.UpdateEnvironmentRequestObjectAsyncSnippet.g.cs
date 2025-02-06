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
    // [START composer_v1_generated_Environments_UpdateEnvironment_async]
    using Google.Cloud.Orchestration.Airflow.Service.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedEnvironmentsClientSnippets
    {
        /// <summary>Snippet for UpdateEnvironmentAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateEnvironmentRequestObjectAsync()
        {
            // Create client
            EnvironmentsClient environmentsClient = await EnvironmentsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEnvironmentRequest request = new UpdateEnvironmentRequest
            {
                Environment = new Environment(),
                Name = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Environment, OperationMetadata> response = await environmentsClient.UpdateEnvironmentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Environment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Environment, OperationMetadata> retrievedResponse = await environmentsClient.PollOnceUpdateEnvironmentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Environment retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END composer_v1_generated_Environments_UpdateEnvironment_async]
}
