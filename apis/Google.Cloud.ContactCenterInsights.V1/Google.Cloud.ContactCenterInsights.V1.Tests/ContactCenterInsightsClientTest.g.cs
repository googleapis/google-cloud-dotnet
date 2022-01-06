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

namespace Google.Cloud.ContactCenterInsights.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedContactCenterInsightsClientTest
    {
        [xunit::FactAttribute]
        public void CreateConversationRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "conversation_id32c22ad5",
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.CreateConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation response = client.CreateConversation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "conversation_id32c22ad5",
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.CreateConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation responseCallSettings = await client.CreateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CreateConversationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversation()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "conversation_id32c22ad5",
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.CreateConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation response = client.CreateConversation(request.Parent, request.Conversation, request.ConversationId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "conversation_id32c22ad5",
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.CreateConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation responseCallSettings = await client.CreateConversationAsync(request.Parent, request.Conversation, request.ConversationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CreateConversationAsync(request.Parent, request.Conversation, request.ConversationId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversationResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "conversation_id32c22ad5",
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.CreateConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation response = client.CreateConversation(request.ParentAsLocationName, request.Conversation, request.ConversationId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "conversation_id32c22ad5",
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.CreateConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation responseCallSettings = await client.CreateConversationAsync(request.ParentAsLocationName, request.Conversation, request.ConversationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CreateConversationAsync(request.ParentAsLocationName, request.Conversation, request.ConversationId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateConversationRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateConversationRequest request = new UpdateConversationRequest
            {
                Conversation = new Conversation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.UpdateConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation response = client.UpdateConversation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateConversationRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateConversationRequest request = new UpdateConversationRequest
            {
                Conversation = new Conversation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.UpdateConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation responseCallSettings = await client.UpdateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.UpdateConversationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateConversation()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateConversationRequest request = new UpdateConversationRequest
            {
                Conversation = new Conversation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.UpdateConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation response = client.UpdateConversation(request.Conversation, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateConversationAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateConversationRequest request = new UpdateConversationRequest
            {
                Conversation = new Conversation(),
                UpdateMask = new wkt::FieldMask(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.UpdateConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation responseCallSettings = await client.UpdateConversationAsync(request.Conversation, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.UpdateConversationAsync(request.Conversation, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                View = ConversationView.Basic,
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.GetConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation response = client.GetConversation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                View = ConversationView.Basic,
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.GetConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation responseCallSettings = await client.GetConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.GetConversationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversation()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.GetConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation response = client.GetConversation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.GetConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation responseCallSettings = await client.GetConversationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.GetConversationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.GetConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation response = client.GetConversation(request.ConversationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                DataSource = new ConversationDataSource(),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                AgentId = "agent_id5ff0189b",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CallMetadata = new Conversation.Types.CallMetadata(),
                Transcript = new Conversation.Types.Transcript(),
                Medium = Conversation.Types.Medium.Unspecified,
                Duration = new wkt::Duration(),
                TurnCount = -1286028205,
                LatestAnalysis = new Analysis(),
                RuntimeAnnotations =
                {
                    new RuntimeAnnotation(),
                },
                LanguageCode = "language_code2f6c7160",
                ExpireTime = new wkt::Timestamp(),
                Ttl = new wkt::Duration(),
                StartTime = new wkt::Timestamp(),
                DialogflowIntents =
                {
                    {
                        "key8a0b6e3c",
                        new DialogflowIntent()
                    },
                },
                ObfuscatedUserId = "obfuscated_user_ida61668af",
            };
            mockGrpcClient.Setup(x => x.GetConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Conversation responseCallSettings = await client.GetConversationAsync(request.ConversationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.GetConversationAsync(request.ConversationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConversationRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeleteConversation(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConversationRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConversationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConversation()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeleteConversation(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConversationAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteConversationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConversationAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteConversationResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeleteConversation(request.ConversationName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteConversationResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteConversationAsync(request.ConversationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteConversationAsync(request.ConversationName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnalysisRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            Analysis expectedResponse = new Analysis
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
                RequestTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                AnalysisResult = new AnalysisResult(),
            };
            mockGrpcClient.Setup(x => x.GetAnalysis(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Analysis response = client.GetAnalysis(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnalysisRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            Analysis expectedResponse = new Analysis
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
                RequestTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                AnalysisResult = new AnalysisResult(),
            };
            mockGrpcClient.Setup(x => x.GetAnalysisAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Analysis>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Analysis responseCallSettings = await client.GetAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Analysis responseCancellationToken = await client.GetAnalysisAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnalysis()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            Analysis expectedResponse = new Analysis
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
                RequestTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                AnalysisResult = new AnalysisResult(),
            };
            mockGrpcClient.Setup(x => x.GetAnalysis(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Analysis response = client.GetAnalysis(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnalysisAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            Analysis expectedResponse = new Analysis
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
                RequestTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                AnalysisResult = new AnalysisResult(),
            };
            mockGrpcClient.Setup(x => x.GetAnalysisAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Analysis>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Analysis responseCallSettings = await client.GetAnalysisAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Analysis responseCancellationToken = await client.GetAnalysisAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAnalysisResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            Analysis expectedResponse = new Analysis
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
                RequestTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                AnalysisResult = new AnalysisResult(),
            };
            mockGrpcClient.Setup(x => x.GetAnalysis(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Analysis response = client.GetAnalysis(request.AnalysisName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAnalysisResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            Analysis expectedResponse = new Analysis
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
                RequestTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                AnalysisResult = new AnalysisResult(),
            };
            mockGrpcClient.Setup(x => x.GetAnalysisAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Analysis>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Analysis responseCallSettings = await client.GetAnalysisAsync(request.AnalysisName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Analysis responseCancellationToken = await client.GetAnalysisAsync(request.AnalysisName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAnalysisRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnalysis(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeleteAnalysis(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAnalysisRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnalysisAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAnalysisAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAnalysis()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnalysis(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeleteAnalysis(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAnalysisAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnalysisAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAnalysisAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAnalysisAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteAnalysisResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnalysis(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeleteAnalysis(request.AnalysisName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAnalysisResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteAnalysisAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteAnalysisAsync(request.AnalysisName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteAnalysisAsync(request.AnalysisName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIssueModelRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIssueModelRequest request = new UpdateIssueModelRequest
            {
                IssueModel = new IssueModel(),
                UpdateMask = new wkt::FieldMask(),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.UpdateIssueModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel response = client.UpdateIssueModel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIssueModelRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIssueModelRequest request = new UpdateIssueModelRequest
            {
                IssueModel = new IssueModel(),
                UpdateMask = new wkt::FieldMask(),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.UpdateIssueModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IssueModel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel responseCallSettings = await client.UpdateIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IssueModel responseCancellationToken = await client.UpdateIssueModelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIssueModel()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIssueModelRequest request = new UpdateIssueModelRequest
            {
                IssueModel = new IssueModel(),
                UpdateMask = new wkt::FieldMask(),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.UpdateIssueModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel response = client.UpdateIssueModel(request.IssueModel, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIssueModelAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIssueModelRequest request = new UpdateIssueModelRequest
            {
                IssueModel = new IssueModel(),
                UpdateMask = new wkt::FieldMask(),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.UpdateIssueModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IssueModel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel responseCallSettings = await client.UpdateIssueModelAsync(request.IssueModel, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IssueModel responseCancellationToken = await client.UpdateIssueModelAsync(request.IssueModel, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIssueModelRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueModelRequest request = new GetIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.GetIssueModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel response = client.GetIssueModel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIssueModelRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueModelRequest request = new GetIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.GetIssueModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IssueModel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel responseCallSettings = await client.GetIssueModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IssueModel responseCancellationToken = await client.GetIssueModelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIssueModel()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueModelRequest request = new GetIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.GetIssueModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel response = client.GetIssueModel(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIssueModelAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueModelRequest request = new GetIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.GetIssueModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IssueModel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel responseCallSettings = await client.GetIssueModelAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IssueModel responseCancellationToken = await client.GetIssueModelAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIssueModelResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueModelRequest request = new GetIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.GetIssueModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel response = client.GetIssueModel(request.IssueModelName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIssueModelResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueModelRequest request = new GetIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            IssueModel expectedResponse = new IssueModel
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                State = IssueModel.Types.State.Unspecified,
                InputDataConfig = new IssueModel.Types.InputDataConfig(),
                TrainingStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.GetIssueModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IssueModel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            IssueModel responseCallSettings = await client.GetIssueModelAsync(request.IssueModelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IssueModel responseCancellationToken = await client.GetIssueModelAsync(request.IssueModelName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListIssueModelsRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssueModelsRequest request = new ListIssueModelsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListIssueModelsResponse expectedResponse = new ListIssueModelsResponse
            {
                IssueModels = { new IssueModel(), },
            };
            mockGrpcClient.Setup(x => x.ListIssueModels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssueModelsResponse response = client.ListIssueModels(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListIssueModelsRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssueModelsRequest request = new ListIssueModelsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListIssueModelsResponse expectedResponse = new ListIssueModelsResponse
            {
                IssueModels = { new IssueModel(), },
            };
            mockGrpcClient.Setup(x => x.ListIssueModelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListIssueModelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssueModelsResponse responseCallSettings = await client.ListIssueModelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListIssueModelsResponse responseCancellationToken = await client.ListIssueModelsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListIssueModels()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssueModelsRequest request = new ListIssueModelsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListIssueModelsResponse expectedResponse = new ListIssueModelsResponse
            {
                IssueModels = { new IssueModel(), },
            };
            mockGrpcClient.Setup(x => x.ListIssueModels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssueModelsResponse response = client.ListIssueModels(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListIssueModelsAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssueModelsRequest request = new ListIssueModelsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListIssueModelsResponse expectedResponse = new ListIssueModelsResponse
            {
                IssueModels = { new IssueModel(), },
            };
            mockGrpcClient.Setup(x => x.ListIssueModelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListIssueModelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssueModelsResponse responseCallSettings = await client.ListIssueModelsAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListIssueModelsResponse responseCancellationToken = await client.ListIssueModelsAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListIssueModelsResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssueModelsRequest request = new ListIssueModelsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListIssueModelsResponse expectedResponse = new ListIssueModelsResponse
            {
                IssueModels = { new IssueModel(), },
            };
            mockGrpcClient.Setup(x => x.ListIssueModels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssueModelsResponse response = client.ListIssueModels(request.ParentAsLocationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListIssueModelsResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssueModelsRequest request = new ListIssueModelsRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            ListIssueModelsResponse expectedResponse = new ListIssueModelsResponse
            {
                IssueModels = { new IssueModel(), },
            };
            mockGrpcClient.Setup(x => x.ListIssueModelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListIssueModelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssueModelsResponse responseCallSettings = await client.ListIssueModelsAsync(request.ParentAsLocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListIssueModelsResponse responseCancellationToken = await client.ListIssueModelsAsync(request.ParentAsLocationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIssueRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIssue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue response = client.GetIssue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIssueRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIssueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Issue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue responseCallSettings = await client.GetIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Issue responseCancellationToken = await client.GetIssueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIssue()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIssue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue response = client.GetIssue(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIssueAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIssueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Issue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue responseCallSettings = await client.GetIssueAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Issue responseCancellationToken = await client.GetIssueAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIssueResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIssue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue response = client.GetIssue(request.IssueName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIssueResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetIssueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Issue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue responseCallSettings = await client.GetIssueAsync(request.IssueName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Issue responseCancellationToken = await client.GetIssueAsync(request.IssueName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListIssuesRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            ListIssuesResponse expectedResponse = new ListIssuesResponse
            {
                Issues = { new Issue(), },
            };
            mockGrpcClient.Setup(x => x.ListIssues(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssuesResponse response = client.ListIssues(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListIssuesRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            ListIssuesResponse expectedResponse = new ListIssuesResponse
            {
                Issues = { new Issue(), },
            };
            mockGrpcClient.Setup(x => x.ListIssuesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListIssuesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssuesResponse responseCallSettings = await client.ListIssuesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListIssuesResponse responseCancellationToken = await client.ListIssuesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListIssues()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            ListIssuesResponse expectedResponse = new ListIssuesResponse
            {
                Issues = { new Issue(), },
            };
            mockGrpcClient.Setup(x => x.ListIssues(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssuesResponse response = client.ListIssues(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListIssuesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            ListIssuesResponse expectedResponse = new ListIssuesResponse
            {
                Issues = { new Issue(), },
            };
            mockGrpcClient.Setup(x => x.ListIssuesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListIssuesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssuesResponse responseCallSettings = await client.ListIssuesAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListIssuesResponse responseCancellationToken = await client.ListIssuesAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListIssuesResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            ListIssuesResponse expectedResponse = new ListIssuesResponse
            {
                Issues = { new Issue(), },
            };
            mockGrpcClient.Setup(x => x.ListIssues(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssuesResponse response = client.ListIssues(request.ParentAsIssueModelName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListIssuesResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            ListIssuesResponse expectedResponse = new ListIssuesResponse
            {
                Issues = { new Issue(), },
            };
            mockGrpcClient.Setup(x => x.ListIssuesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListIssuesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            ListIssuesResponse responseCallSettings = await client.ListIssuesAsync(request.ParentAsIssueModelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListIssuesResponse responseCancellationToken = await client.ListIssuesAsync(request.ParentAsIssueModelName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIssueRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIssueRequest request = new UpdateIssueRequest
            {
                Issue = new Issue(),
                UpdateMask = new wkt::FieldMask(),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateIssue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue response = client.UpdateIssue(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIssueRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIssueRequest request = new UpdateIssueRequest
            {
                Issue = new Issue(),
                UpdateMask = new wkt::FieldMask(),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateIssueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Issue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue responseCallSettings = await client.UpdateIssueAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Issue responseCancellationToken = await client.UpdateIssueAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIssue()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIssueRequest request = new UpdateIssueRequest
            {
                Issue = new Issue(),
                UpdateMask = new wkt::FieldMask(),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateIssue(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue response = client.UpdateIssue(request.Issue, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIssueAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIssueRequest request = new UpdateIssueRequest
            {
                Issue = new Issue(),
                UpdateMask = new wkt::FieldMask(),
            };
            Issue expectedResponse = new Issue
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateIssueAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Issue>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Issue responseCallSettings = await client.UpdateIssueAsync(request.Issue, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Issue responseCancellationToken = await client.UpdateIssueAsync(request.Issue, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateIssueModelStatsRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateIssueModelStatsRequest request = new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            CalculateIssueModelStatsResponse expectedResponse = new CalculateIssueModelStatsResponse
            {
                CurrentStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.CalculateIssueModelStats(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateIssueModelStatsResponse response = client.CalculateIssueModelStats(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateIssueModelStatsRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateIssueModelStatsRequest request = new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            CalculateIssueModelStatsResponse expectedResponse = new CalculateIssueModelStatsResponse
            {
                CurrentStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.CalculateIssueModelStatsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CalculateIssueModelStatsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateIssueModelStatsResponse responseCallSettings = await client.CalculateIssueModelStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CalculateIssueModelStatsResponse responseCancellationToken = await client.CalculateIssueModelStatsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateIssueModelStats()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateIssueModelStatsRequest request = new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            CalculateIssueModelStatsResponse expectedResponse = new CalculateIssueModelStatsResponse
            {
                CurrentStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.CalculateIssueModelStats(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateIssueModelStatsResponse response = client.CalculateIssueModelStats(request.IssueModel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateIssueModelStatsAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateIssueModelStatsRequest request = new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            CalculateIssueModelStatsResponse expectedResponse = new CalculateIssueModelStatsResponse
            {
                CurrentStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.CalculateIssueModelStatsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CalculateIssueModelStatsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateIssueModelStatsResponse responseCallSettings = await client.CalculateIssueModelStatsAsync(request.IssueModel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CalculateIssueModelStatsResponse responseCancellationToken = await client.CalculateIssueModelStatsAsync(request.IssueModel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateIssueModelStatsResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateIssueModelStatsRequest request = new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            CalculateIssueModelStatsResponse expectedResponse = new CalculateIssueModelStatsResponse
            {
                CurrentStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.CalculateIssueModelStats(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateIssueModelStatsResponse response = client.CalculateIssueModelStats(request.IssueModelAsIssueModelName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateIssueModelStatsResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateIssueModelStatsRequest request = new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            CalculateIssueModelStatsResponse expectedResponse = new CalculateIssueModelStatsResponse
            {
                CurrentStats = new IssueModelLabelStats(),
            };
            mockGrpcClient.Setup(x => x.CalculateIssueModelStatsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CalculateIssueModelStatsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateIssueModelStatsResponse responseCallSettings = await client.CalculateIssueModelStatsAsync(request.IssueModelAsIssueModelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CalculateIssueModelStatsResponse responseCancellationToken = await client.CalculateIssueModelStatsAsync(request.IssueModelAsIssueModelName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePhraseMatcherRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreatePhraseMatcherRequest request = new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseMatcher = new PhraseMatcher(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher response = client.CreatePhraseMatcher(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhraseMatcherRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreatePhraseMatcherRequest request = new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseMatcher = new PhraseMatcher(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseMatcher>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher responseCallSettings = await client.CreatePhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseMatcher responseCancellationToken = await client.CreatePhraseMatcherAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePhraseMatcher()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreatePhraseMatcherRequest request = new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseMatcher = new PhraseMatcher(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher response = client.CreatePhraseMatcher(request.Parent, request.PhraseMatcher);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhraseMatcherAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreatePhraseMatcherRequest request = new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseMatcher = new PhraseMatcher(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseMatcher>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher responseCallSettings = await client.CreatePhraseMatcherAsync(request.Parent, request.PhraseMatcher, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseMatcher responseCancellationToken = await client.CreatePhraseMatcherAsync(request.Parent, request.PhraseMatcher, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePhraseMatcherResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreatePhraseMatcherRequest request = new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseMatcher = new PhraseMatcher(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher response = client.CreatePhraseMatcher(request.ParentAsLocationName, request.PhraseMatcher);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhraseMatcherResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreatePhraseMatcherRequest request = new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseMatcher = new PhraseMatcher(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreatePhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseMatcher>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher responseCallSettings = await client.CreatePhraseMatcherAsync(request.ParentAsLocationName, request.PhraseMatcher, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseMatcher responseCancellationToken = await client.CreatePhraseMatcherAsync(request.ParentAsLocationName, request.PhraseMatcher, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhraseMatcherRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseMatcherRequest request = new GetPhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher response = client.GetPhraseMatcher(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhraseMatcherRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseMatcherRequest request = new GetPhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseMatcher>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher responseCallSettings = await client.GetPhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseMatcher responseCancellationToken = await client.GetPhraseMatcherAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhraseMatcher()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseMatcherRequest request = new GetPhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher response = client.GetPhraseMatcher(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhraseMatcherAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseMatcherRequest request = new GetPhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseMatcher>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher responseCallSettings = await client.GetPhraseMatcherAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseMatcher responseCancellationToken = await client.GetPhraseMatcherAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhraseMatcherResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseMatcherRequest request = new GetPhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher response = client.GetPhraseMatcher(request.PhraseMatcherName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhraseMatcherResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPhraseMatcherRequest request = new GetPhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetPhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseMatcher>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher responseCallSettings = await client.GetPhraseMatcherAsync(request.PhraseMatcherName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseMatcher responseCancellationToken = await client.GetPhraseMatcherAsync(request.PhraseMatcherName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhraseMatcherRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeletePhraseMatcherRequest request = new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeletePhraseMatcher(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhraseMatcherRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeletePhraseMatcherRequest request = new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeletePhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePhraseMatcherAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhraseMatcher()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeletePhraseMatcherRequest request = new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeletePhraseMatcher(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhraseMatcherAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeletePhraseMatcherRequest request = new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeletePhraseMatcherAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePhraseMatcherAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhraseMatcherResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeletePhraseMatcherRequest request = new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeletePhraseMatcher(request.PhraseMatcherName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhraseMatcherResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeletePhraseMatcherRequest request = new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeletePhraseMatcherAsync(request.PhraseMatcherName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePhraseMatcherAsync(request.PhraseMatcherName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhraseMatcherRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdatePhraseMatcherRequest request = new UpdatePhraseMatcherRequest
            {
                PhraseMatcher = new PhraseMatcher(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdatePhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher response = client.UpdatePhraseMatcher(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhraseMatcherRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdatePhraseMatcherRequest request = new UpdatePhraseMatcherRequest
            {
                PhraseMatcher = new PhraseMatcher(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdatePhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseMatcher>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher responseCallSettings = await client.UpdatePhraseMatcherAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseMatcher responseCancellationToken = await client.UpdatePhraseMatcherAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhraseMatcher()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdatePhraseMatcherRequest request = new UpdatePhraseMatcherRequest
            {
                PhraseMatcher = new PhraseMatcher(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdatePhraseMatcher(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher response = client.UpdatePhraseMatcher(request.PhraseMatcher, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhraseMatcherAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdatePhraseMatcherRequest request = new UpdatePhraseMatcherRequest
            {
                PhraseMatcher = new PhraseMatcher(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhraseMatcher expectedResponse = new PhraseMatcher
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
                RevisionId = "revision_id8d9ae05d",
                VersionTag = "version_tage7ed110f",
                RevisionCreateTime = new wkt::Timestamp(),
                DisplayName = "display_name137f65c2",
                Type = PhraseMatcher.Types.PhraseMatcherType.Unspecified,
                Active = false,
                PhraseMatchRuleGroups =
                {
                    new PhraseMatchRuleGroup(),
                },
                ActivationUpdateTime = new wkt::Timestamp(),
                RoleMatch = ConversationParticipant.Types.Role.HumanAgent,
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdatePhraseMatcherAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseMatcher>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            PhraseMatcher responseCallSettings = await client.UpdatePhraseMatcherAsync(request.PhraseMatcher, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseMatcher responseCancellationToken = await client.UpdatePhraseMatcherAsync(request.PhraseMatcher, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateStatsRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateStatsRequest request = new CalculateStatsRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "filtere47ac9b2",
            };
            CalculateStatsResponse expectedResponse = new CalculateStatsResponse
            {
                AverageDuration = new wkt::Duration(),
                AverageTurnCount = 239030703,
                ConversationCount = 1758685422,
                SmartHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                CustomHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
#pragma warning disable CS0612
                IssueMatches =
#pragma warning restore CS0612
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                ConversationCountTimeSeries = new CalculateStatsResponse.Types.TimeSeries(),
                IssueMatchesStats =
                {
                    {
                        "key8a0b6e3c",
                        new IssueModelLabelStats.Types.IssueStats()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CalculateStats(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateStatsResponse response = client.CalculateStats(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateStatsRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateStatsRequest request = new CalculateStatsRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "filtere47ac9b2",
            };
            CalculateStatsResponse expectedResponse = new CalculateStatsResponse
            {
                AverageDuration = new wkt::Duration(),
                AverageTurnCount = 239030703,
                ConversationCount = 1758685422,
                SmartHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                CustomHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
#pragma warning disable CS0612
                IssueMatches =
#pragma warning restore CS0612
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                ConversationCountTimeSeries = new CalculateStatsResponse.Types.TimeSeries(),
                IssueMatchesStats =
                {
                    {
                        "key8a0b6e3c",
                        new IssueModelLabelStats.Types.IssueStats()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CalculateStatsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CalculateStatsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateStatsResponse responseCallSettings = await client.CalculateStatsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CalculateStatsResponse responseCancellationToken = await client.CalculateStatsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateStats()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateStatsRequest request = new CalculateStatsRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            CalculateStatsResponse expectedResponse = new CalculateStatsResponse
            {
                AverageDuration = new wkt::Duration(),
                AverageTurnCount = 239030703,
                ConversationCount = 1758685422,
                SmartHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                CustomHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
#pragma warning disable CS0612
                IssueMatches =
#pragma warning restore CS0612
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                ConversationCountTimeSeries = new CalculateStatsResponse.Types.TimeSeries(),
                IssueMatchesStats =
                {
                    {
                        "key8a0b6e3c",
                        new IssueModelLabelStats.Types.IssueStats()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CalculateStats(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateStatsResponse response = client.CalculateStats(request.Location);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateStatsAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateStatsRequest request = new CalculateStatsRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            CalculateStatsResponse expectedResponse = new CalculateStatsResponse
            {
                AverageDuration = new wkt::Duration(),
                AverageTurnCount = 239030703,
                ConversationCount = 1758685422,
                SmartHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                CustomHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
#pragma warning disable CS0612
                IssueMatches =
#pragma warning restore CS0612
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                ConversationCountTimeSeries = new CalculateStatsResponse.Types.TimeSeries(),
                IssueMatchesStats =
                {
                    {
                        "key8a0b6e3c",
                        new IssueModelLabelStats.Types.IssueStats()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CalculateStatsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CalculateStatsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateStatsResponse responseCallSettings = await client.CalculateStatsAsync(request.Location, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CalculateStatsResponse responseCancellationToken = await client.CalculateStatsAsync(request.Location, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CalculateStatsResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateStatsRequest request = new CalculateStatsRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            CalculateStatsResponse expectedResponse = new CalculateStatsResponse
            {
                AverageDuration = new wkt::Duration(),
                AverageTurnCount = 239030703,
                ConversationCount = 1758685422,
                SmartHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                CustomHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
#pragma warning disable CS0612
                IssueMatches =
#pragma warning restore CS0612
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                ConversationCountTimeSeries = new CalculateStatsResponse.Types.TimeSeries(),
                IssueMatchesStats =
                {
                    {
                        "key8a0b6e3c",
                        new IssueModelLabelStats.Types.IssueStats()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CalculateStats(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateStatsResponse response = client.CalculateStats(request.LocationAsLocationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CalculateStatsResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CalculateStatsRequest request = new CalculateStatsRequest
            {
                LocationAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            CalculateStatsResponse expectedResponse = new CalculateStatsResponse
            {
                AverageDuration = new wkt::Duration(),
                AverageTurnCount = 239030703,
                ConversationCount = 1758685422,
                SmartHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                CustomHighlighterMatches =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
#pragma warning disable CS0612
                IssueMatches =
#pragma warning restore CS0612
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                ConversationCountTimeSeries = new CalculateStatsResponse.Types.TimeSeries(),
                IssueMatchesStats =
                {
                    {
                        "key8a0b6e3c",
                        new IssueModelLabelStats.Types.IssueStats()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CalculateStatsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CalculateStatsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            CalculateStatsResponse responseCallSettings = await client.CalculateStatsAsync(request.LocationAsLocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CalculateStatsResponse responseCancellationToken = await client.CalculateStatsAsync(request.LocationAsLocationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettingsRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings response = client.GetSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingsRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.GetSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettings()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings response = client.GetSettings(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingsAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.GetSettingsAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.GetSettingsAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSettingsResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings response = client.GetSettings(request.SettingsName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSettingsResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.GetSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.GetSettingsAsync(request.SettingsName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.GetSettingsAsync(request.SettingsName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSettingsRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings response = client.UpdateSettings(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSettingsRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.UpdateSettingsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSettings()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings response = client.UpdateSettings(request.Settings, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSettingsAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new wkt::FieldMask(),
            };
            Settings expectedResponse = new Settings
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                LanguageCode = "language_code2f6c7160",
                ConversationTtl = new wkt::Duration(),
                PubsubNotificationSettings =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                AnalysisConfig = new Settings.Types.AnalysisConfig(),
            };
            mockGrpcClient.Setup(x => x.UpdateSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Settings>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            Settings responseCallSettings = await client.UpdateSettingsAsync(request.Settings, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Settings responseCancellationToken = await client.UpdateSettingsAsync(request.Settings, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateViewRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateViewRequest request = new CreateViewRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                View = new View(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.CreateView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View response = client.CreateView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateViewRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateViewRequest request = new CreateViewRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                View = new View(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.CreateViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<View>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View responseCallSettings = await client.CreateViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            View responseCancellationToken = await client.CreateViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateView()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateViewRequest request = new CreateViewRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                View = new View(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.CreateView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View response = client.CreateView(request.Parent, request.View);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateViewAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateViewRequest request = new CreateViewRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                View = new View(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.CreateViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<View>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View responseCallSettings = await client.CreateViewAsync(request.Parent, request.View, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            View responseCancellationToken = await client.CreateViewAsync(request.Parent, request.View, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateViewResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateViewRequest request = new CreateViewRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                View = new View(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.CreateView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View response = client.CreateView(request.ParentAsLocationName, request.View);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateViewResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateViewRequest request = new CreateViewRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                View = new View(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.CreateViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<View>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View responseCallSettings = await client.CreateViewAsync(request.ParentAsLocationName, request.View, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            View responseCancellationToken = await client.CreateViewAsync(request.ParentAsLocationName, request.View, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetViewRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.GetView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View response = client.GetView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetViewRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.GetViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<View>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View responseCallSettings = await client.GetViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            View responseCancellationToken = await client.GetViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetView()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.GetView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View response = client.GetView(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetViewAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.GetViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<View>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View responseCallSettings = await client.GetViewAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            View responseCancellationToken = await client.GetViewAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetViewResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.GetView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View response = client.GetView(request.ViewName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetViewResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.GetViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<View>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View responseCallSettings = await client.GetViewAsync(request.ViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            View responseCancellationToken = await client.GetViewAsync(request.ViewName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateViewRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateViewRequest request = new UpdateViewRequest
            {
                View = new View(),
                UpdateMask = new wkt::FieldMask(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.UpdateView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View response = client.UpdateView(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateViewRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateViewRequest request = new UpdateViewRequest
            {
                View = new View(),
                UpdateMask = new wkt::FieldMask(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.UpdateViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<View>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View responseCallSettings = await client.UpdateViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            View responseCancellationToken = await client.UpdateViewAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateView()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateViewRequest request = new UpdateViewRequest
            {
                View = new View(),
                UpdateMask = new wkt::FieldMask(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.UpdateView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View response = client.UpdateView(request.View, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateViewAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateViewRequest request = new UpdateViewRequest
            {
                View = new View(),
                UpdateMask = new wkt::FieldMask(),
            };
            View expectedResponse = new View
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
                DisplayName = "display_name137f65c2",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Value = "value60c16320",
            };
            mockGrpcClient.Setup(x => x.UpdateViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<View>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            View responseCallSettings = await client.UpdateViewAsync(request.View, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            View responseCancellationToken = await client.UpdateViewAsync(request.View, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteViewRequestObject()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteViewRequest request = new DeleteViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeleteView(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteViewRequestObjectAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteViewRequest request = new DeleteViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteViewAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteView()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteViewRequest request = new DeleteViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeleteView(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteViewAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteViewRequest request = new DeleteViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteViewAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteViewAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteViewResourceNames()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteViewRequest request = new DeleteViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            client.DeleteView(request.ViewName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteViewResourceNamesAsync()
        {
            moq::Mock<ContactCenterInsights.ContactCenterInsightsClient> mockGrpcClient = new moq::Mock<ContactCenterInsights.ContactCenterInsightsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteViewRequest request = new DeleteViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ContactCenterInsightsClient client = new ContactCenterInsightsClientImpl(mockGrpcClient.Object, null);
            await client.DeleteViewAsync(request.ViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteViewAsync(request.ViewName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
