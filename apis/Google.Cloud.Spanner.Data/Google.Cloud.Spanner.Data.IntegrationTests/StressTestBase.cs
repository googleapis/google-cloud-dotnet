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

using Google.Cloud.ClientTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    public abstract class StressTestBase
    {
        protected const int TargetQps = 100;
        protected static readonly TimeSpan TestDuration = TimeSpan.FromSeconds(60);

        /// <summary>
        /// These perf statistics are gathered when LogPerformanceTraces = true.
        /// Important statistics here are:
        ///  SpannerTransaction.Commit.Duration: The duration to call spanner server for a commit transaction.
        ///  Transaction.Begin.Duration: The duration to call spanner to begin a transaction.  This value + commit duration should be greater than measured latency
        ///    if our transaction prewarming is working properly.
        ///  Session.CreateTime: The duration to call spanner server for a new session.  This should mostly be done at
        ///    prewarm.  If "Recordings" is more than .25 * TargetQps, then it means additional sessions had to be allocated and the server probably
        ///    started falling behind the target Qps.
        ///  SpannerClient.RawCreateCount: You are looking at "recordings" here to ensure that only `MaximumGrpcChannels` are created.
        ///  Transaction.CacheHit: How many hits we got on prewarmed transactions.
        ///  Right now the return value is the average latency. TODO(benwu):switch to 90th percentile latency.
        /// </summary>
        protected async Task<double> TestLatencyWithQps(double queriesPerSecond, TimeSpan testTime, Func<Task> func)
        {
            var sw = Stopwatch.StartNew();
            var all = new List<Task<TimeSpan>>();

            while (sw.Elapsed < testTime)
            {
                if (sw.Elapsed.TotalSeconds * queriesPerSecond > all.Count)
                {
                    all.Add(TimeIteration(func));
                }
            }

            var timeout = Task.Delay(TimeSpan.FromSeconds(10));
            var completedTask = await Task.WhenAny(Task.WhenAll(all), timeout);
            var completed = all.Where(x => x.IsCompleted).ToList();
            var sum = completed.Sum(x => x.Result.TotalMilliseconds);
            var result = sum / completed.Count;
            FileLogger.LogWithCallerMember($"Elapsed ms: {sw.ElapsedMilliseconds}; Completed tasks: {completed.Count}/{all.Count}; Average latency: {result}");
            if (completedTask == timeout)
            {
                FileLogger.LogWithCallerMember("FAILED!");
                return -1;
            }
            return result;

            async Task<TimeSpan> TimeIteration(Func<Task> localFunc)
            {
                await Task.Yield(); // We immediately yield to allow the spawning thread to continue.
                Stopwatch iterationStopwatch = Stopwatch.StartNew();
                await localFunc().ConfigureAwait(false);
                return iterationStopwatch.Elapsed;
            }
        }
    }
}
