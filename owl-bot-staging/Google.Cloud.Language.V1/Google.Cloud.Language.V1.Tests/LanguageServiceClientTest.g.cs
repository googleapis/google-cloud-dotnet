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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Language.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedLanguageServiceClientTest
    {
        [xunit::FactAttribute]
        public void AnalyzeSentimentRequestObject()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Sentences = { new Sentence(), },
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSentimentResponse response = client.AnalyzeSentiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeSentimentRequestObjectAsync()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Sentences = { new Sentence(), },
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeSentimentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSentimentResponse responseCallSettings = await client.AnalyzeSentimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeSentimentResponse responseCancellationToken = await client.AnalyzeSentimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeSentiment1()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Sentences = { new Sentence(), },
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSentimentResponse response = client.AnalyzeSentiment(request.Document, request.EncodingType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeSentiment1Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Sentences = { new Sentence(), },
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeSentimentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSentimentResponse responseCallSettings = await client.AnalyzeSentimentAsync(request.Document, request.EncodingType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeSentimentResponse responseCancellationToken = await client.AnalyzeSentimentAsync(request.Document, request.EncodingType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeSentiment2()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Sentences = { new Sentence(), },
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSentimentResponse response = client.AnalyzeSentiment(request.Document);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeSentiment2Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Sentences = { new Sentence(), },
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeSentimentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSentimentResponse responseCallSettings = await client.AnalyzeSentimentAsync(request.Document, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeSentimentResponse responseCancellationToken = await client.AnalyzeSentimentAsync(request.Document, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeEntitiesRequestObject()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntities(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitiesResponse response = client.AnalyzeEntities(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeEntitiesRequestObjectAsync()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitiesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeEntitiesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitiesResponse responseCallSettings = await client.AnalyzeEntitiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeEntitiesResponse responseCancellationToken = await client.AnalyzeEntitiesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeEntities1()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntities(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitiesResponse response = client.AnalyzeEntities(request.Document, request.EncodingType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeEntities1Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitiesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeEntitiesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitiesResponse responseCallSettings = await client.AnalyzeEntitiesAsync(request.Document, request.EncodingType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeEntitiesResponse responseCancellationToken = await client.AnalyzeEntitiesAsync(request.Document, request.EncodingType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeEntities2()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntities(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitiesResponse response = client.AnalyzeEntities(request.Document);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeEntities2Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitiesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeEntitiesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitiesResponse responseCallSettings = await client.AnalyzeEntitiesAsync(request.Document, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeEntitiesResponse responseCancellationToken = await client.AnalyzeEntitiesAsync(request.Document, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeEntitySentimentRequestObject()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitySentimentResponse response = client.AnalyzeEntitySentiment(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeEntitySentimentRequestObjectAsync()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeEntitySentimentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitySentimentResponse responseCallSettings = await client.AnalyzeEntitySentimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeEntitySentimentResponse responseCancellationToken = await client.AnalyzeEntitySentimentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeEntitySentiment1()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitySentimentResponse response = client.AnalyzeEntitySentiment(request.Document, request.EncodingType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeEntitySentiment1Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeEntitySentimentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitySentimentResponse responseCallSettings = await client.AnalyzeEntitySentimentAsync(request.Document, request.EncodingType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeEntitySentimentResponse responseCancellationToken = await client.AnalyzeEntitySentimentAsync(request.Document, request.EncodingType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeEntitySentiment2()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitySentimentResponse response = client.AnalyzeEntitySentiment(request.Document);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeEntitySentiment2Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Entities = { new Entity(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeEntitySentimentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitySentimentResponse responseCallSettings = await client.AnalyzeEntitySentimentAsync(request.Document, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeEntitySentimentResponse responseCancellationToken = await client.AnalyzeEntitySentimentAsync(request.Document, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeSyntaxRequestObject()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntax(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSyntaxResponse response = client.AnalyzeSyntax(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeSyntaxRequestObjectAsync()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntaxAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeSyntaxResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSyntaxResponse responseCallSettings = await client.AnalyzeSyntaxAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeSyntaxResponse responseCancellationToken = await client.AnalyzeSyntaxAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeSyntax1()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntax(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSyntaxResponse response = client.AnalyzeSyntax(request.Document, request.EncodingType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeSyntax1Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntaxAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeSyntaxResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSyntaxResponse responseCallSettings = await client.AnalyzeSyntaxAsync(request.Document, request.EncodingType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeSyntaxResponse responseCancellationToken = await client.AnalyzeSyntaxAsync(request.Document, request.EncodingType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeSyntax2()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntax(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSyntaxResponse response = client.AnalyzeSyntax(request.Document);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeSyntax2Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Language = "language7dae1285",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntaxAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeSyntaxResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSyntaxResponse responseCallSettings = await client.AnalyzeSyntaxAsync(request.Document, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeSyntaxResponse responseCancellationToken = await client.AnalyzeSyntaxAsync(request.Document, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ClassifyTextRequestObject()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            ClassifyTextResponse expectedResponse = new ClassifyTextResponse
            {
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.ClassifyText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            ClassifyTextResponse response = client.ClassifyText(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ClassifyTextRequestObjectAsync()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            ClassifyTextResponse expectedResponse = new ClassifyTextResponse
            {
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.ClassifyTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClassifyTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            ClassifyTextResponse responseCallSettings = await client.ClassifyTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClassifyTextResponse responseCancellationToken = await client.ClassifyTextAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ClassifyText()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            ClassifyTextResponse expectedResponse = new ClassifyTextResponse
            {
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.ClassifyText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            ClassifyTextResponse response = client.ClassifyText(request.Document);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ClassifyTextAsync()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            ClassifyTextResponse expectedResponse = new ClassifyTextResponse
            {
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.ClassifyTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ClassifyTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            ClassifyTextResponse responseCallSettings = await client.ClassifyTextAsync(request.Document, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ClassifyTextResponse responseCancellationToken = await client.ClassifyTextAsync(request.Document, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnnotateTextRequestObject()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
                EncodingType = EncodingType.None,
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Entities = { new Entity(), },
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.AnnotateText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateTextResponse response = client.AnnotateText(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnnotateTextRequestObjectAsync()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
                EncodingType = EncodingType.None,
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Entities = { new Entity(), },
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.AnnotateTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotateTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateTextResponse responseCallSettings = await client.AnnotateTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotateTextResponse responseCancellationToken = await client.AnnotateTextAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnnotateText1()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
                EncodingType = EncodingType.None,
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Entities = { new Entity(), },
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.AnnotateText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateTextResponse response = client.AnnotateText(request.Document, request.Features, request.EncodingType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnnotateText1Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
                EncodingType = EncodingType.None,
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Entities = { new Entity(), },
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.AnnotateTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotateTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateTextResponse responseCallSettings = await client.AnnotateTextAsync(request.Document, request.Features, request.EncodingType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotateTextResponse responseCancellationToken = await client.AnnotateTextAsync(request.Document, request.Features, request.EncodingType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnnotateText2()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Entities = { new Entity(), },
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.AnnotateText(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateTextResponse response = client.AnnotateText(request.Document, request.Features);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnnotateText2Async()
        {
            moq::Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new moq::Mock<LanguageService.LanguageServiceClient>(moq::MockBehavior.Strict);
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Sentences = { new Sentence(), },
                Tokens = { new Token(), },
                Entities = { new Entity(), },
                DocumentSentiment = new Sentiment(),
                Language = "language7dae1285",
                Categories =
                {
                    new ClassificationCategory(),
                },
            };
            mockGrpcClient.Setup(x => x.AnnotateTextAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnnotateTextResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateTextResponse responseCallSettings = await client.AnnotateTextAsync(request.Document, request.Features, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnnotateTextResponse responseCancellationToken = await client.AnnotateTextAsync(request.Document, request.Features, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
