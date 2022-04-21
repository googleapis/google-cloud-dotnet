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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcscv = Google.Cloud.Spanner.Common.V1;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Spanner.Admin.Database.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDatabaseAdminClientTest
    {
        [xunit::FactAttribute]
        public void GetDatabaseRequestObject()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                RestoreInfo = new RestoreInfo(),
                EncryptionConfig = new EncryptionConfig(),
                VersionRetentionPeriod = "version_retention_periodbbfc8bf7",
                EarliestVersionTime = new wkt::Timestamp(),
                EncryptionInfo =
                {
                    new EncryptionInfo(),
                },
                DefaultLeader = "default_leader08a48e00",
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Database response = client.GetDatabase(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseRequestObjectAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                RestoreInfo = new RestoreInfo(),
                EncryptionConfig = new EncryptionConfig(),
                VersionRetentionPeriod = "version_retention_periodbbfc8bf7",
                EarliestVersionTime = new wkt::Timestamp(),
                EncryptionInfo =
                {
                    new EncryptionInfo(),
                },
                DefaultLeader = "default_leader08a48e00",
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Database>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Database responseCallSettings = await client.GetDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Database responseCancellationToken = await client.GetDatabaseAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabase()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                RestoreInfo = new RestoreInfo(),
                EncryptionConfig = new EncryptionConfig(),
                VersionRetentionPeriod = "version_retention_periodbbfc8bf7",
                EarliestVersionTime = new wkt::Timestamp(),
                EncryptionInfo =
                {
                    new EncryptionInfo(),
                },
                DefaultLeader = "default_leader08a48e00",
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Database response = client.GetDatabase(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                RestoreInfo = new RestoreInfo(),
                EncryptionConfig = new EncryptionConfig(),
                VersionRetentionPeriod = "version_retention_periodbbfc8bf7",
                EarliestVersionTime = new wkt::Timestamp(),
                EncryptionInfo =
                {
                    new EncryptionInfo(),
                },
                DefaultLeader = "default_leader08a48e00",
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Database>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Database responseCallSettings = await client.GetDatabaseAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Database responseCancellationToken = await client.GetDatabaseAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabaseResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                RestoreInfo = new RestoreInfo(),
                EncryptionConfig = new EncryptionConfig(),
                VersionRetentionPeriod = "version_retention_periodbbfc8bf7",
                EarliestVersionTime = new wkt::Timestamp(),
                EncryptionInfo =
                {
                    new EncryptionInfo(),
                },
                DefaultLeader = "default_leader08a48e00",
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Database response = client.GetDatabase(request.DatabaseName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseResourceNamesAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Ready,
                CreateTime = new wkt::Timestamp(),
                RestoreInfo = new RestoreInfo(),
                EncryptionConfig = new EncryptionConfig(),
                VersionRetentionPeriod = "version_retention_periodbbfc8bf7",
                EarliestVersionTime = new wkt::Timestamp(),
                EncryptionInfo =
                {
                    new EncryptionInfo(),
                },
                DefaultLeader = "default_leader08a48e00",
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Database>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Database responseCallSettings = await client.GetDatabaseAsync(request.DatabaseName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Database responseCancellationToken = await client.GetDatabaseAsync(request.DatabaseName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DropDatabaseRequestObject()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            client.DropDatabase(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DropDatabaseRequestObjectAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            await client.DropDatabaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DropDatabaseAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DropDatabase()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            client.DropDatabase(request.Database);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DropDatabaseAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            await client.DropDatabaseAsync(request.Database, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DropDatabaseAsync(request.Database, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DropDatabaseResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            client.DropDatabase(request.DatabaseAsDatabaseName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DropDatabaseResourceNamesAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            await client.DropDatabaseAsync(request.DatabaseAsDatabaseName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DropDatabaseAsync(request.DatabaseAsDatabaseName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabaseDdlRequestObject()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            GetDatabaseDdlResponse response = client.GetDatabaseDdl(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseDdlRequestObjectAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetDatabaseDdlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            GetDatabaseDdlResponse responseCallSettings = await client.GetDatabaseDdlAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetDatabaseDdlResponse responseCancellationToken = await client.GetDatabaseDdlAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabaseDdl()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            GetDatabaseDdlResponse response = client.GetDatabaseDdl(request.Database);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseDdlAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetDatabaseDdlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            GetDatabaseDdlResponse responseCallSettings = await client.GetDatabaseDdlAsync(request.Database, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetDatabaseDdlResponse responseCancellationToken = await client.GetDatabaseDdlAsync(request.Database, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabaseDdlResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            GetDatabaseDdlResponse response = client.GetDatabaseDdl(request.DatabaseAsDatabaseName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseDdlResourceNamesAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetDatabaseDdlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            GetDatabaseDdlResponse responseCallSettings = await client.GetDatabaseDdlAsync(request.DatabaseAsDatabaseName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetDatabaseDdlResponse responseCancellationToken = await client.GetDatabaseDdlAsync(request.DatabaseAsDatabaseName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupRequestObject()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup response = client.GetBackup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupRequestObjectAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup responseCallSettings = await client.GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackup()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup response = client.GetBackup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup response = client.GetBackup(request.BackupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupResourceNamesAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.BackupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.BackupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBackupRequestObject()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new wkt::FieldMask(),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup response = client.UpdateBackup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBackupRequestObjectAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new wkt::FieldMask(),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup responseCallSettings = await client.UpdateBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.UpdateBackupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBackup()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new wkt::FieldMask(),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup response = client.UpdateBackup(request.Backup, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBackupAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new wkt::FieldMask(),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                DatabaseAsDatabaseName = gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                ExpireTime = new wkt::Timestamp(),
                CreateTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                ReferencingDatabasesAsDatabaseNames =
                {
                    gcscv::DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                },
                EncryptionInfo = new EncryptionInfo(),
                VersionTime = new wkt::Timestamp(),
                DatabaseDialect = DatabaseDialect.GoogleStandardSql,
                ReferencingBackupsAsBackupNames =
                {
                    BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                },
                MaxExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.UpdateBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            Backup responseCallSettings = await client.UpdateBackupAsync(request.Backup, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.UpdateBackupAsync(request.Backup, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBackupRequestObject()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteBackup(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBackupRequestObjectAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBackupAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBackup()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteBackup(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBackupAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteBackupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBackupAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBackupResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteBackup(request.BackupName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBackupResourceNamesAsync()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteBackupAsync(request.BackupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBackupAsync(request.BackupName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
