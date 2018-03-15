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

namespace Google.Cloud.Monitoring.V3.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedGroupServiceClientTest
    {
        [Fact]
        public void GetGroupTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient> { DefaultValue = DefaultValue.Mock };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetGroup(It.IsAny<GetGroupRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            GroupName name = new GroupName("[PROJECT]", "[GROUP]");
            Group response = client.GetGroup(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateGroupTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient> { DefaultValue = DefaultValue.Mock };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateGroup(It.IsAny<CreateGroupRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[PROJECT]");
            Group group = new Group();
            Group response = client.CreateGroup(name, group);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateGroupTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient> { DefaultValue = DefaultValue.Mock };
            Group expectedResponse = new Group
            {
                GroupName = new GroupName("[PROJECT]", "[GROUP]"),
                DisplayName = "displayName1615086568",
                ParentNameAsGroupName = new GroupName("[PROJECT]", "[GROUP]"),
                Filter = "filter-1274492040",
                IsCluster = false,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateGroup(It.IsAny<UpdateGroupRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group group = new Group();
            Group response = client.UpdateGroup(group);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteGroupTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<GroupService.GroupServiceClient> mockGrpcClient = new Mock<GroupService.GroupServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteGroup(It.IsAny<DeleteGroupRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            GroupName name = new GroupName("[PROJECT]", "[GROUP]");
            client.DeleteGroup(name);
            mockGrpcClient.VerifyAll();
        }

    }
}
