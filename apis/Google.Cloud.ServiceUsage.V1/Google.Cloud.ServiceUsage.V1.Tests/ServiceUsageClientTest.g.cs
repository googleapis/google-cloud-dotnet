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

namespace Google.Cloud.ServiceUsage.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedServiceUsageClientTest
    {
        [xunit::FactAttribute]
        public void GetServiceRequestObject()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                Name = "name1c9368b0",
            };
            Service expectedResponse = new Service
            {
                Name = "name1c9368b0",
                Config = new ServiceConfig(),
                State = State.Unspecified,
                Parent = "parent7858e4d0",
            };
            mockGrpcClient.Setup(x => x.GetService(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null, null);
            Service response = client.GetService(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetServiceRequestObjectAsync()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetServiceRequest request = new GetServiceRequest
            {
                Name = "name1c9368b0",
            };
            Service expectedResponse = new Service
            {
                Name = "name1c9368b0",
                Config = new ServiceConfig(),
                State = State.Unspecified,
                Parent = "parent7858e4d0",
            };
            mockGrpcClient.Setup(x => x.GetServiceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Service>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null, null);
            Service responseCallSettings = await client.GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Service responseCancellationToken = await client.GetServiceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchGetServicesRequestObject()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchGetServicesRequest request = new BatchGetServicesRequest
            {
                Parent = "parent7858e4d0",
                Names = { "names318c99a8", },
            };
            BatchGetServicesResponse expectedResponse = new BatchGetServicesResponse
            {
                Services = { new Service(), },
            };
            mockGrpcClient.Setup(x => x.BatchGetServices(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null, null);
            BatchGetServicesResponse response = client.BatchGetServices(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchGetServicesRequestObjectAsync()
        {
            moq::Mock<ServiceUsage.ServiceUsageClient> mockGrpcClient = new moq::Mock<ServiceUsage.ServiceUsageClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchGetServicesRequest request = new BatchGetServicesRequest
            {
                Parent = "parent7858e4d0",
                Names = { "names318c99a8", },
            };
            BatchGetServicesResponse expectedResponse = new BatchGetServicesResponse
            {
                Services = { new Service(), },
            };
            mockGrpcClient.Setup(x => x.BatchGetServicesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchGetServicesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceUsageClient client = new ServiceUsageClientImpl(mockGrpcClient.Object, null, null);
            BatchGetServicesResponse responseCallSettings = await client.BatchGetServicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchGetServicesResponse responseCancellationToken = await client.BatchGetServicesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
