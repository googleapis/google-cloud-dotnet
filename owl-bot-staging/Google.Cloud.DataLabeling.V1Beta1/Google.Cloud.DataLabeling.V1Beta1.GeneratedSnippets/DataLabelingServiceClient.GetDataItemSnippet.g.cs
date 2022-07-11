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
    // [START datalabeling_v1beta1_generated_DataLabelingService_GetDataItem_sync_flattened]
    using Google.Cloud.DataLabeling.V1Beta1;

    public sealed partial class GeneratedDataLabelingServiceClientSnippets
    {
        /// <summary>Snippet for GetDataItem</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetDataItem()
        {
            // Create client
            DataLabelingServiceClient dataLabelingServiceClient = DataLabelingServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/datasets/[DATASET]/dataItems/[DATA_ITEM]";
            // Make the request
            DataItem response = dataLabelingServiceClient.GetDataItem(name);
        }
    }
    // [END datalabeling_v1beta1_generated_DataLabelingService_GetDataItem_sync_flattened]
}
