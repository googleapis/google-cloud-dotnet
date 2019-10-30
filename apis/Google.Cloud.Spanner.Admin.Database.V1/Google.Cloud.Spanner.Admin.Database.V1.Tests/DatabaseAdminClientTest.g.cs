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
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Database>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Database>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            Database responseCallSettings = await client.GetDatabaseAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Database responseCancellationToken = await client.GetDatabaseAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabase_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            Database response = client.GetDatabase(request.DatabaseName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseAsync_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            Database expectedResponse = new Database
            {
                DatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                State = Database.Types.State.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Database>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            await client.DropDatabaseAsync(request.Database, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DropDatabaseAsync(request.Database, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DropDatabase_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            client.DropDatabase(request.DatabaseAsDatabaseName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DropDatabaseAsync_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropDatabaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetDatabaseDdlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetDatabaseDdlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            GetDatabaseDdlResponse responseCallSettings = await client.GetDatabaseDdlAsync(request.Database, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GetDatabaseDdlResponse responseCancellationToken = await client.GetDatabaseDdlAsync(request.Database, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDatabaseDdl_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdl(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            GetDatabaseDdlResponse response = client.GetDatabaseDdl(request.DatabaseAsDatabaseName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDatabaseDdlAsync_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = new gcscv::DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            GetDatabaseDdlResponse expectedResponse = new GetDatabaseDdlResponse
            {
                Statements =
                {
                    "statementsbaee2cf5",
                },
            };
            mockGrpcClient.Setup(x => x.GetDatabaseDdlAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GetDatabaseDdlResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
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
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync_ResourceNames()
        {
            moq::Mock<DatabaseAdmin.DatabaseAdminClient> mockGrpcClient = new moq::Mock<DatabaseAdmin.DatabaseAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnknownResourceName("a/wildcard/resource"),
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
            DatabaseAdminClient client = new DatabaseAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
