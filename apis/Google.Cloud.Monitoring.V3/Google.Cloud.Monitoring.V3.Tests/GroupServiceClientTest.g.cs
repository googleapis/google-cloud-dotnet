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

namespace Google.Cloud.Monitoring.V3.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Monitoring.V3;
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
    public class GeneratedGroupServiceClientTest
    {
        [Fact]
        public void GetGroup()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            GetGroupRequest expectedRequest = new GetGroupRequest
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.GetGroup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            GroupName name = new GroupName("[PROJECT]", "[GROUP]");
            Group response = client.GetGroup(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetGroupAsync()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            GetGroupRequest expectedRequest = new GetGroupRequest
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Group>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            GroupName name = new GroupName("[PROJECT]", "[GROUP]");
            Group response = await client.GetGroupAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetGroup2()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.GetGroup(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetGroupAsync2()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Group>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = await client.GetGroupAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateGroup()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            CreateGroupRequest expectedRequest = new CreateGroupRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Group = new Group(),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.CreateGroup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            Group group = new Group();
            Group response = client.CreateGroup(name, group);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateGroupAsync()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            CreateGroupRequest expectedRequest = new CreateGroupRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Group = new Group(),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.CreateGroupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Group>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            Group group = new Group();
            Group response = await client.CreateGroupAsync(name, group);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateGroup2()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Group = new Group(),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.CreateGroup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.CreateGroup(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateGroupAsync2()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Group = new Group(),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.CreateGroupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Group>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = await client.CreateGroupAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateGroup()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            UpdateGroupRequest expectedRequest = new UpdateGroupRequest
            {
                Group = new Group(),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.UpdateGroup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group group = new Group();
            Group response = client.UpdateGroup(group);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateGroupAsync()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            UpdateGroupRequest expectedRequest = new UpdateGroupRequest
            {
                Group = new Group(),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.UpdateGroupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Group>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group group = new Group();
            Group response = await client.UpdateGroupAsync(group);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateGroup2()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new Group(),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.UpdateGroup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.UpdateGroup(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateGroupAsync2()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new Group(),
            };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            mockGrpcClient.Setup(x => x.UpdateGroupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Group>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = await client.UpdateGroupAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteGroup()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            DeleteGroupRequest expectedRequest = new DeleteGroupRequest
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteGroup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            GroupName name = new GroupName("[PROJECT]", "[GROUP]");
            client.DeleteGroup(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteGroupAsync()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            DeleteGroupRequest expectedRequest = new DeleteGroupRequest
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteGroupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            GroupName name = new GroupName("[PROJECT]", "[GROUP]");
            await client.DeleteGroupAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteGroup2()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteGroup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteGroup(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteGroupAsync2()
        {
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient>(MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteGroupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteGroupAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
