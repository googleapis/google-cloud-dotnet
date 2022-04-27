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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedInstanceGroupsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
            };
            InstanceGroup expectedResponse = new InstanceGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Subnetwork = "subnetworkf55bf572",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null, null);
            InstanceGroup response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
            };
            InstanceGroup expectedResponse = new InstanceGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Subnetwork = "subnetworkf55bf572",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null, null);
            InstanceGroup responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroup responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
            };
            InstanceGroup expectedResponse = new InstanceGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Subnetwork = "subnetworkf55bf572",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null, null);
            InstanceGroup response = client.Get(request.Project, request.Zone, request.InstanceGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<InstanceGroups.InstanceGroupsClient> mockGrpcClient = new moq::Mock<InstanceGroups.InstanceGroupsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "zone255f4ea8",
                InstanceGroup = "instance_group6bf5a5ef",
                Project = "projectaa6ff846",
            };
            InstanceGroup expectedResponse = new InstanceGroup
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Size = -1218396681,
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                Network = "networkd22ce091",
                Fingerprint = "fingerprint009e6052",
                Subnetwork = "subnetworkf55bf572",
                Description = "description2cf9da67",
                NamedPorts = { new NamedPort(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceGroupsClient client = new InstanceGroupsClientImpl(mockGrpcClient.Object, null, null);
            InstanceGroup responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.InstanceGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceGroup responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.InstanceGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
