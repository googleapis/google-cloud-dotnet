// Copyright 2016 Google Inc. All Rights Reserved.
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
using System;
using System.Diagnostics;

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// A simple rate limiter that will allow tracing based on a given QPS.
    /// </summary>
    internal sealed class RateLimiter
    {
        // A mutex to protect the rate limiter instance.
        private static object _instanceMutex = new object();

        // The single rate limiter instance.
        private static RateLimiter _instance;

        // A mutex to handle access.
        private object _mutex = new object();

        // The amount of time that must be waited before allowing tracing.
        private readonly long _fixedDelayMillis;

        // A timer to manage time between events.
        private readonly ITimer _timer;

        // The last time tracing was allowed.
        private long _lastCallMillis;

        /// <summary>
        /// Gets the instance of the <see cref="RateLimiter"/>.  The first request will set the
        /// QPS of the rate limiter.  All subsequent request's QPS will not change the QPS of the rate limiter.
        /// </summary>
        public static RateLimiter GetInstance(double qps)
        {
            if (_instance == null)
            {
                lock (_instanceMutex)
                {
                    if (_instance == null)
                    {
                        _instance = new RateLimiter(qps, StopwatchTimer.Create());
                    }
                }
            }
            return _instance;
        }

        internal RateLimiter(double qps, ITimer timer) {
            GaxPreconditions.CheckArgument(qps > 0, nameof(qps), "qps must be greater than 0");

            _timer = timer;
            _timer.Start();

            _lastCallMillis = 0;
            _fixedDelayMillis = Convert.ToInt64(TimeSpan.FromSeconds(1 / qps).TotalMilliseconds);
        }

        /// <summary>
        /// See if tracing is allowed.
        /// </summary>
        /// <returns>True tracing is allowed.</returns>
        public bool CanTrace() {
            if (CanTrace(_timer.GetElapsedMilliseconds()))
            {
                lock (_mutex)
                {
                    long nowMillis = _timer.GetElapsedMilliseconds();
                    if (CanTrace(nowMillis))
                    {
                        _lastCallMillis = nowMillis;
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CanTrace(long nowMillis)
        {
            return nowMillis - _lastCallMillis > _fixedDelayMillis;
        }
    }
}
