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
    public sealed class GeneratedQuotaControllerClientTest
    {
        [xunit::FactAttribute]
        public void AllocateQuotaRequestObject()
        {
            moq::Mock<QuotaController.QuotaControllerClient> mockGrpcClient = new moq::Mock<QuotaController.QuotaControllerClient>(moq::MockBehavior.Strict);
            AllocateQuotaRequest request = new AllocateQuotaRequest
            {
                ServiceName = "service_named5df05d5",
                AllocateOperation = new QuotaOperation(),
                ServiceConfigId = "service_config_id1616022f",
            };
            AllocateQuotaResponse expectedResponse = new AllocateQuotaResponse
            {
                OperationId = "operation_id8a494117",
                AllocateErrors = { new QuotaError(), },
                QuotaMetrics =
                {
                    new MetricValueSet(),
                },
                ServiceConfigId = "service_config_id1616022f",
            };
            mockGrpcClient.Setup(x => x.AllocateQuota(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            QuotaControllerClient client = new QuotaControllerClientImpl(mockGrpcClient.Object, null, null);
            AllocateQuotaResponse response = client.AllocateQuota(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AllocateQuotaRequestObjectAsync()
        {
            moq::Mock<QuotaController.QuotaControllerClient> mockGrpcClient = new moq::Mock<QuotaController.QuotaControllerClient>(moq::MockBehavior.Strict);
            AllocateQuotaRequest request = new AllocateQuotaRequest
            {
                ServiceName = "service_named5df05d5",
                AllocateOperation = new QuotaOperation(),
                ServiceConfigId = "service_config_id1616022f",
            };
            AllocateQuotaResponse expectedResponse = new AllocateQuotaResponse
            {
                OperationId = "operation_id8a494117",
                AllocateErrors = { new QuotaError(), },
                QuotaMetrics =
                {
                    new MetricValueSet(),
                },
                ServiceConfigId = "service_config_id1616022f",
            };
            mockGrpcClient.Setup(x => x.AllocateQuotaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AllocateQuotaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            QuotaControllerClient client = new QuotaControllerClientImpl(mockGrpcClient.Object, null, null);
            AllocateQuotaResponse responseCallSettings = await client.AllocateQuotaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AllocateQuotaResponse responseCancellationToken = await client.AllocateQuotaAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
