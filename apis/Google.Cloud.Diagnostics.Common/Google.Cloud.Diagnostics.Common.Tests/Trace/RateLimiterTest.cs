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

using System;
using System.Linq;
using System.Threading;
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
            // Create 10 threads to run for a little over five seconds.
            var threads = Enumerable.Range(0, 10)
                .Select(_ => new Thread(() =>
                {
                    while (DateTime.UtcNow < end)
                    {
                        // Avoid completely tight-looping, so that we can actually start enough threads.
                        // (Note that Thread.Yield isn't available on .NET Core.)
                        Thread.Sleep(1);
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

        [Fact]
        public void CanTrace_Always_StressTest()
        {

            // Create a rate limiter that allows 1_000_000 QPS, which effectively means can trace always.
            var rateLimiter = new RateLimiter(1_000_000, StopwatchTimer.Create());
            int canTraceCounter = 0;
            int canTraceQuestions = 0;
            DateTime start = DateTime.UtcNow;
            DateTime end = start.AddSeconds(5.5);
            // Create 10 threads to run for a little over five seconds.
            var threads = Enumerable.Range(0, 10)
                .Select(_ => new Thread(() =>
                {
                    while (DateTime.UtcNow < end)
                    {
                        // Avoid completely tight-looping, so that we can actually start enough threads.
                        // (Note that Thread.Yield isn't available on .NET Core.)
                        Thread.Sleep(1);
                        Interlocked.Increment(ref canTraceQuestions);
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

            // Since everything is to be traced, we should have as many traces as we attempted.
            Assert.Equal(canTraceQuestions, canTraceCounter);
        }

        [Fact]
        public void CanTrace_1000Qps_StressTest()
        {
            // Mocking the stopwatch.
            long[] elapsedMilliseconds = new long[1953];
            FillElapsedMilliseconds(0, 300, 1); // 300 requests on mill 1.
            FillElapsedMilliseconds(300, 800, 2); // 500 requests on mill 2.
            FillElapsedMilliseconds(800, 802, 3); // 2 requests on mill 3.
            FillElapsedMilliseconds(802, 1802, 4); // 1000 requests on mill 4.
            FillElapsedMilliseconds(1802, 1952, 6); // No requests on mill 5 and 150 requests on mill 6.
            FillElapsedMilliseconds(1952, 1953, 7); // 1 request in mill 7
            // We should have 6 traces since we need to trace one for every millisecond in which we received traces.

            void FillElapsedMilliseconds(int from, int to, long value)
            {
                for (int i = from; i < to; i++)
                {
                    elapsedMilliseconds[i] = value;
                }
            }

            // Create a rate limiter that allows 1_000 QPS, which effectively means we should have one trace per millisecond.
            // Mock the stopwatch to simulate the calls per millisecond as defined above.
            var rateLimiter = TraceUtils.GetRateLimiter(1_000, elapsedMilliseconds);
            int canTraceQuestions = 0;
            int canTraceCounter = 0;
            // Create 10 threads to run while we haven't reached the 1953 requests.
            var threads = Enumerable.Range(0, 10)
                .Select(_ => new Thread(() =>
                {
                    while (Interlocked.Increment(ref canTraceQuestions) <= 1953)
                    {
                        // Avoid completely tight-looping, so that we can actually start enough threads.
                        // (Note that Thread.Yield isn't available on .NET Core.)
                        Thread.Sleep(1);
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

            // We should have one trace per every millisecond that we attempted to trace.
            Assert.Equal(6, canTraceCounter);
        }
    }
}