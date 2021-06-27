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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPredictionServiceClientTest
    {
        [xunit::FactAttribute]
        public void PredictRequestObject()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            PredictRequest request = new PredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Parameters = new wkt::Value(),
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Predictions = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
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
            PredictRequest request = new PredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Parameters = new wkt::Value(),
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Predictions = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse responseCallSettings = await client.PredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictResponse responseCancellationToken = await client.PredictAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Predict()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            PredictRequest request = new PredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Parameters = new wkt::Value(),
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Predictions = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
            };
            mockGrpcClient.Setup(x => x.Predict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse response = client.Predict(request.Endpoint, request.Instances, request.Parameters);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PredictAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            PredictRequest request = new PredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Parameters = new wkt::Value(),
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Predictions = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse responseCallSettings = await client.PredictAsync(request.Endpoint, request.Instances, request.Parameters, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictResponse responseCancellationToken = await client.PredictAsync(request.Endpoint, request.Instances, request.Parameters, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PredictResourceNames()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            PredictRequest request = new PredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Parameters = new wkt::Value(),
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Predictions = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
            };
            mockGrpcClient.Setup(x => x.Predict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse response = client.Predict(request.EndpointAsEndpointName, request.Instances, request.Parameters);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PredictResourceNamesAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            PredictRequest request = new PredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                Parameters = new wkt::Value(),
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Predictions = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse responseCallSettings = await client.PredictAsync(request.EndpointAsEndpointName, request.Instances, request.Parameters, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictResponse responseCancellationToken = await client.PredictAsync(request.EndpointAsEndpointName, request.Instances, request.Parameters, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
