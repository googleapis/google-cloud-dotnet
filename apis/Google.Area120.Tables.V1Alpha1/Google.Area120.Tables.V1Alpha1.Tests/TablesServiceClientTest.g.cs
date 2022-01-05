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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Area120.Tables.V1Alpha1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTablesServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetTableRequestObject()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromTable("[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = TableName.FromTable("[TABLE]"),
                DisplayName = "display_name137f65c2",
                Columns =
                {
                    new ColumnDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Table response = client.GetTable(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTableRequestObjectAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromTable("[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = TableName.FromTable("[TABLE]"),
                DisplayName = "display_name137f65c2",
                Columns =
                {
                    new ColumnDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.GetTableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.GetTableAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTable()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromTable("[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = TableName.FromTable("[TABLE]"),
                DisplayName = "display_name137f65c2",
                Columns =
                {
                    new ColumnDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Table response = client.GetTable(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTableAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromTable("[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = TableName.FromTable("[TABLE]"),
                DisplayName = "display_name137f65c2",
                Columns =
                {
                    new ColumnDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.GetTableAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.GetTableAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTableResourceNames()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromTable("[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = TableName.FromTable("[TABLE]"),
                DisplayName = "display_name137f65c2",
                Columns =
                {
                    new ColumnDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTable(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Table response = client.GetTable(request.TableName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTableResourceNamesAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromTable("[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = TableName.FromTable("[TABLE]"),
                DisplayName = "display_name137f65c2",
                Columns =
                {
                    new ColumnDescription(),
                },
            };
            mockGrpcClient.Setup(x => x.GetTableAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Table>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Table responseCallSettings = await client.GetTableAsync(request.TableName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Table responseCancellationToken = await client.GetTableAsync(request.TableName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkspaceRequestObject()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
                DisplayName = "display_name137f65c2",
                Tables = { new Table(), },
            };
            mockGrpcClient.Setup(x => x.GetWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Workspace response = client.GetWorkspace(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkspaceRequestObjectAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
                DisplayName = "display_name137f65c2",
                Tables = { new Table(), },
            };
            mockGrpcClient.Setup(x => x.GetWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workspace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Workspace responseCallSettings = await client.GetWorkspaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workspace responseCancellationToken = await client.GetWorkspaceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkspace()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
                DisplayName = "display_name137f65c2",
                Tables = { new Table(), },
            };
            mockGrpcClient.Setup(x => x.GetWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Workspace response = client.GetWorkspace(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkspaceAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
                DisplayName = "display_name137f65c2",
                Tables = { new Table(), },
            };
            mockGrpcClient.Setup(x => x.GetWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workspace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Workspace responseCallSettings = await client.GetWorkspaceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workspace responseCancellationToken = await client.GetWorkspaceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetWorkspaceResourceNames()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
                DisplayName = "display_name137f65c2",
                Tables = { new Table(), },
            };
            mockGrpcClient.Setup(x => x.GetWorkspace(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Workspace response = client.GetWorkspace(request.WorkspaceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetWorkspaceResourceNamesAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
            };
            Workspace expectedResponse = new Workspace
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
                DisplayName = "display_name137f65c2",
                Tables = { new Table(), },
            };
            mockGrpcClient.Setup(x => x.GetWorkspaceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Workspace>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Workspace responseCallSettings = await client.GetWorkspaceAsync(request.WorkspaceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Workspace responseCancellationToken = await client.GetWorkspaceAsync(request.WorkspaceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRowRequestObject()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetRowRequest request = new GetRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                View = View.ColumnIdView,
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row response = client.GetRow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRowRequestObjectAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetRowRequest request = new GetRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                View = View.ColumnIdView,
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Row>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row responseCallSettings = await client.GetRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Row responseCancellationToken = await client.GetRowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRow()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetRowRequest request = new GetRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row response = client.GetRow(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRowAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetRowRequest request = new GetRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Row>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row responseCallSettings = await client.GetRowAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Row responseCancellationToken = await client.GetRowAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRowResourceNames()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetRowRequest request = new GetRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row response = client.GetRow(request.RowName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRowResourceNamesAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            GetRowRequest request = new GetRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Row>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row responseCallSettings = await client.GetRowAsync(request.RowName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Row responseCancellationToken = await client.GetRowAsync(request.RowName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateRowRequestObject()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            CreateRowRequest request = new CreateRowRequest
            {
                Parent = "parent7858e4d0",
                Row = new Row(),
                View = View.ColumnIdView,
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row response = client.CreateRow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateRowRequestObjectAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            CreateRowRequest request = new CreateRowRequest
            {
                Parent = "parent7858e4d0",
                Row = new Row(),
                View = View.ColumnIdView,
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Row>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row responseCallSettings = await client.CreateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Row responseCancellationToken = await client.CreateRowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateRow()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            CreateRowRequest request = new CreateRowRequest
            {
                Parent = "parent7858e4d0",
                Row = new Row(),
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row response = client.CreateRow(request.Parent, request.Row);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateRowAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            CreateRowRequest request = new CreateRowRequest
            {
                Parent = "parent7858e4d0",
                Row = new Row(),
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Row>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row responseCallSettings = await client.CreateRowAsync(request.Parent, request.Row, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Row responseCancellationToken = await client.CreateRowAsync(request.Parent, request.Row, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchCreateRowsRequestObject()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            BatchCreateRowsRequest request = new BatchCreateRowsRequest
            {
                Parent = "parent7858e4d0",
                Requests =
                {
                    new CreateRowRequest(),
                },
            };
            BatchCreateRowsResponse expectedResponse = new BatchCreateRowsResponse { Rows = { new Row(), }, };
            mockGrpcClient.Setup(x => x.BatchCreateRows(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateRowsResponse response = client.BatchCreateRows(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchCreateRowsRequestObjectAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            BatchCreateRowsRequest request = new BatchCreateRowsRequest
            {
                Parent = "parent7858e4d0",
                Requests =
                {
                    new CreateRowRequest(),
                },
            };
            BatchCreateRowsResponse expectedResponse = new BatchCreateRowsResponse { Rows = { new Row(), }, };
            mockGrpcClient.Setup(x => x.BatchCreateRowsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchCreateRowsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            BatchCreateRowsResponse responseCallSettings = await client.BatchCreateRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchCreateRowsResponse responseCancellationToken = await client.BatchCreateRowsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRowRequestObject()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            UpdateRowRequest request = new UpdateRowRequest
            {
                Row = new Row(),
                UpdateMask = new wkt::FieldMask(),
                View = View.ColumnIdView,
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row response = client.UpdateRow(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRowRequestObjectAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            UpdateRowRequest request = new UpdateRowRequest
            {
                Row = new Row(),
                UpdateMask = new wkt::FieldMask(),
                View = View.ColumnIdView,
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Row>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row responseCallSettings = await client.UpdateRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Row responseCancellationToken = await client.UpdateRowAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateRow()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            UpdateRowRequest request = new UpdateRowRequest
            {
                Row = new Row(),
                UpdateMask = new wkt::FieldMask(),
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row response = client.UpdateRow(request.Row, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateRowAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            UpdateRowRequest request = new UpdateRowRequest
            {
                Row = new Row(),
                UpdateMask = new wkt::FieldMask(),
            };
            Row expectedResponse = new Row
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                Values =
                {
                    {
                        "key8a0b6e3c",
                        new wkt::Value()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.UpdateRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Row>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            Row responseCallSettings = await client.UpdateRowAsync(request.Row, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Row responseCancellationToken = await client.UpdateRowAsync(request.Row, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchUpdateRowsRequestObject()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            BatchUpdateRowsRequest request = new BatchUpdateRowsRequest
            {
                Parent = "parent7858e4d0",
                Requests =
                {
                    new UpdateRowRequest(),
                },
            };
            BatchUpdateRowsResponse expectedResponse = new BatchUpdateRowsResponse { Rows = { new Row(), }, };
            mockGrpcClient.Setup(x => x.BatchUpdateRows(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            BatchUpdateRowsResponse response = client.BatchUpdateRows(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchUpdateRowsRequestObjectAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            BatchUpdateRowsRequest request = new BatchUpdateRowsRequest
            {
                Parent = "parent7858e4d0",
                Requests =
                {
                    new UpdateRowRequest(),
                },
            };
            BatchUpdateRowsResponse expectedResponse = new BatchUpdateRowsResponse { Rows = { new Row(), }, };
            mockGrpcClient.Setup(x => x.BatchUpdateRowsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchUpdateRowsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            BatchUpdateRowsResponse responseCallSettings = await client.BatchUpdateRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchUpdateRowsResponse responseCancellationToken = await client.BatchUpdateRowsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRowRequestObject()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            DeleteRowRequest request = new DeleteRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteRow(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRowRequestObjectAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            DeleteRowRequest request = new DeleteRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteRowAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteRowAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRow()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            DeleteRowRequest request = new DeleteRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteRow(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRowAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            DeleteRowRequest request = new DeleteRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteRowAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteRowAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRowResourceNames()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            DeleteRowRequest request = new DeleteRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRow(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteRow(request.RowName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRowResourceNamesAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            DeleteRowRequest request = new DeleteRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteRowAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteRowAsync(request.RowName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteRowAsync(request.RowName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchDeleteRowsRequestObject()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            BatchDeleteRowsRequest request = new BatchDeleteRowsRequest
            {
                ParentAsTableName = TableName.FromTable("[TABLE]"),
                RowNames =
                {
                    RowName.FromTableRow("[TABLE]", "[ROW]"),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteRows(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            client.BatchDeleteRows(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchDeleteRowsRequestObjectAsync()
        {
            moq::Mock<TablesService.TablesServiceClient> mockGrpcClient = new moq::Mock<TablesService.TablesServiceClient>(moq::MockBehavior.Strict);
            BatchDeleteRowsRequest request = new BatchDeleteRowsRequest
            {
                ParentAsTableName = TableName.FromTable("[TABLE]"),
                RowNames =
                {
                    RowName.FromTableRow("[TABLE]", "[ROW]"),
                },
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.BatchDeleteRowsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TablesServiceClient client = new TablesServiceClientImpl(mockGrpcClient.Object, null);
            await client.BatchDeleteRowsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.BatchDeleteRowsAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
