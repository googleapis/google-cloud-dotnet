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
using gcl = Google.Cloud.Location;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSessionsClientTest
    {
        [xunit::FactAttribute]
        public void DetectIntentRequestObject()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
                InputAudio = proto::ByteString.CopyFromUtf8("input_audio0acdfb28"),
                OutputAudioConfigMask = new wkt::FieldMask(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                WebhookStatus = new gr::Status(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                AlternativeQueryResults = { new QueryResult(), },
                OutputAudioConfig = new OutputAudioConfig(),
            };
            mockGrpcClient.Setup(x => x.DetectIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null, null);
            DetectIntentResponse response = client.DetectIntent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetectIntentRequestObjectAsync()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                QueryParams = new QueryParameters(),
                QueryInput = new QueryInput(),
                OutputAudioConfig = new OutputAudioConfig(),
                InputAudio = proto::ByteString.CopyFromUtf8("input_audio0acdfb28"),
                OutputAudioConfigMask = new wkt::FieldMask(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                WebhookStatus = new gr::Status(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                AlternativeQueryResults = { new QueryResult(), },
                OutputAudioConfig = new OutputAudioConfig(),
            };
            mockGrpcClient.Setup(x => x.DetectIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DetectIntentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null, null);
            DetectIntentResponse responseCallSettings = await client.DetectIntentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DetectIntentResponse responseCancellationToken = await client.DetectIntentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetectIntent()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                WebhookStatus = new gr::Status(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                AlternativeQueryResults = { new QueryResult(), },
                OutputAudioConfig = new OutputAudioConfig(),
            };
            mockGrpcClient.Setup(x => x.DetectIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null, null);
            DetectIntentResponse response = client.DetectIntent(request.Session, request.QueryInput);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetectIntentAsync()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                WebhookStatus = new gr::Status(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                AlternativeQueryResults = { new QueryResult(), },
                OutputAudioConfig = new OutputAudioConfig(),
            };
            mockGrpcClient.Setup(x => x.DetectIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DetectIntentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null, null);
            DetectIntentResponse responseCallSettings = await client.DetectIntentAsync(request.Session, request.QueryInput, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DetectIntentResponse responseCancellationToken = await client.DetectIntentAsync(request.Session, request.QueryInput, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DetectIntentResourceNames()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                WebhookStatus = new gr::Status(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                AlternativeQueryResults = { new QueryResult(), },
                OutputAudioConfig = new OutputAudioConfig(),
            };
            mockGrpcClient.Setup(x => x.DetectIntent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null, null);
            DetectIntentResponse response = client.DetectIntent(request.SessionAsSessionName, request.QueryInput);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DetectIntentResourceNamesAsync()
        {
            moq::Mock<Sessions.SessionsClient> mockGrpcClient = new moq::Mock<Sessions.SessionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DetectIntentRequest request = new DetectIntentRequest
            {
                SessionAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                QueryInput = new QueryInput(),
            };
            DetectIntentResponse expectedResponse = new DetectIntentResponse
            {
                ResponseId = "response_id17f822e1",
                QueryResult = new QueryResult(),
                WebhookStatus = new gr::Status(),
                OutputAudio = proto::ByteString.CopyFromUtf8("output_audio7e712c4b"),
                AlternativeQueryResults = { new QueryResult(), },
                OutputAudioConfig = new OutputAudioConfig(),
            };
            mockGrpcClient.Setup(x => x.DetectIntentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DetectIntentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SessionsClient client = new SessionsClientImpl(mockGrpcClient.Object, null, null);
            DetectIntentResponse responseCallSettings = await client.DetectIntentAsync(request.SessionAsSessionName, request.QueryInput, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DetectIntentResponse responseCancellationToken = await client.DetectIntentAsync(request.SessionAsSessionName, request.QueryInput, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
