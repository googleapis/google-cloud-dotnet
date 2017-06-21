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
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data.StressTests
{
    internal abstract class BaseStressTest
    {
        protected abstract Task<long> TestWrite1(Stopwatch sw);

        private async Task Timeout(TimeSpan milliTestTime)
        {
            await Task.Delay(milliTestTime.Add(TimeSpan.FromSeconds(10)));
        }

        public async Task<double> TestWriteLatencyWithQps(double queriesPerSecond, TimeSpan milliTestTime)
        {
            var qPerMs = queriesPerSecond / 1000;
            var sw = Stopwatch.StartNew();
            var all = new List<Task<long>>();
            var timeout = Timeout(milliTestTime);

            while (sw.ElapsedMilliseconds < milliTestTime.TotalMilliseconds)
            {
                while (sw.ElapsedMilliseconds * qPerMs > all.Count
                       && sw.ElapsedMilliseconds < milliTestTime.TotalMilliseconds)
                {
                    all.Add(TestWrite1(Stopwatch.StartNew()));
                }
            }
            await Task.WhenAny(Task.WhenAll(all), timeout);
            var completed = all.Where(x => x.IsCompleted).ToList();
            var sum = completed.Select(x => x.Result).Sum();
            var result = sum / (double)completed.Count;
            Console.WriteLine($"Elapsed ms:{sw.ElapsedMilliseconds} all_count:{all.Count} sum:{sum} result:{result}");
            if (timeout.IsCompleted)
            {
                Console.WriteLine("FAILED!");
            }
            return result;
        }
    }
}
