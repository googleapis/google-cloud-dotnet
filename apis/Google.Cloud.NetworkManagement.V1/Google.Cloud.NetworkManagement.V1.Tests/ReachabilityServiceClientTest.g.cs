// Copyright 2021 Google LLC
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

namespace Google.Cloud.NetworkManagement.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedReachabilityServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetConnectivityTestRequestObject()
        {
            moq::Mock<ReachabilityService.ReachabilityServiceClient> mockGrpcClient = new moq::Mock<ReachabilityService.ReachabilityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectivityTestRequest request = new GetConnectivityTestRequest
            {
                Name = "name1c9368b0",
            };
            ConnectivityTest expectedResponse = new ConnectivityTest
            {
                ConnectivityTestName = ConnectivityTestName.FromProjectTest("[PROJECT]", "[TEST]"),
                Description = "description2cf9da67",
                Source = new Endpoint(),
                Destination = new Endpoint(),
                Protocol = "protocola08b7881",
                RelatedProjects =
                {
                    "related_projectsf33be6e8",
                },
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReachabilityDetails = new ReachabilityDetails(),
            };
            mockGrpcClient.Setup(x => x.GetConnectivityTest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReachabilityServiceClient client = new ReachabilityServiceClientImpl(mockGrpcClient.Object, null);
            ConnectivityTest response = client.GetConnectivityTest(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectivityTestRequestObjectAsync()
        {
            moq::Mock<ReachabilityService.ReachabilityServiceClient> mockGrpcClient = new moq::Mock<ReachabilityService.ReachabilityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectivityTestRequest request = new GetConnectivityTestRequest
            {
                Name = "name1c9368b0",
            };
            ConnectivityTest expectedResponse = new ConnectivityTest
            {
                ConnectivityTestName = ConnectivityTestName.FromProjectTest("[PROJECT]", "[TEST]"),
                Description = "description2cf9da67",
                Source = new Endpoint(),
                Destination = new Endpoint(),
                Protocol = "protocola08b7881",
                RelatedProjects =
                {
                    "related_projectsf33be6e8",
                },
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReachabilityDetails = new ReachabilityDetails(),
            };
            mockGrpcClient.Setup(x => x.GetConnectivityTestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConnectivityTest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReachabilityServiceClient client = new ReachabilityServiceClientImpl(mockGrpcClient.Object, null);
            ConnectivityTest responseCallSettings = await client.GetConnectivityTestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConnectivityTest responseCancellationToken = await client.GetConnectivityTestAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConnectivityTest()
        {
            moq::Mock<ReachabilityService.ReachabilityServiceClient> mockGrpcClient = new moq::Mock<ReachabilityService.ReachabilityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectivityTestRequest request = new GetConnectivityTestRequest
            {
                Name = "name1c9368b0",
            };
            ConnectivityTest expectedResponse = new ConnectivityTest
            {
                ConnectivityTestName = ConnectivityTestName.FromProjectTest("[PROJECT]", "[TEST]"),
                Description = "description2cf9da67",
                Source = new Endpoint(),
                Destination = new Endpoint(),
                Protocol = "protocola08b7881",
                RelatedProjects =
                {
                    "related_projectsf33be6e8",
                },
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReachabilityDetails = new ReachabilityDetails(),
            };
            mockGrpcClient.Setup(x => x.GetConnectivityTest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReachabilityServiceClient client = new ReachabilityServiceClientImpl(mockGrpcClient.Object, null);
            ConnectivityTest response = client.GetConnectivityTest(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConnectivityTestAsync()
        {
            moq::Mock<ReachabilityService.ReachabilityServiceClient> mockGrpcClient = new moq::Mock<ReachabilityService.ReachabilityServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConnectivityTestRequest request = new GetConnectivityTestRequest
            {
                Name = "name1c9368b0",
            };
            ConnectivityTest expectedResponse = new ConnectivityTest
            {
                ConnectivityTestName = ConnectivityTestName.FromProjectTest("[PROJECT]", "[TEST]"),
                Description = "description2cf9da67",
                Source = new Endpoint(),
                Destination = new Endpoint(),
                Protocol = "protocola08b7881",
                RelatedProjects =
                {
                    "related_projectsf33be6e8",
                },
                DisplayName = "display_name137f65c2",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                ReachabilityDetails = new ReachabilityDetails(),
            };
            mockGrpcClient.Setup(x => x.GetConnectivityTestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConnectivityTest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReachabilityServiceClient client = new ReachabilityServiceClientImpl(mockGrpcClient.Object, null);
            ConnectivityTest responseCallSettings = await client.GetConnectivityTestAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConnectivityTest responseCancellationToken = await client.GetConnectivityTestAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
