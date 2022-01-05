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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Location.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedLocationsClientTest
    {
        [xunit::FactAttribute]
        public void GetLocationRequestObject()
        {
            moq::Mock<Locations.LocationsClient> mockGrpcClient = new moq::Mock<Locations.LocationsClient>(moq::MockBehavior.Strict);
            GetLocationRequest request = new GetLocationRequest
            {
                Name = "name1c9368b0",
            };
            Location expectedResponse = new Location
            {
                Name = "name1c9368b0",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Any(),
                LocationId = "location_iddaa574e2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetLocation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LocationsClient client = new LocationsClientImpl(mockGrpcClient.Object, null);
            Location response = client.GetLocation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLocationRequestObjectAsync()
        {
            moq::Mock<Locations.LocationsClient> mockGrpcClient = new moq::Mock<Locations.LocationsClient>(moq::MockBehavior.Strict);
            GetLocationRequest request = new GetLocationRequest
            {
                Name = "name1c9368b0",
            };
            Location expectedResponse = new Location
            {
                Name = "name1c9368b0",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Metadata = new wkt::Any(),
                LocationId = "location_iddaa574e2",
                DisplayName = "display_name137f65c2",
            };
            mockGrpcClient.Setup(x => x.GetLocationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Location>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LocationsClient client = new LocationsClientImpl(mockGrpcClient.Object, null);
            Location responseCallSettings = await client.GetLocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Location responseCancellationToken = await client.GetLocationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
