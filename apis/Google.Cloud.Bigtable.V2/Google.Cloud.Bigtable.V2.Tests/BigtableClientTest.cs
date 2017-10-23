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
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.Tests
{
    public class BigtableClientTest
    {
        [Fact]
        public async Task MutateRow_Validate_TableName()
        {
            var client = BigtableClient.Create();
            Assert.Throws<ArgumentNullException>(
                () => client.MutateRow(null, "abc", Mutations.DeleteFromRow()));
            Assert.Throws<ArgumentNullException>(
                () => client.MutateRow(null, "abc", new[] { Mutations.DeleteFromRow() }, CallSettings.FromCancellationToken(default)));
            await Assert.ThrowsAsync<ArgumentNullException>(
                () => client.MutateRowAsync(null, "abc", new[] { Mutations.DeleteFromRow() }, CancellationToken.None));
            await Assert.ThrowsAsync<ArgumentNullException>(
                () => client.MutateRowAsync(null, "abc", new[] { Mutations.DeleteFromRow() }, CallSettings.FromCancellationToken(default)));
        }

        [Fact]
        public async Task MutateRow_Validate_RowKey()
        {
            var client = BigtableClient.Create();
            var tableName = new TableName("project", "instance", "table");
            Assert.Throws<ArgumentException>(
                () => client.MutateRow(tableName, "", Mutations.DeleteFromRow()));
            Assert.Throws<ArgumentException>(
                () => client.MutateRow(tableName, new byte[0], new[] { Mutations.DeleteFromRow() }, CallSettings.FromCancellationToken(default)));
            await Assert.ThrowsAsync<ArgumentException>(
                () => client.MutateRowAsync(tableName, ByteString.Empty, new[] { Mutations.DeleteFromRow() }, CancellationToken.None));
            await Assert.ThrowsAsync<ArgumentException>(
                () => client.MutateRowAsync(tableName, "", new[] { Mutations.DeleteFromRow() }, CallSettings.FromCancellationToken(default)));
        }

        [Fact]
        public async Task MutateRow_Validate_Mutations()
        {
            var client = BigtableClient.Create();
            var tableName = new TableName("project", "instance", "table");
            Assert.Throws<ArgumentNullException>(
                () => client.MutateRow(tableName, "abc", null));
            Assert.Throws<ArgumentNullException>(
                () => client.MutateRow(tableName, "abc", null, CallSettings.FromCancellationToken(default)));
            await Assert.ThrowsAsync<ArgumentNullException>(
                () => client.MutateRowAsync(tableName, "abc", null, CancellationToken.None));
            await Assert.ThrowsAsync<ArgumentNullException>(
                () => client.MutateRowAsync(tableName, "abc", null, CallSettings.FromCancellationToken(default)));
        }

        [Fact]
        public async Task MutateRow_Validate_Mutations_Entry()
        {
            var client = BigtableClient.Create();
            var tableName = new TableName("project", "instance", "table");
            Assert.Throws<ArgumentException>(
                () => client.MutateRow(tableName, "abc", new Mutation[] { null }));
            Assert.Throws<ArgumentException>(
                () => client.MutateRow(tableName, "abc", new Mutation[] { null }, CallSettings.FromCancellationToken(default)));
            await Assert.ThrowsAsync<ArgumentException>(
                () => client.MutateRowAsync(tableName, "abc", new Mutation[] { null }, CancellationToken.None));
            await Assert.ThrowsAsync<ArgumentException>(
                () => client.MutateRowAsync(tableName, "abc", new Mutation[] { null }, CallSettings.FromCancellationToken(default)));
        }
    }
}
