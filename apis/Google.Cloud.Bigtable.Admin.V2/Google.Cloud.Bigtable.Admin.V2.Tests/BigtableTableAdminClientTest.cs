// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.Admin.V2.Tests
{
    public class BigtableTableAdminClientTest
    {
        [Fact]
        public async Task DropAllRows_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");
            await DropAllRows_ValidateArguments<NotImplementedException>(tableName);
        }

        [Fact]
        public async Task DropAllRows_Validate_TableName()
        {
            await DropAllRows_ValidateArguments<ArgumentNullException>(null);
        }

        private async Task DropAllRows_ValidateArguments<TException>(TableName tableName)
            where TException : Exception
        {
            var client = new Mock<BigtableTableAdminClient> { CallBase = true };
            Assert.Throws<TException>(
                () => client.Object.DropAllRows(
                    tableName, CallSettings.FromCancellationToken(default)));
            
            await Assert.ThrowsAsync<TException>(
                () => client.Object.DropAllRowsAsync(
                    tableName, CallSettings.FromCancellationToken(default)));
        }

        [Fact]
        public async Task DropRowRange_Valid_Request()
        {
            var tableName = new TableName("project", "instance", "table");
            await DropRowRange_ValidateArguments<NotImplementedException>(
                tableName,
                ByteString.CopyFromUtf8("abc"));
        }

        [Fact]
        public async Task DropRowRange_Validate_TableName()
        {
            await DropRowRange_ValidateArguments<ArgumentNullException>(
                null,
                ByteString.CopyFromUtf8("abc"));
        }

        [Fact]
        public async Task DropRowRange_Validate_RowKeyPrefix()
        {
            var tableName = new TableName("project", "instance", "table");
            await DropRowRange_ValidateArguments<ArgumentNullException>(
                tableName,
                null);
            await DropRowRange_ValidateArguments<ArgumentException>(
                tableName,
                ByteString.Empty);
        }

        private async Task DropRowRange_ValidateArguments<TException>(TableName tableName, ByteString rowKeyPrefix)
            where TException : Exception
        {
            var client = new Mock<BigtableTableAdminClient> { CallBase = true };
            Assert.Throws<TException>(
                () => client.Object.DropRowRange(
                    tableName, rowKeyPrefix, CallSettings.FromCancellationToken(default)));
            
            await Assert.ThrowsAsync<TException>(
                () => client.Object.DropRowRangeAsync(
                    tableName, rowKeyPrefix, CallSettings.FromCancellationToken(default)));
        }
    }
}
