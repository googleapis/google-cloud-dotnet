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
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    internal static class ApiCallRetryExtensions
    {
        // TODO: This is a modified/simplified version of ApiCallRetryExtensions.WithRetry from Google.Api.Gax.Grpc. Can we combine them somehow?
        internal static async Task RetryOperationUntilCompleted(
            Func<Task<bool>> fn,
            IClock clock,
            IScheduler scheduler,
            CallSettings callSettings,
            RetrySettings retrySettings)
        {
            DateTime? overallDeadline = retrySettings.TotalExpiration.CalculateDeadline(clock);
            TimeSpan retryDelay = retrySettings.RetryBackoff.Delay;
            TimeSpan callTimeout = retrySettings.TimeoutBackoff.Delay;
            while (true)
            {
                DateTime attemptDeadline = clock.GetCurrentDateTimeUtc() + callTimeout;
                // Note: this handles a null total deadline due to "<" returning false if overallDeadline is null.
                DateTime combinedDeadline = overallDeadline < attemptDeadline ? overallDeadline.Value : attemptDeadline;
                CallSettings attemptCallSettings = callSettings.WithCallTiming(CallTiming.FromDeadline(combinedDeadline));
                TimeSpan actualDelay = retrySettings.DelayJitter.GetDelay(retryDelay);
                DateTime expectedRetryTime;
                try
                {
                    bool isResponseOk = await fn().ConfigureAwait(false);
                    if (isResponseOk)
                    {
                        return;
                    }
                    
                    expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                    if (expectedRetryTime > overallDeadline)
                    {
                        // TODO: Can we get this string from somewhere?
                        throw new RpcException(new Status(StatusCode.DeadlineExceeded, "Deadline Exceeded"));
                    }
                }
                catch (RpcException e) when (retrySettings.RetryFilter(e))
                {
                    expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                    if (expectedRetryTime > overallDeadline)
                    {
                        throw;
                    }
                }
                await scheduler.Delay(actualDelay, callSettings.CancellationToken.GetValueOrDefault()).ConfigureAwait(false);
                retryDelay = retrySettings.RetryBackoff.NextDelay(retryDelay);
                callTimeout = retrySettings.TimeoutBackoff.NextDelay(callTimeout);
            }
        }

        // TODO: Expose BackoffSettings.NextDelay so we don't need this copy if ApiCallRetryExtensions.WithRetry is not exposed.
        internal static TimeSpan NextDelay(this BackoffSettings settings, TimeSpan currentDelay)
        {
            checked
            {
                TimeSpan next = new TimeSpan((long)(currentDelay.Ticks * settings.DelayMultiplier));
                return next < settings.MaxDelay ? next : settings.MaxDelay;
            }
        }
    }
}

