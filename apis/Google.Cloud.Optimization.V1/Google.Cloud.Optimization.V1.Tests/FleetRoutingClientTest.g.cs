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

using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Optimization.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFleetRoutingClientTest
    {
        [xunit::FactAttribute]
        public void OptimizeToursRequestObject()
        {
            moq::Mock<FleetRouting.FleetRoutingClient> mockGrpcClient = new moq::Mock<FleetRouting.FleetRoutingClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            OptimizeToursRequest request = new OptimizeToursRequest
            {
                Parent = "parent7858e4d0",
                Timeout = new wkt::Duration(),
                Model = new ShipmentModel(),
                SolvingMode = OptimizeToursRequest.Types.SolvingMode.DefaultSolve,
                MaxValidationErrors = 1666672911,
                SearchMode = OptimizeToursRequest.Types.SearchMode.ConsumeAllAvailableTime,
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
                PopulatePolylines = true,
                PopulateTransitionPolylines = false,
                AllowLargeDeadlineDespiteInterruptionRisk = false,
                UseGeodesicDistances = false,
                GeodesicMetersPerSecond = -9.25641050683682E+17,
                Label = "label20ba04d3",
#pragma warning disable CS0612
                PopulateTravelStepPolylines = false,
#pragma warning restore CS0612
            };
            OptimizeToursResponse expectedResponse = new OptimizeToursResponse
            {
                Routes =
                {
                    new ShipmentRoute(),
                },
#pragma warning disable CS0612
                TotalCost = 1.0371784069224398E+17,
#pragma warning restore CS0612
                RequestLabel = "request_label0ecef62f",
                SkippedShipments =
                {
                    new SkippedShipment(),
                },
                ValidationErrors =
                {
                    new OptimizeToursValidationError(),
                },
                Metrics = new OptimizeToursResponse.Types.Metrics(),
            };
            mockGrpcClient.Setup(x => x.OptimizeTours(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FleetRoutingClient client = new FleetRoutingClientImpl(mockGrpcClient.Object, null);
            OptimizeToursResponse response = client.OptimizeTours(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task OptimizeToursRequestObjectAsync()
        {
            moq::Mock<FleetRouting.FleetRoutingClient> mockGrpcClient = new moq::Mock<FleetRouting.FleetRoutingClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            OptimizeToursRequest request = new OptimizeToursRequest
            {
                Parent = "parent7858e4d0",
                Timeout = new wkt::Duration(),
                Model = new ShipmentModel(),
                SolvingMode = OptimizeToursRequest.Types.SolvingMode.DefaultSolve,
                MaxValidationErrors = 1666672911,
                SearchMode = OptimizeToursRequest.Types.SearchMode.ConsumeAllAvailableTime,
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
                PopulatePolylines = true,
                PopulateTransitionPolylines = false,
                AllowLargeDeadlineDespiteInterruptionRisk = false,
                UseGeodesicDistances = false,
                GeodesicMetersPerSecond = -9.25641050683682E+17,
                Label = "label20ba04d3",
#pragma warning disable CS0612
                PopulateTravelStepPolylines = false,
#pragma warning restore CS0612
            };
            OptimizeToursResponse expectedResponse = new OptimizeToursResponse
            {
                Routes =
                {
                    new ShipmentRoute(),
                },
#pragma warning disable CS0612
                TotalCost = 1.0371784069224398E+17,
#pragma warning restore CS0612
                RequestLabel = "request_label0ecef62f",
                SkippedShipments =
                {
                    new SkippedShipment(),
                },
                ValidationErrors =
                {
                    new OptimizeToursValidationError(),
                },
                Metrics = new OptimizeToursResponse.Types.Metrics(),
            };
            mockGrpcClient.Setup(x => x.OptimizeToursAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<OptimizeToursResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FleetRoutingClient client = new FleetRoutingClientImpl(mockGrpcClient.Object, null);
            OptimizeToursResponse responseCallSettings = await client.OptimizeToursAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            OptimizeToursResponse responseCancellationToken = await client.OptimizeToursAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
