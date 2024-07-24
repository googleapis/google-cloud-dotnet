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
    // [START recommender_v1_generated_Recommender_GetInsightTypeConfig_sync]
    using Google.Cloud.Recommender.V1;

    public sealed partial class GeneratedRecommenderClientSnippets
    {
        /// <summary>Snippet for GetInsightTypeConfig</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GetInsightTypeConfigRequestObject()
        {
            // Create client
            RecommenderClient recommenderClient = RecommenderClient.Create();
            // Initialize request argument(s)
            GetInsightTypeConfigRequest request = new GetInsightTypeConfigRequest
            {
                InsightTypeConfigName = InsightTypeConfigName.FromProjectLocationInsightType("[PROJECT]", "[LOCATION]", "[INSIGHT_TYPE]"),
            };
            // Make the request
            InsightTypeConfig response = recommenderClient.GetInsightTypeConfig(request);
        }
    }
    // [END recommender_v1_generated_Recommender_GetInsightTypeConfig_sync]
}
