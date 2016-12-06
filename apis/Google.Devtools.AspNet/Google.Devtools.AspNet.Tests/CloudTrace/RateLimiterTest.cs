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
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Devtools.AspNet.Tests
{
    public class RateLimiterTest
    {
        [Fact]
        public void CanTrace()
        {
            RateLimiter rateLimiter = TraceUtils.GetRateLimiter(1001);
            Assert.True(rateLimiter.CanTrace());
        }

        [Fact]
        public void CanTrace_False()
        {
            RateLimiter rateLimiter = TraceUtils.GetRateLimiter(999);
            Assert.False(rateLimiter.CanTrace());
        }

        [Fact]
        public void CanTrace_DecimalQps()
        {
            RateLimiter rateLimiter = TraceUtils.GetRateLimiter(0.1, new long[] { 9999, 10001 });
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
        }

        [Fact]
        public void CanTrace_Multiple()
        {
            RateLimiter rateLimiter = TraceUtils.GetRateLimiter(
                1, new long[] { 999, 1001, 1790, 1850, 2030, 2700, 5000 });
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
            Assert.False(rateLimiter.CanTrace());
            Assert.True(rateLimiter.CanTrace());
        }

        [Fact]
        public async Task CanTrace_StressTest()
        {
            CancellationTokenSource source = new CancellationTokenSource();
            try
            {
                // Create a rate limiter that allows 1 QPS
                RateLimiter rateLimiter = RateLimiter.GetInstance(1);
                int canTraceCounter = 0;
                int threads = 10;

                // Start a timer to get the total time from tasks starting to ending.
                Stopwatch timer = Stopwatch.StartNew();

                // Start 10 threads to hit the rate limiter
                Task[] tasks = new Task[threads];
                for (int i = 0; i < threads; i++)
                {
                    tasks[i] = Task.Run(async () =>
                    {
                        while (!source.IsCancellationRequested)
                        {
                            if (rateLimiter.CanTrace())
                            {
                                Interlocked.Increment(ref canTraceCounter);
                            }
                            await Task.Yield();
                        }
                    });
                }

                // Set a timeout to 2.1 seconds which should allow 2 traces unless control
                // of the tasks does not return right away.  To ensure a proper trace count
                // use the number of seconds to check the trace count.
                await Task.Delay(2100);
                var elapsedSeconds = Math.Floor(timer.Elapsed.TotalSeconds);

                // Allow for the trace count to be one lower than expected to account
                // for the elapsed time being on the second mark or close and the
                // limiter not getting a final request.
                Assert.InRange(canTraceCounter, elapsedSeconds - 1, elapsedSeconds);
            }
            finally
            {
                source.Cancel();
                source.Dispose();
            }
        }
    }
}