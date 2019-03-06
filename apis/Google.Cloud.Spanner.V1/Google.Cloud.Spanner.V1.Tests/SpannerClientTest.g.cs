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

namespace Google.Cloud.Spanner.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Spanner.Common.V1;
    using apis = Google.Cloud.Spanner.V1;
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
    public class GeneratedSpannerClientTest
    {
        [Fact]
        public void CreateSession()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CreateSessionRequest expectedRequest = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            mockGrpcClient.Setup(x => x.CreateSession(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            Session response = client.CreateSession(database);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSessionAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CreateSessionRequest expectedRequest = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            mockGrpcClient.Setup(x => x.CreateSessionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Session>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            Session response = await client.CreateSessionAsync(database);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateSession2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            mockGrpcClient.Setup(x => x.CreateSession(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = client.CreateSession(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateSessionAsync2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            mockGrpcClient.Setup(x => x.CreateSessionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Session>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = await client.CreateSessionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSession()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            GetSessionRequest expectedRequest = new GetSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            mockGrpcClient.Setup(x => x.GetSession(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            Session response = client.GetSession(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSessionAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            GetSessionRequest expectedRequest = new GetSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            mockGrpcClient.Setup(x => x.GetSessionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Session>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            Session response = await client.GetSessionAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSession2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            mockGrpcClient.Setup(x => x.GetSession(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = client.GetSession(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSessionAsync2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            mockGrpcClient.Setup(x => x.GetSessionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Session>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Session response = await client.GetSessionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSession()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            DeleteSessionRequest expectedRequest = new DeleteSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSession(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            client.DeleteSession(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSessionAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            DeleteSessionRequest expectedRequest = new DeleteSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSessionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            await client.DeleteSessionAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSession2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSession(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            client.DeleteSession(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSessionAsync2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSessionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSessionAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ExecuteSql()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Sql = "sql114126",
            };
            ResultSet expectedResponse = new ResultSet();
            mockGrpcClient.Setup(x => x.ExecuteSql(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ResultSet response = client.ExecuteSql(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ExecuteSqlAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Sql = "sql114126",
            };
            ResultSet expectedResponse = new ResultSet();
            mockGrpcClient.Setup(x => x.ExecuteSqlAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ResultSet>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ResultSet response = await client.ExecuteSqlAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ExecuteBatchDml()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            ExecuteBatchDmlRequest request = new ExecuteBatchDmlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Statements = { },
                Seqno = 109325920L,
            };
            ExecuteBatchDmlResponse expectedResponse = new ExecuteBatchDmlResponse();
            mockGrpcClient.Setup(x => x.ExecuteBatchDml(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ExecuteBatchDmlResponse response = client.ExecuteBatchDml(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ExecuteBatchDmlAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            ExecuteBatchDmlRequest request = new ExecuteBatchDmlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Statements = { },
                Seqno = 109325920L,
            };
            ExecuteBatchDmlResponse expectedResponse = new ExecuteBatchDmlResponse();
            mockGrpcClient.Setup(x => x.ExecuteBatchDmlAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ExecuteBatchDmlResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ExecuteBatchDmlResponse response = await client.ExecuteBatchDmlAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Read()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            ReadRequest request = new ReadRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Table = "table110115790",
                Columns = { },
                KeySet = new KeySet(),
            };
            ResultSet expectedResponse = new ResultSet();
            mockGrpcClient.Setup(x => x.Read(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ResultSet response = client.Read(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReadAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            ReadRequest request = new ReadRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Table = "table110115790",
                Columns = { },
                KeySet = new KeySet(),
            };
            ResultSet expectedResponse = new ResultSet();
            mockGrpcClient.Setup(x => x.ReadAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ResultSet>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            ResultSet response = await client.ReadAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BeginTransaction()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            BeginTransactionRequest expectedRequest = new BeginTransactionRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = ByteString.CopyFromUtf8("27"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions options = new TransactionOptions();
            Transaction response = client.BeginTransaction(session, options);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BeginTransactionAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            BeginTransactionRequest expectedRequest = new BeginTransactionRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = ByteString.CopyFromUtf8("27"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Transaction>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions options = new TransactionOptions();
            Transaction response = await client.BeginTransactionAsync(session, options);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BeginTransaction2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = ByteString.CopyFromUtf8("27"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Transaction response = client.BeginTransaction(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BeginTransactionAsync2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            Transaction expectedResponse = new Transaction
            {
                Id = ByteString.CopyFromUtf8("27"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Transaction>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            Transaction response = await client.BeginTransactionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Commit()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.CopyFromUtf8("28"),
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.Commit(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("28");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = client.Commit(session, transactionId, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CommitAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.CopyFromUtf8("28"),
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.CommitAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CommitResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("28");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = await client.CommitAsync(session, transactionId, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Commit2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.Commit(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions singleUseTransaction = new TransactionOptions();
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = client.Commit(session, singleUseTransaction, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CommitAsync2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.CommitAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CommitResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions singleUseTransaction = new TransactionOptions();
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = await client.CommitAsync(session, singleUseTransaction, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Commit3()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.Commit(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CommitAsync3()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse();
            mockGrpcClient.Setup(x => x.CommitAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CommitResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = await client.CommitAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Rollback()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            RollbackRequest expectedRequest = new RollbackRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.CopyFromUtf8("28"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.Rollback(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("28");
            client.Rollback(session, transactionId);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RollbackAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            RollbackRequest expectedRequest = new RollbackRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.CopyFromUtf8("28"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.RollbackAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("28");
            await client.RollbackAsync(session, transactionId);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Rollback2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.CopyFromUtf8("28"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.Rollback(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            client.Rollback(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RollbackAsync2()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.CopyFromUtf8("28"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.RollbackAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            await client.RollbackAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PartitionQuery()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            PartitionQueryRequest request = new PartitionQueryRequest
            {
                Session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]").ToString(),
                Sql = "sql114126",
            };
            PartitionResponse expectedResponse = new PartitionResponse();
            mockGrpcClient.Setup(x => x.PartitionQuery(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            PartitionResponse response = client.PartitionQuery(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PartitionQueryAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            PartitionQueryRequest request = new PartitionQueryRequest
            {
                Session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]").ToString(),
                Sql = "sql114126",
            };
            PartitionResponse expectedResponse = new PartitionResponse();
            mockGrpcClient.Setup(x => x.PartitionQueryAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PartitionResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            PartitionResponse response = await client.PartitionQueryAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void PartitionRead()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            PartitionReadRequest request = new PartitionReadRequest
            {
                Session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]").ToString(),
                Table = "table110115790",
                KeySet = new KeySet(),
            };
            PartitionResponse expectedResponse = new PartitionResponse();
            mockGrpcClient.Setup(x => x.PartitionRead(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            PartitionResponse response = client.PartitionRead(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task PartitionReadAsync()
        {
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient>(MockBehavior.Strict);
            PartitionReadRequest request = new PartitionReadRequest
            {
                Session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]").ToString(),
                Table = "table110115790",
                KeySet = new KeySet(),
            };
            PartitionResponse expectedResponse = new PartitionResponse();
            mockGrpcClient.Setup(x => x.PartitionReadAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PartitionResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            PartitionResponse response = await client.PartitionReadAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
