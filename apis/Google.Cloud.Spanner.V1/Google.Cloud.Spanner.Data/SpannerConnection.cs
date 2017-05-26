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
using Google.Api.Gax;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Logging;
using Google.Protobuf.WellKnownTypes;
using TransactionOptions = Google.Cloud.Spanner.V1.TransactionOptions;
#if NET45 || NET451
using Transaction = System.Transactions.Transaction;

#endif

// ReSharper disable UnusedParameter.Local
namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// A SpannerConnection represents a connection to a single Spanner database.
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

#if NET45 || NET451
        private TimestampBound _timestampBound;
        private VolatileResourceManager _volatileResourceManager;
#endif

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
            : this(new SpannerConnectionStringBuilder(connectionString, credential))
        {
        }

        /// <summary>
        /// Creates a SpannerConnection with a datasource contained in connectionString.
        /// </summary>
        /// <param name="connectionStringBuilder">
        /// A SpannerConnectionStringBuilder containing
        /// a formatted connection string.
        /// </param>
        public SpannerConnection(SpannerConnectionStringBuilder connectionStringBuilder)
        {
            GaxPreconditions.CheckNotNull(connectionStringBuilder, nameof(connectionStringBuilder));
            TrySetNewConnectionInfo(connectionStringBuilder);
        }

        /// <summary>
        /// Provides options to customize how connections to Spanner are created
        /// and maintained.
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
        /// Returns the credential used for the connection, if set.
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
        public override ConnectionState State => _state;


        internal bool IsClosed => (State & ConnectionState.Open) == 0;

        internal bool IsOpen => (State & ConnectionState.Open) == ConnectionState.Open;

        internal SpannerClient SpannerClient { get; private set; }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<SpannerTransaction> BeginReadOnlyTransactionAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return BeginReadOnlyTransactionAsync(TimestampBound.Strong, cancellationToken);
        }

        /// <summary>
        /// </summary>
        /// <param name="targetReadTimeStamp"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<SpannerTransaction> BeginReadOnlyTransactionAsync(TimestampBound targetReadTimeStamp,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            TransactionOptions.Types.ReadOnly readOnlyOptions;
            switch (targetReadTimeStamp.Mode)
            {
                case TimestampBoundMode.Strong:
                    readOnlyOptions = new TransactionOptions.Types.ReadOnly {Strong = true};
                    break;
                case TimestampBoundMode.ReadTimestamp:
                    readOnlyOptions = new TransactionOptions.Types.ReadOnly {
                        ReadTimestamp = Timestamp.FromDateTime(targetReadTimeStamp.TimeStamp)
                    };
                    break;
                case TimestampBoundMode.MinReadTimestamp:
                    readOnlyOptions = new TransactionOptions.Types.ReadOnly {
                        MinReadTimestamp = Timestamp.FromDateTime(targetReadTimeStamp.TimeStamp)
                    };
                    break;
                case TimestampBoundMode.ExactStaleness:
                    readOnlyOptions = new TransactionOptions.Types.ReadOnly {
                        ExactStaleness = Duration.FromTimeSpan(targetReadTimeStamp.Staleness)
                    };
                    break;
                case TimestampBoundMode.MaxStaleness:
                    readOnlyOptions =
                        new TransactionOptions.Types.ReadOnly {
                            MaxStaleness = Duration.FromTimeSpan(targetReadTimeStamp.Staleness)
                        };
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return BeginTransactionImpl(cancellationToken, new TransactionOptions {
                ReadOnly = readOnlyOptions
            }, TransactionMode.ReadOnly);
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<SpannerTransaction> BeginTransactionAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return BeginTransactionImpl(cancellationToken, new TransactionOptions {
                ReadWrite = new TransactionOptions.Types.ReadWrite()
            }, TransactionMode.ReadWrite);
        }

        /// <inheritdoc />
        public override void ChangeDatabase(string newDataSource)
        {
            if (IsOpen)
                Close();
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
                SpannerClient.ReleaseToPool(session);
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
            Task.Run(OpenAsync).Wait(ConnectionPoolOptions.Instance.Timeout);
        }

        /// <inheritdoc />
        public override Task OpenAsync(CancellationToken cancellationToken)
        {
#if NET45 || NET451
            var currentTransaction = Transaction.Current; //snap it on this thread.
#endif

            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
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
                    SpannerClient = await ClientPool.AcquireClientAsync(_connectionStringBuilder.Credential,
                            _connectionStringBuilder.EndPoint)
                        .ConfigureAwait(false);
                    _sharedSession = await SpannerClient.CreateSessionFromPoolAsync(
                            _connectionStringBuilder.Project,
                            _connectionStringBuilder.SpannerInstance,
                            _connectionStringBuilder.SpannerDatabase,
                            s_defaultTransactionOptions,
                            cancellationToken)
                        .ConfigureAwait(false);
                    _sessionRefCount = 0;
                    _keepAliveCancellation = new CancellationTokenSource();
                    _keepAliveTask = Task.Run(() => KeepAlive(_keepAliveCancellation.Token),
                        _keepAliveCancellation.Token);
                }
                finally
                {
                    _state = _sharedSession != null ? ConnectionState.Open : ConnectionState.Broken;
#if NET45 || NET451
                    if (IsOpen && currentTransaction != null)
                        EnlistTransaction(currentTransaction);
#endif
                }
            }, "SpannerConnection.OpenAsync");
        }

