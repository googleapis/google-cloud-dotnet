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
            var stream = client.MutateRows(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.SetCell(
                        BigtableFixture.ColumnFamily1,
                        "column_name",
                        "test12345",
                        new BigtableVersion(1))));

            var entries = await stream.GetResponseEntries();
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

            await BigtableAssert.HasSingleValueAsync(
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
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            var stream = client.MutateRows(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.SetCell(
                        BigtableFixture.ColumnFamily1,
                        "modify_row_column",
                        "new_cell_value",
                        new BigtableVersion(1))));

            var entries = await stream.GetResponseEntries();
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.ColumnFamily1,
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
                    BigtableFixture.ColumnFamily1,
                    "column_name",
                    "abcd",
                    new BigtableVersion(2)));

            var stream = client.MutateRows(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.DeleteFromColumn(
                        BigtableFixture.ColumnFamily1,
                        "row_exists",
                        new BigtableVersionRange(1, 2))));

            var entries = await stream.GetResponseEntries();
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

            await BigtableAssert.HasSingleValueAsync(
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

            var stream = client.MutateRows(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.DeleteFromFamily(BigtableFixture.ColumnFamily1)));

            var entries = await stream.GetResponseEntries();
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

            var stream = client.MutateRows(
                tableName,
                Mutations.CreateEntry(
                    rowKey,
                    Mutations.DeleteFromRow()));

            var entries = await stream.GetResponseEntries();
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

            var stream = client.MutateRows(
                tableName,
                Mutations.CreateEntry(
                    rowKey1,
                    Mutations.DeleteFromRow()),
                Mutations.CreateEntry(
                    rowKey2,
                    Mutations.SetCell(
                        BigtableFixture.ColumnFamily1,
                        "column_name1",
                        "test12345",
                        new BigtableVersion(1)),
                    Mutations.SetCell(
                        BigtableFixture.ColumnFamily1,
                        "column_name2",
                        "valueXYZ",
                        new BigtableVersion(2))));

            var entries = await stream.GetResponseEntries();
            Assert.True(entries.All(e => e.Status.Code == (int)Code.Ok));

            await BigtableAssert.HasNoValuesAsync(
                client,
                tableName,
                rowKey1);
            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey2,
                BigtableFixture.ColumnFamily1,
                "column_name1",
                "test12345",
                new BigtableVersion(1));
            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey2,
                BigtableFixture.ColumnFamily1,
                "column_name2",
                "valueXYZ",
                new BigtableVersion(2));
        }
    }
}
