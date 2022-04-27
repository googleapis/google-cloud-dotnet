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

namespace Google.Cloud.Dialogflow.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedParticipantsClientTest
    {
        [xunit::FactAttribute]
        public void CreateParticipantRequestObject()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            CreateParticipantRequest request = new CreateParticipantRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Participant = new Participant(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateParticipant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant response = client.CreateParticipant(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateParticipantRequestObjectAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            CreateParticipantRequest request = new CreateParticipantRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Participant = new Participant(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateParticipantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Participant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant responseCallSettings = await client.CreateParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Participant responseCancellationToken = await client.CreateParticipantAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateParticipant()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            CreateParticipantRequest request = new CreateParticipantRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Participant = new Participant(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateParticipant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant response = client.CreateParticipant(request.Parent, request.Participant);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateParticipantAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            CreateParticipantRequest request = new CreateParticipantRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Participant = new Participant(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateParticipantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Participant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant responseCallSettings = await client.CreateParticipantAsync(request.Parent, request.Participant, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Participant responseCancellationToken = await client.CreateParticipantAsync(request.Parent, request.Participant, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateParticipantResourceNames()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            CreateParticipantRequest request = new CreateParticipantRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Participant = new Participant(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateParticipant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant response = client.CreateParticipant(request.ParentAsConversationName, request.Participant);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateParticipantResourceNamesAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            CreateParticipantRequest request = new CreateParticipantRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Participant = new Participant(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateParticipantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Participant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant responseCallSettings = await client.CreateParticipantAsync(request.ParentAsConversationName, request.Participant, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Participant responseCancellationToken = await client.CreateParticipantAsync(request.ParentAsConversationName, request.Participant, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetParticipantRequestObject()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetParticipant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant response = client.GetParticipant(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetParticipantRequestObjectAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetParticipantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Participant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant responseCallSettings = await client.GetParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Participant responseCancellationToken = await client.GetParticipantAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetParticipant()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetParticipant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant response = client.GetParticipant(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetParticipantAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetParticipantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Participant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant responseCallSettings = await client.GetParticipantAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Participant responseCancellationToken = await client.GetParticipantAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetParticipantResourceNames()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetParticipant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant response = client.GetParticipant(request.ParticipantName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetParticipantResourceNamesAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetParticipantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Participant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant responseCallSettings = await client.GetParticipantAsync(request.ParticipantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Participant responseCancellationToken = await client.GetParticipantAsync(request.ParticipantName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateParticipantRequestObject()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            UpdateParticipantRequest request = new UpdateParticipantRequest
            {
                Participant = new Participant(),
                UpdateMask = new wkt::FieldMask(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateParticipant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant response = client.UpdateParticipant(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateParticipantRequestObjectAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            UpdateParticipantRequest request = new UpdateParticipantRequest
            {
                Participant = new Participant(),
                UpdateMask = new wkt::FieldMask(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateParticipantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Participant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant responseCallSettings = await client.UpdateParticipantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Participant responseCancellationToken = await client.UpdateParticipantAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateParticipant()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            UpdateParticipantRequest request = new UpdateParticipantRequest
            {
                Participant = new Participant(),
                UpdateMask = new wkt::FieldMask(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateParticipant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant response = client.UpdateParticipant(request.Participant, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateParticipantAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            UpdateParticipantRequest request = new UpdateParticipantRequest
            {
                Participant = new Participant(),
                UpdateMask = new wkt::FieldMask(),
            };
            Participant expectedResponse = new Participant
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                Role = Participant.Types.Role.HumanAgent,
                SipRecordingMediaLabel = "sip_recording_media_labela9ddfd5d",
                DocumentsMetadataFilters =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateParticipantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Participant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            Participant responseCallSettings = await client.UpdateParticipantAsync(request.Participant, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Participant responseCancellationToken = await client.UpdateParticipantAsync(request.Participant, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeContentRequestObject()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                ReplyAudioConfig = new OutputAudioConfig(),
                TextInput = new TextInput(),
                EventInput = new EventInput(),
                QueryParams = new QueryParameters(),
                RequestId = "request_id362c8df6",
                AssistQueryParams = new AssistQueryParameters(),
                CxParameters = new wkt::Struct(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse response = client.AnalyzeContent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeContentRequestObjectAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                ReplyAudioConfig = new OutputAudioConfig(),
                TextInput = new TextInput(),
                EventInput = new EventInput(),
                QueryParams = new QueryParameters(),
                RequestId = "request_id362c8df6",
                AssistQueryParams = new AssistQueryParameters(),
                CxParameters = new wkt::Struct(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeContentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse responseCallSettings = await client.AnalyzeContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeContentResponse responseCancellationToken = await client.AnalyzeContentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeContent1()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                TextInput = new TextInput(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse response = client.AnalyzeContent(request.Participant, request.TextInput);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeContent1Async()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                TextInput = new TextInput(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeContentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse responseCallSettings = await client.AnalyzeContentAsync(request.Participant, request.TextInput, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeContentResponse responseCancellationToken = await client.AnalyzeContentAsync(request.Participant, request.TextInput, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeContent1ResourceNames()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                TextInput = new TextInput(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse response = client.AnalyzeContent(request.ParticipantAsParticipantName, request.TextInput);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeContent1ResourceNamesAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                TextInput = new TextInput(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeContentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse responseCallSettings = await client.AnalyzeContentAsync(request.ParticipantAsParticipantName, request.TextInput, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeContentResponse responseCancellationToken = await client.AnalyzeContentAsync(request.ParticipantAsParticipantName, request.TextInput, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeContent2()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                EventInput = new EventInput(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse response = client.AnalyzeContent(request.Participant, request.EventInput);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeContent2Async()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                EventInput = new EventInput(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeContentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse responseCallSettings = await client.AnalyzeContentAsync(request.Participant, request.EventInput, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeContentResponse responseCancellationToken = await client.AnalyzeContentAsync(request.Participant, request.EventInput, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeContent2ResourceNames()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                EventInput = new EventInput(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse response = client.AnalyzeContent(request.ParticipantAsParticipantName, request.EventInput);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeContent2ResourceNamesAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                EventInput = new EventInput(),
            };
            AnalyzeContentResponse expectedResponse = new AnalyzeContentResponse
            {
                ReplyText = "reply_text33e99f0a",
                ReplyAudio = new OutputAudio(),
                AutomatedAgentReply = new AutomatedAgentReply(),
                Message = new Message(),
                HumanAgentSuggestionResults =
                {
                    new SuggestionResult(),
                },
                EndUserSuggestionResults =
                {
                    new SuggestionResult(),
                },
                DtmfParameters = new DtmfParameters(),
            };
            mockGrpcClient.Setup(x => x.AnalyzeContentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeContentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeContentResponse responseCallSettings = await client.AnalyzeContentAsync(request.ParticipantAsParticipantName, request.EventInput, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeContentResponse responseCancellationToken = await client.AnalyzeContentAsync(request.ParticipantAsParticipantName, request.EventInput, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestArticlesRequestObject()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestArticlesRequest request = new SuggestArticlesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
                AssistQueryParams = new AssistQueryParameters(),
            };
            SuggestArticlesResponse expectedResponse = new SuggestArticlesResponse
            {
                ArticleAnswers =
                {
                    new ArticleAnswer(),
                },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestArticles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestArticlesResponse response = client.SuggestArticles(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestArticlesRequestObjectAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestArticlesRequest request = new SuggestArticlesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
                AssistQueryParams = new AssistQueryParameters(),
            };
            SuggestArticlesResponse expectedResponse = new SuggestArticlesResponse
            {
                ArticleAnswers =
                {
                    new ArticleAnswer(),
                },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestArticlesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestArticlesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestArticlesResponse responseCallSettings = await client.SuggestArticlesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestArticlesResponse responseCancellationToken = await client.SuggestArticlesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestArticles()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestArticlesRequest request = new SuggestArticlesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestArticlesResponse expectedResponse = new SuggestArticlesResponse
            {
                ArticleAnswers =
                {
                    new ArticleAnswer(),
                },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestArticles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestArticlesResponse response = client.SuggestArticles(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestArticlesAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestArticlesRequest request = new SuggestArticlesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestArticlesResponse expectedResponse = new SuggestArticlesResponse
            {
                ArticleAnswers =
                {
                    new ArticleAnswer(),
                },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestArticlesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestArticlesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestArticlesResponse responseCallSettings = await client.SuggestArticlesAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestArticlesResponse responseCancellationToken = await client.SuggestArticlesAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestArticlesResourceNames()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestArticlesRequest request = new SuggestArticlesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestArticlesResponse expectedResponse = new SuggestArticlesResponse
            {
                ArticleAnswers =
                {
                    new ArticleAnswer(),
                },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestArticles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestArticlesResponse response = client.SuggestArticles(request.ParentAsParticipantName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestArticlesResourceNamesAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestArticlesRequest request = new SuggestArticlesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestArticlesResponse expectedResponse = new SuggestArticlesResponse
            {
                ArticleAnswers =
                {
                    new ArticleAnswer(),
                },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestArticlesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestArticlesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestArticlesResponse responseCallSettings = await client.SuggestArticlesAsync(request.ParentAsParticipantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestArticlesResponse responseCancellationToken = await client.SuggestArticlesAsync(request.ParentAsParticipantName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestFaqAnswersRequestObject()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestFaqAnswersRequest request = new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
                AssistQueryParams = new AssistQueryParameters(),
            };
            SuggestFaqAnswersResponse expectedResponse = new SuggestFaqAnswersResponse
            {
                FaqAnswers = { new FaqAnswer(), },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestFaqAnswers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestFaqAnswersResponse response = client.SuggestFaqAnswers(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestFaqAnswersRequestObjectAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestFaqAnswersRequest request = new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
                AssistQueryParams = new AssistQueryParameters(),
            };
            SuggestFaqAnswersResponse expectedResponse = new SuggestFaqAnswersResponse
            {
                FaqAnswers = { new FaqAnswer(), },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestFaqAnswersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestFaqAnswersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestFaqAnswersResponse responseCallSettings = await client.SuggestFaqAnswersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestFaqAnswersResponse responseCancellationToken = await client.SuggestFaqAnswersAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestFaqAnswers()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestFaqAnswersRequest request = new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestFaqAnswersResponse expectedResponse = new SuggestFaqAnswersResponse
            {
                FaqAnswers = { new FaqAnswer(), },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestFaqAnswers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestFaqAnswersResponse response = client.SuggestFaqAnswers(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestFaqAnswersAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestFaqAnswersRequest request = new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestFaqAnswersResponse expectedResponse = new SuggestFaqAnswersResponse
            {
                FaqAnswers = { new FaqAnswer(), },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestFaqAnswersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestFaqAnswersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestFaqAnswersResponse responseCallSettings = await client.SuggestFaqAnswersAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestFaqAnswersResponse responseCancellationToken = await client.SuggestFaqAnswersAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestFaqAnswersResourceNames()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestFaqAnswersRequest request = new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestFaqAnswersResponse expectedResponse = new SuggestFaqAnswersResponse
            {
                FaqAnswers = { new FaqAnswer(), },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestFaqAnswers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestFaqAnswersResponse response = client.SuggestFaqAnswers(request.ParentAsParticipantName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestFaqAnswersResourceNamesAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestFaqAnswersRequest request = new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestFaqAnswersResponse expectedResponse = new SuggestFaqAnswersResponse
            {
                FaqAnswers = { new FaqAnswer(), },
                LatestMessage = "latest_message4af0b23b",
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestFaqAnswersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestFaqAnswersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestFaqAnswersResponse responseCallSettings = await client.SuggestFaqAnswersAsync(request.ParentAsParticipantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestFaqAnswersResponse responseCancellationToken = await client.SuggestFaqAnswersAsync(request.ParentAsParticipantName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestSmartRepliesRequestObject()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestSmartRepliesRequest request = new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
                CurrentTextInput = new TextInput(),
            };
            SuggestSmartRepliesResponse expectedResponse = new SuggestSmartRepliesResponse
            {
                SmartReplyAnswers =
                {
                    new SmartReplyAnswer(),
                },
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestSmartReplies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestSmartRepliesResponse response = client.SuggestSmartReplies(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestSmartRepliesRequestObjectAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestSmartRepliesRequest request = new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
                CurrentTextInput = new TextInput(),
            };
            SuggestSmartRepliesResponse expectedResponse = new SuggestSmartRepliesResponse
            {
                SmartReplyAnswers =
                {
                    new SmartReplyAnswer(),
                },
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestSmartRepliesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestSmartRepliesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestSmartRepliesResponse responseCallSettings = await client.SuggestSmartRepliesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestSmartRepliesResponse responseCancellationToken = await client.SuggestSmartRepliesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestSmartReplies()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestSmartRepliesRequest request = new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestSmartRepliesResponse expectedResponse = new SuggestSmartRepliesResponse
            {
                SmartReplyAnswers =
                {
                    new SmartReplyAnswer(),
                },
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestSmartReplies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestSmartRepliesResponse response = client.SuggestSmartReplies(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestSmartRepliesAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestSmartRepliesRequest request = new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestSmartRepliesResponse expectedResponse = new SuggestSmartRepliesResponse
            {
                SmartReplyAnswers =
                {
                    new SmartReplyAnswer(),
                },
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestSmartRepliesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestSmartRepliesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestSmartRepliesResponse responseCallSettings = await client.SuggestSmartRepliesAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestSmartRepliesResponse responseCancellationToken = await client.SuggestSmartRepliesAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SuggestSmartRepliesResourceNames()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestSmartRepliesRequest request = new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestSmartRepliesResponse expectedResponse = new SuggestSmartRepliesResponse
            {
                SmartReplyAnswers =
                {
                    new SmartReplyAnswer(),
                },
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestSmartReplies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestSmartRepliesResponse response = client.SuggestSmartReplies(request.ParentAsParticipantName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SuggestSmartRepliesResourceNamesAsync()
        {
            moq::Mock<Participants.ParticipantsClient> mockGrpcClient = new moq::Mock<Participants.ParticipantsClient>(moq::MockBehavior.Strict);
            SuggestSmartRepliesRequest request = new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            SuggestSmartRepliesResponse expectedResponse = new SuggestSmartRepliesResponse
            {
                SmartReplyAnswers =
                {
                    new SmartReplyAnswer(),
                },
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 1799545581,
            };
            mockGrpcClient.Setup(x => x.SuggestSmartRepliesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestSmartRepliesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParticipantsClient client = new ParticipantsClientImpl(mockGrpcClient.Object, null, null);
            SuggestSmartRepliesResponse responseCallSettings = await client.SuggestSmartRepliesAsync(request.ParentAsParticipantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SuggestSmartRepliesResponse responseCancellationToken = await client.SuggestSmartRepliesAsync(request.ParentAsParticipantName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
