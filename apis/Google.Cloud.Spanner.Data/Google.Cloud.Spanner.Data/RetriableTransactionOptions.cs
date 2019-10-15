// Copyright 2019 Google LLC
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
using System;

namespace Google.Cloud.Spanner.Data
{
    internal sealed class RetriableTransactionOptions
    {
        private static readonly BackoffSettings s_defaultBackoff = new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(250),
            maxDelay: TimeSpan.FromSeconds(32),
            delayMultiplier: 2);
        private static readonly Expiration s_defaultOverallExpiry = Expiration.FromTimeout(TimeSpan.FromHours(1));

        internal readonly Func<TimeSpan, TimeSpan> _jitter;

        private RetriableTransactionOptions(Func<TimeSpan, TimeSpan> jitter = null) =>
            _jitter = jitter ?? MinimumBoundJitter;

        internal static RetriableTransactionOptions CreateDefault() => new RetriableTransactionOptions();

        internal static RetriableTransactionOptions CreateWithNoJitter() => new RetriableTransactionOptions(delay => delay);

        internal TimeSpan InitialDelay => s_defaultBackoff.Delay;

        internal DateTime? CalculateDeadline(IClock clock) => s_defaultOverallExpiry.CalculateDeadline(clock);

        internal TimeSpan Jitter(TimeSpan delay) => _jitter(delay);

        internal TimeSpan NextDelay(TimeSpan currentDelay) => s_defaultBackoff.NextDelay(currentDelay);

        // See http://stackoverflow.com/questions/36376888 for why we don't have a thread-local RNG.
        // We might create multiple instances of MinimumBoundJitter so this is static to make sure
        // that we'll only have a single Random instance.
        private static readonly Random s_random = new Random();
        private static readonly object s_lock = new object();
        private static TimeSpan MinimumBoundJitter(TimeSpan minDelay)
        {
            if (minDelay <= TimeSpan.Zero)
            {
                return minDelay;
            }

            double jitterMultiplier;
            lock (s_lock)
            {
                jitterMultiplier = s_random.NextDouble();
            }

            var minDelayTicks = minDelay.Ticks;
            // Always jitter in between minDelay and minDelay * 2.
            var jitter = minDelayTicks * jitterMultiplier;
            var actualDelayTicks = minDelayTicks + jitter;
            return TimeSpan.FromTicks((long)actualDelayTicks);
        }
    }
}
