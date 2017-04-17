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
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;

// ReSharper disable UnusedParameter.Local
namespace Google.Cloud.Spanner
{
    /// <summary>
    /// A SpannerConnection represents a connection to a single Spanner database.
    /// </summary>
    public class SpannerConnection : DbConnection
    {
        private SpannerBatchOperation _activeBatchOperation;
        private SpannerConnectionStringBuilder _connectionStringBuilder;
        private ConnectionState _state = ConnectionState.Closed;
        private SpannerClient _client;
        private Session _session;

        /// <summary>
        /// Creates a SpannerConnection with no datasource or credential specified.
        /// </summary>
        public SpannerConnection()
        {
        }

        /// <summary>
        /// Creates a SpannerConnection with a datasource contained in connectionString
        /// and optional credential information supplied in connectionString or the credential
        /// argument.
        /// </summary>
        /// <param name="connectionString">A Spanner formatted connection string.</param>
        /// <param name="credential">An optional credential.</param>
        public SpannerConnection(string connectionString, ITokenAccess credential = null)
            :this(new SpannerConnectionStringBuilder(connectionString, credential))
        {
        }

        /// <summary>
        /// Creates a SpannerConnection with a datasource contained in connectionString
        /// and optional credential information supplied in connectionString or the credential
        /// argument.
        /// </summary>
        /// <param name="connectionStringBuilder">A SpannerConnectionStringBuilder containing
        ///  a formatted connection string.</param>
        public SpannerConnection(SpannerConnectionStringBuilder connectionStringBuilder)
        {
            TrySetNewConnectionInfo(connectionStringBuilder);
        }

        private bool IsOpen => (State & ConnectionState.Open) == ConnectionState.Open;
        private bool IsClosed => (State & ConnectionState.Open) == 0;

        private void AssertOpen(string message) {
            if (!IsOpen)
            {
                throw new InvalidOperationException("The connection must be open.  Failed to " + message);
            }

        }

        private void AssertClosed(string message) {
            if (!IsClosed)
            {
                throw new InvalidOperationException("The connection must be closed.  Failed to " + message);
            }

        }
        private void TrySetNewConnectionInfo(SpannerConnectionStringBuilder newBuilder) {
            AssertClosed("change connection information.");
            _connectionStringBuilder = newBuilder;
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public SpannerBatchOperation BeginBatchOperation()
        {
            //This may be called while the connection is closed.
            SpannerBatchOperation newBatchOperation = new SpannerBatchOperation(this);
            if (Interlocked.CompareExchange(ref _activeBatchOperation, newBatchOperation, null)
                != null) {
                throw new InvalidOperationException("You may only create a single Batch operation at a time.");
            }
            return _activeBatchOperation;
        }

#if NET451
        /// <inheritdoc />
        public override void EnlistTransaction(System.Transactions.Transaction transaction)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        protected override DbProviderFactory DbProviderFactory
        {
            get { return SpannerProviderFactory.Instance; }
        }
#endif

        /// <summary>
        /// Provides options to customize how connections to Spanner are created
        /// and maintained.
        /// </summary>
        public static ConnectionPoolOptions ConnectionPoolOptions
        {
            get { return ConnectionPoolOptions.Instance; }
        }

        /// <summary>
        /// Returns the credential used for the connection, if set.
        /// </summary>
        public ITokenAccess Credential
        {
            get { return _connectionStringBuilder.Credential; }
        }

        /// <inheritdoc />
        public override string ConnectionString
        {
            get { return _connectionStringBuilder.ToString(); }
            set { TrySetNewConnectionInfo(new SpannerConnectionStringBuilder(value, _connectionStringBuilder.Credential)); }
        }

        /// <inheritdoc />
        public override string Database
        {
            get { return _connectionStringBuilder.SpannerDatabase; }
        }

        /// <inheritdoc />
        public override ConnectionState State
        {
            get { return _state; }
        }

        /// <inheritdoc />
        public override void Open() {
            if (IsOpen)
            {
                return;
            }
            OpenAsync(CancellationToken.None).Wait();
        }

        /// <inheritdoc />
        public override async Task OpenAsync(CancellationToken cancellationToken) {
            if (IsOpen) {
                return;
            }
            _client = await ClientPool.AcquireClientAsync(_connectionStringBuilder.Credential);
            _session =
                await
                    SessionPool.AcquireSessionAsync(_connectionStringBuilder.Credential,
                        _connectionStringBuilder.Project,
                        _connectionStringBuilder.SpannerInstance,
                        _connectionStringBuilder.SpannerDatabase, cancellationToken);
            _state = ConnectionState.Open;
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="insertParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateInsertCommand(string databaseTable, SpannerParameterCollection insertParameters = null) {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateInsertTextBuilder(databaseTable), this, null, insertParameters);
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="updateParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateUpdateCommand(string databaseTable, SpannerParameterCollection updateParameters = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateUpdateTextBuilder(databaseTable), this, null, updateParameters);
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="insertUpdateParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateInsertOrUpdateCommand(string databaseTable,
            SpannerParameterCollection insertUpdateParameters = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateInsertOrUpdateTextBuilder(databaseTable), this, null, insertUpdateParameters);
        }

        /// <summary>
        /// </summary>
        /// <param name="databaseTable"></param>
        /// <param name="deleteFilterParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateDeleteCommand(string databaseTable,
            SpannerParameterCollection deleteFilterParameters = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateDeleteTextBuilder(databaseTable), this, null, deleteFilterParameters);
        }

        /// <summary>
        /// </summary>
        /// <param name="sqlQueryStatement"></param>
        /// <param name="selectParameters"></param>
        /// <returns></returns>
        public SpannerCommand CreateSelectCommand(string sqlQueryStatement,
            SpannerParameterCollection selectParameters = null)
        {
            return new SpannerCommand(SpannerCommandTextBuilder.CreateSelectTextBuilder(sqlQueryStatement), this, null, selectParameters);
        }

        /// <inheritdoc />
        public override void Close()
        {
            if (IsClosed) {
                return;
            }
            _state = ConnectionState.Closed;
            //we do not await the actual session close, we let that happen async.
            var task = SessionPool.ReleaseSessionAsync(_session,
                _connectionStringBuilder.Credential,
                _connectionStringBuilder.Project,
                _connectionStringBuilder.SpannerInstance,
                _connectionStringBuilder.SpannerDatabase);
            task.ContinueWith(t => {
                if (t.IsFaulted && t.Exception != null) {
                    //TODO(benwu): logging methodology?
                    Trace.TraceWarning($"Error releasing session: {t.Exception}");
                }
            });
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (IsOpen) {
                Close();
            }
        }

        /// <inheritdoc />
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
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
        protected override DbCommand CreateDbCommand()
        {
            return new SpannerCommand();
        }

        /// <inheritdoc />
        public override string DataSource => _connectionStringBuilder.DataSource;

        /// <inheritdoc />
        public override string ServerVersion => "0.0";

        /// <summary>
        /// </summary>
        public string Project => _connectionStringBuilder.Project;

        /// <summary>
        /// </summary>
        public string SpannerInstance => _connectionStringBuilder.SpannerInstance;
    }
}