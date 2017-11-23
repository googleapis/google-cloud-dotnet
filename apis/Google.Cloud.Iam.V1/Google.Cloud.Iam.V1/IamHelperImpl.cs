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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Google.Cloud.Iam.V1
{
    /// <summary>
    /// Implementation of <see cref="IamHelper"/> used by client libraries exposing APIs which include IAM.
    /// </summary>
    public sealed class IamHelperImpl : IamHelper
    {
        private readonly IClock _clock;
        private readonly IScheduler _scheduler;
        private readonly ApiCall<GetIamPolicyRequest, Policy> _getPolicyCall;
        private readonly ApiCall<SetIamPolicyRequest, Policy> _setPolicyCall;

        /// <summary>
        /// Creates an instance of this class from API calls.
        /// </summary>
        /// <param name="clock">The clock to use for retry handling. Must not be null.</param>
        /// <param name="scheduler">The scheduler to use for retry handling. Must not be null.</param>
        /// <param name="getPolicyCall">The API call for GetPolicy. Must not be null.</param>
        /// <param name="setPolicyCall">The API call for SetPolicy. Must not be null.</param>
        public IamHelperImpl(
            IClock clock,
            IScheduler scheduler,
            ApiCall<GetIamPolicyRequest, Policy> getPolicyCall,
            ApiCall<SetIamPolicyRequest, Policy> setPolicyCall)
        {
            _clock = GaxPreconditions.CheckNotNull(clock, nameof(clock));
            _scheduler = GaxPreconditions.CheckNotNull(scheduler, nameof(scheduler));
            _getPolicyCall = GaxPreconditions.CheckNotNull(getPolicyCall, nameof(getPolicyCall));
            _setPolicyCall = GaxPreconditions.CheckNotNull(setPolicyCall, nameof(setPolicyCall));
        }

        /// <inheritdoc />
        public override bool ModifyPolicy(string resource, Action<Policy> modification, CallSettings callSettings = null, RetrySettings retrySettings = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource));
            GaxPreconditions.CheckNotNull(modification, nameof(modification));

            var getRequest = new GetIamPolicyRequest { Resource = resource };
            return Retry(retrySettings, callSettings, perCallCallSettings =>
            {
                var policy = _getPolicyCall.Sync(getRequest, perCallCallSettings) ?? new Policy();
                var policyClone = policy.Clone();
                modification(policy);
                if (policy.Equals(policyClone))
                {
                    return false;
                }
                _setPolicyCall.Sync(new SetIamPolicyRequest { Resource = resource, Policy = policy }, perCallCallSettings);
                return true;
            });
        }

        /// <inheritdoc />
        public override Task<bool> ModifyPolicyAsync(string resource, Action<Policy> modification, CallSettings callSettings = null, RetrySettings retrySettings = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource));
            GaxPreconditions.CheckNotNull(modification, nameof(modification));

            var getRequest = new GetIamPolicyRequest { Resource = resource };
            return RetryAsync(retrySettings, callSettings, async perCallCallSettings =>
            {
                var policy = await _getPolicyCall.Async(getRequest, perCallCallSettings).ConfigureAwait(false) ?? new Policy();
                var policyClone = policy.Clone();
                modification(policy);
                if (policy.Equals(policyClone))
                {
                    return false;
                }
                _setPolicyCall.Sync(new SetIamPolicyRequest { Resource = resource, Policy = policy }, perCallCallSettings);
                return true;
            });
        }

        // Mostly copied from GAX
        private TResult Retry<TResult>(RetrySettings retrySettings, CallSettings callSettings, Func<CallSettings, TResult> fn)
        {
            DateTime? overallDeadline = retrySettings.TotalExpiration.CalculateDeadline(_clock);
            TimeSpan retryDelay = retrySettings.RetryBackoff.Delay;
            TimeSpan callTimeout = retrySettings.TimeoutBackoff.Delay;
            while (true)
            {
                DateTime attemptDeadline = _clock.GetCurrentDateTimeUtc() + callTimeout;
                // Note: this handles a null total deadline due to "<" returning false if overallDeadline is null.
                DateTime combinedDeadline = overallDeadline < attemptDeadline ? overallDeadline.Value : attemptDeadline;
                CallSettings attemptCallSettings = callSettings.WithCallTiming(CallTiming.FromDeadline(combinedDeadline));
                try
                {
                    return fn(attemptCallSettings);
                }
                catch (RpcException e) when (e.Status.StatusCode == StatusCode.FailedPrecondition && retrySettings.RetryFilter(e))
                {
                    TimeSpan actualDelay = retrySettings.DelayJitter.GetDelay(retryDelay);
                    DateTime expectedRetryTime = _clock.GetCurrentDateTimeUtc() + actualDelay;
                    if (expectedRetryTime > overallDeadline)
                    {
                        throw;
                    }
                    _scheduler.Sleep(actualDelay, callSettings.CancellationToken.GetValueOrDefault());
                    retryDelay = NextDelay(retrySettings.RetryBackoff, retryDelay);
                    callTimeout = NextDelay(retrySettings.TimeoutBackoff, callTimeout);
                }
            }
        }

        private async Task<TResult> RetryAsync<TResult>(RetrySettings retrySettings, CallSettings callSettings, Func<CallSettings, Task<TResult>> fn)
        {
            DateTime? overallDeadline = retrySettings.TotalExpiration.CalculateDeadline(_clock);
            TimeSpan retryDelay = retrySettings.RetryBackoff.Delay;
            TimeSpan callTimeout = retrySettings.TimeoutBackoff.Delay;
            while (true)
            {
                DateTime attemptDeadline = _clock.GetCurrentDateTimeUtc() + callTimeout;
                // Note: this handles a null total deadline due to "<" returning false if overallDeadline is null.
                DateTime combinedDeadline = overallDeadline < attemptDeadline ? overallDeadline.Value : attemptDeadline;
                CallSettings attemptCallSettings = callSettings.WithCallTiming(CallTiming.FromDeadline(combinedDeadline));
                try
                {
                    return await fn(attemptCallSettings).ConfigureAwait(false);
                }
                catch (RpcException e) when (e.Status.StatusCode == StatusCode.FailedPrecondition && retrySettings.RetryFilter(e))
                {
                    TimeSpan actualDelay = retrySettings.DelayJitter.GetDelay(retryDelay);
                    DateTime expectedRetryTime = _clock.GetCurrentDateTimeUtc() + actualDelay;
                    if (expectedRetryTime > overallDeadline)
                    {
                        throw;
                    }
                    await _scheduler.Delay(actualDelay, callSettings.CancellationToken.GetValueOrDefault()).ConfigureAwait(false);
                    retryDelay = NextDelay(retrySettings.RetryBackoff, retryDelay);
                    callTimeout = NextDelay(retrySettings.TimeoutBackoff, callTimeout);
                }
            }
        }

        // Copied from GAX
        private static TimeSpan NextDelay(BackoffSettings settings, TimeSpan currentDelay)
        {
            checked
            {
                TimeSpan next = new TimeSpan((long) (currentDelay.Ticks * settings.DelayMultiplier));
                return next < settings.MaxDelay ? next : settings.MaxDelay;
            }
        }
    }
}
