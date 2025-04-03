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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.SessionPool;
using Transaction = System.Transactions.Transaction;

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
        private readonly object _sync = new object();

        // The SessionPool to use to allocate sessions. This is obtained from the SessionPoolManager,
        // and released when the connection is closed/disposed.
        private SessionPool _sessionPool;

        private ConnectionState _state = ConnectionState.Closed;

        // State used for TransactionScope-based transactions.
        private VolatileResourceManager _volatileResourceManager;

        /// <inheritdoc />
        public override string ConnectionString
        {
            get => Builder.ToString();
            set
            {
                var newBuilder = Builder.Clone();
                newBuilder.ConnectionString = value;
                TrySetNewConnectionInfo(newBuilder);
            }
        }

        /// <inheritdoc />
        protected override DbProviderFactory DbProviderFactory => SpannerProviderFactory.Instance;

        /// <summary>
        /// The current connection string builder. The object is never mutated and never exposed to consumers.
        /// The value may be changed to a new builder by setting the <see cref="ConnectionString"/>
        /// property, or within this class via the <see cref="TrySetNewConnectionInfo(SpannerConnectionStringBuilder)"/> method.
        /// This value is never null.
        /// </summary>
        internal SpannerConnectionStringBuilder Builder { get; private set; }

        /// <inheritdoc />
        public override string Database => Builder.SpannerDatabase;

        /// <inheritdoc />
        public override string DataSource => Builder.DataSource;

        /// <summary>
        /// The Spanner project name.
        /// </summary>
        [Category("Data")]
        public string Project => Builder.Project;

        /// <inheritdoc />
        public override string ServerVersion => "0.0";

        /// <summary>
        /// The Spanner instance name
        /// </summary>
        [Category("Data")]
        public string SpannerInstance => Builder.SpannerInstance;

        /// <summary>
        /// The logger used by this connection. This is never null.
        /// </summary>
        internal Logger Logger => Builder.SessionPoolManager.Logger;

        /// <inheritdoc />
        public override ConnectionState State
        {
            get
            {
                lock (_sync)
                {
                    return _state;
                }
            }
        }

        internal bool IsOpen => (State & ConnectionState.Open) == ConnectionState.Open;

        internal bool IsClosed => (State & ConnectionState.Open) == 0;

        /// <summary>
        /// Query options to use throughout the lifetime of the connection when
        /// running SQL and streaming SQL requests.
        /// </summary>
        public QueryOptions QueryOptions { get; set; }

        /// <summary>
        /// Request commit statistics for all read/write transactions throughout the
        /// lifetime of the connection and log these. This value is set as the
        /// default for read/write transactions created by this connection, and
        /// is used for statements that are executed on this connection without
        /// a transaction.
        /// </summary>
        /// <remarks>
        /// Commit statistics that are returned for a transaction are logged using the
        /// logger of this connection. Applications can set a custom logger on the
        /// connection to log the output to a different destination.
        /// <see cref="Google.Cloud.Spanner.V1.Internal.Logging.Logger.LogCommitStats(CommitRequest, CommitResponse)"/>
        /// </remarks>
        public bool LogCommitStats => Builder.LogCommitStats;

        /// <summary>
        /// Gets or Sets whether to participate in the active <see cref="System.Transactions.TransactionScope" />
        /// </summary>
        public bool EnlistInTransaction { get; set; } = true;

        /// <summary>
        /// Returns the current ambient transaction (from TransactionScope), if any.
        /// The .NET Standard 1.x version will always return null, as TransactionScope is not supported in .NET Core 1.x.
        /// </summary>
        internal ISpannerTransaction AmbientTransaction => _volatileResourceManager;

        /// <summary>
        /// Creates a SpannerConnection with no datasource or credential specified.
        /// </summary>
        public SpannerConnection() : this(new SpannerConnectionStringBuilder())
        {
        }

        /// <summary>
        /// Creates a SpannerConnection with a datasource contained in <paramref name="connectionString"/>
        /// and optional credential information supplied in <paramref name="connectionString"/> or the <paramref name="credentials"/>
        /// argument.
        /// </summary>
        /// <param name="connectionString">
        /// A Spanner formatted connection string. This is usually of the form
        /// `Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}]`
        /// </param>
        /// <param name="credentials">An optional credential for operations to be performed on the Spanner database. May be null.</param>
        public SpannerConnection(string connectionString, ChannelCredentials credentials = null)
            : this(new SpannerConnectionStringBuilder(connectionString, credentials)) { }

        /// <summary>
        /// Creates a SpannerConnection with a datasource contained in <paramref name="connectionString"/>
        /// and optional credential information supplied in <paramref name="connectionString"/> or the <paramref name="googleCredential"/>
        /// argument.
        /// </summary>
        /// <param name="connectionString">
        /// A Spanner formatted connection string. This is usually of the form
        /// `Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}]`
        /// </param>
        /// <param name="googleCredential">An optional credential for operations to be performed on the Spanner database. May be null.</param>
        public SpannerConnection(string connectionString, GoogleCredential googleCredential)
            : this(new SpannerConnectionStringBuilder(connectionString, googleCredential)) { }

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

        /// <inheritdoc />
        public override void Open()
        {
            if (IsOpen)
            {
                return;
            }
            Open(GetTransactionEnlister());
        }

        /// <inheritdoc />
        public override Task OpenAsync(CancellationToken cancellationToken) => OpenAsyncImpl(GetTransactionEnlister(), cancellationToken);

        /// <summary>
        /// Opens the connection within a <see cref="System.Transactions.TransactionScope"/> with specific
        /// <see cref="SpannerTransactionCreationOptions"/> and <see cref="SpannerTransactionOptions"/>.
        /// </summary>
        /// <param name="creationOptions">
        /// Options to be used when creating the ambient <see cref="SpannerTransaction"/>.
        /// Must not be null.
        /// </param>
        /// <param name="options">
        /// Options to be applied to the ambient <see cref="SpannerTransaction"/> after creation.
        /// May be null, in which case defaults will be used.
        /// A copy of this value will be used internally, so any changes to <paramref name="options"/> made after calling this method
        /// will have no effect on the ambient transaction.
        /// </param>
        public void Open(SpannerTransactionCreationOptions creationOptions, SpannerTransactionOptions options)
        {
            GaxPreconditions.CheckNotNull(creationOptions, nameof(creationOptions));
            GaxPreconditions.CheckArgument(
                !creationOptions.IsPartitionedDml,
                nameof(creationOptions),
                $"Partitioned DML transactions may only be used when executing {nameof(SpannerCommand.ExecutePartitionedUpdateAsync)} and similar methods.");

            var transaction = Transaction.Current;
            if (transaction == null)
            {
                throw new InvalidOperationException($"{nameof(Open)} should only be called within a TransactionScope.");
            }
            if (!EnlistInTransaction)
            {
                throw new InvalidOperationException($"{nameof(Open)} should only be called with ${nameof(EnlistInTransaction)} set to true.");
            }

            // Copy options because SpannerTransactionOptions is mutable.
            options = options is null ? new SpannerTransactionOptions() : new SpannerTransactionOptions(options);

            Open(() => EnlistTransaction(transaction, creationOptions, options));
        }

        /// <summary>
        /// Opens the connection within a <see cref="System.Transactions.TransactionScope"/> with specific
        /// <see cref="SpannerTransactionCreationOptions"/> and <see cref="SpannerTransactionOptions"/>.
        /// </summary>
        /// <param name="creationOptions">
        /// Options to be used when creating the ambient <see cref="SpannerTransaction"/>.
        /// Must not be null.
        /// </param>
        /// <param name="options">
        /// Options to be applied to the ambient <see cref="SpannerTransaction"/> after creation.
        /// May be null, in which case defaults will be used.
        /// A copy of this value will be used internally, so any changes to <paramref name="options"/> made after calling this method
        /// will have no effect on the ambient transaction.
        /// </param>
        /// <param name="cancellationToken">The cancellation token for the operation.</param>
        public Task OpenAsync(SpannerTransactionCreationOptions creationOptions, SpannerTransactionOptions options, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(creationOptions, nameof(creationOptions));
            GaxPreconditions.CheckArgument(
                !creationOptions.IsPartitionedDml,
                nameof(creationOptions),
                $"Partitioned DML transactions may only be used when executing {nameof(SpannerCommand.ExecutePartitionedUpdateAsync)} and similar methods.");

            var transaction = Transaction.Current;
            if (transaction == null)
            {
                throw new InvalidOperationException($"{nameof(Open)} should only be called within a TransactionScope.");
            }
            if (!EnlistInTransaction)
            {
                throw new InvalidOperationException($"{nameof(Open)} should only be called with ${nameof(EnlistInTransaction)} set to true.");
            }

            // Copy options because SpannerTransactionOptions is mutable.
            options = options is null ? new SpannerTransactionOptions() : new SpannerTransactionOptions(options);

            return OpenAsyncImpl(() => EnlistTransaction(transaction, creationOptions, options), cancellationToken);
        }

        /// <summary>
        /// Call OpenAsReadOnly within a <see cref="System.Transactions.TransactionScope" /> to open the connection
        /// with a read-only transaction with the given <see cref="TimestampBound" /> settings
        /// </summary>
        /// <param name="timestampBound">Specifies the timestamp or maximum staleness of a read operation. May be null.</param>
        [Obsolete($"Use the {nameof(Open)} overload that takes {nameof(SpannerTransactionCreationOptions)} and {nameof(SpannerTransactionOptions)} parameters instead.")]
        public void OpenAsReadOnly(TimestampBound timestampBound = null) =>
            Open(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(timestampBound), options: null);

        /// <summary>
        /// If this connection is being opened within a <see cref="System.Transactions.TransactionScope" />, this
        /// will connect to an existing transaction identified by <paramref name="transactionId"/>.
        /// </summary>
        /// <param name="transactionId">The <see cref="TransactionId"/> representing an active readonly <see cref="SpannerTransaction"/>.</param>
        [Obsolete($"Use the {nameof(Open)} overload that takes {nameof(SpannerTransactionCreationOptions)} and {nameof(SpannerTransactionOptions)} parameters instead.")]
        public void OpenAsReadOnly(TransactionId transactionId) =>
            Open(SpannerTransactionCreationOptions.FromReadOnlyTransactionId(transactionId), options: null);

        /// <summary>
        /// If this connection is being opened within a <see cref="System.Transactions.TransactionScope" />, this forces
        /// the created Cloud Spanner transaction to be a read-only transaction with the given
        /// <see cref="TimestampBound" /> settings.
        /// </summary>
        /// <param name="timestampBound">Specifies the timestamp or maximum staleness of a read operation. May be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        [Obsolete($"Use the {nameof(OpenAsync)} overload that takes {nameof(SpannerTransactionCreationOptions)} and {nameof(SpannerTransactionOptions)} parameters instead.")]
        public Task OpenAsReadOnlyAsync(TimestampBound timestampBound = null, CancellationToken cancellationToken = default) =>
            OpenAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(timestampBound), options: null, cancellationToken);

        private void Open(Action transactionEnlister)
        {
            Func<Task> taskRunner = () => OpenAsyncImpl(transactionEnlister, CancellationToken.None);

            // This is slightly annoying, but hard to get round: most of our timeouts use Expiration, but this is more of
            // a BCL-oriented timeout.
            int timeoutSeconds = Builder.Timeout;
            TimeSpan timeout = Builder.AllowImmediateTimeouts && timeoutSeconds == 0
                ? TimeSpan.FromMilliseconds(-1)
                : TimeSpan.FromSeconds(timeoutSeconds);
            if (!Task.Run(taskRunner).WaitWithUnwrappedExceptions(timeout))
            {
                throw new SpannerException(ErrorCode.DeadlineExceeded, "Timed out opening connection");
            }
        }

        /// <summary>
        /// Opens the connection, which involves acquiring a SessionPool,
        /// and potentially enlists the connection in the current transaction.
        /// </summary>
        /// <param name="transactionEnlister">Enlistment delegate; may be null.</param>
        /// <param name="cancellationToken">Cancellation token; may be None</param>
        private Task OpenAsyncImpl(Action transactionEnlister, CancellationToken cancellationToken)
        {
            // TODO: Use the cancellation token. We can't at the moment, as the only reason for this being async is
            // due to credential fetching, and we can't pass a cancellation token to any of that.
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    ConnectionState previousState;
                    lock (_sync)
                    {
                        previousState = _state;
                        if (IsOpen)
                        {
                            return;
                        }

                        if (previousState == ConnectionState.Connecting)
                        {
                            throw new InvalidOperationException("The SpannerConnection is already being opened.");
                        }

                        _state = ConnectionState.Connecting;
                    }
                    OnStateChange(new StateChangeEventArgs(previousState, ConnectionState.Connecting));
                    try
                    {
                        _sessionPool = await Builder.AcquireSessionPoolAsync().ConfigureAwait(false);
                    }
                    finally
                    {
                        // Note: the code could be simplified if we don't mind the ordering of "change state, enlist, fire OnStateChange" -
                        // but it's not clear whether or not that's a problem.
                        lock (_sync)
                        {
                            _state = _sessionPool != null ? ConnectionState.Open : ConnectionState.Broken;
                        }
                        if (IsOpen)
                        {
                            transactionEnlister?.Invoke();
                        }
                        OnStateChange(new StateChangeEventArgs(ConnectionState.Connecting, _state));
                    }
                }, "SpannerConnection.OpenAsync", Logger);
        }

        /// <summary>
        /// Returns a delegate to enlist the current transaction (as detected on the executing thread *now*)
        /// when opening the connection.
        /// </summary>
        private Action GetTransactionEnlister()
        {
            Transaction current = Transaction.Current;
            return current == null ? (Action) null : () => EnlistTransaction(current);
        }

        /// <inheritdoc />
        public override void EnlistTransaction(Transaction transaction) => EnlistTransaction(transaction, SpannerTransactionCreationOptions.ReadWrite, new SpannerTransactionOptions());

        /// <summary>
        /// Enlists this connection in <paramref name="transaction"/>.
        /// A <see cref="SpannerTransaction"/> will be created from the given options.
        /// Note that <see cref="SpannerTransactionOptions"/> is mutable and <paramref name="options"/> is not copied.
        /// Callers should take care to pass an exclusive instance.
        /// </summary>
        private void EnlistTransaction(Transaction transaction, SpannerTransactionCreationOptions creationOptions, SpannerTransactionOptions options)
        {
            if (!EnlistInTransaction)
            {
                return;
            }
            if (_volatileResourceManager != null)
            {
                throw new InvalidOperationException("This connection is already enlisted to a transaction.");
            }
            _volatileResourceManager = new VolatileResourceManager(this, creationOptions, options);
            transaction.EnlistVolatile(_volatileResourceManager, System.Transactions.EnlistmentOptions.None);
        }

        /// <summary>
        /// Begins a read-only transaction using the optionally provided <see cref="CancellationToken" />.
        /// Read transactions are preferred if possible because they do not impose locks internally.
        /// ReadOnly transactions run with strong consistency and return the latest copy of data.
        /// This method is thread safe.
        /// </summary>
        /// <param name="cancellationToken">An optional token for canceling the call. May be null.</param>
        /// <returns>The newly created <see cref="SpannerTransaction"/>.</returns>
        [Obsolete($"Use the {nameof(BeginTransactionAsync)} overload that takes {nameof(SpannerTransactionCreationOptions)} as a parameter instead.")]
        public Task<SpannerTransaction> BeginReadOnlyTransactionAsync(CancellationToken cancellationToken = default) =>
            BeginTransactionAsync(SpannerTransactionCreationOptions.ReadOnly, cancellationToken);

        /// <summary>
        /// Begins a read-only transaction using the optionally provided <see cref="CancellationToken" />
        /// and provided <see cref="TimestampBound" /> to control the read timestamp and/or staleness
        /// of data.
        /// Read transactions are preferred if possible because they do not impose locks internally.
        /// Stale read-only transactions can execute more quickly than strong or read-write transactions.
        /// This method is thread safe.
        /// </summary>
        /// <param name="targetReadTimestamp">Specifies the timestamp or allowed staleness of data. Must not be null.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The newly created <see cref="SpannerTransaction"/>.</returns>
        [Obsolete($"Use the {nameof(BeginTransactionAsync)} overload that takes {nameof(SpannerTransactionCreationOptions)} as a parameter instead.")]
        public Task<SpannerTransaction> BeginReadOnlyTransactionAsync(TimestampBound targetReadTimestamp, CancellationToken cancellationToken = default) =>
            BeginTransactionAsync(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(targetReadTimestamp), cancellationToken);

        /// <summary>
        /// Begins a read-only transaction.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Read-only transactions are preferred if possible because they do not impose locks internally.
        /// Read-only transactions run with strong consistency and return the latest copy of data.
        /// </para>
        /// <para>This method is thread safe.</para>
        /// </remarks>
        /// <returns>The newly created <see cref="SpannerTransaction"/>.</returns>
        [Obsolete($"Use the {nameof(BeginTransaction)} overload that takes {nameof(SpannerTransactionCreationOptions)} as a parameter instead.")]
        public SpannerTransaction BeginReadOnlyTransaction() => BeginTransaction(SpannerTransactionCreationOptions.ReadOnly);

        /// <summary>
        /// Begins a read-only transaction using the provided <see cref="TimestampBound"/> to control the read timestamp
        /// and/or staleness of data.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Read-only transactions are preferred if possible because they do not impose locks internally.
        /// Read-only transactions run with strong consistency and return the latest copy of data.
        /// </para>
        /// <para>This method is thread safe.</para>
        /// </remarks>
        /// <param name="targetReadTimestamp">Specifies the timestamp or allowed staleness of data. Must not be null.</param>
        /// <returns>The newly created <see cref="SpannerTransaction"/>.</returns>
        [Obsolete($"Use the {nameof(BeginTransaction)} overload that takes {nameof(SpannerTransactionCreationOptions)} as a parameter instead.")]
        public SpannerTransaction BeginReadOnlyTransaction(TimestampBound targetReadTimestamp) => BeginTransaction(SpannerTransactionCreationOptions.ForTimestampBoundReadOnly(targetReadTimestamp));

        /// <summary>
        /// Begins a read-only transaction using the provided <see cref="TransactionId" /> to refer to an existing server-side transaction.
        /// </summary>
        /// <remarks>
        /// Read-only transactions are preferred if possible because they do not impose locks internally.
        /// Providing a transaction ID will connect to an already created transaction which is useful
        /// for batch reads. This method differs from <see cref="BeginReadOnlyTransaction()">the parameterless overload</see>
        /// and <see cref="BeginReadOnlyTransaction(TimestampBound)">the overload accepting a TimestampBound</see> as it
        /// uses an existing transaction rather than creating a new server-side transaction.
        /// </remarks>
        /// <param name="transactionId">Specifies the transaction ID of an existing read-only transaction.</param>
        /// <returns>A <see cref="SpannerTransaction"/> attached to the existing transaction represented by
        /// <paramref name="transactionId"/>.</returns>
        [Obsolete($"Use the {nameof(BeginTransaction)} overload that takes {nameof(SpannerTransactionCreationOptions)} as a parameter instead.")]
        public SpannerTransaction BeginReadOnlyTransaction(TransactionId transactionId) => BeginTransaction(SpannerTransactionCreationOptions.FromReadOnlyTransactionId(transactionId));

        /// <summary>
        /// Begins a new Spanner transaction synchronously. This method hides <see cref="DbConnection.BeginTransaction()"/>, but behaves
        /// the same way, just with a more specific return type.
        /// </summary>
        public new SpannerTransaction BeginTransaction() => (SpannerTransaction)base.BeginTransaction();

        /// <summary>
        /// Begins a new read/write transaction.
        /// This method is thread safe.
        /// </summary>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A new <see cref="SpannerTransaction" /></returns>
