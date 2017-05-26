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
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1;
using Google.Protobuf.WellKnownTypes;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// </summary>
    public sealed class SpannerCommand : DbCommand
#if NET45 || NET451
        , ICloneable
#endif
    {
        private readonly CancellationTokenSource _synchronousCancellationTokenSource = new CancellationTokenSource();
        private int _commandTimeout;
        private SpannerTransaction _transaction;

        /// <summary>
        /// </summary>
        public SpannerCommand()
        {
            DesignTimeVisible = true;
            _commandTimeout = (int)ConnectionPoolOptions.Instance.Timeout.TotalSeconds;
        }

        private SpannerCommand(
            SpannerConnection connection,
            SpannerTransaction transaction,
            SpannerParameterCollection parameters) : this() {
            SpannerConnection = connection;
            _transaction = transaction;
            Parameters = parameters;
        }
        /// <summary>
        /// </summary>
        /// <param name="commandTextBuilder"></param>
        /// <param name="connection"></param>
        /// <param name="transaction"></param>
        /// <param name="parameters"></param>
        public SpannerCommand(SpannerCommandTextBuilder commandTextBuilder, SpannerConnection connection,
            SpannerTransaction transaction = null, SpannerParameterCollection parameters = null)
            : this(connection, transaction, parameters)
        {
            GaxPreconditions.CheckNotNull(commandTextBuilder, nameof(commandTextBuilder));
            GaxPreconditions.CheckNotNull(connection, nameof(connection));

            SpannerCommandTextBuilder = commandTextBuilder;
        }

        /// <summary>
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="connection"></param>
        /// <param name="transaction"></param>
        /// <param name="parameters"></param>
        public SpannerCommand(string commandText, SpannerConnection connection, SpannerTransaction transaction = null,
            SpannerParameterCollection parameters = null)
            : this(SpannerCommandTextBuilder.FromCommandText(commandText), connection, transaction, parameters)
        {
        }

        /// <inheritdoc />
        public override string CommandText
        {
            get { return SpannerCommandTextBuilder?.ToString() ?? string.Empty; }
            set { SpannerCommandTextBuilder = SpannerCommandTextBuilder.FromCommandText(value); }
        }

        /// <inheritdoc />
        public override int CommandTimeout
        {
            get { return _commandTimeout; }
            set { _commandTimeout = value; }
        }

        /// <inheritdoc />
        public override CommandType CommandType
        {
            get { return CommandType.Text; }
            set
            {
                if (value != CommandType.Text)
                    throw new NotSupportedException("Cloud Spanner only supports CommandType.Text.");
            }
        }

        /// <inheritdoc />
        public override bool DesignTimeVisible { get; set; }

        /// <summary>
        /// </summary>
        public new SpannerParameterCollection Parameters { get; }

        /// <summary>
        /// </summary>
        public SpannerConnection SpannerConnection { get; set; }

        /// <inheritdoc />
        public override UpdateRowSource UpdatedRowSource
        {
            get { return UpdateRowSource.None; }
            set
            {
                if (value != UpdateRowSource.None)
                {
                    throw new NotSupportedException("Cloud Spanner does not support updating datasets on update/insert queries."
                        + " Please use UUIDs instead of auto increment columns, which can be created on the client.");
                }
            }
        }

        /// <inheritdoc />
        protected override DbConnection DbConnection
        {
            //TODO(benwu): update to use newer lambda forms for get/set. ditto for other places.
            get { return SpannerConnection; }
            set { SpannerConnection = (SpannerConnection) value; }
        }

        /// <inheritdoc />
        protected override DbParameterCollection DbParameterCollection => Parameters;

        /// <inheritdoc />
        protected override DbTransaction DbTransaction
        {
            get { return _transaction; }
            set { _transaction = (SpannerTransaction) value; }
        }

        /// <summary>
        /// </summary>
        internal SpannerCommandTextBuilder SpannerCommandTextBuilder { get; set; }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new SpannerCommand (SpannerConnection, _transaction, Parameters ) {
                DesignTimeVisible = DesignTimeVisible,
                SpannerCommandTextBuilder = SpannerCommandTextBuilder,
                CommandTimeout = CommandTimeout
            };
        }

        /// <inheritdoc />
        public override void Cancel() => _synchronousCancellationTokenSource.Cancel();

        /// <inheritdoc />
        public override int ExecuteNonQuery() => ExecuteNonQueryAsync(_synchronousCancellationTokenSource.Token).ResultWithUnwrappedExceptions();


        /// <inheritdoc />
        public override async Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken)
        {
            // There must be a valid and open connection.
            if (SpannerConnection == null)
                throw new InvalidOperationException(
                    "You must assign a SpannerConnection to this command to execute it.");
            if (SpannerCommandTextBuilder.SpannerCommandType == SpannerCommandType.Select)
                throw new InvalidOperationException(
                    "You can only call ExecuteNonQueryAsync on a Delete, Insert, InsertUpdate, or Update Command");
            if (!SpannerConnection.IsOpen)
                await SpannerConnection.OpenAsync(cancellationToken).ConfigureAwait(false);
            if (!SpannerConnection.IsOpen)
                throw new InvalidOperationException(
                    "Unable to open the Spanner connection to the database to execute the query.");

            // Execute the command.
            var mutations = new List<Mutation>();
            if (SpannerCommandTextBuilder.SpannerCommandType != SpannerCommandType.Delete) {
                var w = new Mutation.Types.Write {
                    Table = SpannerCommandTextBuilder.TargetTable,
                    Columns = {
                        Parameters.Cast<SpannerParameter>()
                            .Select(x => x.SourceColumn ?? x.ParameterName)
                    },
                    Values = {
                        new ListValue {
                            Values = {
                                Parameters.Cast<SpannerParameter>()
                                    .Select(x => TypeMap.ToValue(x.Value, x.TypeCode))
                            }
                        }
                    }
                };
                switch (SpannerCommandTextBuilder.SpannerCommandType) {
                    case SpannerCommandType.Update:
                        mutations.Add(new Mutation {Update = w});
                        break;
                    case SpannerCommandType.Insert:
                        mutations.Add(new Mutation {Insert = w});
                        break;
                    case SpannerCommandType.InsertOrUpdate:
                        mutations.Add(new Mutation {InsertOrUpdate = w});
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            } else {
                var w = new Mutation.Types.Delete {
                    Table = SpannerCommandTextBuilder.TargetTable,
                    KeySet =
                        new KeySet {
                            Keys = {
                                new ListValue {
                                    Values = {
                                        Parameters.Cast<SpannerParameter>()
                                            .Select(x => TypeMap.ToValue(x.Value, x.TypeCode))
                                    }
                                }
                            }
                        }
                };
                mutations.Add(new Mutation {Delete = w});
            }

            // Make the request.  This will commit immediately or not depending on whether a transaction was explicitly created.
            await GetSpannerTransaction().ExecuteMutationsAsync(mutations, cancellationToken)
                .WithTimeout(TimeSpan.FromSeconds(CommandTimeout), "The timeout of the SpannerCommand was exceeded.");
            // Return the number of records affected.
            return mutations.Count;
        }

        /// <inheritdoc />
        public override object ExecuteScalar()
        {
            return ExecuteScalarAsync(_synchronousCancellationTokenSource.Token).ResultWithUnwrappedExceptions();
        }

        /// <summary>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<T> ExecuteScalarAsync<T>()
        {
            return ExecuteScalarAsync<T>(CancellationToken.None);
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<T> ExecuteScalarAsync<T>(CancellationToken cancellationToken)
        {
            using (var reader = await ExecuteDbDataReaderAsync(CommandBehavior.SingleRow, cancellationToken)
                .ConfigureAwait(false))
            {
                if (await reader.ReadAsync(cancellationToken).ConfigureAwait(false) && reader.HasRows &&
                    reader.FieldCount > 0)
                    return reader.GetFieldValue<T>(0);
            }
            return default(T);
        }

        /// <inheritdoc />
        public override async Task<object> ExecuteScalarAsync(CancellationToken cancellationToken)
        {
            using (var reader = await ExecuteDbDataReaderAsync(CommandBehavior.SingleRow, cancellationToken)
                .ConfigureAwait(false))
            {
                if (await reader.ReadAsync(cancellationToken).ConfigureAwait(false) && reader.HasRows &&
                    reader.FieldCount > 0)
                    return reader[0];
            }
            return null;
        }

        /// <inheritdoc />
        public override void Prepare()
        {
            //Spanner does not support preoptimized queries nor 2 phase commit transactions.
        }

        /// <inheritdoc />
        protected override DbParameter CreateDbParameter()
        {
            return new SpannerParameter();
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
        }

        /// <inheritdoc />
        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
        {
            ValidateCommandBehavior(behavior);
            return ExecuteDbDataReaderAsync(behavior, _synchronousCancellationTokenSource.Token).ResultWithUnwrappedExceptions();
        }

        /// <inheritdoc />
        protected override async Task<DbDataReader> ExecuteDbDataReaderAsync(CommandBehavior behavior,
            CancellationToken cancellationToken)
        {
            // There must be a valid and open connection.
            if (SpannerConnection == null)
                throw new InvalidOperationException(
                    "You must assign a SpannerConnection to this command to execute it.");
            if (SpannerCommandTextBuilder.SpannerCommandType != SpannerCommandType.Select)
                throw new InvalidOperationException("You can only call ExecuteReader on a Select Command");
            if (!SpannerConnection.IsOpen)
                await SpannerConnection.OpenAsync(cancellationToken).ConfigureAwait(false);
            if (!SpannerConnection.IsOpen)
                throw new InvalidOperationException("Unable to open the Spanner connection to the database.");

            var request = new ExecuteSqlRequest
            {
                Sql = CommandText
            };

            if (Parameters?.Count > 0)
            {
                request.Params = new Struct();
                Parameters.FillSpannerInternalValues(request.Params.Fields, request.ParamTypes);
            }

            // Execute the command.
            var resultset = await GetSpannerTransaction().ExecuteQueryAsync(request, cancellationToken)
                .WithTimeout(TimeSpan.FromSeconds(CommandTimeout), "The timeout of the SpannerCommand was exceeded.");

            if ((behavior & CommandBehavior.CloseConnection) == CommandBehavior.CloseConnection)
                return new SpannerDataReader(resultset, SpannerConnection);

            return new SpannerDataReader(resultset);
        }

        internal ISpannerTransaction GetSpannerTransaction()
        {
            return _transaction ?? SpannerConnection.GetDefaultTransaction();
        }

        private void ValidateCommandBehavior(CommandBehavior behavior)
        {
            if ((behavior & CommandBehavior.KeyInfo) == CommandBehavior.KeyInfo)
            {
                throw new NotSupportedException($"CommandBehavior KeyInfo is not supported by Cloud Spanner.");
            }
            if ((behavior & CommandBehavior.SchemaOnly) == CommandBehavior.SchemaOnly)
            {
                throw new NotSupportedException($"CommandBehavior SchemaOnly is not supported by Cloud Spanner.");
            }
            if ((behavior & CommandBehavior.SequentialAccess) == CommandBehavior.SequentialAccess)
            {
                throw new NotSupportedException($"CommandBehavior SequentialAccess is not supported by Cloud Spanner.");
            }
        }
    }
}