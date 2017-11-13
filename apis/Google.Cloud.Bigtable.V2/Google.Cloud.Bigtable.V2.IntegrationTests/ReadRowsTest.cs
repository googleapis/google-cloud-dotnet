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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [Collection(nameof(BigtableFixture))]
    public class ReadRowsTest
    {
        private readonly BigtableFixture _fixture;

        public ReadRowsTest(BigtableFixture fixture) => _fixture = fixture;

        [Fact(Skip = "Server doesn't support cell splitting yet")]
        public async Task SplitCell()
        {
            if (_fixture.EmulatorChannel != null)
            {
                // Don't run the test on the emulator.
                return;
            }

            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;

            var buffer = new byte[8192];
            var rnd = new Random();
            rnd.NextBytes(buffer);
            var rowKey = await _fixture.InsertRowAsync(
                tableName,
                BigtableFixture.ColumnFamily1,
                "large_value",
                buffer);

            var allData = buffer.ToList();
            while (true)
            {
                var response = client.ReadRows(
                    tableName,
                    new RowSet { RowKeys = { rowKey.Value } },
                    RowFilters.CellsPerColumnLimit(1));
                using (var enumerator = (RowAsyncEnumerator)response.AsAsyncEnumerable().GetEnumerator())
                {
                    while (await enumerator.MoveNext(default))
                    {
                        var row = enumerator.Current;
                        Assert.Equal(rowKey.Value, row.Key);
                        BigtableAssert.HasSingleValue(
                            row,
                            BigtableFixture.ColumnFamily1,
                            "large_value",
                            allData.ToArray());
                    }
                
                    if (enumerator.HadSplitCell)
                    {
                        return;
                    }
                }

                rnd.NextBytes(buffer);
                // TODO: Use cleaner API when available
                await client.ReadModifyWriteRowAsync(
                    tableName,
                    rowKey.Value,
                    new[]
                    {
                        new ReadModifyWriteRule
                        {
                            FamilyName = BigtableFixture.ColumnFamily1,
                            ColumnQualifier = ByteString.CopyFromUtf8("large_value"),
                            AppendValue = ByteString.CopyFrom(buffer)
                        }
                    });

                allData.AddRange(buffer);

                const int sizeLimit = (1 << 21);
                Assert.True(allData.Count < sizeLimit, $"Inconclusive: cell not split after {sizeLimit} bytes of data");
            }
        }

        [Fact]
        public async Task ReadRow()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, version: new BigtableVersion(1));

            var row = client.ReadRow(tableName, rowKey);
            Assert.Equal(rowKey.Value, row.Key);
            BigtableAssert.HasSingleValue(
                row,
                BigtableFixture.ColumnFamily1,
                "row_exists",
                "true",
                new BigtableVersion(1));
        }

        [Fact]
        public async Task ReadRowAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, version: new BigtableVersion(1));

            var row = await client.ReadRowAsync(tableName, rowKey);
            Assert.Equal(rowKey.Value, row.Key);
            BigtableAssert.HasSingleValue(
                row,
                BigtableFixture.ColumnFamily1,
                "row_exists",
                "true",
                new BigtableVersion(1));
        }

        [Fact]
        public void ReadRowMissing()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;

            var row = client.ReadRow(tableName, "abc");
            Assert.Null(row);
        }

        [Fact]
        public async Task ReadRowMissingAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;

            var row = await client.ReadRowAsync(tableName, "abc");
            Assert.Null(row);
        }

        [Fact]
        public async Task ReadRowFiltered()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            await client.MutateRowAsync(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    "0",
                    new BigtableVersion(1)),
                Mutations.SetCell(
                    BigtableFixture.OtherColumnFamily,
                    "row_exists",
                    "true",
                    new BigtableVersion(2)));

            var row = client.ReadRow(tableName, rowKey, RowFilters.ValueRegex("true"));
            Assert.Equal(rowKey.Value, row.Key);
            BigtableAssert.HasSingleValue(
                row,
                BigtableFixture.OtherColumnFamily,
                "row_exists",
                "true",
                new BigtableVersion(2));
        }

        [Fact]
        public async Task ReadRowFilteredAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            await client.MutateRowAsync(
                tableName,
                rowKey,
                Mutations.SetCell(
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    "0",
                    new BigtableVersion(1)),
                Mutations.SetCell(
                    BigtableFixture.OtherColumnFamily,
                    "row_exists",
                    "true",
                    new BigtableVersion(2)));

            var row = await client.ReadRowAsync(tableName, rowKey, RowFilters.ValueRegex("true"));
            Assert.Equal(rowKey.Value, row.Key);
            BigtableAssert.HasSingleValue(
                row,
                BigtableFixture.OtherColumnFamily,
                "row_exists",
                "true",
                new BigtableVersion(2));
        }

        [Fact]
        public async Task ReadRowsWithKeys()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var originalIndexes = new Dictionary<BigtableByteString, int>();
            var rowKeys = new List<BigtableByteString>();
            int endRowIndex = 100;
            for (int i = 0; i < endRowIndex; i++)
            {
                rowKeys.Add(await _fixture.InsertRowAsync(
                    tableName,
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    i,
                    new BigtableVersion(1)));

                originalIndexes[rowKeys[i]] = i;
            }

            var response = client.ReadRows(
                tableName,
                // TODO: Use RowSet helpers when available
                new RowSet { RowKeys = { rowKeys.Select(s => s.Value) } });

            rowKeys.Sort();

            int currentRowIndex = 0;
            await response.AsAsyncEnumerable().ForEachAsync(row =>
            {
                var currentRowKey = rowKeys[currentRowIndex++];
                Assert.Equal(currentRowKey.Value, row.Key);

                BigtableAssert.HasSingleValue(
                    row,
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    new BigtableByteString(originalIndexes[currentRowKey]),
                    new BigtableVersion(1));
            });

            Assert.Equal(currentRowIndex, endRowIndex);
        }

        [Fact]
        public async Task ReadRowsWithKeysFiltered()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var originalIndexes = new Dictionary<BigtableByteString, int>();
            var rowKeys = new List<BigtableByteString>();
            for (int i = 0; i < 100; i++)
            {
                rowKeys.Add(await _fixture.InsertRowAsync(
                    tableName,
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    i,
                    new BigtableVersion(i + 1)));

                originalIndexes[rowKeys[i]] = i;
            }

            var response = client.ReadRows(
                tableName,
                // TODO: Use RowSet helpers when available?
                new RowSet { RowKeys = { rowKeys.Select(s => s.Value) } },
                RowFilters.Interleave(
                    RowFilters.VersionRange(new BigtableVersionRange(1, 26)),
                    RowFilters.VersionRange(new BigtableVersionRange(76, 101))));

            rowKeys.Sort();

            int rowCount = 0;
            await response.AsAsyncEnumerable().ForEachAsync(row =>
            {
                rowCount++;
                int index = originalIndexes[row.Key];
                int version = index + 1;

                Assert.True(version <= 25 || 76 <= version);

                BigtableAssert.HasSingleValue(
                    row,
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    new BigtableByteString(index),
                    new BigtableVersion(version));
            });

            Assert.Equal(50, rowCount);
        }

        [Fact]
        public async Task ReadRowsWithKeysLimited()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var originalIndexes = new Dictionary<BigtableByteString, int>();
            var rowKeys = new List<BigtableByteString>();
            for (int i = 0; i < 100; i++)
            {
                rowKeys.Add(await _fixture.InsertRowAsync(
                    tableName,
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    i,
                    new BigtableVersion(i + 1)));

                originalIndexes[rowKeys[i]] = i;
            }

            var response = client.ReadRows(
                tableName,
                // TODO: Use RowSet helpers when available?
                new RowSet { RowKeys = { rowKeys.Select(s => s.Value) } },
                rowsLimit: 37);

            rowKeys.Sort();

            int rowCount = 0;
            await response.AsAsyncEnumerable().ForEachAsync(row =>
            {
                rowCount++;
                int index = originalIndexes[row.Key];
                int version = index + 1;

                BigtableAssert.HasSingleValue(
                    row,
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    new BigtableByteString(index),
                    new BigtableVersion(version));
            });

            Assert.Equal(37, rowCount);
        }

        [Fact]
        public async Task ReadRowsWithRange()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            string rowKeyPrefix = Guid.NewGuid().ToString();
            int endRowIndex = 0xFF;
            var rowKeys =
                Enumerable.Range(0, endRowIndex)
                .Select(i => (BigtableByteString)(rowKeyPrefix + i.ToString("X2")))
                .ToList();
            await _fixture.InsertRowsAsync(tableName, rowKeys, version: new BigtableVersion(1));

            var startRange = (BigtableByteString)rowKeyPrefix;
            var endRange = (BigtableByteString)(rowKeyPrefix + "z");
            var response = client.ReadRows(
                tableName,
                // TODO: Use RowSet helpers when available
                new RowSet
                {
                    RowRanges =
                    {
                        new RowRange { StartKeyClosed = startRange.Value, EndKeyOpen = endRange.Value }
                    }
                });

            int currentRowIndex = 0;
            await response.AsAsyncEnumerable().ForEachAsync(row =>
            {
                BigtableAssert.HasSingleValue(
                    row,
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    new BigtableByteString(currentRowIndex++),
                    new BigtableVersion(1));
            });

            Assert.Equal(endRowIndex, currentRowIndex);
        }

        [Fact]
        public async Task ReadRowsWithRangeFiltered()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            string rowKeyPrefix = Guid.NewGuid().ToString();
            int endRowIndex = 0xFF;
            var rowKeys =
                Enumerable.Range(0, endRowIndex)
                .Select(i => (BigtableByteString)(rowKeyPrefix + i.ToString("X2")))
                .ToList();
            await _fixture.InsertRowsAsync(tableName, rowKeys, version: new BigtableVersion(1));

            var startRange = (BigtableByteString)rowKeyPrefix;
            var endRange = (BigtableByteString)(rowKeyPrefix + "z");
            var response = client.ReadRows(
                tableName,
                // TODO: Use RowSet helpers when available
                new RowSet
                {
                    RowRanges =
                    {
                    new RowRange { StartKeyClosed = startRange.Value, EndKeyOpen = endRange.Value }
                    }
                },
                // Get all values ending in a byte which is a UTF-8 lowercase letter
                RowFilters.ValueRegex(".*[a-z]$"));

            int currentRowIndex = 'a';
            await response.AsAsyncEnumerable().ForEachAsync(row =>
            {
                BigtableAssert.HasSingleValue(
                    row,
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    new BigtableByteString(currentRowIndex++),
                    new BigtableVersion(1));
            });

            Assert.Equal('z' + 1, currentRowIndex);
        }

        [Fact]
        public async Task ReadRowsWithRangeLimited()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            string rowKeyPrefix = Guid.NewGuid().ToString();
            int endRowIndex = 0xFF;
            var rowKeys =
                Enumerable.Range(0, endRowIndex)
                .Select(i => (BigtableByteString)(rowKeyPrefix + i.ToString("X2")))
                .ToList();
            await _fixture.InsertRowsAsync(tableName, rowKeys, version: new BigtableVersion(1));

            var startRange = (BigtableByteString)rowKeyPrefix;
            var endRange = (BigtableByteString)(rowKeyPrefix + "z");
            var response = client.ReadRows(
                tableName,
                // TODO: Use RowSet helpers when available
                new RowSet
                {
                    RowRanges =
                    {
                        new RowRange { StartKeyClosed = startRange.Value, EndKeyOpen = endRange.Value }
                    }
                },
                rowsLimit: 37);

            int currentRowIndex = 0;
            await response.AsAsyncEnumerable().ForEachAsync(row =>
            {
                BigtableAssert.HasSingleValue(
                    row,
                    BigtableFixture.ColumnFamily1,
                    "row_index",
                    new BigtableByteString(currentRowIndex++),
                    new BigtableVersion(1));
            });

            Assert.Equal(37, currentRowIndex);
        }

        [Fact]
        public async Task ReadRows_Validate_SingleIteration()
        {
            var tableName = await _fixture.CreateTable();
            var client = _fixture.TableClient;

            var rowKey = await _fixture.InsertRowAsync(tableName);
            System.Diagnostics.Debug.WriteLine((string)rowKey);

            var response = client.ReadRows(tableName);
            await response.AsAsyncEnumerable().ForEachAsync(row =>
            {
                Assert.Equal(rowKey.Value, row.Key);
            });

            var enumerable = response.AsAsyncEnumerable();
            Assert.Throws<InvalidOperationException>(() => enumerable.GetEnumerator());
        }
    }
}
