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

using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.Common.V1;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.PoolRewrite.SessionPool;

namespace Google.Cloud.Spanner.V1.PoolRewrite.Tests
{
    public partial class SessionPoolTests
    {
        /// <summary>
        /// Tests for <see cref="SessionPool.TargetedSessionPool" />, mostly
        /// involving direct construction of the pool to avoid any maintenance loops etc.
        /// </summary>
        public sealed class TargetedSessionPoolTests
        {
            private static readonly DatabaseName s_databaseName = new DatabaseName("project", "instance", "database");

            private static TargetedSessionPool CreatePool(bool acquireSessionsImmediately)
            {
                var client = new SessionTestingSpannerClient();
                // Fixed session pool options so we can hard-code values without worrying about the defaults changing
                var options = new SessionPoolOptions
                {
                     IdleSessionRefreshDelay = TimeSpan.FromMinutes(15),
                     MaintenanceLoopDelay = TimeSpan.FromMinutes(1),
                     PoolEvictionDelay = TimeSpan.FromMinutes(100), // Deliberately not a multiple of 15
                     SessionEvictionJitter = RetrySettings.NoJitter,
                     SessionRefreshJitter = RetrySettings.NoJitter,
                     MaximumActiveSessions = 100,
                     MaximumConcurrentSessionCreates = 20,
                     MinimumPooledSessions = 10,
                     Timeout = 60,
                     WaitOnResourcesExhausted = ResourcesExhaustedBehavior.Block,
                     WriteSessionsFraction = 0.2
                };
                var parent = new SessionPool(client, options, client.Logger);
                return new TargetedSessionPool(parent, s_databaseName, acquireSessionsImmediately);
            }

            [Fact]
            public void Construction_NoAcquireSessionsImmediately()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient) pool.Client;

                var stats = pool.GetStatisticsSnapshot();
                Assert.Equal(0, stats.InFlightCreationCount);
                Assert.Equal(0, stats.ReadPoolCount);
                Assert.Equal(0, stats.ReadWritePoolCount);

                // No attempt to run the scheduler, as there's nothing in-flight
                client.Logger.AssertNoWarningsOrErrors();
            }

