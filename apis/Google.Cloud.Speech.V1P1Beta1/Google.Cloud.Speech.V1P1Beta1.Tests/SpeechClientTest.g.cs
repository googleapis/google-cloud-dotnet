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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Speech.V1P1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSpeechClientTest
    {
        [xunit::FactAttribute]
        public void RecognizeRequestObject()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Results =
                {
                    new SpeechRecognitionResult(),
                },
                TotalBilledTime = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.Recognize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse response = client.Recognize(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecognizeRequestObjectAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Results =
                {
                    new SpeechRecognitionResult(),
                },
                TotalBilledTime = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecognizeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse responseCallSettings = await client.RecognizeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecognizeResponse responseCancellationToken = await client.RecognizeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Recognize()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Results =
                {
                    new SpeechRecognitionResult(),
                },
                TotalBilledTime = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.Recognize(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse response = client.Recognize(request.Config, request.Audio);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RecognizeAsync()
        {
            moq::Mock<Speech.SpeechClient> mockGrpcClient = new moq::Mock<Speech.SpeechClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            RecognizeRequest request = new RecognizeRequest
            {
                Config = new RecognitionConfig(),
                Audio = new RecognitionAudio(),
            };
            RecognizeResponse expectedResponse = new RecognizeResponse
            {
                Results =
                {
                    new SpeechRecognitionResult(),
                },
                TotalBilledTime = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.RecognizeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RecognizeResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SpeechClient client = new SpeechClientImpl(mockGrpcClient.Object, null);
            RecognizeResponse responseCallSettings = await client.RecognizeAsync(request.Config, request.Audio, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RecognizeResponse responseCancellationToken = await client.RecognizeAsync(request.Config, request.Audio, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
