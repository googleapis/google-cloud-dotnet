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

namespace Google.Cloud.Translate.V3.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Translate.V3;
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
    public class GeneratedTranslationServiceClientTest
    {
        [Fact]
        public void TranslateText()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents = { },
                TargetLanguageCode = "targetLanguageCode1323228230",
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse();
            mockGrpcClient.Setup(x => x.TranslateText(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse response = client.TranslateText(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TranslateTextAsync()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            TranslateTextRequest request = new TranslateTextRequest
            {
                Contents = { },
                TargetLanguageCode = "targetLanguageCode1323228230",
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            TranslateTextResponse expectedResponse = new TranslateTextResponse();
            mockGrpcClient.Setup(x => x.TranslateTextAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TranslateTextResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            TranslateTextResponse response = await client.TranslateTextAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DetectLanguage()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DetectLanguageRequest expectedRequest = new DetectLanguageRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Model = "model104069929",
                MimeType = "mimeType-196041627",
                Labels = { },
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse();
            mockGrpcClient.Setup(x => x.DetectLanguage(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string model = "model104069929";
            string mimeType = "mimeType-196041627";
            IDictionary<string, string> labels = new Dictionary<string, string>();
            DetectLanguageResponse response = client.DetectLanguage(formattedParent, model, mimeType, labels);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DetectLanguageAsync()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DetectLanguageRequest expectedRequest = new DetectLanguageRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                Model = "model104069929",
                MimeType = "mimeType-196041627",
                Labels = { },
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse();
            mockGrpcClient.Setup(x => x.DetectLanguageAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DetectLanguageResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string model = "model104069929";
            string mimeType = "mimeType-196041627";
            IDictionary<string, string> labels = new Dictionary<string, string>();
            DetectLanguageResponse response = await client.DetectLanguageAsync(formattedParent, model, mimeType, labels);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DetectLanguage2()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse();
            mockGrpcClient.Setup(x => x.DetectLanguage(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            DetectLanguageResponse response = client.DetectLanguage(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DetectLanguageAsync2()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DetectLanguageRequest request = new DetectLanguageRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            DetectLanguageResponse expectedResponse = new DetectLanguageResponse();
            mockGrpcClient.Setup(x => x.DetectLanguageAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DetectLanguageResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            DetectLanguageResponse response = await client.DetectLanguageAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSupportedLanguages()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest expectedRequest = new GetSupportedLanguagesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                DisplayLanguageCode = "displayLanguageCode30710199",
                Model = "model104069929",
            };
            SupportedLanguages expectedResponse = new SupportedLanguages();
            mockGrpcClient.Setup(x => x.GetSupportedLanguages(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string displayLanguageCode = "displayLanguageCode30710199";
            string model = "model104069929";
            SupportedLanguages response = client.GetSupportedLanguages(formattedParent, displayLanguageCode, model);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSupportedLanguagesAsync()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest expectedRequest = new GetSupportedLanguagesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                DisplayLanguageCode = "displayLanguageCode30710199",
                Model = "model104069929",
            };
            SupportedLanguages expectedResponse = new SupportedLanguages();
            mockGrpcClient.Setup(x => x.GetSupportedLanguagesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SupportedLanguages>(Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string displayLanguageCode = "displayLanguageCode30710199";
            string model = "model104069929";
            SupportedLanguages response = await client.GetSupportedLanguagesAsync(formattedParent, displayLanguageCode, model);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSupportedLanguages2()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            SupportedLanguages expectedResponse = new SupportedLanguages();
            mockGrpcClient.Setup(x => x.GetSupportedLanguages(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            SupportedLanguages response = client.GetSupportedLanguages(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSupportedLanguagesAsync2()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSupportedLanguagesRequest request = new GetSupportedLanguagesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            SupportedLanguages expectedResponse = new SupportedLanguages();
            mockGrpcClient.Setup(x => x.GetSupportedLanguagesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SupportedLanguages>(Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            SupportedLanguages response = await client.GetSupportedLanguagesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetGlossary()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetGlossaryRequest expectedRequest = new GetGlossaryRequest
            {
                Name = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString(),
            };
            Glossary expectedResponse = new Glossary
            {
                Name = "name2-1052831874",
                EntryCount = 811131134,
            };
            mockGrpcClient.Setup(x => x.GetGlossary(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString();
            Glossary response = client.GetGlossary(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetGlossaryAsync()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetGlossaryRequest expectedRequest = new GetGlossaryRequest
            {
                Name = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString(),
            };
            Glossary expectedResponse = new Glossary
            {
                Name = "name2-1052831874",
                EntryCount = 811131134,
            };
            mockGrpcClient.Setup(x => x.GetGlossaryAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Glossary>(Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString();
            Glossary response = await client.GetGlossaryAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetGlossary2()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                Name = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString(),
            };
            Glossary expectedResponse = new Glossary
            {
                Name = "name2-1052831874",
                EntryCount = 811131134,
            };
            mockGrpcClient.Setup(x => x.GetGlossary(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            Glossary response = client.GetGlossary(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetGlossaryAsync2()
        {
            Mock<TranslationService.TranslationServiceClient> mockGrpcClient = new Mock<TranslationService.TranslationServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetGlossaryRequest request = new GetGlossaryRequest
            {
                Name = new GlossaryName("[PROJECT]", "[LOCATION]", "[GLOSSARY]").ToString(),
            };
            Glossary expectedResponse = new Glossary
            {
                Name = "name2-1052831874",
                EntryCount = 811131134,
            };
            mockGrpcClient.Setup(x => x.GetGlossaryAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Glossary>(Task.FromResult(expectedResponse), null, null, null, null));
            TranslationServiceClient client = new TranslationServiceClientImpl(mockGrpcClient.Object, null);
            Glossary response = await client.GetGlossaryAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
