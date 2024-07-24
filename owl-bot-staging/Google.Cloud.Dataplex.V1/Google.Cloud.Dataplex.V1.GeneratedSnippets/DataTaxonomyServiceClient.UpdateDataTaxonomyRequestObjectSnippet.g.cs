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
    // [START dataplex_v1_generated_DataTaxonomyService_UpdateDataTaxonomy_sync]
    using Google.Cloud.Dataplex.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedDataTaxonomyServiceClientSnippets
    {
        /// <summary>Snippet for UpdateDataTaxonomy</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void UpdateDataTaxonomyRequestObject()
        {
            // Create client
            DataTaxonomyServiceClient dataTaxonomyServiceClient = DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataTaxonomyRequest request = new UpdateDataTaxonomyRequest
            {
                UpdateMask = new FieldMask(),
                DataTaxonomy = new DataTaxonomy(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<DataTaxonomy, OperationMetadata> response = dataTaxonomyServiceClient.UpdateDataTaxonomy(request);

            // Poll until the returned long-running operation is complete
            Operation<DataTaxonomy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataTaxonomy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataTaxonomy, OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceUpdateDataTaxonomy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataTaxonomy retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataplex_v1_generated_DataTaxonomyService_UpdateDataTaxonomy_sync]
}
