// Copyright 2019 Google LLC
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

namespace Google.Cloud.Speech.V1P1Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Speech.V1P1Beta1;
    using Google.LongRunning;
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
    public class GeneratedSpeechClientTest
    {
        [Fact]
        public void Recognize()
        {
            Mock<Speech.SpeechClient> mockGrpcClient = new Mock<Speech.SpeechClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            RecognizeRequest expectedRequest = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
                    SampleRateHertz = 44100,
                    LanguageCode = "en-US",
                },
                Audio = new RecognitionAudio
                {
                    Uri = "gs://bucket_name/file_name.flac",
                },
            };
            RecognizeResponse expectedResponse = new RecognizeResponse();
            mockGrpcClient.Setup(x => x.Recognize(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognitionConfig config = new RecognitionConfig
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
                SampleRateHertz = 44100,
                LanguageCode = "en-US",
            };
            RecognitionAudio audio = new RecognitionAudio
            {
                Uri = "gs://bucket_name/file_name.flac",
            };
            RecognizeResponse response = client.Recognize(config, audio);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RecognizeAsync()
        {
            Mock<Speech.SpeechClient> mockGrpcClient = new Mock<Speech.SpeechClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            RecognizeRequest expectedRequest = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
                    SampleRateHertz = 44100,
                    LanguageCode = "en-US",
                },
                Audio = new RecognitionAudio
                {
                    Uri = "gs://bucket_name/file_name.flac",
                },
            };
            RecognizeResponse expectedResponse = new RecognizeResponse();
            mockGrpcClient.Setup(x => x.RecognizeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RecognizeResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognitionConfig config = new RecognitionConfig
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
                SampleRateHertz = 44100,
                LanguageCode = "en-US",
            };
            RecognitionAudio audio = new RecognitionAudio
            {
                Uri = "gs://bucket_name/file_name.flac",
            };
            RecognizeResponse response = await client.RecognizeAsync(config, audio);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Recognize2()
        {
            Mock<Speech.SpeechClient> mockGrpcClient = new Mock<Speech.SpeechClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
                    SampleRateHertz = 44100,
                    LanguageCode = "en-US",
                },
                Audio = new RecognitionAudio
                {
                    Uri = "gs://bucket_name/file_name.flac",
                },
            };
            RecognizeResponse expectedResponse = new RecognizeResponse();
            mockGrpcClient.Setup(x => x.Recognize(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse response = client.Recognize(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RecognizeAsync2()
        {
            Mock<Speech.SpeechClient> mockGrpcClient = new Mock<Speech.SpeechClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig
                {
                    Encoding = RecognitionConfig.Types.AudioEncoding.Flac,
                    SampleRateHertz = 44100,
                    LanguageCode = "en-US",
                },
                Audio = new RecognitionAudio
                {
                    Uri = "gs://bucket_name/file_name.flac",
                },
            };
            RecognizeResponse expectedResponse = new RecognizeResponse();
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RecognizeResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse response = await client.RecognizeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
