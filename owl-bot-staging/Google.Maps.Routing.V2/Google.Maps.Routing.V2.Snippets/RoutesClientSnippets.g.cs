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
    using Google.Api.Gax.Grpc;
    using Google.Maps.Routing.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRoutesClientSnippets
    {
        /// <summary>Snippet for ComputeRoutes</summary>
        public void ComputeRoutesRequestObject()
        {
            // Snippet: ComputeRoutes(ComputeRoutesRequest, CallSettings)
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
            // End snippet
        }

        /// <summary>Snippet for ComputeRoutesAsync</summary>
        public async Task ComputeRoutesRequestObjectAsync()
        {
            // Snippet: ComputeRoutesAsync(ComputeRoutesRequest, CallSettings)
            // Additional: ComputeRoutesAsync(ComputeRoutesRequest, CancellationToken)
            // Create client
            RoutesClient routesClient = await RoutesClient.CreateAsync();
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
            ComputeRoutesResponse response = await routesClient.ComputeRoutesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeRouteMatrix</summary>
        public async Task ComputeRouteMatrixRequestObject()
        {
            // Snippet: ComputeRouteMatrix(ComputeRouteMatrixRequest, CallSettings)
            // Create client
            RoutesClient routesClient = RoutesClient.Create();
            // Initialize request argument(s)
            ComputeRouteMatrixRequest request = new ComputeRouteMatrixRequest
            {
                Origins =
                {
                    new RouteMatrixOrigin(),
                },
                Destinations =
                {
                    new RouteMatrixDestination(),
                },
                TravelMode = RouteTravelMode.TravelModeUnspecified,
                RoutingPreference = RoutingPreference.Unspecified,
                DepartureTime = new Timestamp(),
                LanguageCode = "",
                Units = Units.Unspecified,
                ExtraComputations =
                {
                    ComputeRouteMatrixRequest.Types.ExtraComputation.Unspecified,
                },
                RegionCode = "",
                TrafficModel = TrafficModel.Unspecified,
                ArrivalTime = new Timestamp(),
                TransitPreferences = new TransitPreferences(),
            };
            // Make the request, returning a streaming response
            using RoutesClient.ComputeRouteMatrixStream response = routesClient.ComputeRouteMatrix(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<RouteMatrixElement> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                RouteMatrixElement responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }
    }
}
