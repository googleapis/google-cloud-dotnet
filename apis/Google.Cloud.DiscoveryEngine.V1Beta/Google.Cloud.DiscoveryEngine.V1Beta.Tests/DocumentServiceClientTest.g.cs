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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DiscoveryEngine.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDocumentServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetDocumentRequestObject()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.GetDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.GetDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDocumentRequestObjectAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.GetDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.GetDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.GetDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDocument()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.GetDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.GetDocument(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDocumentAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.GetDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.GetDocumentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.GetDocumentAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDocumentResourceNames()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.GetDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.GetDocument(request.DocumentName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDocumentResourceNamesAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDocumentRequest request = new GetDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.GetDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.GetDocumentAsync(request.DocumentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.GetDocumentAsync(request.DocumentName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDocumentRequestObject()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Document = new Document(),
                DocumentId = "document_id10fcfae7",
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.CreateDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.CreateDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDocumentRequestObjectAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Document = new Document(),
                DocumentId = "document_id10fcfae7",
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.CreateDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.CreateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.CreateDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDocument()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Document = new Document(),
                DocumentId = "document_id10fcfae7",
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.CreateDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.CreateDocument(request.Parent, request.Document, request.DocumentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDocumentAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Document = new Document(),
                DocumentId = "document_id10fcfae7",
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.CreateDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.CreateDocumentAsync(request.Parent, request.Document, request.DocumentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.CreateDocumentAsync(request.Parent, request.Document, request.DocumentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDocumentResourceNames()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Document = new Document(),
                DocumentId = "document_id10fcfae7",
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.CreateDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.CreateDocument(request.ParentAsBranchName, request.Document, request.DocumentId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDocumentResourceNamesAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                ParentAsBranchName = BranchName.FromProjectLocationDataStoreBranch("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]"),
                Document = new Document(),
                DocumentId = "document_id10fcfae7",
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.CreateDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.CreateDocumentAsync(request.ParentAsBranchName, request.Document, request.DocumentId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.CreateDocumentAsync(request.ParentAsBranchName, request.Document, request.DocumentId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDocumentRequestObject()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                AllowMissing = true,
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.UpdateDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document response = client.UpdateDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDocumentRequestObjectAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                AllowMissing = true,
            };
            Document expectedResponse = new Document
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
                Id = "id74b70bb8",
                SchemaId = "schema_idb515cf80",
                StructData = new wkt::Struct(),
                JsonData = "json_datae887bbfe",
                ParentDocumentId = "parent_document_idc4e8ae0f",
            };
            mockGrpcClient.Setup(x => x.UpdateDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            Document responseCallSettings = await client.UpdateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.UpdateDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDocumentRequestObject()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDocument(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDocumentRequestObjectAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDocumentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDocument()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDocument(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDocumentAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDocumentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDocumentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDocumentResourceNames()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteDocument(request.DocumentName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDocumentResourceNamesAsync()
        {
            moq::Mock<DocumentService.DocumentServiceClient> mockGrpcClient = new moq::Mock<DocumentService.DocumentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                DocumentName = DocumentName.FromProjectLocationDataStoreBranchDocument("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[BRANCH]", "[DOCUMENT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentServiceClient client = new DocumentServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteDocumentAsync(request.DocumentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDocumentAsync(request.DocumentName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
