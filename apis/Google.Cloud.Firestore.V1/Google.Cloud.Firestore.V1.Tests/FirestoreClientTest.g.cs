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

namespace Google.Cloud.Firestore.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Firestore.V1;
    using Google.Protobuf;
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
    public class GeneratedFirestoreClientTest
    {
        [Fact]
        public void GetDocument()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            GetDocumentRequest request = new GetDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            Document expectedResponse = new Document
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetDocument(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = client.GetDocument(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetDocumentAsync()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            GetDocumentRequest request = new GetDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            Document expectedResponse = new Document
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetDocumentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Document>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = await client.GetDocumentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateDocument()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                Parent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString(),
                CollectionId = "collectionId-821242276",
                DocumentId = "documentId506676927",
                Document = new Document(),
            };
            Document expectedResponse = new Document
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateDocument(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = client.CreateDocument(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateDocumentAsync()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                Parent = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString(),
                CollectionId = "collectionId-821242276",
                DocumentId = "documentId506676927",
                Document = new Document(),
            };
            Document expectedResponse = new Document
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateDocumentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Document>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = await client.CreateDocumentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateDocument()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            UpdateDocumentRequest expectedRequest = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
            };
            Document expectedResponse = new Document
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateDocument(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            DocumentMask updateMask = new DocumentMask();
            Document response = client.UpdateDocument(document, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateDocumentAsync()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            UpdateDocumentRequest expectedRequest = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
            };
            Document expectedResponse = new Document
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateDocumentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Document>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            DocumentMask updateMask = new DocumentMask();
            Document response = await client.UpdateDocumentAsync(document, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateDocument2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
            };
            Document expectedResponse = new Document
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateDocument(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = client.UpdateDocument(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateDocumentAsync2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
            };
            Document expectedResponse = new Document
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateDocumentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Document>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = await client.UpdateDocumentAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteDocument()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            DeleteDocumentRequest expectedRequest = new DeleteDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDocument(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            AnyPathName name = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]");
            client.DeleteDocument(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteDocumentAsync()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            DeleteDocumentRequest expectedRequest = new DeleteDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDocumentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            AnyPathName name = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]");
            await client.DeleteDocumentAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteDocument2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDocument(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            client.DeleteDocument(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteDocumentAsync2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                AnyPathName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteDocumentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDocumentAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BeginTransaction()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            BeginTransactionRequest expectedRequest = new BeginTransactionRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            BeginTransactionResponse response = client.BeginTransaction(formattedDatabase);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BeginTransactionAsync()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            BeginTransactionRequest expectedRequest = new BeginTransactionRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BeginTransactionResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            BeginTransactionResponse response = await client.BeginTransactionAsync(formattedDatabase);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BeginTransaction2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse response = client.BeginTransaction(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BeginTransactionAsync2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BeginTransactionResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse response = await client.BeginTransactionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Commit()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Writes = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.Commit(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            IEnumerable<Write> writes = new List<Write>();
            CommitResponse response = client.Commit(formattedDatabase, writes);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CommitAsync()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Writes = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.CommitAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CommitResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            IEnumerable<Write> writes = new List<Write>();
            CommitResponse response = await client.CommitAsync(formattedDatabase, writes);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Commit2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Writes = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.Commit(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CommitAsync2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Writes = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.CommitAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CommitResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = await client.CommitAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Rollback()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            RollbackRequest expectedRequest = new RollbackRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.Rollback(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            ByteString transaction = ByteString.CopyFromUtf8("-34");
            client.Rollback(formattedDatabase, transaction);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RollbackAsync()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            RollbackRequest expectedRequest = new RollbackRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.RollbackAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            ByteString transaction = ByteString.CopyFromUtf8("-34");
            await client.RollbackAsync(formattedDatabase, transaction);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Rollback2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.Rollback(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            client.Rollback(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RollbackAsync2()
        {
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient>(MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Database = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString(),
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.RollbackAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            await client.RollbackAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
