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
    // [START aiplatform_v1beta1_generated_FeatureOnlineStoreAdminService_UpdateFeatureView_sync_flattened]
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedFeatureOnlineStoreAdminServiceClientSnippets
    {
        /// <summary>Snippet for UpdateFeatureView</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpdateFeatureView()
        {
            // Create client
            FeatureOnlineStoreAdminServiceClient featureOnlineStoreAdminServiceClient = FeatureOnlineStoreAdminServiceClient.Create();
            // Initialize request argument(s)
            FeatureView featureView = new FeatureView();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> response = featureOnlineStoreAdminServiceClient.UpdateFeatureView(featureView, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            FeatureView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<FeatureView, UpdateFeatureViewOperationMetadata> retrievedResponse = featureOnlineStoreAdminServiceClient.PollOnceUpdateFeatureView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                FeatureView retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1beta1_generated_FeatureOnlineStoreAdminService_UpdateFeatureView_sync_flattened]
}
