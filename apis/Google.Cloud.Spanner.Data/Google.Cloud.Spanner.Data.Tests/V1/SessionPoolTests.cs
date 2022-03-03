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
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1.Tests
{
    [FileLoggerBeforeAfterTest]
    public partial class SessionPoolTests
    {
        private const int TestTimeoutMilliseconds = 20000;

        private static readonly DatabaseName s_sampleDatabaseName = new DatabaseName("project", "instance", "database");
        private static readonly DatabaseName s_sampleDatabaseName2 = new DatabaseName("project", "instance", "database2");
        private static readonly SessionName s_sampleSessionName = new SessionName("project", "instance", "database", "session");
        private static readonly ByteString s_sampleTransactionId = ByteString.CopyFromUtf8("transaction-id");

        [Fact]
        public void CreateDetachedSession()
        {
            var logger = new InMemoryLogger();
            var mock = SpannerClientHelpers.CreateMockClient(logger);
            var pool = new SessionPool(mock.Object, new SessionPoolOptions());

            var mode = ModeOneofCase.ReadOnly;
            var session = pool.CreateDetachedSession(s_sampleSessionName, s_sampleTransactionId, mode);
            Assert.Equal(s_sampleSessionName, session.SessionName);
            Assert.Equal(s_sampleTransactionId, session.TransactionId);
            Assert.Equal(mode, session.TransactionMode);
            logger.AssertNoWarningsOrErrors();
        }

        [Fact(Timeout = TestTimeoutMilliseconds)]
        public async Task ScheduledMaintenanceEvictsSessions()
        {
            var client = new SessionTestingSpannerClient();
            var options = new SessionPoolOptions
            {
                // We'll never actually hit a refresh, as the eviction delay is shorter.
                IdleSessionRefreshDelay = TimeSpan.FromMinutes(30),
                PoolEvictionDelay = TimeSpan.FromMinutes(3),
                MaintenanceLoopDelay = TimeSpan.FromMinutes(1),
                SessionEvictionJitter = RetrySettings.NoJitter,
                MinimumPooledSessions = 10,
                MaximumConcurrentSessionCreates = 20,
                WriteSessionsFraction = 0
            };
            var sessionPool = new SessionPool(client, options);
            var acquisitionTask = sessionPool.AcquireSessionAsync(s_sampleDatabaseName, new TransactionOptions(), default);

            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(1));

            // Our session should be ready, the pool should be up to size, and we should
            // have created 11 sessions in total.
            var session = await acquisitionTask;
            var stats = sessionPool.GetStatisticsSnapshot(s_sampleDatabaseName);
            Assert.Equal(10, stats.ReadPoolCount);
            Assert.Equal(11, client.SessionsCreated);
            Assert.Equal(0, client.SessionsDeleted);

            // If we allow the maintenance pool to run until T=5 minutes, we should have evicted
            // all the 10 sessions in the pool and replaced them.
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(4));
            stats = sessionPool.GetStatisticsSnapshot(s_sampleDatabaseName);
            Assert.Equal(10, stats.ReadPoolCount);
            Assert.Equal(21, client.SessionsCreated);
            Assert.Equal(10, client.SessionsDeleted);
        }

        [Fact(Timeout = TestTimeoutMilliseconds)]
        public async Task ScheduledMaintenanceEvictsSessions_DifferentEvictionTimes()
        {
            var client = new SessionTestingSpannerClient();
            var options = new SessionPoolOptions
            {
                // We'll never actually hit a refresh, as the eviction delay is shorter.
                IdleSessionRefreshDelay = TimeSpan.FromMinutes(30),
                PoolEvictionDelay = TimeSpan.FromMinutes(3),
                MaintenanceLoopDelay = TimeSpan.FromMinutes(1),
                SessionEvictionJitter = RetrySettings.NoJitter,
                MinimumPooledSessions = 10,
                MaximumConcurrentSessionCreates = 20,
                WriteSessionsFraction = 0
            };
            var sessionPool = new SessionPool(client, options);
            var acquisitionTask = sessionPool.AcquireSessionAsync(s_sampleDatabaseName, new TransactionOptions(), default);

            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(1));

            // Our session should be ready, the pool should be up to size, and we should
            // have created 11 sessions in total.
            var session = await acquisitionTask;
            var stats = sessionPool.GetStatisticsSnapshot(s_sampleDatabaseName);
            Assert.Equal(10, stats.ReadPoolCount);
            Assert.Equal(11, client.SessionsCreated);
            Assert.Equal(0, client.SessionsDeleted);

            // Force the creation of a newer session by acquiring one.
            // The new one will be created to satisfy the minimum size of the pool
            // and will sit on top of the stack.
            // First move the pool to T=2, so that the new session will be created in T=3
            // so that its eviction time will be T=6 so as to make sure that it's not
            // being evicted when we check at T=5.
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(1));
            acquisitionTask = sessionPool.AcquireSessionAsync(s_sampleDatabaseName, new TransactionOptions(), default);
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(1));
            session = await acquisitionTask;
            stats = sessionPool.GetStatisticsSnapshot(s_sampleDatabaseName);
            Assert.Equal(10, stats.ReadPoolCount);
            Assert.Equal(12, client.SessionsCreated);
            Assert.Equal(0, client.SessionsDeleted);

            // If we allow the maintenance pool to run until T=5 minutes, we should have evicted
            // all the old 9 sessions in the pool and replaced them with 9 new ones.
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(2));
            stats = sessionPool.GetStatisticsSnapshot(s_sampleDatabaseName);
            Assert.Equal(10, stats.ReadPoolCount);
            Assert.Equal(21, client.SessionsCreated);
            Assert.Equal(9, client.SessionsDeleted);
        }

        [Fact(Timeout = TestTimeoutMilliseconds)]
        public async Task ShutdownPoolAsync()
        {
            var client = new SessionTestingSpannerClient();
            var options = new SessionPoolOptions
            {
                IdleSessionRefreshDelay = TimeSpan.FromMinutes(30),
                PoolEvictionDelay = TimeSpan.FromMinutes(30),
                MaintenanceLoopDelay = TimeSpan.FromMinutes(1),
                MinimumPooledSessions = 10,
                MaximumConcurrentSessionCreates = 20,
                WriteSessionsFraction = 0
            };
            var sessionPool = new SessionPool(client, options);
            var acquisitionTask = sessionPool.AcquireSessionAsync(s_sampleDatabaseName, new TransactionOptions(), default);

            // After a minute, we should have a session. Release it immediately for simplicity.
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(1));
            var session = await acquisitionTask;
            session.ReleaseToPool(false);

            // Shut the pool down, and wait a minute. (It won't take that long, as nothing's pending.)
            var shutdownTask = sessionPool.ShutdownPoolAsync(s_sampleDatabaseName, default);
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(1));

            // Now the shutdown task should have completed, and the stats will know that it's shut down.
            await shutdownTask;

            var stats = sessionPool.GetStatisticsSnapshot(s_sampleDatabaseName);
            Assert.True(stats.Shutdown);

            // We can't get sessions any more for this database
            await Assert.ThrowsAsync<InvalidOperationException>(() => sessionPool.AcquireSessionAsync(s_sampleDatabaseName, new TransactionOptions(), default));

            // But we can for a different database. (It shuts down a single database pool, not the whole session pool.)
            var acquisitionTask2 = sessionPool.AcquireSessionAsync(s_sampleDatabaseName2, new TransactionOptions(), default);
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(1));
            await acquisitionTask2;
        }

        [Fact(Timeout = TestTimeoutMilliseconds)]
        public async Task WhenPoolReady()
        {
            var client = new SessionTestingSpannerClient();
            var options = new SessionPoolOptions
            {
                IdleSessionRefreshDelay = TimeSpan.FromMinutes(30),
                PoolEvictionDelay = TimeSpan.FromMinutes(30),
                MaintenanceLoopDelay = TimeSpan.FromMinutes(1),
                MinimumPooledSessions = 10,
                MaximumConcurrentSessionCreates = 20,
                WriteSessionsFraction = 0
            };
            var sessionPool = new SessionPool(client, options);

            // Ask when the pool is ready, which shouldn't take a minute.
            var poolReadyTask = sessionPool.WhenPoolReady(s_sampleDatabaseName, default);
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(1));
            await poolReadyTask;

            // When the pool *is* ready, we should be able to acquire a session directly from the pool,
            // without any further delays.
            await sessionPool.AcquireSessionAsync(s_sampleDatabaseName, new TransactionOptions(), default);            
        }

        [Fact]
        public void GetStatisticsSnapshot_UnrepresentedDatabase()
        {
            var client = new SessionTestingSpannerClient();
            var options = new SessionPoolOptions();
            var sessionPool = new SessionPool(client, options);
            // We haven't used the database in this session pool, so there are no statistics for it.
            Assert.Null(sessionPool.GetStatisticsSnapshot(s_sampleDatabaseName));
        }

        [Fact(Timeout = TestTimeoutMilliseconds)]
        public async Task GetStatisticsSnapshot_MultipleDatabases()
        {
            var client = new SessionTestingSpannerClient();
            var options = new SessionPoolOptions
            {
                MinimumPooledSessions = 10,
            };
            var sessionPool = new SessionPool(client, options);
            var acquisitionTask1 = sessionPool.AcquireSessionAsync(s_sampleDatabaseName, new TransactionOptions(), default);
            var acquisitionTask2 = sessionPool.AcquireSessionAsync(s_sampleDatabaseName2, new TransactionOptions(), default);

            // Wait a little in real time because session creation tasks 
            // are started in a controlled fire and forget manner.
            // Let's give time for stats to be updated.
            await Task.Delay(TimeSpan.FromMilliseconds(250));

            var stats = sessionPool.GetStatisticsSnapshot();
            Assert.Equal(2, stats.PerDatabaseStatistics.Count);
            Assert.Equal(2, stats.TotalActiveSessionCount);
            Assert.Equal(0, stats.TotalReadPoolCount);
            // We've asked for 2 sessions, and the databases "know" they need 10 in the pool (each), so
            // there will be 22 in-flight requests in total.
            Assert.Equal(22, stats.TotalInFlightCreationCount);

            Assert.Contains(stats.PerDatabaseStatistics, s => s.DatabaseName == s_sampleDatabaseName);
            Assert.Contains(stats.PerDatabaseStatistics, s => s.DatabaseName == s_sampleDatabaseName2);

            // xUnit waits until tasks registered in its synchronization context have completed before considering the
            // test itself complete, so we need to let the pool complete the acquisition tasks.
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(2));
        }

        [Fact(Timeout = TestTimeoutMilliseconds)]
        public async Task MaintenanceTaskCompletesWhenPoolIsGarbageCollected()
        {
            var client = new SessionTestingSpannerClient();
            var options = new SessionPoolOptions
            {
                MinimumPooledSessions = 10,
                MaintenanceLoopDelay = TimeSpan.FromMinutes(1)
            };
            var sessionPool = new SessionPool(client, options);
            var waitingTask = sessionPool.WhenPoolReady(s_sampleDatabaseName);
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(5.5));
            await waitingTask;
            var maintenanceCount = client.Logger.GetEntries(LogLevel.Debug).Count(entry => entry.Contains("maintenance"));
            Assert.InRange(maintenanceCount, 5, 6);
            // Make sure the session pool is "alive" up until this point
            GC.KeepAlive(sessionPool);

            var weakReference = new WeakReference<SessionPool>(sessionPool);
            sessionPool = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            
            // Depending on the frameowrk version and the release mode, the pool may or may not be collected
            // at this point. If this weak reference has been cleared, we'll assume the internal one has been
            // as well. Otherwise, this test is pointless but harmless.
            if (!weakReference.TryGetTarget(out _))
            {
                await client.Scheduler.RunAsync(TimeSpan.FromMinutes(10));
                maintenanceCount = client.Logger.GetEntries(LogLevel.Debug).Count(entry => entry.Contains("maintenance"));
                // We're really just checking that at *some* point, we stopped logging.
                // If the maintenance loop hadn't stopped, we'd have 15 entries.
                Assert.InRange(maintenanceCount, 5, 8);
            }
        }

        // TODO: Would this be useful in CommonTesting?
        /// <summary>
        /// Logger which retains log entries, allowing us to detect warnings and errors.
        /// All log entries are also written to the test logger.
        /// </summary>
        private class InMemoryLogger : ILogger
        {
            private readonly ConcurrentDictionary<LogLevel, List<string>> _logsByLevel = new ConcurrentDictionary<LogLevel, List<string>>();

            internal InMemoryLogger()
            {
            }

            public IDisposable BeginScope<TState>(TState state) =>
                throw new NotImplementedException();

            public bool IsEnabled(LogLevel logLevel) => logLevel >= LogLevel.Debug;

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
            {
                var list = _logsByLevel.GetOrAdd(logLevel, _ => new List<string>());
                lock (list)
                {
                    list.Add(formatter(state, exception));
                }
            }

            internal void AssertNoWarningsOrErrors()
            {
                AssertNoEntries(LogLevel.Error);
                AssertNoEntries(LogLevel.Warning);
            }

            internal List<string> GetEntries(LogLevel level)
            {
                var list = _logsByLevel.GetOrAdd(level, _ => new List<string>());
                lock (list)
                {
                    return list.ToList();
                }
            }

            private void AssertNoEntries(LogLevel level)
            {
                var list = GetEntries(level);
                if (list.Count != 0)
                {
                    Assert.True(false, $"Level {level}:{Environment.NewLine}{string.Join(Environment.NewLine, list)}");
                }
            }
        }
    }
}
