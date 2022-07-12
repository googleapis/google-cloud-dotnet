// Copyright 2022 Google LLC
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

namespace Google.Cloud.DataLabeling.V1Beta1.Snippets
{
    // [START datalabeling_v1beta1_generated_DataLabelingService_ExportData_sync]
    using Google.Cloud.DataLabeling.V1Beta1;
    using Google.LongRunning;

    public sealed partial class GeneratedDataLabelingServiceClientSnippets
    {
        /// <summary>Snippet for ExportData</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ExportDataRequestObject()
        {
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            ExportDataRequest request = new ExportDataRequest
            {
                DatasetName = DatasetName.FromProjectDataset("[PROJECT]", "[DATASET]"),
                AnnotatedDatasetAsAnnotatedDatasetName = AnnotatedDatasetName.FromProjectDatasetAnnotatedDataset("[PROJECT]", "[DATASET]", "[ANNOTATED_DATASET]"),
                Filter = "",
                OutputConfig = new OutputConfig(),
                UserEmailAddress = "",
            };
            // Make the request
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> response = dataLabelingServiceClient.ExportData(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportDataOperationResponse, ExportDataOperationMetadata> retrievedResponse = dataLabelingServiceClient.PollOnceExportData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END datalabeling_v1beta1_generated_DataLabelingService_ExportData_sync]
}
