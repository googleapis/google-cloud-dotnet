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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.ServiceControl.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedServiceControllerClientTest
    {
        [xunit::FactAttribute]
        public void CheckRequestObject()
        {
            moq::Mock<ServiceController.ServiceControllerClient> mockGrpcClient = new moq::Mock<ServiceController.ServiceControllerClient>(moq::MockBehavior.Strict);
            CheckRequest request = new CheckRequest
            {
                ServiceName = "service_named5df05d5",
                Operation = new Operation(),
                ServiceConfigId = "service_config_id1616022f",
            };
            CheckResponse expectedResponse = new CheckResponse
            {
                OperationId = "operation_id8a494117",
                CheckErrors = { new CheckError(), },
                ServiceConfigId = "service_config_id1616022f",
                CheckInfo = new CheckResponse.Types.CheckInfo(),
                ServiceRolloutId = "service_rollout_id901a2f43",
            };
            mockGrpcClient.Setup(x => x.Check(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceControllerClient client = new ServiceControllerClientImpl(mockGrpcClient.Object, null, null);
            CheckResponse response = client.Check(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckRequestObjectAsync()
        {
            moq::Mock<ServiceController.ServiceControllerClient> mockGrpcClient = new moq::Mock<ServiceController.ServiceControllerClient>(moq::MockBehavior.Strict);
            CheckRequest request = new CheckRequest
            {
                ServiceName = "service_named5df05d5",
                Operation = new Operation(),
                ServiceConfigId = "service_config_id1616022f",
            };
            CheckResponse expectedResponse = new CheckResponse
            {
                OperationId = "operation_id8a494117",
                CheckErrors = { new CheckError(), },
                ServiceConfigId = "service_config_id1616022f",
                CheckInfo = new CheckResponse.Types.CheckInfo(),
                ServiceRolloutId = "service_rollout_id901a2f43",
            };
            mockGrpcClient.Setup(x => x.CheckAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceControllerClient client = new ServiceControllerClientImpl(mockGrpcClient.Object, null, null);
            CheckResponse responseCallSettings = await client.CheckAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckResponse responseCancellationToken = await client.CheckAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportRequestObject()
        {
            moq::Mock<ServiceController.ServiceControllerClient> mockGrpcClient = new moq::Mock<ServiceController.ServiceControllerClient>(moq::MockBehavior.Strict);
            ReportRequest request = new ReportRequest
            {
                ServiceName = "service_named5df05d5",
                Operations = { new Operation(), },
                ServiceConfigId = "service_config_id1616022f",
            };
            ReportResponse expectedResponse = new ReportResponse
            {
                ReportErrors =
                {
                    new ReportResponse.Types.ReportError(),
                },
                ServiceConfigId = "service_config_id1616022f",
                ServiceRolloutId = "service_rollout_id901a2f43",
            };
            mockGrpcClient.Setup(x => x.Report(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ServiceControllerClient client = new ServiceControllerClientImpl(mockGrpcClient.Object, null, null);
            ReportResponse response = client.Report(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportRequestObjectAsync()
        {
            moq::Mock<ServiceController.ServiceControllerClient> mockGrpcClient = new moq::Mock<ServiceController.ServiceControllerClient>(moq::MockBehavior.Strict);
            ReportRequest request = new ReportRequest
            {
                ServiceName = "service_named5df05d5",
                Operations = { new Operation(), },
                ServiceConfigId = "service_config_id1616022f",
            };
            ReportResponse expectedResponse = new ReportResponse
            {
                ReportErrors =
                {
                    new ReportResponse.Types.ReportError(),
                },
                ServiceConfigId = "service_config_id1616022f",
                ServiceRolloutId = "service_rollout_id901a2f43",
            };
            mockGrpcClient.Setup(x => x.ReportAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ServiceControllerClient client = new ServiceControllerClientImpl(mockGrpcClient.Object, null, null);
            ReportResponse responseCallSettings = await client.ReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportResponse responseCancellationToken = await client.ReportAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
