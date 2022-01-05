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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Monitoring.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGroupServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetGroupRequestObject()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.GetGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupRequestObjectAsync()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.GetGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.GetGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGroup()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.GetGroup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupAsync()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.GetGroupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.GetGroupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGroupResourceNames1()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.GetGroup(request.GroupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupResourceNames1Async()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.GetGroupAsync(request.GroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.GetGroupAsync(request.GroupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGroupResourceNames2()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.GetGroup(request.ResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupResourceNames2Async()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.GetGroupAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.GetGroupAsync(request.ResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGroupRequestObject()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ValidateOnly = true,
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.CreateGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGroupRequestObjectAsync()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ValidateOnly = true,
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.CreateGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.CreateGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGroup()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.CreateGroup(request.Name, request.Group);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGroupAsync()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.CreateGroupAsync(request.Name, request.Group, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.CreateGroupAsync(request.Name, request.Group, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGroupResourceNames1()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.CreateGroup(request.ProjectName, request.Group);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGroupResourceNames1Async()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.CreateGroupAsync(request.ProjectName, request.Group, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.CreateGroupAsync(request.ProjectName, request.Group, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGroupResourceNames2()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.CreateGroup(request.OrganizationName, request.Group);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGroupResourceNames2Async()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.CreateGroupAsync(request.OrganizationName, request.Group, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.CreateGroupAsync(request.OrganizationName, request.Group, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGroupResourceNames3()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.CreateGroup(request.FolderName, request.Group);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGroupResourceNames3Async()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.CreateGroupAsync(request.FolderName, request.Group, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.CreateGroupAsync(request.FolderName, request.Group, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateGroupResourceNames4()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.CreateGroup(request.ResourceName, request.Group);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateGroupResourceNames4Async()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            CreateGroupRequest request = new CreateGroupRequest
            {
                Group = new Group(),
                ProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.CreateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.CreateGroupAsync(request.ResourceName, request.Group, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.CreateGroupAsync(request.ResourceName, request.Group, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGroupRequestObject()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new Group(),
                ValidateOnly = true,
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.UpdateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.UpdateGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGroupRequestObjectAsync()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new Group(),
                ValidateOnly = true,
            };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.UpdateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.UpdateGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.UpdateGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGroup()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest { Group = new Group(), };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.UpdateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group response = client.UpdateGroup(request.Group);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGroupAsync()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest { Group = new Group(), };
            Group expectedResponse = new Group
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                DisplayName = "display_name137f65c2",
                ParentName = "parent_name91315215",
                Filter = "filtere47ac9b2",
                IsCluster = true,
            };
            mockGrpcClient.Setup(x => x.UpdateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Group>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            Group responseCallSettings = await client.UpdateGroupAsync(request.Group, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Group responseCancellationToken = await client.UpdateGroupAsync(request.Group, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGroupRequestObject()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                Recursive = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteGroup(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGroupRequestObjectAsync()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                Recursive = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGroupAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGroup()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteGroup(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGroupAsync()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteGroupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGroupAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGroupResourceNames1()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteGroup(request.GroupName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGroupResourceNames1Async()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteGroupAsync(request.GroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGroupAsync(request.GroupName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteGroupResourceNames2()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteGroup(request.ResourceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteGroupResourceNames2Async()
        {
            moq::Mock<GroupService.GroupServiceClient> mockGrpcClient = new moq::Mock<GroupService.GroupServiceClient>(moq::MockBehavior.Strict);
            DeleteGroupRequest request = new DeleteGroupRequest
            {
                GroupName = GroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupServiceClient client = new GroupServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteGroupAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteGroupAsync(request.ResourceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
