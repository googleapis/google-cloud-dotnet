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

using Google.Cloud.Bigtable.Common.V2;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [Collection(nameof(BigtableFixture))]
    public class CheckAndMutateRowTest
    {
        private readonly BigtableFixture _fixture;

        public CheckAndMutateRowTest(BigtableFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task NullPredicate_ExistingRow()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            var result = client.CheckAndMutateRow(
                tableName,
                rowKey,
                predicateFilter: null,
                trueMutations: new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "original_row_status",
                        "row_had_cells")
                },
                falseMutations: new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "original_row_status",
                        "row_had_no_cells")
                });

            Assert.True(result.PredicateMatched);
            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "original_row_status",
                "row_had_cells");
        }

        [Fact]
        public async Task NullPredicate_ExistingRowAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName);

            var result = await client.CheckAndMutateRowAsync(
                tableName,
                rowKey,
                predicateFilter: null,
                trueMutations: new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "original_row_status",
                        "row_had_cells")
                },
                falseMutations: new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "original_row_status",
                        "row_had_no_cells")
                });

            Assert.True(result.PredicateMatched);
            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "original_row_status",
                "row_had_cells");
        }

        [Fact]
        public async Task NullPredicate_MissingRow()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            var result = client.CheckAndMutateRow(
                tableName,
                rowKey,
                predicateFilter: null,
                trueMutations: new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "original_row_status",
                        "row_had_cells")
                },
                falseMutations: new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "original_row_status",
                        "row_had_no_cells")
                });

            Assert.False(result.PredicateMatched);
            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "original_row_status",
                "row_had_no_cells");
        }

        [Fact]
        public async Task NullPredicate_MissingRowAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            BigtableByteString rowKey = Guid.NewGuid().ToString();

            var result = await client.CheckAndMutateRowAsync(
                tableName,
                rowKey,
                predicateFilter: null,
                trueMutations: new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "original_row_status",
                        "row_had_cells")
                },
                falseMutations: new[]
                {
                    Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "original_row_status",
                        "row_had_no_cells")
                });

            Assert.False(result.PredicateMatched);
            await BigtableAssert.HasSingleValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "original_row_status",
                "row_had_no_cells");
        }

        [Fact]
        public async Task MostRecentValueCheck()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, value: "a1");

            var result = client.CheckAndMutateRow(
                tableName,
                rowKey,
                RowFilters.Chain(
                    RowFilters.CellsPerColumnLimit(1),
                    RowFilters.ValueRegex(@"^[a-z]\d+$")),
                Mutations.SetCell(
                    BigtableFixture.DefaultColumnFamily,
                    "found_recent_value",
                    "true"));

            Assert.True(result.PredicateMatched);
            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "found_recent_value",
                "true");
        }

        [Fact]
        public async Task MostRecentValueCheckAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, value: "a1");

            var result = await client.CheckAndMutateRowAsync(
                tableName,
                rowKey,
                RowFilters.Chain(
                    RowFilters.CellsPerColumnLimit(1),
                    RowFilters.ValueRegex(@"^[a-z]\d+$")),
                Mutations.SetCell(
                    BigtableFixture.DefaultColumnFamily,
                    "found_recent_value",
                    "true"));

            Assert.True(result.PredicateMatched);
            await BigtableAssert.HasValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "found_recent_value",
                "true");
        }

        [Fact]
        public async Task SecondToLastValueCheck()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, value: "a1");

            var result = client.CheckAndMutateRow(
                tableName,
                rowKey,
                RowFilters.Chain(
                    RowFilters.CellsPerColumnLimit(2),
                    RowFilters.ValueRegex(@"^[a-z]\d+$"),
                    RowFilters.CellsPerRowOffset(1)),
                Mutations.SetCell(
                    BigtableFixture.DefaultColumnFamily,
                    "found_recent_value",
                    "true"));

            Assert.False(result.PredicateMatched);
            await BigtableAssert.DoesNotHaveValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "found_recent_value",
                "true");
        }

        [Fact]
        public async Task SecondToLastValueCheckAsync()
        {
            var tableName = _fixture.TableName;
            var client = _fixture.TableClient;
            var rowKey = await _fixture.InsertRowAsync(tableName, value: "a1");

            var result = await client.CheckAndMutateRowAsync(
                tableName,
                rowKey,
                RowFilters.Chain(
                    RowFilters.CellsPerColumnLimit(2),
                    RowFilters.ValueRegex(@"^[a-z]\d+$"),
                    RowFilters.CellsPerRowOffset(1)),
                Mutations.SetCell(
                        BigtableFixture.DefaultColumnFamily,
                        "found_recent_value",
                        "true"));

            Assert.False(result.PredicateMatched);
            await BigtableAssert.DoesNotHaveValueAsync(
                client,
                tableName,
                rowKey,
                BigtableFixture.DefaultColumnFamily,
                "found_recent_value",
                "true");
        }
    }
}
