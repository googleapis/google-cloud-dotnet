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
    public sealed class GeneratedTargetInstancesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetInstances.TargetInstancesClient> mockGrpcClient = new moq::Mock<TargetInstances.TargetInstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetInstanceRequest request = new GetTargetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                TargetInstance = "target_instance1017fe07",
            };
            TargetInstance expectedResponse = new TargetInstance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                CreationTimestamp = "creation_timestamp235e59a1",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                NatPolicy = "nat_policy8dd30c47",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetInstancesClient client = new TargetInstancesClientImpl(mockGrpcClient.Object, null);
            TargetInstance response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<TargetInstances.TargetInstancesClient> mockGrpcClient = new moq::Mock<TargetInstances.TargetInstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetInstanceRequest request = new GetTargetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                TargetInstance = "target_instance1017fe07",
            };
            TargetInstance expectedResponse = new TargetInstance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                CreationTimestamp = "creation_timestamp235e59a1",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                NatPolicy = "nat_policy8dd30c47",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetInstancesClient client = new TargetInstancesClientImpl(mockGrpcClient.Object, null);
            TargetInstance responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetInstance responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<TargetInstances.TargetInstancesClient> mockGrpcClient = new moq::Mock<TargetInstances.TargetInstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetInstanceRequest request = new GetTargetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                TargetInstance = "target_instance1017fe07",
            };
            TargetInstance expectedResponse = new TargetInstance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                CreationTimestamp = "creation_timestamp235e59a1",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                NatPolicy = "nat_policy8dd30c47",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetInstancesClient client = new TargetInstancesClientImpl(mockGrpcClient.Object, null);
            TargetInstance response = client.Get(request.Project, request.Zone, request.TargetInstance);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<TargetInstances.TargetInstancesClient> mockGrpcClient = new moq::Mock<TargetInstances.TargetInstancesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForZoneOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetInstanceRequest request = new GetTargetInstanceRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                TargetInstance = "target_instance1017fe07",
            };
            TargetInstance expectedResponse = new TargetInstance
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                Instance = "instance99a62371",
                CreationTimestamp = "creation_timestamp235e59a1",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                NatPolicy = "nat_policy8dd30c47",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetInstance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetInstancesClient client = new TargetInstancesClientImpl(mockGrpcClient.Object, null);
            TargetInstance responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.TargetInstance, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetInstance responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.TargetInstance, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
