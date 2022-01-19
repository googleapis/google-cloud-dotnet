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
using gagr = Google.Api.Gax.ResourceNames;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.ErrorReporting.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedErrorStatsServiceClientTest
    {
        [xunit::FactAttribute]
        public void DeleteEventsRequestObject()
        {
            moq::Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new moq::Mock<ErrorStatsService.ErrorStatsServiceClient>(moq::MockBehavior.Strict);
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse { };
            mockGrpcClient.Setup(x => x.DeleteEvents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            DeleteEventsResponse response = client.DeleteEvents(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEventsRequestObjectAsync()
        {
            moq::Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new moq::Mock<ErrorStatsService.ErrorStatsServiceClient>(moq::MockBehavior.Strict);
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse { };
            mockGrpcClient.Setup(x => x.DeleteEventsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeleteEventsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            DeleteEventsResponse responseCallSettings = await client.DeleteEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeleteEventsResponse responseCancellationToken = await client.DeleteEventsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEvents()
        {
            moq::Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new moq::Mock<ErrorStatsService.ErrorStatsServiceClient>(moq::MockBehavior.Strict);
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse { };
            mockGrpcClient.Setup(x => x.DeleteEvents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            DeleteEventsResponse response = client.DeleteEvents(request.ProjectName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEventsAsync()
        {
            moq::Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new moq::Mock<ErrorStatsService.ErrorStatsServiceClient>(moq::MockBehavior.Strict);
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse { };
            mockGrpcClient.Setup(x => x.DeleteEventsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeleteEventsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            DeleteEventsResponse responseCallSettings = await client.DeleteEventsAsync(request.ProjectName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeleteEventsResponse responseCancellationToken = await client.DeleteEventsAsync(request.ProjectName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteEventsResourceNames()
        {
            moq::Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new moq::Mock<ErrorStatsService.ErrorStatsServiceClient>(moq::MockBehavior.Strict);
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse { };
            mockGrpcClient.Setup(x => x.DeleteEvents(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            DeleteEventsResponse response = client.DeleteEvents(request.ProjectNameAsProjectName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteEventsResourceNamesAsync()
        {
            moq::Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new moq::Mock<ErrorStatsService.ErrorStatsServiceClient>(moq::MockBehavior.Strict);
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse { };
            mockGrpcClient.Setup(x => x.DeleteEventsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeleteEventsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            DeleteEventsResponse responseCallSettings = await client.DeleteEventsAsync(request.ProjectNameAsProjectName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeleteEventsResponse responseCancellationToken = await client.DeleteEventsAsync(request.ProjectNameAsProjectName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
