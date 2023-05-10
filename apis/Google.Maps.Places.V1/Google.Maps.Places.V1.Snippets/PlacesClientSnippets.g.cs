// Copyright 2023 Google LLC
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
    using Google.Maps.Places.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPlacesClientSnippets
    {
        /// <summary>Snippet for SearchText</summary>
        public void SearchTextRequestObject()
        {
            // Snippet: SearchText(SearchTextRequest, CallSettings)
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            SearchTextRequest request = new SearchTextRequest
            {
                TextQuery = "",
                LanguageCode = "",
                RegionCode = "",
                RankPreference = SearchTextRequest.Types.RankPreference.Unspecified,
                IncludedType = "",
                OpenNow = false,
                MinRating = 0,
                MaxResultCount = 0,
                PriceLevels =
                {
                    PriceLevel.Unspecified,
                },
                StrictTypeFiltering = false,
                LocationBias = new SearchTextRequest.Types.LocationBias(),
                LocationRestriction = new SearchTextRequest.Types.LocationRestriction(),
            };
            // Make the request
            SearchTextResponse response = placesClient.SearchText(request);
            // End snippet
        }

        /// <summary>Snippet for SearchTextAsync</summary>
        public async Task SearchTextRequestObjectAsync()
        {
            // Snippet: SearchTextAsync(SearchTextRequest, CallSettings)
            // Additional: SearchTextAsync(SearchTextRequest, CancellationToken)
            // Create client
            PlacesClient placesClient = await PlacesClient.CreateAsync();
            // Initialize request argument(s)
            SearchTextRequest request = new SearchTextRequest
            {
                TextQuery = "",
                LanguageCode = "",
                RegionCode = "",
                RankPreference = SearchTextRequest.Types.RankPreference.Unspecified,
                IncludedType = "",
                OpenNow = false,
                MinRating = 0,
                MaxResultCount = 0,
                PriceLevels =
                {
                    PriceLevel.Unspecified,
                },
                StrictTypeFiltering = false,
                LocationBias = new SearchTextRequest.Types.LocationBias(),
                LocationRestriction = new SearchTextRequest.Types.LocationRestriction(),
            };
            // Make the request
            SearchTextResponse response = await placesClient.SearchTextAsync(request);
            // End snippet
        }
    }
}
