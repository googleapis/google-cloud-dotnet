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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcbcv = Google.Cloud.Bigtable.Common.V2;
using gciv = Google.Cloud.Iam.V1;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Bigtable.Admin.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBigtableTableAdminClientTest
    {
        [xunit::FactAttribute]
        public void CreateTableRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "table_idde1e5ba1",
                Table = new Table(),
                InitialSplits =
                {
                    new CreateTableRequest.Types.Split(),
                },
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.CreateTable(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTableRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "table_idde1e5ba1",
                Table = new Table(),
                InitialSplits =
                {
                    new CreateTableRequest.Types.Split(),
                },
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.CreateTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.CreateTableAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTable()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "table_idde1e5ba1",
                Table = new Table(),
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.CreateTable(request.Parent, request.TableId, request.Table);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTableAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "table_idde1e5ba1",
                Table = new Table(),
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.CreateTableAsync(request.Parent, request.TableId, request.Table, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.CreateTableAsync(request.Parent, request.TableId, request.Table, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTableResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "table_idde1e5ba1",
                Table = new Table(),
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.CreateTable(request.ParentAsInstanceName, request.TableId, request.Table);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTableResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "table_idde1e5ba1",
                Table = new Table(),
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.CreateTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.CreateTableAsync(request.ParentAsInstanceName, request.TableId, request.Table, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.CreateTableAsync(request.ParentAsInstanceName, request.TableId, request.Table, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTableRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTableRequest request = new GetTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                View = Table.Types.View.NameOnly,
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.GetTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.GetTable(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTableRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTableRequest request = new GetTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                View = Table.Types.View.NameOnly,
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.GetTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.GetTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.GetTableAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTable()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTableRequest request = new GetTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.GetTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.GetTable(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTableAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTableRequest request = new GetTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.GetTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.GetTableAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.GetTableAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTableResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTableRequest request = new GetTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.GetTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.GetTable(request.TableName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTableResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTableRequest request = new GetTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.GetTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.GetTableAsync(request.TableName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.GetTableAsync(request.TableName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTableRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteTable(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTableRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTableAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTable()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteTable(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTableAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTableAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTableAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTableResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteTable(request.TableName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTableResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTableAsync(request.TableName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTableAsync(request.TableName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyColumnFamiliesRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications =
                {
                    new ModifyColumnFamiliesRequest.Types.Modification(),
                },
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamilies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.ModifyColumnFamilies(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyColumnFamiliesRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications =
                {
                    new ModifyColumnFamiliesRequest.Types.Modification(),
                },
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamiliesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.ModifyColumnFamiliesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.ModifyColumnFamiliesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyColumnFamilies()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications =
                {
                    new ModifyColumnFamiliesRequest.Types.Modification(),
                },
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamilies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.ModifyColumnFamilies(request.Name, request.Modifications);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyColumnFamiliesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications =
                {
                    new ModifyColumnFamiliesRequest.Types.Modification(),
                },
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamiliesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.ModifyColumnFamiliesAsync(request.Name, request.Modifications, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.ModifyColumnFamiliesAsync(request.Name, request.Modifications, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ModifyColumnFamiliesResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications =
                {
                    new ModifyColumnFamiliesRequest.Types.Modification(),
                },
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamilies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.ModifyColumnFamilies(request.TableName, request.Modifications);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ModifyColumnFamiliesResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications =
                {
                    new ModifyColumnFamiliesRequest.Types.Modification(),
                },
            };
            Table expectedResponse = new Table
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterStates =
                {
                    {
                        "key8a0b6e3c",
                        new Table.Types.ClusterState()
                    },
                },
                ColumnFamilies =
                {
                    {
                        "key8a0b6e3c",
                        new ColumnFamily()
                    },
                },
                Granularity = Table.Types.TimestampGranularity.Unspecified,
                RestoreInfo = new RestoreInfo(),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamiliesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.ModifyColumnFamiliesAsync(request.TableName, request.Modifications, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.ModifyColumnFamiliesAsync(request.TableName, request.Modifications, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DropRowRangeRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKeyPrefix = proto::ByteString.CopyFromUtf8("row_key_prefixb7d03808"),
                DeleteAllDataFromTable = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropRowRange(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DropRowRange(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DropRowRangeRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKeyPrefix = proto::ByteString.CopyFromUtf8("row_key_prefixb7d03808"),
                DeleteAllDataFromTable = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DropRowRangeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DropRowRangeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DropRowRangeAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateConsistencyTokenRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            GenerateConsistencyTokenResponse response = client.GenerateConsistencyToken(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateConsistencyTokenRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateConsistencyTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            GenerateConsistencyTokenResponse responseCallSettings = await client.GenerateConsistencyTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateConsistencyTokenResponse responseCancellationToken = await client.GenerateConsistencyTokenAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateConsistencyToken()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            GenerateConsistencyTokenResponse response = client.GenerateConsistencyToken(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateConsistencyTokenAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateConsistencyTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            GenerateConsistencyTokenResponse responseCallSettings = await client.GenerateConsistencyTokenAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateConsistencyTokenResponse responseCancellationToken = await client.GenerateConsistencyTokenAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateConsistencyTokenResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            GenerateConsistencyTokenResponse response = client.GenerateConsistencyToken(request.TableName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateConsistencyTokenResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateConsistencyTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            GenerateConsistencyTokenResponse responseCallSettings = await client.GenerateConsistencyTokenAsync(request.TableName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateConsistencyTokenResponse responseCancellationToken = await client.GenerateConsistencyTokenAsync(request.TableName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckConsistencyRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse { Consistent = false, };
            mockGrpcClient.Setup(x => x.CheckConsistency(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            CheckConsistencyResponse response = client.CheckConsistency(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckConsistencyRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse { Consistent = false, };
            mockGrpcClient.Setup(x => x.CheckConsistencyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckConsistencyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            CheckConsistencyResponse responseCallSettings = await client.CheckConsistencyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckConsistencyResponse responseCancellationToken = await client.CheckConsistencyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckConsistency()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse { Consistent = false, };
            mockGrpcClient.Setup(x => x.CheckConsistency(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            CheckConsistencyResponse response = client.CheckConsistency(request.Name, request.ConsistencyToken);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckConsistencyAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse { Consistent = false, };
            mockGrpcClient.Setup(x => x.CheckConsistencyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckConsistencyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            CheckConsistencyResponse responseCallSettings = await client.CheckConsistencyAsync(request.Name, request.ConsistencyToken, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckConsistencyResponse responseCancellationToken = await client.CheckConsistencyAsync(request.Name, request.ConsistencyToken, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CheckConsistencyResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse { Consistent = false, };
            mockGrpcClient.Setup(x => x.CheckConsistency(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            CheckConsistencyResponse response = client.CheckConsistency(request.TableName, request.ConsistencyToken);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CheckConsistencyResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = gcbcv::TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistency_token7d99a6b3",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse { Consistent = false, };
            mockGrpcClient.Setup(x => x.CheckConsistencyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CheckConsistencyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            CheckConsistencyResponse responseCallSettings = await client.CheckConsistencyAsync(request.TableName, request.ConsistencyToken, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CheckConsistencyResponse responseCancellationToken = await client.CheckConsistencyAsync(request.TableName, request.ConsistencyToken, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSnapshotRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                SourceTable = new Table(),
                DataSizeBytes = 4901836685197062001L,
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = Snapshot.Types.State.NotKnown,
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.GetSnapshot(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                SourceTable = new Table(),
                DataSizeBytes = 4901836685197062001L,
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = Snapshot.Types.State.NotKnown,
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.GetSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.GetSnapshotAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSnapshot()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                SourceTable = new Table(),
                DataSizeBytes = 4901836685197062001L,
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = Snapshot.Types.State.NotKnown,
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.GetSnapshot(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                SourceTable = new Table(),
                DataSizeBytes = 4901836685197062001L,
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = Snapshot.Types.State.NotKnown,
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.GetSnapshotAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.GetSnapshotAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSnapshotResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                SourceTable = new Table(),
                DataSizeBytes = 4901836685197062001L,
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = Snapshot.Types.State.NotKnown,
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.GetSnapshot(request.SnapshotName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSnapshotResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                SourceTable = new Table(),
                DataSizeBytes = 4901836685197062001L,
                CreateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                State = Snapshot.Types.State.NotKnown,
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Snapshot>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Snapshot responseCallSettings = await client.GetSnapshotAsync(request.SnapshotName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Snapshot responseCancellationToken = await client.GetSnapshotAsync(request.SnapshotName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshotRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshot(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSnapshotAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshot()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshot(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSnapshotAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSnapshotResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshot(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshot(request.SnapshotName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSnapshotResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotAsync(request.SnapshotName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSnapshotAsync(request.SnapshotName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup response = client.GetBackup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.GetBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackup()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup response = client.GetBackup(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetBackupResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.GetBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup response = client.GetBackup(request.BackupName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetBackupResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.GetBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.GetBackupAsync(request.BackupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.GetBackupAsync(request.BackupName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBackupRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new wkt::FieldMask(),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.UpdateBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup response = client.UpdateBackup(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBackupRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new wkt::FieldMask(),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.UpdateBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.UpdateBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.UpdateBackupAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateBackup()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new wkt::FieldMask(),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.UpdateBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup response = client.UpdateBackup(request.Backup, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateBackupAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new wkt::FieldMask(),
            };
            Backup expectedResponse = new Backup
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                SourceTable = "source_table3c9665d0",
                ExpireTime = new wkt::Timestamp(),
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                SizeBytes = 4628423819757039038L,
                State = Backup.Types.State.Unspecified,
                EncryptionInfo = new EncryptionInfo(),
            };
            mockGrpcClient.Setup(x => x.UpdateBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Backup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Backup responseCallSettings = await client.UpdateBackupAsync(request.Backup, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Backup responseCancellationToken = await client.UpdateBackupAsync(request.Backup, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBackupRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteBackup(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBackupRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBackupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBackupAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBackup()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteBackup(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBackupAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBackupAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBackupAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteBackupResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteBackup(request.BackupName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteBackupResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteBackupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteBackupAsync(request.BackupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteBackupAsync(request.BackupName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new moq::Mock<BigtableTableAdmin.BigtableTableAdminClient>(moq::MockBehavior.Strict);
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
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
