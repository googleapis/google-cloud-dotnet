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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTransitionRouteGroupsClientTest
    {
        [xunit::FactAttribute]
        public void GetTransitionRouteGroupRequestObject()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            GetTransitionRouteGroupRequest request = new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                LanguageCode = "language_code2f6c7160",
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup response = client.GetTransitionRouteGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransitionRouteGroupRequestObjectAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            GetTransitionRouteGroupRequest request = new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                LanguageCode = "language_code2f6c7160",
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransitionRouteGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup responseCallSettings = await client.GetTransitionRouteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransitionRouteGroup responseCancellationToken = await client.GetTransitionRouteGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTransitionRouteGroup()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            GetTransitionRouteGroupRequest request = new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup response = client.GetTransitionRouteGroup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransitionRouteGroupAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            GetTransitionRouteGroupRequest request = new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransitionRouteGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup responseCallSettings = await client.GetTransitionRouteGroupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransitionRouteGroup responseCancellationToken = await client.GetTransitionRouteGroupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTransitionRouteGroupResourceNames()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            GetTransitionRouteGroupRequest request = new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup response = client.GetTransitionRouteGroup(request.TransitionRouteGroupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTransitionRouteGroupResourceNamesAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            GetTransitionRouteGroupRequest request = new GetTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransitionRouteGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup responseCallSettings = await client.GetTransitionRouteGroupAsync(request.TransitionRouteGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransitionRouteGroup responseCancellationToken = await client.GetTransitionRouteGroupAsync(request.TransitionRouteGroupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTransitionRouteGroupRequestObject()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            CreateTransitionRouteGroupRequest request = new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                TransitionRouteGroup = new TransitionRouteGroup(),
                LanguageCode = "language_code2f6c7160",
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup response = client.CreateTransitionRouteGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTransitionRouteGroupRequestObjectAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            CreateTransitionRouteGroupRequest request = new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                TransitionRouteGroup = new TransitionRouteGroup(),
                LanguageCode = "language_code2f6c7160",
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransitionRouteGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup responseCallSettings = await client.CreateTransitionRouteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransitionRouteGroup responseCancellationToken = await client.CreateTransitionRouteGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTransitionRouteGroup()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            CreateTransitionRouteGroupRequest request = new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                TransitionRouteGroup = new TransitionRouteGroup(),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup response = client.CreateTransitionRouteGroup(request.Parent, request.TransitionRouteGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTransitionRouteGroupAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            CreateTransitionRouteGroupRequest request = new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                TransitionRouteGroup = new TransitionRouteGroup(),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransitionRouteGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup responseCallSettings = await client.CreateTransitionRouteGroupAsync(request.Parent, request.TransitionRouteGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransitionRouteGroup responseCancellationToken = await client.CreateTransitionRouteGroupAsync(request.Parent, request.TransitionRouteGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTransitionRouteGroupResourceNames()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            CreateTransitionRouteGroupRequest request = new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                TransitionRouteGroup = new TransitionRouteGroup(),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup response = client.CreateTransitionRouteGroup(request.ParentAsFlowName, request.TransitionRouteGroup);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTransitionRouteGroupResourceNamesAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            CreateTransitionRouteGroupRequest request = new CreateTransitionRouteGroupRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                TransitionRouteGroup = new TransitionRouteGroup(),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransitionRouteGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup responseCallSettings = await client.CreateTransitionRouteGroupAsync(request.ParentAsFlowName, request.TransitionRouteGroup, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransitionRouteGroup responseCancellationToken = await client.CreateTransitionRouteGroupAsync(request.ParentAsFlowName, request.TransitionRouteGroup, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTransitionRouteGroupRequestObject()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            UpdateTransitionRouteGroupRequest request = new UpdateTransitionRouteGroupRequest
            {
                TransitionRouteGroup = new TransitionRouteGroup(),
                UpdateMask = new wkt::FieldMask(),
                LanguageCode = "language_code2f6c7160",
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup response = client.UpdateTransitionRouteGroup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTransitionRouteGroupRequestObjectAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            UpdateTransitionRouteGroupRequest request = new UpdateTransitionRouteGroupRequest
            {
                TransitionRouteGroup = new TransitionRouteGroup(),
                UpdateMask = new wkt::FieldMask(),
                LanguageCode = "language_code2f6c7160",
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransitionRouteGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup responseCallSettings = await client.UpdateTransitionRouteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransitionRouteGroup responseCancellationToken = await client.UpdateTransitionRouteGroupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateTransitionRouteGroup()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            UpdateTransitionRouteGroupRequest request = new UpdateTransitionRouteGroupRequest
            {
                TransitionRouteGroup = new TransitionRouteGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup response = client.UpdateTransitionRouteGroup(request.TransitionRouteGroup, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateTransitionRouteGroupAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            UpdateTransitionRouteGroupRequest request = new UpdateTransitionRouteGroupRequest
            {
                TransitionRouteGroup = new TransitionRouteGroup(),
                UpdateMask = new wkt::FieldMask(),
            };
            TransitionRouteGroup expectedResponse = new TransitionRouteGroup
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                DisplayName = "display_name137f65c2",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TransitionRouteGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            TransitionRouteGroup responseCallSettings = await client.UpdateTransitionRouteGroupAsync(request.TransitionRouteGroup, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TransitionRouteGroup responseCancellationToken = await client.UpdateTransitionRouteGroupAsync(request.TransitionRouteGroup, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTransitionRouteGroupRequestObject()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            DeleteTransitionRouteGroupRequest request = new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransitionRouteGroup(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTransitionRouteGroupRequestObjectAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            DeleteTransitionRouteGroupRequest request = new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransitionRouteGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTransitionRouteGroupAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTransitionRouteGroup()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            DeleteTransitionRouteGroupRequest request = new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransitionRouteGroup(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTransitionRouteGroupAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            DeleteTransitionRouteGroupRequest request = new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransitionRouteGroupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTransitionRouteGroupAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTransitionRouteGroupResourceNames()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            DeleteTransitionRouteGroupRequest request = new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransitionRouteGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            client.DeleteTransitionRouteGroup(request.TransitionRouteGroupName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTransitionRouteGroupResourceNamesAsync()
        {
            moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient> mockGrpcClient = new moq::Mock<TransitionRouteGroups.TransitionRouteGroupsClient>(moq::MockBehavior.Strict);
            DeleteTransitionRouteGroupRequest request = new DeleteTransitionRouteGroupRequest
            {
                TransitionRouteGroupName = TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTransitionRouteGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TransitionRouteGroupsClient client = new TransitionRouteGroupsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTransitionRouteGroupAsync(request.TransitionRouteGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTransitionRouteGroupAsync(request.TransitionRouteGroupName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
