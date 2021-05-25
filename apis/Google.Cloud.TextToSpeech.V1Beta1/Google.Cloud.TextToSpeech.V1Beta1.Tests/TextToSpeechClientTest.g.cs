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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.TextToSpeech.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTextToSpeechClientTest
    {
        [xunit::FactAttribute]
        public void ListVoicesRequestObject()
        {
            moq::Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new moq::Mock<TextToSpeech.TextToSpeechClient>(moq::MockBehavior.Strict);
            ListVoicesRequest request = new ListVoicesRequest
            {
                LanguageCode = "language_code2f6c7160",
            };
            ListVoicesResponse expectedResponse = new ListVoicesResponse
            {
                Voices = { new Voice(), },
            };
            mockGrpcClient.Setup(x => x.ListVoices(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            ListVoicesResponse response = client.ListVoices(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListVoicesRequestObjectAsync()
        {
            moq::Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new moq::Mock<TextToSpeech.TextToSpeechClient>(moq::MockBehavior.Strict);
            ListVoicesRequest request = new ListVoicesRequest
            {
                LanguageCode = "language_code2f6c7160",
            };
            ListVoicesResponse expectedResponse = new ListVoicesResponse
            {
                Voices = { new Voice(), },
            };
            mockGrpcClient.Setup(x => x.ListVoicesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListVoicesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            ListVoicesResponse responseCallSettings = await client.ListVoicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListVoicesResponse responseCancellationToken = await client.ListVoicesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListVoices()
        {
            moq::Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new moq::Mock<TextToSpeech.TextToSpeechClient>(moq::MockBehavior.Strict);
            ListVoicesRequest request = new ListVoicesRequest
            {
                LanguageCode = "language_code2f6c7160",
            };
            ListVoicesResponse expectedResponse = new ListVoicesResponse
            {
                Voices = { new Voice(), },
            };
            mockGrpcClient.Setup(x => x.ListVoices(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            ListVoicesResponse response = client.ListVoices(request.LanguageCode);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListVoicesAsync()
        {
            moq::Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new moq::Mock<TextToSpeech.TextToSpeechClient>(moq::MockBehavior.Strict);
            ListVoicesRequest request = new ListVoicesRequest
            {
                LanguageCode = "language_code2f6c7160",
            };
            ListVoicesResponse expectedResponse = new ListVoicesResponse
            {
                Voices = { new Voice(), },
            };
            mockGrpcClient.Setup(x => x.ListVoicesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListVoicesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            ListVoicesResponse responseCallSettings = await client.ListVoicesAsync(request.LanguageCode, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListVoicesResponse responseCancellationToken = await client.ListVoicesAsync(request.LanguageCode, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SynthesizeSpeechRequestObject()
        {
            moq::Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new moq::Mock<TextToSpeech.TextToSpeechClient>(moq::MockBehavior.Strict);
            SynthesizeSpeechRequest request = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
                EnableTimePointing =
                {
                    SynthesizeSpeechRequest.Types.TimepointType.Unspecified,
                },
            };
            SynthesizeSpeechResponse expectedResponse = new SynthesizeSpeechResponse
            {
                AudioContent = proto::ByteString.CopyFromUtf8("audio_content20992f23"),
                Timepoints = { new Timepoint(), },
                AudioConfig = new AudioConfig(),
            };
            mockGrpcClient.Setup(x => x.SynthesizeSpeech(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            SynthesizeSpeechResponse response = client.SynthesizeSpeech(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SynthesizeSpeechRequestObjectAsync()
        {
            moq::Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new moq::Mock<TextToSpeech.TextToSpeechClient>(moq::MockBehavior.Strict);
            SynthesizeSpeechRequest request = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
                EnableTimePointing =
                {
                    SynthesizeSpeechRequest.Types.TimepointType.Unspecified,
                },
            };
            SynthesizeSpeechResponse expectedResponse = new SynthesizeSpeechResponse
            {
                AudioContent = proto::ByteString.CopyFromUtf8("audio_content20992f23"),
                Timepoints = { new Timepoint(), },
                AudioConfig = new AudioConfig(),
            };
            mockGrpcClient.Setup(x => x.SynthesizeSpeechAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SynthesizeSpeechResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            SynthesizeSpeechResponse responseCallSettings = await client.SynthesizeSpeechAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SynthesizeSpeechResponse responseCancellationToken = await client.SynthesizeSpeechAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SynthesizeSpeech()
        {
            moq::Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new moq::Mock<TextToSpeech.TextToSpeechClient>(moq::MockBehavior.Strict);
            SynthesizeSpeechRequest request = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
            };
            SynthesizeSpeechResponse expectedResponse = new SynthesizeSpeechResponse
            {
                AudioContent = proto::ByteString.CopyFromUtf8("audio_content20992f23"),
                Timepoints = { new Timepoint(), },
                AudioConfig = new AudioConfig(),
            };
            mockGrpcClient.Setup(x => x.SynthesizeSpeech(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            SynthesizeSpeechResponse response = client.SynthesizeSpeech(request.Input, request.Voice, request.AudioConfig);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SynthesizeSpeechAsync()
        {
            moq::Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new moq::Mock<TextToSpeech.TextToSpeechClient>(moq::MockBehavior.Strict);
            SynthesizeSpeechRequest request = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
            };
            SynthesizeSpeechResponse expectedResponse = new SynthesizeSpeechResponse
            {
                AudioContent = proto::ByteString.CopyFromUtf8("audio_content20992f23"),
                Timepoints = { new Timepoint(), },
                AudioConfig = new AudioConfig(),
            };
            mockGrpcClient.Setup(x => x.SynthesizeSpeechAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SynthesizeSpeechResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            SynthesizeSpeechResponse responseCallSettings = await client.SynthesizeSpeechAsync(request.Input, request.Voice, request.AudioConfig, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SynthesizeSpeechResponse responseCancellationToken = await client.SynthesizeSpeechAsync(request.Input, request.Voice, request.AudioConfig, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
