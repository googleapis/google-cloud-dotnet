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
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class BigtableClientTest
    {
        private class TestBigtableClient : BigtableClient { }

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

        [Fact]
        public async Task CheckAndMutateRow_Validate_RowKey()
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            await CheckAndMutateRow_ValidateArguments<ArgumentException>(
                tableName,
                "",
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new[] { Mutations.DeleteFromRow() });
            await CheckAndMutateRow_ValidateArguments<ArgumentException>(
                tableName,
                new byte[0],
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new[] { Mutations.DeleteFromRow() });
            await CheckAndMutateRow_ValidateArguments<ArgumentException>(
                tableName,
                ByteString.Empty,
                RowFilters.PassAllFilter(),
                new[] { Mutations.DeleteFromRow() },
                new[] { Mutations.DeleteFromRow() });
            await CheckAndMutateRow_ValidateArguments<ArgumentException>(
                tableName,
                default,
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

        [Fact]
        public async Task MutateRow_Validate_RowKey()
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            await MutateRow_ValidateArguments<ArgumentException>(tableName, "", new[] { Mutations.DeleteFromRow() });
            await MutateRow_ValidateArguments<ArgumentException>(tableName, new byte[0], new[] { Mutations.DeleteFromRow() });
            await MutateRow_ValidateArguments<ArgumentException>(tableName, ByteString.Empty, new[] { Mutations.DeleteFromRow() });
            await MutateRow_ValidateArguments<ArgumentException>(tableName, default, new[] { Mutations.DeleteFromRow() });
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

        [Fact]
        public async Task ReadRow_Validare_RowKey()
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            await ReadRow_ValidateArguments<ArgumentException>(tableName, "", null);
            await ReadRow_ValidateArguments<ArgumentException>(tableName, new byte[0], null);
            await ReadRow_ValidateArguments<ArgumentException>(tableName, ByteString.Empty, null);
            await ReadRow_ValidateArguments<ArgumentException>(tableName, default, null);
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
                new RowSet { RowKeys = { (BigtableByteString)"abc" } },
                RowFilters.BlockAllFilter(),
                0);
            ReadRows_ValidateArguments<NotImplementedException>(
                tableName,
                // TODO: Use RowRange helpers when available.
                new RowSet { RowRanges = { new RowRange { StartKeyClosed = (BigtableByteString)"", EndKeyOpen = (BigtableByteString)"z" } } },
                RowFilters.CellsPerRowLimit(1),
                123);
        }

        [Fact]
        public void ReadRows_Validate_TableName()
        {
            var client = new TestBigtableClient();
            var rows = new RowSet { RowKeys = { (BigtableByteString)"abc" } };
            ReadRows_ValidateArguments<ArgumentNullException>(null, rows, null, null);
        }

        [Fact]
        public void ReadRows_Validate_RowsLimit()
        {
            var client = new TestBigtableClient();
            var tableName = new TableName("project", "instance", "table");
            var rows = new RowSet { RowKeys = { (BigtableByteString)"abc" } };
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
