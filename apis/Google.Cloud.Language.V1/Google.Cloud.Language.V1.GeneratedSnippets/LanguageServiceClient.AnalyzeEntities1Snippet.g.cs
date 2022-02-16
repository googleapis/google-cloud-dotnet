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

namespace Google.Cloud.Language.V1.Snippets
{
    // [START language_v1_generated_LanguageService_AnalyzeEntities_sync_flattened1]
    using Google.Cloud.Language.V1;

    public sealed partial class GeneratedLanguageServiceClientSnippets
    {
        /// <summary>Snippet for AnalyzeEntities</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void AnalyzeEntities1()
        {
            // Create client
            LanguageServiceClient languageServiceClient = LanguageServiceClient.Create();
            // Initialize request argument(s)
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            // Make the request
            AnalyzeEntitiesResponse response = languageServiceClient.AnalyzeEntities(document, encodingType);
        }
    }
    // [END language_v1_generated_LanguageService_AnalyzeEntities_sync_flattened1]
}
