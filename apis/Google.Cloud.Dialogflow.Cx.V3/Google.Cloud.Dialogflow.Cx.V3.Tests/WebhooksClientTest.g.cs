// Copyright 2021 Google LLC
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
    public sealed class GeneratedWebhooksClientTest
    {
        [xunit::FactAttribute]
        public void GetWebhookRequestObject()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            GetWebhookRequest request = new GetWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook response = client.GetWebhook(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWebhookRequestObjectAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            GetWebhookRequest request = new GetWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Webhook>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook responseCallSettings = await client.GetWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Webhook responseCancellationToken = await client.GetWebhookAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWebhook()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            GetWebhookRequest request = new GetWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook response = client.GetWebhook(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWebhookAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            GetWebhookRequest request = new GetWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Webhook>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook responseCallSettings = await client.GetWebhookAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Webhook responseCancellationToken = await client.GetWebhookAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWebhookResourceNames()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            GetWebhookRequest request = new GetWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook response = client.GetWebhook(request.WebhookName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWebhookResourceNamesAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            GetWebhookRequest request = new GetWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.GetWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Webhook>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook responseCallSettings = await client.GetWebhookAsync(request.WebhookName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Webhook responseCancellationToken = await client.GetWebhookAsync(request.WebhookName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWebhookRequestObject()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            CreateWebhookRequest request = new CreateWebhookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Webhook = new Webhook(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook response = client.CreateWebhook(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWebhookRequestObjectAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            CreateWebhookRequest request = new CreateWebhookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Webhook = new Webhook(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Webhook>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook responseCallSettings = await client.CreateWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Webhook responseCancellationToken = await client.CreateWebhookAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWebhook()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            CreateWebhookRequest request = new CreateWebhookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Webhook = new Webhook(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook response = client.CreateWebhook(request.Parent, request.Webhook);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWebhookAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            CreateWebhookRequest request = new CreateWebhookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Webhook = new Webhook(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Webhook>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook responseCallSettings = await client.CreateWebhookAsync(request.Parent, request.Webhook, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Webhook responseCancellationToken = await client.CreateWebhookAsync(request.Parent, request.Webhook, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateWebhookResourceNames()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            CreateWebhookRequest request = new CreateWebhookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Webhook = new Webhook(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook response = client.CreateWebhook(request.ParentAsAgentName, request.Webhook);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateWebhookResourceNamesAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            CreateWebhookRequest request = new CreateWebhookRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Webhook = new Webhook(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.CreateWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Webhook>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook responseCallSettings = await client.CreateWebhookAsync(request.ParentAsAgentName, request.Webhook, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Webhook responseCancellationToken = await client.CreateWebhookAsync(request.ParentAsAgentName, request.Webhook, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWebhookRequestObject()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            UpdateWebhookRequest request = new UpdateWebhookRequest
            {
                Webhook = new Webhook(),
                UpdateMask = new wkt::FieldMask(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook response = client.UpdateWebhook(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWebhookRequestObjectAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            UpdateWebhookRequest request = new UpdateWebhookRequest
            {
                Webhook = new Webhook(),
                UpdateMask = new wkt::FieldMask(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Webhook>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook responseCallSettings = await client.UpdateWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Webhook responseCancellationToken = await client.UpdateWebhookAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateWebhook()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            UpdateWebhookRequest request = new UpdateWebhookRequest
            {
                Webhook = new Webhook(),
                UpdateMask = new wkt::FieldMask(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook response = client.UpdateWebhook(request.Webhook, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateWebhookAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            UpdateWebhookRequest request = new UpdateWebhookRequest
            {
                Webhook = new Webhook(),
                UpdateMask = new wkt::FieldMask(),
            };
            Webhook expectedResponse = new Webhook
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                DisplayName = "display_name137f65c2",
                GenericWebService = new Webhook.Types.GenericWebService(),
                Disabled = false,
                Timeout = new wkt::Duration(),
                ServiceDirectory = new Webhook.Types.ServiceDirectoryConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Webhook>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            Webhook responseCallSettings = await client.UpdateWebhookAsync(request.Webhook, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Webhook responseCancellationToken = await client.UpdateWebhookAsync(request.Webhook, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWebhookRequestObject()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            DeleteWebhookRequest request = new DeleteWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            client.DeleteWebhook(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWebhookRequestObjectAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            DeleteWebhookRequest request = new DeleteWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWebhookAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWebhook()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            DeleteWebhookRequest request = new DeleteWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            client.DeleteWebhook(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWebhookAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            DeleteWebhookRequest request = new DeleteWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWebhookAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWebhookAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteWebhookResourceNames()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            DeleteWebhookRequest request = new DeleteWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebhook(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            client.DeleteWebhook(request.WebhookName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteWebhookResourceNamesAsync()
        {
            moq::Mock<Webhooks.WebhooksClient> mockGrpcClient = new moq::Mock<Webhooks.WebhooksClient>(moq::MockBehavior.Strict);
            DeleteWebhookRequest request = new DeleteWebhookRequest
            {
                WebhookName = WebhookName.FromProjectLocationAgentWebhook("[PROJECT]", "[LOCATION]", "[AGENT]", "[WEBHOOK]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteWebhookAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            WebhooksClient client = new WebhooksClientImpl(mockGrpcClient.Object, null);
            await client.DeleteWebhookAsync(request.WebhookName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteWebhookAsync(request.WebhookName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
