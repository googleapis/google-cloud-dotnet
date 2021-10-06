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
    public sealed class GeneratedTargetPoolsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPool expectedResponse = new TargetPool
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Instances =
                {
                    "instances5432a96f",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                BackupPool = "backup_pool2446601c",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                SessionAffinity = TargetPool.Types.SessionAffinity.GeneratedCookie,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPool response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPool expectedResponse = new TargetPool
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Instances =
                {
                    "instances5432a96f",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                BackupPool = "backup_pool2446601c",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                SessionAffinity = TargetPool.Types.SessionAffinity.GeneratedCookie,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPool responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPool responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPool expectedResponse = new TargetPool
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Instances =
                {
                    "instances5432a96f",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                BackupPool = "backup_pool2446601c",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                SessionAffinity = TargetPool.Types.SessionAffinity.GeneratedCookie,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPool response = client.Get(request.Project, request.Region, request.TargetPool);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetPoolRequest request = new GetTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetPool expectedResponse = new TargetPool
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Instances =
                {
                    "instances5432a96f",
                },
                CreationTimestamp = "creation_timestamp235e59a1",
                BackupPool = "backup_pool2446601c",
                Region = "regionedb20d96",
                FailoverRatio = -7.1869584E+17F,
                Description = "description2cf9da67",
                HealthChecks =
                {
                    "health_checksedb1f3f8",
                },
                SelfLink = "self_link7e87f12d",
                SessionAffinity = TargetPool.Types.SessionAffinity.GeneratedCookie,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPool responseCallSettings = await client.GetAsync(request.Project, request.Region, request.TargetPool, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPool responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.TargetPool, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHealthRequestObject()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceReferenceResource = new InstanceReference(),
            };
            TargetPoolInstanceHealth expectedResponse = new TargetPoolInstanceHealth
            {
                Kind = "kindf7aa39d9",
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolInstanceHealth response = client.GetHealth(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHealthRequestObjectAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceReferenceResource = new InstanceReference(),
            };
            TargetPoolInstanceHealth expectedResponse = new TargetPoolInstanceHealth
            {
                Kind = "kindf7aa39d9",
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPoolInstanceHealth>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolInstanceHealth responseCallSettings = await client.GetHealthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPoolInstanceHealth responseCancellationToken = await client.GetHealthAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetHealth()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceReferenceResource = new InstanceReference(),
            };
            TargetPoolInstanceHealth expectedResponse = new TargetPoolInstanceHealth
            {
                Kind = "kindf7aa39d9",
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealth(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolInstanceHealth response = client.GetHealth(request.Project, request.Region, request.TargetPool, request.InstanceReferenceResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetHealthAsync()
        {
            moq::Mock<TargetPools.TargetPoolsClient> mockGrpcClient = new moq::Mock<TargetPools.TargetPoolsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetHealthTargetPoolRequest request = new GetHealthTargetPoolRequest
            {
                TargetPool = "target_pool65e437ac",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InstanceReferenceResource = new InstanceReference(),
            };
            TargetPoolInstanceHealth expectedResponse = new TargetPoolInstanceHealth
            {
                Kind = "kindf7aa39d9",
                HealthStatus = { new HealthStatus(), },
            };
            mockGrpcClient.Setup(x => x.GetHealthAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetPoolInstanceHealth>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetPoolsClient client = new TargetPoolsClientImpl(mockGrpcClient.Object, null);
            TargetPoolInstanceHealth responseCallSettings = await client.GetHealthAsync(request.Project, request.Region, request.TargetPool, request.InstanceReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetPoolInstanceHealth responseCancellationToken = await client.GetHealthAsync(request.Project, request.Region, request.TargetPool, request.InstanceReferenceResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
