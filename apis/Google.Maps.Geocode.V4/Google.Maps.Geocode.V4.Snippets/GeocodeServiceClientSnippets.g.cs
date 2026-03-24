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
    public sealed class AllGeneratedGeocodeServiceClientSnippets
    {
        /// <summary>Snippet for GeocodeAddress</summary>
        public void GeocodeAddressRequestObject()
        {
            // Snippet: GeocodeAddress(GeocodeAddressRequest, CallSettings)
            // Create client
            GeocodeServiceClient geocodeServiceClient = GeocodeServiceClient.Create();
            // Initialize request argument(s)
            GeocodeAddressRequest request = new GeocodeAddressRequest
            {
                AddressQuery = "",
                LocationBias = new GeocodeAddressRequest.Types.LocationBias(),
                LanguageCode = "",
                RegionCode = "",
            };
            // Make the request
            GeocodeAddressResponse response = geocodeServiceClient.GeocodeAddress(request);
            // End snippet
        }

        /// <summary>Snippet for GeocodeAddressAsync</summary>
        public async Task GeocodeAddressRequestObjectAsync()
        {
            // Snippet: GeocodeAddressAsync(GeocodeAddressRequest, CallSettings)
            // Additional: GeocodeAddressAsync(GeocodeAddressRequest, CancellationToken)
            // Create client
            GeocodeServiceClient geocodeServiceClient = await GeocodeServiceClient.CreateAsync();
            // Initialize request argument(s)
            GeocodeAddressRequest request = new GeocodeAddressRequest
            {
                AddressQuery = "",
                LocationBias = new GeocodeAddressRequest.Types.LocationBias(),
                LanguageCode = "",
                RegionCode = "",
            };
            // Make the request
            GeocodeAddressResponse response = await geocodeServiceClient.GeocodeAddressAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GeocodeLocation</summary>
        public void GeocodeLocationRequestObject()
        {
            // Snippet: GeocodeLocation(GeocodeLocationRequest, CallSettings)
            // Create client
            GeocodeServiceClient geocodeServiceClient = GeocodeServiceClient.Create();
            // Initialize request argument(s)
            GeocodeLocationRequest request = new GeocodeLocationRequest
            {
                LocationQuery = "",
                LanguageCode = "",
                RegionCode = "",
                Types_ = { "", },
                Granularity =
                {
                    GeocodeResult.Types.Granularity.Unspecified,
                },
            };
            // Make the request
            GeocodeLocationResponse response = geocodeServiceClient.GeocodeLocation(request);
            // End snippet
        }

        /// <summary>Snippet for GeocodeLocationAsync</summary>
        public async Task GeocodeLocationRequestObjectAsync()
        {
            // Snippet: GeocodeLocationAsync(GeocodeLocationRequest, CallSettings)
            // Additional: GeocodeLocationAsync(GeocodeLocationRequest, CancellationToken)
            // Create client
            GeocodeServiceClient geocodeServiceClient = await GeocodeServiceClient.CreateAsync();
            // Initialize request argument(s)
            GeocodeLocationRequest request = new GeocodeLocationRequest
            {
                LocationQuery = "",
                LanguageCode = "",
                RegionCode = "",
                Types_ = { "", },
                Granularity =
                {
                    GeocodeResult.Types.Granularity.Unspecified,
                },
            };
            // Make the request
            GeocodeLocationResponse response = await geocodeServiceClient.GeocodeLocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GeocodePlace</summary>
        public void GeocodePlaceRequestObject()
        {
            // Snippet: GeocodePlace(GeocodePlaceRequest, CallSettings)
            // Create client
            GeocodeServiceClient geocodeServiceClient = GeocodeServiceClient.Create();
            // Initialize request argument(s)
            GeocodePlaceRequest request = new GeocodePlaceRequest
            {
                Place = "",
                LanguageCode = "",
                RegionCode = "",
            };
            // Make the request
            GeocodeResult response = geocodeServiceClient.GeocodePlace(request);
            // End snippet
        }

        /// <summary>Snippet for GeocodePlaceAsync</summary>
        public async Task GeocodePlaceRequestObjectAsync()
        {
            // Snippet: GeocodePlaceAsync(GeocodePlaceRequest, CallSettings)
            // Additional: GeocodePlaceAsync(GeocodePlaceRequest, CancellationToken)
            // Create client
            GeocodeServiceClient geocodeServiceClient = await GeocodeServiceClient.CreateAsync();
            // Initialize request argument(s)
            GeocodePlaceRequest request = new GeocodePlaceRequest
            {
                Place = "",
                LanguageCode = "",
                RegionCode = "",
            };
            // Make the request
            GeocodeResult response = await geocodeServiceClient.GeocodePlaceAsync(request);
            // End snippet
        }
    }
}
