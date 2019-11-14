// Copyright 2019 Google LLC
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
    public class GeneratedErrorGroupServiceClientTest
    {
        [Fact]
        public void GetGroup()
        {
            Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new Mock<ErrorGroupService.ErrorGroupServiceClient>(MockBehavior.Strict);
            GetGroupRequest expectedRequest = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
                GroupId = "groupId506361563",
            };
            mockGrpcClient.Setup(x => x.GetGroup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null);
            ErrorGroupName groupName = new ErrorGroupName("[PROJECT]", "[GROUP]");
            ErrorGroup response = client.GetGroup(groupName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetGroupAsync()
        {
            Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new Mock<ErrorGroupService.ErrorGroupServiceClient>(MockBehavior.Strict);
            GetGroupRequest expectedRequest = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
                GroupId = "groupId506361563",
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ErrorGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null);
            ErrorGroupName groupName = new ErrorGroupName("[PROJECT]", "[GROUP]");
            ErrorGroup response = await client.GetGroupAsync(groupName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetGroup2()
        {
            Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new Mock<ErrorGroupService.ErrorGroupServiceClient>(MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
                GroupId = "groupId506361563",
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null);
            ErrorGroup response = client.GetGroup(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetGroupAsync2()
        {
            Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new Mock<ErrorGroupService.ErrorGroupServiceClient>(MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
                GroupId = "groupId506361563",
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ErrorGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null);
            ErrorGroup response = await client.GetGroupAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateGroup()
        {
            Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new Mock<ErrorGroupService.ErrorGroupServiceClient>(MockBehavior.Strict);
            UpdateGroupRequest expectedRequest = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
                GroupId = "groupId506361563",
            };
            mockGrpcClient.Setup(x => x.UpdateGroup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null);
            ErrorGroup group = new ErrorGroup();
            ErrorGroup response = client.UpdateGroup(group);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateGroupAsync()
        {
            Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new Mock<ErrorGroupService.ErrorGroupServiceClient>(MockBehavior.Strict);
            UpdateGroupRequest expectedRequest = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
                GroupId = "groupId506361563",
            };
            mockGrpcClient.Setup(x => x.UpdateGroupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ErrorGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null);
            ErrorGroup group = new ErrorGroup();
            ErrorGroup response = await client.UpdateGroupAsync(group);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateGroup2()
        {
            Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new Mock<ErrorGroupService.ErrorGroupServiceClient>(MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
                GroupId = "groupId506361563",
            };
            mockGrpcClient.Setup(x => x.UpdateGroup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null);
            ErrorGroup response = client.UpdateGroup(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateGroupAsync2()
        {
            Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new Mock<ErrorGroupService.ErrorGroupServiceClient>(MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = new ErrorGroupName("[PROJECT]", "[GROUP]"),
                GroupId = "groupId506361563",
            };
            mockGrpcClient.Setup(x => x.UpdateGroupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ErrorGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null);
            ErrorGroup response = await client.UpdateGroupAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
