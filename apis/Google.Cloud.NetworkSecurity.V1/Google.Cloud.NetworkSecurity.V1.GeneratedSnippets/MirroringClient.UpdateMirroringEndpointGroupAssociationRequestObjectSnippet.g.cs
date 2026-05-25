// Copyright 2026 Google LLC
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
    // [START networksecurity_v1_generated_Mirroring_UpdateMirroringEndpointGroupAssociation_sync]
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedMirroringClientSnippets
    {
        /// <summary>Snippet for UpdateMirroringEndpointGroupAssociation</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpdateMirroringEndpointGroupAssociationRequestObject()
        {
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            UpdateMirroringEndpointGroupAssociationRequest request = new UpdateMirroringEndpointGroupAssociationRequest
            {
                UpdateMask = new FieldMask(),
                MirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = mirroringClient.UpdateMirroringEndpointGroupAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = mirroringClient.PollOnceUpdateMirroringEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END networksecurity_v1_generated_Mirroring_UpdateMirroringEndpointGroupAssociation_sync]
}
