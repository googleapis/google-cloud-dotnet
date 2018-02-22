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
        private class RequestMadeException : Exception { }

        private class TestBigtableClient : BigtableClient
        {
            public override CheckAndMutateRowResponse CheckAndMutateRow(CheckAndMutateRowRequest request, CallSettings callSettings = null) =>
                throw new RequestMadeException();
            public override Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(CheckAndMutateRowRequest request, CallSettings callSettings = null) =>
                throw new RequestMadeException();
            public override MutateRowResponse MutateRow(MutateRowRequest request, CallSettings callSettings = null) =>
                throw new RequestMadeException();
            public override Task<MutateRowResponse> MutateRowAsync(MutateRowRequest request, CallSettings callSettings = null) =>
                throw new RequestMadeException();
            public override BigtableServiceApiClient.MutateRowsStream MutateRows(MutateRowsRequest request, CallSettings callSettings = null) =>
                throw new RequestMadeException();
            public override ReadModifyWriteRowResponse ReadModifyWriteRow(ReadModifyWriteRowRequest request, CallSettings callSettings = null) =>
                throw new RequestMadeException();
            public override Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(ReadModifyWriteRowRequest request, CallSettings callSettings = null) =>
                throw new RequestMadeException();
            public override ReadRowsStream ReadRows(ReadRowsRequest request, CallSettings callSettings = null) =>
                throw new RequestMadeException();
            public override BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(SampleRowKeysRequest request, CallSettings callSettings = null) =>
                throw new RequestMadeException();
        }

        [Fact]
        public async Task CheckAndMutateRow_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");

            await CheckAndMutateRow_ValidateArguments<RequestMadeException>(
                tableName,
                "abc",
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new[] { Mutations.DeleteFromRow() });
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
            var tableName = new TableName("project", "instance", "table");

            await MutateRow_ValidateArguments<RequestMadeException>(tableName, "abc", new[] { Mutations.DeleteFromRow() });
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
        public void MutateRows_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");
            MutateRows_ValidateArguments<RequestMadeException>(
                tableName,
                new[] { Mutations.CreateEntry("abc", Mutations.DeleteFromRow()) });
        }

        [Fact]
        public void MutateRows_Validate_TableName()
        {
            MutateRows_ValidateArguments<ArgumentNullException>(
                null,
                new[] { Mutations.CreateEntry("abc", Mutations.DeleteFromRow()) });
        }

        [Fact]
        public void MutateRows_Validate_Mutations()
        {
            var tableName = new TableName("project", "instance", "table");
            MutateRows_ValidateArguments<ArgumentNullException>(tableName, null);
            MutateRows_ValidateArguments<ArgumentException>(tableName, new MutateRowsRequest.Types.Entry[0]);
            MutateRows_ValidateArguments<ArgumentException>(tableName, new MutateRowsRequest.Types.Entry[] { null });
        }

        private void MutateRows_ValidateArguments<TException>(
            TableName tableName,
            IEnumerable<MutateRowsRequest.Types.Entry> entries)
            where TException : Exception
        {
            var client = new TestBigtableClient();
            Assert.Throws<TException>(
                () => client.MutateRows(tableName, entries?.ToArray()));
            Assert.Throws<TException>(
                () => client.MutateRows(tableName, entries, CallSettings.FromCancellationToken(default)));
        }

        [Fact]
        public async Task ReadModifyWriteRow_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");
            await ReadModifyWriteRow_ValidateArguments<RequestMadeException>(
                tableName, "abc", new[] { ReadModifyWriteRules.Append("a", "b", "c") } );
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
            var tableName = new TableName("project", "instance", "table");
            await ReadRow_ValidateArguments<RequestMadeException>(tableName, "abc", null);
            await ReadRow_ValidateArguments<RequestMadeException>(tableName, "abc", RowFilters.CellsPerColumnLimit(1));
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
                });

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

            ReadRows_ValidateArguments<RequestMadeException>(tableName, null, null, null);
            ReadRows_ValidateArguments<RequestMadeException>(
                tableName,
                RowSet.FromRowKey("abc"),
                RowFilters.BlockAllFilter(),
                0);
            ReadRows_ValidateArguments<RequestMadeException>(
                tableName,
                RowSet.FromRowRanges(RowRange.ClosedOpen("", "z")),
                RowFilters.CellsPerRowLimit(1),
                123);
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
            var client = new TestBigtableClient();
            Assert.Throws<TException>(
                () => client.ReadRows(tableName, rows, filter, rowsLimit));
        }

        [Fact]
        public void SampleRowKeys_Valid_Request()
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            Assert.Throws<RequestMadeException>(() => client.SampleRowKeys(tableName));
        }

        [Fact]
        public void SampleRowKeys_Validate_TableName()
        {
            var client = new TestBigtableClient();
            Assert.Throws<ArgumentNullException>(() => client.SampleRowKeys((TableName)null));
        }
    }
}
