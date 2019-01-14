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

namespace Google.Cloud.Bigtable.V2.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Bigtable.Common.V2;
    using apis = Google.Cloud.Bigtable.V2;
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
    public class GeneratedBigtableServiceApiClientTest
    {
        [Fact]
        public void MutateRow()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            MutateRowRequest expectedRequest = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                Mutations = { },
            };
            MutateRowResponse expectedResponse = new MutateRowResponse();
            mockGrpcClient.Setup(x => x.MutateRow(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("122");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            MutateRowResponse response = client.MutateRow(tableName, rowKey, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task MutateRowAsync()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            MutateRowRequest expectedRequest = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                Mutations = { },
            };
            MutateRowResponse expectedResponse = new MutateRowResponse();
            mockGrpcClient.Setup(x => x.MutateRowAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateRowResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("122");
            IEnumerable<Mutation> mutations = new List<Mutation>();
            MutateRowResponse response = await client.MutateRowAsync(tableName, rowKey, mutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void MutateRow2()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                Mutations = { },
            };
            MutateRowResponse expectedResponse = new MutateRowResponse();
            mockGrpcClient.Setup(x => x.MutateRow(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse response = client.MutateRow(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task MutateRowAsync2()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            MutateRowRequest request = new MutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                Mutations = { },
            };
            MutateRowResponse expectedResponse = new MutateRowResponse();
            mockGrpcClient.Setup(x => x.MutateRowAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateRowResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            MutateRowResponse response = await client.MutateRowAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckAndMutateRow()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            CheckAndMutateRowRequest expectedRequest = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                PredicateFilter = new RowFilter(),
                TrueMutations = { },
                FalseMutations = { },
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRow(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("122");
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            CheckAndMutateRowResponse response = client.CheckAndMutateRow(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CheckAndMutateRowAsync()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            CheckAndMutateRowRequest expectedRequest = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                PredicateFilter = new RowFilter(),
                TrueMutations = { },
                FalseMutations = { },
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRowAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CheckAndMutateRowResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("122");
            RowFilter predicateFilter = new RowFilter();
            IEnumerable<Mutation> trueMutations = new List<Mutation>();
            IEnumerable<Mutation> falseMutations = new List<Mutation>();
            CheckAndMutateRowResponse response = await client.CheckAndMutateRowAsync(tableName, rowKey, predicateFilter, trueMutations, falseMutations);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CheckAndMutateRow2()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRow(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse response = client.CheckAndMutateRow(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CheckAndMutateRowAsync2()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            CheckAndMutateRowRequest request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
            };
            CheckAndMutateRowResponse expectedResponse = new CheckAndMutateRowResponse
            {
                PredicateMatched = true,
            };
            mockGrpcClient.Setup(x => x.CheckAndMutateRowAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CheckAndMutateRowResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            CheckAndMutateRowResponse response = await client.CheckAndMutateRowAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ReadModifyWriteRow()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            ReadModifyWriteRowRequest expectedRequest = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                Rules = { },
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse();
            mockGrpcClient.Setup(x => x.ReadModifyWriteRow(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("122");
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            ReadModifyWriteRowResponse response = client.ReadModifyWriteRow(tableName, rowKey, rules);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReadModifyWriteRowAsync()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            ReadModifyWriteRowRequest expectedRequest = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                Rules = { },
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse();
            mockGrpcClient.Setup(x => x.ReadModifyWriteRowAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReadModifyWriteRowResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            TableName tableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ByteString rowKey = ByteString.CopyFromUtf8("122");
            IEnumerable<ReadModifyWriteRule> rules = new List<ReadModifyWriteRule>();
            ReadModifyWriteRowResponse response = await client.ReadModifyWriteRowAsync(tableName, rowKey, rules);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ReadModifyWriteRow2()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                Rules = { },
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse();
            mockGrpcClient.Setup(x => x.ReadModifyWriteRow(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse response = client.ReadModifyWriteRow(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReadModifyWriteRowAsync2()
        {
            Mock<Bigtable.BigtableClient> mockGrpcClient = new Mock<Bigtable.BigtableClient>(MockBehavior.Strict);
            ReadModifyWriteRowRequest request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKey = ByteString.CopyFromUtf8("122"),
                Rules = { },
            };
            ReadModifyWriteRowResponse expectedResponse = new ReadModifyWriteRowResponse();
            mockGrpcClient.Setup(x => x.ReadModifyWriteRowAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReadModifyWriteRowResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BigtableServiceApiClient client = new BigtableServiceApiClientImpl(mockGrpcClient.Object, null);
            ReadModifyWriteRowResponse response = await client.ReadModifyWriteRowAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
