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
using Google.Cloud.Spanner.V1;

// ReSharper disable UnusedParameter.Local

namespace Google.Cloud.Spanner
{
    /// <summary>
    /// </summary>
    public sealed class SpannerCommand : DbCommand
#if NET451
        , ICloneable
#endif
    {
        private readonly SpannerTransaction _transaction;
        private readonly CancellationTokenSource _synchronousCancellationTokenSource = new CancellationTokenSource();
        private int _commandTimeout;

        /// <summary>
        /// </summary>
        public SpannerCommand()
        {
            DesignTimeVisible = true;
            _commandTimeout = ConnectionPoolOptions.Instance.TimeoutMilliseconds;
        }

        /// <summary>
        /// </summary>
        /// <param name="commandTextBuilder"></param>
        /// <param name="connection"></param>
        /// <param name="transaction"></param>
        /// <param name="parameters"></param>
        public SpannerCommand(SpannerCommandTextBuilder commandTextBuilder, SpannerConnection connection,
            SpannerTransaction transaction = null, SpannerParameterCollection parameters = null)
        {
            SpannerCommandTextBuilder = commandTextBuilder;
            SpannerConnection = connection;
            _transaction = transaction;
            Parameters = parameters;
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
            set { throw new NotSupportedException("Cloud Spanner only supports CommandType.Text."); }
        }

        /// <inheritdoc />
        public override bool DesignTimeVisible { get; set; }

        /// <summary>
        /// </summary>
        public new SpannerParameterCollection Parameters { get; private set; }

        /// <summary>
        /// </summary>
        public SpannerConnection SpannerConnection { get; set; }

        /// <inheritdoc />
        public override UpdateRowSource UpdatedRowSource
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <inheritdoc />
        protected override DbConnection DbConnection
        {
            get { return SpannerConnection; }
            set { SpannerConnection = (SpannerConnection) value; }
        }

        /// <inheritdoc />
        protected override DbParameterCollection DbParameterCollection => Parameters;

        /// <inheritdoc />
        protected override DbTransaction DbTransaction
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// </summary>
        internal SpannerCommandTextBuilder SpannerCommandTextBuilder { get; set; }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new SpannerCommand {
                DesignTimeVisible = DesignTimeVisible,
                Parameters = Parameters,
                SpannerConnection = SpannerConnection,
                SpannerCommandTextBuilder = SpannerCommandTextBuilder,
                CommandTimeout = CommandTimeout
            };
        }

        /// <inheritdoc />
        public override void Cancel()
        {
            _synchronousCancellationTokenSource.Cancel();
        }

        /// <inheritdoc />
        public override void Prepare()
        {
            //Spanner does not support preoptimized queries.
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
        public override int ExecuteNonQuery()
        {
            return ExecuteNonQueryAsync(_synchronousCancellationTokenSource.Token).Result;
        }

        /// <inheritdoc />
        public override object ExecuteScalar()
        {
            return ExecuteScalarAsync(_synchronousCancellationTokenSource.Token).Result;
        }

        private void ValidateCommandBehavior(CommandBehavior behavior)
        {
            switch (behavior)
            {
                case CommandBehavior.KeyInfo:
                case CommandBehavior.SchemaOnly:
                case CommandBehavior.SequentialAccess:
                    throw new InvalidOperationException($"CommandBehavior {behavior} is not supported by Cloud Spanner.");
            }
        }

        /// <inheritdoc />
        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
        {
            ValidateCommandBehavior(behavior);
            return ExecuteDbDataReaderAsync(behavior, _synchronousCancellationTokenSource.Token).Result;
        }

        /// <inheritdoc />
        protected override async Task<DbDataReader> ExecuteDbDataReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
        {
            // There must be a valid and open connection.
            if (SpannerConnection == null)
            {
                throw new InvalidOperationException(
                    "You must assign a SpannerConnection to this command to execute it.");
            }
            if (SpannerCommandTextBuilder.SpannerCommandType != SpannerCommandType.Select)
            {
                throw new InvalidOperationException("You can only call ExecuteNonQuery on a Select Command");
            }
            if (!SpannerConnection.IsOpen)
            {
                //implicit open
                await SpannerConnection.OpenAsync(cancellationToken);
            }
            if (!SpannerConnection.IsOpen)
            {
                throw new InvalidOperationException("Unable to open the Spanner connection to the database.");
            }

            // Execute the command.
            var resultset = await SpannerConnection.ExecuteSqlAsync(new ExecuteSqlRequest
            {
                Sql = CommandText,
            }, cancellationToken);

            if ((behavior & CommandBehavior.CloseConnection) == CommandBehavior.CloseConnection)
                return new SpannerDataReader(resultset, SpannerConnection);
            return new SpannerDataReader(resultset);
        }

        /// <inheritdoc />
        public override Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override Task<object> ExecuteScalarAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}