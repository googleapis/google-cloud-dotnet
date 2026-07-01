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
    using Google.Maps.Isochrones.V1;
    using Google.Protobuf.WellKnownTypes;
    using Google.Type;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedIsochroneServiceClientSnippets
    {
        /// <summary>Snippet for GenerateIsochrone</summary>
        public void GenerateIsochroneRequestObject()
        {
            // Snippet: GenerateIsochrone(GenerateIsochroneRequest, CallSettings)
            // Create client
            IsochroneServiceClient isochroneServiceClient = IsochroneServiceClient.Create();
            // Initialize request argument(s)
            GenerateIsochroneRequest request = new GenerateIsochroneRequest
            {
                Location = new LatLng(),
                TravelDuration = new Duration(),
                TravelMode = GenerateIsochroneRequest.Types.TravelMode.Unspecified,
                TravelDirection = GenerateIsochroneRequest.Types.TravelDirection.Unspecified,
                RoutingPreference = GenerateIsochroneRequest.Types.RoutingPreference.Unspecified,
                EnableSmoothing = false,
                PolygonFidelity = GenerateIsochroneRequest.Types.PolygonFidelity.Unspecified,
            };
            // Make the request
            GenerateIsochroneResponse response = isochroneServiceClient.GenerateIsochrone(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateIsochroneAsync</summary>
        public async Task GenerateIsochroneRequestObjectAsync()
        {
            // Snippet: GenerateIsochroneAsync(GenerateIsochroneRequest, CallSettings)
            // Additional: GenerateIsochroneAsync(GenerateIsochroneRequest, CancellationToken)
            // Create client
            IsochroneServiceClient isochroneServiceClient = await IsochroneServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateIsochroneRequest request = new GenerateIsochroneRequest
            {
                Location = new LatLng(),
                TravelDuration = new Duration(),
                TravelMode = GenerateIsochroneRequest.Types.TravelMode.Unspecified,
                TravelDirection = GenerateIsochroneRequest.Types.TravelDirection.Unspecified,
                RoutingPreference = GenerateIsochroneRequest.Types.RoutingPreference.Unspecified,
                EnableSmoothing = false,
                PolygonFidelity = GenerateIsochroneRequest.Types.PolygonFidelity.Unspecified,
            };
            // Make the request
            GenerateIsochroneResponse response = await isochroneServiceClient.GenerateIsochroneAsync(request);
            // End snippet
        }
    }
}
