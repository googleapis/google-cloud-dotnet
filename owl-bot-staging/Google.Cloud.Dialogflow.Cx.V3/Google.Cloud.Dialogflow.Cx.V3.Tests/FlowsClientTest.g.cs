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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFlowsClientTest
    {
        [xunit::FactAttribute]
        public void CreateFlowRequestObject()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFlowRequest request = new CreateFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Flow = new Flow(),
                LanguageCode = "language_code2f6c7160",
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreateFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow response = client.CreateFlow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFlowRequestObjectAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFlowRequest request = new CreateFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Flow = new Flow(),
                LanguageCode = "language_code2f6c7160",
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreateFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Flow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow responseCallSettings = await client.CreateFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Flow responseCancellationToken = await client.CreateFlowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFlow()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFlowRequest request = new CreateFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Flow = new Flow(),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreateFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow response = client.CreateFlow(request.Parent, request.Flow);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFlowAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFlowRequest request = new CreateFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Flow = new Flow(),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreateFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Flow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow responseCallSettings = await client.CreateFlowAsync(request.Parent, request.Flow, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Flow responseCancellationToken = await client.CreateFlowAsync(request.Parent, request.Flow, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFlowResourceNames()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFlowRequest request = new CreateFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Flow = new Flow(),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreateFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow response = client.CreateFlow(request.ParentAsAgentName, request.Flow);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFlowResourceNamesAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFlowRequest request = new CreateFlowRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Flow = new Flow(),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreateFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Flow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow responseCallSettings = await client.CreateFlowAsync(request.ParentAsAgentName, request.Flow, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Flow responseCancellationToken = await client.CreateFlowAsync(request.ParentAsAgentName, request.Flow, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteFlowRequestObject()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFlowRequest request = new DeleteFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            client.DeleteFlow(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteFlowRequestObjectAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFlowRequest request = new DeleteFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteFlowAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteFlow()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFlowRequest request = new DeleteFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            client.DeleteFlow(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteFlowAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFlowRequest request = new DeleteFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteFlowAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteFlowAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteFlowResourceNames()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFlowRequest request = new DeleteFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            client.DeleteFlow(request.FlowName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteFlowResourceNamesAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFlowRequest request = new DeleteFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteFlowAsync(request.FlowName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteFlowAsync(request.FlowName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFlowRequestObject()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowRequest request = new GetFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "language_code2f6c7160",
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow response = client.GetFlow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFlowRequestObjectAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowRequest request = new GetFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "language_code2f6c7160",
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Flow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow responseCallSettings = await client.GetFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Flow responseCancellationToken = await client.GetFlowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFlow()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowRequest request = new GetFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow response = client.GetFlow(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFlowAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowRequest request = new GetFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Flow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow responseCallSettings = await client.GetFlowAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Flow responseCancellationToken = await client.GetFlowAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFlowResourceNames()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowRequest request = new GetFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow response = client.GetFlow(request.FlowName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFlowResourceNamesAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowRequest request = new GetFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Flow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow responseCallSettings = await client.GetFlowAsync(request.FlowName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Flow responseCancellationToken = await client.GetFlowAsync(request.FlowName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFlowRequestObject()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFlowRequest request = new UpdateFlowRequest
            {
                Flow = new Flow(),
                UpdateMask = new wkt::FieldMask(),
                LanguageCode = "language_code2f6c7160",
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow response = client.UpdateFlow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFlowRequestObjectAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFlowRequest request = new UpdateFlowRequest
            {
                Flow = new Flow(),
                UpdateMask = new wkt::FieldMask(),
                LanguageCode = "language_code2f6c7160",
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Flow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow responseCallSettings = await client.UpdateFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Flow responseCancellationToken = await client.UpdateFlowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFlow()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFlowRequest request = new UpdateFlowRequest
            {
                Flow = new Flow(),
                UpdateMask = new wkt::FieldMask(),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow response = client.UpdateFlow(request.Flow, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFlowAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFlowRequest request = new UpdateFlowRequest
            {
                Flow = new Flow(),
                UpdateMask = new wkt::FieldMask(),
            };
            Flow expectedResponse = new Flow
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                NluSettings = new NluSettings(),
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Flow>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            Flow responseCallSettings = await client.UpdateFlowAsync(request.Flow, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Flow responseCancellationToken = await client.UpdateFlowAsync(request.Flow, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateFlowRequestObject()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateFlowRequest request = new ValidateFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "language_code2f6c7160",
            };
            FlowValidationResult expectedResponse = new FlowValidationResult
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                ValidationMessages =
                {
                    new ValidationMessage(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.ValidateFlow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            FlowValidationResult response = client.ValidateFlow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateFlowRequestObjectAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateFlowRequest request = new ValidateFlowRequest
            {
                FlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "language_code2f6c7160",
            };
            FlowValidationResult expectedResponse = new FlowValidationResult
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                ValidationMessages =
                {
                    new ValidationMessage(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.ValidateFlowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FlowValidationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            FlowValidationResult responseCallSettings = await client.ValidateFlowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FlowValidationResult responseCancellationToken = await client.ValidateFlowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFlowValidationResultRequestObject()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowValidationResultRequest request = new GetFlowValidationResultRequest
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "language_code2f6c7160",
            };
            FlowValidationResult expectedResponse = new FlowValidationResult
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                ValidationMessages =
                {
                    new ValidationMessage(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFlowValidationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            FlowValidationResult response = client.GetFlowValidationResult(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFlowValidationResultRequestObjectAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowValidationResultRequest request = new GetFlowValidationResultRequest
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "language_code2f6c7160",
            };
            FlowValidationResult expectedResponse = new FlowValidationResult
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                ValidationMessages =
                {
                    new ValidationMessage(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFlowValidationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FlowValidationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            FlowValidationResult responseCallSettings = await client.GetFlowValidationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FlowValidationResult responseCancellationToken = await client.GetFlowValidationResultAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFlowValidationResult()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowValidationResultRequest request = new GetFlowValidationResultRequest
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            FlowValidationResult expectedResponse = new FlowValidationResult
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                ValidationMessages =
                {
                    new ValidationMessage(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFlowValidationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            FlowValidationResult response = client.GetFlowValidationResult(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFlowValidationResultAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowValidationResultRequest request = new GetFlowValidationResultRequest
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            FlowValidationResult expectedResponse = new FlowValidationResult
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                ValidationMessages =
                {
                    new ValidationMessage(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFlowValidationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FlowValidationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            FlowValidationResult responseCallSettings = await client.GetFlowValidationResultAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FlowValidationResult responseCancellationToken = await client.GetFlowValidationResultAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFlowValidationResultResourceNames()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowValidationResultRequest request = new GetFlowValidationResultRequest
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            FlowValidationResult expectedResponse = new FlowValidationResult
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                ValidationMessages =
                {
                    new ValidationMessage(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFlowValidationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            FlowValidationResult response = client.GetFlowValidationResult(request.FlowValidationResultName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFlowValidationResultResourceNamesAsync()
        {
            moq::Mock<Flows.FlowsClient> mockGrpcClient = new moq::Mock<Flows.FlowsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFlowValidationResultRequest request = new GetFlowValidationResultRequest
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
            };
            FlowValidationResult expectedResponse = new FlowValidationResult
            {
                FlowValidationResultName = FlowValidationResultName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                ValidationMessages =
                {
                    new ValidationMessage(),
                },
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetFlowValidationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FlowValidationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FlowsClient client = new FlowsClientImpl(mockGrpcClient.Object, null);
            FlowValidationResult responseCallSettings = await client.GetFlowValidationResultAsync(request.FlowValidationResultName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FlowValidationResult responseCancellationToken = await client.GetFlowValidationResultAsync(request.FlowValidationResultName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
