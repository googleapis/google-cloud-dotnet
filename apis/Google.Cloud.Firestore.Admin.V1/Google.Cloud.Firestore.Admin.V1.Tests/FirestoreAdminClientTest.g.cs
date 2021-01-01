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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Firestore.Admin.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFirestoreAdminClientTest
    {
        [xunit::FactAttribute]
        public void GetIndexRequestObject()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
                QueryScope = Index.Types.QueryScope.Unspecified,
                Fields =
                {
                    new Index.Types.IndexField(),
                },
                State = Index.Types.State.Ready,
            };
            mockGrpcClient.Setup(x => x.GetIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Index response = client.GetIndex(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexRequestObjectAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
                QueryScope = Index.Types.QueryScope.Unspecified,
                Fields =
                {
                    new Index.Types.IndexField(),
                },
                State = Index.Types.State.Ready,
            };
            mockGrpcClient.Setup(x => x.GetIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Index>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Index responseCallSettings = await client.GetIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Index responseCancellationToken = await client.GetIndexAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIndex()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
                QueryScope = Index.Types.QueryScope.Unspecified,
                Fields =
                {
                    new Index.Types.IndexField(),
                },
                State = Index.Types.State.Ready,
            };
            mockGrpcClient.Setup(x => x.GetIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Index response = client.GetIndex(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
                QueryScope = Index.Types.QueryScope.Unspecified,
                Fields =
                {
                    new Index.Types.IndexField(),
                },
                State = Index.Types.State.Ready,
            };
            mockGrpcClient.Setup(x => x.GetIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Index>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Index responseCallSettings = await client.GetIndexAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Index responseCancellationToken = await client.GetIndexAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIndexResourceNames()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
                QueryScope = Index.Types.QueryScope.Unspecified,
                Fields =
                {
                    new Index.Types.IndexField(),
                },
                State = Index.Types.State.Ready,
            };
            mockGrpcClient.Setup(x => x.GetIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Index response = client.GetIndex(request.IndexName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexResourceNamesAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexRequest request = new GetIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            Index expectedResponse = new Index
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
                QueryScope = Index.Types.QueryScope.Unspecified,
                Fields =
                {
                    new Index.Types.IndexField(),
                },
                State = Index.Types.State.Ready,
            };
            mockGrpcClient.Setup(x => x.GetIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Index>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Index responseCallSettings = await client.GetIndexAsync(request.IndexName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Index responseCancellationToken = await client.GetIndexAsync(request.IndexName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIndexRequestObject()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteIndex(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIndexRequestObjectAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIndexAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIndexAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIndex()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteIndex(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIndexAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIndexAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIndexAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteIndexResourceNames()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIndex(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteIndex(request.IndexName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteIndexResourceNamesAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteIndexRequest request = new DeleteIndexRequest
            {
                IndexName = IndexName.FromProjectDatabaseCollectionIndex("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[INDEX]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteIndexAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteIndexAsync(request.IndexName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteIndexAsync(request.IndexName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFieldRequestObject()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
            };
            Field expectedResponse = new Field
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
                IndexConfig = new Field.Types.IndexConfig(),
            };
            mockGrpcClient.Setup(x => x.GetField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Field response = client.GetField(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFieldRequestObjectAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
            };
            Field expectedResponse = new Field
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
                IndexConfig = new Field.Types.IndexConfig(),
            };
            mockGrpcClient.Setup(x => x.GetFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Field>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Field responseCallSettings = await client.GetFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Field responseCancellationToken = await client.GetFieldAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetField()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
            };
            Field expectedResponse = new Field
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
                IndexConfig = new Field.Types.IndexConfig(),
            };
            mockGrpcClient.Setup(x => x.GetField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Field response = client.GetField(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFieldAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
            };
            Field expectedResponse = new Field
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
                IndexConfig = new Field.Types.IndexConfig(),
            };
            mockGrpcClient.Setup(x => x.GetFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Field>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Field responseCallSettings = await client.GetFieldAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Field responseCancellationToken = await client.GetFieldAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFieldResourceNames()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
            };
            Field expectedResponse = new Field
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
                IndexConfig = new Field.Types.IndexConfig(),
            };
            mockGrpcClient.Setup(x => x.GetField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Field response = client.GetField(request.FieldName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFieldResourceNamesAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFieldRequest request = new GetFieldRequest
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
            };
            Field expectedResponse = new Field
            {
                FieldName = FieldName.FromProjectDatabaseCollectionField("[PROJECT]", "[DATABASE]", "[COLLECTION]", "[FIELD]"),
                IndexConfig = new Field.Types.IndexConfig(),
            };
            mockGrpcClient.Setup(x => x.GetFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Field>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null);
            Field responseCallSettings = await client.GetFieldAsync(request.FieldName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Field responseCancellationToken = await client.GetFieldAsync(request.FieldName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
