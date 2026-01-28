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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Common.V1;
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
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
            var pool = new SessionPool(mock, new SessionPoolOptions());
            var mode = ModeOneofCase.ReadOnly;

            var session = pool.CreateDetachedSession(s_sampleSessionName, s_sampleTransactionId, mode);

            Assert.Equal(s_sampleSessionName, session.SessionName);
            Assert.Equal(s_sampleTransactionId, session.TransactionId);
            logger.AssertNoWarningsOrErrors();
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

            // We can get sessions for this database but it will for a new underlying session
            acquisitionTask = sessionPool.AcquireSessionAsync(s_sampleDatabaseName, new TransactionOptions(), default);
            await client.Scheduler.RunAsync(TimeSpan.FromMinutes(1));
            var session2 = await acquisitionTask;
            session2.ReleaseToPool(false);
            Assert.NotEqual(session.SessionName, session2.SessionName);

            // We can get sessions for another DB as well
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

        // TODO: Would this be useful in CommonTesting?
        /// <summary>
        /// Logger which retains log entries, allowing us to detect warnings and errors.
        /// All log entries are also written to the test logger.
        /// </summary>
        private class InMemoryLogger : Logger
        {
            private readonly ConcurrentDictionary<LogLevel, List<string>> _logsByLevel = new ConcurrentDictionary<LogLevel, List<string>>();

            internal InMemoryLogger()
            {
                LogLevel = LogLevel.Debug;
            }

            protected override void LogPerformanceEntries(IEnumerable<string> entries)
            {
                // No-op
            }

            protected override void LogImpl(LogLevel level, string message, Exception exception)
            {
                TestLogger.Instance.Log(level, message, exception);
                var list = _logsByLevel.GetOrAdd(level, _ => new List<string>());

                // We don't care about any exceptions at the moment.
                lock (list)
                {
                    list.Add(message);
                }
            }

            internal void AssertNoWarningsOrErrors()
            {
                AssertNoEntries(LogLevel.Error);
                AssertNoEntries(LogLevel.Warn);
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
                    Assert.Fail($"Level {level}:{Environment.NewLine}{string.Join(Environment.NewLine, list)}");
                }
            }
        }
    }
}
