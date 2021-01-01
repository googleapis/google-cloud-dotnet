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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DocumentAI.V1Beta2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDocumentUnderstandingServiceClientTest
    {
        [xunit::FactAttribute]
        public void ProcessDocumentRequestObject()
        {
            moq::Mock<DocumentUnderstandingService.DocumentUnderstandingServiceClient> mockGrpcClient = new moq::Mock<DocumentUnderstandingService.DocumentUnderstandingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessDocumentRequest request = new ProcessDocumentRequest
            {
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                DocumentType = "document_typeba9d5586",
                TableExtractionParams = new TableExtractionParams(),
                FormExtractionParams = new FormExtractionParams(),
                EntityExtractionParams = new EntityExtractionParams(),
                OcrParams = new OcrParams(),
                AutomlParams = new AutoMlParams(),
                Parent = "parent7858e4d0",
            };
            Document expectedResponse = new Document
            {
                Uri = "uri3db70593",
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                MimeType = "mime_type606a0ffc",
                Text = "textec51b21c",
                TextStyles =
                {
                    new Document.Types.Style(),
                },
                Pages =
                {
                    new Document.Types.Page(),
                },
                Entities =
                {
                    new Document.Types.Entity(),
                },
                EntityRelations =
                {
                    new Document.Types.EntityRelation(),
                },
                ShardInfo = new Document.Types.ShardInfo(),
                Error = new gr::Status(),
                Labels =
                {
                    new Document.Types.Label(),
                },
            };
            mockGrpcClient.Setup(x => x.ProcessDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentUnderstandingServiceClient client = new DocumentUnderstandingServiceClientImpl(mockGrpcClient.Object, null);
            Document response = client.ProcessDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ProcessDocumentRequestObjectAsync()
        {
            moq::Mock<DocumentUnderstandingService.DocumentUnderstandingServiceClient> mockGrpcClient = new moq::Mock<DocumentUnderstandingService.DocumentUnderstandingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessDocumentRequest request = new ProcessDocumentRequest
            {
                InputConfig = new InputConfig(),
                OutputConfig = new OutputConfig(),
                DocumentType = "document_typeba9d5586",
                TableExtractionParams = new TableExtractionParams(),
                FormExtractionParams = new FormExtractionParams(),
                EntityExtractionParams = new EntityExtractionParams(),
                OcrParams = new OcrParams(),
                AutomlParams = new AutoMlParams(),
                Parent = "parent7858e4d0",
            };
            Document expectedResponse = new Document
            {
                Uri = "uri3db70593",
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                MimeType = "mime_type606a0ffc",
                Text = "textec51b21c",
                TextStyles =
                {
                    new Document.Types.Style(),
                },
                Pages =
                {
                    new Document.Types.Page(),
                },
                Entities =
                {
                    new Document.Types.Entity(),
                },
                EntityRelations =
                {
                    new Document.Types.EntityRelation(),
                },
                ShardInfo = new Document.Types.ShardInfo(),
                Error = new gr::Status(),
                Labels =
                {
                    new Document.Types.Label(),
                },
            };
            mockGrpcClient.Setup(x => x.ProcessDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentUnderstandingServiceClient client = new DocumentUnderstandingServiceClientImpl(mockGrpcClient.Object, null);
            Document responseCallSettings = await client.ProcessDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.ProcessDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
