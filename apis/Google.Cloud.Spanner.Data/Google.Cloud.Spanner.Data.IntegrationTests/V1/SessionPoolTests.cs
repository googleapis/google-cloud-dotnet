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
using Google.Cloud.Spanner.Data;
using Google.Cloud.Spanner.Data.IntegrationTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.V1.IntegrationTests
{
    [Collection(nameof(AllTypesTableFixture))]
    [CommonTestDiagnostics]
    public class SessionPoolTests
    {
        private readonly AllTypesTableFixture _fixture;

        public SessionPoolTests(AllTypesTableFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public async Task SessionRefreshOnRelease()
        {
            var options = new SessionPoolOptions
            {
                MinimumPooledSessions = 5,
                MaximumActiveSessions = 5,
                IdleSessionRefreshDelay = TimeSpan.FromSeconds(10),
                WriteSessionsFraction = 0,
                SessionRefreshJitter = RetrySettings.NoJitter
            };

            await TestWithPool(options, async pool =>
            {
                var cts = new CancellationTokenSource(10000);
                await pool.WhenPoolReady(_fixture.DatabaseName, cts.Token);
                // Upper bound for when we expect we need to refresh.
                var expectedRefreshTime = DateTime.UtcNow + options.IdleSessionRefreshDelay;
                // Acquire all the sessions, which should all have a required refresh time within our upper bound
                var initialSessions = await AcquireSessionsAsync(pool);
                Assert.All(initialSessions, s => Assert.True(s.RefreshTimeForTest <= expectedRefreshTime));

                // Wait for everything to idle out
                await Task.Delay(options.IdleSessionRefreshDelay + TimeSpan.FromSeconds(1));
                Assert.True(DateTime.UtcNow > expectedRefreshTime);

                // Release the sessions, wait for the pool to repopulate, then fetch again
                initialSessions.ForEach(s => s.ReleaseToPool(false));
                cts = new CancellationTokenSource(10000);
                await pool.WhenPoolReady(_fixture.DatabaseName, cts.Token);
                FileLogger.Log(pool.GetStatisticsSnapshot(_fixture.DatabaseName).ToString());
                var refreshedSessions = await AcquireSessionsAsync(pool);

                // We should still have the same sessions...
                Assert.Equal(
                    initialSessions.Select(s => s.SessionName.SessionId).OrderBy(id => id),
                    refreshedSessions.Select(s => s.SessionName.SessionId).OrderBy(id => id));

                // ... but they should all be refreshed now.
                Assert.All(refreshedSessions, s => Assert.True(s.RefreshTimeForTest > expectedRefreshTime));
                // Release the sessions so they can be deleted when we shut down the pool.
                refreshedSessions.ForEach(s => s.ReleaseToPool(false));
            });

            async Task<List<PooledSession>> AcquireSessionsAsync(SessionPool pool)
            {
                var ret = new List<PooledSession>();
                for (int i = 0; i < options.MinimumPooledSessions; i++)
                {
                    var cts = new CancellationTokenSource(1000);
                    ret.Add(await pool.AcquireSessionAsync(_fixture.DatabaseName, null, cts.Token));
                }
                return ret;
            }
        }

        [SkippableFact]
        public async Task SessionLabels()
        {
            Skip.If(_fixture.RunningOnEmulator, "Emulator does not support filtering by labels");
            string guid = Guid.NewGuid().ToString().ToLowerInvariant();
            var options = new SessionPoolOptions
            {
                SessionLabels =
                {
                    { "guid", guid },
                    { "key1", "value1" }
                }
            };
            await TestWithPool(options, async pool =>
            {
                var session = await pool.AcquireSessionAsync(_fixture.DatabaseName, new TransactionOptions(), CancellationToken.None);

                // Use the underlying client to list the sessions with the labels we've specified.
                SpannerClient client = pool.Client;
                var listRequest = new ListSessionsRequest
                {
                    Database = _fixture.DatabaseName.ToString(),
                    Filter = $"labels.guid:{guid}"
                };
                var matchingSessions = client.ListSessions(listRequest).ToList();

                // The session we've acquired from the pool should be there.
                Assert.Contains(matchingSessions, s => s.SessionName == session.SessionName);
                Assert.All(matchingSessions, s => Assert.True(s.Labels.ContainsKey("key1")));
                Assert.All(matchingSessions, s => Assert.True(s.Labels.ContainsKey("guid")));
                // All the matching sessions should also the label we searched for.
                Assert.All(matchingSessions, s => Assert.Equal(guid, s.Labels["guid"]));
                // All the matching sessions should also have the other label.
                Assert.All(matchingSessions, s => Assert.Equal("value1", s.Labels["key1"]));
                // The only sessions matching our labels should be the ones we've created
                Assert.InRange(matchingSessions.Count, 1, options.MinimumPooledSessions + 1);

                session.ReleaseToPool(false);
            });
        }

        private async Task TestWithPool(SessionPoolOptions options, Func<SessionPool, Task> test)
        {
            var poolManager = SessionPoolManager.Create(options);
            var pool = await poolManager.AcquireSessionPoolAsync(_fixture.SpannerClientCreationOptions);
            try
            {
                await test(pool);
            }
            finally
            {
                // Wait for up to 10 seconds for the pool to shut down, but don't fail if it doesn't. This would
                // usually be because the test failed and didn't get it into a "clean shutdown" situation.
                await Task.WhenAny(
                    pool.ShutdownPoolAsync(_fixture.DatabaseName, CancellationToken.None),
                    Task.Delay(10000));
            }
        }
    }
}
