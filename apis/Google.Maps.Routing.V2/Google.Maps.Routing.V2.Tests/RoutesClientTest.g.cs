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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Maps.Routing.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRoutesClientTest
    {
        [xunit::FactAttribute]
        public void ComputeRoutesRequestObject()
        {
            moq::Mock<Routes.RoutesClient> mockGrpcClient = new moq::Mock<Routes.RoutesClient>(moq::MockBehavior.Strict);
            ComputeRoutesRequest request = new ComputeRoutesRequest
            {
                Origin = new Waypoint(),
                Destination = new Waypoint(),
                Intermediates = { new Waypoint(), },
                TravelMode = RouteTravelMode.Bicycle,
                RoutingPreference = RoutingPreference.TrafficAware,
                PolylineQuality = PolylineQuality.Unspecified,
                DepartureTime = new wkt::Timestamp(),
                ComputeAlternativeRoutes = false,
                RouteModifiers = new RouteModifiers(),
                LanguageCode = "language_code2f6c7160",
                Units = Units.Metric,
                PolylineEncoding = PolylineEncoding.Unspecified,
                RequestedReferenceRoutes =
                {
                    ComputeRoutesRequest.Types.ReferenceRoute.FuelEfficient,
                },
            };
            ComputeRoutesResponse expectedResponse = new ComputeRoutesResponse
            {
                Routes = { new Route(), },
                FallbackInfo = new FallbackInfo(),
            };
            mockGrpcClient.Setup(x => x.ComputeRoutes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RoutesClient client = new RoutesClientImpl(mockGrpcClient.Object, null, null);
            ComputeRoutesResponse response = client.ComputeRoutes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ComputeRoutesRequestObjectAsync()
        {
            moq::Mock<Routes.RoutesClient> mockGrpcClient = new moq::Mock<Routes.RoutesClient>(moq::MockBehavior.Strict);
            ComputeRoutesRequest request = new ComputeRoutesRequest
            {
                Origin = new Waypoint(),
                Destination = new Waypoint(),
                Intermediates = { new Waypoint(), },
                TravelMode = RouteTravelMode.Bicycle,
                RoutingPreference = RoutingPreference.TrafficAware,
                PolylineQuality = PolylineQuality.Unspecified,
                DepartureTime = new wkt::Timestamp(),
                ComputeAlternativeRoutes = false,
                RouteModifiers = new RouteModifiers(),
                LanguageCode = "language_code2f6c7160",
                Units = Units.Metric,
                PolylineEncoding = PolylineEncoding.Unspecified,
                RequestedReferenceRoutes =
                {
                    ComputeRoutesRequest.Types.ReferenceRoute.FuelEfficient,
                },
            };
            ComputeRoutesResponse expectedResponse = new ComputeRoutesResponse
            {
                Routes = { new Route(), },
                FallbackInfo = new FallbackInfo(),
            };
            mockGrpcClient.Setup(x => x.ComputeRoutesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ComputeRoutesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RoutesClient client = new RoutesClientImpl(mockGrpcClient.Object, null, null);
            ComputeRoutesResponse responseCallSettings = await client.ComputeRoutesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ComputeRoutesResponse responseCancellationToken = await client.ComputeRoutesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
