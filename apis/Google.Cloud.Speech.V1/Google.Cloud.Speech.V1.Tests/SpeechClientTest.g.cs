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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
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

namespace Google.Cloud.Speech.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedSpeechClientTest
    {
        [Fact]
        public void RecognizeTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Speech.SpeechClient> mockGrpcClient = new Mock<Speech.SpeechClient> { DefaultValue = DefaultValue.Mock };
            RecognizeResponse expectedResponse = new RecognizeResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Recognize(It.IsAny<RecognizeRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
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
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
