// Copyright 2017, Google Inc. All rights reserved.
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

using Grpc.Core;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [Collection(nameof(BigtableFixture))]
    public class MutateRowTest
    {
        private readonly BigtableFixture _fixture;

        public MutateRowTest(BigtableFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task AddNewRow()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "column_name",
                    "test12345",
                    new BigtableVersion(1)));

            await VerifySingleRowAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "column_name",
                "test12345",
                new BigtableVersion(1));
        }

        [Fact]
        public async Task AddNewRowAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.ColumnFamily1,
                        "column_name",
                        "test12345",
                        new BigtableVersion(1))
                });

            await VerifySingleRowAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "column_name",
                "test12345",
                new BigtableVersion(1));
        }
        
        [Fact]
        public async Task ModifyRow()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await InsertRowAsync(client, tableName, rowKey, new BigtableVersion(1));

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "modify_row_column",
                    "new_cell_value",
                    new BigtableVersion(1)));

            // TODO: Use cleaner API when available
            var response = client.ReadRows(new ReadRowsRequest
            {
                TableName = tableName.ToString(),
                Rows = new RowSet { RowKeys = { rowKey } }
            });

            await ModifyRow_VerifyResponse(rowKey, response);
        }

        [Fact]
        public async Task ModifyRowAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await InsertRowAsync(client, tableName, rowKey, new BigtableVersion(1));

            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.ColumnFamily1,
                        "modify_row_column",
                        "new_cell_value",
                        new BigtableVersion(1))
                });

            // TODO: Use cleaner API when available
            var response = client.ReadRows(new ReadRowsRequest
            {
                TableName = tableName.ToString(),
                Rows = new RowSet { RowKeys = { rowKey } }
            });

            await ModifyRow_VerifyResponse(rowKey, response);
        }

        private static async Task ModifyRow_VerifyResponse(
            BigtableByteString rowKey, BigtableClient.ReadRowsStream response)
        {
            while (await response.ResponseStream.MoveNext(default))
            {
                var current = response.ResponseStream.Current;
                BigtableByteString currentRowKey;
                string currentColumnFamily = null;
                foreach (var chunk in current.Chunks)
                {
                    if (!chunk.RowKey.IsEmpty)
                    {
                        currentRowKey = chunk.RowKey;
                    }
                    if (chunk.FamilyName != null)
                    {
                        currentColumnFamily = chunk.FamilyName;
                    }
                    Assert.Equal(rowKey, currentRowKey);
                    Assert.Equal(BigtableFixture.ColumnFamily1, currentColumnFamily);
                    if ((BigtableByteString)chunk.Qualifier == "modify_row_column")
                    {
                        Assert.Equal("new_cell_value", (BigtableByteString)chunk.Value);
                        Assert.Equal(1000, chunk.TimestampMicros);
                    }
                }
            }
        }

        [Fact]
        public async Task DeleteFromColumn()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await InsertRowAsync(client, tableName, rowKey, new BigtableVersion(1));
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "column_name",
                    "abcd",
                    new BigtableVersion(2)));

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.DeleteFromColumn(
                    BigtableFixture.ColumnFamily1,
                    "column_name",
                    new BigtableVersionRange(1, 2)));

            await VerifySingleRowAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "column_name",
                "abcd",
                new BigtableVersion(2));
        }

        [Fact]
        public async Task DeleteFromColumnAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await InsertRowAsync(client, tableName, rowKey, new BigtableVersion(1));
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "column_name",
                    "abcd",
                    new BigtableVersion(2)));

            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[]
                {
                    Mutations.DeleteFromColumn(
                        BigtableFixture.ColumnFamily1,
                        "column_name",
                        new BigtableVersionRange(1, 2))
                });

            await VerifySingleRowAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "column_name",
                "abcd",
                new BigtableVersion(2));
        }

        [Fact]
        public async Task DeleteFromFamily()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await InsertRowAsync(client, tableName, rowKey, new BigtableVersion(1));
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.OtherColumnFamily,
                    "last_name",
                    "Smith",
                    new BigtableVersion(3)));

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.DeleteFromFamily(BigtableFixture.ColumnFamily1));

            await VerifySingleRowAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.OtherColumnFamily,
                "last_name",
                "Smith",
                new BigtableVersion(3));
        }

        [Fact]
        public async Task DeleteFromFamilyAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await InsertRowAsync(client, tableName, rowKey, new BigtableVersion(1));
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.OtherColumnFamily,
                    "last_name",
                    "Smith",
                    new BigtableVersion(3)));

            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[] { Mutations.DeleteFromFamily(BigtableFixture.ColumnFamily1) });

            await VerifySingleRowAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.OtherColumnFamily,
                "last_name",
                "Smith",
                new BigtableVersion(3));
        }

        [Fact]
        public async Task DeleteRow()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await InsertRowAsync(client, tableName, rowKey, new BigtableVersion(1));

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.DeleteFromRow());

            await VerifyNoRowAsync(client, tableName, rowKey);
        }

        [Fact]
        public async Task DeleteRowAsync()
        {
            var tableName = _fixture.DefaultTableName;
            var client = _fixture.DefaultTableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await InsertRowAsync(client, tableName, rowKey, new BigtableVersion(1));

            await client.MutateRowAsync(
                tableName,
                rowKey,
                new[] { Mutations.DeleteFromRow() });

            await VerifyNoRowAsync(client, tableName, rowKey);
        }

        private static async Task InsertRowAsync(
            BigtableClient client,
            TableName tableName,
            BigtableByteString rowKey,
            BigtableVersion version)
        {
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "column_name",
                    "test12345",
                    new BigtableVersion(1)));

            await VerifySingleRowAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
                "column_name",
                "test12345",
                new BigtableVersion(1));
        }

        private static async Task VerifyNoRowAsync(
            BigtableClient client,
            TableName tableName,
            BigtableByteString rowKey)
        {
            // TODO: Use cleaner API when available
            var response = client.ReadRows(new ReadRowsRequest
            {
                TableName = tableName.ToString(),
                Rows = new RowSet { RowKeys = { rowKey } }
            });

            while (await response.ResponseStream.MoveNext(default))
            {
                var current = response.ResponseStream.Current;
                foreach (var chunk in current.Chunks)
                {
                    Assert.True(false, $"No chunks expected for the row at {rowKey.Value.ToStringUtf8()}");
                }
            }
        }

        private static async Task VerifySingleRowAsync(
            BigtableClient client,
            TableName tableName,
            BigtableByteString rowKey,
            string familyName,
            BigtableByteString columnQualifier,
            BigtableByteString value,
            BigtableVersion version)
        {
            // TODO: Use cleaner API when available
            var response = client.ReadRows(new ReadRowsRequest
            {
                TableName = tableName.ToString(),
                Rows = new RowSet { RowKeys = { rowKey } }
            });

            while (await response.ResponseStream.MoveNext(default))
            {
                var current = response.ResponseStream.Current;
                foreach (var chunk in current.Chunks)
                {
                    Assert.Equal(rowKey.Value, chunk.RowKey);
                    Assert.Equal(familyName, chunk.FamilyName);
                    Assert.Equal(columnQualifier.Value, chunk.Qualifier);
                    Assert.Equal(value.Value, chunk.Value);
                    Assert.Equal(version.Micros, chunk.TimestampMicros);
                }
            }
        }
    }
}
