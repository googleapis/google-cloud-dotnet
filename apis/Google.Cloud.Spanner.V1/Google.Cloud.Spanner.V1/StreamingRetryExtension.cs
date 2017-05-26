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
                    return await someMethod();
                }
                DateTime? overallDeadline = retrySettings.TotalExpiration.CalculateDeadline(clock);
                TimeSpan retryDelay = retrySettings.RetryBackoff.Delay;
                while (true)
                {
                    try
                    {
                        return await someMethod();
                    }
                    catch (RpcException e) when (retrySettings.RetryFilter(e))
                    {
                        TimeSpan actualDelay = retrySettings.DelayJitter.GetDelay(retryDelay);
                        DateTime expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                        if (expectedRetryTime > overallDeadline)
                        {
                            throw;
                        }
                        await scheduler.Delay(actualDelay, callSettings.CancellationToken.GetValueOrDefault());
                        retryDelay = retrySettings.RetryBackoff.NextDelay(retryDelay);
                    }
                }
            }
    }
}
