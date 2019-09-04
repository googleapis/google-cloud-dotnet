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

namespace Google.Cloud.Bigtable.Admin.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Bigtable.Admin.V2;
    using Google.Cloud.Bigtable.Common.V2;
    using Google.Cloud.Iam.V1;
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

    /// <summary>Generated unit tests</summary>
    public class GeneratedBigtableTableAdminClientTest
    {
        [Fact]
        public void CreateTable()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
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
        public void GetTable()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
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
        public void GetIamPolicy()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            Policy response = client.GetIamPolicy(formattedResource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            GetIamPolicyRequest expectedRequest = new GetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            Policy response = await client.GetIamPolicyAsync(formattedResource);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetIamPolicy2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = client.GetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetIamPolicyAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.GetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            Policy policy = new Policy();
            Policy response = client.SetIamPolicy(formattedResource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            SetIamPolicyRequest expectedRequest = new SetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            Policy policy = new Policy();
            Policy response = await client.SetIamPolicyAsync(formattedResource, policy);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SetIamPolicy2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = client.SetIamPolicy(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SetIamPolicyAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Policy = new Policy(),
            };
            Policy expectedResponse = new Policy
            {
                Version = 351608024,
                Etag = ByteString.CopyFromUtf8("etag3123477"),
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Policy>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            Policy response = await client.SetIamPolicyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = client.TestIamPermissions(formattedResource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            TestIamPermissionsRequest expectedRequest = new TestIamPermissionsRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(formattedResource, permissions);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void TestIamPermissions2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = client.TestIamPermissions(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task TestIamPermissionsAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient = new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Permissions = { },
            };
            TestIamPermissionsResponse expectedResponse = new TestIamPermissionsResponse();
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TestIamPermissionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            TestIamPermissionsResponse response = await client.TestIamPermissionsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
