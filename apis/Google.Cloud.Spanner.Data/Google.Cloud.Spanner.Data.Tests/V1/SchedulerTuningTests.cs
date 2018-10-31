// Copyright 2018 Google LLC
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

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.ClientTesting;
using Xunit;

public class SchedulerTuningTests
{
    [Fact]
    public void TimeContinuations()
    {
        int tasks = 50;
        List<TaskCompletionSource<int>> tcs = Enumerable.Range(0, tasks)
            .Select(_ => new TaskCompletionSource<int>())
            .ToList();

        object monitor = new object();
        int count = 0;
        Task[] awaitingTasks = tcs.Select(async t =>
        {
            await t.Task.ConfigureAwait(false);
            FileLogger.Log($"Woken");
            Interlocked.Increment(ref count);
            lock (monitor)
            {
                Monitor.Pulse(monitor);
            }
        }).ToArray();

        Stopwatch sw = Stopwatch.StartNew();
        tcs.ForEach(t => t.SetResult(0));
        lock (monitor)
        {
            while (Interlocked.CompareExchange(ref count, 0, 0) < tasks)
            {
                Monitor.Wait(monitor);
            }
        }
        sw.Stop();
        Assert.Equal(-1, sw.ElapsedMilliseconds);
    }
}