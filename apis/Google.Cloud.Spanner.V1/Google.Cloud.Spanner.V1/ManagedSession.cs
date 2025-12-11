// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.V1.Internal;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// TODO: Add summary for mux sessions
/// </summary>
public class ManagedSession
{
    private readonly Logger _logger;
    private readonly CreateSessionRequest _createSessionRequestTemplate;
    private Task _sessionCreationTask;
    private readonly object _sessionCreationTaskLock = new object();

    internal Session _session;

    private const double HardRefreshIntervalInDays = 28.0;
    private const double SoftRefreshIntervalInDays = 7.0;

    private readonly IClock _clock;

    /// <summary>
    /// The client used for all operations in this managed session.
    /// </summary>
    internal SpannerClient Client { get; }

    internal Task<Session> CreateSessionTask { get; }

    /// <summary>
    /// The name of the session. This is never null.
    /// </summary>
    internal SessionName SessionName => Session.SessionName;

    /// <summary>
    /// The Spanner session resource associated to this pooled session.
    /// Won't be null.
    /// </summary>
    internal Session Session
    {
        get { return _session; }
        set { _session = value; }
    }

    /// <summary>
    /// The options governing this managed session.
    /// </summary>
    public ManagedSessionOptions Options { get; }

    /// <summary>
    /// The database for this managed session
    /// </summary>
    public DatabaseName DatabaseName { get; }

