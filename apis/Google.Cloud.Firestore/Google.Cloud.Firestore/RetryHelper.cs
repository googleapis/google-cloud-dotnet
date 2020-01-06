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
            RetrySettings retrySettings = callSettings.Retry;
            if (retrySettings == null)
            {
                return await fn(request, callSettings).ConfigureAwait(false);
            }
            DateTime? overallDeadline = callSettings.Expiration.CalculateDeadline(clock);
            // Every attempt should use the same deadline, calculated from the start of the call.
            if (callSettings.Expiration?.Type == ExpirationType.Timeout)
            {
                callSettings = callSettings.WithDeadline(overallDeadline.Value);
            }
            // Remove retry from the call settings we pass into the function, so that the settings
            // can be used even for a streaming call.
            callSettings = callSettings.WithRetry(null);

            TimeSpan backoffDelay = retrySettings.InitialBackoff;
            int attempt = 0;
            while (true)
            {
                try
                {
                    attempt++;
                    var response = await fn(request, callSettings).ConfigureAwait(false);
                    return response;
                }
                catch (RpcException e) when (attempt < retrySettings.MaxAttempts && retrySettings.RetryFilter(e))
                {
                    TimeSpan actualDelay = retrySettings.BackoffJitter.GetDelay(backoffDelay);
                    DateTime expectedRetryTime = clock.GetCurrentDateTimeUtc() + actualDelay;
                    if (expectedRetryTime > overallDeadline)
                    {
                        throw;
                    }
                    await scheduler.Delay(actualDelay, callSettings.CancellationToken.GetValueOrDefault()).ConfigureAwait(false);
                    backoffDelay = retrySettings.NextBackoff(backoffDelay);
                }
            }
        }
    }
}
