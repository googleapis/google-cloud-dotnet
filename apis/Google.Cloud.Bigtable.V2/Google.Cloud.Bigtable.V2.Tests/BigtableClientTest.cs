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
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class BigtableClientTest
    {
        private class TestBigtableClient : BigtableClient { }
        
        public static TheoryData<BigtableByteString> InvalidRowKeys { get; } = new TheoryData<BigtableByteString>
        {
            "",
            new byte[0],
            ByteString.Empty,
            default
        };

        [Fact]
        public async Task CheckAndMutateRow_Valid_Request()
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");

            // NotImplementedException means it got through the normal validations and tried to actually
            // make the request on the TestBigtableClient.
            await CheckAndMutateRow_ValidateArguments<NotImplementedException>(
                tableName,
                "abc",
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new[] { Mutations.DeleteFromRow() });
        }

        [Fact]
        public async Task CheckAndMutateRow_Validate_TableName()
        {
            var client = new TestBigtableClient();
            await CheckAndMutateRow_ValidateArguments<ArgumentNullException>(
                null,
                "abc",
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new[] { Mutations.DeleteFromRow() });
        }

        [Theory]
        [MemberData(nameof(InvalidRowKeys))]
        public async Task CheckAndMutateRow_Validate_RowKey(BigtableByteString rowKey)
        {
            var client = new TestBigtableClient();
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
            var client = new TestBigtableClient();
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
            var client = new TestBigtableClient();
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
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");

            // NotImplementedException means it got through the normal validations and tried to actually
            // make the request on the TestBigtableClient.
            await MutateRow_ValidateArguments<NotImplementedException>(tableName, "abc", new[] { Mutations.DeleteFromRow() });
        }

        [Fact]
        public async Task MutateRow_Validate_TableName()
        {
            var client = new TestBigtableClient();
            await MutateRow_ValidateArguments<ArgumentNullException>(null, "abc", new[] { Mutations.DeleteFromRow() });
        }

        [Theory]
        [MemberData(nameof(InvalidRowKeys))]
        public async Task MutateRow_Validate_RowKey(BigtableByteString rowKey)
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            await MutateRow_ValidateArguments<ArgumentException>(tableName, rowKey, new[] { Mutations.DeleteFromRow() });
        }

        [Fact]
        public async Task MutateRow_Validate_Mutations()
        {
            var client = new TestBigtableClient();
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
            var client = new TestBigtableClient();
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
        public async Task ReadModifyWriteRow_Valid_Request()
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");

            // NotImplementedException means it got through the normal validations and tried to actually
            // make the request on the TestBigtableClient.
            await ReadModifyWriteRow_ValidateArguments<NotImplementedException>(
                tableName, "abc", new[] { ReadModifyWriteRules.Append("a", "b", "c") } );
        }

        [Fact]
        public async Task ReadModifyWriteRow_Validate_TableName()
        {
            var client = new TestBigtableClient();
            await ReadModifyWriteRow_ValidateArguments<ArgumentNullException>(
                null, "abc", new[] { ReadModifyWriteRules.Append("a", "b", "c") });
        }

        [Theory]
        [MemberData(nameof(InvalidRowKeys))]
        public async Task ReadModifyWriteRow_Validate_RowKey(BigtableByteString rowKey)
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            await ReadModifyWriteRow_ValidateArguments<ArgumentException>(
                tableName, rowKey, new[] { ReadModifyWriteRules.Append("a", "b", "c") });
        }

        [Fact]
        public async Task ReadModifyWriteRow_Validate_Rules()
        {
            var client = new TestBigtableClient();
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
            var client = new TestBigtableClient();
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
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");

            // NotImplementedException means it got through the normal validations and tried to actually
            // make the request on the TestBigtableClient.
            await ReadRow_ValidateArguments<NotImplementedException>(tableName, "abc", null);
            await ReadRow_ValidateArguments<NotImplementedException>(tableName, "abc", RowFilters.CellsPerColumnLimit(1));
        }

        [Fact]
        public async Task ReadRow_Validate_TableName()
        {
            var client = new TestBigtableClient();
            await ReadRow_ValidateArguments<ArgumentNullException>(null, "abc", null);
        }

        [Theory]
        [MemberData(nameof(InvalidRowKeys))]
        public async Task ReadRow_Validate_RowKey(BigtableByteString rowKey)
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            await ReadRow_ValidateArguments<ArgumentException>(tableName, rowKey, null);
        }

        private async Task ReadRow_ValidateArguments<TException>(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter filter)
            where TException : Exception
        {
            var client = new TestBigtableClient();
            Assert.Throws<TException>(
                () => client.ReadRow(tableName, rowKey, filter));
            await Assert.ThrowsAsync<TException>(
                () => client.ReadRowAsync(tableName, rowKey, filter));
        }

        [Fact]
        public async Task ReadRows_Family_Order()
        {
            var stream = new MockReadRowsStream(
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
                            Value = ByteString.CopyFromUtf8("value3"),
                            CommitRow = true
                        }
                    }
                });

            int rowCount = 0;
            await stream.AsAsyncEnumerable().ForEachAsync(row =>
            {
                rowCount++;
                var familyNames = row.Families.Select(r => r.Name).ToArray();
                Assert.Equal("A", familyNames[0]);
                Assert.Equal("a", familyNames[1]);
                Assert.Equal("z", familyNames[2]);
            });
            Assert.Equal(1, rowCount);
        }

        [Fact]
        public void ReadRows_Valid_Request()
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");

            // NotImplementedException means it got through the normal validations and tried to actually
            // make the request on the TestBigtableClient.
            ReadRows_ValidateArguments<NotImplementedException>(tableName, null, null, null);
            ReadRows_ValidateArguments<NotImplementedException>(
                tableName,
                // TODO: Maybe add RowSet helpers to help with this
                new RowSet { RowKeys = { ByteString.CopyFromUtf8("abc") } },
                RowFilters.BlockAllFilter(),
                0);
            ReadRows_ValidateArguments<NotImplementedException>(
                tableName,
                // TODO: Use RowRange helpers when available.
                new RowSet { RowRanges = { new RowRange {
                    StartKeyClosed = ByteString.CopyFromUtf8(""),
                    EndKeyOpen = ByteString.CopyFromUtf8("z") } } },
                RowFilters.CellsPerRowLimit(1),
                123);
        }

        [Fact]
        public void ReadRows_Validate_TableName()
        {
            var client = new TestBigtableClient();
            var rows = new RowSet { RowKeys = { ByteString.CopyFromUtf8("abc") } };
            ReadRows_ValidateArguments<ArgumentNullException>(null, rows, null, null);
        }

        [Fact]
        public void ReadRows_Validate_RowsLimit()
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            var rows = new RowSet { RowKeys = { ByteString.CopyFromUtf8("abc") } };
            ReadRows_ValidateArguments<ArgumentOutOfRangeException>(tableName, rows, null, -1);
        }

        private void ReadRows_ValidateArguments<TException>(
            TableName tableName,
            RowSet rows,
            RowFilter filter,
            long? rowsLimit)
            where TException : Exception
        {
            var client = new TestBigtableClient();
            Assert.Throws<TException>(
                () => client.ReadRows(tableName, rows, filter, rowsLimit));
        }
    }
}
