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

namespace Google.Cloud.Datastore.V1.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedDatastoreClientTest
    {
        [Fact]
        public void LookupTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient> { DefaultValue = DefaultValue.Mock };
            LookupResponse expectedResponse = new LookupResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Lookup(It.IsAny<LookupRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            ReadOptions readOptions = new ReadOptions();
            IEnumerable<Key> keys = new List<Key>();
            LookupResponse response = client.Lookup(projectId, readOptions, keys);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BeginTransactionTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient> { DefaultValue = DefaultValue.Mock };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.BeginTransaction(It.IsAny<BeginTransactionRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            BeginTransactionResponse response = client.BeginTransaction(projectId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CommitTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient> { DefaultValue = DefaultValue.Mock };
            CommitResponse expectedResponse = new CommitResponse
            {
                IndexUpdates = 1425228195,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Commit(It.IsAny<CommitRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            ByteString transaction = ByteString.CopyFromUtf8("-34");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = client.Commit(projectId, mode, transaction, mutations);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CommitTest2()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient> { DefaultValue = DefaultValue.Mock };
            CommitResponse expectedResponse = new CommitResponse
            {
                IndexUpdates = 1425228195,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Commit(It.IsAny<CommitRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = client.Commit(projectId, mode, mutations);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RollbackTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient> { DefaultValue = DefaultValue.Mock };
            RollbackResponse expectedResponse = new RollbackResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.Rollback(It.IsAny<RollbackRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            ByteString transaction = ByteString.CopyFromUtf8("-34");
            RollbackResponse response = client.Rollback(projectId, transaction);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AllocateIdsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient> { DefaultValue = DefaultValue.Mock };
            AllocateIdsResponse expectedResponse = new AllocateIdsResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.AllocateIds(It.IsAny<AllocateIdsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            IEnumerable<Key> keys = new List<Key>();
            AllocateIdsResponse response = client.AllocateIds(projectId, keys);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ReserveIdsTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient> { DefaultValue = DefaultValue.Mock };
            ReserveIdsResponse expectedResponse = new ReserveIdsResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ReserveIds(It.IsAny<ReserveIdsRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            IEnumerable<Key> keys = new List<Key>();
            ReserveIdsResponse response = client.ReserveIds(projectId, keys);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
