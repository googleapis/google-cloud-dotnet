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

namespace Google.Cloud.Language.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedLanguageServiceClientTest
    {
        [Fact]
        public void AnalyzeSentimentTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient> { DefaultValue = DefaultValue.Mock };
            AnalyzeSentimentResponse expectedResponse = new AnalyzeSentimentResponse
            {
                Language = "language-1613589672",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.AnalyzeSentiment(It.IsAny<AnalyzeSentimentRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnalyzeSentimentResponse response = client.AnalyzeSentiment(document);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeEntitiesTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient> { DefaultValue = DefaultValue.Mock };
            AnalyzeEntitiesResponse expectedResponse = new AnalyzeEntitiesResponse
            {
                Language = "language-1613589672",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.AnalyzeEntities(It.IsAny<AnalyzeEntitiesRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeEntitiesResponse response = client.AnalyzeEntities(document, encodingType);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeEntitySentimentTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient> { DefaultValue = DefaultValue.Mock };
            AnalyzeEntitySentimentResponse expectedResponse = new AnalyzeEntitySentimentResponse
            {
                Language = "language-1613589672",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.AnalyzeEntitySentiment(It.IsAny<AnalyzeEntitySentimentRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeEntitySentimentResponse response = client.AnalyzeEntitySentiment(document, encodingType);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnalyzeSyntaxTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient> { DefaultValue = DefaultValue.Mock };
            AnalyzeSyntaxResponse expectedResponse = new AnalyzeSyntaxResponse
            {
                Language = "language-1613589672",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.AnalyzeSyntax(It.IsAny<AnalyzeSyntaxRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            EncodingType encodingType = EncodingType.None;
            AnalyzeSyntaxResponse response = client.AnalyzeSyntax(document, encodingType);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ClassifyTextTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient> { DefaultValue = DefaultValue.Mock };
            ClassifyTextResponse expectedResponse = new ClassifyTextResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ClassifyText(It.IsAny<ClassifyTextRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            ClassifyTextResponse response = client.ClassifyText(document);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AnnotateTextTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<LanguageService.LanguageServiceClient> mockGrpcClient = new Mock<LanguageService.LanguageServiceClient> { DefaultValue = DefaultValue.Mock };
            AnnotateTextResponse expectedResponse = new AnnotateTextResponse
            {
                Language = "language-1613589672",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.AnnotateText(It.IsAny<AnnotateTextRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            LanguageServiceClient client = new LanguageServiceClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            AnnotateTextRequest.Types.Features features = new AnnotateTextRequest.Types.Features();
            EncodingType encodingType = EncodingType.None;
            AnnotateTextResponse response = client.AnnotateText(document, features, encodingType);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
