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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedAutoSuggestionServiceClientSnippets
    {
        /// <summary>Snippet for SuggestQueries</summary>
        public void SuggestQueriesRequestObject()
        {
            // Snippet: SuggestQueries(SuggestQueriesRequest, CallSettings)
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
            // End snippet
        }

        /// <summary>Snippet for SuggestQueriesAsync</summary>
        public async Task SuggestQueriesRequestObjectAsync()
        {
            // Snippet: SuggestQueriesAsync(SuggestQueriesRequest, CallSettings)
            // Additional: SuggestQueriesAsync(SuggestQueriesRequest, CancellationToken)
            // Create client
            AutoSuggestionServiceClient autoSuggestionServiceClient = await AutoSuggestionServiceClient.CreateAsync();
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
            SuggestQueriesResponse response = await autoSuggestionServiceClient.SuggestQueriesAsync(request);
            // End snippet
        }
    }
}
