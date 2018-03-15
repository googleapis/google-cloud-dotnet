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

namespace Google.Cloud.Firestore.V1Beta1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedFirestoreClientTest
    {
        [Fact]
        public void UpdateDocumentTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient> { DefaultValue = DefaultValue.Mock };
            Document expectedResponse = new Document
            {
                Name = "name3373707",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateDocument(It.IsAny<UpdateDocumentRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            Document document = new Document();
            DocumentMask updateMask = new DocumentMask();
            Document response = client.UpdateDocument(document, updateMask);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteDocumentTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteDocument(It.IsAny<DeleteDocumentRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedName = new AnyPathName("[PROJECT]", "[DATABASE]", "[DOCUMENT]", "[ANY_PATH]").ToString();
            client.DeleteDocument(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BeginTransactionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient> { DefaultValue = DefaultValue.Mock };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.BeginTransaction(It.IsAny<BeginTransactionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            BeginTransactionResponse response = client.BeginTransaction(formattedDatabase);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CommitTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient> { DefaultValue = DefaultValue.Mock };
            CommitResponse expectedResponse = new CommitResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Commit(It.IsAny<CommitRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            IEnumerable<Write> writes = new List<Write>();
            CommitResponse response = client.Commit(formattedDatabase, writes);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RollbackTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Firestore.FirestoreClient> mockGrpcClient = new Mock<Firestore.FirestoreClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Rollback(It.IsAny<RollbackRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            FirestoreClient client = new FirestoreClientImpl(mockGrpcClient.Object, null);
            string formattedDatabase = new DatabaseRootName("[PROJECT]", "[DATABASE]").ToString();
            ByteString transaction = ByteString.CopyFromUtf8("-34");
            client.Rollback(formattedDatabase, transaction);
            mockGrpcClient.VerifyAll();
        }

    }
}
