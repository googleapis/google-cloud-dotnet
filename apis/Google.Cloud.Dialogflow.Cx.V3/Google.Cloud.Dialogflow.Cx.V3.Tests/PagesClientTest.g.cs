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
    public sealed class GeneratedPagesClientTest
    {
        [xunit::FactAttribute]
        public void GetPageRequestObject()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            GetPageRequest request = new GetPageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                LanguageCode = "language_code2f6c7160",
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetPage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page response = client.GetPage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPageRequestObjectAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            GetPageRequest request = new GetPageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                LanguageCode = "language_code2f6c7160",
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetPageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Page>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page responseCallSettings = await client.GetPageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Page responseCancellationToken = await client.GetPageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPage()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            GetPageRequest request = new GetPageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetPage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page response = client.GetPage(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPageAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            GetPageRequest request = new GetPageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetPageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Page>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page responseCallSettings = await client.GetPageAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Page responseCancellationToken = await client.GetPageAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPageResourceNames()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            GetPageRequest request = new GetPageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetPage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page response = client.GetPage(request.PageName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPageResourceNamesAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            GetPageRequest request = new GetPageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetPageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Page>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page responseCallSettings = await client.GetPageAsync(request.PageName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Page responseCancellationToken = await client.GetPageAsync(request.PageName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePageRequestObject()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            CreatePageRequest request = new CreatePageRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Page = new Page(),
                LanguageCode = "language_code2f6c7160",
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreatePage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page response = client.CreatePage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePageRequestObjectAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            CreatePageRequest request = new CreatePageRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Page = new Page(),
                LanguageCode = "language_code2f6c7160",
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreatePageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Page>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page responseCallSettings = await client.CreatePageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Page responseCancellationToken = await client.CreatePageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePage()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            CreatePageRequest request = new CreatePageRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Page = new Page(),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreatePage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page response = client.CreatePage(request.Parent, request.Page);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePageAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            CreatePageRequest request = new CreatePageRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Page = new Page(),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreatePageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Page>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page responseCallSettings = await client.CreatePageAsync(request.Parent, request.Page, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Page responseCancellationToken = await client.CreatePageAsync(request.Parent, request.Page, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePageResourceNames()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            CreatePageRequest request = new CreatePageRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Page = new Page(),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreatePage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page response = client.CreatePage(request.ParentAsFlowName, request.Page);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePageResourceNamesAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            CreatePageRequest request = new CreatePageRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Page = new Page(),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.CreatePageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Page>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page responseCallSettings = await client.CreatePageAsync(request.ParentAsFlowName, request.Page, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Page responseCancellationToken = await client.CreatePageAsync(request.ParentAsFlowName, request.Page, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePageRequestObject()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            UpdatePageRequest request = new UpdatePageRequest
            {
                Page = new Page(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.UpdatePage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page response = client.UpdatePage(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePageRequestObjectAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            UpdatePageRequest request = new UpdatePageRequest
            {
                Page = new Page(),
                LanguageCode = "language_code2f6c7160",
                UpdateMask = new wkt::FieldMask(),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.UpdatePageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Page>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page responseCallSettings = await client.UpdatePageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Page responseCancellationToken = await client.UpdatePageAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePage()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            UpdatePageRequest request = new UpdatePageRequest
            {
                Page = new Page(),
                UpdateMask = new wkt::FieldMask(),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.UpdatePage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page response = client.UpdatePage(request.Page, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePageAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            UpdatePageRequest request = new UpdatePageRequest
            {
                Page = new Page(),
                UpdateMask = new wkt::FieldMask(),
            };
            Page expectedResponse = new Page
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                DisplayName = "display_name137f65c2",
                Form = new Form(),
                EntryFulfillment = new Fulfillment(),
                TransitionRoutes =
                {
                    new TransitionRoute(),
                },
                EventHandlers = { new EventHandler(), },
                TransitionRouteGroupsAsTransitionRouteGroupNames =
                {
                    TransitionRouteGroupName.FromProjectLocationAgentFlowTransitionRouteGroup("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[TRANSITION_ROUTE_GROUP]"),
                },
            };
            mockGrpcClient.Setup(x => x.UpdatePageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Page>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            Page responseCallSettings = await client.UpdatePageAsync(request.Page, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Page responseCancellationToken = await client.UpdatePageAsync(request.Page, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePageRequestObject()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            DeletePageRequest request = new DeletePageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            client.DeletePage(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePageRequestObjectAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            DeletePageRequest request = new DeletePageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeletePageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePageAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePage()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            DeletePageRequest request = new DeletePageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            client.DeletePage(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePageAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            DeletePageRequest request = new DeletePageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeletePageAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePageAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePageResourceNames()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            DeletePageRequest request = new DeletePageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePage(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            client.DeletePage(request.PageName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePageResourceNamesAsync()
        {
            moq::Mock<Pages.PagesClient> mockGrpcClient = new moq::Mock<Pages.PagesClient>(moq::MockBehavior.Strict);
            DeletePageRequest request = new DeletePageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePageAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PagesClient client = new PagesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeletePageAsync(request.PageName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePageAsync(request.PageName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
