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
    // [START routes_v2_generated_Routes_ComputeRouteMatrix_sync]
    using Google.Api.Gax.Grpc;
    using Google.Maps.Routing.V2;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedRoutesClientSnippets
    {
        /// <summary>Snippet for ComputeRouteMatrix</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ComputeRouteMatrixRequestObject()
        {
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
        }
    }
    // [END routes_v2_generated_Routes_ComputeRouteMatrix_sync]
}
