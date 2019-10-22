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

namespace Google.Cloud.AutoML.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.AutoML.V1;
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
    public class GeneratedPredictionServiceClientTest
    {
        [Fact]
        public void Predict()
        {
            Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new Mock<PredictionService.PredictionServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            PredictRequest expectedRequest = new PredictRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload(),
                Params = { },
            };
            PredictResponse expectedResponse = new PredictResponse();
            mockGrpcClient.Setup(x => x.Predict(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            ExamplePayload payload = new ExamplePayload();
            IDictionary<string, string> @params = new Dictionary<string, string>();
            PredictResponse response = client.Predict(name, payload, @params);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PredictAsync()
        {
            Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new Mock<PredictionService.PredictionServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            PredictRequest expectedRequest = new PredictRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload(),
                Params = { },
            };
            PredictResponse expectedResponse = new PredictResponse();
            mockGrpcClient.Setup(x => x.PredictAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PredictResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            ModelName name = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]");
            ExamplePayload payload = new ExamplePayload();
            IDictionary<string, string> @params = new Dictionary<string, string>();
            PredictResponse response = await client.PredictAsync(name, payload, @params);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Predict2()
        {
            Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new Mock<PredictionService.PredictionServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload(),
            };
            PredictResponse expectedResponse = new PredictResponse();
            mockGrpcClient.Setup(x => x.Predict(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse response = client.Predict(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PredictAsync2()
        {
            Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new Mock<PredictionService.PredictionServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                ModelName = new ModelName("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload(),
            };
            PredictResponse expectedResponse = new PredictResponse();
            mockGrpcClient.Setup(x => x.PredictAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PredictResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse response = await client.PredictAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
