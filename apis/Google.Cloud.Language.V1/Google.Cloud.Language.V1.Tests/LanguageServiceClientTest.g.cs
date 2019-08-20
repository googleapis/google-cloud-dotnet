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

namespace Google.Cloud.Language.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Language.V1;
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
    public class GeneratedLanguageServiceClientTest
    {
        [Fact]
        public void AnalyzeSentiment()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSentimentRequest expectedRequest = new AnalyzeSentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentiment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeSentimentResponse response = client.AnalyzeSentiment(document, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeSentimentAsync()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSentimentRequest expectedRequest = new AnalyzeSentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentimentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeSentimentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeSentimentResponse response = await client.AnalyzeSentimentAsync(document, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeSentiment2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSentimentRequest expectedRequest = new AnalyzeSentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentiment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnalyzeSentimentResponse response = client.AnalyzeSentiment(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeSentimentAsync2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSentimentRequest expectedRequest = new AnalyzeSentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentimentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeSentimentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnalyzeSentimentResponse response = await client.AnalyzeSentimentAsync(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeSentiment3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentiment(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSentimentResponse response = client.AnalyzeSentiment(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeSentimentAsync3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSentimentRequest request = new AnalyzeSentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSentimentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeSentimentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSentimentResponse response = await client.AnalyzeSentimentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeEntities()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitiesRequest expectedRequest = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntities(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeEntitiesResponse response = client.AnalyzeEntities(document, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeEntitiesAsync()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitiesRequest expectedRequest = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitiesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeEntitiesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeEntitiesResponse response = await client.AnalyzeEntitiesAsync(document, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeEntities2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitiesRequest expectedRequest = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntities(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnalyzeEntitiesResponse response = client.AnalyzeEntities(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeEntitiesAsync2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitiesRequest expectedRequest = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitiesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeEntitiesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnalyzeEntitiesResponse response = await client.AnalyzeEntitiesAsync(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeEntities3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntities(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitiesResponse response = client.AnalyzeEntities(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeEntitiesAsync3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitiesRequest request = new AnalyzeEntitiesRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitiesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeEntitiesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitiesResponse response = await client.AnalyzeEntitiesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeEntitySentiment()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitySentimentRequest expectedRequest = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentiment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeEntitySentimentResponse response = client.AnalyzeEntitySentiment(document, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeEntitySentimentAsync()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitySentimentRequest expectedRequest = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentimentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeEntitySentimentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeEntitySentimentResponse response = await client.AnalyzeEntitySentimentAsync(document, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeEntitySentiment2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitySentimentRequest expectedRequest = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentiment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnalyzeEntitySentimentResponse response = client.AnalyzeEntitySentiment(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeEntitySentimentAsync2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitySentimentRequest expectedRequest = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentimentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeEntitySentimentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnalyzeEntitySentimentResponse response = await client.AnalyzeEntitySentimentAsync(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeEntitySentiment3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentiment(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitySentimentResponse response = client.AnalyzeEntitySentiment(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeEntitySentimentAsync3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeEntitySentimentRequest request = new AnalyzeEntitySentimentRequest
            {
                Document = new Document(),
            };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentimentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeEntitySentimentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeEntitySentimentResponse response = await client.AnalyzeEntitySentimentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeSyntax()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSyntaxRequest expectedRequest = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntax(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeSyntaxResponse response = client.AnalyzeSyntax(document, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeSyntaxAsync()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSyntaxRequest expectedRequest = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
                EncodingType = EncodingType.None,
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntaxAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeSyntaxResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeSyntaxResponse response = await client.AnalyzeSyntaxAsync(document, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeSyntax2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSyntaxRequest expectedRequest = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntax(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnalyzeSyntaxResponse response = client.AnalyzeSyntax(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeSyntaxAsync2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSyntaxRequest expectedRequest = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntaxAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeSyntaxResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnalyzeSyntaxResponse response = await client.AnalyzeSyntaxAsync(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeSyntax3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntax(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSyntaxResponse response = client.AnalyzeSyntax(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnalyzeSyntaxAsync3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnalyzeSyntaxRequest request = new AnalyzeSyntaxRequest
            {
                Document = new Document(),
            };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnalyzeSyntaxAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnalyzeSyntaxResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnalyzeSyntaxResponse response = await client.AnalyzeSyntaxAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ClassifyText()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            ClassifyTextRequest expectedRequest = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            ClassifyTextResponse expectedResponse = new ClassifyTextResponse();
            mockGrpcClient.Setup(x => x.ClassifyText(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            ClassifyTextResponse response = client.ClassifyText(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ClassifyTextAsync()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            ClassifyTextRequest expectedRequest = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            ClassifyTextResponse expectedResponse = new ClassifyTextResponse();
            mockGrpcClient.Setup(x => x.ClassifyTextAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ClassifyTextResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            ClassifyTextResponse response = await client.ClassifyTextAsync(document);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ClassifyText2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            ClassifyTextResponse expectedResponse = new ClassifyTextResponse();
            mockGrpcClient.Setup(x => x.ClassifyText(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            ClassifyTextResponse response = client.ClassifyText(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ClassifyTextAsync2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            ClassifyTextRequest request = new ClassifyTextRequest
            {
                Document = new Document(),
            };
            ClassifyTextResponse expectedResponse = new ClassifyTextResponse();
            mockGrpcClient.Setup(x => x.ClassifyTextAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ClassifyTextResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            ClassifyTextResponse response = await client.ClassifyTextAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnnotateText()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnnotateTextRequest expectedRequest = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
                EncodingType = EncodingType.None,
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnnotateText(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            EncodingType encodingType = EncodingType.None;
            AnnotateTextResponse response = client.AnnotateText(document, features, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnnotateTextAsync()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnnotateTextRequest expectedRequest = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
                EncodingType = EncodingType.None,
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnnotateTextAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnnotateTextResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            EncodingType encodingType = EncodingType.None;
            AnnotateTextResponse response = await client.AnnotateTextAsync(document, features, encodingType);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnnotateText2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnnotateTextRequest expectedRequest = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnnotateText(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            AnnotateTextResponse response = client.AnnotateText(document, features);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnnotateTextAsync2()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnnotateTextRequest expectedRequest = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnnotateTextAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnnotateTextResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            AnnotateTextResponse response = await client.AnnotateTextAsync(document, features);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnnotateText3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnnotateText(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateTextResponse response = client.AnnotateText(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AnnotateTextAsync3()
        {
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient>(MockBehavior.Strict);
            AnnotateTextRequest request = new AnnotateTextRequest
            {
                Document = new Document(),
                Features = new AnnotateTextRequest.Types.Features(),
            };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Language = "language-1613589672",
            };
            mockGrpcClient.Setup(x => x.AnnotateTextAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AnnotateTextResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            AnnotateTextResponse response = await client.AnnotateTextAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
