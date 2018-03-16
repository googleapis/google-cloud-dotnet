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

namespace Google.Cloud.Dlp.V2Beta1.Tests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedDlpServiceClientTest
    {
        [Fact]
        public void InspectContent()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            InspectContentRequest expectedRequest = new InspectContentRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                Items = {
                            new ContentItem
                            {
                                Type = "text/plain",
                                Value = "My email is example@example.com.",
                            },
                        },
            };
            InspectContentResponse expectedResponse = new InspectContentResponse();
            mockGrpcClient.Setup(x => x.InspectContent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectConfig inspectConfig = new InspectConfig
            {
                InfoTypes = {
                                new InfoType
                                {
                                    Name = "EMAIL_ADDRESS",
                                },
                            },
            };
            IEnumerable<ContentItem> items = new[]
            {
                new ContentItem
                {
                    Type = "text/plain",
                    Value = "My email is example@example.com.",
                },
            };
            InspectContentResponse response = client.InspectContent(inspectConfig, items);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task InspectContentAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            InspectContentRequest expectedRequest = new InspectContentRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                Items = {
                            new ContentItem
                            {
                                Type = "text/plain",
                                Value = "My email is example@example.com.",
                            },
                        },
            };
            InspectContentResponse expectedResponse = new InspectContentResponse();
            mockGrpcClient.Setup(x => x.InspectContentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<InspectContentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectConfig inspectConfig = new InspectConfig
            {
                InfoTypes = {
                                new InfoType
                                {
                                    Name = "EMAIL_ADDRESS",
                                },
                            },
            };
            IEnumerable<ContentItem> items = new[]
            {
                new ContentItem
                {
                    Type = "text/plain",
                    Value = "My email is example@example.com.",
                },
            };
            InspectContentResponse response = await client.InspectContentAsync(inspectConfig, items);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void InspectContent2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            InspectContentRequest request = new InspectContentRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                Items = {
                            new ContentItem
                            {
                                Type = "text/plain",
                                Value = "My email is example@example.com.",
                            },
                        },
            };
            InspectContentResponse expectedResponse = new InspectContentResponse();
            mockGrpcClient.Setup(x => x.InspectContent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectContentResponse response = client.InspectContent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task InspectContentAsync2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            InspectContentRequest request = new InspectContentRequest
            {
                InspectConfig = new InspectConfig
                                {
                                    InfoTypes = {
                                                    new InfoType
                                                    {
                                                        Name = "EMAIL_ADDRESS",
                                                    },
                                                },
                                },
                Items = {
                            new ContentItem
                            {
                                Type = "text/plain",
                                Value = "My email is example@example.com.",
                            },
                        },
            };
            InspectContentResponse expectedResponse = new InspectContentResponse();
            mockGrpcClient.Setup(x => x.InspectContentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<InspectContentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            InspectContentResponse response = await client.InspectContentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeidentifyContent()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeidentifyContentRequest expectedRequest = new DeidentifyContentRequest
            {
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Items = { },
            };
            DeidentifyContentResponse expectedResponse = new DeidentifyContentResponse();
            mockGrpcClient.Setup(x => x.DeidentifyContent(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyConfig deidentifyConfig = new DeidentifyConfig();
            InspectConfig inspectConfig = new InspectConfig();
            IEnumerable<ContentItem> items = new List<ContentItem>();
            DeidentifyContentResponse response = client.DeidentifyContent(deidentifyConfig, inspectConfig, items);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeidentifyContentAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeidentifyContentRequest expectedRequest = new DeidentifyContentRequest
            {
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Items = { },
            };
            DeidentifyContentResponse expectedResponse = new DeidentifyContentResponse();
            mockGrpcClient.Setup(x => x.DeidentifyContentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DeidentifyContentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyConfig deidentifyConfig = new DeidentifyConfig();
            InspectConfig inspectConfig = new InspectConfig();
            IEnumerable<ContentItem> items = new List<ContentItem>();
            DeidentifyContentResponse response = await client.DeidentifyContentAsync(deidentifyConfig, inspectConfig, items);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeidentifyContent2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Items = { },
            };
            DeidentifyContentResponse expectedResponse = new DeidentifyContentResponse();
            mockGrpcClient.Setup(x => x.DeidentifyContent(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyContentResponse response = client.DeidentifyContent(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeidentifyContentAsync2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeidentifyContentRequest request = new DeidentifyContentRequest
            {
                DeidentifyConfig = new DeidentifyConfig(),
                InspectConfig = new InspectConfig(),
                Items = { },
            };
            DeidentifyContentResponse expectedResponse = new DeidentifyContentResponse();
            mockGrpcClient.Setup(x => x.DeidentifyContentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DeidentifyContentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            DeidentifyContentResponse response = await client.DeidentifyContentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInspectFindings()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInspectFindingsRequest expectedRequest = new ListInspectFindingsRequest
            {
                ResultName = new ResultName("[RESULT]"),
            };
            ListInspectFindingsResponse expectedResponse = new ListInspectFindingsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListInspectFindings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ResultName name = new ResultName("[RESULT]");
            ListInspectFindingsResponse response = client.ListInspectFindings(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListInspectFindingsAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInspectFindingsRequest expectedRequest = new ListInspectFindingsRequest
            {
                ResultName = new ResultName("[RESULT]"),
            };
            ListInspectFindingsResponse expectedResponse = new ListInspectFindingsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListInspectFindingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListInspectFindingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ResultName name = new ResultName("[RESULT]");
            ListInspectFindingsResponse response = await client.ListInspectFindingsAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInspectFindings2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInspectFindingsRequest request = new ListInspectFindingsRequest
            {
                ResultName = new ResultName("[RESULT]"),
            };
            ListInspectFindingsResponse expectedResponse = new ListInspectFindingsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListInspectFindings(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ListInspectFindingsResponse response = client.ListInspectFindings(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListInspectFindingsAsync2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInspectFindingsRequest request = new ListInspectFindingsRequest
            {
                ResultName = new ResultName("[RESULT]"),
            };
            ListInspectFindingsResponse expectedResponse = new ListInspectFindingsResponse
            {
                NextPageToken = "nextPageToken-1530815211",
            };
            mockGrpcClient.Setup(x => x.ListInspectFindingsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListInspectFindingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ListInspectFindingsResponse response = await client.ListInspectFindingsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInfoTypes()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInfoTypesRequest expectedRequest = new ListInfoTypesRequest
            {
                Category = "PII",
                LanguageCode = "en",
            };
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse();
            mockGrpcClient.Setup(x => x.ListInfoTypes(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            string category = "PII";
            string languageCode = "en";
            ListInfoTypesResponse response = client.ListInfoTypes(category, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListInfoTypesAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInfoTypesRequest expectedRequest = new ListInfoTypesRequest
            {
                Category = "PII",
                LanguageCode = "en",
            };
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse();
            mockGrpcClient.Setup(x => x.ListInfoTypesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListInfoTypesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            string category = "PII";
            string languageCode = "en";
            ListInfoTypesResponse response = await client.ListInfoTypesAsync(category, languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListInfoTypes2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                Category = "PII",
                LanguageCode = "en",
            };
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse();
            mockGrpcClient.Setup(x => x.ListInfoTypes(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ListInfoTypesResponse response = client.ListInfoTypes(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListInfoTypesAsync2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListInfoTypesRequest request = new ListInfoTypesRequest
            {
                Category = "PII",
                LanguageCode = "en",
            };
            ListInfoTypesResponse expectedResponse = new ListInfoTypesResponse();
            mockGrpcClient.Setup(x => x.ListInfoTypesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListInfoTypesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ListInfoTypesResponse response = await client.ListInfoTypesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListRootCategories()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListRootCategoriesRequest expectedRequest = new ListRootCategoriesRequest
            {
                LanguageCode = "en",
            };
            ListRootCategoriesResponse expectedResponse = new ListRootCategoriesResponse();
            mockGrpcClient.Setup(x => x.ListRootCategories(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            string languageCode = "en";
            ListRootCategoriesResponse response = client.ListRootCategories(languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListRootCategoriesAsync()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListRootCategoriesRequest expectedRequest = new ListRootCategoriesRequest
            {
                LanguageCode = "en",
            };
            ListRootCategoriesResponse expectedResponse = new ListRootCategoriesResponse();
            mockGrpcClient.Setup(x => x.ListRootCategoriesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListRootCategoriesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            string languageCode = "en";
            ListRootCategoriesResponse response = await client.ListRootCategoriesAsync(languageCode);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListRootCategories2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListRootCategoriesRequest request = new ListRootCategoriesRequest
            {
                LanguageCode = "en",
            };
            ListRootCategoriesResponse expectedResponse = new ListRootCategoriesResponse();
            mockGrpcClient.Setup(x => x.ListRootCategories(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ListRootCategoriesResponse response = client.ListRootCategories(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListRootCategoriesAsync2()
        {
            Mock<DlpService.DlpServiceClient> mockGrpcClient = new Mock<DlpService.DlpServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListRootCategoriesRequest request = new ListRootCategoriesRequest
            {
                LanguageCode = "en",
            };
            ListRootCategoriesResponse expectedResponse = new ListRootCategoriesResponse();
            mockGrpcClient.Setup(x => x.ListRootCategoriesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListRootCategoriesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DlpServiceClient client = new DlpServiceClientImpl(mockGrpcClient.Object, null);
            ListRootCategoriesResponse response = await client.ListRootCategoriesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
