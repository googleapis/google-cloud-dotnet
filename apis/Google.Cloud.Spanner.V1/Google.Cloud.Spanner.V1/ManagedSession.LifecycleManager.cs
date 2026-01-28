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
using Google.Cloud.Spanner.V1.Internal;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;
public sealed partial class ManagedSession
{
    private sealed class LifecycleManager
    {
        // Absolute hard expiry is at 28 days, but let's make sure every session we give out has at least
        // 12 hours of life left.
        private static readonly TimeSpan s_hardExpiry = TimeSpan.FromDays(27) + TimeSpan.FromHours(12);
        private static readonly TimeSpan s_softExpiry = TimeSpan.FromDays(7);

        private readonly SpannerClient _client;
        private readonly CreateSessionRequest _createSessionRequestTemplate;
        private readonly CallSettings _createSessionSettings;

        private readonly IClock _clock;

        private readonly object _sessionCreationTaskLock = new object();
        private Task<Session> _sessionCreationTask;
        private Session _session;

        internal LifecycleManager(ManagedSessionOptions options)
        {
            GaxPreconditions.CheckNotNull(options, nameof(options));

            _client = options.Client;
            _clock = _client.Settings.Clock ?? SystemClock.Instance;
            _createSessionRequestTemplate = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = options.DatabaseName,
                Session = new Session
                {
                    Multiplexed = true
                }
            };
            if (options.DatabaseRole is not null)
            {
                _createSessionRequestTemplate.Session.CreatorRole = options.DatabaseRole;
            }
            _createSessionSettings = _client.Settings.CreateSessionSettings
                .WithExpiration(Expiration.FromTimeout(options.EffectiveTimeout));
        }

        internal async Task<Session> GetFreshSessionAsync(CancellationToken cancellationToken)
        {
            Task<Session> sessionCreationTask;

            var utcNow = _clock.GetCurrentDateTimeUtc();
            var softExpiryCreationTime = utcNow - s_softExpiry;
            var hardExpiryCreationTime = utcNow - s_hardExpiry;

            lock (_sessionCreationTaskLock)
            {
                var sessionCreateTime = _session?.CreateTime.ToDateTimeOffset() ?? DateTimeOffset.MinValue;
                bool isHardExpired = sessionCreateTime <= hardExpiryCreationTime;
                bool isSoftExpired = isHardExpired || sessionCreateTime <= softExpiryCreationTime;

                // If the session is at least soft-expired, and we haven't started refreshing it,
                // let's do so
                if (isSoftExpired && _sessionCreationTask is null)
                {
                    _sessionCreationTask = Task.Run(CreateNewSessionAsync);

                    // Let's make sure that exceptions in _sessionCreationTask are always observed.
                    // Note that we don't keep a reference to this new task as we don't really
                    // care about the errors, and we want calling code explicitly awaiting on _sessionCreationTask
                    // to actually fail if there's an error. We just schedule it to run and that's enough for
                    // avoiding exception observavility issues.
                    _ = _sessionCreationTask.ContinueWith(async t =>
                    {
                        try
                        {
                            await t.ConfigureAwait(false);
                        }
                        catch (Exception ex)
                        {
                            _client.Settings.Logger.Warn("An error occured on a background session creation task", ex);
                        }
                    }, TaskContinuationOptions.OnlyOnFaulted);
                }

                // Now we know we have triggered a session refresh if it was needed.
                // If the session is not hard-expired, we can return the current session.
                if (!isHardExpired)
                {
                    return _session;
                }

                // If we are here the session has hard-expired, we need to wait on the refresh to finish.
                // Let's get a local reference to the refresh task that we'll be using outside the lock.
                sessionCreationTask = _sessionCreationTask;
            }

            // Note we use the cancellation token received to await on the session refresh,
            // but not on the refresh itself.
            return await sessionCreationTask.WithCancellationToken(cancellationToken).ConfigureAwait(false);
        }

        private async Task<Session> CreateNewSessionAsync()
        {
            try
            {
                var sessionRequest = _createSessionRequestTemplate.Clone();
                var session = await _client.CreateSessionAsync(sessionRequest, _createSessionSettings)
                    .ConfigureAwait(false);
                lock (_sessionCreationTaskLock)
                {
                    _session = session;
                    _sessionCreationTask = null;
                }
                return session;
            }
            catch
            {
                lock(_sessionCreationTaskLock)
                {
                    _sessionCreationTask = null;
                }
                throw;
            }
        }
    }
}
