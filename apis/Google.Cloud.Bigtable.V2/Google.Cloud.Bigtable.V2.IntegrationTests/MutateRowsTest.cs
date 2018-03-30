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

using Google.Protobuf;
using Google.Rpc;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [Collection(nameof(BigtableFixture))]
    public class MutateRowsTest
    {
        private readonly BigtableFixture _fixture;

        public MutateRowsTest(BigtableFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task AddNewRow()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            var response = await client.MutateRowsAsync(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "column_name",
                        "test12345",
                        new BigtableVersion(1))));

            var entries = response.Entries.OrderBy(e => e.Index);
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

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

            var response = await client.MutateRowsAsync(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "modify_row_column",
                        "new_cell_value",
                        new BigtableVersion(1))));

            var entries = response.Entries.OrderBy(e => e.Index);
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

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

            var response = await client.MutateRowsAsync(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.DeleteFromColumn(
                        BigtableFixture.DefaultColumnFamily,
                        BigtableFixture.DefaultColumnQualifier,
                        new BigtableVersionRange(1, 2))));

            var entries = response.Entries.OrderBy(e => e.Index);
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

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

            var response = await client.MutateRowsAsync(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.DeleteFromFamily(BigtableFixture.DefaultColumnFamily)));

            var entries = response.Entries.OrderBy(e => e.Index);
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

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

            var response = await client.MutateRowsAsync(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.DeleteFromRow()));

            var entries = response.Entries.OrderBy(e => e.Index);
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

            await BigtableAssert.HasNoValuesAsync(client, tableName, rowKey);
        }

        [Fact]
        public async Task MultipleRows()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey1 = await _fixture.InsertRowAsync(tableName);
            BigtableByteString rowKey2 = Guid.NewGuid().ToString();

            var response = await client.MutateRowsAsync(
                tableName,
                Mutations.CreateEntry(
                    rowKey2,
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "column_name1",
                        "test12345",
                        new BigtableVersion(1)),
                    Mutations.SetCell(
                        BigtableFixture.OtherColumnFamily,
                        "column_name3",
                        "valueABC",
                        new BigtableVersion(3))),
                Mutations.CreateEntry(
                    rowKey1,
                    Mutations.DeleteFromRow()),
                Mutations.CreateEntry(
                    rowKey2,
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "column_name2",
                        "valueXYZ",
                        new BigtableVersion(2))));

            var entries = response.Entries.OrderBy(e => e.Index);
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

            await BigtableAssert.HasNoValuesAsync(
                client,
                tableName,
                rowKey1);
            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey2,
                BigtableFixture.DefaultColumnFamily,
                "column_name1",
                "test12345",
                new BigtableVersion(1));
            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey2,
                BigtableFixture.DefaultColumnFamily,
                "column_name2",
                "valueXYZ",
                new BigtableVersion(2));
            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey2,
                BigtableFixture.OtherColumnFamily,
                "column_name3",
                "valueABC",
                new BigtableVersion(3));
        }

        [Fact]
        public async Task NonIdempotentRequestDisallowed()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            await Assert.ThrowsAsync<InvalidOperationException>(() =>
                client.MutateRowsAsync(
                    tableName,
                    Mutations.CreateEntry(
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
                        })));

            // Also just verify we allow the same call which is idempotent instead (has TimestampMicros).
            await client.MutateRowsAsync(
                tableName,
                Mutations.CreateEntry(
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
                    }));
        }

        [Fact]
        public async Task OmittedVersion()
        {
            var beforeInsertTimestamp = DateTime.UtcNow.AddMilliseconds(-1);

            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();
            var response = await client.MutateRowsAsync(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "column_name",
                        "test12345")));

            var entries = response.Entries.OrderBy(e => e.Index);
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

            var row = await client.ReadRowAsync(tableName, rowKey);
            var cell = row.Families[0].Columns[0].Cells[0];
            var insertTimestamp = cell.Version.ToDateTime();
            Assert.True(
                beforeInsertTimestamp <= insertTimestamp,
                $"Expected insert time to be on or after {beforeInsertTimestamp:s}, but was {insertTimestamp:s}");
        }
    }
}
