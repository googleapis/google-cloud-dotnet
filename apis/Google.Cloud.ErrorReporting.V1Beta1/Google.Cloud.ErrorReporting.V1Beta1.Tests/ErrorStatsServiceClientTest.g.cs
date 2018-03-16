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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
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

namespace Google.Cloud.ErrorReporting.V1Beta1.Tests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedErrorStatsServiceClientTest
    {
        [Fact]
        public void DeleteEvents()
        {
            Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new Mock<ErrorStatsService.ErrorStatsServiceClient>(MockBehavior.Strict);
            DeleteEventsRequest expectedRequest = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse();
            mockGrpcClient.Setup(x => x.DeleteEvents(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName projectName = new ProjectName("[PROJECT]");
            DeleteEventsResponse response = client.DeleteEvents(projectName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteEventsAsync()
        {
            Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new Mock<ErrorStatsService.ErrorStatsServiceClient>(MockBehavior.Strict);
            DeleteEventsRequest expectedRequest = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse();
            mockGrpcClient.Setup(x => x.DeleteEventsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DeleteEventsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName projectName = new ProjectName("[PROJECT]");
            DeleteEventsResponse response = await client.DeleteEventsAsync(projectName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteEvents2()
        {
            Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new Mock<ErrorStatsService.ErrorStatsServiceClient>(MockBehavior.Strict);
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse();
            mockGrpcClient.Setup(x => x.DeleteEvents(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            DeleteEventsResponse response = client.DeleteEvents(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteEventsAsync2()
        {
            Mock<ErrorStatsService.ErrorStatsServiceClient> mockGrpcClient = new Mock<ErrorStatsService.ErrorStatsServiceClient>(MockBehavior.Strict);
            DeleteEventsRequest request = new DeleteEventsRequest
            {
                ProjectNameAsProjectName = new ProjectName("[PROJECT]"),
            };
            DeleteEventsResponse expectedResponse = new DeleteEventsResponse();
            mockGrpcClient.Setup(x => x.DeleteEventsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DeleteEventsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ErrorStatsServiceClient client = new ErrorStatsServiceClientImpl(mockGrpcClient.Object, null);
            DeleteEventsResponse response = await client.DeleteEventsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
