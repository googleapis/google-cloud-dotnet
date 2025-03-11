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
    // [START dataplex_v1_generated_DataTaxonomyService_CreateDataAttribute_sync_flattened]
    using Google.Cloud.Dataplex.V1;
    using Google.LongRunning;
    using System;

    public sealed partial class GeneratedDataTaxonomyServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataAttribute</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        [ObsoleteAttribute]
        public void CreateDataAttribute()
        {
            // Create client
            DataTaxonomyServiceClient dataTaxonomyServiceClient = DataTaxonomyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataTaxonomies/[DATA_TAXONOMY_ID]";
#pragma warning disable CS0612
            DataAttribute dataAttribute = new DataAttribute();
#pragma warning restore CS0612
            string dataAttributeId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<DataAttribute, OperationMetadata> response = dataTaxonomyServiceClient.CreateDataAttribute(parent, dataAttribute, dataAttributeId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<DataAttribute, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            DataAttribute result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<DataAttribute, OperationMetadata> retrievedResponse = dataTaxonomyServiceClient.PollOnceCreateDataAttribute(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                DataAttribute retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
            }
        }
    }
    // [END dataplex_v1_generated_DataTaxonomyService_CreateDataAttribute_sync_flattened]
}
