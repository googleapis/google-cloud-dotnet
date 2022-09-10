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

namespace Google.Maps.Routing.V2.Snippets
{
    // [START routes_v2_generated_Routes_ComputeRoutes_sync]
    using Google.Maps.Routing.V2;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedRoutesClientSnippets
    {
        /// <summary>Snippet for ComputeRoutes</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ComputeRoutesRequestObject()
        {
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            ComputeRoutesRequest request = new ComputeRoutesRequest
            {
                Origin = new Waypoint(),
                Destination = new Waypoint(),
                Intermediates = { new Waypoint(), },
                TravelMode = RouteTravelMode.TravelModeUnspecified,
                RoutingPreference = RoutingPreference.Unspecified,
                PolylineQuality = PolylineQuality.Unspecified,
                DepartureTime = new Timestamp(),
                ComputeAlternativeRoutes = false,
                RouteModifiers = new RouteModifiers(),
                LanguageCode = "",
                Units = Units.Unspecified,
                PolylineEncoding = PolylineEncoding.Unspecified,
            };
            // Make the request
            ComputeRoutesResponse response = routesClient.ComputeRoutes(request);
        }
    }
    // [END routes_v2_generated_Routes_ComputeRoutes_sync]
}