#if NET462
        public Task<SpannerTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default) =>
#else
        public new Task<SpannerTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default) =>
#endif
            BeginTransactionAsync(SpannerTransactionCreationOptions.ReadWrite, cancellationToken);

        /// <inheritdoc />
        protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
        {
            if (isolationLevel != IsolationLevel.Unspecified
                && isolationLevel != IsolationLevel.Serializable)
            {
                throw new NotSupportedException(
                    $"Cloud Spanner only supports isolation levels {IsolationLevel.Serializable} and {IsolationLevel.Unspecified}.");
            }
            return Task.Run(() => BeginTransactionAsync()).ResultWithUnwrappedExceptions();
        }

#if NETSTANDARD2_1_OR_GREATER
        /// <inheritdoc />
        protected override async ValueTask<DbTransaction> BeginDbTransactionAsync(IsolationLevel isolationLevel, CancellationToken cancellationToken)
        {
            if (isolationLevel != IsolationLevel.Unspecified && isolationLevel != IsolationLevel.Serializable)
            {
                throw new NotSupportedException(
                    $"Cloud Spanner only supports isolation levels {IsolationLevel.Serializable} and {IsolationLevel.Unspecified}.");
            }
            return await BeginTransactionAsync(cancellationToken).ConfigureAwait(false);
        }
