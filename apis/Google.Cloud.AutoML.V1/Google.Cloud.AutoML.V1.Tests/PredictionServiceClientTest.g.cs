// Copyright 2020 Google LLC
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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AutoML.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPredictionServiceClientTest
    {
        [xunit::FactAttribute]
        public void PredictRequestObject()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                Name = "name1c9368b0",
                Payload = new ExamplePayload(),
                Params =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Payload =
                {
                    new AnnotationPayload(),
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                PreprocessedInput = new ExamplePayload(),
            };
            mockGrpcClient.Setup(x => x.Predict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse response = client.Predict(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PredictRequestObjectAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                Name = "name1c9368b0",
                Payload = new ExamplePayload(),
                Params =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Payload =
                {
                    new AnnotationPayload(),
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                PreprocessedInput = new ExamplePayload(),
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse responseCallSettings = await client.PredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictResponse responseCancellationToken = await client.PredictAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
