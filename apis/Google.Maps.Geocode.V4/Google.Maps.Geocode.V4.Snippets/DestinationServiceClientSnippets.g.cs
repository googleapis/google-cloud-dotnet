// Copyright 2026 Google LLC
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
    using Google.Maps.Geocode.V4;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDestinationServiceClientSnippets
    {
        /// <summary>Snippet for SearchDestinations</summary>
        public void SearchDestinationsRequestObject()
        {
            // Snippet: SearchDestinations(SearchDestinationsRequest, CallSettings)
            // Create client
            DestinationServiceClient destinationServiceClient = DestinationServiceClient.Create();
            // Initialize request argument(s)
            SearchDestinationsRequest request = new SearchDestinationsRequest
            {
                Place = "",
                TravelModes =
                {
                    NavigationPoint.Types.TravelMode.Unspecified,
                },
                LanguageCode = "",
                RegionCode = "",
            };
            // Make the request
            SearchDestinationsResponse response = destinationServiceClient.SearchDestinations(request);
            // End snippet
        }

        /// <summary>Snippet for SearchDestinationsAsync</summary>
        public async Task SearchDestinationsRequestObjectAsync()
        {
            // Snippet: SearchDestinationsAsync(SearchDestinationsRequest, CallSettings)
            // Additional: SearchDestinationsAsync(SearchDestinationsRequest, CancellationToken)
            // Create client
            DestinationServiceClient destinationServiceClient = await DestinationServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchDestinationsRequest request = new SearchDestinationsRequest
            {
                Place = "",
                TravelModes =
                {
                    NavigationPoint.Types.TravelMode.Unspecified,
                },
                LanguageCode = "",
                RegionCode = "",
            };
            // Make the request
            SearchDestinationsResponse response = await destinationServiceClient.SearchDestinationsAsync(request);
            // End snippet
        }
    }
}
