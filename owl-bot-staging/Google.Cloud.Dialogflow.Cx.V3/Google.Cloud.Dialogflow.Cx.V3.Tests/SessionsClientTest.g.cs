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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.Cx.V3.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSessionsClientTest
    {
        [xunit::FactAttribute]
        public void DetectIntentRequestObject()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                OutputAudioConfig = new OutputAudioConfig(),
                ResponseType = DetectIntentResponse.Types.ResponseType.Partial,
                AllowCancellation = true,
            };
            mockGrpcClient.Setup(x => x.DetectIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            DetectIntentResponse response = client.DetectIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetectIntentRequestObjectAsync()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                OutputAudioConfig = new OutputAudioConfig(),
                ResponseType = DetectIntentResponse.Types.ResponseType.Partial,
                AllowCancellation = true,
            };
            mockGrpcClient.Setup(x => x.DetectIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DetectIntentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            DetectIntentResponse responseCallSettings = await client.DetectIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DetectIntentResponse responseCancellationToken = await client.DetectIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MatchIntentRequestObject()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            MatchIntentRequest request = new MatchIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
            };
            MatchIntentResponse expectedResponse = new MatchIntentResponse
            {
                Text = "textec51b21c",
                TriggerIntentAsIntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                Transcript = "transcript20c5b28b",
                Matches = { new Match(), },
                CurrentPage = new Page(),
                TriggerEvent = "trigger_eventff063b42",
            };
            mockGrpcClient.Setup(x => x.MatchIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            MatchIntentResponse response = client.MatchIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MatchIntentRequestObjectAsync()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            MatchIntentRequest request = new MatchIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectLocationAgentSession("[PROJECT]", "[LOCATION]", "[AGENT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
            };
            MatchIntentResponse expectedResponse = new MatchIntentResponse
            {
                Text = "textec51b21c",
                TriggerIntentAsIntentName = IntentName.FromProjectLocationAgentIntent("[PROJECT]", "[LOCATION]", "[AGENT]", "[INTENT]"),
                Transcript = "transcript20c5b28b",
                Matches = { new Match(), },
                CurrentPage = new Page(),
                TriggerEvent = "trigger_eventff063b42",
            };
            mockGrpcClient.Setup(x => x.MatchIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MatchIntentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            MatchIntentResponse responseCallSettings = await client.MatchIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MatchIntentResponse responseCancellationToken = await client.MatchIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void FulfillIntentRequestObject()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            FulfillIntentRequest request = new FulfillIntentRequest
            {
                MatchIntentRequest = new MatchIntentRequest(),
                Match = new Match(),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            FulfillIntentResponse expectedResponse = new FulfillIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            mockGrpcClient.Setup(x => x.FulfillIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            FulfillIntentResponse response = client.FulfillIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task FulfillIntentRequestObjectAsync()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            FulfillIntentRequest request = new FulfillIntentRequest
            {
                MatchIntentRequest = new MatchIntentRequest(),
                Match = new Match(),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            FulfillIntentResponse expectedResponse = new FulfillIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                OutputAudioConfig = new OutputAudioConfig(),
            };
            mockGrpcClient.Setup(x => x.FulfillIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<FulfillIntentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null);
            FulfillIntentResponse responseCallSettings = await client.FulfillIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            FulfillIntentResponse responseCancellationToken = await client.FulfillIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
