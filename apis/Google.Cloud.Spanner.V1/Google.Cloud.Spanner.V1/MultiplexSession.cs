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
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

/// <summary>
/// TODO: Add summary for mux sessions
/// </summary>
public class MultiplexSession
{
    private readonly SemaphoreSlim _sessionCreateSemaphore;
    private readonly Logger _logger;
    private readonly CreateSessionRequest _createSessionRequestTemplate;

    internal Session _session;
    internal int _markedForRefresh;

    private const double ForceRefreshIntervalInDays = 28.0;
    private const double SoftRefreshIntervalInDays = 7.0;

    private readonly IClock _clock;

    /// <summary>
    /// The client used for all operations in this multiplex session.
    /// </summary>
    internal SpannerClient Client { get; }

    internal Task<Session> CreateSessionTask { get; }

    /// <summary>
    /// The name of the session. This is never null.
    /// </summary>
    public SessionName SessionName => Session.SessionName;

    /// <summary>
    /// The Spanner session resource associated to this pooled session.
    /// Won't be null.
    /// </summary>
    internal Session Session
    {
        get { return _session; }
        private set { _session = value; }
    }

    private bool MarkedForRefresh => Interlocked.CompareExchange(ref _markedForRefresh, 0, 0) == 1;

    /// <summary>
    /// The options governing this multiplex session.
    /// </summary>
    public MultiplexSessionOptions Options { get; }

    /// <summary>
    /// The database for this multiplex session
    /// </summary>
    public DatabaseName DatabaseName { get; }

    /// <summary>
    /// The database role of the multiplex session
    /// </summary>
    public string DatabaseRole { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="client"></param>
    /// <param name="dbName"></param>
    /// <param name="dbRole"></param>
    /// <param name="options"></param>
    public MultiplexSession(SpannerClient client, DatabaseName dbName, string dbRole, MultiplexSessionOptions options)
    {
        Client = GaxPreconditions.CheckNotNull(client, nameof(client));
        Options = options ?? new MultiplexSessionOptions();
        _logger = client.Settings.Logger; // Just to avoid fetching it all the time
        _sessionCreateSemaphore = new SemaphoreSlim(1);

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

    private async Task<Boolean> UpdateMuxSession(bool needsRefresh, double intervalInDays)
    {
        Session oldSession = _session;
        await CreateOrRefreshSessionsAsync(default).ConfigureAwait(false);

        return _session != oldSession;
    }

    internal void MaybeRefreshWithTimePeriodCheck()
    {
        if (SessionHasExpired(ForceRefreshIntervalInDays))
        {
            // If the session has expired on a client RPC request call, or has exceeded the 28 day Mux session refresh guidance
            // No request can proceed without us having a new Session to work with
            // Block on refreshing and getting a new session
            bool sessionIsRefreshed = UpdateMuxSession(true, ForceRefreshIntervalInDays).Result;

            if (!sessionIsRefreshed)
            {
                throw new Exception("Unable to refresh multiplex session, and the old session has expired or is 28 days past refresh");
            }

            _logger.Info($"Refreshed session since it was expired or past 28 days refresh period. New session {SessionName}");
        }

        if (SessionHasExpired(SoftRefreshIntervalInDays))
        {
            // The Mux sessions have a lifespan of 28 days. We check if we need a session refresh in every request needing the session
            // If the timespan of a request needing a session and the session creation time is greater than 7 days, we proactively refresh the mux session
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

            bool acquiredSemaphore = false;
            try
            {
                if (needsRefresh && MarkedForRefresh && !SessionHasExpired(ForceRefreshIntervalInDays))
                {
                    // If the refresh was triggered for the soft refresh timeline (7 days)
                    // Some other thread has already marked this session to be refreshed
                    // Any subsequent request threads can continue using the 'stale' session so let's not block
                    // On the other hand if the refresh is for the forced refresh timeline (28 days)
                    // Any subsequent request threads need to be blocked on the Session refresh
                    return;
                }

                await _sessionCreateSemaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
                acquiredSemaphore = true;

                if (_session == null || (needsRefresh && SessionHasExpired()))
                {
                    Interlocked.Exchange(ref _markedForRefresh, 1);
                    multiplexSession = await Client.CreateSessionAsync(_createSessionRequestTemplate, callSettings).ConfigureAwait(false);

                    Interlocked.Exchange(ref _session, multiplexSession);
                    Interlocked.Exchange(ref _markedForRefresh, 0);
                }
            }
            catch (OperationCanceledException)
            {
                _logger.Warn(() => $"Creation request cancelled before we could procure a Multiplex Session for DatabaseName: {DatabaseName}, DatabaseRole: {DatabaseRole}");
                throw;
            }
            finally
            {
                if (acquiredSemaphore)
                {
                    _sessionCreateSemaphore.Release();
                }
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
    public sealed partial class MultiplexSessionBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        public MultiplexSessionBuilder(DatabaseName databaseName, SpannerClient client)
        {
            DatabaseName = GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            Client = GaxPreconditions.CheckNotNull(client, nameof(client));
        }

        /// <summary>
        /// The options governing this multiplex session.
        /// </summary>
        public MultiplexSessionOptions Options { get; set; }

        /// <summary>
        /// The database for this multiplex session
        /// </summary>
        public DatabaseName DatabaseName { get; set; }

        /// <summary>
        /// The database role of the multiplex session
        /// </summary>
        public string DatabaseRole { get; set; }

        /// <summary>
        /// The client used for all operations in this multiplex session.
        /// </summary>
        public SpannerClient Client { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<MultiplexSession> BuildAsync(CancellationToken cancellationToken = default)
        {
            MultiplexSession multiplexSession = new MultiplexSession(Client, DatabaseName, DatabaseRole, Options);

            await multiplexSession.CreateOrRefreshSessionsAsync(cancellationToken).ConfigureAwait(false);

            return multiplexSession;
        }
    }
}
