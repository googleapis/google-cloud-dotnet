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
    // [START routeoptimization_v1_generated_RouteOptimization_OptimizeTours_sync]
    using Google.Maps.RouteOptimization.V1;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedRouteOptimizationClientSnippets
    {
        /// <summary>Snippet for OptimizeTours</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void OptimizeToursRequestObject()
        {
            // Create client
            RouteOptimizationClient routeOptimizationClient = RouteOptimizationClient.Create();
            // Initialize request argument(s)
            OptimizeToursRequest request = new OptimizeToursRequest
            {
                Parent = "",
                Timeout = new Duration(),
                Model = new ShipmentModel(),
                SolvingMode = OptimizeToursRequest.Types.SolvingMode.DefaultSolve,
                MaxValidationErrors = 0,
                SearchMode = OptimizeToursRequest.Types.SearchMode.Unspecified,
                InjectedFirstSolutionRoutes =
                {
                    new ShipmentRoute(),
                },
                InjectedSolutionConstraint = new InjectedSolutionConstraint(),
                RefreshDetailsRoutes =
                {
                    new ShipmentRoute(),
                },
                InterpretInjectedSolutionsUsingLabels = false,
                ConsiderRoadTraffic = false,
                PopulatePolylines = false,
                PopulateTransitionPolylines = false,
                AllowLargeDeadlineDespiteInterruptionRisk = false,
                UseGeodesicDistances = false,
                GeodesicMetersPerSecond = 0,
                Label = "",
            };
            // Make the request
            OptimizeToursResponse response = routeOptimizationClient.OptimizeTours(request);
        }
    }
    // [END routeoptimization_v1_generated_RouteOptimization_OptimizeTours_sync]
}
