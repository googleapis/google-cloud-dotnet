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
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2.Requests;
using Xunit;

namespace Google.Cloud.Bigtable.Admin.V2.Tests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedBigtableTableAdminClientTest
    {
        [Fact]
        public void CreateTable()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateTableRequest expectedRequest = new CreateTableRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                TableId = "tableId-895419604",
                Table = new Table(),
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.CreateTable(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string tableId = "tableId-895419604";
            Table table = new Table();
            Table response = client.CreateTable(parent, tableId, table);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTableAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateTableRequest expectedRequest = new CreateTableRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                TableId = "tableId-895419604",
                Table = new Table(),
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.CreateTableAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Table>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string tableId = "tableId-895419604";
            Table table = new Table();
            Table response = await client.CreateTableAsync(parent, tableId, table);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateTable2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                TableId = "tableId-895419604",
                Table = new Table(),
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.CreateTable(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.CreateTable(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateTableAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                TableId = "tableId-895419604",
                Table = new Table(),
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.CreateTableAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Table>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = await client.CreateTableAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListTables()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient =
                new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListTablesRequest expectedRequest = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Table expectedTableResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            ListTablesResponse expextedListTablesResponse = new ListTablesResponse
            {
                Tables = { expectedTableResponse }
            };
            mockGrpcClient.Setup(x => x.ListTables(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expextedListTablesResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            PagedEnumerable<ListTablesResponse, Table> response = client.ListTables(name);
            Assert.Same(expectedTableResponse, response.Single());
            Assert.Same(expextedListTablesResponse, response.AsRawResponses().ToList().Single());
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListTablesAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient =
                new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListTablesRequest expectedRequest = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Table expectedTableResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            ListTablesResponse expextedListTablesResponse = new ListTablesResponse
            {
                Tables = { expectedTableResponse }
            };
            mockGrpcClient.Setup(x => x.ListTablesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListTablesResponse>(Task.FromResult(expextedListTablesResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            PagedAsyncEnumerable<ListTablesResponse, Table> responseAsync = client.ListTablesAsync(name);
            Assert.Same(expectedTableResponse, await responseAsync.Single());
            List<ListTablesResponse> response = await responseAsync.AsRawResponses().ToList();
            Assert.Same(expextedListTablesResponse, response.Single());
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListTables2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient =
                new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListTablesRequest request = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Table expectedTableResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            ListTablesResponse expextedListTablesResponse = new ListTablesResponse
            {
                Tables = {expectedTableResponse}
            };
            mockGrpcClient.Setup(x => x.ListTables(request, It.IsAny<CallOptions>()))
                .Returns(expextedListTablesResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            PagedEnumerable<ListTablesResponse, Table> response = client.ListTables(request);
            Assert.Same(expectedTableResponse, response.Single());
            Assert.Same(expextedListTablesResponse, response.AsRawResponses().ToList().Single());
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListTablesAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient =
                new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListTablesRequest request = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Table expectedTableResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            ListTablesResponse expextedListTablesResponse = new ListTablesResponse
            {
                Tables = { expectedTableResponse }
            };
            mockGrpcClient.Setup(x => x.ListTablesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListTablesResponse>(Task.FromResult(expextedListTablesResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            PagedAsyncEnumerable<ListTablesResponse, Table> responseAsync = client.ListTablesAsync(request);
            Assert.Same(expectedTableResponse, await responseAsync.Single());
            List<ListTablesResponse> response = await responseAsync.AsRawResponses().ToList();
            Assert.Same(expextedListTablesResponse, response.Single());
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTable()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetTableRequest expectedRequest = new GetTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.GetTable(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            Table response = client.GetTable(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTableAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetTableRequest expectedRequest = new GetTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.GetTableAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Table>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            Table response = await client.GetTableAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetTable2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetTableRequest request = new GetTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.GetTable(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.GetTable(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetTableAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetTableRequest request = new GetTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.GetTableAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Table>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = await client.GetTableAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTable()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteTableRequest expectedRequest = new DeleteTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTable(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            client.DeleteTable(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTableAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteTableRequest expectedRequest = new DeleteTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTableAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            await client.DeleteTableAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteTable2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTable(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteTable(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteTableAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteTableAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTableAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ModifyColumnFamilies()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest expectedRequest = new ModifyColumnFamiliesRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications = { },
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamilies(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications = new List<ModifyColumnFamiliesRequest.Types.Modification>();
            Table response = client.ModifyColumnFamilies(name, modifications);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ModifyColumnFamiliesAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest expectedRequest = new ModifyColumnFamiliesRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications = { },
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamiliesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Table>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications = new List<ModifyColumnFamiliesRequest.Types.Modification>();
            Table response = await client.ModifyColumnFamiliesAsync(name, modifications);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ModifyColumnFamilies2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications = { },
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamilies(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = client.ModifyColumnFamilies(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ModifyColumnFamiliesAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications = { },
            };
            Table expectedResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            mockGrpcClient.Setup(x => x.ModifyColumnFamiliesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Table>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Table response = await client.ModifyColumnFamiliesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DropRowRange()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DropRowRange(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DropRowRange(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DropRowRangeAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DropRowRangeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DropRowRangeAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GenerateConsistencyToken()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest expectedRequest = new GenerateConsistencyTokenRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistencyToken-1090516718",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyToken(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            GenerateConsistencyTokenResponse response = client.GenerateConsistencyToken(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GenerateConsistencyTokenAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest expectedRequest = new GenerateConsistencyTokenRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistencyToken-1090516718",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyTokenAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateConsistencyTokenResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            GenerateConsistencyTokenResponse response = await client.GenerateConsistencyTokenAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GenerateConsistencyToken2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistencyToken-1090516718",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyToken(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            GenerateConsistencyTokenResponse response = client.GenerateConsistencyToken(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GenerateConsistencyTokenAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            GenerateConsistencyTokenResponse expectedResponse = new GenerateConsistencyTokenResponse
            {
                ConsistencyToken = "consistencyToken-1090516718",
            };
            mockGrpcClient.Setup(x => x.GenerateConsistencyTokenAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateConsistencyTokenResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            GenerateConsistencyTokenResponse response = await client.GenerateConsistencyTokenAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckConsistency()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CheckConsistencyRequest expectedRequest = new CheckConsistencyRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistencyToken-1090516718",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse
            {
                Consistent = true,
            };
            mockGrpcClient.Setup(x => x.CheckConsistency(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string consistencyToken = "consistencyToken-1090516718";
            CheckConsistencyResponse response = client.CheckConsistency(name, consistencyToken);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CheckConsistencyAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CheckConsistencyRequest expectedRequest = new CheckConsistencyRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistencyToken-1090516718",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse
            {
                Consistent = true,
            };
            mockGrpcClient.Setup(x => x.CheckConsistencyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CheckConsistencyResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string consistencyToken = "consistencyToken-1090516718";
            CheckConsistencyResponse response = await client.CheckConsistencyAsync(name, consistencyToken);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckConsistency2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistencyToken-1090516718",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse
            {
                Consistent = true,
            };
            mockGrpcClient.Setup(x => x.CheckConsistency(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            CheckConsistencyResponse response = client.CheckConsistency(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CheckConsistencyAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "consistencyToken-1090516718",
            };
            CheckConsistencyResponse expectedResponse = new CheckConsistencyResponse
            {
                Consistent = true,
            };
            mockGrpcClient.Setup(x => x.CheckConsistencyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CheckConsistencyResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            CheckConsistencyResponse response = await client.CheckConsistencyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSnapshot()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSnapshotRequest expectedRequest = new GetSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                DataSizeBytes = 2110122398L,
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetSnapshot(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            Snapshot response = client.GetSnapshot(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSnapshotAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSnapshotRequest expectedRequest = new GetSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                DataSizeBytes = 2110122398L,
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetSnapshotAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Snapshot>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            Snapshot response = await client.GetSnapshotAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSnapshot2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                DataSizeBytes = 2110122398L,
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetSnapshot(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Snapshot response = client.GetSnapshot(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSnapshotAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Snapshot expectedResponse = new Snapshot
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                DataSizeBytes = 2110122398L,
                Description = "description-1724546052",
            };
            mockGrpcClient.Setup(x => x.GetSnapshotAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Snapshot>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Snapshot response = await client.GetSnapshotAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSnapshot()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteSnapshotRequest expectedRequest = new DeleteSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSnapshot(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            client.DeleteSnapshot(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSnapshotAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteSnapshotRequest expectedRequest = new DeleteSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            await client.DeleteSnapshotAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSnapshot2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSnapshot(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteSnapshot(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSnapshotAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSnapshotAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSnapshotAsync(request);
            mockGrpcClient.VerifyAll();
        }
    }
}
