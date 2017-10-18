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
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;
using DatabaseName = Google.Cloud.Spanner.Admin.Database.V1.DatabaseName;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a SQL query or command to execute against
    /// a Spanner database.
    /// If the command is a SQL query, then <see cref="SpannerCommand.CommandText"/>
    /// contains the entire SQL statement. Use <see cref="SpannerCommand.ExecuteReaderAsync()"/>  to obtain results.
    /// 
    /// If the command is an update, insert or delete command, then <see cref="SpannerCommand.CommandText"/>
    /// is simply "[operation] [spanner_table]" such as "UPDATE MYTABLE" with the parameter
    /// collection containing <see cref="SpannerParameter"/> instances whose name matches a column
    /// in the target table. Use <see cref="ExecuteNonQueryAsync"/> to execute the command.
    /// 
    /// The command may also be a DDL statement such as CREATE TABLE. Use <see cref="ExecuteNonQueryAsync"/>
    /// to execute a DDL statement.
    /// </summary>
    public sealed class SpannerCommand : DbCommand
#if !NETSTANDARD1_5
        , ICloneable
#endif
    {
        private readonly CancellationTokenSource _synchronousCancellationTokenSource = new CancellationTokenSource();
        private int _commandTimeout;
        private SpannerTransaction _transaction;
        private Logger _logger;

        /// <summary>
        /// Initializes a new instance of <see cref="SpannerCommand"/>.
        /// </summary>
        public SpannerCommand()
        {
            DesignTimeVisible = true;
            _commandTimeout = SpannerOptions.Instance.Timeout;
        }

        private SpannerCommand(
            SpannerConnection connection,
            SpannerTransaction transaction,
            SpannerParameterCollection parameters) : this()
        {
            SpannerConnection = connection;
            _transaction = transaction;
            if (parameters != null)
            {
                Parameters = parameters;
            }
        }

        /// <summary>
        /// Initializes a new instance of <see cref="SpannerCommand"/>.
        /// </summary>
        /// <param name="commandTextBuilder">The <see cref="SpannerCommandTextBuilder"/>
        /// that configures the text of this command. Must not be null.</param>
        /// <param name="connection">The <see cref="SpannerConnection"/> that is
        /// associated with this <see cref="SpannerCommand"/>. Must not be null.</param>
        /// <param name="transaction">An optional <see cref="SpannerTransaction"/>
        /// created through <see>
        /// <cref>SpannerConnection.BeginTransactionAsync</cref>
        /// </see>
        /// </param>. May be null.
        /// <param name="parameters">An optional collection of <see cref="SpannerParameter"/>
        /// that is used in the command. May be null.</param>
        public SpannerCommand(
            SpannerCommandTextBuilder commandTextBuilder,
            SpannerConnection connection,
            SpannerTransaction transaction = null,
            SpannerParameterCollection parameters = null)
            : this(connection, transaction, parameters)
        {
            GaxPreconditions.CheckNotNull(commandTextBuilder, nameof(commandTextBuilder));
            GaxPreconditions.CheckNotNull(connection, nameof(connection));

            SpannerCommandTextBuilder = commandTextBuilder;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="SpannerCommand"/>
        /// </summary>
        /// <param name="commandText">If this command is a SQL Query, then commandText is
        /// the SQL statement. If its an update, insert or delete command, then this text
        /// is "[operation] [table]" such as "UPDATE MYTABLE"</param>. Must not be null.
        /// <param name="connection">The <see cref="SpannerConnection"/> that is
        /// associated with this <see cref="SpannerCommand"/>. Must not be null.</param>
        /// <param name="transaction">An optional <see cref="SpannerTransaction"/>
        /// created through <see>
        /// <cref>SpannerConnection.BeginTransactionAsync</cref></see>. May be null.</param>
        /// <param name="parameters">An optional collection of <see cref="SpannerParameter"/>
        /// that is used in the command. May be null.</param>
        public SpannerCommand(
            string commandText,
            SpannerConnection connection,
            SpannerTransaction transaction = null,
            SpannerParameterCollection parameters = null)
            : this(SpannerCommandTextBuilder.FromCommandText(commandText), connection, transaction, parameters) { }

        /// <inheritdoc />
        public override string CommandText
        {
            get => SpannerCommandTextBuilder?.ToString() ?? "";
            set => SpannerCommandTextBuilder = SpannerCommandTextBuilder.FromCommandText(value);
        }


        /// <summary>
        /// This property is for internal use only.
        /// </summary>
        public Logger Logger
        {
            get => _logger ?? SpannerConnection?.Logger;
            set => _logger = value;
        }

        /// <summary>
        /// Gets or sets the wait time before terminating the attempt to execute a command and generating an error.
        /// Defaults to <see cref="SpannerOptions.Timeout"/> which is 60 seconds.
        /// A value of '0' normally indicates that no timeout should be used (it waits an infinite amount of time).
        /// However, if you specify AllowImmediateTimeouts=true in the connection string, '0' will cause a timeout
        /// that expires immediately. This is normally used only for testing purposes.
        /// </summary>
        public override int CommandTimeout
        {
            get => _commandTimeout;
            set => _commandTimeout = value;
        }

        /// <inheritdoc />
        public override CommandType CommandType
        {
            get => CommandType.Text;
            set
            {
                if (value != CommandType.Text)
                {
                    throw new NotSupportedException("Cloud Spanner only supports CommandType.Text.");
                }
            }
        }

        /// <inheritdoc />
        public override bool DesignTimeVisible { get; set; }

        /// <summary>
        /// The parameters of the SQL statement or command.
        /// </summary>
        public new SpannerParameterCollection Parameters { get; } = new SpannerParameterCollection();

        /// <summary>
        /// The connection to the data source.
        /// </summary>
        public SpannerConnection SpannerConnection { get; set; }

        /// <inheritdoc />
        public override UpdateRowSource UpdatedRowSource
        {
            get => UpdateRowSource.None;
            set
            {
                if (value != UpdateRowSource.None)
                {
                    throw new NotSupportedException(
                        "Cloud Spanner does not support updating datasets on update/insert queries."
                        + " Please use UUIDs instead of auto increment columns, which can be created on the client.");
                }
            }
        }

        /// <inheritdoc />
        protected override DbConnection DbConnection
        {
            //TODO(benwu): update to use newer lambda forms for get/set. ditto for other places.
            get => SpannerConnection;
            set => SpannerConnection = (SpannerConnection) value;
        }

        /// <inheritdoc />
        protected override DbParameterCollection DbParameterCollection => Parameters;

        /// <inheritdoc />
        protected override DbTransaction DbTransaction
        {
            get => _transaction;
            set => _transaction = (SpannerTransaction) value;
        }

        // ReSharper disable once MemberCanBePrivate.Global
        internal SpannerCommandTextBuilder SpannerCommandTextBuilder { get; set; }

        /// <summary>
        /// Returns a copy of this <see cref="SpannerCommand"/>.
        /// </summary>
        /// <returns>a copy of this <see cref="SpannerCommand"/>.</returns>
        public object Clone() => new SpannerCommand(SpannerConnection, _transaction, Parameters?.Clone())
        {
            DesignTimeVisible = DesignTimeVisible,
            SpannerCommandTextBuilder = SpannerCommandTextBuilder,
            CommandTimeout = CommandTimeout
        };

        /// <inheritdoc />
        public override void Cancel()
        {
            _synchronousCancellationTokenSource.Cancel();
        }

        /// <inheritdoc />
        public override int ExecuteNonQuery() => ExecuteNonQueryAsync(_synchronousCancellationTokenSource.Token)
            .ResultWithUnwrappedExceptions();

        /// <summary>
        /// Executes the command against the <see cref="SpannerConnection"/>.
        /// This method is thread safe.
        /// </summary>
        /// <returns>a <see cref="SpannerDataReader"/>.</returns>
        public Task<DbDataReader> ExecuteReaderAsync(
            TimestampBound singleUseReadSettings,
            CancellationToken cancellationToken = default)
            => ExecuteReaderImplAsync(
                SpannerConnection,
                GetExecuteSqlRequest(),
                CommandTimeout,
                GetSpannerTransaction(),
                Transaction,
                singleUseReadSettings,
                Logger,
                cancellationToken
                );

        private static async Task<DbDataReader> ExecuteReaderImplAsync(
            SpannerConnection spannerConnection,
            ExecuteSqlRequest request,
            int commandTimeout,
            ISpannerTransaction spannerTransaction,
            DbTransaction transaction,
            TimestampBound singleUseReadSettings,
            Logger logger,
            CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(singleUseReadSettings, nameof(singleUseReadSettings));
            // There must be a valid and open connection.
            if (spannerConnection == null)
            {
                throw new InvalidOperationException(
                    "You must assign a SpannerConnection to this command to execute it.");
            }
            if (transaction != null)
            {
                throw new InvalidOperationException(
                    "singleUseReadSettings cannot be used within"
                    + " another transaction.");
            }
            var singleUseTransaction =
                await spannerConnection.BeginSingleUseTransactionAsync(
                    singleUseReadSettings,
                    cancellationToken).ConfigureAwait(false);
            return await ExecuteDbDataReaderImplAsync(
                spannerConnection,
                request,
                commandTimeout,
                spannerTransaction,
                CommandBehavior.Default,
                singleUseTransaction,
                logger,
                cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public override Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken)
        {
            // There must be a valid and open connection.
            if (SpannerConnection == null)
            {
                throw new InvalidOperationException(
                    "You must assign a SpannerConnection to this command to execute it.");
            }

            if (SpannerCommandTextBuilder.SpannerCommandType == SpannerCommandType.Select)
            {
                throw new InvalidOperationException(
                    $"You can only call ExecuteNonQueryAsync on a {SpannerCommandType.Delete}, {SpannerCommandType.Insert},"
                    + $"{SpannerCommandType.InsertOrUpdate}, {SpannerCommandType.Update}, or {SpannerCommandType.Ddl} Command");
            }

            return SpannerCommandTextBuilder.SpannerCommandType == SpannerCommandType.Ddl
                ? ExecuteDdlAsync(
                    SpannerConnection,
                    SpannerCommandTextBuilder,
                    CommandText,
                    cancellationToken
                    )
                : ExecuteMutationsAsync(
                    SpannerConnection,
                    GetMutations(),
                    CommandTimeout,
                    GetSpannerTransaction(),
                    cancellationToken
                    );
        }

        private static async Task<int> ExecuteDdlAsync(
            SpannerConnection spannerConnection,
            SpannerCommandTextBuilder spannerCommandTextBuilder,
            string commandText,
            CancellationToken cancellationToken)
        {
            var databaseAdminClient = await DatabaseAdminClient.CreateAsync().ConfigureAwait(false);

            if (spannerCommandTextBuilder.IsCreateDatabaseCommand)
            {
                var parent = new InstanceName(spannerConnection.Project, spannerConnection.SpannerInstance);
                var response = await databaseAdminClient.CreateDatabaseAsync(
                    new CreateDatabaseRequest
                    {
                        ParentAsInstanceName = parent,
                        CreateStatement = commandText,
                        ExtraStatements = { spannerCommandTextBuilder.ExtraStatements }
                    }).ConfigureAwait(false);
                await response.PollUntilCompletedAsync().ConfigureAwait(false);
            }
            else if (spannerCommandTextBuilder.IsDropDatabaseCommand)
            {
                if (spannerCommandTextBuilder.ExtraStatements?.Length > 0)
                {
                    throw new InvalidOperationException("Drop database commands do not support additional ddl statements");
                }
                var dbName = new DatabaseName(spannerConnection.Project,
                    spannerConnection.SpannerInstance,
                    spannerCommandTextBuilder.DatabaseToDrop);
                await databaseAdminClient.DropDatabaseAsync(dbName, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                var ddlStatements = new List<string> {commandText};
                if (spannerCommandTextBuilder.ExtraStatements != null)
                {
                    ddlStatements.AddRange(spannerCommandTextBuilder.ExtraStatements);
                }

                var response =
                    await databaseAdminClient.UpdateDatabaseDdlAsync(
                        new UpdateDatabaseDdlRequest
                        {
                            DatabaseAsDatabaseName = new DatabaseName(
                                spannerConnection.Project, spannerConnection.SpannerInstance, spannerConnection.Database),
                            Statements = { ddlStatements }
                        }).ConfigureAwait(false);
                await response.PollUntilCompletedAsync().ConfigureAwait(false);
            }
            return 0;
        }

        private static async Task<int> ExecuteMutationsAsync(
            SpannerConnection spannerConnection,
            List<Mutation> mutations,
            int commandTimeout,
            ISpannerTransaction spannerTransaction,
            CancellationToken cancellationToken)
        {
            if (!spannerConnection.IsOpen)
            {
                await spannerConnection.OpenAsync(cancellationToken).ConfigureAwait(false);
            }

            if (!spannerConnection.IsOpen)
            {
                throw new InvalidOperationException(
                    "Unable to open the Spanner connection to the database to execute the query.");
            }

            // Make the request. This will commit immediately or not depending on whether a transaction was explicitly created.
            await spannerTransaction.ExecuteMutationsAsync(mutations, cancellationToken, commandTimeout)
                .ConfigureAwait(false);
            // Return the number of records affected.
            return mutations.Count;
        }

        private List<Mutation> GetMutations()
        {
            var mutations = new List<Mutation>();
            if (SpannerCommandTextBuilder.SpannerCommandType != SpannerCommandType.Delete)
            {
                var w = new Mutation.Types.Write
                {
                    Table = SpannerCommandTextBuilder.TargetTable,
                    Columns = {Parameters.Select(x => x.SourceColumn ?? x.ParameterName)},
                    Values =
                    {
                        new ListValue
                        {
                            Values =
                            {
                                Parameters.Select(x => ValueConversion.ToValue(x.GetValidatedValue(), x.SpannerDbType))
                            }
                        }
                    }
                };
                switch (SpannerCommandTextBuilder.SpannerCommandType)
                {
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
            }
            else
            {
                var w = new Mutation.Types.Delete
                {
                    Table = SpannerCommandTextBuilder.TargetTable,
                    KeySet =
                        new KeySet
                        {
                            Keys =
                            {
                                new ListValue
                                {
                                    Values =
                                    {
                                        Parameters.Select(
                                            x => ValueConversion.ToValue(x.GetValidatedValue(), x.SpannerDbType))
                                    }
                                }
                            }
                        }
                };
                mutations.Add(new Mutation {Delete = w});
            }
            return mutations;
        }

        /// <inheritdoc />
        public override object ExecuteScalar() => ExecuteScalarAsync(_synchronousCancellationTokenSource.Token)
            .ResultWithUnwrappedExceptions();

        /// <summary>
        /// Executes the query and returns the first column of the first row in the result set returned by the query.
        /// All other columns and rows are ignored. The return value is converted to type T if possible.
        /// This method is thread safe.
        /// </summary>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <typeparam name="T">The expected return type. If possible the return type will be converted to this type.
        /// If conversion is requested between incompatible types, an <see cref="InvalidOperationException"/>
        /// will be thrown.
        /// If the conversion fails due to the contents returned (for example a string representing a
        /// boolean does not have either 'true' or 'false') then a <see cref="FormatException"/> exception will be
        /// thrown as documented by the <see cref="Convert"/> class.</typeparam>
        /// <returns>The first column of the first row resulting from execution of the query.</returns>
        public Task<T> ExecuteScalarAsync<T>(CancellationToken cancellationToken = default)
            => ExecuteScalarImplAsync<T>(
                SpannerConnection,
                GetExecuteSqlRequest(),
                CommandTimeout,
                GetSpannerTransaction(),
                Transaction,
                Logger,
                cancellationToken
                );

        private static async Task<T> ExecuteScalarImplAsync<T>(
            SpannerConnection spannerConnection,
            ExecuteSqlRequest request,
            int commandTimeout,
            ISpannerTransaction spannerTransaction,
            DbTransaction transaction,
            Logger logger,
            CancellationToken cancellationToken)
        {
            using (var reader = await ExecuteDbDataReaderImplAsync(
                spannerConnection,
                request,
                commandTimeout,
                spannerTransaction,
                CommandBehavior.SingleRow,
                null,
                logger,
                cancellationToken)
                .ConfigureAwait(false))
            {
                if (await reader.ReadAsync(cancellationToken).ConfigureAwait(false) && reader.HasRows &&
                    reader.FieldCount > 0)
                {
                    return reader.GetFieldValue<T>(0);
                }
            }
            return default;
        }

        /// <inheritdoc />
        public override Task<object> ExecuteScalarAsync(CancellationToken cancellationToken)
            => ExecuteScalarAsync<object>(cancellationToken);

        /// <inheritdoc />
        public override void Prepare()
        {
            //Spanner does not support preoptimized queries nor 2 phase commit transactions.
        }

        /// <inheritdoc />
        protected override DbParameter CreateDbParameter() => new SpannerParameter();

        /// <inheritdoc />
        protected override void Dispose(bool disposing) { }

        /// <summary>
        /// Sends the command to Cloud Spanner and builds a <see cref="SpannerDataReader"/>.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/> that produces a <see cref="SpannerDataReader"/>.</returns>
        public new Task<SpannerDataReader> ExecuteReaderAsync()
            => ExecuteReaderAsync(CommandBehavior.Default, CancellationToken.None);

        /// <summary>
        /// Sends the command to Cloud Spanner and builds a <see cref="SpannerDataReader"/>.
        /// </summary>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>An asynchronous <see cref="Task"/> that produces a <see cref="SpannerDataReader"/>.</returns>
        public new Task<SpannerDataReader> ExecuteReaderAsync(CancellationToken cancellationToken)
            => ExecuteReaderAsync(CommandBehavior.Default, cancellationToken);

        /// <summary>
        /// Sends the command to Cloud Spanner and builds a <see cref="SpannerDataReader"/>.
        /// </summary>
        /// <param name="behavior">Options for statement execution and data retrieval.</param>
        /// <returns>An asynchronous <see cref="Task"/> that produces a <see cref="SpannerDataReader"/>.</returns>
        public new Task<SpannerDataReader> ExecuteReaderAsync(CommandBehavior behavior)
            => ExecuteReaderAsync(behavior, CancellationToken.None);

        /// <summary>
        /// Sends the command to Cloud Spanner and builds a <see cref="SpannerDataReader"/>.
        /// </summary>
        /// <param name="behavior">Options for statement execution and data retrieval.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>An asynchronous <see cref="Task"/> that produces a <see cref="SpannerDataReader"/>.</returns>
        public new async Task<SpannerDataReader> ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
        {
            return (SpannerDataReader) await ExecuteDbDataReaderAsync(behavior, cancellationToken)
                .ConfigureAwait(false);
        }

        /// <inheritdoc />
        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
        {
            ValidateCommandBehavior(behavior);
            return ExecuteDbDataReaderImplAsync(
                SpannerConnection,
                GetExecuteSqlRequest(),
                CommandTimeout,
                GetSpannerTransaction(),
                behavior,
                null,
                Logger,
                _synchronousCancellationTokenSource.Token)
                .ResultWithUnwrappedExceptions();
        }

        /// <inheritdoc />
        protected override Task<DbDataReader> ExecuteDbDataReaderAsync(
            CommandBehavior behavior,
            CancellationToken cancellationToken) => ExecuteDbDataReaderImplAsync(
                SpannerConnection,
                GetExecuteSqlRequest(),
                CommandTimeout,
                GetSpannerTransaction(),
                behavior,
                null,
                Logger,
                cancellationToken);

        private static async Task<DbDataReader> ExecuteDbDataReaderImplAsync(
            SpannerConnection spannerConnection,
            ExecuteSqlRequest request,
            int commandTimeout,
            ISpannerTransaction spannerTransaction,
            CommandBehavior behavior,
            SingleUseTransaction singleUseTransaction,
            Logger logger,
            CancellationToken cancellationToken)
        {
            // There must be a valid and open connection.
            if (spannerConnection == null)
            {
                throw new InvalidOperationException(
                    "You must assign a SpannerConnection to this command to execute it.");
            }

            if (!spannerConnection.IsOpen)
            {
                await spannerConnection.OpenAsync(cancellationToken).ConfigureAwait(false);
            }

            if (!spannerConnection.IsOpen)
            {
                throw new InvalidOperationException("Unable to open the Spanner connection to the database.");
            }

            var tx = singleUseTransaction ?? spannerTransaction;

            logger.Sensitive_Info(() => $"SpannerCommand.ExecuteReader.Query={request.Sql}");

            // Execute the command.
            var resultSet = await tx.ExecuteQueryAsync(request, cancellationToken, commandTimeout)
                .ConfigureAwait(false);

            if ((behavior & CommandBehavior.CloseConnection) == CommandBehavior.CloseConnection)
            {
                return new SpannerDataReader(logger, resultSet, spannerConnection);
            }

            return new SpannerDataReader(logger, resultSet, null, singleUseTransaction);
        }

        private ExecuteSqlRequest GetExecuteSqlRequest()
        {
            if (SpannerCommandTextBuilder.SpannerCommandType != SpannerCommandType.Select)
            {
                throw new InvalidOperationException("You can only call ExecuteReader on a Select Command");
            }

            var request = new ExecuteSqlRequest
            {
                Sql = CommandText
            };

            if (Parameters?.Count > 0)
            {
                request.Params = new Struct();
                Parameters.FillSpannerInternalValues(request.Params.Fields, request.ParamTypes);
            }
            return request;
        }

        internal ISpannerTransaction GetSpannerTransaction() => _transaction ??
            SpannerConnection.GetDefaultTransaction();

        private void ValidateCommandBehavior(CommandBehavior behavior)
        {
            if ((behavior & CommandBehavior.KeyInfo) == CommandBehavior.KeyInfo)
            {
                throw new NotSupportedException(
                    $"{nameof(CommandBehavior.KeyInfo)} is not supported by Cloud Spanner.");
            }
            if ((behavior & CommandBehavior.SchemaOnly) == CommandBehavior.SchemaOnly)
            {
                throw new NotSupportedException(
                    $"{nameof(CommandBehavior.SchemaOnly)} is not supported by Cloud Spanner.");
            }
        }
    }
}
