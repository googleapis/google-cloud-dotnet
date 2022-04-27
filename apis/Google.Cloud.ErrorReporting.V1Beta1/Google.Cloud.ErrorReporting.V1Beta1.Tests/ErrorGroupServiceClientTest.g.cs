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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.ErrorReporting.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedErrorGroupServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetGroupRequestObject()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup response = client.GetGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupRequestObjectAsync()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ErrorGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup responseCallSettings = await client.GetGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ErrorGroup responseCancellationToken = await client.GetGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGroup()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup response = client.GetGroup(request.GroupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupAsync()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ErrorGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup responseCallSettings = await client.GetGroupAsync(request.GroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ErrorGroup responseCancellationToken = await client.GetGroupAsync(request.GroupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetGroupResourceNames()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.GetGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup response = client.GetGroup(request.GroupNameAsErrorGroupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetGroupResourceNamesAsync()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            GetGroupRequest request = new GetGroupRequest
            {
                GroupNameAsErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.GetGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ErrorGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup responseCallSettings = await client.GetGroupAsync(request.GroupNameAsErrorGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ErrorGroup responseCancellationToken = await client.GetGroupAsync(request.GroupNameAsErrorGroupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGroupRequestObject()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.UpdateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup response = client.UpdateGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGroupRequestObjectAsync()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.UpdateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ErrorGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup responseCallSettings = await client.UpdateGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ErrorGroup responseCancellationToken = await client.UpdateGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateGroup()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.UpdateGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup response = client.UpdateGroup(request.Group);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateGroupAsync()
        {
            moq::Mock<ErrorGroupService.ErrorGroupServiceClient> mockGrpcClient = new moq::Mock<ErrorGroupService.ErrorGroupServiceClient>(moq::MockBehavior.Strict);
            UpdateGroupRequest request = new UpdateGroupRequest
            {
                Group = new ErrorGroup(),
            };
            ErrorGroup expectedResponse = new ErrorGroup
            {
                ErrorGroupName = ErrorGroupName.FromProjectGroup("[PROJECT]", "[GROUP]"),
                GroupId = "group_id4f9a930e",
                TrackingIssues =
                {
                    new TrackingIssue(),
                },
                ResolutionStatus = ResolutionStatus.Muted,
            };
            mockGrpcClient.Setup(x => x.UpdateGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ErrorGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ErrorGroupServiceClient client = new ErrorGroupServiceClientImpl(mockGrpcClient.Object, null, null);
            ErrorGroup responseCallSettings = await client.UpdateGroupAsync(request.Group, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ErrorGroup responseCancellationToken = await client.UpdateGroupAsync(request.Group, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
