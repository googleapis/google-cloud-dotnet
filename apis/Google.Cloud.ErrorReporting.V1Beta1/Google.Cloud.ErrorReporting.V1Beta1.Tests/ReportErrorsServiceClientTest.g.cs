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
    public sealed class GeneratedReportErrorsServiceClientTest
    {
        [xunit::FactAttribute]
        public void ReportErrorEventRequestObject()
        {
            moq::Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new moq::Mock<ReportErrorsService.ReportErrorsServiceClient>(moq::MockBehavior.Strict);
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse { };
            mockGrpcClient.Setup(x => x.ReportErrorEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null, null);
            ReportErrorEventResponse response = client.ReportErrorEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportErrorEventRequestObjectAsync()
        {
            moq::Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new moq::Mock<ReportErrorsService.ReportErrorsServiceClient>(moq::MockBehavior.Strict);
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse { };
            mockGrpcClient.Setup(x => x.ReportErrorEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportErrorEventResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null, null);
            ReportErrorEventResponse responseCallSettings = await client.ReportErrorEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportErrorEventResponse responseCancellationToken = await client.ReportErrorEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportErrorEvent()
        {
            moq::Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new moq::Mock<ReportErrorsService.ReportErrorsServiceClient>(moq::MockBehavior.Strict);
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse { };
            mockGrpcClient.Setup(x => x.ReportErrorEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null, null);
            ReportErrorEventResponse response = client.ReportErrorEvent(request.ProjectName, request.Event);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportErrorEventAsync()
        {
            moq::Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new moq::Mock<ReportErrorsService.ReportErrorsServiceClient>(moq::MockBehavior.Strict);
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse { };
            mockGrpcClient.Setup(x => x.ReportErrorEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportErrorEventResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null, null);
            ReportErrorEventResponse responseCallSettings = await client.ReportErrorEventAsync(request.ProjectName, request.Event, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportErrorEventResponse responseCancellationToken = await client.ReportErrorEventAsync(request.ProjectName, request.Event, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportErrorEventResourceNames()
        {
            moq::Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new moq::Mock<ReportErrorsService.ReportErrorsServiceClient>(moq::MockBehavior.Strict);
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse { };
            mockGrpcClient.Setup(x => x.ReportErrorEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null, null);
            ReportErrorEventResponse response = client.ReportErrorEvent(request.ProjectNameAsProjectName, request.Event);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportErrorEventResourceNamesAsync()
        {
            moq::Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new moq::Mock<ReportErrorsService.ReportErrorsServiceClient>(moq::MockBehavior.Strict);
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse { };
            mockGrpcClient.Setup(x => x.ReportErrorEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportErrorEventResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null, null);
            ReportErrorEventResponse responseCallSettings = await client.ReportErrorEventAsync(request.ProjectNameAsProjectName, request.Event, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportErrorEventResponse responseCancellationToken = await client.ReportErrorEventAsync(request.ProjectNameAsProjectName, request.Event, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
