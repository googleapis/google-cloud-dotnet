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
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;
using Google.Cloud.Spanner.V1;

#if NET451
using Transaction = System.Transactions.Transaction;

#endif

// ReSharper disable UnusedParameter.Local
namespace Google.Cloud.Spanner
{
    /// <summary>
    ///     A SpannerConnection represents a connection to a single Spanner database.
    /// </summary>
    public sealed class SpannerConnection : DbConnection
    {
        private SpannerBatchOperation _activeBatchOperation;
        private SpannerClient _client;
        private SpannerConnectionStringBuilder _connectionStringBuilder;
        private Session _session;
        private int _sessionInUse;
        private int _executingCount;
        private ConnectionState _state = ConnectionState.Closed;
        private readonly object _sync = new object();

        /// <summary>
        ///     Creates a SpannerConnection with no datasource or credential specified.
        /// </summary>
        public SpannerConnection()
        {
        }

        /// <summary>
        ///     Creates a SpannerConnection with a datasource contained in connectionString
        ///     and optional credential information supplied in connectionString or the credential
        ///     argument.
        /// </summary>
        /// <param name="connectionString">A Spanner formatted connection string.</param>
        /// <param name="credential">An optional credential.</param>
        public SpannerConnection(string connectionString, ITokenAccess credential = null)
            : this(new SpannerConnectionStringBuilder(connectionString, credential))
        {
        }

        /// <summary>
        ///     Creates a SpannerConnection with a datasource contained in connectionString.
        /// </summary>
        /// <param name="connectionStringBuilder">
        ///     A SpannerConnectionStringBuilder containing
        ///     a formatted connection string.
        /// </param>
        public SpannerConnection(SpannerConnectionStringBuilder connectionStringBuilder)
        {
            connectionStringBuilder.ThrowIfNull(nameof(connectionStringBuilder));
            TrySetNewConnectionInfo(connectionStringBuilder);
        }

        /// <summary>
        ///     Provides options to customize how connections to Spanner are created
        ///     and maintained.
        /// </summary>
        public static ConnectionPoolOptions ConnectionPoolOptions => ConnectionPoolOptions.Instance;

        /// <inheritdoc />
        public override string ConnectionString
        {
            get { return _connectionStringBuilder.ToString(); }
            set
            {
                TrySetNewConnectionInfo(new SpannerConnectionStringBuilder(value, _connectionStringBuilder.Credential));
            }
        }

        /// <summary>
        ///     Returns the credential used for the connection, if set.
        /// </summary>
        public ITokenAccess Credential => _connectionStringBuilder.Credential;

        /// <inheritdoc />
        public override string Database => _connectionStringBuilder.SpannerDatabase;

        /// <inheritdoc />
        public override string DataSource => _connectionStringBuilder.DataSource;

        /// <summary>
        /// </summary>
        public string Project => _connectionStringBuilder.Project;

        //TODO review server version support.
        /// <inheritdoc />
        public override string ServerVersion => "0.0";

        /// <summary>
        /// </summary>
        public string SpannerInstance => _connectionStringBuilder.SpannerInstance;

        /// <inheritdoc />
        public override ConnectionState State => (
            _state | (_executingCount > 0 ? ConnectionState.Executing : 0));


        internal bool IsClosed => (State & ConnectionState.Open) == 0;

        internal bool IsOpen => (State & ConnectionState.Open) == ConnectionState.Open;

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public SpannerBatchOperation BeginBatchOperation()
        {
            //This may be called while the connection is closed.
            var newBatchOperation = new SpannerBatchOperation(this);
            if (Interlocked.CompareExchange(ref _activeBatchOperation, newBatchOperation, null)
                != null) throw new InvalidOperationException("You may only create a single Batch operation at a time.");
            return _activeBatchOperation;
        }

        /// <summary>
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public SpannerTransaction BeginTransaction(TransactionMode mode = TransactionMode.ReadOnly)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="timestampBound"></param>
        /// <returns></returns>
        public SpannerTransaction BeginTransaction(TransactionMode mode,
            TimestampBound timestampBound)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override void ChangeDatabase(string newDataSource)
        {
            TrySetNewConnectionInfo(_connectionStringBuilder.CloneWithNewDataSource(newDataSource));
        }

