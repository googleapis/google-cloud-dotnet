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
    public sealed class GeneratedRegionHealthChecksClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionHealthChecks.RegionHealthChecksClient> mockGrpcClient = new moq::Mock<RegionHealthChecks.RegionHealthChecksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionHealthCheckRequest request = new GetRegionHealthCheckRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            HealthCheck expectedResponse = new HealthCheck
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                Http2HealthCheck = new HTTP2HealthCheck(),
                CreationTimestamp = "creation_timestamp235e59a1",
                TimeoutSec = -1529270667,
                GrpcHealthCheck = new GRPCHealthCheck(),
                Region = "regionedb20d96",
                UnhealthyThreshold = -790413526,
                SslHealthCheck = new SSLHealthCheck(),
                CheckIntervalSec = 932847778,
                LogConfig = new HealthCheckLogConfig(),
                HealthyThreshold = -1266282289,
                HttpHealthCheck = new HTTPHealthCheck(),
                Description = "description2cf9da67",
                HttpsHealthCheck = new HTTPSHealthCheck(),
                SelfLink = "self_link7e87f12d",
                TcpHealthCheck = new TCPHealthCheck(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionHealthChecksClient client = new RegionHealthChecksClientImpl(mockGrpcClient.Object, null, null);
            HealthCheck response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionHealthChecks.RegionHealthChecksClient> mockGrpcClient = new moq::Mock<RegionHealthChecks.RegionHealthChecksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionHealthCheckRequest request = new GetRegionHealthCheckRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            HealthCheck expectedResponse = new HealthCheck
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                Http2HealthCheck = new HTTP2HealthCheck(),
                CreationTimestamp = "creation_timestamp235e59a1",
                TimeoutSec = -1529270667,
                GrpcHealthCheck = new GRPCHealthCheck(),
                Region = "regionedb20d96",
                UnhealthyThreshold = -790413526,
                SslHealthCheck = new SSLHealthCheck(),
                CheckIntervalSec = 932847778,
                LogConfig = new HealthCheckLogConfig(),
                HealthyThreshold = -1266282289,
                HttpHealthCheck = new HTTPHealthCheck(),
                Description = "description2cf9da67",
                HttpsHealthCheck = new HTTPSHealthCheck(),
                SelfLink = "self_link7e87f12d",
                TcpHealthCheck = new TCPHealthCheck(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheck>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionHealthChecksClient client = new RegionHealthChecksClientImpl(mockGrpcClient.Object, null, null);
            HealthCheck responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheck responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionHealthChecks.RegionHealthChecksClient> mockGrpcClient = new moq::Mock<RegionHealthChecks.RegionHealthChecksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionHealthCheckRequest request = new GetRegionHealthCheckRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            HealthCheck expectedResponse = new HealthCheck
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                Http2HealthCheck = new HTTP2HealthCheck(),
                CreationTimestamp = "creation_timestamp235e59a1",
                TimeoutSec = -1529270667,
                GrpcHealthCheck = new GRPCHealthCheck(),
                Region = "regionedb20d96",
                UnhealthyThreshold = -790413526,
                SslHealthCheck = new SSLHealthCheck(),
                CheckIntervalSec = 932847778,
                LogConfig = new HealthCheckLogConfig(),
                HealthyThreshold = -1266282289,
                HttpHealthCheck = new HTTPHealthCheck(),
                Description = "description2cf9da67",
                HttpsHealthCheck = new HTTPSHealthCheck(),
                SelfLink = "self_link7e87f12d",
                TcpHealthCheck = new TCPHealthCheck(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionHealthChecksClient client = new RegionHealthChecksClientImpl(mockGrpcClient.Object, null, null);
            HealthCheck response = client.Get(request.Project, request.Region, request.HealthCheck);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionHealthChecks.RegionHealthChecksClient> mockGrpcClient = new moq::Mock<RegionHealthChecks.RegionHealthChecksClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForRegionOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRegionHealthCheckRequest request = new GetRegionHealthCheckRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                HealthCheck = "health_check13a16219",
            };
            HealthCheck expectedResponse = new HealthCheck
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = "typee2cc9d59",
                Http2HealthCheck = new HTTP2HealthCheck(),
                CreationTimestamp = "creation_timestamp235e59a1",
                TimeoutSec = -1529270667,
                GrpcHealthCheck = new GRPCHealthCheck(),
                Region = "regionedb20d96",
                UnhealthyThreshold = -790413526,
                SslHealthCheck = new SSLHealthCheck(),
                CheckIntervalSec = 932847778,
                LogConfig = new HealthCheckLogConfig(),
                HealthyThreshold = -1266282289,
                HttpHealthCheck = new HTTPHealthCheck(),
                Description = "description2cf9da67",
                HttpsHealthCheck = new HTTPSHealthCheck(),
                SelfLink = "self_link7e87f12d",
                TcpHealthCheck = new TCPHealthCheck(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<HealthCheck>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionHealthChecksClient client = new RegionHealthChecksClientImpl(mockGrpcClient.Object, null, null);
            HealthCheck responseCallSettings = await client.GetAsync(request.Project, request.Region, request.HealthCheck, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            HealthCheck responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.HealthCheck, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
