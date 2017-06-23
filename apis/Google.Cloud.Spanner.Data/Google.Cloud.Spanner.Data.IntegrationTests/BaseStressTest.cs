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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Spanner.V1;
using Google.Cloud.Spanner.V1.Logging;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    public abstract class BaseStressTest
    {
        protected const int TargetQps = 100;
        protected static readonly TimeSpan TestDurationMs = TimeSpan.FromSeconds(60);

        protected abstract Task<TimeSpan> TestWrite1(Stopwatch sw);

        private async Task<TimeSpan> TestWrite(Stopwatch sw)
        {
            await Task.Yield(); //We immediately yield to allow the spawning thread to continue.
            return await TestWrite1(sw);
        }


        private async Task Timeout(TimeSpan testTime)
        {
            await Task.Delay(testTime.Add(TimeSpan.FromSeconds(10)));
        }

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
        /// </summary>
        protected async Task<double> TestWriteLatencyWithQps(double queriesPerSecond, TimeSpan milliTestTime)
        {
            var sw = Stopwatch.StartNew();
            var all = new List<Task<TimeSpan>>();
            var timeout = Timeout(milliTestTime);

            while (sw.Elapsed < milliTestTime)
            {
                if (sw.Elapsed.TotalSeconds * queriesPerSecond > all.Count)
                {
                    all.Add(TestWrite(Stopwatch.StartNew()));
                }
            }

            var completedTask = await Task.WhenAny(Task.WhenAll(all), timeout);
            var completed = all.Where(x => x.IsCompleted).ToList();
            var sum = completed.Sum(x => x.Result.TotalMilliseconds);
            var result = sum / completed.Count;
            Console.WriteLine($"Elapsed ms:{sw.ElapsedMilliseconds} all_count:{all.Count} sum:{sum} result:{result}");
            if (completedTask == timeout)
            {
                Console.WriteLine("FAILED!");
                return -1;
            }
            return result;
        }

        /// <summary>
        /// The purpose of this method is to review the state of both the client (grpc channel) pool and session pool.
        /// The session pool should have sessions perfectly evenly distributed among each channel.
        /// The channel pool at test end should all have refcounts = 0.
        /// </summary>
        protected static bool ValidatePoolInfo()
        {
            StringBuilder s = new StringBuilder();
            bool isValid = SessionPool.GetIsPoolEvenlySplit(s);
            Logger.Instance.Info(s.ToString());

            s.Clear();
            isValid = ClientPool.GetTotalClientRefCount(s) == 0 && isValid;
            Logger.Instance.Info(s.ToString());

            return isValid;
        }
    }
}
