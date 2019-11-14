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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.LongRunning;
using Grpc.Core;
using Xunit;
using Google.Cloud.Bigtable.Common.V2;

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
            await DropRowRange_ValidateArguments<ArgumentException>(
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

        //TODO: Remove ListTables() tests once the unit test auto-gen is extended to support paged response methods.
        [Fact]
        public void ListTables()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient =
                new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            ListTablesRequest expectedRequest = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Table expectedTableResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            ListTablesResponse expextedListTablesResponse = new ListTablesResponse
            {
                Tables = {expectedTableResponse}
            };
            mockGrpcClient.Setup(x => x.ListTables(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expextedListTablesResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            PagedEnumerable<ListTablesResponse, Table> response = client.ListTables(name);
            Assert.Same(expectedTableResponse, response.Single());
            Assert.Same(expextedListTablesResponse, response.AsRawResponses().ToList().Single());
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListTablesAsync()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient =
                new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            ListTablesRequest expectedRequest = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Table expectedTableResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            ListTablesResponse expextedListTablesResponse = new ListTablesResponse
            {
                Tables = { expectedTableResponse }
            };
            mockGrpcClient.Setup(x => x.ListTablesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListTablesResponse>(Task.FromResult(expextedListTablesResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            InstanceName name = new InstanceName("[PROJECT]", "[INSTANCE]");
            PagedAsyncEnumerable<ListTablesResponse, Table> responseAsync = client.ListTablesAsync(name);
            Assert.Same(expectedTableResponse, await responseAsync.SingleAsync());
            List<ListTablesResponse> response = await responseAsync.AsRawResponses().ToListAsync();
            Assert.Same(expextedListTablesResponse, response.Single());
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListTables2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient =
                new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            ListTablesRequest request = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Table expectedTableResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            ListTablesResponse expextedListTablesResponse = new ListTablesResponse
            {
                Tables = { expectedTableResponse }
            };
            mockGrpcClient.Setup(x => x.ListTables(request, It.IsAny<CallOptions>()))
                .Returns(expextedListTablesResponse);
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            PagedEnumerable<ListTablesResponse, Table> response = client.ListTables(request);
            Assert.Same(expectedTableResponse, response.Single());
            Assert.Same(expextedListTablesResponse, response.AsRawResponses().ToList().Single());
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListTablesAsync2()
        {
            Mock<BigtableTableAdmin.BigtableTableAdminClient> mockGrpcClient =
                new Mock<BigtableTableAdmin.BigtableTableAdminClient>(MockBehavior.Strict);
            ListTablesRequest request = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            Table expectedTableResponse = new Table
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            ListTablesResponse expextedListTablesResponse = new ListTablesResponse
            {
                Tables = { expectedTableResponse }
            };
            mockGrpcClient.Setup(x => x.ListTablesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListTablesResponse>(Task.FromResult(expextedListTablesResponse), null, null, null, null));
            BigtableTableAdminClient client = new BigtableTableAdminClientImpl(mockGrpcClient.Object, null);
            PagedAsyncEnumerable<ListTablesResponse, Table> responseAsync = client.ListTablesAsync(request);
            Assert.Same(expectedTableResponse, await responseAsync.SingleAsync());
            List<ListTablesResponse> response = await responseAsync.AsRawResponses().ToListAsync();
            Assert.Same(expextedListTablesResponse, response.Single());
            mockGrpcClient.VerifyAll();
        }

    }
}
