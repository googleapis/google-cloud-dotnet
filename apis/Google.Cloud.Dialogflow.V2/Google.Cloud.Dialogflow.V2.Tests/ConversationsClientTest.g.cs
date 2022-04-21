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

namespace Google.Cloud.Dialogflow.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedConversationsClientTest
    {
        [xunit::FactAttribute]
        public void CreateConversationRequestObject()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
                ConversationId = "conversation_id32c22ad5",
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CreateConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.CreateConversation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationRequestObjectAsync()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
                ConversationId = "conversation_id32c22ad5",
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CreateConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.CreateConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CreateConversationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversation()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CreateConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.CreateConversation(request.Parent, request.Conversation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationAsync()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CreateConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.CreateConversationAsync(request.Parent, request.Conversation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CreateConversationAsync(request.Parent, request.Conversation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversationResourceNames1()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CreateConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.CreateConversation(request.ParentAsProjectName, request.Conversation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationResourceNames1Async()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CreateConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.CreateConversationAsync(request.ParentAsProjectName, request.Conversation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CreateConversationAsync(request.ParentAsProjectName, request.Conversation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateConversationResourceNames2()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CreateConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.CreateConversation(request.ParentAsLocationName, request.Conversation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateConversationResourceNames2Async()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CreateConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.CreateConversationAsync(request.ParentAsLocationName, request.Conversation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CreateConversationAsync(request.ParentAsLocationName, request.Conversation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationRequestObject()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.GetConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.GetConversation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationRequestObjectAsync()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.GetConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.GetConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.GetConversationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversation()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.GetConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.GetConversation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationAsync()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.GetConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.GetConversationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.GetConversationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConversationResourceNames()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.GetConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.GetConversation(request.ConversationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConversationResourceNamesAsync()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.GetConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.GetConversationAsync(request.ConversationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.GetConversationAsync(request.ConversationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CompleteConversationRequestObject()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CompleteConversationRequest request = new CompleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CompleteConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.CompleteConversation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompleteConversationRequestObjectAsync()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CompleteConversationRequest request = new CompleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CompleteConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.CompleteConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CompleteConversationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CompleteConversation()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CompleteConversationRequest request = new CompleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CompleteConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.CompleteConversation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompleteConversationAsync()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CompleteConversationRequest request = new CompleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CompleteConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.CompleteConversationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CompleteConversationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CompleteConversationResourceNames()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CompleteConversationRequest request = new CompleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CompleteConversation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation response = client.CompleteConversation(request.ConversationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompleteConversationResourceNamesAsync()
        {
            moq::Mock<Conversations.ConversationsClient> mockGrpcClient = new moq::Mock<Conversations.ConversationsClient>(moq::MockBehavior.Strict);
            CompleteConversationRequest request = new CompleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            Conversation expectedResponse = new Conversation
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LifecycleState = Conversation.Types.LifecycleState.Unspecified,
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                PhoneNumber = new ConversationPhoneNumber(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ConversationStage = Conversation.Types.ConversationStage.HumanAssistStage,
            };
            mockGrpcClient.Setup(x => x.CompleteConversationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Conversation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversationsClient client = new ConversationsClientImpl(mockGrpcClient.Object, null, null);
            Conversation responseCallSettings = await client.CompleteConversationAsync(request.ConversationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Conversation responseCancellationToken = await client.CompleteConversationAsync(request.ConversationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
