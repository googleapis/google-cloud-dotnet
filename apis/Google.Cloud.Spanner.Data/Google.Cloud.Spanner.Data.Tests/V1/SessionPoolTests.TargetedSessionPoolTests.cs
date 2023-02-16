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
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Common.V1;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.SessionPool;

namespace Google.Cloud.Spanner.V1.Tests
{
    public partial class SessionPoolTests
    {
        /// <summary>
        /// Tests for <see cref="SessionPool.TargetedSessionPool" />, mostly
        /// involving direct construction of the pool to avoid any maintenance loops etc.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The tests use the scheduler in different ways. Some are slightly "interactive" - we
        /// want the scheduler to be triggering while we wait for tasks to complete (e.g. session
        /// acquisition, or waiting for the pool to be up to size).
        /// These use FakeScheduler.RunAsync with a delegate.
        /// </para>
        /// <para>
        /// Other tasks start asynchronous tasks running, then allow the scheduler to advance up to a
        /// certain time before stopping... at which point we're back in control and can make assertions
        /// without further tasks completing. These use FakeScheduler.RunForSecondsAsync.
        /// </para>
        /// </remarks>
        [FileLoggerBeforeAfterTest]
        public sealed class TargetedSessionPoolTests
        {
            private static readonly DatabaseName s_databaseName = new DatabaseName("project", "instance", "database");
            private static readonly string s_databaseRole = "test";

            // The time to delay in tests that need to wait for all the sessions to be acquired (or fail).
            // Reducing this time will make the tests faster, but at the cost of flakiness.
            private static readonly TimeSpan s_sessionAcquistionDelay = TimeSpan.FromMilliseconds(500);

            private static TargetedSessionPool CreatePool(bool acquireSessionsImmediately)
            {
                var client = new SessionTestingSpannerClient();
                client.Scheduler.RealTimeTimeout = TimeSpan.FromSeconds(15);
                // Fixed session pool options so we can hard-code values without worrying about the defaults changing
                var options = new SessionPoolOptions
                {
                     IdleSessionRefreshDelay = TimeSpan.FromMinutes(15),
                     MaintenanceLoopDelay = TimeSpan.FromSeconds(0), // Disable automatic pool maintenance
                     PoolEvictionDelay = TimeSpan.FromMinutes(100), // Deliberately not a multiple of 15
                     SessionEvictionJitter = RetrySettings.NoJitter,
                     SessionRefreshJitter = RetrySettings.NoJitter,
                     MaximumActiveSessions = 100,
                     MaximumConcurrentSessionCreates = 20,
                     CreateSessionMaximumBatchSize = 5,
                     MinimumPooledSessions = 10,
                     Timeout = TimeSpan.FromSeconds(60),
                     WaitOnResourcesExhausted = ResourcesExhaustedBehavior.Block,
                     WriteSessionsFraction = 0.2
                };
                var parent = new SessionPool(client, options);
                return new TargetedSessionPool(parent, SessionPoolSegmentKey.Create(s_databaseName), acquireSessionsImmediately);
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
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

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task Construction_AcquireSessionsImmediately()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient) pool.Client;

                // Wait a little in real time, session creation is
                // launched as a (controlled) fire and forget task. Let's make sure it
                // advances enough so that stats are updated.
                await Task.Delay(s_sessionAcquistionDelay);
                var stats = pool.GetStatisticsSnapshot();
                Assert.Equal(10, stats.InFlightCreationCount);
                Assert.Equal(0, stats.ReadPoolCount);
                Assert.Equal(0, stats.ReadWritePoolCount);

                await client.Scheduler.RunForSecondsAsync(15);

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

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task ReleaseSession_NoRefreshRequired()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    // Acquire all 100 possible active sessions, so we don't get any more behind the scenes.
                    var sessions = await AcquireAllSessionsAsync(pool);

                    var firstSession = sessions[0];
                    await client.Scheduler.Delay(TimeSpan.FromMinutes(10)); // Not long enough to require a refresh

                    var timeBeforeSqlCall = client.Clock.GetCurrentDateTimeUtc();
                    await firstSession.ExecuteSqlAsync(new ExecuteSqlRequest { Sql = "Client SQL" }, null);

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

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task ReleaseSession_RefreshRequired()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient) pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    // Acquire all 100 possible active sessions, so we don't get any more behind the scenes.
                    var sessions = await AcquireAllSessionsAsync(pool);

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

