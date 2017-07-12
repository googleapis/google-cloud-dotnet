// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Cloud.PubSub.V1.Tasks;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.PubSub.V1.Tests.Tasks.TestScheduler;

namespace Google.Cloud.PubSub.V1.Tests.Tasks
{
    public class TestSchedulerTest
    {
#pragma warning disable CS1998
        // Deliberately testing an async method with no await
        private async Task<int> GetANumber1()
        {
            return 111;
        }
#pragma warning restore CS1998

        private Task<int> GetANumber2()
        {
            return Task.FromResult(222);
        }

        private async Task<int> WaitTest(TestScheduler sch, int i)
        {
            if (i < 10)
            {
                await sch.TaskHelper.ConfigureAwait(sch.Delay(TimeSpan.FromSeconds(i), CancellationToken.None));
            }
            return i;
        }

        private DateTime Dt(int seconds) => new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc) + TimeSpan.FromSeconds(seconds);

        [Fact]
        public void BasicFunctionality()
        {
            using (var scheduler = new TestScheduler(threadCount: 4))
            {
                TaskHelper taskHelper = scheduler.TaskHelper;
                var number = scheduler.Run(async () =>
                {
                    Assert.Equal(Dt(0), scheduler.Clock.GetCurrentDateTimeUtc());
                    await taskHelper.ConfigureAwait(scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                    Assert.Equal(Dt(10), scheduler.Clock.GetCurrentDateTimeUtc());
                    await taskHelper.ConfigureAwait(scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                    Assert.Equal(Dt(20), scheduler.Clock.GetCurrentDateTimeUtc());
                    int n1 = await taskHelper.ConfigureAwait(GetANumber1());
                    Assert.Equal(111, n1);
                    int n2 = await taskHelper.ConfigureAwait(GetANumber2());
                    Assert.Equal(222, n2);
                    Task<int>[] tasks = new Task<int>[1000];
                    for (int i = 0; i < tasks.Length; i++)
                    {
                        tasks[i] = WaitTest(scheduler, i);
                    }
                    await taskHelper.ConfigureAwait(Task.WhenAll(tasks));
                    return tasks.Sum(x => x.Result);
                });
                Assert.Equal(1000 * 999 / 2, number);
            }
        }

        [Fact]
        public void WaitThreadDepletionDetection()
        {
            // Throws with 1 thread
            using (var scheduler1 = new TestScheduler(threadCount: 1))
            {
                Assert.Throws<SchedulerException>(() =>
                {
                    scheduler1.Run(() =>
                    {
                        Task task = scheduler1.Delay(TimeSpan.FromHours(1), CancellationToken.None);
                        scheduler1.TaskHelper.Wait(task);
                    });
                });
            }

            // Does not throw (and completes) with 2 threads
            using (var scheduler2 = new TestScheduler(threadCount: 2))
            {
                scheduler2.Run(() =>
                {
                    Task task = scheduler2.Delay(TimeSpan.FromHours(1), CancellationToken.None);
                    scheduler2.TaskHelper.Wait(task);
                });
            }
        }

        [Fact]
        public void WaitCancelled()
        {
            using (var scheduler = new TestScheduler(threadCount: 2))
            {
                TaskHelper taskHelper = scheduler.TaskHelper;
                scheduler.Run(() =>
                {
                    var task = scheduler.Delay(TimeSpan.FromSeconds(10), new CancellationToken(true));
                    var ae = Assert.Throws<AggregateException>(() => taskHelper.Wait(task));
                    Assert.IsAssignableFrom<OperationCanceledException>(ae.InnerException);
                    Assert.True(task.IsCanceled);
                });
            }
        }

        [Fact]
        public void WaitException()
        {
            using (var scheduler = new TestScheduler(threadCount: 2))
            {
                TaskHelper taskHelper = scheduler.TaskHelper;
                scheduler.Run(() =>
                {
                    var task = taskHelper.Run(() => throw new NotImplementedException());
                    var ae = Assert.Throws<AggregateException>(() => taskHelper.Wait(task));
                    Assert.IsAssignableFrom<NotImplementedException>(ae.InnerException);
                    Assert.True(task.IsFaulted);
                });
            }
        }
    }
}