            [Fact]
            public async Task Construction_AcquireSessionsImmediately()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient) pool.Client;
                var stats = pool.GetStatisticsSnapshot();
                Assert.Equal(10, stats.InFlightCreationCount);
                Assert.Equal(0, stats.ReadPoolCount);
                Assert.Equal(0, stats.ReadWritePoolCount);

                await client.Scheduler.RunAsync(async () =>
                {
                    // This is unfortunate, but basically our fake task scheduler doesn't know how long to wait for
                    // (in terms of other tasks being scheduled) before moving on.
                    Thread.Sleep(2000);
                    await client.Scheduler.Delay(TimeSpan.FromSeconds(15));
                });

                stats = pool.GetStatisticsSnapshot();
                
                Assert.Equal(0, stats.InFlightCreationCount);
                // It's very likely that we'll end up with "all read/write" sessions,
                // as all the new sessions will go through the "do we need more read/write transactions?"
                // code at the same time. That's likely to happen with the real pool too - but it'll
                // even itself out over time.
                Assert.Equal(10, stats.ReadPoolCount + stats.ReadWritePoolCount);
                Assert.InRange(stats.ReadWritePoolCount, 2, 10);

                client.Logger.AssertNoWarningsOrErrors();
            }

            [Fact]
            public async Task ReleaseSession_NoRefreshRequired()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    // Acquire all 100 possible active sessions, so we don't get any more behind the scenes.
                    var sessions = new List<PooledSession>();
                    for (int i = 0; i < 100; i++)
                    {
                        sessions.Add(await pool.AcquireSessionAsync(new TransactionOptions(), default));
                    }

                    var firstSession = sessions[0];
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(10)); // Not long enough to require a refresh

                    var timeBeforeSqlCall = client.Clock.GetCurrentDateTimeUtc();
                    await firstSession.ExecuteSqlAsync(new ExecuteSqlRequest { Sql = "Client SQL" }, 5, default);

                    firstSession.ReleaseToPool(false);

                    var reacquiredSession = await pool.AcquireSessionAsync(new TransactionOptions(), default);
                    Assert.Equal(firstSession.SessionName, reacquiredSession.SessionName);

                    // The only request is the one we sent
                    Assert.Equal(1, client.ExecuteSqlRequests.Count);
                    Assert.True(client.ExecuteSqlRequests.TryDequeue(out var refreshRequest));
                    Assert.Equal("Client SQL", refreshRequest.Sql);

                    // The refresh time should have been reset due to the successful call.
                    Assert.InRange(reacquiredSession.RefreshTimeForTest, timeBeforeSqlCall.AddMinutes(15), client.Clock.GetCurrentDateTimeUtc().AddMinutes(15));
                });

                client.Logger.AssertNoWarningsOrErrors();
            }

            [Fact]
            public async Task ReleaseSession_RefreshRequired()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient) pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    // Acquire all 100 possible active sessions, so we don't get any more behind the scenes.
                    var sessions = new List<PooledSession>();
                    for (int i = 0; i < 100; i++)
                    {
                        sessions.Add(await pool.AcquireSessionAsync(new TransactionOptions(), default));
                    }

                    var firstSession = sessions[0];
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(20)); // So a refresh is required
                    Assert.Equal(0, client.ExecuteSqlRequests.Count);
                    var timeBeforeRelease = client.Clock.GetCurrentDateTimeUtc();
                    firstSession.ReleaseToPool(false);

                    var refreshedSession = await pool.AcquireSessionAsync(new TransactionOptions(), default);
                    Assert.Equal(firstSession.SessionName, refreshedSession.SessionName);
                    Assert.Equal(1, client.ExecuteSqlRequests.Count);
                    Assert.True(client.ExecuteSqlRequests.TryDequeue(out var refreshRequest));
                    Assert.Equal("SELECT 1", refreshRequest.Sql);
                    // The refresh time should have been reset due to the successful call.
                    Assert.InRange(refreshedSession.RefreshTimeForTest,
                        timeBeforeRelease.AddMinutes(15), client.Clock.GetCurrentDateTimeUtc().AddMinutes(15));
                });

                client.Logger.AssertNoWarningsOrErrors();
            }

            [Fact]
            public async Task ReleaseSession_SessionEvicted()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    // Acquire all 100 possible active sessions, so we don't get any more behind the scenes.
                    var sessions = new List<PooledSession>();
                    for (int i = 0; i < 100; i++)
                    {
                        sessions.Add(await pool.AcquireSessionAsync(new TransactionOptions(), default));
                    }

                    var firstSession = sessions[0];
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(150)); // So it should be evicted
                    firstSession.ReleaseToPool(false);

                    var laterSession = await pool.AcquireSessionAsync(new TransactionOptions(), default);
                    Assert.NotEqual(firstSession.SessionName, laterSession.SessionName);
                    Assert.Equal(101, client.SessionsCreated);
                    Assert.Equal(1, client.SessionsDeleted);
                });

                client.Logger.AssertNoWarningsOrErrors();
            }

            [Fact]
            public async Task AcquireAsync_ZeroPoolSizeAcquireUpToMaximum()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                pool.Options.MinimumPooledSessions = 0;

                await client.Scheduler.RunAsync(async () =>
                {
                    await AcquireAllSessionsAsync(pool);
                    Assert.Equal(pool.Options.MaximumActiveSessions, pool.ActiveSessionCount);
                });
            }

            [Fact]
            public async Task AcquireAsync_UpToMaxActiveSessionsOneAtATime()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    for (int i = 0; i < pool.Options.MaximumActiveSessions; i++)
                    {
                        await pool.AcquireSessionAsync(new TransactionOptions(), default);
                    }
                });
            }

            [Fact]
            public async Task AcquireAsync_UpToMaxActiveSessionsAllInOneGo()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                // Create all the tasks before we let anything else happen
                var tasks = Enumerable
                    .Range(0, pool.Options.MaximumActiveSessions)
                    .Select(_ => pool.AcquireSessionAsync(new TransactionOptions(), default))
                    .ToList();
                await client.Scheduler.RunAsync(async () =>
                {
                    // Now we're running, all the acquisition tasks should be able to start requests
                    // running etc.
                    await Task.WhenAll(tasks);
                });
            }

            [Fact]
            public async Task AcquireAsync_MaxActiveSessions_Fail()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                pool.Options.WaitOnResourcesExhausted = ResourcesExhaustedBehavior.Fail;

                await client.Scheduler.RunAsync(async () =>
                {
                    await AcquireAllSessionsAsync(pool);
                    Assert.Equal(pool.Options.MaximumActiveSessions, pool.ActiveSessionCount);

                    var exception = await Assert.ThrowsAsync<RpcException>(() => pool.AcquireSessionAsync(new TransactionOptions(), default));
                    Assert.Equal(StatusCode.ResourceExhausted, exception.StatusCode);
                });
            }

            [Fact]
            public async Task AcquireAsync_MaxActiveSessions_Block()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                pool.Options.WaitOnResourcesExhausted = ResourcesExhaustedBehavior.Block;

                await client.Scheduler.RunAsync(async () =>
                {
                    var sessions = await AcquireAllSessionsAsync(pool);
                    Assert.Equal(pool.Options.MaximumActiveSessions, pool.ActiveSessionCount);

                    // We can't exceed the maximum active session count
                    var acquisitionTask = pool.AcquireSessionAsync(new TransactionOptions(), default);
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(1));
                    Assert.False(acquisitionTask.IsCompleted);

                    // But we can get a released session
                    sessions[0].ReleaseToPool(false);
                    await acquisitionTask;

                    Assert.Equal(pool.Options.MaximumActiveSessions, pool.ActiveSessionCount);
                });
            }

            [Fact]
            public async Task MaintainPool_CreatesNewSessions()
            {
                var pool = CreatePool(false);
                pool.Options.WriteSessionsFraction = 1; // Just for simplicity.
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(1));
                    // Allow any pending tasks to execute.
                    Thread.Sleep(2000);

                    var stats = pool.GetStatisticsSnapshot();
                    Assert.Equal(0, stats.ReadWritePoolCount);

                    pool.MaintainPool();

                    await client.Scheduler.Delay(TimeSpan.FromMinutes(1));
                    Thread.Sleep(2000);

                    stats = pool.GetStatisticsSnapshot();
                    Assert.Equal(10, stats.ReadWritePoolCount);
                });
            }

            [Fact]
            public async Task MaintainPool_RefreshesSessions()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(1));
                    // Allow any pending tasks to execute.
                    Thread.Sleep(2000);

                    // Let all the sessions idle out.
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(20));

                    var timeBeforeMaintenance = client.Clock.GetCurrentDateTimeUtc();

                    // Start everything refreshing.
                    pool.MaintainPool();

                    // Give the refresh tasks time to run.
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(1));
                    Thread.Sleep(2000);

                    var session = await pool.AcquireSessionAsync(new TransactionOptions(), default);
                    Assert.InRange(session.RefreshTimeForTest, timeBeforeMaintenance.AddMinutes(15), client.Clock.GetCurrentDateTimeUtc().AddMinutes(15));

                    // We shouldn't have asked for any more sessions from the client, because the refreshing tasks
                    // would count as in-flight sessions.
                    Assert.Equal(10, client.SessionsCreated);
                });
            }

            [Fact]
            public async Task MaintainPool_EvictsSessions()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(1));
                    // Allow any pending tasks to execute.
                    Thread.Sleep(2000);

                    // Let all the sessions go beyond their eviction time.
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(101));

                    var timeBeforeMaintenance = client.Clock.GetCurrentDateTimeUtc();

                    // Start everything refreshing.
                    pool.MaintainPool();

                    // Give the eviction and reacquisition tasks time to run.
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(1));
                    Thread.Sleep(2000);

                    // The newly created session should have an appropriate refresh time.
                    var session = await pool.AcquireSessionAsync(new TransactionOptions(), default);
                    Assert.InRange(session.RefreshTimeForTest, timeBeforeMaintenance.AddMinutes(15), client.Clock.GetCurrentDateTimeUtc().AddMinutes(15));
                    session.ReleaseToPool(false);

                    // Pool should be full again.
                    var stats = pool.GetStatisticsSnapshot();
                    Assert.Equal(10, stats.ReadPoolCount + stats.ReadWritePoolCount);

                    // All the previous sessions should be evicted, and the pool refilled.
                    Assert.Equal(20, client.SessionsCreated);
                });
            }

            [Fact(Skip="Currently flaky on CI. Fixing via GAX changes")]
            public async Task WaitForPoolAsync_Normal()
            {
                var pool = CreatePool(false);
                pool.Options.MinimumPooledSessions = 30;
                pool.MaintainPool();
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    var timeBefore = client.Clock.GetCurrentDateTimeUtc();
                    await pool.WaitForPoolAsync(default);

                    // We allow 20 session creates at a time, and each takes 5 seconds.
                    // We'll need at least 6 read/write sessions too, but those will be taken from the first 20
                    // as we err on the side of over-creating read/write transactions. (When the first 20
                    // all return, they'll all notice we have no transactions.) That won't slow down the
                    // second set of creations.
                    var timeAfter = client.Clock.GetCurrentDateTimeUtc();
                    Assert.Equal(TimeSpan.FromSeconds(10), timeAfter - timeBefore);
                    var stats = pool.GetStatisticsSnapshot();
                    Assert.Equal(10, stats.ReadPoolCount);
                    Assert.Equal(20, stats.ReadWritePoolCount);
                });
            }

            [Fact]
            public async Task WaitForPoolAsync_CancelOneOfTwo()
            {
                var pool = CreatePool(false);
                pool.Options.MinimumPooledSessions = 30;
                pool.MaintainPool();
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    var timeBefore = client.Clock.GetCurrentDateTimeUtc();
                    var cts = new CancellationTokenSource();
                    var task1 = pool.WaitForPoolAsync(cts.Token);
                    var task2 = pool.WaitForPoolAsync(default);

                    await client.Scheduler.Delay(TimeSpan.FromSeconds(8));
                    
                    Assert.Equal(TaskStatus.WaitingForActivation, task1.Status);
                    Assert.Equal(TaskStatus.WaitingForActivation, task2.Status);

                    // If we cancel one cancelation token, that task will fail,
                    // but the other won't.
                    cts.Cancel();
                    await client.Scheduler.Delay(TimeSpan.FromSeconds(1));
                    Thread.Sleep(1000);
                    Assert.Equal(TaskStatus.Canceled, task1.Status);
                    Assert.Equal(TaskStatus.WaitingForActivation, task2.Status);

                    // The uncancelled task completes normally
                    await task2;
                });
            }

            [Fact]
            public async Task WaitForPoolAsync_AlreadyCompleted()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    // Wait for it to come up to minimum size
                    await pool.WaitForPoolAsync(default);

                    // Asking for it again should return an already completed task
                    Task task = pool.WaitForPoolAsync(default);
                    Assert.Equal(TaskStatus.RanToCompletion, task.Status);
                });
            }

            [Fact]
            public async Task WaitForPoolAsync_AlreadyUnhealthy()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                client.FailAllRpcs = true;
                pool.MaintainPool();

                await client.Scheduler.RunAsync(async () =>
                {
                    var exception = await Assert.ThrowsAsync<RpcException>(() => pool.WaitForPoolAsync(default));
                    Assert.Equal(StatusCode.Unknown, exception.StatusCode);
                });
            }

            [Fact]
            public async Task WaitForPoolAsync_BecomesUnhealthyWhileWaiting()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                client.FailAllRpcs = true;

                await client.Scheduler.RunAsync(async () =>
                {
                    var task = pool.WaitForPoolAsync(default);
                    pool.MaintainPool();
                    var exception = await Assert.ThrowsAsync<RpcException>(() => task);
                    // If we go unhealthy while waiting, the status code from the RPC is used for the exception.
                    Assert.Equal(StatusCode.Internal, exception.StatusCode);
                });
            }

            [Fact]
            public async Task WaitForPoolAsync_ReleaseSession()
            {
                var pool = CreatePool(false);
                pool.Options.MaximumActiveSessions = 10; // Same as minimum pool size
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    var session = await pool.AcquireSessionAsync(new TransactionOptions(), default);

                    Task task = pool.WaitForPoolAsync(default);

                    // Wait a bit - but nothing should happen, because we can't get any more sessions
                    await client.Scheduler.Delay(TimeSpan.FromSeconds(10));
                    Thread.Sleep(1000);
                    // Having acquired a session, we can't reach the minimum pool size
                    Assert.Equal(TaskStatus.WaitingForActivation, task.Status);

                    session.ReleaseToPool(false);

                    // Now the pool can be full again.
                    await task;
                });
            }

            [Fact]
            public async Task ShutdownPoolAsync_AllStatsToZero()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    await pool.WaitForPoolAsync(default);
                    var session = await pool.AcquireSessionAsync(new TransactionOptions(), default);

                    // Shut down the pool, but keep one active session for now
                    Task task = pool.ShutdownPoolAsync(default);
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(1));
                    var stats = pool.GetStatisticsSnapshot();
                    Assert.Equal(true, stats.Shutdown);
                    Assert.Equal(1, stats.ActiveSessionCount);
                    Assert.Equal(0, stats.InFlightCreationCount);
                    Assert.Equal(0, stats.ReadPoolCount);
                    Assert.Equal(0, stats.ReadWritePoolCount);
                    Assert.Equal(TaskStatus.WaitingForActivation, task.Status);

                    session.ReleaseToPool(false);
                    // Now we should be able to wait for the shutdown task to complete
                    await task;

                    stats = pool.GetStatisticsSnapshot();
                    Assert.Equal(0, stats.ActiveSessionCount);
                });
            }

            [Fact]
            public async Task ShutdownPoolAsync_PendingAcquisitionsFail()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    // Make sure we won't be able to get any more sessions immediately.
                    var sessions = await AcquireAllSessionsAsync(pool);
                    var acquisitionTask = pool.AcquireSessionAsync(new TransactionOptions(), default);
                    var shutdownTask = pool.ShutdownPoolAsync(default);

                    // The existing acquisition task should fail.
                    await Assert.ThrowsAsync<TaskCanceledException>(() => acquisitionTask);

                    sessions.ForEach(s => s.ReleaseToPool(false));
                    await shutdownTask;
                });
            }

            [Fact]
            public async Task ShutdownPoolAsync_CannotAcquireAfterShutdown()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    await pool.WaitForPoolAsync(default);
                    await pool.ShutdownPoolAsync(default);
                    // TODO: Is this the right exception? It feels appropriate.
                    await Assert.ThrowsAsync<InvalidOperationException>(() => pool.AcquireSessionAsync(new TransactionOptions(), default));
                });
            }

            private async Task<List<PooledSession>> AcquireAllSessionsAsync(TargetedSessionPool pool)
            {
                List<PooledSession> sessions = new List<PooledSession>();
                for (int i = 0; i < pool.Options.MaximumActiveSessions; i++)
                {
                    sessions.Add(await pool.AcquireSessionAsync(new TransactionOptions(), default));
                }
                return sessions;
            }
        }
    }
}
