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
    public sealed class GeneratedAgentsClientTest
    {
        [xunit::FactAttribute]
        public void GetAgentRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.GetAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.GetAgent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAgentRequestObjectAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.GetAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.GetAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.GetAgentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAgent()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.GetAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.GetAgent(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAgentAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.GetAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.GetAgentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.GetAgentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAgentResourceNames()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.GetAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.GetAgent(request.AgentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAgentResourceNamesAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.GetAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.GetAgentAsync(request.AgentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.GetAgentAsync(request.AgentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAgentRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Agent = new Agent(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.CreateAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.CreateAgent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAgentRequestObjectAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Agent = new Agent(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.CreateAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.CreateAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.CreateAgentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAgent()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Agent = new Agent(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.CreateAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.CreateAgent(request.Parent, request.Agent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAgentAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Agent = new Agent(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.CreateAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.CreateAgentAsync(request.Parent, request.Agent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.CreateAgentAsync(request.Parent, request.Agent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateAgentResourceNames()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Agent = new Agent(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.CreateAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.CreateAgent(request.ParentAsLocationName, request.Agent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateAgentResourceNamesAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateAgentRequest request = new CreateAgentRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Agent = new Agent(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.CreateAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.CreateAgentAsync(request.ParentAsLocationName, request.Agent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.CreateAgentAsync(request.ParentAsLocationName, request.Agent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAgentRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateAgentRequest request = new UpdateAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.UpdateAgent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAgentRequestObjectAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateAgentRequest request = new UpdateAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.UpdateAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.UpdateAgentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateAgent()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateAgentRequest request = new UpdateAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.UpdateAgent(request.Agent, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateAgentAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateAgentRequest request = new UpdateAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Agent expectedResponse = new Agent
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                SpeechToTextSettings = new SpeechToTextSettings(),
                StartFlowAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                SecuritySettingsAsSecuritySettingsName = SecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
#pragma warning disable CS0612
                EnableStackdriverLogging = false,
#pragma warning restore CS0612
                EnableSpellCorrection = true,
                AdvancedSettings = new AdvancedSettings(),
                Locked = true,
            };
            mockGrpcClient.Setup(x => x.UpdateAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.UpdateAgentAsync(request.Agent, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.UpdateAgentAsync(request.Agent, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAgentRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAgent(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAgentRequestObjectAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAgentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAgent()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAgent(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAgentAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAgentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAgentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAgentResourceNames()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAgent(request.AgentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAgentResourceNamesAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAgentAsync(request.AgentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAgentAsync(request.AgentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ValidateAgentRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateAgentRequest request = new ValidateAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            AgentValidationResult expectedResponse = new AgentValidationResult
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowValidationResults =
                {
                    new FlowValidationResult(),
                },
            };
            mockGrpcClient.Setup(x => x.ValidateAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            AgentValidationResult response = client.ValidateAgent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ValidateAgentRequestObjectAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ValidateAgentRequest request = new ValidateAgentRequest
            {
                AgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            AgentValidationResult expectedResponse = new AgentValidationResult
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowValidationResults =
                {
                    new FlowValidationResult(),
                },
            };
            mockGrpcClient.Setup(x => x.ValidateAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AgentValidationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            AgentValidationResult responseCallSettings = await client.ValidateAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AgentValidationResult responseCancellationToken = await client.ValidateAgentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAgentValidationResultRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentValidationResultRequest request = new GetAgentValidationResultRequest
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            AgentValidationResult expectedResponse = new AgentValidationResult
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowValidationResults =
                {
                    new FlowValidationResult(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAgentValidationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            AgentValidationResult response = client.GetAgentValidationResult(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAgentValidationResultRequestObjectAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentValidationResultRequest request = new GetAgentValidationResultRequest
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                LanguageCode = "language_code2f6c7160",
            };
            AgentValidationResult expectedResponse = new AgentValidationResult
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowValidationResults =
                {
                    new FlowValidationResult(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAgentValidationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AgentValidationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            AgentValidationResult responseCallSettings = await client.GetAgentValidationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AgentValidationResult responseCancellationToken = await client.GetAgentValidationResultAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAgentValidationResult()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentValidationResultRequest request = new GetAgentValidationResultRequest
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            AgentValidationResult expectedResponse = new AgentValidationResult
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowValidationResults =
                {
                    new FlowValidationResult(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAgentValidationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            AgentValidationResult response = client.GetAgentValidationResult(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAgentValidationResultAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentValidationResultRequest request = new GetAgentValidationResultRequest
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            AgentValidationResult expectedResponse = new AgentValidationResult
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowValidationResults =
                {
                    new FlowValidationResult(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAgentValidationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AgentValidationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            AgentValidationResult responseCallSettings = await client.GetAgentValidationResultAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AgentValidationResult responseCancellationToken = await client.GetAgentValidationResultAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAgentValidationResultResourceNames()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentValidationResultRequest request = new GetAgentValidationResultRequest
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            AgentValidationResult expectedResponse = new AgentValidationResult
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowValidationResults =
                {
                    new FlowValidationResult(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAgentValidationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            AgentValidationResult response = client.GetAgentValidationResult(request.AgentValidationResultName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAgentValidationResultResourceNamesAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAgentValidationResultRequest request = new GetAgentValidationResultRequest
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
            };
            AgentValidationResult expectedResponse = new AgentValidationResult
            {
                AgentValidationResultName = AgentValidationResultName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                FlowValidationResults =
                {
                    new FlowValidationResult(),
                },
            };
            mockGrpcClient.Setup(x => x.GetAgentValidationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AgentValidationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            AgentValidationResult responseCallSettings = await client.GetAgentValidationResultAsync(request.AgentValidationResultName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AgentValidationResult responseCancellationToken = await client.GetAgentValidationResultAsync(request.AgentValidationResultName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
