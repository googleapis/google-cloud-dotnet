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

namespace Google.Cloud.Dataflow.V1Beta3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMetricsV1Beta3ClientTest
    {
        [xunit::FactAttribute]
        public void GetJobMetricsRequestObject()
        {
            moq::Mock<MetricsV1Beta3.MetricsV1Beta3Client> mockGrpcClient = new moq::Mock<MetricsV1Beta3.MetricsV1Beta3Client>(moq::MockBehavior.Strict);
            GetJobMetricsRequest request = new GetJobMetricsRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                StartTime = new wkt::Timestamp(),
                Location = "locatione09d18d5",
            };
            JobMetrics expectedResponse = new JobMetrics
            {
                MetricTime = new wkt::Timestamp(),
                Metrics = { new MetricUpdate(), },
            };
            mockGrpcClient.Setup(x => x.GetJobMetrics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MetricsV1Beta3Client client = new MetricsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            JobMetrics response = client.GetJobMetrics(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetJobMetricsRequestObjectAsync()
        {
            moq::Mock<MetricsV1Beta3.MetricsV1Beta3Client> mockGrpcClient = new moq::Mock<MetricsV1Beta3.MetricsV1Beta3Client>(moq::MockBehavior.Strict);
            GetJobMetricsRequest request = new GetJobMetricsRequest
            {
                ProjectId = "project_id43ad98b0",
                JobId = "job_id38ea97d6",
                StartTime = new wkt::Timestamp(),
                Location = "locatione09d18d5",
            };
            JobMetrics expectedResponse = new JobMetrics
            {
                MetricTime = new wkt::Timestamp(),
                Metrics = { new MetricUpdate(), },
            };
            mockGrpcClient.Setup(x => x.GetJobMetricsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<JobMetrics>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MetricsV1Beta3Client client = new MetricsV1Beta3ClientImpl(mockGrpcClient.Object, null);
            JobMetrics responseCallSettings = await client.GetJobMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            JobMetrics responseCancellationToken = await client.GetJobMetricsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
