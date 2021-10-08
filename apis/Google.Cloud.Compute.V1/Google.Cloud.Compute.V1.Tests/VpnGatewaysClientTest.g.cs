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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVpnGatewaysClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGateway expectedResponse = new VpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnInterfaces =
                {
                    new VpnGatewayVpnGatewayInterface(),
                },
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGateway response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGateway expectedResponse = new VpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnInterfaces =
                {
                    new VpnGatewayVpnGatewayInterface(),
                },
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGateway responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGateway responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGateway expectedResponse = new VpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnInterfaces =
                {
                    new VpnGatewayVpnGatewayInterface(),
                },
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGateway response = client.Get(request.Project, request.Region, request.VpnGateway);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGateway expectedResponse = new VpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnInterfaces =
                {
                    new VpnGatewayVpnGatewayInterface(),
                },
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGateway responseCallSettings = await client.GetAsync(request.Project, request.Region, request.VpnGateway, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGateway responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.VpnGateway, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStatusRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGatewaysGetStatusResponse expectedResponse = new VpnGatewaysGetStatusResponse
            {
                Result = new VpnGatewayStatus(),
            };
            mockGrpcClient.Setup(x => x.GetStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewaysGetStatusResponse response = client.GetStatus(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStatusRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGatewaysGetStatusResponse expectedResponse = new VpnGatewaysGetStatusResponse
            {
                Result = new VpnGatewayStatus(),
            };
            mockGrpcClient.Setup(x => x.GetStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGatewaysGetStatusResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewaysGetStatusResponse responseCallSettings = await client.GetStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGatewaysGetStatusResponse responseCancellationToken = await client.GetStatusAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStatus()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGatewaysGetStatusResponse expectedResponse = new VpnGatewaysGetStatusResponse
            {
                Result = new VpnGatewayStatus(),
            };
            mockGrpcClient.Setup(x => x.GetStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewaysGetStatusResponse response = client.GetStatus(request.Project, request.Region, request.VpnGateway);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStatusAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGatewaysGetStatusResponse expectedResponse = new VpnGatewaysGetStatusResponse
            {
                Result = new VpnGatewayStatus(),
            };
            mockGrpcClient.Setup(x => x.GetStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGatewaysGetStatusResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewaysGetStatusResponse responseCallSettings = await client.GetStatusAsync(request.Project, request.Region, request.VpnGateway, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGatewaysGetStatusResponse responseCancellationToken = await client.GetStatusAsync(request.Project, request.Region, request.VpnGateway, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