            [Fact(Timeout = TestTimeoutMilliseconds)]
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

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task ReleaseSession_TransactionRolledback()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient) pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    // Acquire all 100 possible active sessions, so we don't get any more behind the scenes.
                    var sessions = await AcquireAllSessionsAsync(pool);

                    var transactionId = ByteString.CopyFromUtf8("sample transaction");
                    var firstSession = sessions[0].WithTransaction(transactionId, TransactionOptions.ModeOneofCase.ReadWrite);

                    var timeBeforeRelease = client.Clock.GetCurrentDateTimeUtc();
                    firstSession.ReleaseToPool(false);

                    var reacquiredSession = await pool.AcquireSessionAsync(new TransactionOptions(), default);
                    Assert.Equal(firstSession.SessionName, reacquiredSession.SessionName);

                    // The only rollback request is the one we sent
                    Assert.Equal(1, client.RollbackRequests.Count);
                    Assert.True(client.RollbackRequests.TryDequeue(out var rollbackRequest));
                    Assert.Equal(transactionId, rollbackRequest.TransactionId);
                    Assert.Equal(firstSession.SessionName, rollbackRequest.SessionAsSessionName);

                    // We should have waited for the rollback to complete before reacquiring
                    Assert.Equal(timeBeforeRelease + client.RollbackDelay, client.Clock.GetCurrentDateTimeUtc());
                });

                client.Logger.AssertNoWarningsOrErrors();
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
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

            [Fact(Timeout = TestTimeoutMilliseconds)]
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
                var stats = pool.GetStatisticsSnapshot();
                Assert.Equal(0, stats.ReadPoolCount);
                Assert.Equal(0, stats.ReadWritePoolCount);
                Assert.Equal(100, stats.ActiveSessionCount);
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task AcquireAsync_UpToMaxActiveSessionsAllInOneGo()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                // Create all the tasks before we let anything else happen
                var tasks = AcquireSessionTasks(pool, pool.Options.MaximumActiveSessions);
                await client.Scheduler.RunAsync(async () =>
                {
                    // Now we're running, all the acquisition tasks should be able to start requests
                    // running etc.
                    await Task.WhenAll(tasks);
                });
                var stats = pool.GetStatisticsSnapshot();
                Assert.Equal(0, stats.ReadPoolCount);
                Assert.Equal(0, stats.ReadWritePoolCount);
                Assert.Equal(100, stats.ActiveSessionCount);
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
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

            [Fact(Timeout = TestTimeoutMilliseconds)]
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

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task AcquireAsync_BecomesUnhealthy()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                client.FailAllRpcs = true;

                await client.Scheduler.RunAsync(async () =>
                {
                    var exception = await Assert.ThrowsAsync<RpcException>(() => pool.AcquireSessionAsync(new TransactionOptions(), default));
                    var stats = pool.GetStatisticsSnapshot();
                    Assert.False(stats.Healthy);
                    Assert.Equal(0, stats.ActiveSessionCount);
                    Assert.Equal(0, stats.PendingAcquisitionCount);
                    Assert.Equal(0, stats.ReadPoolCount);
                    Assert.Equal(0, stats.ReadWritePoolCount);
                });
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task AcquireAsync_BecomesUnhealthy_NotifiesWaitingCallers()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                var options = pool.Options;

                // Give the pool time to create the minimum amount of sessions.
                await client.Scheduler.RunAsync(TimeSpan.FromSeconds(15));

                var stats = pool.GetStatisticsSnapshot();
                Assert.True(stats.Healthy);
                Assert.Equal(0, stats.ActiveSessionCount);
                Assert.Equal(0, stats.PendingAcquisitionCount);
                Assert.Equal(10, stats.ReadPoolCount + stats.ReadWritePoolCount);
                Assert.Equal(0, stats.InFlightCreationCount);

                client.FailAllRpcs = true;
                client.FailAllRpcsDelay = TimeSpan.FromSeconds(1);

                // The sessions previously created can be acquired inmediately.
                // The extra ones should be pending waiting on create session tasks.
                var acquisitionTasks = AcquireSessionTasks(pool, 13);
                // Wait a little in real time to make sure that session creation tasks have started.
                // Session creation is done in a (controlled) fire and forget way, that's why
                // we need to wait a little in real time.
                await Task.Delay(s_sessionAcquistionDelay);
                stats = pool.GetStatisticsSnapshot();
                Assert.True(stats.Healthy);
                Assert.Equal(13, stats.ActiveSessionCount);
                Assert.Equal(3, stats.PendingAcquisitionCount);
                Assert.Equal(0, stats.ReadPoolCount);
                Assert.Equal(0, stats.ReadWritePoolCount);
                Assert.Equal(13, stats.InFlightCreationCount);

                // Make the create session tasks fail and notify the waiting callers.
                await client.Scheduler.RunAsync(TimeSpan.FromSeconds(5));

                int successfulAcquisitions = 0;
                int failedAcquisitions = 0;
                while(acquisitionTasks.Count > 0)
                {
                    var acquisitionTask = await Task.WhenAny(acquisitionTasks);
                    acquisitionTasks.Remove(acquisitionTask);

                    // It can either be one that got a previously created session
                    // or one that failed.
                    try
                    {
                        await acquisitionTask;
                        successfulAcquisitions++;
                    }
                    catch
                    {
                        failedAcquisitions++;
                    }
                }
                Assert.Equal(10, successfulAcquisitions);
                Assert.Equal(3, failedAcquisitions);
                stats = pool.GetStatisticsSnapshot();
                Assert.False(stats.Healthy);
                Assert.Equal(10, stats.ActiveSessionCount);
                Assert.Equal(0, stats.PendingAcquisitionCount);
                Assert.Equal(0, stats.ReadPoolCount);
                Assert.Equal(0, stats.ReadWritePoolCount);
                Assert.Equal(0, stats.InFlightCreationCount);
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task AcquireAsync_NursesBackToHealth()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                var options = pool.Options;

                client.FailAllRpcs = true;
                client.FailAllRpcsDelay = TimeSpan.FromSeconds(1);

                // In total MinimumSizePool + 1 sessions will be created (or tried to in our case)
                // in batches of CreateSessionMaximumBatchSize or less. The pool is still healthy
                // but no sessions have been created so the pool will try to create as many as necessary
                // to satisfy this caller and the MinimumSizePool.
                var acquisitionTask = pool.AcquireSessionAsync(new TransactionOptions(), default);

                // Give the pool time to go unhealthy
                await client.Scheduler.RunAsync(TimeSpan.FromSeconds(5));

                var exception = await Assert.ThrowsAsync<RpcException>(() => acquisitionTask);
                var stats = pool.GetStatisticsSnapshot();
                Assert.False(stats.Healthy);
                Assert.Equal(0, stats.ActiveSessionCount);
                Assert.Equal(0, stats.PendingAcquisitionCount);
                Assert.Equal(0, stats.ReadPoolCount);
                Assert.Equal(0, stats.ReadWritePoolCount);
                Assert.Equal(0, stats.InFlightCreationCount);

                client.FailAllRpcs = false;
                client.FailAllRpcsDelay = TimeSpan.Zero;

                // Acquire some sessions. This will start to try and nurse the pool back to health
                var acquisitionTasks = AcquireSessionTasks(pool, 3);
                // Wait a little in real time to make sure that nursing has started.
                // Nursing is done in a (controlled) fire and forget way, that's why
                // we need to wait a little in real time.
                await Task.Delay(s_sessionAcquistionDelay);
                stats = pool.GetStatisticsSnapshot();
                Assert.False(stats.Healthy);
                Assert.Equal(3, stats.ActiveSessionCount);
                // This one is 0 because the pool is unhealthy. The callers are waiting for the
                // pool to become healthy first.
                Assert.Equal(0, stats.PendingAcquisitionCount);
                Assert.Equal(0, stats.ReadPoolCount);
                Assert.Equal(0, stats.ReadWritePoolCount);
                // Nursing back to health attempts to create the last failed batch.
                // That will be either a batch of maximum size or a smaller batch with the remainder
                // whichever failed last.
                Assert.True(stats.InFlightCreationCount == 5 || stats.InFlightCreationCount == 1);

                // Run enough to have the pool become healthy and all the requested sessions acquired.
                await client.Scheduler.RunAsync(TimeSpan.FromSeconds(15));

                var pooledSessions = await Task.WhenAll(acquisitionTasks);
                Assert.Equal(3, pooledSessions.Length);
                stats = pool.GetStatisticsSnapshot();
                Assert.True(stats.Healthy);
                Assert.Equal(3, stats.ActiveSessionCount);
                Assert.Equal(0, stats.PendingAcquisitionCount);
                Assert.Equal(10, stats.ReadPoolCount + stats.ReadWritePoolCount);
                Assert.Equal(0, stats.InFlightCreationCount);
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task AcquireAsync_NursesBackToHealth_OriginalCallerCancelled()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                var options = pool.Options;

                client.FailAllRpcs = true;
                client.FailAllRpcsDelay = TimeSpan.FromSeconds(1);

                // In total MinimumSizePool + 1 sessions will be created (or tried to in our case)
                // in batches of CreateSessionMaximumBatchSize or less.
                var acquisitionTask = pool.AcquireSessionAsync(new TransactionOptions(), default);

                // Give the pool time to go unhealthy.
                await client.Scheduler.RunAsync(TimeSpan.FromSeconds(5));

                var exception = await Assert.ThrowsAsync<RpcException>(() => acquisitionTask);
                var stats = pool.GetStatisticsSnapshot();
                Assert.False(stats.Healthy);
                // Rest of stats for this same scenario are checked elsewhere.

                client.FailAllRpcs = false;
                client.FailAllRpcsDelay = TimeSpan.Zero;

                // This caller will start the nursing, the rest will just wait for the nursing to be done.
                var cancellationTokenSource = new CancellationTokenSource();
                var nursingAcquisition = pool.AcquireSessionAsync(new TransactionOptions(), cancellationTokenSource.Token);
                // Wait a little in real time to make sure that nursing has started.
                // Nursing is done in a (controlled) fire and forget way, that's why
                // we need to wait a little in real time.
                await Task.Delay(s_sessionAcquistionDelay);

                // Acquire some other sessions. These won't start a new nursing task, will just wait for
                // the one already started to be done.
                var acquisitionTasks = AcquireSessionTasks(pool, 3);

                stats = pool.GetStatisticsSnapshot();
                Assert.False(stats.Healthy);
                Assert.Equal(4, stats.ActiveSessionCount);

                // Cancel the original call, nursing should keep running.
                cancellationTokenSource.Cancel();
                var canceledException = await Assert.ThrowsAsync<TaskCanceledException>(() => nursingAcquisition);

                // Run enough to have the pool become healthy and all the requested sessions acquiered.
                await client.Scheduler.RunAsync(TimeSpan.FromSeconds(20));

                var pooledSessions = await Task.WhenAll(acquisitionTasks);
                Assert.Equal(3, pooledSessions.Length);
                stats = pool.GetStatisticsSnapshot();
                Assert.True(stats.Healthy);
                Assert.Equal(3, stats.ActiveSessionCount);
                Assert.Equal(0, stats.PendingAcquisitionCount);
                Assert.Equal(10, stats.ReadPoolCount + stats.ReadWritePoolCount);
                Assert.Equal(0, stats.InFlightCreationCount);
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task RefreshTransaction_FailsForDifferentTransactionTypes()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    var originalSession = await pool.AcquireSessionAsync(
                        new TransactionOptions { ReadOnly = new TransactionOptions.Types.ReadOnly() },
                        CancellationToken.None);

                    await Assert.ThrowsAsync<ArgumentException>(() => originalSession.WithFreshTransactionOrNewAsync(new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() }, CancellationToken.None));
                });
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task RefreshTransaction_WithFreshSession()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                var transactionOptions = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };
                await client.Scheduler.RunAsync(async () =>
                {
                    var originalSession = await pool.AcquireSessionAsync(
                        transactionOptions,
                        CancellationToken.None);
                    var originalSessionName = originalSession.SessionName;
                    var originalTransactionId = originalSession.TransactionId;
                    // This session hasn't had time to be stale.
                    // Refreshing the transaction should return a new instance of PooledSession
                    // with the same session name and different transaction ID.
                    var newSession = await originalSession.WithFreshTransactionOrNewAsync(transactionOptions, CancellationToken.None);

                    Assert.NotSame(originalSession, newSession);
                    Assert.Equal(originalSessionName, newSession.SessionName);
                    Assert.NotEqual(originalTransactionId, newSession.TransactionId);
                });
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task RefreshTransaction_WithStaleSession()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                var transactionOptions = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };

                await client.Scheduler.RunAsync(async () =>
                {
                    var originalSession = await pool.AcquireSessionAsync(transactionOptions, CancellationToken.None);
                    var originalSessionName = originalSession.SessionName;
                    var originalTransactionId = originalSession.TransactionId;

                    await client.Scheduler.Delay(TimeSpan.FromMinutes(20)); // So a refresh is required
                    // This session is now stale.
                    // Refreshing the transaction should return a new instance of PooledSession
                    // with a different session name and different transaction ID.
                    var newSessionTask = originalSession.WithFreshTransactionOrNewAsync(transactionOptions, CancellationToken.None);
                    // Let's make sure that our original session was refreshed and returned back to the pool.
                    // We have one session already so we can only acquire the rest.
                    var allSessionsTask = AcquireSessionTasks(pool, pool.Options.MaximumActiveSessions - 1);

                    var newSession = await newSessionTask;
                    Assert.NotSame(originalSession, newSession);
                    Assert.NotEqual(originalSessionName, newSession.SessionName);
                    Assert.NotEqual(originalTransactionId, newSession.TransactionId);

                    var allSessions = await Task.WhenAll(allSessionsTask);
                    Assert.Contains(allSessions, s => originalSessionName.Equals(s.SessionName));
                    Assert.DoesNotContain(allSessions, s => originalTransactionId.Equals(s.TransactionId));
                });
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task MaintainPool_CreatesNewSessions()
            {
                var pool = CreatePool(false);
                pool.Options.WriteSessionsFraction = 1; // Just for simplicity.
                var client = (SessionTestingSpannerClient)pool.Client;

                var stats = pool.GetStatisticsSnapshot();
                Assert.Equal(0, stats.ReadWritePoolCount);

                pool.MaintainPool();

                // Give it time to bring the pool up to size.
                await client.Scheduler.RunForSecondsAsync(30);

                stats = pool.GetStatisticsSnapshot();
                Assert.Equal(10, stats.ReadWritePoolCount);
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task MaintainPool_RefreshesSessions()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;

                // Give the pool a minute to fill up
                await client.Scheduler.RunForSecondsAsync(60);
                Assert.Equal(10, pool.GetStatisticsSnapshot().ReadWritePoolCount);

                // Let all the sessions idle out over 20 minutes.
                await client.Scheduler.RunForSecondsAsync(60 * 20);

                var timeBeforeMaintenance = client.Clock.GetCurrentDateTimeUtc();

                // Start everything refreshing.
                pool.MaintainPool();

                // Give the refresh tasks time to run.
                await client.Scheduler.RunForSecondsAsync(60);

                await client.Scheduler.RunAsync(async () =>
                {
                    var session = await pool.AcquireSessionAsync(new TransactionOptions(), default);
                    Assert.InRange(session.RefreshTimeForTest, timeBeforeMaintenance.AddMinutes(15), client.Clock.GetCurrentDateTimeUtc().AddMinutes(15));

                    // We shouldn't have asked for any more sessions from the client, because the refreshing tasks
                    // would count as in-flight sessions.
                    Assert.Equal(10, client.SessionsCreated);
                });
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task MaintainPool_EvictsSessions()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;

                // Give the pool a minute to fill up
                await client.Scheduler.RunForSecondsAsync(60);
                Assert.Equal(10, pool.GetStatisticsSnapshot().ReadWritePoolCount);

                // Let all the sessions go beyond their eviction time.
                await client.Scheduler.RunForSecondsAsync(60 * 101); // 100 minute eviction

                // Start everything refreshing.
                var timeBeforeMaintenance = client.Clock.GetCurrentDateTimeUtc();
                pool.MaintainPool();

                // Give the eviction and reacquisition tasks time to run.
                await client.Scheduler.RunForSecondsAsync(60);
                Assert.Equal(10, pool.GetStatisticsSnapshot().ReadWritePoolCount);

                // Pool should be full aagain
                var stats = pool.GetStatisticsSnapshot();
                Assert.Equal(10, stats.ReadPoolCount + stats.ReadWritePoolCount);

                // The newly created session should have an appropriate refresh time.
                // (We don't need to let the scheduler run, as we're getting it from the pool.)
                var session = await pool.AcquireSessionAsync(new TransactionOptions(), default);
                Assert.InRange(session.RefreshTimeForTest, timeBeforeMaintenance.AddMinutes(15), client.Clock.GetCurrentDateTimeUtc().AddMinutes(15));

                // All the previous sessions should have been evicted, so in total we've created 20 sessions.
                Assert.Equal(20, client.SessionsCreated);
                Assert.Equal(10, client.SessionsDeleted);
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task WhenPoolReady_Normal()
            {
                var pool = CreatePool(false);
                pool.Options.MinimumPooledSessions = 30;
                pool.MaintainPool();
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    var timeBefore = client.Clock.GetCurrentDateTimeUtc();
                    await pool.WhenPoolReady(default);

                    // We allow 20 session creates at a time, and each takes 5 seconds.
                    // We'll need at least 6 read/write sessions too. In reality, all 20 initially-created
                    // sessions will have read/write transactions created for them, because they'll all check that
                    // before any transactions are created.
                    // We check the most important part first: that we actually have the required sessions.
                    var stats = pool.GetStatisticsSnapshot();
                    Assert.Equal(30, stats.ReadWritePoolCount + stats.ReadPoolCount);
                    // Implicitly checks that we have 10 read-only sessions
                    Assert.Equal(20, stats.ReadWritePoolCount);

                    // We're loose when checking the elapsed time, as on slow CI machines it can take around half
                    // a second for a released SemaphoreSlim to be acquired again, which means we don't start the second
                    // session creation batch  until the virtual clock has advanced for the transaction creation.
                    var timeAfter = client.Clock.GetCurrentDateTimeUtc();
                    var elapsedSeconds = (timeAfter - timeBefore).TotalSeconds;
                    Assert.InRange(elapsedSeconds, 10, 11);
                });
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task WhenPoolReady_CancelOneOfTwo()
            {
                var pool = CreatePool(false);
                pool.Options.MinimumPooledSessions = 30;
                pool.MaintainPool();
                var client = (SessionTestingSpannerClient)pool.Client;

                var timeBefore = client.Clock.GetCurrentDateTimeUtc();
                var cts = new CancellationTokenSource();
                var task1 = pool.WhenPoolReady(cts.Token);
                var task2 = pool.WhenPoolReady(default);

                await client.Scheduler.RunForSecondsAsync(8);

                Assert.Equal(TaskStatus.WaitingForActivation, task1.Status);
                Assert.Equal(TaskStatus.WaitingForActivation, task2.Status);
                
                // If we cancel one cancelation token, that task will fail,
                // but the other won't.
                cts.Cancel();
                await client.Scheduler.RunForSecondsAsync(1);
                Assert.Equal(TaskStatus.Canceled, task1.Status);
                Assert.Equal(TaskStatus.WaitingForActivation, task2.Status);

                // Two seconds later (i.e. 11 seconds after starting), the uncancelled task completes normally.
                // It may well complete after 10 (virtual) seconds, but it depends on how quickly the SemaphoreSlim
                // is acquired for the second batch.
                await client.Scheduler.RunForSecondsAsync(2);
                // Just await this normally to avoid race conditions for when it completes
                await task2;
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task WhenPoolReady_AlreadyCompleted()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;

                await client.Scheduler.RunAsync(async () =>
                {
                    // Wait for it to come up to minimum size
                    await pool.WhenPoolReady(default);

                    // Asking for it again should return an already completed task
                    Task task = pool.WhenPoolReady(default);
                    Assert.Equal(TaskStatus.RanToCompletion, task.Status);
                });
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task WhenPoolReady_AlreadyUnhealthy()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                client.FailAllRpcs = true;
                pool.MaintainPool();

                // Wait a little in real time so that the start session creation tasks
                // have had time to execute, they are started in a fire and forget manner.
                // This test has been flaky, so we wait up to three times, stopping the wait if
                // we know that the pool is unhealthy.
                for (int i = 0; i < 3; i++)
                {
                    var stats = pool.GetStatisticsSnapshot();
                    if (!stats.Healthy)
                    {
                        break;
                    }
                    await Task.Delay(s_sessionAcquistionDelay);
                }

                await client.Scheduler.RunAsync(async () =>
                {
                    var exception = await Assert.ThrowsAsync<RpcException>(() => pool.WhenPoolReady(default));
                    Assert.Equal(StatusCode.Unknown, exception.StatusCode);
                });
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task WhenPoolReady_BecomesUnhealthyWhileWaiting()
            {
                var pool = CreatePool(false);
                var client = (SessionTestingSpannerClient)pool.Client;
                client.FailAllRpcs = true;
                // We can end up with a lot of log entries, which take a while to write to disk
                // before the task becomes faulted.
                client.Scheduler.PostLoopSettleTime = TimeSpan.FromMilliseconds(500);

                // We could probably do this without the scheduler, given that the tasks
                // will fail immediately, but it feels odd not to use it.
                await client.Scheduler.RunAsync(async () =>
                {
                    var task = pool.WhenPoolReady(default);
                    pool.MaintainPool();
                    var exception = await Assert.ThrowsAsync<RpcException>(() => task);
                    // If we go unhealthy while waiting, the status code from the RPC is used for the exception.
                    Assert.Equal(StatusCode.Internal, exception.StatusCode);
                });
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task WhenPoolReady_ReleaseSession()
            {
                var pool = CreatePool(false);
                pool.Options.MaximumActiveSessions = 10; // Same as minimum pool size
                var client = (SessionTestingSpannerClient)pool.Client;

                var sessionTask = pool.AcquireSessionAsync(new TransactionOptions(), default);
                var waitTask = pool.WhenPoolReady(default);

                // Even if we wait for a minute, the WhenPoolReady task can't complete due to
                // the limit on MaximumActiveSessions.
                await client.Scheduler.RunForSecondsAsync(60);

                Assert.Equal(TaskStatus.RanToCompletion, sessionTask.Status);
                Assert.Equal(TaskStatus.WaitingForActivation, waitTask.Status);

                // Releasing the session puts it back in the pool directly (with no delays to schedule)
                sessionTask.Result.ReleaseToPool(false);
                // We don't check the status directly, as we need continuations to run, but it should
                // complete pretty quickly. (The timeout is just to avoid the test hanging if there's a bug.)
                Assert.True(waitTask.Wait(1000));
            }

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task ShutdownPoolAsync_AllStatsToZero()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    await pool.WhenPoolReady(default);
                    var session = await pool.AcquireSessionAsync(new TransactionOptions(), default);

                    // Shut down the pool, but keep one active session for now
                    Task task = pool.ShutdownPoolAsync(default);
                    // Note: only a 20 second delay to avoid a real-time timeout. The shutdown task
                    // will schedule a timer once per second, so if we have a 200ms delay per iteration,
                    // that means we spend 4 seconds here. That's okay, but we don't want it to be more.
                    await client.Scheduler.Delay(TimeSpan.FromSeconds(20));
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

            [Fact(Timeout = TestTimeoutMilliseconds)]
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

            [Fact(Timeout = TestTimeoutMilliseconds)]
            public async Task ShutdownPoolAsync_CannotAcquireAfterShutdown()
            {
                var pool = CreatePool(true);
                var client = (SessionTestingSpannerClient)pool.Client;
                await client.Scheduler.RunAsync(async () =>
                {
                    await pool.WhenPoolReady(default);
                    await pool.ShutdownPoolAsync(default);
                    await Assert.ThrowsAsync<InvalidOperationException>(() => pool.AcquireSessionAsync(new TransactionOptions(), default));
                });
            }

            [Fact]
            public async Task BatchCreateSession_WithDatabaseRoleAsync()
            {
                var spannerClientMock = new SessionTestingSpannerClient();
                var parent = new SessionPool(spannerClientMock, new SessionPoolOptions());
                var targetedSessionPool = new TargetedSessionPool(parent, SessionPoolSegmentKey.Create(s_databaseName).WithDatabaseRole(s_databaseRole), acquireSessionsImmediately: true);

                // Give the pool a minute to fill up
                await spannerClientMock.Scheduler.RunForSecondsAsync(60);

                BatchCreateSessionsRequest batchCreateSessionsRequest;
                Assert.True(spannerClientMock.BatchCreateSessionRequests.TryDequeue(out batchCreateSessionsRequest));
                Assert.Equal(s_databaseRole, batchCreateSessionsRequest.SessionTemplate.CreatorRole);
                Assert.Equal(s_databaseName, batchCreateSessionsRequest.DatabaseAsDatabaseName);
            }

            private async Task<List<PooledSession>> AcquireAllSessionsAsync(TargetedSessionPool pool)
            {
                var tasks = AcquireSessionTasks(pool, pool.Options.MaximumActiveSessions);
                await Task.WhenAll(tasks);
                return tasks.Select(t => t.Result).ToList();
            }

            private List<Task<PooledSession>> AcquireSessionTasks(TargetedSessionPool pool, int sessionsToAcquiere) => 
                Enumerable
                .Range(0, sessionsToAcquiere)
                .Select(_ => pool.AcquireSessionAsync(new TransactionOptions(), default))
                .ToList();
        }
    }
}
