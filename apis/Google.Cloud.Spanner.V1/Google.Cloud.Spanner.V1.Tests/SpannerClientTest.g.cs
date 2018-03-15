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

namespace Google.Cloud.Spanner.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedSpannerClientTest
    {
        [Fact]
        public void CreateSessionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient> { DefaultValue = DefaultValue.Mock };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.CreateSession(It.IsAny<CreateSessionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            Session response = client.CreateSession(database);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSessionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient> { DefaultValue = DefaultValue.Mock };
            Session expectedResponse = new Session
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetSession(It.IsAny<GetSessionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            Session response = client.GetSession(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSessionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteSession(It.IsAny<DeleteSessionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            client.DeleteSession(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BeginTransactionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient> { DefaultValue = DefaultValue.Mock };
            Transaction expectedResponse = new Transaction
            {
                Id = ByteString.CopyFromUtf8("27"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.BeginTransaction(It.IsAny<BeginTransactionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions options = new TransactionOptions();
            Transaction response = client.BeginTransaction(session, options);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CommitTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient> { DefaultValue = DefaultValue.Mock };
            CommitResponse expectedResponse = new CommitResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Commit(It.IsAny<CommitRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("28");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = client.Commit(session, transactionId, mutations);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CommitTest2()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient> { DefaultValue = DefaultValue.Mock };
            CommitResponse expectedResponse = new CommitResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Commit(It.IsAny<CommitRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions singleUseTransaction = new TransactionOptions();
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = client.Commit(session, singleUseTransaction, mutations);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RollbackTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Spanner.SpannerClient> mockGrpcClient = new Mock<Spanner.SpannerClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Rollback(It.IsAny<RollbackRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            SpannerClient client = new SpannerClientImpl(mockGrpcClient.Object, null);
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.CopyFromUtf8("28");
            client.Rollback(session, transactionId);
            mockGrpcClient.VerifyAll();
        }

    }
}
