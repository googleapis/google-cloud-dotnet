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
    // [START retail_v2_generated_GenerativeQuestionService_BatchUpdateGenerativeQuestionConfigs_async]
    using Google.Cloud.Retail.V2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedGenerativeQuestionServiceClientSnippets
    {
        /// <summary>Snippet for BatchUpdateGenerativeQuestionConfigsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task BatchUpdateGenerativeQuestionConfigsRequestObjectAsync()
        {
            // Create client
            GenerativeQuestionServiceClient generativeQuestionServiceClient = await GenerativeQuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateGenerativeQuestionConfigsRequest request = new BatchUpdateGenerativeQuestionConfigsRequest
            {
                ParentAsCatalogName = CatalogName.FromProjectLocationCatalog("[PROJECT]", "[LOCATION]", "[CATALOG]"),
                Requests =
                {
                    new UpdateGenerativeQuestionConfigRequest(),
                },
            };
            // Make the request
            BatchUpdateGenerativeQuestionConfigsResponse response = await generativeQuestionServiceClient.BatchUpdateGenerativeQuestionConfigsAsync(request);
        }
    }
    // [END retail_v2_generated_GenerativeQuestionService_BatchUpdateGenerativeQuestionConfigs_async]
}
