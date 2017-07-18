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
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf.WellKnownTypes;

#if NET45 || NET451
using Transaction = System.Transactions.Transaction;

#endif

// ReSharper disable UnusedParameter.Local
namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a connection to a single Spanner database.
    /// When opened, <see cref="SpannerConnection" /> will acquire and maintain a session
    /// with the target Spanner database.
    /// <see cref="SpannerCommand" /> instances using this <see cref="SpannerConnection" />
    /// will use this session to execute their operation. Concurrent read operations can
    /// share this session, but concurrent write operations may cause additional sessions
    /// to be opened to the database.
    /// Underlying sessions with the Spanner database are pooled and are closed after a
    /// configurable
    /// <see>
    /// <cref>SpannerOptions.PoolEvictionDelay</cref>
    /// </see>
    /// .
    /// </summary>
    public sealed class SpannerConnection : DbConnection
    {
        //Internally, a SpannerConnection acts as a local SessionPool.
        //When OpenAsync() is called, it creates a session with passthru transaction semantics and
        //allows other consumers to borrow that session.
        //Consumers may be SpannerTransactions or if the user has is not explicitly using transactions,
        //the consumer may be the SpannerCommand itself.
        //While SpannerTransaction has sole ownership of the session it obtains, SpannerCommand shares
        // any session it obtains with others.

        private static readonly TransactionOptions s_defaultTransactionOptions = new TransactionOptions();
        private readonly object _sync = new object();

        private SpannerConnectionStringBuilder _connectionStringBuilder;

        private CancellationTokenSource _keepAliveCancellation;

        // ReSharper disable once NotAccessedField.Local
        private Task _keepAliveTask;

        private int _sessionRefCount;
        private Session _sharedSession;

        private volatile Task<Session> _sharedSessionAllocator;
        private ConnectionState _state = ConnectionState.Closed;
        private readonly HashSet<string> _staleSessions = new HashSet<string>();

        /// <summary>
        /// Provides options to customize how connections to Spanner are created
        /// and maintained.
        /// </summary>
        public static SpannerOptions SpannerOptions => SpannerOptions.Instance;

        /// <inheritdoc />
        public override string ConnectionString
        {
            get => _connectionStringBuilder?.ToString();
            set => TrySetNewConnectionInfo(
                new SpannerConnectionStringBuilder(value, _connectionStringBuilder?.Credential));
        }

        /// <summary>
        /// The credential used for the connection, if set.
        /// If credentials are not specified, then application default credentials are used instead.
        /// See gcloud documentation on how to set up application default credentials.
        /// </summary>
        public ITokenAccess Credential => _connectionStringBuilder?.Credential;

        /// <inheritdoc />
        public override string Database => _connectionStringBuilder?.SpannerDatabase;

        /// <inheritdoc />
        public override string DataSource => _connectionStringBuilder?.DataSource;

        /// <summary>
        /// The Spanner project name.
        /// </summary>
        [Category("Data")]
        public string Project => _connectionStringBuilder?.Project;

        /// <inheritdoc />
        public override string ServerVersion => "0.0";

        /// <summary>
        /// The Spanner instance name
        /// </summary>
        [Category("Data")]
        public string SpannerInstance => _connectionStringBuilder?.SpannerInstance;

        /// <inheritdoc />
        public override ConnectionState State => _state;

        internal bool IsClosed => (State & ConnectionState.Open) == 0;

        internal bool IsOpen => (State & ConnectionState.Open) == ConnectionState.Open;

        internal SpannerClient SpannerClient { get; private set; }

        /// <summary>
        /// Creates a SpannerConnection with no datasource or credential specified.
        /// </summary>
        public SpannerConnection() { }

        /// <summary>
        /// Creates a SpannerConnection with a datasource contained in connectionString
        /// and optional credential information supplied in connectionString or the credential
        /// argument.
        /// </summary>
        /// <param name="connectionString">
        /// A Spanner formatted connection string. This is usually of the form
        /// `Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}]`
        /// </param>
        /// <param name="credential">An optional credential for operations to be performed on the Spanner database.  May be null.</param>
        public SpannerConnection(string connectionString, ITokenAccess credential = null)
            : this(new SpannerConnectionStringBuilder(connectionString, credential)) { }

        /// <summary>
        /// Creates a SpannerConnection with a datasource contained in connectionString.
        /// </summary>
        /// <param name="connectionStringBuilder">
        /// A SpannerConnectionStringBuilder containing a formatted connection string.  Must not be null.
        /// </param>
        public SpannerConnection(SpannerConnectionStringBuilder connectionStringBuilder)
        {
            GaxPreconditions.CheckNotNull(connectionStringBuilder, nameof(connectionStringBuilder));
            TrySetNewConnectionInfo(connectionStringBuilder);
        }

        /// <summary>
        /// Begins a readonly transaction using the optionally provided <see cref="CancellationToken" />.
        /// Read transactions are preferred if possible because they do not impose locks internally.
        /// ReadOnly transactions run with strong consistency and return the latest copy of data.
        /// This method is thread safe.
        /// </summary>
        /// <param name="cancellationToken">An optional token for canceling the call. May be null.</param>
        /// <returns>a new <see cref="SpannerTransaction" /></returns>
        public Task<SpannerTransaction> BeginReadOnlyTransactionAsync(
            CancellationToken cancellationToken = default(CancellationToken)) => BeginReadOnlyTransactionAsync(
            TimestampBound.Strong, cancellationToken);

        /// <summary>
        /// Begins a readonly transaction using the optionally provided <see cref="CancellationToken" />
        /// and provided <see cref="TimestampBound" /> to control the read timestamp and/or staleness
        /// of data.
        /// Read transactions are preferred if possible because they do not impose locks internally.
        /// Stale read-only transactions can execute more quickly than strong or read-write transactions,.
        /// This method is thread safe.
        /// </summary>
        /// <param name="targetReadTimestamp">Specifies the timestamp or allowed staleness of data. Must not be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns></returns>
        public Task<SpannerTransaction> BeginReadOnlyTransactionAsync(
            TimestampBound targetReadTimestamp,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            if (targetReadTimestamp.Mode == TimestampBoundMode.MinReadTimestamp
                || targetReadTimestamp.Mode == TimestampBoundMode.MaxStaleness)
            {
                throw new ArgumentException(
                    nameof(targetReadTimestamp),
                    $"{nameof(TimestampBoundMode.MinReadTimestamp)} and "
                    + $"{nameof(TimestampBoundMode.MaxStaleness)} can only be used in a single-use"
                    + " transaction as an argument to SpannerCommand.ExecuteReader().");
            }

            return BeginTransactionImplAsync(
                new TransactionOptions {ReadOnly = ConvertToOptions(targetReadTimestamp)},
                TransactionMode.ReadOnly,
                cancellationToken,
                targetReadTimestamp);
        }

        private TransactionOptions.Types.ReadOnly ConvertToOptions(TimestampBound targetReadTimestamp)
        {
            switch (targetReadTimestamp.Mode)
            {
                case TimestampBoundMode.Strong:
                    return new TransactionOptions.Types.ReadOnly {Strong = true};
                case TimestampBoundMode.ReadTimestamp:
                    return new TransactionOptions.Types.ReadOnly
                    {
                        ReadTimestamp = Timestamp.FromDateTime(targetReadTimestamp.Timestamp)
                    };
                case TimestampBoundMode.MinReadTimestamp:
                    return new TransactionOptions.Types.ReadOnly
                    {
                        MinReadTimestamp = Timestamp.FromDateTime(targetReadTimestamp.Timestamp)
                    };
                case TimestampBoundMode.ExactStaleness:
                    return new TransactionOptions.Types.ReadOnly
                    {
                        ExactStaleness = Duration.FromTimeSpan(targetReadTimestamp.Staleness)
                    };
                case TimestampBoundMode.MaxStaleness:
                    return
                        new TransactionOptions.Types.ReadOnly
                        {
                            MaxStaleness = Duration.FromTimeSpan(targetReadTimestamp.Staleness)
                        };
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Begins a new read/write transaction.
        /// This method is thread safe.
        /// </summary>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A new <see cref="SpannerTransaction" /></returns>
        public Task<SpannerTransaction> BeginTransactionAsync(
            CancellationToken cancellationToken = default(CancellationToken)) => BeginTransactionImplAsync(
            new TransactionOptions
            {
                ReadWrite = new TransactionOptions.Types.ReadWrite()
            }, TransactionMode.ReadWrite, cancellationToken);

        /// <inheritdoc />
        public override void ChangeDatabase(string newDataSource)
        {
            if (IsOpen)
            {
                Close();
            }

            TrySetNewConnectionInfo(_connectionStringBuilder?.CloneWithNewDataSource(newDataSource));
        }

        /// <inheritdoc />
        public override void Close()
        {
            Session session;
            bool primarySessionInUse;
            lock (_sync)
            {
                if (IsClosed)
                {
                    return;
                }

                _keepAliveCancellation?.Cancel();
#if NET45 || NET451
                _volatileResourceManager = null;
#endif
                primarySessionInUse = _sessionRefCount > 0;
                _state = ConnectionState.Closed;
                //we do not await the actual session close, we let that happen async.
                session = _sharedSession;
                _sharedSession = null;
            }
            if (session != null && !primarySessionInUse)
            {
                SessionPool.Default.ReleaseToPool(SpannerClient, session);
            }
            ReleaseClient(SpannerClient);
            SpannerClient = null;
        }

        private void ReleaseClient(SpannerClient client)
        {
            if (client != null)
            {
                ClientPool.Default.ReleaseClient(
                    client,
                    _connectionStringBuilder.Credential,
                    _connectionStringBuilder.EndPoint);
            }
        }

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to delete rows from a Spanner database table.
        /// This method is thread safe.
        /// </summary>
        /// <param name="databaseTable">The name of the table from which to delete rows. Must not be null.</param>
        /// <param name="primaryKeys">The set of columns that form the primary key of the table.</param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateDeleteCommand(
            string databaseTable,
            SpannerParameterCollection primaryKeys = null) => new SpannerCommand(
            SpannerCommandTextBuilder.CreateDeleteTextBuilder(databaseTable), this, null,
            primaryKeys);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to insert rows into a Spanner database table.
        /// This method is thread safe.
        /// </summary>
        /// <param name="databaseTable">The name of the table to insert rows into. Must not be null.</param>
        /// <param name="insertedColumns">
        /// A collection of <see cref="SpannerParameter" />
        /// where each instance represents a column in the Spanner database table being set.
        /// May be null.
        /// </param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateInsertCommand(
            string databaseTable,
            SpannerParameterCollection insertedColumns = null) => new SpannerCommand(
            SpannerCommandTextBuilder.CreateInsertTextBuilder(databaseTable), this, null,
            insertedColumns);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to insert or update rows into a Spanner database table.
        /// This method is thread safe.
        /// </summary>
        /// <param name="databaseTable">The name of the table to insert or updates rows. Must not be null.</param>
        /// <param name="insertUpdateColumns">
        /// A collection of <see cref="SpannerParameter" />
        /// where each instance represents a column in the Spanner database table being set.
        /// May be null
        /// </param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateInsertOrUpdateCommand(
            string databaseTable,
            SpannerParameterCollection insertUpdateColumns = null) => new SpannerCommand(
            SpannerCommandTextBuilder.CreateInsertOrUpdateTextBuilder(databaseTable), this,
            null, insertUpdateColumns);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to select rows using a SQL query statement.
        /// This method is thread safe.
        /// </summary>
        /// <param name="sqlQueryStatement">
        /// A full SQL query statement that may optionally have
        /// replacement parameters. Must not be null.
        /// </param>
        /// <param name="selectParameters">
        /// Optionally supplied set of <see cref="SpannerParameter" />
        /// that correspond to the parameters used in the SQL query. May be null.
        /// </param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateSelectCommand(
            string sqlQueryStatement,
            SpannerParameterCollection selectParameters = null) => new SpannerCommand(
            SpannerCommandTextBuilder.CreateSelectTextBuilder(sqlQueryStatement), this, null,
            selectParameters);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to update rows in a Spanner database table.
        /// This method is thread safe.
        /// </summary>
        /// <param name="databaseTable">The name of the table to update rows. Must not be null.</param>
        /// <param name="updateColumns">
        /// A collection of <see cref="SpannerParameter" />
        /// where each instance represents a column in the Spanner database table being set.
        /// Primary keys of the rows to be updated must also be included.
        /// May be null.
        /// </param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateUpdateCommand(
            string databaseTable,
            SpannerParameterCollection updateColumns = null) => new SpannerCommand(
            SpannerCommandTextBuilder.CreateUpdateTextBuilder(databaseTable), this, null,
            updateColumns);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to execute a DDL (CREATE/DROP TABLE, etc) statement.
        /// This method is thread safe.
        /// </summary>
        /// <param name="ddlStatement">The DDL statement (eg 'CREATE TABLE MYTABLE ...').  Must not be null.</param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateDdlCommand(
            string ddlStatement) => new SpannerCommand(
            SpannerCommandTextBuilder.CreateDdlTextBuilder(ddlStatement), this);

        /// <inheritdoc />
        public override void Open()
        {
            if (IsOpen)
            {
                return;
            }

            Task.Run(OpenAsync).Wait(SpannerOptions.Instance.Timeout);
        }

        /// <inheritdoc />
        public override Task OpenAsync(CancellationToken cancellationToken)
        {
#if NET45 || NET451
            var currentTransaction = Transaction.Current; //snap it on this thread.
#endif
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    if (string.IsNullOrEmpty(_connectionStringBuilder?.SpannerDatabase))
                    {
                        Logger.Warn(() => "No database was defined. Therefore OpenAsync did not establish a session.");
                        return;
                    }
                    if (IsOpen)
                    {
                        return;
                    }

                    lock (_sync)
                    {
                        if (IsOpen)
                        {
                            return;
                        }

                        if (_state == ConnectionState.Connecting)
                        {
                            throw new InvalidOperationException("The SpannerConnection is already being opened.");
                        }

                        _state = ConnectionState.Connecting;
                    }
                    SpannerClient localClient = null;
                    try
                    {
                        localClient = await ClientPool.Default.AcquireClientAsync(
                                _connectionStringBuilder.Credential,
                                _connectionStringBuilder.EndPoint)
                            .ConfigureAwait(false);
                        _sharedSession = await SessionPool.Default.CreateSessionFromPoolAsync(
                                localClient, _connectionStringBuilder.Project,
                                _connectionStringBuilder.SpannerInstance,
                                _connectionStringBuilder.SpannerDatabase,
                                s_defaultTransactionOptions,
                                cancellationToken)
                            .ConfigureAwait(false);
                        _sessionRefCount = 0;
                        _keepAliveCancellation = new CancellationTokenSource();
                        _keepAliveTask = Task.Run(
                            () => KeepAlive(_keepAliveCancellation.Token),
                            _keepAliveCancellation.Token);
                    }
                    finally
                    {
                        _state = _sharedSession != null ? ConnectionState.Open : ConnectionState.Broken;
                        if (IsOpen)
                        {
                            SpannerClient = localClient;
                        }
                        else
                        {
                            ReleaseClient(localClient);
                        }
#if NET45 || NET451
                        if (IsOpen && currentTransaction != null)
                        {
                            EnlistTransaction(currentTransaction);
                        }
#endif
                    }
                }, "SpannerConnection.OpenAsync");
        }

        /// <inheritdoc />
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            isolationLevel.AssertOneOf(nameof(isolationLevel), IsolationLevel.Serializable, IsolationLevel.Unspecified);
            return BeginTransactionAsync().ResultWithUnwrappedExceptions();
        }

        /// <inheritdoc />
        protected override DbCommand CreateDbCommand() => new SpannerCommand();

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (IsOpen)
            {
                Close();
            }
        }

        internal ISpannerTransaction GetDefaultTransaction()
        {
#if NET45 || NET451
            if (_volatileResourceManager != null)
            {
                return _volatileResourceManager;
            }
#endif
            return new EphemeralTransaction(this);
        }

        internal void ReleaseSession(Session session)
        {
            Session sessionToRelease = null;
            lock (_sync)
            {
                if (ReferenceEquals(session, _sharedSession))
                {
                    Interlocked.Decrement(ref _sessionRefCount);
                    if (!IsOpen && _sessionRefCount == 0)
                    {
                        //delayed session release due to a synchronous close
                        sessionToRelease = _sharedSession;
                        _sharedSession = null;
                    }
                }
                else if (_sharedSession == null && IsOpen)
                {
                    //someone stole the shared session, lets put it back for reserved use.
                    _sharedSession = session;
                    //we'll also ensure the refcnt is zero, but this should already be true.
                    _sessionRefCount = 0;
                }
                else if (!_staleSessions.Contains(session.Name))
                {
                    if (SessionPool.Default.IsSessionExpired(session))
                    {
                        //_staleSessions ensures we only release bad sessions once because
                        //we are clobbering its refcount that it would otherwise use for this purpose.
                        _staleSessions.Add(session.Name);
                    }
                    sessionToRelease = session;
                }
            }
            if (sessionToRelease != null)
            {
                SessionPool.Default.ReleaseToPool(SpannerClient, sessionToRelease);
            }
        }

        private Task<Session> AllocateSession(TransactionOptions options, CancellationToken cancellationToken)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    AssertOpen("execute command");
                    Task<Session> result;
                    // If the shared session gets used for anything but a write, we need
                    // to clear out the transaction state, because this will happen implicitly
                    // by spanner when a read is done without the active transaction.
                    // For other cases, the transaction state is always cleared as soon as its
                    // placed back into the session pool.
                    var sharedSessionReadOnlyUse = false;

                    lock (_sync)
                    {
                        //first we ensure _sharedSession hasn't been invalidated/expired.
                        if (SessionPool.Default.IsSessionExpired(_sharedSession))
                        {
                            _sharedSession = null;
                            _sessionRefCount = 0; //any existing references will fail out and release them.
                        }

                        //we will use _sharedSession if
                        //a) options == s_defaultTransactionOptions && _sharedSession != null
                        //    (we increment refcnt) and return _sharedSession
                        //b) options == s_defaultTransactionOptions && _sharedSession == null
                        //    we create a new shared session and return it.
                        //c) options != s_defaultTransactionOptions && _sharedSession != null && refcnt == 0
                        //    we steal _sharedSession to return it, set _sharedSession = null
                        //d) options != s_defaultTransactionOptions && (_sharedSession == null || refcnt > 0)
                        //    we grab a new session from the pool.
                        bool isSharedReadonlyTx = Equals(options, s_defaultTransactionOptions);
                        if (isSharedReadonlyTx && _sharedSession != null)
                        {
                            var taskSource = new TaskCompletionSource<Session>();
                            taskSource.SetResult(_sharedSession);
                            result = taskSource.Task;
                            Interlocked.Increment(ref _sessionRefCount);
                        }
                        else if (isSharedReadonlyTx && _sharedSession == null)
                        {
                            sharedSessionReadOnlyUse = true;
                            // If we enter this code path, it means a transaction has stolen our shared session.
                            // This is ok, we'll just create another. But need to be very careful about concurrency
                            // as compared to OpenAsync (which is documented as not threadsafe).
                            // To make this threadsafe, we store the creation task as a member and let other callers
                            // hook onto the first creation task.
                            if (_sharedSessionAllocator == null)
                            {
                                _sharedSessionAllocator = SessionPool.Default.CreateSessionFromPoolAsync(
                                    SpannerClient, _connectionStringBuilder.Project, _connectionStringBuilder.SpannerInstance,
                                    _connectionStringBuilder.SpannerDatabase, options, CancellationToken.None);
                                result = Task.Run(
                                    async () =>
                                    {
                                        var newSession = await _sharedSessionAllocator.ConfigureAwait(false);
                                        Interlocked.Increment(ref _sessionRefCount);
                                        // we need to make sure the refcnt is >0 before setting _sharedSession.
                                        // or else the session could again be stolen from us by another transaction.
                                        _sharedSession = newSession;
                                        return _sharedSession;
                                    }, CancellationToken.None);
                            }
                            else
                            {
                                result = Task.Run(
                                    async () =>
                                    {
                                        await _sharedSessionAllocator.ConfigureAwait(false);
                                        Interlocked.Increment(ref _sessionRefCount);
                                        return _sharedSession;
                                    }, CancellationToken.None);
                            }
                        }
                        else if (!isSharedReadonlyTx && _sharedSession != null && _sessionRefCount == 0)
                        {
                            //In this case, someone has called OpenAsync() followed by BeginTransactionAsync().
                            //While we'd prefer them to just call BeginTransaction (so we can allocate a session
                            // with the appropriate transaction semantics straight from the pool), this is still allowed
                            // and we shouldn't create *two* sessions here for the case where they only ever use
                            // this connection for a single transaction.
                            //So, we'll steal the shared precreated session and re-allocate it to the transaction.
                            //If the user later does reads outside of a transaction, it will force create a new session.
                            var taskSource = new TaskCompletionSource<Session>();
                            taskSource.SetResult(_sharedSession);
                            result = taskSource.Task;
                            _sessionRefCount = 0;
                            _sharedSession = null;
                            _sharedSessionAllocator = null;
                        }
                        else
                        {
                            //In this case, its a transaction and the shared session is also in use.
                            //so, we'll just create a new session (from the pool).
                            result = SessionPool.Default.CreateSessionFromPoolAsync(
                                SpannerClient, _connectionStringBuilder.Project, _connectionStringBuilder.SpannerInstance,
                                _connectionStringBuilder.SpannerDatabase, options, cancellationToken);
                        }
                    }

                    var session = await result.ConfigureAwait(false);
                    if (sharedSessionReadOnlyUse)
                    {
                        await session.RemoveFromTransactionPoolAsync().ConfigureAwait(false);
                    }

                    return session;
                }, "SpannerConnection.AllocateSession");
        }

        private void AssertClosed(string message)
        {
            if (!IsClosed)
            {
                throw new InvalidOperationException("The connection must be closed. Failed to " + message);
            }
        }

        private void AssertOpen(string message)
        {
            if (!IsOpen)
            {
                throw new InvalidOperationException("The connection must be open. Failed to " + message);
            }
        }

        internal Task<SingleUseTransaction> BeginSingleUseTransactionAsync(
            TimestampBound targetReadTimestamp,
            CancellationToken cancellationToken)
        {
            var options = new TransactionOptions {ReadOnly = ConvertToOptions(targetReadTimestamp)};
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    using (var sessionHolder = await SessionHolder.Allocate(
                            this,
                            options, cancellationToken)
                        .ConfigureAwait(false))
                    {
                        await sessionHolder.Session.RemoveFromTransactionPoolAsync().ConfigureAwait(false);
                        return new SingleUseTransaction(this, sessionHolder.TakeOwnership(), options);
                    }
                }, "SpannerConnection.BeginSingleUseTransaction");
        }

        private Task<SpannerTransaction> BeginTransactionImplAsync(
            TransactionOptions transactionOptions,
            TransactionMode transactionMode,
            CancellationToken cancellationToken,
            TimestampBound targetReadTimestamp = null)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    using (var sessionHolder = await SessionHolder.Allocate(this, transactionOptions, cancellationToken)
                        .ConfigureAwait(false))
                    {
                        var transaction = await SpannerClient
                            .BeginPooledTransactionAsync(sessionHolder.Session, transactionOptions)
                            .ConfigureAwait(false);
                        return new SpannerTransaction(
                            this, transactionMode, sessionHolder.TakeOwnership(),
                            transaction, targetReadTimestamp);
                    }
                }, "SpannerConnection.BeginTransaction");
        }

        private Task KeepAlive(CancellationToken cancellationToken)
        {
            var request = new ExecuteSqlRequest
            {
                Sql = "SELECT 1"
            };

            var task = Task.Delay(SpannerOptions.KeepAliveInterval, cancellationToken);
            var loopTask = task.ContinueWith(
                async t =>
                {
                    if (!cancellationToken.IsCancellationRequested)
                    {
                        //ping and reschedule.
                        var sharedSession = _sharedSession;
                        if (sharedSession != null)
                        {
                            try
                            {
                                request.SessionAsSessionName = sharedSession.SessionName;
                                await SpannerClient.ExecuteSqlAsync(request).WithSessionChecking(() => sharedSession)
                                    .ConfigureAwait(false);
                            }
                            catch (Exception e)
                            {
                                Logger.Warn(() => $"Exception attempting to keep session alive: {e}");
                            }
                        }

                        _keepAliveTask = Task.Run(
                            () => KeepAlive(_keepAliveCancellation.Token),
                            _keepAliveCancellation.Token);
                    }
                }, cancellationToken);

            return loopTask;
        }

        private void TrySetNewConnectionInfo(SpannerConnectionStringBuilder newBuilder)
        {
            AssertClosed("change connection information.");
            _connectionStringBuilder = newBuilder;
        }

        /// <summary>
        /// SessionHolder is a helper class to ensure that sessions do not leak and are properly recycled when
        /// an error occurs.
        /// </summary>
        internal sealed class SessionHolder : IDisposable
        {
            private readonly SpannerConnection _connection;
            private Session _session;

            public Session Session => _session;

            private SessionHolder(SpannerConnection connection, Session session)
            {
                _connection = connection;
                _session = session;
            }

            public void Dispose()
            {
                var session = Interlocked.Exchange(ref _session, null);
                if (session != null)
                {
                    _connection.ReleaseSession(session);
                }
            }

            public static Task<SessionHolder> Allocate(SpannerConnection owner, CancellationToken cancellationToken) =>
                Allocate(owner, s_defaultTransactionOptions, cancellationToken);

            public static async Task<SessionHolder> Allocate(
                SpannerConnection owner,
                TransactionOptions options,
                CancellationToken cancellationToken)
            {
                var session = await owner.AllocateSession(options, cancellationToken).ConfigureAwait(false);
                return new SessionHolder(owner, session);
            }

            public Session TakeOwnership() => Interlocked.Exchange(ref _session, null);
        }

