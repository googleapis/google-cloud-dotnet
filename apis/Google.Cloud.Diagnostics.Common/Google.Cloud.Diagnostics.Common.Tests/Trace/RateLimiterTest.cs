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

using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class RateLimiterTest
    {
        [Fact]
        public void CanTrace()
        {
            var rateLimiter = TraceUtils.GetRateLimiter(1001);
            Assert.True(rateLimiter.CanTrace()); // t=0ms
            Assert.True(rateLimiter.CanTrace()); // t=1001ms
            Assert.True(rateLimiter.CanTrace()); // t=2002ms
        }

        [Fact]
        public void CanTrace_False()
        {
            var rateLimiter = TraceUtils.GetRateLimiter(999);
            Assert.True(rateLimiter.CanTrace());  // t=0ms
            Assert.False(rateLimiter.CanTrace()); // t=999ms
            Assert.True(rateLimiter.CanTrace());  // t=1998ms
        }

        [Fact]
        public void CanTrace_DecimalQps()
        {
            var rateLimiter = TraceUtils.GetRateLimiter(0.1, new long[] { 9999, 10001 });
            Assert.True(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
        }

        [Fact]
        public void CanTrace_Multiple()
        {
            var rateLimiter = TraceUtils.GetRateLimiter(
                1, new long[] { 999, 1001, 1790, 1850, 2030, 2700, 5000 });
            Assert.True(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
        }

        [Fact]
        public void CanTrace_StressTest()
        {
            // Create a rate limiter that allows .5 QPS
            var rateLimiter = new RateLimiter(.5, StopwatchTimer.Create());
            int canTraceCounter = 0;
            DateTime start = DateTime.UtcNow;
            DateTime end = start.AddSeconds(5.5);
            // Create 10 threads to run for a little over two seconds.
            var threads = Enumerable.Range(0, 10)
                .Select(_ => new Thread(() =>
                {
                    while (DateTime.UtcNow < end)
                    {
                        if (rateLimiter.CanTrace())
                        {
                            Interlocked.Increment(ref canTraceCounter);
                        }
                    }
                }))
                .ToList();

            // Start the threads and wait for them all to finish
            threads.ForEach(t => t.Start());
            threads.ForEach(t => t.Join());

            // We should have exactly 3 traces: one at t~=0, one at t~=2, one at t~=4.
            // (The test machine would have to be very highly loaded to take half a second between
            // the check in the while loop and the increment leading to an over-count, and it would have
            // to take half a second to start the threads to lead to an under-count.)
            Assert.Equal(3, canTraceCounter);
        }
    }
}