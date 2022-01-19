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

namespace Google.Cloud.DataQnA.V1Alpha.Snippets
{
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.DataQnA.V1Alpha;

    public sealed partial class GeneratedAutoSuggestionServiceClientStandaloneSnippets
    {
        /// <summary>Snippet for SuggestQueries</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void SuggestQueriesRequestObject()
        {
            // Create client
            AutoSuggestionServiceClient autoSuggestionServiceClient = AutoSuggestionServiceClient.Create();
            // Initialize request argument(s)
            SuggestQueriesRequest request = new SuggestQueriesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Scopes = { "", },
                Query = "",
                SuggestionTypes =
                {
                    SuggestionType.Unspecified,
                },
            };
            // Make the request
            SuggestQueriesResponse response = autoSuggestionServiceClient.SuggestQueries(request);
        }
    }
}
