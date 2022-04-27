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

using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
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
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelDisplayName = "model_display_name8ef9ce34",
            };
            mockGrpcClient.Setup(x => x.Predict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
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
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelDisplayName = "model_display_name8ef9ce34",
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
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
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelDisplayName = "model_display_name8ef9ce34",
            };
            mockGrpcClient.Setup(x => x.Predict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
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
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelDisplayName = "model_display_name8ef9ce34",
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
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
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelDisplayName = "model_display_name8ef9ce34",
            };
            mockGrpcClient.Setup(x => x.Predict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
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
                ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelDisplayName = "model_display_name8ef9ce34",
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            PredictResponse responseCallSettings = await client.PredictAsync(request.EndpointAsEndpointName, request.Instances, request.Parameters, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictResponse responseCancellationToken = await client.PredictAsync(request.EndpointAsEndpointName, request.Instances, request.Parameters, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RawPredictRequestObject()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            RawPredictRequest request = new RawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new ga::HttpBody(),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.RawPredict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.RawPredict(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RawPredictRequestObjectAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            RawPredictRequest request = new RawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new ga::HttpBody(),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.RawPredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.RawPredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.RawPredictAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RawPredict()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            RawPredictRequest request = new RawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new ga::HttpBody(),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.RawPredict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.RawPredict(request.Endpoint, request.HttpBody);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RawPredictAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            RawPredictRequest request = new RawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new ga::HttpBody(),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.RawPredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.RawPredictAsync(request.Endpoint, request.HttpBody, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.RawPredictAsync(request.Endpoint, request.HttpBody, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RawPredictResourceNames()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            RawPredictRequest request = new RawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new ga::HttpBody(),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.RawPredict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.RawPredict(request.EndpointAsEndpointName, request.HttpBody);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RawPredictResourceNamesAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            RawPredictRequest request = new RawPredictRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                HttpBody = new ga::HttpBody(),
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.RawPredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.RawPredictAsync(request.EndpointAsEndpointName, request.HttpBody, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.RawPredictAsync(request.EndpointAsEndpointName, request.HttpBody, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExplainRequestObject()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Parameters = new wkt::Value(),
                ExplanationSpecOverride = new ExplanationSpecOverride(),
            };
            ExplainResponse expectedResponse = new ExplainResponse
            {
                Explanations = { new Explanation(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Predictions = { new wkt::Value(), },
            };
            mockGrpcClient.Setup(x => x.Explain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ExplainResponse response = client.Explain(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExplainRequestObjectAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Parameters = new wkt::Value(),
                ExplanationSpecOverride = new ExplanationSpecOverride(),
            };
            ExplainResponse expectedResponse = new ExplainResponse
            {
                Explanations = { new Explanation(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Predictions = { new wkt::Value(), },
            };
            mockGrpcClient.Setup(x => x.ExplainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExplainResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ExplainResponse responseCallSettings = await client.ExplainAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExplainResponse responseCancellationToken = await client.ExplainAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Explain()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Parameters = new wkt::Value(),
            };
            ExplainResponse expectedResponse = new ExplainResponse
            {
                Explanations = { new Explanation(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Predictions = { new wkt::Value(), },
            };
            mockGrpcClient.Setup(x => x.Explain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ExplainResponse response = client.Explain(request.Endpoint, request.Instances, request.Parameters, request.DeployedModelId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExplainAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Parameters = new wkt::Value(),
            };
            ExplainResponse expectedResponse = new ExplainResponse
            {
                Explanations = { new Explanation(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Predictions = { new wkt::Value(), },
            };
            mockGrpcClient.Setup(x => x.ExplainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExplainResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ExplainResponse responseCallSettings = await client.ExplainAsync(request.Endpoint, request.Instances, request.Parameters, request.DeployedModelId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExplainResponse responseCancellationToken = await client.ExplainAsync(request.Endpoint, request.Instances, request.Parameters, request.DeployedModelId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ExplainResourceNames()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Parameters = new wkt::Value(),
            };
            ExplainResponse expectedResponse = new ExplainResponse
            {
                Explanations = { new Explanation(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Predictions = { new wkt::Value(), },
            };
            mockGrpcClient.Setup(x => x.Explain(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ExplainResponse response = client.Explain(request.EndpointAsEndpointName, request.Instances, request.Parameters, request.DeployedModelId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ExplainResourceNamesAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances = { new wkt::Value(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Parameters = new wkt::Value(),
            };
            ExplainResponse expectedResponse = new ExplainResponse
            {
                Explanations = { new Explanation(), },
                DeployedModelId = "deployed_model_idf0bd41af",
                Predictions = { new wkt::Value(), },
            };
            mockGrpcClient.Setup(x => x.ExplainAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExplainResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null, null);
            ExplainResponse responseCallSettings = await client.ExplainAsync(request.EndpointAsEndpointName, request.Instances, request.Parameters, request.DeployedModelId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExplainResponse responseCancellationToken = await client.ExplainAsync(request.EndpointAsEndpointName, request.Instances, request.Parameters, request.DeployedModelId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
