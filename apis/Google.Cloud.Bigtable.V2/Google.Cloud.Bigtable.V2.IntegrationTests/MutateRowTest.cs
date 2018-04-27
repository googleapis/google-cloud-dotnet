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

using Google.Cloud.Bigtable.Common.V2;
using Google.Protobuf;
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
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.DefaultColumnFamily,
                    "column_name",
                    "test12345",
                    new BigtableVersion(1)));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "column_name",
                "test12345",
                new BigtableVersion(1));
        }

        [Fact]
        public async Task AddNewRowAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            await client.MutateRowAsync(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.DefaultColumnFamily,
                    "column_name",
                    "test12345",
                    new BigtableVersion(1)));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "column_name",
                "test12345",
                new BigtableVersion(1));
        }
        
        [Fact]
        public async Task ModifyRow()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.DefaultColumnFamily,
                    "modify_row_column",
                    "new_cell_value",
                    new BigtableVersion(1)));

            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "modify_row_column",
                "new_cell_value",
                new BigtableVersion(1));
        }

        [Fact]
        public async Task ModifyRowAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            await client.MutateRowAsync(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.DefaultColumnFamily,
                    "modify_row_column",
                    "new_cell_value",
                    new BigtableVersion(1)));

            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "modify_row_column",
                "new_cell_value",
                new BigtableVersion(1));
        }
        
        [Fact]
        public async Task DeleteFromColumn()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, version: new BigtableVersion(1));
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.DefaultColumnFamily,
                    "column_name",
                    "abcd",
                    new BigtableVersion(2)));

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.DeleteFromColumn(
                    BigtableFixture.DefaultColumnFamily,
                    BigtableFixture.DefaultColumnQualifier,
                    new BigtableVersionRange(1, 2)));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "column_name",
                "abcd",
                new BigtableVersion(2));
        }

        [Fact]
        public async Task DeleteFromColumnAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, version: new BigtableVersion(1));
            client.MutateRow(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.DefaultColumnFamily,
                    "column_name",
                    "abcd",
                    new BigtableVersion(2)));

            await client.MutateRowAsync(
                tableName,
                rowKey,
                Mutations.DeleteFromColumn(
                    BigtableFixture.DefaultColumnFamily,
                    BigtableFixture.DefaultColumnQualifier,
                    new BigtableVersionRange(1, 2)));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "column_name",
                "abcd",
                new BigtableVersion(2));
        }

        [Fact]
        public async Task DeleteFromFamily()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);
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
                Mutations.DeleteFromFamily(BigtableFixture.DefaultColumnFamily));

            await BigtableAssert.HasSingleValueAsync(
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
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);
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
                Mutations.DeleteFromFamily(BigtableFixture.DefaultColumnFamily));

            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.OtherColumnFamily,
                "last_name",
                "Smith",
                new BigtableVersion(3));
        }

        [Fact]
        public async Task DeleteFromRow()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            client.MutateRow(
                tableName,
                rowKey,
                Mutations.DeleteFromRow());

            await BigtableAssert.HasNoValuesAsync(client, tableName, rowKey);
        }

        [Fact]
        public async Task DeleteFromRowAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            await client.MutateRowAsync(
                tableName,
                rowKey,
                Mutations.DeleteFromRow());

            await BigtableAssert.HasNoValuesAsync(client, tableName, rowKey);
        }

        [Fact]
        public void NonIdempotentRequestDisallowed()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            Assert.Throws<InvalidOperationException>(() =>
                client.MutateRow(
                    tableName,
                    rowKey,
                    new Mutation
                    {
                        SetCell = new Mutation.Types.SetCell
                        {
                            FamilyName = BigtableFixture.DefaultColumnFamily,
                            ColumnQualifier = ByteString.CopyFromUtf8("column_name"),
                            Value = ByteString.CopyFromUtf8("test12345"),
                            TimestampMicros = -1
                        }
                    }));

            // Also just verify we allow the same call which is idempotent instead (has TimestampMicros).
            client.MutateRow(
                tableName,
                rowKey,
                new Mutation
                {
                    SetCell = new Mutation.Types.SetCell
                    {
                        FamilyName = BigtableFixture.DefaultColumnFamily,
                        ColumnQualifier = ByteString.CopyFromUtf8("column_name"),
                        Value = ByteString.CopyFromUtf8("test12345"),
                        TimestampMicros = 1000
                    }
                });
        }
    }
}
