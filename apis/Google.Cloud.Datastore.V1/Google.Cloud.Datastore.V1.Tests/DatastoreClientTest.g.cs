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

namespace Google.Cloud.Datastore.V1.Tests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedDatastoreClientTest
    {
        [Fact]
        public void Lookup()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            LookupRequest expectedRequest = new LookupRequest
            {
                ProjectId = "projectId-1969970175",
                ReadOptions = new ReadOptions(),
                Keys = { },
            };
            LookupResponse expectedResponse = new LookupResponse();
            mockGrpcClient.Setup(x => x.Lookup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            ReadOptions readOptions = new ReadOptions();
            IEnumerable<Key> keys = new List<Key>();
            LookupResponse response = client.Lookup(projectId, readOptions, keys);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task LookupAsync()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            LookupRequest expectedRequest = new LookupRequest
            {
                ProjectId = "projectId-1969970175",
                ReadOptions = new ReadOptions(),
                Keys = { },
            };
            LookupResponse expectedResponse = new LookupResponse();
            mockGrpcClient.Setup(x => x.LookupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LookupResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            ReadOptions readOptions = new ReadOptions();
            IEnumerable<Key> keys = new List<Key>();
            LookupResponse response = await client.LookupAsync(projectId, readOptions, keys);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Lookup2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            LookupRequest request = new LookupRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            LookupResponse expectedResponse = new LookupResponse();
            mockGrpcClient.Setup(x => x.Lookup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            LookupResponse response = client.Lookup(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task LookupAsync2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            LookupRequest request = new LookupRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            LookupResponse expectedResponse = new LookupResponse();
            mockGrpcClient.Setup(x => x.LookupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LookupResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            LookupResponse response = await client.LookupAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BeginTransaction()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            BeginTransactionRequest expectedRequest = new BeginTransactionRequest
            {
                ProjectId = "projectId-1969970175",
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            BeginTransactionResponse response = client.BeginTransaction(projectId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BeginTransactionAsync()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            BeginTransactionRequest expectedRequest = new BeginTransactionRequest
            {
                ProjectId = "projectId-1969970175",
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BeginTransactionResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            BeginTransactionResponse response = await client.BeginTransactionAsync(projectId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void BeginTransaction2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "projectId-1969970175",
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse response = client.BeginTransaction(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BeginTransactionAsync2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "projectId-1969970175",
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BeginTransactionResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse response = await client.BeginTransactionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Commit()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                ProjectId = "projectId-1969970175",
                Mode = CommitRequest.Types.Mode.Unspecified,
                Transaction = ByteString.CopyFromUtf8("-34"),
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                IndexUpdates = 1425228195,
            };
            mockGrpcClient.Setup(x => x.Commit(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            ByteString transaction = ByteString.CopyFromUtf8("-34");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = client.Commit(projectId, mode, transaction, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CommitAsync()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                ProjectId = "projectId-1969970175",
                Mode = CommitRequest.Types.Mode.Unspecified,
                Transaction = ByteString.CopyFromUtf8("-34"),
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                IndexUpdates = 1425228195,
            };
            mockGrpcClient.Setup(x => x.CommitAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CommitResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            ByteString transaction = ByteString.CopyFromUtf8("-34");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = await client.CommitAsync(projectId, mode, transaction, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Commit2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                ProjectId = "projectId-1969970175",
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                IndexUpdates = 1425228195,
            };
            mockGrpcClient.Setup(x => x.Commit(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = client.Commit(projectId, mode, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CommitAsync2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            CommitRequest expectedRequest = new CommitRequest
            {
                ProjectId = "projectId-1969970175",
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                IndexUpdates = 1425228195,
            };
            mockGrpcClient.Setup(x => x.CommitAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CommitResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            CommitRequest.Types.Mode mode = CommitRequest.Types.Mode.Unspecified;
            IEnumerable<Mutation> mutations = new List<Mutation>();
            CommitResponse response = await client.CommitAsync(projectId, mode, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Commit3()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                ProjectId = "projectId-1969970175",
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                IndexUpdates = 1425228195,
            };
            mockGrpcClient.Setup(x => x.Commit(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CommitAsync3()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                ProjectId = "projectId-1969970175",
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { },
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                IndexUpdates = 1425228195,
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CommitResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = await client.CommitAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Rollback()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            RollbackRequest expectedRequest = new RollbackRequest
            {
                ProjectId = "projectId-1969970175",
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            RollbackResponse expectedResponse = new RollbackResponse();
            mockGrpcClient.Setup(x => x.Rollback(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            ByteString transaction = ByteString.CopyFromUtf8("-34");
            RollbackResponse response = client.Rollback(projectId, transaction);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RollbackAsync()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            RollbackRequest expectedRequest = new RollbackRequest
            {
                ProjectId = "projectId-1969970175",
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            RollbackResponse expectedResponse = new RollbackResponse();
            mockGrpcClient.Setup(x => x.RollbackAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RollbackResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            ByteString transaction = ByteString.CopyFromUtf8("-34");
            RollbackResponse response = await client.RollbackAsync(projectId, transaction);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Rollback2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                ProjectId = "projectId-1969970175",
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            RollbackResponse expectedResponse = new RollbackResponse();
            mockGrpcClient.Setup(x => x.Rollback(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            RollbackResponse response = client.Rollback(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RollbackAsync2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                ProjectId = "projectId-1969970175",
                Transaction = ByteString.CopyFromUtf8("-34"),
            };
            RollbackResponse expectedResponse = new RollbackResponse();
            mockGrpcClient.Setup(x => x.RollbackAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RollbackResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            RollbackResponse response = await client.RollbackAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AllocateIds()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            AllocateIdsRequest expectedRequest = new AllocateIdsRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            AllocateIdsResponse expectedResponse = new AllocateIdsResponse();
            mockGrpcClient.Setup(x => x.AllocateIds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            IEnumerable<Key> keys = new List<Key>();
            AllocateIdsResponse response = client.AllocateIds(projectId, keys);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AllocateIdsAsync()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            AllocateIdsRequest expectedRequest = new AllocateIdsRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            AllocateIdsResponse expectedResponse = new AllocateIdsResponse();
            mockGrpcClient.Setup(x => x.AllocateIdsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AllocateIdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            IEnumerable<Key> keys = new List<Key>();
            AllocateIdsResponse response = await client.AllocateIdsAsync(projectId, keys);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AllocateIds2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            AllocateIdsResponse expectedResponse = new AllocateIdsResponse();
            mockGrpcClient.Setup(x => x.AllocateIds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            AllocateIdsResponse response = client.AllocateIds(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AllocateIdsAsync2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            AllocateIdsResponse expectedResponse = new AllocateIdsResponse();
            mockGrpcClient.Setup(x => x.AllocateIdsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AllocateIdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            AllocateIdsResponse response = await client.AllocateIdsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ReserveIds()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            ReserveIdsRequest expectedRequest = new ReserveIdsRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            ReserveIdsResponse expectedResponse = new ReserveIdsResponse();
            mockGrpcClient.Setup(x => x.ReserveIds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            IEnumerable<Key> keys = new List<Key>();
            ReserveIdsResponse response = client.ReserveIds(projectId, keys);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReserveIdsAsync()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            ReserveIdsRequest expectedRequest = new ReserveIdsRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            ReserveIdsResponse expectedResponse = new ReserveIdsResponse();
            mockGrpcClient.Setup(x => x.ReserveIdsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReserveIdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            string projectId = "projectId-1969970175";
            IEnumerable<Key> keys = new List<Key>();
            ReserveIdsResponse response = await client.ReserveIdsAsync(projectId, keys);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ReserveIds2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            ReserveIdsRequest request = new ReserveIdsRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            ReserveIdsResponse expectedResponse = new ReserveIdsResponse();
            mockGrpcClient.Setup(x => x.ReserveIds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            ReserveIdsResponse response = client.ReserveIds(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReserveIdsAsync2()
        {
            Mock<Datastore.DatastoreClient> mockGrpcClient = new Mock<Datastore.DatastoreClient>(MockBehavior.Strict);
            ReserveIdsRequest request = new ReserveIdsRequest
            {
                ProjectId = "projectId-1969970175",
                Keys = { },
            };
            ReserveIdsResponse expectedResponse = new ReserveIdsResponse();
            mockGrpcClient.Setup(x => x.ReserveIdsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReserveIdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            ReserveIdsResponse response = await client.ReserveIdsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
