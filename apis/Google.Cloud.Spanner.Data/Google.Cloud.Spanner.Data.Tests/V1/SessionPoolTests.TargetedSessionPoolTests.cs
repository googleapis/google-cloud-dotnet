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
using System;
using System.Collections.Generic;
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
        }
    }
}