#endif
        /// <summary>
        /// Creates a <see cref="SpannerTransaction"/> based on the given creation options.
        /// </summary>
        public SpannerTransaction BeginTransaction(SpannerTransactionCreationOptions transactionCreationOptions) =>
            Task.Run(
                () => BeginTransactionAsync(transactionCreationOptions, cancellationToken: default))
            .ResultWithUnwrappedExceptions();

        /// <summary>
        /// Creates a <see cref="SpannerTransaction"/> based on the given creation options.
        /// </summary>
        public Task<SpannerTransaction> BeginTransactionAsync(
            SpannerTransactionCreationOptions transactionCreationOptions,
            CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(transactionCreationOptions, nameof(transactionCreationOptions));
            GaxPreconditions.CheckArgument(
                !transactionCreationOptions.IsPartitionedDml,
                nameof(transactionCreationOptions),
                $"Partitioned DML transactions may only be used when executing {nameof(SpannerCommand.ExecutePartitionedUpdateAsync)} and similar methods.");

            GaxPreconditions.CheckArgument(
                !transactionCreationOptions.IsSingleUse,
                nameof(transactionCreationOptions.IsSingleUse),
                $"Single-use transactions may only be used with the {nameof(SpannerCommand.ExecuteReader)} set  of methods.");

            return BeginTransactionAsyncImpl(transactionCreationOptions, cancellationToken);
        }

        internal Task<SpannerTransaction> BeginTransactionAsyncImpl(
            SpannerTransactionCreationOptions transactionCreationOptions,
            CancellationToken cancellationToken)
        {
            return ExecuteHelper.WithErrorTranslationAndProfiling(
                async () =>
                {
                    await OpenAsync(cancellationToken).ConfigureAwait(false);

                    PooledSession session;
                    if (transactionCreationOptions.TransactionId is null)
                    {
                        session = await AcquireSessionAsync(transactionCreationOptions, cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        SessionName sessionName = SessionName.Parse(transactionCreationOptions.TransactionId.Session);
                        ByteString transactionIdBytes = ByteString.FromBase64(transactionCreationOptions.TransactionId.Id);
                        session = _sessionPool.CreateDetachedSession(sessionName, transactionIdBytes, TransactionOptions.ModeOneofCase.ReadOnly);
                    }
                    return new SpannerTransaction(this, session, transactionCreationOptions, isRetriable: false);
                }, "SpannerConnection.BeginTransactionAsync", Logger);
        }

        /// <summary>
        /// Executes a read-write transaction, with retries as necessary.
        /// The work to perform in each transaction attempt is defined by <paramref name="asyncWork"/>.
        /// </summary>
        /// <remarks><paramref name="asyncWork"/> will be fully retried whenever the <see cref="SpannerTransaction"/>
        /// that it receives as a parameter aborts. <paramref name="asyncWork"/> won't be retried if any other errors occur.
        /// <paramref name="asyncWork"/> must be prepared to be called more than once.
        /// A new <see cref="SpannerTransaction"/> will be passed to <paramref name="asyncWork"/>
        /// each time it is rerun.
        /// <paramref name="asyncWork"/> doesn't need to handle the lifecycle of the <see cref="SpannerTransaction"/>,
        /// it will be automatically committed after <paramref name="asyncWork"/> has finished or rollbacked if an
        /// <see cref="Exception"/> (other than because the transaction commit aborted) is thrown by <paramref name="asyncWork"/>.</remarks>
        /// <param name="asyncWork">The work to perform in each transaction attempt.</param>
        /// <param name="transactionCreationOptions">
        /// Options for creating transactions. These options should be for a read-write transaction that
        /// is not detached. May be null in which case defaults will be used.
        /// </param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The value returned by <paramref name="asyncWork"/> if the transaction commits successfully.</returns>
        public async Task<TResult> RunWithRetriableTransactionAsync<TResult>(Func<SpannerTransaction, Task<TResult>> asyncWork, SpannerTransactionCreationOptions transactionCreationOptions, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(asyncWork, nameof(asyncWork));

            RetriableTransaction transaction = new RetriableTransaction(
                this,
                Builder.SessionPoolManager.SpannerSettings.Clock ?? SystemClock.Instance,
                Builder.SessionPoolManager.SpannerSettings.Scheduler ?? SystemScheduler.Instance,
                transactionCreationOptions,
                retryOptions: null);

            await OpenAsync(cancellationToken).ConfigureAwait(false);
            return await transaction.RunAsync(asyncWork, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes a read-write transaction, with retries as necessary.
        /// The work to perform in each transaction attempt is defined by <paramref name="asyncWork"/>.
        /// </summary>
        /// <remarks><paramref name="asyncWork"/> will be fully retried whenever the <see cref="SpannerTransaction"/>
        /// that it receives as a parameter aborts. <paramref name="asyncWork"/> won't be retried if any other errors occur.
        /// <paramref name="asyncWork"/> must be prepared to be called more than once.
        /// A new <see cref="SpannerTransaction"/> will be passed to <paramref name="asyncWork"/>
        /// each time it is rerun.
        /// <paramref name="asyncWork"/> doesn't need to handle the lifecycle of the <see cref="SpannerTransaction"/>,
        /// it will be automatically committed after <paramref name="asyncWork"/> has finished or rollbacked if an
        /// <see cref="Exception"/> (other than because the transaction commit aborted) is thrown by <paramref name="asyncWork"/>.</remarks>
        /// <param name="asyncWork">The work to perform in each transaction attempt.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The value returned by <paramref name="asyncWork"/> if the transaction commits successfully.</returns>
        public Task<TResult> RunWithRetriableTransactionAsync<TResult>(Func<SpannerTransaction, Task<TResult>> asyncWork, CancellationToken cancellationToken = default) =>
            RunWithRetriableTransactionAsync(asyncWork, transactionCreationOptions: null, cancellationToken);

        /// <summary>
        /// Executes a read-write transaction, with retries as necessary.
        /// The work to perform in each transaction attempt is defined by <paramref name="asyncWork"/>.
        /// </summary>
        /// <remarks><paramref name="asyncWork"/> will be fully retried whenever the <see cref="SpannerTransaction"/>
        /// that it receives as a parameter aborts. <paramref name="asyncWork"/> won't be retried if any other errors occur.
        /// <paramref name="asyncWork"/> must be prepared to be called more than once.
        /// A new <see cref="SpannerTransaction"/> will be passed to <paramref name="asyncWork"/>
        /// each time it is rerun.
        /// <paramref name="asyncWork"/> doesn't need to handle the lifecycle of the <see cref="SpannerTransaction"/>,
        /// it will be automatically committed after <paramref name="asyncWork"/> has finished or rollbacked if an
        /// <see cref="Exception"/> (other than because the transaction commit aborted) is thrown by <paramref name="asyncWork"/>.</remarks>
        /// <param name="asyncWork">The work to perform in each transaction attempt.</param>
        /// <param name="transactionCreationOptions">
        /// Options for creating transactions. These options should be for a read-write transaction that
        /// is not detached. May be null in which case defaults will be used.
        /// </param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task that when completed will signal that the work is done.</returns>
        public async Task RunWithRetriableTransactionAsync(Func<SpannerTransaction, Task> asyncWork, SpannerTransactionCreationOptions transactionCreationOptions, CancellationToken cancellationToken)
        {
            GaxPreconditions.CheckNotNull(asyncWork, nameof(asyncWork));
            await RunWithRetriableTransactionAsync(async transaction =>
            {
                await asyncWork(transaction).ConfigureAwait(false);
                return true;
            }, transactionCreationOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Executes a read-write transaction, with retries as necessary.
        /// The work to perform in each transaction attempt is defined by <paramref name="asyncWork"/>.
        /// </summary>
        /// <remarks><paramref name="asyncWork"/> will be fully retried whenever the <see cref="SpannerTransaction"/>
        /// that it receives as a parameter aborts. <paramref name="asyncWork"/> won't be retried if any other errors occur.
        /// <paramref name="asyncWork"/> must be prepared to be called more than once.
        /// A new <see cref="SpannerTransaction"/> will be passed to <paramref name="asyncWork"/>
        /// each time it is rerun.
        /// <paramref name="asyncWork"/> doesn't need to handle the lifecycle of the <see cref="SpannerTransaction"/>,
        /// it will be automatically committed after <paramref name="asyncWork"/> has finished or rollbacked if an
        /// <see cref="Exception"/> (other than because the transaction commit aborted) is thrown by <paramref name="asyncWork"/>.</remarks>
        /// <param name="asyncWork">The work to perform in each transaction attempt.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task that when completed will signal that the work is done.</returns>
        public Task RunWithRetriableTransactionAsync(Func<SpannerTransaction, Task> asyncWork, CancellationToken cancellationToken = default) =>
            RunWithRetriableTransactionAsync(asyncWork, transactionCreationOptions: null, cancellationToken);

        /// <summary>
        /// Executes a read-write transaction, with retries as necessary.
        /// The work to perform in each transaction attempt is defined by <paramref name="work"/>.
        /// </summary>
        /// <remarks><paramref name="work"/> will be fully retried whenever the <see cref="SpannerTransaction"/>
        /// that it receives as a parameter aborts. <paramref name="work"/> won't be retried if any other errors occur.
        /// <paramref name="work"/> must be prepared to be called more than once.
        /// A new <see cref="SpannerTransaction"/> will be passed to <paramref name="work"/>
        /// each time it is rerun.
        /// <paramref name="work"/> doesn't need to handle the lifecycle of the <see cref="SpannerTransaction"/>,
        /// it will be automatically committed after <paramref name="work"/> has finished or rollbacked if an
        /// <see cref="Exception"/> (other than because the transaction aborted) is thrown by <paramref name="work"/>.</remarks>
        /// <param name="work">The work to perform in each transaction attempt.</param>
        /// <param name="transactionCreationOptions">
        /// Options for creating transactions. These options should be for a read-write transaction that
        /// is not detached. May be null in which case defaults will be used.
        /// </param>
        /// <returns>The value returned by <paramref name="work"/> if the transaction commits successfully.</returns>
        public TResult RunWithRetriableTransaction<TResult>(Func<SpannerTransaction, TResult> work, SpannerTransactionCreationOptions transactionCreationOptions)
        {
            GaxPreconditions.CheckNotNull(work, nameof(work));
            return Task.Run(
                () => RunWithRetriableTransactionAsync(transaction => Task.FromResult(work(transaction)), transactionCreationOptions, CancellationToken.None))
            .ResultWithUnwrappedExceptions();
        }

        /// <summary>
        /// Executes a read-write transaction, with retries as necessary.
        /// The work to perform in each transaction attempt is defined by <paramref name="work"/>.
        /// </summary>
        /// <remarks><paramref name="work"/> will be fully retried whenever the <see cref="SpannerTransaction"/>
        /// that it receives as a parameter aborts. <paramref name="work"/> won't be retried if any other errors occur.
        /// <paramref name="work"/> must be prepared to be called more than once.
        /// A new <see cref="SpannerTransaction"/> will be passed to <paramref name="work"/>
        /// each time it is rerun.
        /// <paramref name="work"/> doesn't need to handle the lifecycle of the <see cref="SpannerTransaction"/>,
        /// it will be automatically committed after <paramref name="work"/> has finished or rollbacked if an
        /// <see cref="Exception"/> (other than because the transaction aborted) is thrown by <paramref name="work"/>.</remarks>
        /// <param name="work">The work to perform in each transaction attempt.</param>
        /// <returns>The value returned by <paramref name="work"/> if the transaction commits successfully.</returns>
        public TResult RunWithRetriableTransaction<TResult>(Func<SpannerTransaction, TResult> work) => RunWithRetriableTransaction(work, transactionCreationOptions: null);

        /// <summary>
        /// Executes a read-write transaction, with retries as necessary.
        /// The work to perform in each transaction attempt is defined by <paramref name="work"/>.
        /// </summary>
        /// <remarks><paramref name="work"/> will be fully retried whenever the <see cref="SpannerTransaction"/>
        /// that it receives as a parameter aborts. <paramref name="work"/> won't be retried if any other errors occur.
        /// <paramref name="work"/> must be prepared to be called more than once.
        /// A new <see cref="SpannerTransaction"/> will be passed to <paramref name="work"/>
        /// each time it is rerun.
        /// <paramref name="work"/> doesn't need to handle the lifecycle of the <see cref="SpannerTransaction"/>,
        /// it will be automatically committed after <paramref name="work"/> has finished or rollbacked if an
        /// <see cref="Exception"/> (other than because the transaction aborted) is thrown by <paramref name="work"/>.</remarks>
        /// <param name="work">The work to perform in each transaction attempt.</param>
        /// <param name="transactionCreationOptions">
        /// Options for creating transactions. These options should be for a read-write transaction that
        /// is not detached. May be null in which case defaults will be used.
        /// </param>
        public void RunWithRetriableTransaction(Action<SpannerTransaction> work, SpannerTransactionCreationOptions transactionCreationOptions)
        {
            GaxPreconditions.CheckNotNull(work, nameof(work));
            RunWithRetriableTransaction(transaction =>
            {
                work(transaction);
                return (true);
            }, transactionCreationOptions);
        }

        /// <summary>
        /// Executes a read-write transaction, with retries as necessary.
        /// The work to perform in each transaction attempt is defined by <paramref name="work"/>.
        /// </summary>
        /// <remarks><paramref name="work"/> will be fully retried whenever the <see cref="SpannerTransaction"/>
        /// that it receives as a parameter aborts. <paramref name="work"/> won't be retried if any other errors occur.
        /// <paramref name="work"/> must be prepared to be called more than once.
        /// A new <see cref="SpannerTransaction"/> will be passed to <paramref name="work"/>
        /// each time it is rerun.
        /// <paramref name="work"/> doesn't need to handle the lifecycle of the <see cref="SpannerTransaction"/>,
        /// it will be automatically committed after <paramref name="work"/> has finished or rollbacked if an
        /// <see cref="Exception"/> (other than because the transaction aborted) is thrown by <paramref name="work"/>.</remarks>
        /// <param name="work">The work to perform in each transaction attempt.</param>
        public void RunWithRetriableTransaction(Action<SpannerTransaction> work) => RunWithRetriableTransaction(work, transactionCreationOptions: null);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to read rows from a Spanner database table. The rows will be
        /// returned in the order of the primary key.
        /// This method is thread safe.
        /// </summary>
        /// <param name="databaseTable">The name of the table from which to read rows. Must not be null.</param>
        /// <param name="readOptions">The read options to use for the command. Must not be null.</param>
        /// <param name="keySet">The set of primary keys to read. Must not be null.</param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateReadCommand(
            string databaseTable,
            ReadOptions readOptions,
            KeySet keySet) => new SpannerCommand(
            SpannerCommandTextBuilder.CreateReadTextBuilder(databaseTable, readOptions),
            this, GaxPreconditions.CheckNotNull(keySet, nameof(keySet)));

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
        public SpannerCommand CreateSelectCommand(string sqlQueryStatement, SpannerParameterCollection selectParameters = null) =>
            new SpannerCommand(SpannerCommandTextBuilder.CreateSelectTextBuilder(sqlQueryStatement), this, null, selectParameters);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> from a <see cref="CommandPartition"/>.
        /// The newly created command will execute on a subset of data defined by the <see cref="CommandPartition.PartitionId"/>
        /// </summary>
        /// <param name="partition">
        /// Information that represents a command to execute against a subset of data.
        /// </param>
        /// <param name="transaction">The <see cref="SpannerTransaction"/> used when
        /// creating the <see cref="CommandPartition"/>.  See <see cref="SpannerConnection.BeginReadOnlyTransaction(TransactionId)"/>.</param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateCommandWithPartition(CommandPartition partition, SpannerTransaction transaction) =>
            new SpannerCommand(this, transaction, partition);

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
        public SpannerCommand CreateUpdateCommand(string databaseTable, SpannerParameterCollection updateColumns = null) =>
            new SpannerCommand(SpannerCommandTextBuilder.CreateUpdateTextBuilder(databaseTable), this, null, updateColumns);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to execute a DDL (CREATE/DROP TABLE, etc) statement.
        /// This method is thread safe.
        /// </summary>
        /// <param name="ddlStatement">The DDL statement (eg 'CREATE TABLE MYTABLE ...').  Must not be null.</param>
        /// <param name="extraDdlStatements">An optional set of additional DDL statements to execute after
        /// the first statement.  Extra Ddl statements cannot be used to create additional databases.</param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateDdlCommand(
            string ddlStatement, params string[] extraDdlStatements) =>
            CreateDdlCommand(ddlStatement, protobufDescriptors: null, extraDdlStatements);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to execute a DDL (CREATE/DROP TABLE, etc) statement.
        /// This method is thread safe.
        /// </summary>
        /// <param name="ddlStatement">The DDL statement (eg 'CREATE TABLE MYTABLE ...').  Must not be null.</param>
        /// <param name="protobufDescriptors">The set of protobuf descriptors that can be used to create proto bundles. May be null.</param>
        /// <param name="extraDdlStatements">An optional set of additional DDL statements to execute after
        /// the first statement.  Extra Ddl statements cannot be used to create additional databases.</param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateDdlCommand(
            string ddlStatement, FileDescriptorSet protobufDescriptors, params string[] extraDdlStatements) =>
            new SpannerCommand(SpannerCommandTextBuilder.CreateDdlTextBuilder(ddlStatement, protobufDescriptors, extraDdlStatements), this);

        /// <summary>
        /// Creates a new <see cref="SpannerCommand" /> to execute a general DML (UPDATE, INSERT, DELETE) statement.
        /// This method is thread safe.
        /// </summary>
        /// <remarks>
        /// To insert, update, delete or "insert or update" a single row, the operation-specific methods
        /// (<see cref="CreateUpdateCommand(string, SpannerParameterCollection)"/> etc) are preferred as they are more efficient.
        /// This method is more appropriate for general-purpose DML which can perform modifications based on query results.
        /// </remarks>
        /// <param name="dmlStatement">The DML statement (eg 'DELETE FROM MYTABLE WHERE ...').  Must not be null.</param>
        /// <param name="dmlParameters">
        /// Optionally supplied set of <see cref="SpannerParameter" />
        /// that correspond to the parameters used in the SQL query. May be null.
        /// </param>
        /// <returns>A configured <see cref="SpannerCommand" /></returns>
        public SpannerCommand CreateDmlCommand(string dmlStatement, SpannerParameterCollection dmlParameters = null) =>
            new SpannerCommand(SpannerCommandTextBuilder.CreateDmlTextBuilder(dmlStatement), this, null, dmlParameters);

        /// <summary>
        /// Creates a new <see cref="SpannerBatchCommand"/> to execute batched DML statements with this connection, without using a transaction.
        /// You can add commands to the batch by using <see cref="SpannerBatchCommand.Add(SpannerCommand)"/>,
        /// <see cref="SpannerBatchCommand.Add(SpannerCommandTextBuilder, SpannerParameterCollection)"/>
        /// and <see cref="SpannerBatchCommand.Add(string, SpannerParameterCollection)"/>.
        /// </summary>
        public SpannerBatchCommand CreateBatchDmlCommand() => new SpannerBatchCommand(this);

        /// <inheritdoc />
        protected override DbCommand CreateDbCommand() => new SpannerCommand(this);

        /// <summary>
        /// Returns a task indicating when the session pool associated with the connection is populated up to its minimum size.
        /// </summary>
        /// <remarks>
        /// If the pool is unhealthy or becomes unhealthy before it reaches its minimum size,
        /// the returned task will be faulted with an <see cref="RpcException"/>.
        /// </remarks>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task which will complete when the session pool has reached its minimum size.</returns>
        public async Task WhenSessionPoolReady(CancellationToken cancellationToken = default)
        {
            var sessionPoolSegmentKey = GetSessionPoolSegmentKey(nameof(WhenSessionPoolReady));
            await OpenAsync(cancellationToken).ConfigureAwait(false);
            await _sessionPool.WhenPoolReady(sessionPoolSegmentKey, cancellationToken).ConfigureAwait(false);
        }

        internal Task<PooledSession> AcquireSessionAsync(SpannerTransactionCreationOptions creationOptions, CancellationToken cancellationToken)
        {
            SessionPool pool;
            DatabaseName databaseName;
            lock (_sync)
            {
                AssertOpen("acquire session.");
                pool = _sessionPool;
                databaseName = Builder.DatabaseName;
            }
            if (databaseName is null)
            {
                throw new InvalidOperationException("Unable to acquire session on connection with no database name");
            }
            var sessionPoolSegmentKey = GetSessionPoolSegmentKey(nameof(AcquireSessionAsync));
            return creationOptions?.IsDetached == true ?
                pool.AcquireDetachedSessionAsync(sessionPoolSegmentKey, creationOptions?.GetTransactionOptions(), creationOptions?.IsSingleUse == true, cancellationToken) :
                pool.AcquireSessionAsync(sessionPoolSegmentKey, creationOptions?.GetTransactionOptions(), creationOptions?.IsSingleUse == true, cancellationToken);
        }

        /// <summary>
        /// Shuts down the session pool associated with the connection. Further attempts to acquire sessions will fail immediately.
        /// </summary>
        /// <remarks>
        /// This call will delete all pooled sessions, and wait for all active sessions to be released back to the pool
        /// and also deleted.
        /// </remarks>
        /// <param name="cancellationToken">An optional token for canceling the returned task. This does not cancel the shutdown itself.</param>
        /// <returns>A task which will complete when the session pool has finished shutting down.</returns>
        public async Task ShutdownSessionPoolAsync(CancellationToken cancellationToken = default)
        {
            var sessionPoolSegmentKey = GetSessionPoolSegmentKey(nameof(ShutdownSessionPoolAsync));
            await OpenAsync(cancellationToken).ConfigureAwait(false);
            await _sessionPool.ShutdownPoolAsync(sessionPoolSegmentKey, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves statistics for the session pool associated with the corresponding <see cref="SessionPoolSegmentKey"/>. The connection string must
        /// include a database name.
        /// </summary>
        /// <returns>The session pool statistics, or <c>null</c> if there is no current session pool
        /// associated with the <see cref="SessionPoolSegmentKey"/>.</returns>
        public SessionPool.SessionPoolSegmentStatistics GetSessionPoolSegmentStatistics()
        {
            var sessionPoolSegmentKey = GetSessionPoolSegmentKey(nameof(GetSessionPoolSegmentStatistics));
            return Builder.SessionPoolManager.GetDatabaseStatistics(new SpannerClientCreationOptions(Builder), sessionPoolSegmentKey);
        }

        private SessionPoolSegmentKey GetSessionPoolSegmentKey(string operationName)
        {
            DatabaseName databaseName = Builder.DatabaseName;
            GaxPreconditions.CheckState(databaseName != null, $"{operationName} cannot be used without a database.");
            return SessionPoolSegmentKey.Create(databaseName).WithDatabaseRole(Builder.DatabaseRole);
        }

        /// <inheritdoc />
        public override void ChangeDatabase(string newDataSource)
        {
            if (IsOpen)
            {
                Close();
            }

            TrySetNewConnectionInfo(Builder.CloneWithNewDataSource(newDataSource));
        }

        private void TrySetNewConnectionInfo(SpannerConnectionStringBuilder newBuilder)
        {
            AssertClosed("change connection information.");
            // We will never allow our internal SpannerConnectionStringBuilder to be touched from the outside, so it's cloned.
            Builder = newBuilder.Clone();
        }

        /// <inheritdoc />
        public override void Close()
        {
            SessionPool sessionPool;

            ConnectionState oldState;
            lock (_sync)
            {
                if (IsClosed)
                {
                    return;
                }

                oldState = _state;
                sessionPool = _sessionPool;

                _sessionPool = null;
                _state = ConnectionState.Closed;
            }

            if (sessionPool != null)
            {
                // Note: if we're in an implicit transaction using TransactionScope, this will "release" the session pool
                // back to the session pool manager before we're really done with it, but that's okay - it will just report
                // inaccurate connection counts temporarily. This is an inherent problem with implicit transactions.
                Builder.SessionPoolManager.Release(sessionPool);
            }

            if (oldState != _state)
            {
                OnStateChange(new StateChangeEventArgs(oldState, _state));
            }
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

        internal async Task EnsureIsOpenAsync(CancellationToken cancellationToken)
        {
            if (!IsOpen)
            {
                await OpenAsync(cancellationToken).ConfigureAwait(false);
            }

            if (!IsOpen)
            {
                throw new InvalidOperationException("Unable to open the Spanner connection to the database.");
            }
        }

        internal CallSettings CreateCallSettings(Func<SpannerSettings, CallSettings> settingsProvider, CancellationToken cancellationToken) =>
            settingsProvider(Builder.SessionPoolManager.SpannerSettings).WithCancellationToken(cancellationToken);

        internal CallSettings CreateCallSettings(Func<SpannerSettings, CallSettings> settingsProvider, int timeoutSeconds, CancellationToken cancellationToken)
        {
            var originalSettings = settingsProvider(Builder.SessionPoolManager.SpannerSettings);
            var expiration = timeoutSeconds == 0 && !Builder.AllowImmediateTimeouts ? Expiration.None : Expiration.FromTimeout(TimeSpan.FromSeconds(timeoutSeconds));
            return originalSettings.WithExpiration(expiration).WithCancellationToken(cancellationToken);
        }

        /// <inheritdoc />
        protected override void Dispose(bool disposing)
        {
            if (IsOpen)
            {
                Close();
            }
        }
    }
}
