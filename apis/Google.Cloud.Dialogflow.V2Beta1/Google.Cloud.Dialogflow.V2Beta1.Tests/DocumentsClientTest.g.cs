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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDocumentsClientTest
    {
        [xunit::FactAttribute]
        public void GetDocumentRequestObject()
        {
            moq::Mock<Documents.DocumentsClient> mockGrpcClient = new moq::Mock<Documents.DocumentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
                DisplayName = "display_name137f65c2",
                MimeType = "mime_type606a0ffc",
                KnowledgeTypes =
                {
                    Document.Types.KnowledgeType.AgentFacingSmartReply,
                },
                ContentUri = "content_uriaf560198",
#pragma warning disable CS0612
                Content = "contentb964039a",
#pragma warning restore CS0612
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawContent = proto::ByteString.CopyFromUtf8("raw_content4f67d498"),
                EnableAutoReload = true,
                LatestReloadStatus = new Document.Types.ReloadStatus(),
                State = Document.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentsClient client = new DocumentsClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.GetDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDocumentRequestObjectAsync()
        {
            moq::Mock<Documents.DocumentsClient> mockGrpcClient = new moq::Mock<Documents.DocumentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
                DisplayName = "display_name137f65c2",
                MimeType = "mime_type606a0ffc",
                KnowledgeTypes =
                {
                    Document.Types.KnowledgeType.AgentFacingSmartReply,
                },
                ContentUri = "content_uriaf560198",
#pragma warning disable CS0612
                Content = "contentb964039a",
#pragma warning restore CS0612
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawContent = proto::ByteString.CopyFromUtf8("raw_content4f67d498"),
                EnableAutoReload = true,
                LatestReloadStatus = new Document.Types.ReloadStatus(),
                State = Document.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentsClient client = new DocumentsClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.GetDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.GetDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDocument()
        {
            moq::Mock<Documents.DocumentsClient> mockGrpcClient = new moq::Mock<Documents.DocumentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
                DisplayName = "display_name137f65c2",
                MimeType = "mime_type606a0ffc",
                KnowledgeTypes =
                {
                    Document.Types.KnowledgeType.AgentFacingSmartReply,
                },
                ContentUri = "content_uriaf560198",
#pragma warning disable CS0612
                Content = "contentb964039a",
#pragma warning restore CS0612
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawContent = proto::ByteString.CopyFromUtf8("raw_content4f67d498"),
                EnableAutoReload = true,
                LatestReloadStatus = new Document.Types.ReloadStatus(),
                State = Document.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentsClient client = new DocumentsClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.GetDocument(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDocumentAsync()
        {
            moq::Mock<Documents.DocumentsClient> mockGrpcClient = new moq::Mock<Documents.DocumentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
                DisplayName = "display_name137f65c2",
                MimeType = "mime_type606a0ffc",
                KnowledgeTypes =
                {
                    Document.Types.KnowledgeType.AgentFacingSmartReply,
                },
                ContentUri = "content_uriaf560198",
#pragma warning disable CS0612
                Content = "contentb964039a",
#pragma warning restore CS0612
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawContent = proto::ByteString.CopyFromUtf8("raw_content4f67d498"),
                EnableAutoReload = true,
                LatestReloadStatus = new Document.Types.ReloadStatus(),
                State = Document.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentsClient client = new DocumentsClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.GetDocumentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.GetDocumentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDocumentResourceNames()
        {
            moq::Mock<Documents.DocumentsClient> mockGrpcClient = new moq::Mock<Documents.DocumentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
                DisplayName = "display_name137f65c2",
                MimeType = "mime_type606a0ffc",
                KnowledgeTypes =
                {
                    Document.Types.KnowledgeType.AgentFacingSmartReply,
                },
                ContentUri = "content_uriaf560198",
#pragma warning disable CS0612
                Content = "contentb964039a",
#pragma warning restore CS0612
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawContent = proto::ByteString.CopyFromUtf8("raw_content4f67d498"),
                EnableAutoReload = true,
                LatestReloadStatus = new Document.Types.ReloadStatus(),
                State = Document.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentsClient client = new DocumentsClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.GetDocument(request.DocumentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDocumentResourceNamesAsync()
        {
            moq::Mock<Documents.DocumentsClient> mockGrpcClient = new moq::Mock<Documents.DocumentsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectKnowledgeBaseDocument("[PROJECT]", "[KNOWLEDGE_BASE]", "[DOCUMENT]"),
                DisplayName = "display_name137f65c2",
                MimeType = "mime_type606a0ffc",
                KnowledgeTypes =
                {
                    Document.Types.KnowledgeType.AgentFacingSmartReply,
                },
                ContentUri = "content_uriaf560198",
#pragma warning disable CS0612
                Content = "contentb964039a",
#pragma warning restore CS0612
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                RawContent = proto::ByteString.CopyFromUtf8("raw_content4f67d498"),
                EnableAutoReload = true,
                LatestReloadStatus = new Document.Types.ReloadStatus(),
                State = Document.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentsClient client = new DocumentsClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.GetDocumentAsync(request.DocumentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.GetDocumentAsync(request.DocumentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
