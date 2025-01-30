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
    // [START routes_v2_generated_Routes_ComputeRoutes_sync]
    using Google.Maps.Routing.V2;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedRoutesClientSnippets
    {
        /// <summary>Snippet for ComputeRoutes</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
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
                OptimizeWaypointOrder = false,
                RequestedReferenceRoutes =
                {
                    ComputeRoutesRequest.Types.ReferenceRoute.Unspecified,
                },
                ExtraComputations =
                {
                    ComputeRoutesRequest.Types.ExtraComputation.Unspecified,
                },
                RegionCode = "",
                TrafficModel = TrafficModel.Unspecified,
                ArrivalTime = new Timestamp(),
                TransitPreferences = new TransitPreferences(),
            };
            // Make the request
            ComputeRoutesResponse response = routesClient.ComputeRoutes(request);
        }
    }
    // [END routes_v2_generated_Routes_ComputeRoutes_sync]
}
