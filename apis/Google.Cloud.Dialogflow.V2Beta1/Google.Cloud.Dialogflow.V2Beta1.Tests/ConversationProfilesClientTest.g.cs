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
    public sealed class GeneratedConversationProfilesClientTest
    {
        [xunit::FactAttribute]
        public void GetConversationProfileRequestObject()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConversationProfileRequest request = new GetConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.GetConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile response = client.GetConversationProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationProfileRequestObjectAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConversationProfileRequest request = new GetConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.GetConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile responseCallSettings = await client.GetConversationProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationProfile responseCancellationToken = await client.GetConversationProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationProfile()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConversationProfileRequest request = new GetConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.GetConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile response = client.GetConversationProfile(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationProfileAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConversationProfileRequest request = new GetConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.GetConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile responseCallSettings = await client.GetConversationProfileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationProfile responseCancellationToken = await client.GetConversationProfileAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationProfileResourceNames()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConversationProfileRequest request = new GetConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.GetConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile response = client.GetConversationProfile(request.ConversationProfileName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationProfileResourceNamesAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetConversationProfileRequest request = new GetConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.GetConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile responseCallSettings = await client.GetConversationProfileAsync(request.ConversationProfileName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationProfile responseCancellationToken = await client.GetConversationProfileAsync(request.ConversationProfileName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversationProfileRequestObject()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.CreateConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile response = client.CreateConversationProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationProfileRequestObjectAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.CreateConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile responseCallSettings = await client.CreateConversationProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationProfile responseCancellationToken = await client.CreateConversationProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversationProfile()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.CreateConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile response = client.CreateConversationProfile(request.Parent, request.ConversationProfile);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationProfileAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.CreateConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile responseCallSettings = await client.CreateConversationProfileAsync(request.Parent, request.ConversationProfile, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationProfile responseCancellationToken = await client.CreateConversationProfileAsync(request.Parent, request.ConversationProfile, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversationProfileResourceNames1()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.CreateConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile response = client.CreateConversationProfile(request.ParentAsProjectName, request.ConversationProfile);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationProfileResourceNames1Async()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.CreateConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile responseCallSettings = await client.CreateConversationProfileAsync(request.ParentAsProjectName, request.ConversationProfile, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationProfile responseCancellationToken = await client.CreateConversationProfileAsync(request.ParentAsProjectName, request.ConversationProfile, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversationProfileResourceNames2()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.CreateConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile response = client.CreateConversationProfile(request.ParentAsLocationName, request.ConversationProfile);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationProfileResourceNames2Async()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.CreateConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile responseCallSettings = await client.CreateConversationProfileAsync(request.ParentAsLocationName, request.ConversationProfile, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationProfile responseCancellationToken = await client.CreateConversationProfileAsync(request.ParentAsLocationName, request.ConversationProfile, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateConversationProfileRequestObject()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateConversationProfileRequest request = new UpdateConversationProfileRequest
            {
                ConversationProfile = new ConversationProfile(),
                UpdateMask = new wkt::FieldMask(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.UpdateConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile response = client.UpdateConversationProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateConversationProfileRequestObjectAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateConversationProfileRequest request = new UpdateConversationProfileRequest
            {
                ConversationProfile = new ConversationProfile(),
                UpdateMask = new wkt::FieldMask(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.UpdateConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile responseCallSettings = await client.UpdateConversationProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationProfile responseCancellationToken = await client.UpdateConversationProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateConversationProfile()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateConversationProfileRequest request = new UpdateConversationProfileRequest
            {
                ConversationProfile = new ConversationProfile(),
                UpdateMask = new wkt::FieldMask(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.UpdateConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile response = client.UpdateConversationProfile(request.ConversationProfile, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateConversationProfileAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateConversationProfileRequest request = new UpdateConversationProfileRequest
            {
                ConversationProfile = new ConversationProfile(),
                UpdateMask = new wkt::FieldMask(),
            };
            ConversationProfile expectedResponse = new ConversationProfile
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                DisplayName = "display_name137f65c2",
                AutomatedAgentConfig = new AutomatedAgentConfig(),
                HumanAgentAssistantConfig = new HumanAgentAssistantConfig(),
                HumanAgentHandoffConfig = new HumanAgentHandoffConfig(),
                NotificationConfig = new NotificationConfig(),
                LoggingConfig = new LoggingConfig(),
                NewMessageEventNotificationConfig = new NotificationConfig(),
                SttConfig = new SpeechToTextConfig(),
                LanguageCode = "language_code2f6c7160",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SecuritySettingsAsCXSecuritySettingsName = CXSecuritySettingsName.FromProjectLocationSecuritySettings("[PROJECT]", "[LOCATION]", "[SECURITY_SETTINGS]"),
                TimeZone = "time_zone73f23b20",
            };
            mockGrpcClient.Setup(x => x.UpdateConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ConversationProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            ConversationProfile responseCallSettings = await client.UpdateConversationProfileAsync(request.ConversationProfile, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ConversationProfile responseCancellationToken = await client.UpdateConversationProfileAsync(request.ConversationProfile, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConversationProfileRequestObject()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteConversationProfileRequest request = new DeleteConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteConversationProfile(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConversationProfileRequestObjectAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteConversationProfileRequest request = new DeleteConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteConversationProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConversationProfileAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConversationProfile()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteConversationProfileRequest request = new DeleteConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteConversationProfile(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConversationProfileAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteConversationProfileRequest request = new DeleteConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteConversationProfileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConversationProfileAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConversationProfileResourceNames()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteConversationProfileRequest request = new DeleteConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversationProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteConversationProfile(request.ConversationProfileName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConversationProfileResourceNamesAsync()
        {
            moq::Mock<ConversationProfiles.ConversationProfilesClient> mockGrpcClient = new moq::Mock<ConversationProfiles.ConversationProfilesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteConversationProfileRequest request = new DeleteConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversationProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationProfilesClient client = new ConversationProfilesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteConversationProfileAsync(request.ConversationProfileName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConversationProfileAsync(request.ConversationProfileName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
