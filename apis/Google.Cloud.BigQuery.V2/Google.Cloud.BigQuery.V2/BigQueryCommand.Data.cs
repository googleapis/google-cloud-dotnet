// Copyright 2017 Google Inc. All Rights Reserved.
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

using System;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;

namespace Google.Cloud.BigQuery.V2
{
    public sealed partial class BigQueryCommand : DbCommand
    {
        /// <summary>
        ///     CommandOptions provides options and what sort of command is being executed.
        ///     It can never be null and defaults to a sql command (DML or Query).
        /// </summary>
        private BigQueryCommandOptions _commandOptions = new SqlCommandOptions();

        internal CancellationTokenSource SynchronousCancellationTokenSource { get; } = new CancellationTokenSource();

        /// <inheritdoc />
        public override string CommandText
        {
            get => CommandOptions.CommandText;
            set => CommandOptions.CommandText = value;
        }

        /// <inheritdoc />
        public override int CommandTimeout { get; set; }

        /// <inheritdoc />
        public override CommandType CommandType
        {
            get => CommandType.Text;
            set
            {
                if (value != CommandType.Text)
                    throw new NotSupportedException("Cloud BigQuery only supports CommandType.Text.");
            }
        }

        /// <summary>
        /// </summary>
        public BigQueryCommandType BigQueryCommandType => CommandOptions.BigQueryCommandType;

        /// <inheritdoc />
        public override UpdateRowSource UpdatedRowSource
        {
            get => UpdateRowSource.None;
            set
            {
                if (value != UpdateRowSource.None)
                    throw new NotSupportedException(
                        "Cloud BigQuery does not support updating datasets on update/insert queries."
                        + " Please use UUIDs instead of auto increment columns, which can be created on the client.");
            }
        }

        /// <summary>
        /// </summary>
        public BigQueryConnection BigQueryConnection
        {
            get => CommandOptions.BigQueryConnection;
            set => CommandOptions.BigQueryConnection = value;
        }

        /// <summary>
        /// </summary>
        public BigQueryCommandOptions CommandOptions
        {
            get => _commandOptions;
            set
            {
                GaxPreconditions.CheckNotNull(value, nameof(value));
                _commandOptions = value;
            }
        }

        /// <inheritdoc />
        protected override DbConnection DbConnection
        {
            get => BigQueryConnection;
            set => BigQueryConnection = (BigQueryConnection) value;
        }

        /// <inheritdoc />
        protected override DbParameterCollection DbParameterCollection => Parameters;

        /// <inheritdoc />
        protected override DbTransaction DbTransaction { get; set; }

        /// <inheritdoc />
        public override bool DesignTimeVisible { get; set; }

        /// <inheritdoc />
        public override void Cancel()
        {
            SynchronousCancellationTokenSource.Cancel();
        }

        /// <inheritdoc />
        public override object ExecuteScalar() => ExecuteScalarAsync(SynchronousCancellationTokenSource.Token)
            .ResultWithUnwrappedExceptions();

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task<object> ExecuteScalarAsync(CancellationToken cancellationToken)
            => ExecuteScalarAsync<object>(cancellationToken);

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> ExecuteScalarAsync<T>(CancellationToken cancellationToken)
        {
            using (var reader = await ExecuteReaderAsync(cancellationToken)
                .ConfigureAwait(false))
            {
                if (await reader.ReadAsync(cancellationToken).ConfigureAwait(false) && reader.HasRows &&
                    reader.FieldCount > 0)
                    return reader.GetFieldValue<T>(0);
            }
            return default(T);
        }

        /// <inheritdoc />
        public override int ExecuteNonQuery()
            => ExecuteNonQueryAsync(SynchronousCancellationTokenSource.Token).ResultWithUnwrappedExceptions();

        /// <inheritdoc />
        public override Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken)
        {
            AssertCommandOptions();
            return CommandOptions.ExecuteNonQueryAsync(BigQueryConnection, cancellationToken);
        }

        /// <inheritdoc />
        public override void Prepare()
        {
            //BigQuery does not support preoptimized queries nor 2 phase commit transactions.
            //Note: We cannot throw here because that will break some datatable scenarios.
        }

        /// <inheritdoc />
        protected override DbParameter CreateDbParameter() => new BigQueryParameter();

        /// <summary>
        /// </summary>
        public new Task<BigQueryDataReader> ExecuteReaderAsync()
            => ExecuteReaderAsync(CommandBehavior.Default, CancellationToken.None);

        /// <summary>
        /// </summary>
        public new async Task<BigQueryDataReader> ExecuteReaderAsync(CommandBehavior behavior,
            CancellationToken cancellationToken) => (BigQueryDataReader) await ExecuteDbDataReaderAsync(behavior,
                cancellationToken)
            .ConfigureAwait(false);

        /// <inheritdoc />
        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
        {
            ValidateCommandBehavior(behavior);
            return ExecuteDbDataReaderAsync(
                    behavior,
                    SynchronousCancellationTokenSource.Token)
                .ResultWithUnwrappedExceptions();
        }


        /// <inheritdoc />
        protected override Task<DbDataReader> ExecuteDbDataReaderAsync(
            CommandBehavior behavior,
            CancellationToken cancellationToken)
        {
            AssertCommandOptions();
            return CommandOptions.ExecuteDbDataReaderAsync(BigQueryConnection, behavior, cancellationToken);
        }

        /// <summary>
        /// </summary>
        public BigQueryJob StartJob() => StartJobAsync(SynchronousCancellationTokenSource.Token)
            .ResultWithUnwrappedExceptions();

        /// <summary>
        /// </summary>
        public async Task<BigQueryJob> StartJobAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            AssertCommandOptions();
            var job = await CommandOptions.StartJobAsync(BigQueryConnection, cancellationToken).ConfigureAwait(false);
            if (job == null)
                throw new NotSupportedException("This command type does not support a long running BigQueryJob");
            return job;
        }

        private void AssertCommandOptions()
        {
            // There must be a valid and open connection.
            if (CommandOptions == null)
                throw new InvalidOperationException(
                    $"{nameof(CommandOptions)} must not be null.");
        }

        // ReSharper disable once UnusedParameter.Local
        private void ValidateCommandBehavior(CommandBehavior behavior)
        {
            if ((behavior & CommandBehavior.KeyInfo) == CommandBehavior.KeyInfo)
                throw new NotSupportedException(
                    $"{nameof(CommandBehavior.KeyInfo)} is not supported by Cloud BigQuery.");
            if ((behavior & CommandBehavior.SchemaOnly) == CommandBehavior.SchemaOnly)
                throw new NotSupportedException(
                    $"{nameof(CommandBehavior.SchemaOnly)} is not supported by Cloud BigQuery.");
        }
    }
}