    /// <summary>
    /// The database role of the managed session
    /// </summary>
    public string DatabaseRole { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="client"></param>
    /// <param name="dbName"></param>
    /// <param name="dbRole"></param>
    /// <param name="options"></param>
    public ManagedSession(SpannerClient client, DatabaseName dbName, string dbRole, ManagedSessionOptions options)
    {
        Client = GaxPreconditions.CheckNotNull(client, nameof(client));
        Options = options ?? new ManagedSessionOptions();
        _logger = client.Settings.Logger; // Just to avoid fetching it all the time

        DatabaseName = dbName;
        DatabaseRole = dbRole;

        _clock = client.Settings.Clock ?? SystemClock.Instance;

        _createSessionRequestTemplate = new CreateSessionRequest
        {
            DatabaseAsDatabaseName = DatabaseName,
            Session = new Session
            {
                CreatorRole = DatabaseRole ?? "",
                Multiplexed = true
            }
        };
    }

    /// <summary>
    /// Returns a ManagedTransaction for the same ManagedSession as this with the given <paramref name="transactionOptions"/>.
    /// </summary>
    public async Task<ManagedTransaction> CreateManagedTransactionWithOptions(TransactionOptions transactionOptions, bool singleUseTransaction)
    {
        await MaybeRefreshWithTimePeriodCheck().ConfigureAwait(false);
        return new ManagedTransaction(this, transactionId: null, transactionOptions, singleUseTransaction, readTimestamp: null);
    }

    /// <summary>
    /// Returns a ManagedTransaction for the same ManagedSession as this one with the given transaction related values.
    /// </summary>
    public async Task<ManagedTransaction> CreateManagedTransactionWithSpannerTransaction(ByteString transactionId, TransactionOptions transactionOptions, bool singleUseTransaction, Timestamp readTimestamp = null)
    {
        GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId));
        await MaybeRefreshWithTimePeriodCheck().ConfigureAwait(false);
        return new ManagedTransaction(this, transactionId, transactionOptions, singleUseTransaction, readTimestamp);
    }

    /// <summary>
    /// Returns a ManagedTransaction for the same ManagedSession as this one with the given transaction mode.
    /// </summary>
    public async Task<ManagedTransaction> CreateManagedTransactionWithMode(ByteString transactionId, ModeOneofCase transactionMode, Timestamp readTimestamp = null)
    {
        TransactionOptions BuildTransactionOptions() => transactionMode switch
        {
            ModeOneofCase.None => new TransactionOptions(),
            ModeOneofCase.PartitionedDml => new TransactionOptions { PartitionedDml = new() },
            ModeOneofCase.ReadWrite => new TransactionOptions { ReadWrite = new() },
            ModeOneofCase.ReadOnly => new TransactionOptions() { ReadOnly = new() },
            _ => throw new ArgumentException(nameof(transactionMode), $"Unknown {typeof(ModeOneofCase).FullName}: {transactionMode}")
        };

        return await CreateManagedTransactionWithSpannerTransaction(transactionId, BuildTransactionOptions(), false, readTimestamp).ConfigureAwait(false);
    }

    private async Task<bool> UpdateMuxSession(bool needsRefresh, double intervalInDays)
    {
        Session oldSession = _session;
        await CreateOrRefreshSessionsAsync(default).ConfigureAwait(false);

        return _session != oldSession;
    }

    internal async Task MaybeRefreshWithTimePeriodCheck()
    {
        if (SessionHasExpired(HardRefreshIntervalInDays))
        {
            // If the session has expired on a client RPC request call, or has exceeded the 28 day Mux session refresh guidance
            // No request can proceed without us having a new Session to work with
            // Block on refreshing and getting a new session
            bool sessionIsRefreshed = await UpdateMuxSession(true, HardRefreshIntervalInDays).ConfigureAwait(false);

            if (!sessionIsRefreshed)
            {
                throw new Exception("Unable to refresh multiplex session, and the old session has expired or is 28 days past refresh");
            }

            _logger.Info($"Refreshed session since it was expired or past 28 days refresh period. New session {SessionName}");
        }

        if (SessionHasExpired(SoftRefreshIntervalInDays))
        {
            // The Mux sessions have a lifespan of 28 days. We check if we need a session refresh in every request needing the session
            // If the timespan between a request needing a session and the session creation time is greater than 7 days, we proactively refresh the mux session
            // The request can safely use the older session since it is still valid while we do this refresh to fetch the new session.
            // Hence fire and forget the session refresh.
            _ = Task.Run(() => UpdateMuxSession(true, SoftRefreshIntervalInDays));
        }
    }

    // internal for testing
    internal bool SessionHasExpired(double intervalInDays = SoftRefreshIntervalInDays)
    {
        DateTime currentTime = _clock.GetCurrentDateTimeUtc();
        DateTime? sessionCreateTime = _session?.CreateTime.ToDateTime(); // Inherent conversion into UTC DateTime
        if (_session == null || _session.Expired || currentTime - sessionCreateTime >= TimeSpan.FromDays(intervalInDays))
        {
            return true;
        }

        return false;
    }

    private async Task CreateOrRefreshSessionsAsync(CancellationToken cancellationToken, bool needsRefresh = false)
    {
        try
        {
            var callSettings = Client.Settings.CreateSessionSettings
                .WithExpiration(Expiration.FromTimeout(Options.Timeout))
                .WithCancellationToken(cancellationToken);

            Session multiplexSession;

            try
            {
                // Non-blocking, fast check if the session is still "fresh" enough
                if (_session != null && !SessionHasExpired(HardRefreshIntervalInDays))
                {
                    // Check for soft refresh need *without* blocking or creating a new task yet.
                    if (SessionHasExpired(SoftRefreshIntervalInDays))
                    {
                        _ = TriggerRefresh(SoftRefreshIntervalInDays);
                    }

                    // Either way, the current session is safe to use. Return immediately.
                    return;
                }

                // Hard refresh or initial session creation
                Task currentCreationTask = TriggerRefresh(HardRefreshIntervalInDays);

                // 2b. Block the current caller on the task (Hard Refresh requirement)
                // If we initiated the task, we are waiting for our own task.
                // If another thread initiated it, we are waiting for their task.
                await currentCreationTask.ConfigureAwait(false);

                Task TriggerRefresh(double refreshInterval)
                {
                    // We only need to check if a task is running to avoid running two at once.
                    if (_sessionCreationTask != null)
                    {
                        // A refresh is already running (either soft or hard). Do nothing and use the existing session creation task.
                        return _sessionCreationTask;
                    }

                    // Acquire the lock to safely initialize the task
                    lock (_sessionCreationTaskLock)
                    {
                        if (_sessionCreationTask is null)
                        {
                            _sessionCreationTask = Task.Run(async () =>
                            {
                                try
                                {
                                    if (SessionHasExpired(refreshInterval))
                                    {
                                        // Create/Refresh the session only if it is null or it is older than the refreshInterval
                                        multiplexSession = await Client.CreateSessionAsync(_createSessionRequestTemplate, callSettings).ConfigureAwait(false);
                                        Interlocked.Exchange(ref _session, multiplexSession);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // Log the exception. Soft refresh failures should generally not crash the main thread.
                                    _logger.Warn($"Exception while trying to refresh session for interval {refreshInterval}. {ex}");
                                    if (refreshInterval == HardRefreshIntervalInDays)
                                    {
                                        // Very likely we cannot continue without getting a fresh session in this case.
                                        throw;
                                    }
                                }
                                finally
                                {
                                    // Clear the task after completion (success or failure)
                                    // to allow the next refresh to run.
                                    _ = Interlocked.Exchange(ref _sessionCreationTask, null);
                                }
                            });
                        }
                    }

                    return _sessionCreationTask;
                }
            }
            catch (OperationCanceledException)
            {
                _logger.Warn(() => $"Creation request cancelled before we could procure a Multiplex Session for DatabaseName: {DatabaseName}, DatabaseRole: {DatabaseRole}");
                throw;
            }
        }
        catch (Exception e)
        {
            _logger.Warn(() => $"Failed to create multiplex session for DatabaseName: {DatabaseName}, DatabaseRole: {DatabaseRole}", e);
            throw;
        }
        finally
        {
            // Nothing to do here since for legacy SessionPool we had to have some logging for when the pool went from healthy to unhealthy.
            // This could mean n number of things went wrong in the pool
            // But with the MUX session, we essentially only have 1 session we need to manage per client.
            // So there is no case of the mux session going back and forth in terms of its healthiness.
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        public SessionBuilder(DatabaseName databaseName, SpannerClient client)
        {
            DatabaseName = GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            Client = GaxPreconditions.CheckNotNull(client, nameof(client));
        }

        /// <summary>
        /// The options governing this managed session.
        /// </summary>
        public ManagedSessionOptions Options { get; set; }

        /// <summary>
        /// The database for this managed session
        /// </summary>
        public DatabaseName DatabaseName { get; set; }

        /// <summary>
        /// The database role of the managed session
        /// </summary>
        public string DatabaseRole { get; set; }

        /// <summary>
        /// The client used for all operations in this managed session.
        /// </summary>
        public SpannerClient Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ManagedSession> BuildAsync(CancellationToken cancellationToken = default)
        {
            ManagedSession managedSession = new ManagedSession(Client, DatabaseName, DatabaseRole, Options);
            await managedSession.CreateOrRefreshSessionsAsync(cancellationToken).ConfigureAwait(false);

            return managedSession;
        }
    }
}