        /// <inheritdoc />
        public override void Close()
        {
            Session session;
            bool primarySessionInUse;
            lock (_sync)
            {
                if (IsClosed) return;
                primarySessionInUse = _sessionInUse == 1;
                _state = ConnectionState.Closed;
                //we do not await the actual session close, we let that happen async.
                session = _session;
                _session = null;
            }
            if (!primarySessionInUse)
            {
                //release the session if its not used.
                //if it's used, we'll detect a closed state after the operation and release it then.
                var task = session.ReleaseToPool();
                task.ContinueWith(t =>
                {
                    //TODO, proper logging.
                    //if (t.IsFaulted && t.Exception != null) Trace.TraceWarning($"Error releasing session: {t.Exception}");
                });
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="deleteFilterParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateDeleteCommand(string databaseTable,
            SpannerParameterCollection deleteFilterParameters = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateDeleteTextBuilder(databaseTable), this, null,
                deleteFilterParameters);
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="insertParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateInsertCommand(string databaseTable,
            SpannerParameterCollection insertParameters = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateInsertTextBuilder(databaseTable), this, null,
                insertParameters);
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="insertUpdateParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateInsertOrUpdateCommand(string databaseTable,
            SpannerParameterCollection insertUpdateParameters = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateInsertOrUpdateTextBuilder(databaseTable), this,
                null, insertUpdateParameters);
        }

        /// <summary>
        /// </summary>
        /// <param name="sqlQueryStatement"></param>
        /// <param name="selectParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateSelectCommand(string sqlQueryStatement,
            SpannerParameterCollection selectParameters = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateSelectTextBuilder(sqlQueryStatement), this, null,
                selectParameters);
        }

        /// <summary>
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="indexToUse"></param>
        /// <param name="columnsToRead"></param>
        /// <returns></returns>
        public SpannerCommand CreateTableDirectReadCommand(string tableName, string indexToUse = null,
            SpannerParameterCollection columnsToRead = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateTableDirectReadTextBuilder(tableName), this, null,
                    columnsToRead)
                {ReadIndex = indexToUse};
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="updateParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateUpdateCommand(string databaseTable,
            SpannerParameterCollection updateParameters = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateUpdateTextBuilder(databaseTable), this, null,
                updateParameters);
        }

        /// <inheritdoc />
        public override void Open()
        {
            if (IsOpen)
                return;
            OpenAsync(CancellationToken.None).Wait();
        }

        /// <inheritdoc />
        public override async Task OpenAsync(CancellationToken cancellationToken)
        {
            if (IsOpen) return;
            lock (_sync)
            {
                if (IsOpen) return;
                if (_state == ConnectionState.Connecting)
                    throw new InvalidOperationException("The SpannerConnection is already being opened.");
                _state = ConnectionState.Connecting;
            }
            try
            {
                _client = await ClientPool.AcquireClientAsync(_connectionStringBuilder.Credential,
                    _connectionStringBuilder.EndPoint);
                _session =
                    await
                        _client.CreateSessionFromPoolAsync(
                            _connectionStringBuilder.Project,
                            _connectionStringBuilder.SpannerInstance,
                            _connectionStringBuilder.SpannerDatabase, cancellationToken);
                _sessionInUse = 0;
            }
            finally
            {
                _state = _session != null ? ConnectionState.Open : ConnectionState.Broken;
            }
        }

        /// <inheritdoc />
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override DbCommand CreateDbCommand()
        {
            return new SpannerCommand();
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (IsOpen) Close();
        }

        private void AssertClosed(string message)
        {
            if (!IsClosed)
                throw new InvalidOperationException("The connection must be closed.  Failed to " + message);
        }

        private void AssertOpen(string message)
        {
            if (!IsOpen)
                throw new InvalidOperationException("The connection must be open.  Failed to " + message);
        }

        private void TrySetNewConnectionInfo(SpannerConnectionStringBuilder newBuilder)
        {
            AssertClosed("change connection information.");
            _connectionStringBuilder = newBuilder;
        }

        internal async Task<CommitResponse> CommitAsync(List<Mutation> mutations, CancellationToken cancellationToken)
        {
            var sessionToUse = await AllocateSession(cancellationToken);
            try
            {
                return await _client.CommitAsync(sessionToUse.SessionName,
                    new TransactionOptions {ReadWrite = new TransactionOptions.Types.ReadWrite()}, mutations);
            }
            finally
            {
                await sessionToUse.ReleaseToPool();
            }
        }

        internal async Task<ReliableStreamReader> ExecuteSqlAsync(
            ExecuteSqlRequest executeSqlRequest, CancellationToken cancellationToken)
        {
            var sessionToUse = await AllocateSession(cancellationToken);
            var streamReader = _client.GetSqlStreamReader(executeSqlRequest, sessionToUse);

            Interlocked.Increment(ref _executingCount);
            streamReader.StreamClosed += async (o, e) =>
            {
                Interlocked.Decrement(ref _executingCount);
                if (ReferenceEquals(sessionToUse, _session))
                {
                    Interlocked.Exchange(ref _sessionInUse, 0);
                }
                else
                {
                    await sessionToUse.ReleaseToPool();
                }
            };
            return streamReader;
        }

        private async Task<Session> AllocateSession(CancellationToken cancellationToken)
        {
            AssertOpen("execute command");
            Session sessionToUse = null;

            if (Interlocked.CompareExchange(ref _sessionInUse, 1, 0) == 0)
            {
                sessionToUse = _session;
            }

            return sessionToUse ?? await _client.CreateSessionFromPoolAsync(
                       _connectionStringBuilder.Project, _connectionStringBuilder.SpannerInstance,
                       _connectionStringBuilder.SpannerDatabase, cancellationToken);
        }

#if NET451

        /// <inheritdoc />
        public override void EnlistTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override DbProviderFactory DbProviderFactory => SpannerProviderFactory.s_instance;

#endif
    }
}