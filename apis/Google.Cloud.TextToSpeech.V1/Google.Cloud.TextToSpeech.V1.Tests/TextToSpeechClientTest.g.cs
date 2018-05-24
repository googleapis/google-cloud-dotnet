// Copyright 2018 Google LLC
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

namespace Google.Cloud.TextToSpeech.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.TextToSpeech.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedTextToSpeechClientTest
    {
        [Fact]
        public void ListVoices()
        {
            Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new Mock<TextToSpeech.TextToSpeechClient>(MockBehavior.Strict);
            ListVoicesRequest expectedRequest = new ListVoicesRequest
            {
                LanguageCode = "languageCode-412800396",
            };
            ListVoicesResponse expectedResponse = new ListVoicesResponse();
            mockGrpcClient.Setup(x => x.ListVoices(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            string languageCode = "languageCode-412800396";
            ListVoicesResponse response = client.ListVoices(languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListVoicesAsync()
        {
            Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new Mock<TextToSpeech.TextToSpeechClient>(MockBehavior.Strict);
            ListVoicesRequest expectedRequest = new ListVoicesRequest
            {
                LanguageCode = "languageCode-412800396",
            };
            ListVoicesResponse expectedResponse = new ListVoicesResponse();
            mockGrpcClient.Setup(x => x.ListVoicesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListVoicesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            string languageCode = "languageCode-412800396";
            ListVoicesResponse response = await client.ListVoicesAsync(languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListVoices2()
        {
            Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new Mock<TextToSpeech.TextToSpeechClient>(MockBehavior.Strict);
            ListVoicesRequest request = new ListVoicesRequest();
            ListVoicesResponse expectedResponse = new ListVoicesResponse();
            mockGrpcClient.Setup(x => x.ListVoices(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            ListVoicesResponse response = client.ListVoices(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListVoicesAsync2()
        {
            Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new Mock<TextToSpeech.TextToSpeechClient>(MockBehavior.Strict);
            ListVoicesRequest request = new ListVoicesRequest();
            ListVoicesResponse expectedResponse = new ListVoicesResponse();
            mockGrpcClient.Setup(x => x.ListVoicesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListVoicesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            ListVoicesResponse response = await client.ListVoicesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SynthesizeSpeech()
        {
            Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new Mock<TextToSpeech.TextToSpeechClient>(MockBehavior.Strict);
            SynthesizeSpeechRequest expectedRequest = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
            };
            SynthesizeSpeechResponse expectedResponse = new SynthesizeSpeechResponse
            {
                AudioContent = ByteString.CopyFromUtf8("16"),
            };
            mockGrpcClient.Setup(x => x.SynthesizeSpeech(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            SynthesisInput input = new SynthesisInput();
            VoiceSelectionParams voice = new VoiceSelectionParams();
            AudioConfig audioConfig = new AudioConfig();
            SynthesizeSpeechResponse response = client.SynthesizeSpeech(input, voice, audioConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SynthesizeSpeechAsync()
        {
            Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new Mock<TextToSpeech.TextToSpeechClient>(MockBehavior.Strict);
            SynthesizeSpeechRequest expectedRequest = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
            };
            SynthesizeSpeechResponse expectedResponse = new SynthesizeSpeechResponse
            {
                AudioContent = ByteString.CopyFromUtf8("16"),
            };
            mockGrpcClient.Setup(x => x.SynthesizeSpeechAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SynthesizeSpeechResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            SynthesisInput input = new SynthesisInput();
            VoiceSelectionParams voice = new VoiceSelectionParams();
            AudioConfig audioConfig = new AudioConfig();
            SynthesizeSpeechResponse response = await client.SynthesizeSpeechAsync(input, voice, audioConfig);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SynthesizeSpeech2()
        {
            Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new Mock<TextToSpeech.TextToSpeechClient>(MockBehavior.Strict);
            SynthesizeSpeechRequest request = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
            };
            SynthesizeSpeechResponse expectedResponse = new SynthesizeSpeechResponse
            {
                AudioContent = ByteString.CopyFromUtf8("16"),
            };
            mockGrpcClient.Setup(x => x.SynthesizeSpeech(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            SynthesizeSpeechResponse response = client.SynthesizeSpeech(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SynthesizeSpeechAsync2()
        {
            Mock<TextToSpeech.TextToSpeechClient> mockGrpcClient = new Mock<TextToSpeech.TextToSpeechClient>(MockBehavior.Strict);
            SynthesizeSpeechRequest request = new SynthesizeSpeechRequest
            {
                Input = new SynthesisInput(),
                Voice = new VoiceSelectionParams(),
                AudioConfig = new AudioConfig(),
            };
            SynthesizeSpeechResponse expectedResponse = new SynthesizeSpeechResponse
            {
                AudioContent = ByteString.CopyFromUtf8("16"),
            };
            mockGrpcClient.Setup(x => x.SynthesizeSpeechAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SynthesizeSpeechResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            TextToSpeechClient client = new TextToSpeechClientImpl(mockGrpcClient.Object, null);
            SynthesizeSpeechResponse response = await client.SynthesizeSpeechAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
