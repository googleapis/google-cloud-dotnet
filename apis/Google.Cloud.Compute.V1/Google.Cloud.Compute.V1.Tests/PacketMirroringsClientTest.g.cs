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
    public sealed class GeneratedPacketMirroringsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroring expectedResponse = new PacketMirroring
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                MirroredResources = new PacketMirroringMirroredResourceInfo(),
                Region = "regionedb20d96",
                Network = new PacketMirroringNetworkInfo(),
                Enable = "enable6d158f20",
                Filter = new PacketMirroringFilter(),
                Description = "description2cf9da67",
                CollectorIlb = new PacketMirroringForwardingRuleInfo(),
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroring response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroring expectedResponse = new PacketMirroring
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                MirroredResources = new PacketMirroringMirroredResourceInfo(),
                Region = "regionedb20d96",
                Network = new PacketMirroringNetworkInfo(),
                Enable = "enable6d158f20",
                Filter = new PacketMirroringFilter(),
                Description = "description2cf9da67",
                CollectorIlb = new PacketMirroringForwardingRuleInfo(),
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PacketMirroring>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroring responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PacketMirroring responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroring expectedResponse = new PacketMirroring
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                MirroredResources = new PacketMirroringMirroredResourceInfo(),
                Region = "regionedb20d96",
                Network = new PacketMirroringNetworkInfo(),
                Enable = "enable6d158f20",
                Filter = new PacketMirroringFilter(),
                Description = "description2cf9da67",
                CollectorIlb = new PacketMirroringForwardingRuleInfo(),
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroring response = client.Get(request.Project, request.Region, request.PacketMirroring);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroring expectedResponse = new PacketMirroring
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                MirroredResources = new PacketMirroringMirroredResourceInfo(),
                Region = "regionedb20d96",
                Network = new PacketMirroringNetworkInfo(),
                Enable = "enable6d158f20",
                Filter = new PacketMirroringFilter(),
                Description = "description2cf9da67",
                CollectorIlb = new PacketMirroringForwardingRuleInfo(),
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PacketMirroring>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroring responseCallSettings = await client.GetAsync(request.Project, request.Region, request.PacketMirroring, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PacketMirroring responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.PacketMirroring, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
