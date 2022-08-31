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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAgentsClientTest
    {
        [xunit::FactAttribute]
        public void GetAgentRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.GetAgent(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAgentAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.GetAgentAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.GetAgentAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAgentResourceNames1()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.GetAgent(request.ParentAsProjectName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAgentResourceNames1Async()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.GetAgentAsync(request.ParentAsProjectName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.GetAgentAsync(request.ParentAsProjectName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAgentResourceNames2()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.GetAgent(request.ParentAsLocationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAgentResourceNames2Async()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetAgentRequest request = new GetAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.GetAgentAsync(request.ParentAsLocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.GetAgentAsync(request.ParentAsLocationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetAgentRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetAgentRequest request = new SetAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.SetAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.SetAgent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetAgentRequestObjectAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetAgentRequest request = new SetAgentRequest
            {
                Agent = new Agent(),
                UpdateMask = new wkt::FieldMask(),
            };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.SetAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.SetAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.SetAgentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetAgent()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetAgentRequest request = new SetAgentRequest { Agent = new Agent(), };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.SetAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent response = client.SetAgent(request.Agent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetAgentAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            SetAgentRequest request = new SetAgentRequest { Agent = new Agent(), };
            Agent expectedResponse = new Agent
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                DisplayName = "display_name137f65c2",
                DefaultLanguageCode = "default_language_codee612e130",
                SupportedLanguageCodes =
                {
                    "supported_language_codesbcd806b9",
                },
                TimeZone = "time_zone73f23b20",
                Description = "description2cf9da67",
                AvatarUri = "avatar_urie1767db7",
                EnableLogging = false,
#pragma warning disable CS0612
                MatchMode = Agent.Types.MatchMode.MlOnly,
#pragma warning restore CS0612
                ClassificationThreshold = -7.6869614E+17F,
                ApiVersion = Agent.Types.ApiVersion.V2Beta1,
                Tier = Agent.Types.Tier.Standard,
            };
            mockGrpcClient.Setup(x => x.SetAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Agent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            Agent responseCallSettings = await client.SetAgentAsync(request.Agent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Agent responseCancellationToken = await client.SetAgentAsync(request.Agent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAgentRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
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
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAgent(request.Parent);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAgentAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAgentAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAgentAsync(request.Parent, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAgentResourceNames1()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAgent(request.ParentAsProjectName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAgentResourceNames1Async()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAgentAsync(request.ParentAsProjectName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAgentAsync(request.ParentAsProjectName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAgentResourceNames2()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteAgent(request.ParentAsLocationName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAgentResourceNames2Async()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteAgentRequest request = new DeleteAgentRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAgentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteAgentAsync(request.ParentAsLocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAgentAsync(request.ParentAsLocationName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetValidationResultRequestObject()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetValidationResultRequest request = new GetValidationResultRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                LanguageCode = "language_code2f6c7160",
            };
            ValidationResult expectedResponse = new ValidationResult
            {
                ValidationErrors =
                {
                    new ValidationError(),
                },
            };
            mockGrpcClient.Setup(x => x.GetValidationResult(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            ValidationResult response = client.GetValidationResult(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetValidationResultRequestObjectAsync()
        {
            moq::Mock<Agents.AgentsClient> mockGrpcClient = new moq::Mock<Agents.AgentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetValidationResultRequest request = new GetValidationResultRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                LanguageCode = "language_code2f6c7160",
            };
            ValidationResult expectedResponse = new ValidationResult
            {
                ValidationErrors =
                {
                    new ValidationError(),
                },
            };
            mockGrpcClient.Setup(x => x.GetValidationResultAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ValidationResult>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgentsClient client = new AgentsClientImpl(mockGrpcClient.Object, null, null);
            ValidationResult responseCallSettings = await client.GetValidationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ValidationResult responseCancellationToken = await client.GetValidationResultAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
