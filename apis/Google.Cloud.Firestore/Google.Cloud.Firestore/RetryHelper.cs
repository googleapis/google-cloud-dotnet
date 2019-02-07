// Copyright 2019, Google LLC
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

namespace Google.Cloud.Firestore
{
    /// <summary>
    /// Provides retry functionality similar to that provided by GAX.
    /// (This code is almost entirely copied from GAX. The GAX code doesn't quite work
    /// for our use case.)
    /// </summary>
    internal static class RetryHelper
    {
        internal static async Task<TResponse> Retry<TRequest, TResponse>(
            Func<TRequest, CallSettings, Task<TResponse>> fn,
            TRequest request, CallSettings callSettings, IClock clock, IScheduler scheduler)
        {
            RetrySettings retrySettings = callSettings.Timing?.Retry;
            if (retrySettings == null)
            {
                return await fn(request, callSettings).ConfigureAwait(false);
            }
            DateTime? overallDeadline = retrySettings.TotalExpiration.CalculateDeadline(clock);
            TimeSpan retryDelay = retrySettings.RetryBackoff.Delay;
            TimeSpan callTimeout = retrySettings.TimeoutBackoff.Delay;
            while (true)
            {
                DateTime attemptDeadline = clock.GetCurrentDateTimeUtc() + callTimeout;
                // Note: this handles a null total deadline due to "<" returning false if overallDeadline is null.
                DateTime combinedDeadline = overallDeadline < attemptDeadline ? overallDeadline.Value : attemptDeadline;
                CallSettings attemptCallSettings = callSettings.WithCallTiming(CallTiming.FromDeadline(combinedDeadline));
                try
                {
                    return await fn(request, attemptCallSettings).ConfigureAwait(false);
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
                    callTimeout = retrySettings.TimeoutBackoff.NextDelay(callTimeout);
                }
            }
        }
    }
}
