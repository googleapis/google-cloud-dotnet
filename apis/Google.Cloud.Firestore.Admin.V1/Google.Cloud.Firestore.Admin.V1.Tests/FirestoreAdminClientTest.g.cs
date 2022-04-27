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
using gagr = Google.Api.Gax.ResourceNames;
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
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
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            Field responseCallSettings = await client.GetFieldAsync(request.FieldName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Field responseCancellationToken = await client.GetFieldAsync(request.FieldName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabaseRequestObject()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                LocationId = "location_iddaa574e2",
                Type = Database.Types.DatabaseType.Unspecified,
                ConcurrencyMode = Database.Types.ConcurrencyMode.OptimisticWithEntityGroups,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            Database response = client.GetDatabase(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseRequestObjectAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                LocationId = "location_iddaa574e2",
                Type = Database.Types.DatabaseType.Unspecified,
                ConcurrencyMode = Database.Types.ConcurrencyMode.OptimisticWithEntityGroups,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Database>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            Database responseCallSettings = await client.GetDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Database responseCancellationToken = await client.GetDatabaseAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabase()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                LocationId = "location_iddaa574e2",
                Type = Database.Types.DatabaseType.Unspecified,
                ConcurrencyMode = Database.Types.ConcurrencyMode.OptimisticWithEntityGroups,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            Database response = client.GetDatabase(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                LocationId = "location_iddaa574e2",
                Type = Database.Types.DatabaseType.Unspecified,
                ConcurrencyMode = Database.Types.ConcurrencyMode.OptimisticWithEntityGroups,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Database>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            Database responseCallSettings = await client.GetDatabaseAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Database responseCancellationToken = await client.GetDatabaseAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabaseResourceNames()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                LocationId = "location_iddaa574e2",
                Type = Database.Types.DatabaseType.Unspecified,
                ConcurrencyMode = Database.Types.ConcurrencyMode.OptimisticWithEntityGroups,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            Database response = client.GetDatabase(request.DatabaseName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseResourceNamesAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = DatabaseName.FromProjectDatabase("[PROJECT]", "[DATABASE]"),
                LocationId = "location_iddaa574e2",
                Type = Database.Types.DatabaseType.Unspecified,
                ConcurrencyMode = Database.Types.ConcurrencyMode.OptimisticWithEntityGroups,
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Database>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            Database responseCallSettings = await client.GetDatabaseAsync(request.DatabaseName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Database responseCancellationToken = await client.GetDatabaseAsync(request.DatabaseName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDatabasesRequestObject()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListDatabasesResponse expectedResponse = new ListDatabasesResponse
            {
                Databases = { new Database(), },
            };
            mockGrpcClient.Setup(x => x.ListDatabases(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            ListDatabasesResponse response = client.ListDatabases(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDatabasesRequestObjectAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListDatabasesResponse expectedResponse = new ListDatabasesResponse
            {
                Databases = { new Database(), },
            };
            mockGrpcClient.Setup(x => x.ListDatabasesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDatabasesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            ListDatabasesResponse responseCallSettings = await client.ListDatabasesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDatabasesResponse responseCancellationToken = await client.ListDatabasesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDatabases()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListDatabasesResponse expectedResponse = new ListDatabasesResponse
            {
                Databases = { new Database(), },
            };
            mockGrpcClient.Setup(x => x.ListDatabases(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            ListDatabasesResponse response = client.ListDatabases(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDatabasesAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListDatabasesResponse expectedResponse = new ListDatabasesResponse
            {
                Databases = { new Database(), },
            };
            mockGrpcClient.Setup(x => x.ListDatabasesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDatabasesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            ListDatabasesResponse responseCallSettings = await client.ListDatabasesAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDatabasesResponse responseCancellationToken = await client.ListDatabasesAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListDatabasesResourceNames()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListDatabasesResponse expectedResponse = new ListDatabasesResponse
            {
                Databases = { new Database(), },
            };
            mockGrpcClient.Setup(x => x.ListDatabases(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            ListDatabasesResponse response = client.ListDatabases(request.ParentAsProjectName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListDatabasesResourceNamesAsync()
        {
            moq::Mock<FirestoreAdmin.FirestoreAdminClient> mockGrpcClient = new moq::Mock<FirestoreAdmin.FirestoreAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
            };
            ListDatabasesResponse expectedResponse = new ListDatabasesResponse
            {
                Databases = { new Database(), },
            };
            mockGrpcClient.Setup(x => x.ListDatabasesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListDatabasesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FirestoreAdminClient client = new FirestoreAdminClientImpl(mockGrpcClient.Object, null, null);
            ListDatabasesResponse responseCallSettings = await client.ListDatabasesAsync(request.ParentAsProjectName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListDatabasesResponse responseCancellationToken = await client.ListDatabasesAsync(request.ParentAsProjectName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
