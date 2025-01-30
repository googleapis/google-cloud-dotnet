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
    // [START apigateway_v1_generated_ApiGatewayService_UpdateApiConfig_async_flattened]
    using Google.Cloud.ApiGateway.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedApiGatewayServiceClientSnippets
    {
        /// <summary>Snippet for UpdateApiConfigAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task UpdateApiConfigAsync()
        {
            // Create client
            ApiGatewayServiceClient apiGatewayServiceClient = await ApiGatewayServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApiConfig apiConfig = new ApiConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ApiConfig, OperationMetadata> response = await apiGatewayServiceClient.UpdateApiConfigAsync(apiConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ApiConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ApiConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ApiConfig, OperationMetadata> retrievedResponse = await apiGatewayServiceClient.PollOnceUpdateApiConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ApiConfig retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END apigateway_v1_generated_ApiGatewayService_UpdateApiConfig_async_flattened]
}
