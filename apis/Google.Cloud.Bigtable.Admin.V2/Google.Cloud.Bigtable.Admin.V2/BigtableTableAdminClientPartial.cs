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
using Google.Cloud.Bigtable.Common.V2;
using Grpc.Core;
using System.Threading;
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
        public Task DropAllRowsAsync(TableName tableName, CallSettings callSettings = null) =>
            DropRowRangeAsync(
                CreateDropRowRangeRequest(tableName, rowKeyPrefix: default, deleteAllDataFromTable: true),
                callSettings);

        /// <summary>
        /// Permanently drop/delete all rows in the table.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="DropAllRowsAsync(TableName, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table on which to drop the rows. Must not be null.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public Task DropAllRowsAsync(TableName tableName, CancellationToken cancellationToken) =>
            DropAllRowsAsync(tableName, CallSettings.FromCancellationToken(cancellationToken));

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
        public void DropAllRows(TableName tableName, CallSettings callSettings = null) =>
            DropRowRange(
                CreateDropRowRangeRequest(tableName, rowKeyPrefix: default, deleteAllDataFromTable: true),
                callSettings);

        /// <summary>
        /// Permanently drop/delete all rows that start with this row key prefix.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="DropRowRangeAsync(DropRowRangeRequest, CallSettings)"/>.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKeyPrefix"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
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
            BigtableByteString rowKeyPrefix,
            CallSettings callSettings = null) =>
            DropRowRangeAsync(
                CreateDropRowRangeRequest(tableName, rowKeyPrefix, deleteAllDataFromTable: false),
                callSettings);

        /// <summary>
        /// Permanently drop/delete all rows that start with this row key prefix.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="DropRowRangeAsync(TableName, BigtableByteString, CallSettings)"/>.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKeyPrefix"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table on which to drop a range of rows. Must not be null.
        /// </param>
        /// <param name="rowKeyPrefix">
        /// The prefix of all rows which should be dropped. Cannot be null or empty.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public Task DropRowRangeAsync(
            TableName tableName,
            BigtableByteString rowKeyPrefix,
            CancellationToken cancellationToken) =>
            DropRowRangeAsync(tableName, rowKeyPrefix, CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Permanently drop/delete all rows that start with this row key prefix.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="DropRowRange(DropRowRangeRequest, CallSettings)"/>.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKeyPrefix"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
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
            BigtableByteString rowKeyPrefix,
            CallSettings callSettings = null) =>
            DropRowRange(
                CreateDropRowRangeRequest(tableName, rowKeyPrefix, deleteAllDataFromTable: false),
                callSettings);

        private static DropRowRangeRequest CreateDropRowRangeRequest(
            TableName tableName,
            BigtableByteString rowKeyPrefix,
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
                GaxPreconditions.CheckArgument(
                    rowKeyPrefix.Length != 0, nameof(rowKeyPrefix),
                    "The row key prefix must not empty");
                request.RowKeyPrefix = rowKeyPrefix.Value;
            }
            return request;
        }
    }

    public partial class BigtableTableAdminClientBuilder
    {
        private const string s_emulatorHostEnvironmentVariable = "BIGTABLE_EMULATOR_HOST";
        private static readonly string[] s_emulatorEnvironmentVariables = { s_emulatorHostEnvironmentVariable };

        /// <summary>
        /// Specifies how the builder responds to the presence of emulator environment variables.
        /// </summary>
        /// <remarks>
        /// This property defaults to <see cref="EmulatorDetection.None"/>, meaning that
        /// environment variables are ignored.
        /// </remarks>
        public new EmulatorDetection EmulatorDetection
        {
            get => base.EmulatorDetection;
            set => base.EmulatorDetection = value;
        }

        partial void InterceptBuild(ref BigtableTableAdminClient client) => client = MaybeCreateEmulatorClientBuilder()?.Build();

        partial void InterceptBuildAsync(CancellationToken cancellationToken, ref Task<BigtableTableAdminClient> task) =>
            task = MaybeCreateEmulatorClientBuilder()?.BuildAsync(cancellationToken);

        private BigtableTableAdminClientBuilder MaybeCreateEmulatorClientBuilder()
        {
            var emulatorEnvironment = GetEmulatorEnvironment(s_emulatorEnvironmentVariables, s_emulatorEnvironmentVariables);
            if (emulatorEnvironment is null)
            {
                return null;
            }
            // We don't set the EmulatorDetection property here to avoid recursively calling
            // MaybeCreateEmulatorClientBuilder().
            var builder = new BigtableTableAdminClientBuilder
            {
                Settings = Settings,
                Endpoint = emulatorEnvironment[s_emulatorHostEnvironmentVariable],
                ChannelCredentials = ChannelCredentials.Insecure
            };
            builder.CopySettingsForEmulator(this);
            return builder;
        }
    }
}
