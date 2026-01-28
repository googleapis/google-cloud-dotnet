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
/// This class helps manage Spanner multiplex session creation and lifecycle.
/// A <see cref="ManagedSession"/> should only be created through a <see cref="SessionBuilder"/>.
/// It provides factory methods to create <see cref="ManagedTransaction"/> which will be created using the current underlying session in this ManagedSession.
/// A check to see if the underlying session needs to be refreshed or created will be done everytime a method to create a ManagedTransaction is called.
/// The class will do a soft, non-blocking refresh if the underlying session is greater than 7 days but less than 28 days old from its creation.
/// A hard, blocking refresh is done if the session is greater than 28 days old from its creation. 
/// </summary>
public class ManagedSession
{
    private const double HardRefreshIntervalInDays = 28.0;
    private const double SoftRefreshIntervalInDays = 7.0;

    private readonly Logger _logger;
    private readonly CreateSessionRequest _createSessionRequestTemplate;
    private Task _sessionCreationTask;
    private readonly object _sessionCreationTaskLock = new object();

    private Session _session;

    private readonly IClock _clock;

    /// <summary>
    /// The client used for all operations in this managed session.
    /// </summary>
    internal SpannerClient Client { get; }

    /// <summary>
    /// The name of the session. This is never null.
    /// </summary>
    internal SessionName SessionName => Session.SessionName;

    /// <summary>
    /// The Spanner session resource associated to this ManagedSession.
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
    internal ManagedSession(SpannerClient client, DatabaseName dbName, string dbRole, ManagedSessionOptions options)
    {
        GaxPreconditions.CheckNotNull(dbName, nameof(dbName));
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
    public async Task<ManagedTransaction> CreateManagedTransaction(TransactionOptions transactionOptions, bool singleUseTransaction, CancellationToken cancellationToken = default)
    {
        await CreateOrRefreshSessionsAsync(cancellationToken).ConfigureAwait(false);
        return new ManagedTransaction(this, transactionId: null, transactionOptions, singleUseTransaction, readTimestamp: null);
    }

    /// <summary>
    /// Returns a ManagedTransaction for the same ManagedSession as this one with the given transaction related values.
    /// </summary>
    public async Task<ManagedTransaction> CreateManagedTransaction(ByteString transactionId, TransactionOptions transactionOptions, bool singleUseTransaction, Timestamp readTimestamp = null, CancellationToken cancellationToken = default)
    {
        GaxPreconditions.CheckNotNull(transactionId, nameof(transactionId));
        await CreateOrRefreshSessionsAsync(cancellationToken).ConfigureAwait(false);
        return new ManagedTransaction(this, transactionId, transactionOptions, singleUseTransaction, readTimestamp);
    }

    /// <summary>
    /// Returns a ManagedTransaction for the same ManagedSession as this one with the given transaction mode.
    /// </summary>
    public async Task<ManagedTransaction> CreateManagedTransaction(ByteString transactionId, ModeOneofCase transactionMode, Timestamp readTimestamp = null)
    {
        TransactionOptions BuildTransactionOptions() => transactionMode switch
        {
            ModeOneofCase.None => new TransactionOptions(),
            ModeOneofCase.PartitionedDml => new TransactionOptions { PartitionedDml = new() },
            ModeOneofCase.ReadWrite => new TransactionOptions { ReadWrite = new() },
            ModeOneofCase.ReadOnly => new TransactionOptions() { ReadOnly = new() },
            _ => throw new ArgumentException(nameof(transactionMode), $"Unknown {typeof(ModeOneofCase).FullName}: {transactionMode}")
        };

        return await CreateManagedTransaction(transactionId, BuildTransactionOptions(), false, readTimestamp).ConfigureAwait(false);
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

                // Hard refresh or initial session creation,
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
                                        multiplexSession = await Client.CreateSessionAsync(_createSessionRequestTemplate, callSettings)
                                                                       .WithCancellationToken(cancellationToken).ConfigureAwait(false);

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
    /// Builder to build a <see cref="ManagedSession"/>
    /// </summary>
    public sealed partial class SessionBuilder
    {
        /// <summary>
        /// Constructor with validations on essential parameters needed to build the ManagedSession
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
        /// The <see cref="DatabaseName"/> for this managed session.
        /// This is a required field and will be used when creating the underlying Spanner session.
        /// </summary>
        public DatabaseName DatabaseName { get; set; }

        /// <summary>
        /// The database role of the managed session. This will be used when creating the underlying Spanner session.
        /// </summary>
        public string DatabaseRole { get; set; }

        /// <summary>
        /// The client used for all operations in this managed session.
        /// </summary>
        public SpannerClient Client { get; set; }

        /// <summary>
        /// Async method to build a managed session. This will fetch a valid session from backend Spanner and wrap it inside the managed session object.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to cancel this call</param>
        /// <returns></returns>
        public async Task<ManagedSession> BuildAsync(CancellationToken cancellationToken = default)
        {
            ManagedSession managedSession = new ManagedSession(Client, DatabaseName, DatabaseRole, Options);
            await managedSession.CreateOrRefreshSessionsAsync(cancellationToken).ConfigureAwait(false);

            return managedSession;
        }
    }
}