#if NET45 || NET451
        private TimestampBound _timestampBound;
        private VolatileResourceManager _volatileResourceManager;
#endif

#if NET45 || NET451

        /// <summary>
        /// If this connection is being opened within a <see cref="System.Transactions.TransactionScope" />, this forces
        /// the created Cloud Spanner transaction to be a read-only transaction with the given
        /// <see cref="TimestampBound" /> settings.
        /// </summary>
        /// <param name="timestampBound">
        /// Specifies the timestamp or maximum staleness of a
        /// read operation. Must not be null.
        /// </param>
        public void OpenAsReadOnly(TimestampBound timestampBound = null)
        {
            if (Transaction.Current == null)
            {
                throw new InvalidOperationException($"{nameof(OpenAsReadOnly)} should only be called within a TransactionScope.");
            }
            if (!EnlistInTransaction)
            {
                throw new InvalidOperationException($"{nameof(OpenAsReadOnly)} should only be called with ${nameof(EnlistInTransaction)} set to true.");
            }
            _timestampBound = timestampBound ?? TimestampBound.Strong;
            Open();
        }

        /// <summary>
        /// If this connection is being opened within a <see cref="System.Transactions.TransactionScope" />, this forces
        /// the created Cloud Spanner transaction to be a read-only transaction with the given
        /// <see cref="TimestampBound" /> settings.
        /// </summary>
        /// <param name="timestampBound">
        /// Specifies the timestamp or maximum staleness of a
        /// read operation. Must not be null.
        /// </param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        public Task OpenAsReadOnlyAsync(TimestampBound timestampBound = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (Transaction.Current == null)
            {
                throw new InvalidOperationException($"{nameof(OpenAsReadOnlyAsync)} should only be called within a TransactionScope.");
            }
            if (!EnlistInTransaction)
            {
                throw new InvalidOperationException($"{nameof(OpenAsReadOnlyAsync)} should only be called with ${nameof(EnlistInTransaction)} set to true.");
            }
            _timestampBound = timestampBound ?? TimestampBound.Strong;
            return OpenAsync(cancellationToken);
        }
#endif

#if NET45 || NET451

        /// <summary>
        /// Gets or Sets whether to participate in the active <see cref="System.Transactions.TransactionScope" />
        /// </summary>
        // ReSharper disable once AutoPropertyCanBeMadeGetOnly.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public bool EnlistInTransaction { get; set; } = true;

        /// <inheritdoc />
        public override void EnlistTransaction(Transaction transaction)
        {
            if (!EnlistInTransaction)
            {
                return;
            }
            if (_volatileResourceManager != null)
            {
                throw new InvalidOperationException("This connection is already enlisted to a transaction.");
            }
            _volatileResourceManager = new VolatileResourceManager(this, _timestampBound);
            transaction.EnlistVolatile(_volatileResourceManager, System.Transactions.EnlistmentOptions.None);
        }

        /// <inheritdoc />
        protected override DbProviderFactory DbProviderFactory => SpannerProviderFactory.Instance;
#endif
    }
}
