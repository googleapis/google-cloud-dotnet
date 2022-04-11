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

using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Datastore.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDatastoreClientTest
    {
        [xunit::FactAttribute]
        public void LookupRequestObject()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            LookupRequest request = new LookupRequest
            {
                ReadOptions = new ReadOptions(),
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            LookupResponse expectedResponse = new LookupResponse
            {
                Found = { new EntityResult(), },
                Missing = { new EntityResult(), },
                Deferred = { new Key(), },
                ReadTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.Lookup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            LookupResponse response = client.Lookup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LookupRequestObjectAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            LookupRequest request = new LookupRequest
            {
                ReadOptions = new ReadOptions(),
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            LookupResponse expectedResponse = new LookupResponse
            {
                Found = { new EntityResult(), },
                Missing = { new EntityResult(), },
                Deferred = { new Key(), },
                ReadTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.LookupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LookupResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            LookupResponse responseCallSettings = await client.LookupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LookupResponse responseCancellationToken = await client.LookupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Lookup()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            LookupRequest request = new LookupRequest
            {
                ReadOptions = new ReadOptions(),
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            LookupResponse expectedResponse = new LookupResponse
            {
                Found = { new EntityResult(), },
                Missing = { new EntityResult(), },
                Deferred = { new Key(), },
                ReadTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.Lookup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            LookupResponse response = client.Lookup(request.ProjectId, request.ReadOptions, request.Keys);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LookupAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            LookupRequest request = new LookupRequest
            {
                ReadOptions = new ReadOptions(),
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            LookupResponse expectedResponse = new LookupResponse
            {
                Found = { new EntityResult(), },
                Missing = { new EntityResult(), },
                Deferred = { new Key(), },
                ReadTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.LookupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LookupResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            LookupResponse responseCallSettings = await client.LookupAsync(request.ProjectId, request.ReadOptions, request.Keys, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LookupResponse responseCancellationToken = await client.LookupAsync(request.ProjectId, request.ReadOptions, request.Keys, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RunQueryRequestObject()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            RunQueryRequest request = new RunQueryRequest
            {
                ReadOptions = new ReadOptions(),
                PartitionId = new PartitionId(),
                Query = new Query(),
                GqlQuery = new GqlQuery(),
                ProjectId = "project_id43ad98b0",
            };
            RunQueryResponse expectedResponse = new RunQueryResponse
            {
                Batch = new QueryResultBatch(),
                Query = new Query(),
            };
            mockGrpcClient.Setup(x => x.RunQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            RunQueryResponse response = client.RunQuery(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RunQueryRequestObjectAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            RunQueryRequest request = new RunQueryRequest
            {
                ReadOptions = new ReadOptions(),
                PartitionId = new PartitionId(),
                Query = new Query(),
                GqlQuery = new GqlQuery(),
                ProjectId = "project_id43ad98b0",
            };
            RunQueryResponse expectedResponse = new RunQueryResponse
            {
                Batch = new QueryResultBatch(),
                Query = new Query(),
            };
            mockGrpcClient.Setup(x => x.RunQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RunQueryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            RunQueryResponse responseCallSettings = await client.RunQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RunQueryResponse responseCancellationToken = await client.RunQueryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BeginTransactionRequestObject()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "project_id43ad98b0",
                TransactionOptions = new TransactionOptions(),
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse response = client.BeginTransaction(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BeginTransactionRequestObjectAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "project_id43ad98b0",
                TransactionOptions = new TransactionOptions(),
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BeginTransactionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse responseCallSettings = await client.BeginTransactionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BeginTransactionResponse responseCancellationToken = await client.BeginTransactionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BeginTransaction()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "project_id43ad98b0",
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            mockGrpcClient.Setup(x => x.BeginTransaction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse response = client.BeginTransaction(request.ProjectId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BeginTransactionAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                ProjectId = "project_id43ad98b0",
            };
            BeginTransactionResponse expectedResponse = new BeginTransactionResponse
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
            };
            mockGrpcClient.Setup(x => x.BeginTransactionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BeginTransactionResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            BeginTransactionResponse responseCallSettings = await client.BeginTransactionAsync(request.ProjectId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BeginTransactionResponse responseCancellationToken = await client.BeginTransactionAsync(request.ProjectId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CommitRequestObject()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { new Mutation(), },
                ProjectId = "project_id43ad98b0",
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                MutationResults =
                {
                    new MutationResult(),
                },
                IndexUpdates = 1466771529,
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CommitRequestObjectAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { new Mutation(), },
                ProjectId = "project_id43ad98b0",
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                MutationResults =
                {
                    new MutationResult(),
                },
                IndexUpdates = 1466771529,
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Commit1()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { new Mutation(), },
                ProjectId = "project_id43ad98b0",
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                MutationResults =
                {
                    new MutationResult(),
                },
                IndexUpdates = 1466771529,
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request.ProjectId, request.Mode, request.Transaction, request.Mutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Commit1Async()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { new Mutation(), },
                ProjectId = "project_id43ad98b0",
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                MutationResults =
                {
                    new MutationResult(),
                },
                IndexUpdates = 1466771529,
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request.ProjectId, request.Mode, request.Transaction, request.Mutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request.ProjectId, request.Mode, request.Transaction, request.Mutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Commit2()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { new Mutation(), },
                ProjectId = "project_id43ad98b0",
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                MutationResults =
                {
                    new MutationResult(),
                },
                IndexUpdates = 1466771529,
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.Commit(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse response = client.Commit(request.ProjectId, request.Mode, request.Mutations);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task Commit2Async()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            CommitRequest request = new CommitRequest
            {
                Mode = CommitRequest.Types.Mode.Unspecified,
                Mutations = { new Mutation(), },
                ProjectId = "project_id43ad98b0",
            };
            CommitResponse expectedResponse = new CommitResponse
            {
                MutationResults =
                {
                    new MutationResult(),
                },
                IndexUpdates = 1466771529,
                CommitTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CommitAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            CommitResponse responseCallSettings = await client.CommitAsync(request.ProjectId, request.Mode, request.Mutations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitResponse responseCancellationToken = await client.CommitAsync(request.ProjectId, request.Mode, request.Mutations, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RollbackRequestObject()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                ProjectId = "project_id43ad98b0",
            };
            RollbackResponse expectedResponse = new RollbackResponse { };
            mockGrpcClient.Setup(x => x.Rollback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            RollbackResponse response = client.Rollback(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackRequestObjectAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                ProjectId = "project_id43ad98b0",
            };
            RollbackResponse expectedResponse = new RollbackResponse { };
            mockGrpcClient.Setup(x => x.RollbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RollbackResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            RollbackResponse responseCallSettings = await client.RollbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RollbackResponse responseCancellationToken = await client.RollbackAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Rollback()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                ProjectId = "project_id43ad98b0",
            };
            RollbackResponse expectedResponse = new RollbackResponse { };
            mockGrpcClient.Setup(x => x.Rollback(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            RollbackResponse response = client.Rollback(request.ProjectId, request.Transaction);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RollbackAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            RollbackRequest request = new RollbackRequest
            {
                Transaction = proto::ByteString.CopyFromUtf8("transaction6ab7d5f4"),
                ProjectId = "project_id43ad98b0",
            };
            RollbackResponse expectedResponse = new RollbackResponse { };
            mockGrpcClient.Setup(x => x.RollbackAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RollbackResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            RollbackResponse responseCallSettings = await client.RollbackAsync(request.ProjectId, request.Transaction, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RollbackResponse responseCancellationToken = await client.RollbackAsync(request.ProjectId, request.Transaction, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AllocateIdsRequestObject()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            AllocateIdsResponse expectedResponse = new AllocateIdsResponse { Keys = { new Key(), }, };
            mockGrpcClient.Setup(x => x.AllocateIds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            AllocateIdsResponse response = client.AllocateIds(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AllocateIdsRequestObjectAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            AllocateIdsResponse expectedResponse = new AllocateIdsResponse { Keys = { new Key(), }, };
            mockGrpcClient.Setup(x => x.AllocateIdsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AllocateIdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            AllocateIdsResponse responseCallSettings = await client.AllocateIdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AllocateIdsResponse responseCancellationToken = await client.AllocateIdsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AllocateIds()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            AllocateIdsResponse expectedResponse = new AllocateIdsResponse { Keys = { new Key(), }, };
            mockGrpcClient.Setup(x => x.AllocateIds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            AllocateIdsResponse response = client.AllocateIds(request.ProjectId, request.Keys);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AllocateIdsAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            AllocateIdsRequest request = new AllocateIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            AllocateIdsResponse expectedResponse = new AllocateIdsResponse { Keys = { new Key(), }, };
            mockGrpcClient.Setup(x => x.AllocateIdsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AllocateIdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            AllocateIdsResponse responseCallSettings = await client.AllocateIdsAsync(request.ProjectId, request.Keys, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AllocateIdsResponse responseCancellationToken = await client.AllocateIdsAsync(request.ProjectId, request.Keys, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReserveIdsRequestObject()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            ReserveIdsRequest request = new ReserveIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
                DatabaseId = "database_idbff1efc9",
            };
            ReserveIdsResponse expectedResponse = new ReserveIdsResponse { };
            mockGrpcClient.Setup(x => x.ReserveIds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            ReserveIdsResponse response = client.ReserveIds(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReserveIdsRequestObjectAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            ReserveIdsRequest request = new ReserveIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
                DatabaseId = "database_idbff1efc9",
            };
            ReserveIdsResponse expectedResponse = new ReserveIdsResponse { };
            mockGrpcClient.Setup(x => x.ReserveIdsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReserveIdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            ReserveIdsResponse responseCallSettings = await client.ReserveIdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReserveIdsResponse responseCancellationToken = await client.ReserveIdsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReserveIds()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            ReserveIdsRequest request = new ReserveIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            ReserveIdsResponse expectedResponse = new ReserveIdsResponse { };
            mockGrpcClient.Setup(x => x.ReserveIds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            ReserveIdsResponse response = client.ReserveIds(request.ProjectId, request.Keys);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReserveIdsAsync()
        {
            moq::Mock<Datastore.DatastoreClient> mockGrpcClient = new moq::Mock<Datastore.DatastoreClient>(moq::MockBehavior.Strict);
            ReserveIdsRequest request = new ReserveIdsRequest
            {
                Keys = { new Key(), },
                ProjectId = "project_id43ad98b0",
            };
            ReserveIdsResponse expectedResponse = new ReserveIdsResponse { };
            mockGrpcClient.Setup(x => x.ReserveIdsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReserveIdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatastoreClient client = new DatastoreClientImpl(mockGrpcClient.Object, null);
            ReserveIdsResponse responseCallSettings = await client.ReserveIdsAsync(request.ProjectId, request.Keys, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReserveIdsResponse responseCancellationToken = await client.ReserveIdsAsync(request.ProjectId, request.Keys, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
