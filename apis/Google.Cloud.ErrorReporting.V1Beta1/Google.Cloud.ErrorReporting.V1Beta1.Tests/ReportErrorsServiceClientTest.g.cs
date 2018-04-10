// Copyright 2018 Google LLC
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

namespace Google.Cloud.ErrorReporting.V1Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.ErrorReporting.V1Beta1;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedReportErrorsServiceClientTest
    {
        [Fact]
        public void ReportErrorEvent()
        {
            Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new Mock<ReportErrorsService.ReportErrorsServiceClient>(MockBehavior.Strict);
            ReportErrorEventRequest expectedRequest = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse();
            mockGrpcClient.Setup(x => x.ReportErrorEvent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName projectName = new ProjectName("[PROJECT]");
            ReportedErrorEvent @event = new ReportedErrorEvent();
            ReportErrorEventResponse response = client.ReportErrorEvent(projectName, @event);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReportErrorEventAsync()
        {
            Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new Mock<ReportErrorsService.ReportErrorsServiceClient>(MockBehavior.Strict);
            ReportErrorEventRequest expectedRequest = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse();
            mockGrpcClient.Setup(x => x.ReportErrorEventAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReportErrorEventResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName projectName = new ProjectName("[PROJECT]");
            ReportedErrorEvent @event = new ReportedErrorEvent();
            ReportErrorEventResponse response = await client.ReportErrorEventAsync(projectName, @event);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ReportErrorEvent2()
        {
            Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new Mock<ReportErrorsService.ReportErrorsServiceClient>(MockBehavior.Strict);
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse();
            mockGrpcClient.Setup(x => x.ReportErrorEvent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null);
            ReportErrorEventResponse response = client.ReportErrorEvent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReportErrorEventAsync2()
        {
            Mock<ReportErrorsService.ReportErrorsServiceClient> mockGrpcClient = new Mock<ReportErrorsService.ReportErrorsServiceClient>(MockBehavior.Strict);
            ReportErrorEventRequest request = new ReportErrorEventRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
                Event = new ReportedErrorEvent(),
            };
            ReportErrorEventResponse expectedResponse = new ReportErrorEventResponse();
            mockGrpcClient.Setup(x => x.ReportErrorEventAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReportErrorEventResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ReportErrorsServiceClient client = new ReportErrorsServiceClientImpl(mockGrpcClient.Object, null);
            ReportErrorEventResponse response = await client.ReportErrorEventAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