#if NET45 || NET451
        /// <summary>
        /// </summary>
        /// <param name="timestampBound"></param>
        /// <returns></returns>
        public void OpenWithTimeBoundSettings(TimestampBound timestampBound)
        {
            _timestampBound = timestampBound;
            Open();
        }

        /// <summary>
        /// </summary>
        /// <param name="timestampBound"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task OpenWithTimeBoundSettingsAsync(TimestampBound timestampBound, CancellationToken cancellationToken)
        {
            _timestampBound = timestampBound;
            return OpenAsync(cancellationToken);
        }
#endif

        /// <inheritdoc />
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            isolationLevel.AssertOneOf(nameof(isolationLevel), IsolationLevel.Serializable, IsolationLevel.Unspecified);
            return BeginTransactionAsync().ResultWithUnwrappedExceptions();
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

        internal ISpannerTransaction GetDefaultTransaction()
        {
#if NET45 || NET451
            if (_volatileResourceManager != null)
                return _volatileResourceManager;
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
                    if (SessionPool.IsSessionExpired(session))
                    {
                        //_staleSessions ensures we only release bad sessions once because
                        //we are clobbering its refcount that it would otherwise use for this purpose.
                        _staleSessions.Add(session.Name);
                    }
                    sessionToRelease = session;
                }
            }
            if (sessionToRelease != null)
                SpannerClient.ReleaseToPool(sessionToRelease);
        }

        private Task<Session> AllocateSession(TransactionOptions options, CancellationToken cancellationToken)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(() =>
            {
                AssertOpen("execute command");
                Task<Session> result;

                lock (_sync)
                {
                    //first we ensure _sharedSession hasn't been invalidated/expired.
                    if (SessionPool.IsSessionExpired(_sharedSession))
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
                    var isSharedReadonlyTx = Equals(options, s_defaultTransactionOptions);
                    if (isSharedReadonlyTx && _sharedSession != null)
                    {
                        var taskSource = new TaskCompletionSource<Session>();
                        taskSource.SetResult(_sharedSession);
                        result = taskSource.Task;
                        Interlocked.Increment(ref _sessionRefCount);
                    }
                    else if (isSharedReadonlyTx && _sharedSession == null)
                    {
                        // If we enter this code path, it means a transaction has stolen our shared session.
                        // This is ok, we'll just create another.  But need to be very careful about concurrency
                        // as compared to OpenAsync (which is documented as not threadsafe).
                        // To make this threadsafe, we store the creation task as a member and let other callers
                        // hook onto the first creation task.
                        if (_sharedSessionAllocator == null)
                        {
                            _sharedSessionAllocator = SpannerClient.CreateSessionFromPoolAsync(
                                _connectionStringBuilder.Project, _connectionStringBuilder.SpannerInstance,
                                _connectionStringBuilder.SpannerDatabase, options, CancellationToken.None);
                            _sharedSessionAllocator.ContinueWith(t =>
                            {
                                if (t.IsCompleted)
                                {
                                    // we need to make sure the refcnt is >0 before setting _sharedSession.
                                    // or else the session could again be stolen from us by another transaction.
                                    Interlocked.Increment(ref _sessionRefCount);
                                    _sharedSession = t.ResultWithUnwrappedExceptions();
                                }
                            }, CancellationToken.None);
                        }
                        else
                        {
                            _sharedSessionAllocator.ContinueWith(t =>
                            {
                                if (t.IsCompleted)
                                    Interlocked.Increment(ref _sessionRefCount);
                            }, CancellationToken.None);
                        }
                        result = _sharedSessionAllocator;
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
                        result = SpannerClient.CreateSessionFromPoolAsync(
                            _connectionStringBuilder.Project, _connectionStringBuilder.SpannerInstance,
                            _connectionStringBuilder.SpannerDatabase, options, cancellationToken);
                    }
                }

                return result;
            }, "SpannerConnection.AllocateSession");
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

        private Task<SpannerTransaction> BeginTransactionImpl(CancellationToken cancellationToken,
            TransactionOptions transactionOptions,
            TransactionMode transactionMode)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(async () =>
            {
                using (var sessionHolder = await SessionHolder.Allocate(this, transactionOptions, cancellationToken)
                    .ConfigureAwait(false))
                {
                    var transaction = await SpannerClient
                        .BeginPooledTransactionAsync(sessionHolder.Session, transactionOptions)
                        .ConfigureAwait(false);
                    return new SpannerTransaction(this, transactionMode, sessionHolder.TakeOwnership(),
                        transaction);
                }
            }, "SpannerConnection.BeginTransaction");
        }

        private Task KeepAlive(CancellationToken cancellationToken)
        {
            var request = new ExecuteSqlRequest {
                Sql = "SELECT 1"
            };

            var task = Task.Delay(ConnectionPoolOptions.KeepAliveInterval, cancellationToken);
            var loopTask = task.ContinueWith(async t =>
            {
                if (!cancellationToken.IsCancellationRequested)
                {
                    //ping and reschedule.
                    var sharedSession = _sharedSession;
                    if (sharedSession != null)
                        try
                        {
                            request.SessionAsSessionName = sharedSession.SessionName;
                            await SpannerClient.ExecuteSqlAsync(request).WithSessionChecking(() => sharedSession);
                        }
                        catch (Exception e)
                        {
                            Logger.Warn(() => $"Exception attempting to keep session alive: {e}");
                        }

                    _keepAliveTask = Task.Run(() => KeepAlive(_keepAliveCancellation.Token),
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

            private SessionHolder(SpannerConnection connection, Session session)
            {
                _connection = connection;
                _session = session;
            }

            public Session Session => _session;

            public void Dispose()
            {
                var session = Interlocked.Exchange(ref _session, null);
                if (session != null)
                    _connection.ReleaseSession(session);
            }

            public static Task<SessionHolder> Allocate(SpannerConnection owner, CancellationToken cancellationToken)
            {
                return Allocate(owner, s_defaultTransactionOptions, cancellationToken);
            }

            public static async Task<SessionHolder> Allocate(SpannerConnection owner, TransactionOptions options,
                CancellationToken cancellationToken)
            {
                var session = await owner.AllocateSession(options, cancellationToken).ConfigureAwait(false);
                return new SessionHolder(owner, session);
            }

            public Session TakeOwnership()
            {
                return Interlocked.Exchange(ref _session, null);
            }
        }

#if NET45 || NET451

        /// <summary>
        /// </summary>
        public bool EnlistInTransaction { get; set; } = true;

        /// <inheritdoc />
        public override void EnlistTransaction(Transaction transaction)
        {
            if (!EnlistInTransaction) return;
            if (_volatileResourceManager != null)
                throw new InvalidOperationException("This connection is already enlisted to a transaction.");
            _volatileResourceManager = new VolatileResourceManager(this, _timestampBound);
            transaction.EnlistVolatile(_volatileResourceManager, System.Transactions.EnlistmentOptions.None);
        }

        /// <inheritdoc />
        protected override DbProviderFactory DbProviderFactory => SpannerProviderFactory.Instance;

#endif
    }
}