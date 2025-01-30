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
    using Google.Cloud.Optimization.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedFleetRoutingClientSnippets
    {
        /// <summary>Snippet for OptimizeTours</summary>
        public void OptimizeToursRequestObject()
        {
            // Snippet: OptimizeTours(OptimizeToursRequest, CallSettings)
            // Create client
            FleetRoutingClient fleetRoutingClient = FleetRoutingClient.Create();
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
            OptimizeToursResponse response = fleetRoutingClient.OptimizeTours(request);
            // End snippet
        }

        /// <summary>Snippet for OptimizeToursAsync</summary>
        public async Task OptimizeToursRequestObjectAsync()
        {
            // Snippet: OptimizeToursAsync(OptimizeToursRequest, CallSettings)
            // Additional: OptimizeToursAsync(OptimizeToursRequest, CancellationToken)
            // Create client
            FleetRoutingClient fleetRoutingClient = await FleetRoutingClient.CreateAsync();
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
            OptimizeToursResponse response = await fleetRoutingClient.OptimizeToursAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchOptimizeTours</summary>
        public void BatchOptimizeToursRequestObject()
        {
            // Snippet: BatchOptimizeTours(BatchOptimizeToursRequest, CallSettings)
            // Create client
            FleetRoutingClient fleetRoutingClient = FleetRoutingClient.Create();
            // Initialize request argument(s)
            BatchOptimizeToursRequest request = new BatchOptimizeToursRequest
            {
                Parent = "",
                ModelConfigs =
                {
                    new BatchOptimizeToursRequest.Types.AsyncModelConfig(),
                },
            };
            // Make the request
            Operation<BatchOptimizeToursResponse, AsyncModelMetadata> response = fleetRoutingClient.BatchOptimizeTours(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchOptimizeToursResponse, AsyncModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchOptimizeToursResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchOptimizeToursResponse, AsyncModelMetadata> retrievedResponse = fleetRoutingClient.PollOnceBatchOptimizeTours(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchOptimizeToursResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchOptimizeToursAsync</summary>
        public async Task BatchOptimizeToursRequestObjectAsync()
        {
            // Snippet: BatchOptimizeToursAsync(BatchOptimizeToursRequest, CallSettings)
            // Additional: BatchOptimizeToursAsync(BatchOptimizeToursRequest, CancellationToken)
            // Create client
            FleetRoutingClient fleetRoutingClient = await FleetRoutingClient.CreateAsync();
            // Initialize request argument(s)
            BatchOptimizeToursRequest request = new BatchOptimizeToursRequest
            {
                Parent = "",
                ModelConfigs =
                {
                    new BatchOptimizeToursRequest.Types.AsyncModelConfig(),
                },
            };
            // Make the request
            Operation<BatchOptimizeToursResponse, AsyncModelMetadata> response = await fleetRoutingClient.BatchOptimizeToursAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchOptimizeToursResponse, AsyncModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchOptimizeToursResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchOptimizeToursResponse, AsyncModelMetadata> retrievedResponse = await fleetRoutingClient.PollOnceBatchOptimizeToursAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchOptimizeToursResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
