// Copyright 2017 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Grpc;
using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Moq;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class BigtableClientTest
    {
        [Fact]
        public void AppProfileId()
        {
            var settings = new BigtableClient.ClientCreationSettings(credentials: ChannelCredentials.Insecure);
            var client = BigtableClient.Create(settings);
            Assert.Null(client.AppProfileId);

            client = client.WithAppProfileId("abc");
            Assert.Equal("abc", client.AppProfileId);

            client = BigtableClient.Create(settings, appProfileId: "xyz");
            Assert.Equal("xyz", client.AppProfileId);

            client = client.WithAppProfileId(null);
            Assert.Null(client.AppProfileId);
        }

        [Fact]
        public async Task CheckAndMutateRow_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");

            await CheckAndMutateRow_ValidateArguments<NotImplementedException>(
                tableName,
                "abc",
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new[] { Mutations.DeleteFromRow() });
        }

        [Fact]
        public void CheckAndMutateRow_AppProfileId()
        {
            var request = new CheckAndMutateRowRequest();
            Assert.Empty(request.AppProfileId);

            request.AppProfileId = "abc";
            Assert.Equal("abc", request.AppProfileId);

            request = new CheckAndMutateRowRequest { AppProfileId = "xyz" };
            Assert.Equal("xyz", request.AppProfileId);

            request.AppProfileId = string.Empty;
            Assert.Empty(request.AppProfileId);
        }

        [Fact]
        public async Task CheckAndMutateRow_AppProfileId_From_Client()
        {
            var appProfileId_on_client = "csharp";
            var appProfileId_on_request = "other";
            var request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = new TableName("project", "instance", "table"),
                RowKey = ByteString.CopyFromUtf8("abc"),
                FalseMutations = {new Mutation()},
                TrueMutations = {new Mutation()}
            };
            var request2 = new CheckAndMutateRowRequest(request);
            var request_with_appProfileId = new CheckAndMutateRowRequest(request) { AppProfileId = appProfileId_on_request };
            Mock<BigtableServiceApiClient> mockGrpcClient =
                new Mock<BigtableServiceApiClient>(MockBehavior.Strict);
            mockGrpcClient
                .Setup(x => x.CheckAndMutateRow(request, It.IsAny<CallSettings>()))
                .Returns(new CheckAndMutateRowResponse());
            mockGrpcClient
                .Setup(x => x.CheckAndMutateRow(request_with_appProfileId, It.IsAny<CallSettings>()))
                .Returns(new CheckAndMutateRowResponse());
            mockGrpcClient
                .Setup(x => x.CheckAndMutateRowAsync(request, It.IsAny<CallSettings>()))
                .ReturnsAsync(new CheckAndMutateRowResponse());
            mockGrpcClient
                .Setup(x => x.CheckAndMutateRowAsync(request_with_appProfileId, It.IsAny<CallSettings>()))
                .ReturnsAsync(new CheckAndMutateRowResponse());
            BigtableClient client = new BigtableClientImpl(
                new[] { mockGrpcClient.Object }, appProfileId_on_client, BigtableServiceApiSettings.GetDefault());
            client.CheckAndMutateRow(request);
            await client.CheckAndMutateRowAsync(request2);
            Assert.Equal(appProfileId_on_client, request.AppProfileId);
            Assert.Equal(appProfileId_on_client, request2.AppProfileId);
            client.CheckAndMutateRow(request_with_appProfileId);
            Assert.NotEqual(appProfileId_on_client, request_with_appProfileId.AppProfileId);
            Assert.Equal(appProfileId_on_request, request_with_appProfileId.AppProfileId);
            await client.CheckAndMutateRowAsync(request_with_appProfileId);
            Assert.NotEqual(appProfileId_on_client, request_with_appProfileId.AppProfileId);
            Assert.Equal(appProfileId_on_request, request_with_appProfileId.AppProfileId);
        }

        [Fact]
        public async Task CheckAndMutateRow_Validate_TableName()
        {
            await CheckAndMutateRow_ValidateArguments<ArgumentNullException>(
                null,
                "abc",
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new[] { Mutations.DeleteFromRow() });
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidRowKeys), MemberType = typeof(TestData))]
        public async Task CheckAndMutateRow_Validate_RowKey(BigtableByteString rowKey)
        {
            var tableName = new TableName("project", "instance", "table");
            await CheckAndMutateRow_ValidateArguments<ArgumentException>(
                tableName,
                rowKey,
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new[] { Mutations.DeleteFromRow() });
        }

        [Fact]
        public async Task CheckAndMutateRow_Validate_Mutations()
        {
            var tableName = new TableName("project", "instance", "table");
            await CheckAndMutateRow_ValidateArguments<ArgumentException>(
                tableName,
                "abc",
                RowFilters.PassAllFilter(),
                null,
                null);
            await CheckAndMutateRow_ValidateArguments<ArgumentException>(
                tableName,
                "abc",
                RowFilters.PassAllFilter(),
                new Mutation[0],
                new Mutation[0]);
            await CheckAndMutateRow_ValidateArguments<ArgumentException>(
                tableName,
                "abc",
                RowFilters.PassAllFilter(),
                new Mutation[] { null },
                new[] { Mutations.DeleteFromRow() },
                callTrueMutationsOnlyOverload: false);
            await CheckAndMutateRow_ValidateArguments<ArgumentException>(
                tableName,
                "abc",
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new Mutation[] { null },
                callTrueMutationsOnlyOverload: false);
        }

        private async Task CheckAndMutateRow_ValidateArguments<TException>(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            bool callTrueMutationsOnlyOverload = true)
            where TException : Exception
        {
            var client = new MockBigtableClient();
            if (callTrueMutationsOnlyOverload)
            {
                Assert.Throws<TException>(
                    () => client.CheckAndMutateRow(
                        tableName, rowKey, predicateFilter, trueMutations?.ToArray()));
            }
            Assert.Throws<TException>(
                () => client.CheckAndMutateRow(
                    tableName, rowKey, predicateFilter, trueMutations, falseMutations, CallSettings.FromCancellationToken(default)));

            if (callTrueMutationsOnlyOverload)
            {
                await Assert.ThrowsAsync<TException>(
                    () => client.CheckAndMutateRowAsync(
                        tableName, rowKey, predicateFilter, trueMutations?.ToArray()));
            }
            await Assert.ThrowsAsync<TException>(
                () => client.CheckAndMutateRowAsync(
                    tableName, rowKey, predicateFilter, trueMutations, falseMutations, CallSettings.FromCancellationToken(default)));
        }

        [Fact]
        public async Task MutateRow_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");

            await MutateRow_ValidateArguments<NotImplementedException>(tableName, "abc", new[] { Mutations.DeleteFromRow() });
        }

        [Fact]
        public void MutateRow_AppProfileId()
        {
            var request = new MutateRowRequest();
            Assert.Empty(request.AppProfileId);

            request.AppProfileId = "abc";
            Assert.Equal("abc", request.AppProfileId);

            request = new MutateRowRequest{AppProfileId = "xyz"};
            Assert.Equal("xyz", request.AppProfileId);

            request.AppProfileId = string.Empty;
            Assert.Empty(request.AppProfileId);
        }

        [Fact]
        public async Task MutateRow_AppProfileId_From_client()
        {
            var appProfileId_on_client = "csharp";
            var appProfileId_on_request = "other";
            var request = new MutateRowRequest
            {
                Mutations = {new Mutation()},
                RowKey = ByteString.CopyFromUtf8("abc"),
                TableNameAsTableName = new TableName("project", "instance", "table"),
            };
            var request2 = new MutateRowRequest(request);
            var request_with_appProfileId = new MutateRowRequest(request) { AppProfileId = appProfileId_on_request };
            Mock<BigtableServiceApiClient> mockGrpcClient =
                new Mock<BigtableServiceApiClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.MutateRow(request, It.IsAny<CallSettings>()))
                .Returns(new MutateRowResponse());
            mockGrpcClient.Setup(x => x.MutateRow(request_with_appProfileId, It.IsAny<CallSettings>()))
                .Returns(new MutateRowResponse());
            mockGrpcClient.Setup(x => x.MutateRowAsync(request, It.IsAny<CallSettings>()))
                .ReturnsAsync(new MutateRowResponse());
            mockGrpcClient.Setup(x => x.MutateRowAsync(request_with_appProfileId, It.IsAny<CallSettings>()))
                .ReturnsAsync(new MutateRowResponse());
            BigtableClient client = new BigtableClientImpl(
                new[] {mockGrpcClient.Object}, appProfileId_on_client, BigtableServiceApiSettings.GetDefault());
            client.MutateRow(request);
            await client.MutateRowAsync(request2);
            Assert.Equal(appProfileId_on_client, request.AppProfileId);
            Assert.Equal(appProfileId_on_client, request2.AppProfileId);
            client.MutateRow(request_with_appProfileId);
            Assert.NotEqual(appProfileId_on_client, request_with_appProfileId.AppProfileId);
            Assert.Equal(appProfileId_on_request, request_with_appProfileId.AppProfileId);
            await client.MutateRowAsync(request_with_appProfileId);
            Assert.NotEqual(appProfileId_on_client, request_with_appProfileId.AppProfileId);
            Assert.Equal(appProfileId_on_request, request_with_appProfileId.AppProfileId);
        }

        [Fact]
        public async Task MutateRow_Validate_TableName()
        {
            await MutateRow_ValidateArguments<ArgumentNullException>(null, "abc", new[] { Mutations.DeleteFromRow() });
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidRowKeys), MemberType = typeof(TestData))]
        public async Task MutateRow_Validate_RowKey(BigtableByteString rowKey)
        {
            var tableName = new TableName("project", "instance", "table");
            await MutateRow_ValidateArguments<ArgumentException>(tableName, rowKey, new[] { Mutations.DeleteFromRow() });
        }

        [Fact]
        public async Task MutateRow_Validate_Mutations()
        {
            var tableName = new TableName("project", "instance", "table");
            await MutateRow_ValidateArguments<ArgumentNullException>(tableName, "abc", null);
            await MutateRow_ValidateArguments<ArgumentException>(tableName, "abc", new Mutation[0]);
            await MutateRow_ValidateArguments<ArgumentException>(tableName, "abc", new Mutation[] { null });
        }

        private async Task MutateRow_ValidateArguments<TException>(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<Mutation> mutations)
            where TException : Exception
        {
            var client = new MockBigtableClient();
            Assert.Throws<TException>(
                () => client.MutateRow(tableName, rowKey, mutations?.ToArray()));
            Assert.Throws<TException>(
                () => client.MutateRow(tableName, rowKey, mutations, CallSettings.FromCancellationToken(default)));
            await Assert.ThrowsAsync<TException>(
                () => client.MutateRowAsync(tableName, rowKey, mutations?.ToArray()));
            await Assert.ThrowsAsync<TException>(
                () => client.MutateRowAsync(tableName, rowKey, mutations, CallSettings.FromCancellationToken(default)));
        }

        [Fact]
        public async Task MutateRows_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");
            await MutateRows_ValidateArguments<NotImplementedException>(
                tableName,
                new[] { Mutations.CreateEntry("abc", Mutations.DeleteFromRow()) });
        }

        [Fact]
        public void MutateRows_AppProfileId()
        {
            var request = new MutateRowsRequest();
            Assert.Empty(request.AppProfileId);

            request.AppProfileId = "abc";
            Assert.Equal("abc", request.AppProfileId);

            request = new MutateRowsRequest{AppProfileId = "xyz"};
            Assert.Equal("xyz", request.AppProfileId);

            request.AppProfileId = string.Empty;
            Assert.Empty(request.AppProfileId);
        }

        [Fact]
        public void MutateRows_AppProfileId_From_client()
        {
            var appProfileId_on_client = "csharp";
            var appProfileId_on_request = "other";
            var request = new MutateRowsRequest
            {
                Entries ={Mutations.CreateEntry("abc", new Mutation())},
                TableNameAsTableName = new TableName("project", "instance", "table")
            };
            var request_with_appProfileId = new MutateRowsRequest(request) { AppProfileId = appProfileId_on_request };
            Mock<BigtableServiceApiClient> mockGrpcClient =
                new Mock<BigtableServiceApiClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.MutateRows(request, It.IsAny<CallSettings>()))
                .Returns(new BigtableServiceApiClientImpl.MutateRowsStreamImpl(null));
            mockGrpcClient.Setup(x => x.MutateRows(request_with_appProfileId, It.IsAny<CallSettings>()))
                .Returns(new BigtableServiceApiClientImpl.MutateRowsStreamImpl(null));
            BigtableClient client = new BigtableClientImpl(
                new[] { mockGrpcClient.Object }, appProfileId_on_client, BigtableServiceApiSettings.GetDefault());
            client.MutateRowsAsync(request);
            Assert.Equal(appProfileId_on_client, request.AppProfileId);
            client.MutateRowsAsync(request);
            Assert.NotEqual(appProfileId_on_client, request_with_appProfileId.AppProfileId);
            Assert.Equal(appProfileId_on_request, request_with_appProfileId.AppProfileId);
        }

        [Fact]
        public async Task MutateRows_Validate_TableName()
        {
            await MutateRows_ValidateArguments<ArgumentNullException>(
                null,
                new[] { Mutations.CreateEntry("abc", Mutations.DeleteFromRow()) });
        }

        [Fact]
        public async Task MutateRows_Validate_Mutations()
        {
            var tableName = new TableName("project", "instance", "table");
            await MutateRows_ValidateArguments<ArgumentNullException>(tableName, null);
            await MutateRows_ValidateArguments<ArgumentException>(tableName, new MutateRowsRequest.Types.Entry[0]);
            await MutateRows_ValidateArguments<ArgumentException>(tableName, new MutateRowsRequest.Types.Entry[] { null });
        }

        private async Task MutateRows_ValidateArguments<TException>(
            TableName tableName,
            IEnumerable<MutateRowsRequest.Types.Entry> entries)
            where TException : Exception
        {
            var client = new MockBigtableClient();
            await Assert.ThrowsAsync<TException>(
                () => client.MutateRowsAsync(tableName, entries?.ToArray()));
            await Assert.ThrowsAsync<TException>(
                () => client.MutateRowsAsync(tableName, entries, CallSettings.FromCancellationToken(default)));
        }

        [Fact]
        public async Task ReadModifyWriteRow_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");
            await ReadModifyWriteRow_ValidateArguments<NotImplementedException>(
                tableName, "abc", new[] { ReadModifyWriteRules.Append("a", "b", "c") });
        }

        [Fact]
        public void ReadModifyWriteRow_AppProfileId()
        {
            var request = new ReadModifyWriteRowRequest();
            Assert.Empty(request.AppProfileId);

            request.AppProfileId = "abc";
            Assert.Equal("abc", request.AppProfileId);

            request = new ReadModifyWriteRowRequest { AppProfileId = "xyz" };
            Assert.Equal("xyz", request.AppProfileId);

            request.AppProfileId = string.Empty;
            Assert.Empty(request.AppProfileId);
        }

        [Fact]
        public async Task ReadModifyWriteRow_AppProfileId_From_Client()
        {
            var appProfileId_on_client = "csharp";
            var appProfileId_on_request = "other";
            var request = new ReadModifyWriteRowRequest
            {
                RowKey = ByteString.CopyFromUtf8("abc"),
                TableNameAsTableName = new TableName("project", "instance", "table"),
                Rules = { ReadModifyWriteRules.Append("familyName", "CQ1", "Append")}
            };
            var request2 = new ReadModifyWriteRowRequest(request);
            var request_with_appProfileId = new ReadModifyWriteRowRequest(request) { AppProfileId = appProfileId_on_request };
            Mock<BigtableServiceApiClient> mockGrpcClient =
                new Mock<BigtableServiceApiClient>(MockBehavior.Strict);
            mockGrpcClient
                .Setup(x => x.ReadModifyWriteRow(request, It.IsAny<CallSettings>()))
                .Returns(new ReadModifyWriteRowResponse());
            mockGrpcClient
                .Setup(x => x.ReadModifyWriteRow(request_with_appProfileId, It.IsAny<CallSettings>()))
                .Returns(new ReadModifyWriteRowResponse());
            mockGrpcClient
                 .Setup(x => x.ReadModifyWriteRowAsync(request, It.IsAny<CallSettings>()))
                .ReturnsAsync(new ReadModifyWriteRowResponse());
            mockGrpcClient
                .Setup(x => x.ReadModifyWriteRowAsync(request_with_appProfileId, It.IsAny<CallSettings>()))
                .ReturnsAsync(new ReadModifyWriteRowResponse());
            BigtableClient client = new BigtableClientImpl(
                new[] { mockGrpcClient.Object }, appProfileId_on_client, BigtableServiceApiSettings.GetDefault());
            client.ReadModifyWriteRow(request);
            await client.ReadModifyWriteRowAsync(request2);
            Assert.Equal(appProfileId_on_client, request.AppProfileId);
            Assert.Equal(appProfileId_on_client, request2.AppProfileId);
            client.ReadModifyWriteRow(request_with_appProfileId);
            Assert.NotEqual(appProfileId_on_client, request_with_appProfileId.AppProfileId);
            Assert.Equal(appProfileId_on_request, request_with_appProfileId.AppProfileId);
            await client.ReadModifyWriteRowAsync(request_with_appProfileId);
            Assert.NotEqual(appProfileId_on_client, request_with_appProfileId.AppProfileId);
            Assert.Equal(appProfileId_on_request, request_with_appProfileId.AppProfileId);
        }

        [Fact]
        public async Task ReadModifyWriteRow_Validate_TableName()
        {
            await ReadModifyWriteRow_ValidateArguments<ArgumentNullException>(
                null, "abc", new[] { ReadModifyWriteRules.Append("a", "b", "c") });
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidRowKeys), MemberType = typeof(TestData))]
        public async Task ReadModifyWriteRow_Validate_RowKey(BigtableByteString rowKey)
        {
            var tableName = new TableName("project", "instance", "table");
            await ReadModifyWriteRow_ValidateArguments<ArgumentException>(
                tableName, rowKey, new[] { ReadModifyWriteRules.Append("a", "b", "c") });
        }

        [Fact]
        public async Task ReadModifyWriteRow_Validate_Rules()
        {
            var tableName = new TableName("project", "instance", "table");
            await ReadModifyWriteRow_ValidateArguments<ArgumentNullException>(tableName, "abc", null);
            await ReadModifyWriteRow_ValidateArguments<ArgumentException>(tableName, "abc", new ReadModifyWriteRule[0]);
            await ReadModifyWriteRow_ValidateArguments<ArgumentException>(tableName, "abc", new ReadModifyWriteRule[] { null });
        }

        private async Task ReadModifyWriteRow_ValidateArguments<TException>(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules)
            where TException : Exception
        {
            var client = new MockBigtableClient();
            Assert.Throws<TException>(
                () => client.ReadModifyWriteRow(tableName, rowKey, rules?.ToArray()));
            Assert.Throws<TException>(
                () => client.ReadModifyWriteRow(tableName, rowKey, rules, CallSettings.FromCancellationToken(default)));
            await Assert.ThrowsAsync<TException>(
                () => client.ReadModifyWriteRowAsync(tableName, rowKey, rules?.ToArray()));
            await Assert.ThrowsAsync<TException>(
                () => client.ReadModifyWriteRowAsync(tableName, rowKey, rules, CallSettings.FromCancellationToken(default)));
        }

        [Fact]
        public async Task ReadRow_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");
            await ReadRow_ValidateArguments<NotImplementedException>(tableName, "abc", null);
            await ReadRow_ValidateArguments<NotImplementedException>(tableName, "abc", RowFilters.CellsPerColumnLimit(1));
        }

        [Fact]
        public async Task ReadRow_Validate_TableName()
        {
            await ReadRow_ValidateArguments<ArgumentNullException>(null, "abc", null);
        }

        [Theory]
        [MemberData(nameof(TestData.InvalidRowKeys), MemberType = typeof(TestData))]
        public async Task ReadRow_Validate_RowKey(BigtableByteString rowKey)
        {
            var tableName = new TableName("project", "instance", "table");
            await ReadRow_ValidateArguments<ArgumentException>(tableName, rowKey, null);
        }

        private async Task ReadRow_ValidateArguments<TException>(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter filter)
            where TException : Exception
        {
            var client = new MockBigtableClient();
            Assert.Throws<TException>(
                () => client.ReadRow(tableName, rowKey, filter));
            await Assert.ThrowsAsync<TException>(
                () => client.ReadRowAsync(tableName, rowKey, filter));
        }

        [Fact]
        public async Task ReadRows_Family_Order()
        {
            var request = new ReadRowsRequest
            {
                Rows = RowSet.FromRowRanges(RowRange.Closed("a", "z"))
            };
            var client = Utilities.CreateReadRowsMockClient(
                request,
                initialStreamResponse: new[]
                {
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            new ReadRowsResponse.Types.CellChunk
                            {
                                RowKey = ByteString.CopyFromUtf8("abc"),
                                FamilyName = "z",
                                Qualifier = ByteString.CopyFromUtf8("column1"),
                                Value = ByteString.CopyFromUtf8("value1")
                            },
                            new ReadRowsResponse.Types.CellChunk
                            {
                                RowKey = ByteString.CopyFromUtf8("abc"),
                                FamilyName = "A",
                                Qualifier = ByteString.CopyFromUtf8("column2"),
                                Value = ByteString.CopyFromUtf8("value2")
                            }
                        }
                    },
                    new ReadRowsResponse
                    {
                        Chunks =
                        {
                            new ReadRowsResponse.Types.CellChunk
                            {
                                RowKey = ByteString.CopyFromUtf8("abc"),
                                FamilyName = "a",
                                Qualifier = ByteString.CopyFromUtf8("column3"),
                                Value = ByteString.CopyFromUtf8("value3")
                            },
                            new ReadRowsResponse.Types.CellChunk
                            {
                                RowKey = ByteString.CopyFromUtf8("abc"),
                                FamilyName = "Z",
                                Qualifier = ByteString.CopyFromUtf8("column4"),
                                Value = ByteString.CopyFromUtf8("value4"),
                                CommitRow = true
                            }
                        }
                    }
                });
            var stream = client.ReadRows(request);

            int rowCount = 0;
            await stream.ForEachAsync(row =>
            {
                rowCount++;

                var family = row.Families[0];
                Assert.Equal("A", family.Name);
                Assert.Equal("column2", family.Columns[0].Qualifier.ToStringUtf8());
                Assert.Equal("value2", family.Columns[0].Cells[0].Value.ToStringUtf8());
                family = row.Families[1];
                Assert.Equal("Z", family.Name);
                Assert.Equal("column4", family.Columns[0].Qualifier.ToStringUtf8());
                Assert.Equal("value4", family.Columns[0].Cells[0].Value.ToStringUtf8());
                family = row.Families[2];
                Assert.Equal("a", family.Name);
                Assert.Equal("column3", family.Columns[0].Qualifier.ToStringUtf8());
                Assert.Equal("value3", family.Columns[0].Cells[0].Value.ToStringUtf8());
                family = row.Families[3];
                Assert.Equal("z", family.Name);
                Assert.Equal("column1", family.Columns[0].Qualifier.ToStringUtf8());
                Assert.Equal("value1", family.Columns[0].Cells[0].Value.ToStringUtf8());
            });
            Assert.Equal(1, rowCount);
        }

        [Fact]
        public void ReadRows_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");

            ReadRows_ValidateArguments<NotImplementedException>(tableName, null, null, null);
            ReadRows_ValidateArguments<NotImplementedException>(
                tableName,
                RowSet.FromRowKey("abc"),
                RowFilters.BlockAllFilter(),
                0);
            ReadRows_ValidateArguments<NotImplementedException>(
                tableName,
                RowSet.FromRowRanges(RowRange.ClosedOpen("", "z")),
                RowFilters.CellsPerRowLimit(1),
                123);
        }

        [Fact]
        public void ReadRows_AppProfileId()
        {
            var request = new ReadRowsRequest();
            Assert.Empty(request.AppProfileId);

            request.AppProfileId = "abc";
            Assert.Equal("abc", request.AppProfileId);

            request = new ReadRowsRequest { AppProfileId = "xyz" };
            Assert.Equal("xyz", request.AppProfileId);

            request.AppProfileId = string.Empty;
            Assert.Empty(request.AppProfileId);

        }

        [Fact]
        public void ReadRows_AppProfileId_From_Client()
        {
            var appProfileId_on_client = "csharp";
            var appProfileId_on_request = "other";
            var request =
                new ReadRowsRequest {TableNameAsTableName = new TableName("project", "instance", "table")};
            var request_with_appProfileId = new ReadRowsRequest(request) { AppProfileId = appProfileId_on_request };
            Mock<BigtableServiceApiClient> mockGrpcClient =
                new Mock<BigtableServiceApiClient>(MockBehavior.Strict);
            mockGrpcClient
                .Setup(x => x.ReadRows(request, It.IsAny<CallSettings>()))
                .Returns(new BigtableServiceApiClientImpl.ReadRowsStreamImpl(null));
            mockGrpcClient
                .Setup(x => x.ReadRows(request_with_appProfileId, It.IsAny<CallSettings>()))
                .Returns(new BigtableServiceApiClientImpl.ReadRowsStreamImpl(null));
            BigtableClient client = new BigtableClientImpl(
                new[] { mockGrpcClient.Object }, appProfileId_on_client, BigtableServiceApiSettings.GetDefault());
            client.ReadRows(request);
            Assert.Equal(appProfileId_on_client, request.AppProfileId);
            client.ReadRows(request_with_appProfileId);
            Assert.NotEqual(appProfileId_on_client, request_with_appProfileId.AppProfileId);
            Assert.Equal(appProfileId_on_request, request_with_appProfileId.AppProfileId);
        }

        [Fact]
        public void ReadRows_Validate_TableName()
        {
            var rows = RowSet.FromRowKey("abc");
            ReadRows_ValidateArguments<ArgumentNullException>(null, rows, null, null);
        }

        [Fact]
        public void ReadRows_Validate_RowsLimit()
        {
            var tableName = new TableName("project", "instance", "table");
            var rows = RowSet.FromRowKey("abc");
            ReadRows_ValidateArguments<ArgumentOutOfRangeException>(tableName, rows, null, -1);
        }

        private void ReadRows_ValidateArguments<TException>(
            TableName tableName,
            RowSet rows,
            RowFilter filter,
            long? rowsLimit)
            where TException : Exception
        {
            var client = new MockBigtableClient();
            Assert.Throws<TException>(
                () => client.ReadRows(tableName, rows, filter, rowsLimit));
        }

        [Fact]
        public void SampleRowKeys_Valid_Request()
        {
            var client = new MockBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            Assert.Throws<NotImplementedException>(() => client.SampleRowKeys(tableName));
        }

        [Fact]
        public void SampleRowKeys_AppProfileId()
        {
            var request = new SampleRowKeysRequest();
            Assert.Empty(request.AppProfileId);

            request.AppProfileId = "abc";
            Assert.Equal("abc", request.AppProfileId);

            request = new SampleRowKeysRequest { AppProfileId = "xyz" };
            Assert.Equal("xyz", request.AppProfileId);

            request.AppProfileId = string.Empty;
            Assert.Empty(request.AppProfileId);

        }

        [Fact]
        public void SampleRowKeys_AppProfileId_From_client()
        {
            var appProfileId_on_client = "csharp";
            var appProfileId_on_request = "other";
            var request = new SampleRowKeysRequest
            {
                TableNameAsTableName = new TableName("project", "instance", "table"),
            };
            var request_with_appProfileId = new SampleRowKeysRequest(request) { AppProfileId = appProfileId_on_request };
            Mock<BigtableServiceApiClient> mockGrpcClient =
                new Mock<BigtableServiceApiClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.SampleRowKeys(request, It.IsAny<CallSettings>()))
                .Returns(new BigtableServiceApiClientImpl.SampleRowKeysStreamImpl(null));
            mockGrpcClient.Setup(x => x.SampleRowKeys(request_with_appProfileId, It.IsAny<CallSettings>()))
                .Returns(new BigtableServiceApiClientImpl.SampleRowKeysStreamImpl(null));
            BigtableClient client = new BigtableClientImpl(
                new[] { mockGrpcClient.Object }, appProfileId_on_client, BigtableServiceApiSettings.GetDefault());
            client.SampleRowKeys(request);
            Assert.Equal(appProfileId_on_client, request.AppProfileId);
            client.SampleRowKeys(request_with_appProfileId);
            Assert.NotEqual(appProfileId_on_client, request_with_appProfileId.AppProfileId);
            Assert.Equal(appProfileId_on_request, request_with_appProfileId.AppProfileId);
        }

        [Fact]
        public void SampleRowKeys_Validate_TableName()
        {
            var client = new MockBigtableClient();
            Assert.Throws<ArgumentNullException>(() => client.SampleRowKeys((TableName)null));
        }
    }
}
