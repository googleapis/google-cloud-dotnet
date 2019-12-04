// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
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
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data.CommonTesting
{
    /// <summary>
    /// Helper methods to provide simple retry behavior for testing purposes.
    /// This functionality may be moved to production code in the future.
    /// </summary>
    public static class RetryHelpers
    {
        // Allow up to 10 seconds each time.
        private static readonly RetrySettings s_retrySettings =
            RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue,
                initialBackoff: TimeSpan.FromMilliseconds(50),
                maxBackoff: TimeSpan.FromSeconds(1),
                backoffMultiplier: 2,
                retryFilter: ignored => false,
                RetrySettings.RandomJitter);
        private static readonly TimeSpan s_timeout = TimeSpan.FromSeconds(10);

        /// <summary>
        /// Executes a single command, retrying once if the first attempt is aborted.
        /// Only for use in "one-shot" commands (not in a transaction).
        public static Task<int> ExecuteNonQueryAsyncWithRetry(this SpannerCommand command) =>
            ExecuteWithRetryAsyncImpl(() => command.ExecuteNonQueryAsync());

        /// <summary>
        /// Executes the given action, retrying once if the first attempt is aborted.
        /// </summary>
        public static void ExecuteWithRetry(Action action) => ExecuteWithRetryImpl(() => { action(); return 0; });

        /// <summary>
        /// Executes the given asynchronous action, retrying once if the first attempt is aborted.
        /// </summary>
        public static Task ExecuteWithRetryAsync(Func<Task> action) => ExecuteWithRetryAsyncImpl(async () => { await action(); return 0; });

        private static int _calls;
        private static int _retries;

        // TODO: Move this retry code into production code, so that everyone can use it.

        private static T ExecuteWithRetryImpl<T>(Func<T> func)
        {
            Interlocked.Increment(ref _calls);

            // Make it easy to move this into production code later on by using IClock/IScheduler/IJitter
            var clock = SystemClock.Instance;
            var scheduler = SystemScheduler.Instance;

            DateTime start = DateTime.UtcNow;
            DateTime end = start + s_timeout;
            // Immediate initial retry, before the exponential delay starts.
            TimeSpan backoff = TimeSpan.Zero;
            while (true)
            {
                try
                {
                    return func();
                }
                catch (SpannerException e) when (e.IsRetryable)
                {
                    TimeSpan actualDelay = s_retrySettings.BackoffJitter.GetDelay(backoff);
                    DateTime expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                    if (expectedRetryTime > end)
                    {
                        throw;
                    }
                    scheduler.Sleep(actualDelay, CancellationToken.None);
                    backoff = s_retrySettings.NextBackoff(backoff);
                    Interlocked.Increment(ref _retries);
                }
            }
        }

        private static async Task<T> ExecuteWithRetryAsyncImpl<T>(Func<Task<T>> func)
        {
            Interlocked.Increment(ref _calls);

            // Make it easy to move this into production code later on by using IClock/IScheduler/IJitter
            var clock = SystemClock.Instance;
            var scheduler = SystemScheduler.Instance;

            DateTime start = DateTime.UtcNow;
            DateTime end = start + s_timeout;
            // Immediate initial retry, before the exponential delay starts.
            TimeSpan backoff = TimeSpan.Zero;
            while (true)
            {
                try
                {
                    return await func();
                }
                catch (SpannerException e) when (e.IsRetryable)
                {
                    TimeSpan actualDelay = s_retrySettings.BackoffJitter.GetDelay(backoff);
                    DateTime expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                    if (expectedRetryTime > end)
                    {
                        throw;
                    }
                    await scheduler.Delay(actualDelay, CancellationToken.None).ConfigureAwait(false);
                    backoff = s_retrySettings.NextBackoff(backoff);
                    Interlocked.Increment(ref _retries);
                }
            }
        }

        public static void MaybeLogStats(string description)
        {
            int calls = Interlocked.CompareExchange(ref _calls, 1, 1);
            int retries = Interlocked.CompareExchange(ref _retries, 1, 1);
            // Don't log anything if nothing interesting has happened.
            if (calls == 0 && retries == 0)
            {
                return;
            }
            Logger.DefaultLogger.Debug($"{description}: RetryHelper stats: {retries} retries out of {calls} calls");
        }

        public static void ResetStats()
        {
            Interlocked.Exchange(ref _calls, 0);
            Interlocked.Exchange(ref _retries, 0);
        }
    }
}
