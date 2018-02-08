// Copyright 2018 Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    internal static class ApiCallRetryExtensions
    {
        // TODO: Expose this from Google.Api.Gax.Grpc? If not, we can do some cleanup here:
        //       * move to new location (perhaps as private method where it is used),
        //       * request is not needed in `fn` callback
        //       * overall response from WithRetry not needed
        internal static Func<TRequest, CallSettings, Task<TResponse>> WithRetry<TRequest, TResponse>(
            this Func<TRequest, CallSettings, Task<TResponse>> fn,
            IClock clock,
            IScheduler scheduler,
            Func<TResponse, Task<bool>> postResponse,
            RetrySettings retrySettings = null) =>
            async (request, callSettings) =>
            {
                if (retrySettings == null)
                {
                    retrySettings = callSettings.Timing?.Retry;
                    if (retrySettings == null)
                    {
                        return await fn(request, callSettings).ConfigureAwait(false);
                    }
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
                    TimeSpan actualDelay = retrySettings.DelayJitter.GetDelay(retryDelay);
                    DateTime expectedRetryTime;
                    try
                    {
                        var response = await fn(request, attemptCallSettings).ConfigureAwait(false);
                        bool isResponseOk = false;
                        if (postResponse != null)
                        {
                            isResponseOk = await postResponse(response).ConfigureAwait(false);
                        }

                        expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                        if (isResponseOk || expectedRetryTime > overallDeadline)
                        {
                            return response;
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
            };


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

