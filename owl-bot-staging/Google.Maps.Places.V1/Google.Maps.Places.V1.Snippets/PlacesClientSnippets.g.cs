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
    using Google.Maps.Places.V1;
    using Google.Type;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPlacesClientSnippets
    {
        /// <summary>Snippet for SearchNearby</summary>
        public void SearchNearbyRequestObject()
        {
            // Snippet: SearchNearby(SearchNearbyRequest, CallSettings)
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            SearchNearbyRequest request = new SearchNearbyRequest
            {
                LanguageCode = "",
                RegionCode = "",
                IncludedTypes = { "", },
                ExcludedTypes = { "", },
                IncludedPrimaryTypes = { "", },
                ExcludedPrimaryTypes = { "", },
                MaxResultCount = 0,
                LocationRestriction = new SearchNearbyRequest.Types.LocationRestriction(),
                RankPreference = SearchNearbyRequest.Types.RankPreference.Unspecified,
                RoutingParameters = new RoutingParameters(),
            };
            // Make the request
            SearchNearbyResponse response = placesClient.SearchNearby(request);
            // End snippet
        }

        /// <summary>Snippet for SearchNearbyAsync</summary>
        public async Task SearchNearbyRequestObjectAsync()
        {
            // Snippet: SearchNearbyAsync(SearchNearbyRequest, CallSettings)
            // Additional: SearchNearbyAsync(SearchNearbyRequest, CancellationToken)
            // Create client
            PlacesClient placesClient = await PlacesClient.CreateAsync();
            // Initialize request argument(s)
            SearchNearbyRequest request = new SearchNearbyRequest
            {
                LanguageCode = "",
                RegionCode = "",
                IncludedTypes = { "", },
                ExcludedTypes = { "", },
                IncludedPrimaryTypes = { "", },
                ExcludedPrimaryTypes = { "", },
                MaxResultCount = 0,
                LocationRestriction = new SearchNearbyRequest.Types.LocationRestriction(),
                RankPreference = SearchNearbyRequest.Types.RankPreference.Unspecified,
                RoutingParameters = new RoutingParameters(),
            };
            // Make the request
            SearchNearbyResponse response = await placesClient.SearchNearbyAsync(request);
            // End snippet
        }

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
                EvOptions = new SearchTextRequest.Types.EVOptions(),
                RoutingParameters = new RoutingParameters(),
                SearchAlongRouteParameters = new SearchTextRequest.Types.SearchAlongRouteParameters(),
                IncludePureServiceAreaBusinesses = false,
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
                EvOptions = new SearchTextRequest.Types.EVOptions(),
                RoutingParameters = new RoutingParameters(),
                SearchAlongRouteParameters = new SearchTextRequest.Types.SearchAlongRouteParameters(),
                IncludePureServiceAreaBusinesses = false,
            };
            // Make the request
            SearchTextResponse response = await placesClient.SearchTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhotoMedia</summary>
        public void GetPhotoMediaRequestObject()
        {
            // Snippet: GetPhotoMedia(GetPhotoMediaRequest, CallSettings)
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            GetPhotoMediaRequest request = new GetPhotoMediaRequest
            {
                PhotoMediaName = PhotoMediaName.FromPlacePhotoReference("[PLACE_ID]", "[PHOTO_REFERENCE]"),
                MaxWidthPx = 0,
                MaxHeightPx = 0,
                SkipHttpRedirect = false,
            };
            // Make the request
            PhotoMedia response = placesClient.GetPhotoMedia(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhotoMediaAsync</summary>
        public async Task GetPhotoMediaRequestObjectAsync()
        {
            // Snippet: GetPhotoMediaAsync(GetPhotoMediaRequest, CallSettings)
            // Additional: GetPhotoMediaAsync(GetPhotoMediaRequest, CancellationToken)
            // Create client
            PlacesClient placesClient = await PlacesClient.CreateAsync();
            // Initialize request argument(s)
            GetPhotoMediaRequest request = new GetPhotoMediaRequest
            {
                PhotoMediaName = PhotoMediaName.FromPlacePhotoReference("[PLACE_ID]", "[PHOTO_REFERENCE]"),
                MaxWidthPx = 0,
                MaxHeightPx = 0,
                SkipHttpRedirect = false,
            };
            // Make the request
            PhotoMedia response = await placesClient.GetPhotoMediaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhotoMedia</summary>
        public void GetPhotoMedia()
        {
            // Snippet: GetPhotoMedia(string, CallSettings)
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            string name = "places/[PLACE_ID]/photos/[PHOTO_REFERENCE]/media";
            // Make the request
            PhotoMedia response = placesClient.GetPhotoMedia(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhotoMediaAsync</summary>
        public async Task GetPhotoMediaAsync()
        {
            // Snippet: GetPhotoMediaAsync(string, CallSettings)
            // Additional: GetPhotoMediaAsync(string, CancellationToken)
            // Create client
            PlacesClient placesClient = await PlacesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "places/[PLACE_ID]/photos/[PHOTO_REFERENCE]/media";
            // Make the request
            PhotoMedia response = await placesClient.GetPhotoMediaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhotoMedia</summary>
        public void GetPhotoMediaResourceNames()
        {
            // Snippet: GetPhotoMedia(PhotoMediaName, CallSettings)
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            PhotoMediaName name = PhotoMediaName.FromPlacePhotoReference("[PLACE_ID]", "[PHOTO_REFERENCE]");
            // Make the request
            PhotoMedia response = placesClient.GetPhotoMedia(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhotoMediaAsync</summary>
        public async Task GetPhotoMediaResourceNamesAsync()
        {
            // Snippet: GetPhotoMediaAsync(PhotoMediaName, CallSettings)
            // Additional: GetPhotoMediaAsync(PhotoMediaName, CancellationToken)
            // Create client
            PlacesClient placesClient = await PlacesClient.CreateAsync();
            // Initialize request argument(s)
            PhotoMediaName name = PhotoMediaName.FromPlacePhotoReference("[PLACE_ID]", "[PHOTO_REFERENCE]");
            // Make the request
            PhotoMedia response = await placesClient.GetPhotoMediaAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlace</summary>
        public void GetPlaceRequestObject()
        {
            // Snippet: GetPlace(GetPlaceRequest, CallSettings)
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            GetPlaceRequest request = new GetPlaceRequest
            {
                PlaceName = PlaceName.FromPlace("[PLACE_ID]"),
                LanguageCode = "",
                RegionCode = "",
                SessionToken = "",
            };
            // Make the request
            Place response = placesClient.GetPlace(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlaceAsync</summary>
        public async Task GetPlaceRequestObjectAsync()
        {
            // Snippet: GetPlaceAsync(GetPlaceRequest, CallSettings)
            // Additional: GetPlaceAsync(GetPlaceRequest, CancellationToken)
            // Create client
            PlacesClient placesClient = await PlacesClient.CreateAsync();
            // Initialize request argument(s)
            GetPlaceRequest request = new GetPlaceRequest
            {
                PlaceName = PlaceName.FromPlace("[PLACE_ID]"),
                LanguageCode = "",
                RegionCode = "",
                SessionToken = "",
            };
            // Make the request
            Place response = await placesClient.GetPlaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPlace</summary>
        public void GetPlace()
        {
            // Snippet: GetPlace(string, CallSettings)
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            string name = "places/[PLACE_ID]";
            // Make the request
            Place response = placesClient.GetPlace(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlaceAsync</summary>
        public async Task GetPlaceAsync()
        {
            // Snippet: GetPlaceAsync(string, CallSettings)
            // Additional: GetPlaceAsync(string, CancellationToken)
            // Create client
            PlacesClient placesClient = await PlacesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "places/[PLACE_ID]";
            // Make the request
            Place response = await placesClient.GetPlaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlace</summary>
        public void GetPlaceResourceNames()
        {
            // Snippet: GetPlace(PlaceName, CallSettings)
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            PlaceName name = PlaceName.FromPlace("[PLACE_ID]");
            // Make the request
            Place response = placesClient.GetPlace(name);
            // End snippet
        }

        /// <summary>Snippet for GetPlaceAsync</summary>
        public async Task GetPlaceResourceNamesAsync()
        {
            // Snippet: GetPlaceAsync(PlaceName, CallSettings)
            // Additional: GetPlaceAsync(PlaceName, CancellationToken)
            // Create client
            PlacesClient placesClient = await PlacesClient.CreateAsync();
            // Initialize request argument(s)
            PlaceName name = PlaceName.FromPlace("[PLACE_ID]");
            // Make the request
            Place response = await placesClient.GetPlaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AutocompletePlaces</summary>
        public void AutocompletePlacesRequestObject()
        {
            // Snippet: AutocompletePlaces(AutocompletePlacesRequest, CallSettings)
            // Create client
            PlacesClient placesClient = PlacesClient.Create();
            // Initialize request argument(s)
            AutocompletePlacesRequest request = new AutocompletePlacesRequest
            {
                Input = "",
                LocationBias = new AutocompletePlacesRequest.Types.LocationBias(),
                LocationRestriction = new AutocompletePlacesRequest.Types.LocationRestriction(),
                IncludedPrimaryTypes = { "", },
                IncludedRegionCodes = { "", },
                LanguageCode = "",
                RegionCode = "",
                Origin = new LatLng(),
                InputOffset = 0,
                IncludeQueryPredictions = false,
                SessionToken = "",
                IncludePureServiceAreaBusinesses = false,
            };
            // Make the request
            AutocompletePlacesResponse response = placesClient.AutocompletePlaces(request);
            // End snippet
        }

        /// <summary>Snippet for AutocompletePlacesAsync</summary>
        public async Task AutocompletePlacesRequestObjectAsync()
        {
            // Snippet: AutocompletePlacesAsync(AutocompletePlacesRequest, CallSettings)
            // Additional: AutocompletePlacesAsync(AutocompletePlacesRequest, CancellationToken)
            // Create client
            PlacesClient placesClient = await PlacesClient.CreateAsync();
            // Initialize request argument(s)
            AutocompletePlacesRequest request = new AutocompletePlacesRequest
            {
                Input = "",
                LocationBias = new AutocompletePlacesRequest.Types.LocationBias(),
                LocationRestriction = new AutocompletePlacesRequest.Types.LocationRestriction(),
                IncludedPrimaryTypes = { "", },
                IncludedRegionCodes = { "", },
                LanguageCode = "",
                RegionCode = "",
                Origin = new LatLng(),
                InputOffset = 0,
                IncludeQueryPredictions = false,
                SessionToken = "",
                IncludePureServiceAreaBusinesses = false,
            };
            // Make the request
            AutocompletePlacesResponse response = await placesClient.AutocompletePlacesAsync(request);
            // End snippet
        }
    }
}
