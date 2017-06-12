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
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Core;

namespace Google.Cloud.Spanner.V1
{
    internal static class StreamingRetryExtension
    {
        internal static DateTime? CalculateDeadline(this Expiration expiration, IClock clock)
        {
            GaxPreconditions.CheckNotNull(clock, nameof(clock));
            if (expiration == null)
            {
                return null;
            }
            switch (expiration.Type)
            {
                case ExpirationType.None:
                    return null;
                case ExpirationType.Timeout:
                    Debug.Assert(expiration.Timeout != null, "expiration.Timeout != null");
                    return clock.GetCurrentDateTimeUtc() + expiration.Timeout.Value;
                case ExpirationType.Deadline:
                    Debug.Assert(expiration.Deadline != null, "expiration.Deadline != null");
                    return expiration.Deadline.Value;
                default:
                    throw new ArgumentException("Invalid expiration", nameof(expiration));
            }
        }

        internal static TimeSpan NextDelay(this BackoffSettings settings, TimeSpan currentDelay)
        {
            checked
            {
                TimeSpan next = new TimeSpan((long)(currentDelay.Ticks * settings.DelayMultiplier));
                return next < settings.MaxDelay ? next : settings.MaxDelay;
            }
        }

        internal static async Task<TResponse> CallWithRetryAsync<TResponse>(
            this Func<Task<TResponse>> someMethod,
            CallSettings callSettings,
            IClock clock, IScheduler scheduler)
            {
                RetrySettings retrySettings = callSettings.Timing?.Retry;
                if (retrySettings == null)
                {
                    return await someMethod().ConfigureAwait(false);
                }
                DateTime? overallDeadline = retrySettings.TotalExpiration.CalculateDeadline(clock);
                TimeSpan retryDelay = retrySettings.RetryBackoff.Delay;
                while (true)
                {
                    try
                    {
                        return await someMethod().ConfigureAwait(false);
                    }
                    catch (RpcException e) when (retrySettings.RetryFilter(e))
                    {
                        TimeSpan actualDelay = retrySettings.DelayJitter.GetDelay(retryDelay);
                        DateTime expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                        if (expectedRetryTime > overallDeadline)
                        {
                            throw;
                        }
                        await scheduler.Delay(actualDelay, callSettings.CancellationToken.GetValueOrDefault()).ConfigureAwait(false);
                        retryDelay = retrySettings.RetryBackoff.NextDelay(retryDelay);
                    }
                }
            }
    }
}
