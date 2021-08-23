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

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSpecialistPoolServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetSpecialistPoolRequestObject()
        {
            moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient> mockGrpcClient = new moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpecialistPoolRequest request = new GetSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
            };
            SpecialistPool expectedResponse = new SpecialistPool
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
                DisplayName = "display_name137f65c2",
                SpecialistManagersCount = 1389839351,
                SpecialistManagerEmails =
                {
                    "specialist_manager_emails54da434d",
                },
                PendingDataLabelingJobs =
                {
                    "pending_data_labeling_jobsd91cc38b",
                },
            };
            mockGrpcClient.Setup(x => x.GetSpecialistPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpecialistPoolServiceClient client = new SpecialistPoolServiceClientImpl(mockGrpcClient.Object, null);
            SpecialistPool response = client.GetSpecialistPool(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSpecialistPoolRequestObjectAsync()
        {
            moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient> mockGrpcClient = new moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpecialistPoolRequest request = new GetSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
            };
            SpecialistPool expectedResponse = new SpecialistPool
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
                DisplayName = "display_name137f65c2",
                SpecialistManagersCount = 1389839351,
                SpecialistManagerEmails =
                {
                    "specialist_manager_emails54da434d",
                },
                PendingDataLabelingJobs =
                {
                    "pending_data_labeling_jobsd91cc38b",
                },
            };
            mockGrpcClient.Setup(x => x.GetSpecialistPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SpecialistPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpecialistPoolServiceClient client = new SpecialistPoolServiceClientImpl(mockGrpcClient.Object, null);
            SpecialistPool responseCallSettings = await client.GetSpecialistPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SpecialistPool responseCancellationToken = await client.GetSpecialistPoolAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSpecialistPool()
        {
            moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient> mockGrpcClient = new moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpecialistPoolRequest request = new GetSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
            };
            SpecialistPool expectedResponse = new SpecialistPool
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
                DisplayName = "display_name137f65c2",
                SpecialistManagersCount = 1389839351,
                SpecialistManagerEmails =
                {
                    "specialist_manager_emails54da434d",
                },
                PendingDataLabelingJobs =
                {
                    "pending_data_labeling_jobsd91cc38b",
                },
            };
            mockGrpcClient.Setup(x => x.GetSpecialistPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpecialistPoolServiceClient client = new SpecialistPoolServiceClientImpl(mockGrpcClient.Object, null);
            SpecialistPool response = client.GetSpecialistPool(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSpecialistPoolAsync()
        {
            moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient> mockGrpcClient = new moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpecialistPoolRequest request = new GetSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
            };
            SpecialistPool expectedResponse = new SpecialistPool
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
                DisplayName = "display_name137f65c2",
                SpecialistManagersCount = 1389839351,
                SpecialistManagerEmails =
                {
                    "specialist_manager_emails54da434d",
                },
                PendingDataLabelingJobs =
                {
                    "pending_data_labeling_jobsd91cc38b",
                },
            };
            mockGrpcClient.Setup(x => x.GetSpecialistPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SpecialistPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpecialistPoolServiceClient client = new SpecialistPoolServiceClientImpl(mockGrpcClient.Object, null);
            SpecialistPool responseCallSettings = await client.GetSpecialistPoolAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SpecialistPool responseCancellationToken = await client.GetSpecialistPoolAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSpecialistPoolResourceNames()
        {
            moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient> mockGrpcClient = new moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpecialistPoolRequest request = new GetSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
            };
            SpecialistPool expectedResponse = new SpecialistPool
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
                DisplayName = "display_name137f65c2",
                SpecialistManagersCount = 1389839351,
                SpecialistManagerEmails =
                {
                    "specialist_manager_emails54da434d",
                },
                PendingDataLabelingJobs =
                {
                    "pending_data_labeling_jobsd91cc38b",
                },
            };
            mockGrpcClient.Setup(x => x.GetSpecialistPool(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpecialistPoolServiceClient client = new SpecialistPoolServiceClientImpl(mockGrpcClient.Object, null);
            SpecialistPool response = client.GetSpecialistPool(request.SpecialistPoolName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSpecialistPoolResourceNamesAsync()
        {
            moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient> mockGrpcClient = new moq::Mock<SpecialistPoolService.SpecialistPoolServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSpecialistPoolRequest request = new GetSpecialistPoolRequest
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
            };
            SpecialistPool expectedResponse = new SpecialistPool
            {
                SpecialistPoolName = SpecialistPoolName.FromProjectLocationSpecialistPool("[PROJECT]", "[LOCATION]", "[SPECIALIST_POOL]"),
                DisplayName = "display_name137f65c2",
                SpecialistManagersCount = 1389839351,
                SpecialistManagerEmails =
                {
                    "specialist_manager_emails54da434d",
                },
                PendingDataLabelingJobs =
                {
                    "pending_data_labeling_jobsd91cc38b",
                },
            };
            mockGrpcClient.Setup(x => x.GetSpecialistPoolAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SpecialistPool>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpecialistPoolServiceClient client = new SpecialistPoolServiceClientImpl(mockGrpcClient.Object, null);
            SpecialistPool responseCallSettings = await client.GetSpecialistPoolAsync(request.SpecialistPoolName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SpecialistPool responseCancellationToken = await client.GetSpecialistPoolAsync(request.SpecialistPoolName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
