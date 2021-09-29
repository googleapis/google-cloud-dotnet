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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Firestore.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFirestoreClientTest
    {
        [xunit::FactAttribute]
        public void GetDocumentRequestObject()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            GetDocumentRequest request = new GetDocumentRequest
            {
                Name = "name1c9368b0",
                Mask = new DocumentMask(),
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                ReadTime = new wkt::Timestamp(),
            };
            Document expectedResponse = new Document
            {
                Name = "name1c9368b0",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new Value()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = client.GetDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDocumentRequestObjectAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            GetDocumentRequest request = new GetDocumentRequest
            {
                Name = "name1c9368b0",
                Mask = new DocumentMask(),
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                ReadTime = new wkt::Timestamp(),
            };
            Document expectedResponse = new Document
            {
                Name = "name1c9368b0",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new Value()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document responseCallSettings = await client.GetDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.GetDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDocumentRequestObject()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
                Mask = new DocumentMask(),
                CurrentDocument = new Precondition(),
            };
            Document expectedResponse = new Document
            {
                Name = "name1c9368b0",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new Value()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = client.UpdateDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDocumentRequestObjectAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
                Mask = new DocumentMask(),
                CurrentDocument = new Precondition(),
            };
            Document expectedResponse = new Document
            {
                Name = "name1c9368b0",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new Value()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document responseCallSettings = await client.UpdateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.UpdateDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateDocument()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
            };
            Document expectedResponse = new Document
            {
                Name = "name1c9368b0",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new Value()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = client.UpdateDocument(request.Document, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateDocumentAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            UpdateDocumentRequest request = new UpdateDocumentRequest
            {
                Document = new Document(),
                UpdateMask = new DocumentMask(),
            };
            Document expectedResponse = new Document
            {
                Name = "name1c9368b0",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new Value()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document responseCallSettings = await client.UpdateDocumentAsync(request.Document, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.UpdateDocumentAsync(request.Document, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDocumentRequestObject()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                Name = "name1c9368b0",
                CurrentDocument = new Precondition(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            client.DeleteDocument(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDocumentRequestObjectAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                Name = "name1c9368b0",
                CurrentDocument = new Precondition(),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDocumentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteDocument()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            client.DeleteDocument(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteDocumentAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            DeleteDocumentRequest request = new DeleteDocumentRequest
            {
                Name = "name1c9368b0",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            await client.DeleteDocumentAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteDocumentAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BeginTransactionRequestObject()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = "databased8eee011",
                Options = new TransactionOptions(),
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse response = client.BeginTransaction(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BeginTransactionRequestObjectAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = "databased8eee011",
                Options = new TransactionOptions(),
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BeginTransactionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse responseCallSettings = await client.BeginTransactionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BeginTransactionResponse responseCancellationToken = await client.BeginTransactionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BeginTransaction()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = "databased8eee011",
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse response = client.BeginTransaction(request.Database);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BeginTransactionAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                Database = "databased8eee011",
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BeginTransactionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse responseCallSettings = await client.BeginTransactionAsync(request.Database, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BeginTransactionResponse responseCancellationToken = await client.BeginTransactionAsync(request.Database, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CommitRequestObject()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Database = "databased8eee011",
                Writes = { new Write(), },
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                WriteResults = { new WriteResult(), },
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CommitRequestObjectAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Database = "databased8eee011",
                Writes = { new Write(), },
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                WriteResults = { new WriteResult(), },
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Commit()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Database = "databased8eee011",
                Writes = { new Write(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                WriteResults = { new WriteResult(), },
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request.Database, request.Writes);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CommitAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Database = "databased8eee011",
                Writes = { new Write(), },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                WriteResults = { new WriteResult(), },
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request.Database, request.Writes, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request.Database, request.Writes, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RollbackRequestObject()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Database = "databased8eee011",
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.Rollback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            client.Rollback(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackRequestObjectAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Database = "databased8eee011",
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RollbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            await client.RollbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RollbackAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Rollback()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Database = "databased8eee011",
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.Rollback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            client.Rollback(request.Database, request.Transaction);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Database = "databased8eee011",
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.RollbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            await client.RollbackAsync(request.Database, request.Transaction, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.RollbackAsync(request.Database, request.Transaction, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchWriteRequestObject()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            BatchWriteRequest request = new BatchWriteRequest
            {
                Database = "databased8eee011",
                Writes = { new Write(), },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            BatchWriteResponse expectedResponse = new BatchWriteResponse
            {
                WriteResults = { new WriteResult(), },
                Status = { new gr::Status(), },
            };
            mockGrpcClient.Setup(x => x.BatchWrite(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            BatchWriteResponse response = client.BatchWrite(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchWriteRequestObjectAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            BatchWriteRequest request = new BatchWriteRequest
            {
                Database = "databased8eee011",
                Writes = { new Write(), },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            BatchWriteResponse expectedResponse = new BatchWriteResponse
            {
                WriteResults = { new WriteResult(), },
                Status = { new gr::Status(), },
            };
            mockGrpcClient.Setup(x => x.BatchWriteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchWriteResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            BatchWriteResponse responseCallSettings = await client.BatchWriteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchWriteResponse responseCancellationToken = await client.BatchWriteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateDocumentRequestObject()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                Parent = "parent7858e4d0",
                CollectionId = "collection_idd84d1a0a",
                DocumentId = "document_id10fcfae7",
                Document = new Document(),
                Mask = new DocumentMask(),
            };
            Document expectedResponse = new Document
            {
                Name = "name1c9368b0",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new Value()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document response = client.CreateDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateDocumentRequestObjectAsync()
        {
            moq::Mock<Firestore.FirestoreClient> mockGrpcClient = new moq::Mock<Firestore.FirestoreClient>(moq::MockBehavior.Strict);
            CreateDocumentRequest request = new CreateDocumentRequest
            {
                Parent = "parent7858e4d0",
                CollectionId = "collection_idd84d1a0a",
                DocumentId = "document_id10fcfae7",
                Document = new Document(),
                Mask = new DocumentMask(),
            };
            Document expectedResponse = new Document
            {
                Name = "name1c9368b0",
                Fields =
                {
                    {
                        "key8a0b6e3c",
                        new Value()
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document responseCallSettings = await client.CreateDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.CreateDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
