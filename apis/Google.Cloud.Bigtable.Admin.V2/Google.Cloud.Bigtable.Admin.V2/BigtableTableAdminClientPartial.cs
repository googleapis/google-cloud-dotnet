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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class BigtableTableAdminClient
    {
        /// <summary>
        /// Permanently drop/delete all rows in the table.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="DropRowRangeAsync(DropRowRangeRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table on which to drop the rows. Must not be null.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public Task DropAllRowsAsync(
            TableName tableName,
            CallSettings callSettings = null) =>
            DropRowRangeAsync(
                CreateDropRowRangeRequest(tableName, rowKeyPrefix: null, deleteAllDataFromTable: true),
                callSettings);

        /// <summary>
        /// Permanently drop/delete all rows in the table.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="DropRowRange(DropRowRangeRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table on which to drop the rows. Must not be null.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public void DropAllRows(
            TableName tableName,
            CallSettings callSettings = null) =>
            DropRowRange(
                CreateDropRowRangeRequest(tableName, rowKeyPrefix: null, deleteAllDataFromTable: true),
                callSettings);

        /// <summary>
        /// Permanently drop/delete all rows that start with this row key prefix.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="DropRowRangeAsync(DropRowRangeRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table on which to drop a range of rows. Must not be null.
        /// </param>
        /// <param name="rowKeyPrefix">
        /// The prefix of all rows which should be dropped. Cannot be null or empty.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public Task DropRowRangeAsync(
            TableName tableName,
            ByteString rowKeyPrefix, // TODO: Use BigtableByteString when shared
            CallSettings callSettings = null) =>
            DropRowRangeAsync(
                CreateDropRowRangeRequest(tableName, rowKeyPrefix, deleteAllDataFromTable: false),
                callSettings);

        /// <summary>
        /// Permanently drop/delete all rows that start with this row key prefix.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="DropRowRange(DropRowRangeRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table on which to drop a range of rows. Must not be null.
        /// </param>
        /// <param name="rowKeyPrefix">
        /// The prefix of all rows which should be dropped. Cannot be null or empty.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public void DropRowRange(
            TableName tableName,
            ByteString rowKeyPrefix, // TODO: Use BigtableByteString when shared
            CallSettings callSettings = null) =>
            DropRowRange(
                CreateDropRowRangeRequest(tableName, rowKeyPrefix, deleteAllDataFromTable: false),
                callSettings);

        private static DropRowRangeRequest CreateDropRowRangeRequest(
            TableName tableName,
            ByteString rowKeyPrefix,
            bool deleteAllDataFromTable)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            var request = new DropRowRangeRequest { TableName = tableName };

            if (deleteAllDataFromTable)
            {
                request.DeleteAllDataFromTable = true;
            }
            else
            {
                GaxPreconditions.CheckNotNull(rowKeyPrefix, nameof(rowKeyPrefix));
                GaxPreconditions.CheckArgument(
                    rowKeyPrefix.Length != 0, nameof(rowKeyPrefix),
                    "The row key prefix must not empty");
                request.RowKeyPrefix = rowKeyPrefix;
            }
            return request;
        }
    }
}
