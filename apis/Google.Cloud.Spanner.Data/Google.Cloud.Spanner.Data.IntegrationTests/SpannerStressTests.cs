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

using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using Google.Cloud.Spanner.V1;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(SpannerStressTestTableFixture))]
    [CommonTestDiagnostics]
    public class SpannerStressTests : StressTestBase
    {
        private static int s_rowCounter = 1;
        private static readonly string s_guid = IdGenerator.FromGuid();
        private static ThreadLocal<Random> s_rnd = new ThreadLocal<Random>(() => new Random(Environment.TickCount));
        private SpannerStressTestTableFixture _fixture;

        public SpannerStressTests(SpannerStressTestTableFixture fixture) =>
            _fixture = fixture;

        [Fact]
        public Task RunWriteStress()
        {
            return RunStress(async connectionStringBuilder =>
            {
                using (var connection = new SpannerConnection(connectionStringBuilder))
                {
                    var localCounter = Interlocked.Increment(ref s_rowCounter);
                    var insertCommand = connection.CreateInsertCommand(_fixture.TableName);
                    insertCommand.Parameters.Add("ID", SpannerDbType.String, $"{s_guid}{localCounter}");
                    insertCommand.Parameters.Add("Title", SpannerDbType.String, "Title");

                    // This uses an ephemeral transaction, so it's legal to retry it.
                    await insertCommand.ExecuteNonQueryAsyncWithRetry();
                }
            });
        }

        [SkippableFact]
        public Task RunParallelTransactionStress()
        {
            Skip.If(_fixture.RunningOnEmulator, "Stress tests are flaky when running against the emulator");

            return RunStress(connectionStringBuilder => RetryHelpers.ExecuteWithRetryAsync(async () =>
            {
                using (var connection = new SpannerConnection(connectionStringBuilder))
                {
                    await connection.OpenAsync();
                    using (var tx = await connection.BeginTransactionAsync())
                    {
                        var rowsToWrite = Enumerable.Range(0, s_rnd.Value.Next(5) + 1)
                            .Select(x => Interlocked.Increment(ref s_rowCounter)).ToList();

                        var insertCommand = connection.CreateInsertCommand(_fixture.TableName);
                        var idParameter = insertCommand.Parameters.Add("ID", SpannerDbType.String);
                        var titleParameter = insertCommand.Parameters.Add("Title", SpannerDbType.String);
                        titleParameter.Value = "Title";
                        insertCommand.Transaction = tx;

                        var tasks = rowsToWrite.Select(
                            x =>
                            {
                                // This will blow up with dupe primary keys if not threadsafe.
                                idParameter.Value = $"{s_guid}{x}";
                                return insertCommand.ExecuteNonQueryAsync(CancellationToken.None);
                            });

                        // This doesn't really *help* with perf, but is something
                        // somebody will try.
                        await Task.WhenAll(tasks);
                        await tx.CommitAsync();
                    }
                }
            }));
        }

        [SkippableFact]
        public async Task RunReadStress()
        {
            Skip.If(_fixture.RunningOnEmulator, "Stress tests are flaky when running against the emulator");

            // Insert a single row first, but remember the ID so we can read it.
            int localCounter = Interlocked.Increment(ref s_rowCounter);
            string id = $"{s_guid}{localCounter}";
            string title = "Title {id}";
            using (var connection = new SpannerConnection(_fixture.ConnectionString))
            {
                var insertCommand = connection.CreateInsertCommand(_fixture.TableName);
                insertCommand.Parameters.Add("ID", SpannerDbType.String).Value = $"{s_guid}{localCounter}";
                insertCommand.Parameters.Add("Title", SpannerDbType.String).Value = title;
                await insertCommand.ExecuteNonQueryAsyncWithRetry();
            }

            await RunStress(TestReadOneRow);

            async Task TestReadOneRow(SpannerConnectionStringBuilder connectionStringBuilder)
            {
                using (var connection = new SpannerConnection(connectionStringBuilder))
                {
                    var command = connection.CreateSelectCommand($"SELECT Title FROM {_fixture.TableName} WHERE ID=@id");
                    command.Parameters.Add("@ID", SpannerDbType.String).Value = id;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        Assert.True(await reader.ReadAsync());
                        Assert.Equal(title, reader.GetString(0));
                        Assert.False(await reader.ReadAsync());
                    }
                }
            }
        }

        private async Task RunStress(Func<SpannerConnectionStringBuilder, Task> func)
        {
            // Create a new session pool manager to eliminate the chance of a previous test altering the pool state.

            // Prewarm:
            // The maximum roundtrip time for Spanner (and MySQL) is about 200ms per
            // write. If we initialize with the target sustained # sessions,
            // we shouldn't see any more sessions created.
            int countToPreWarm = Math.Min(TargetQps / 4, 800);
            var options = new SessionPoolOptions
            {
                MaximumActiveSessions = Math.Max(countToPreWarm + 50, 400),
                MinimumPooledSessions = countToPreWarm,
                MaximumConcurrentSessionCreates = Math.Min(countToPreWarm, 50)
            };

            var sessionPoolManager = SessionPoolManager.Create(options);
            var connectionStringBuilder = new SpannerConnectionStringBuilder(_fixture.ConnectionString)
            {
                SessionPoolManager = sessionPoolManager,
                MaximumGrpcChannels = Math.Max(4, 8 * TargetQps / 2000)
            };
            var pool = await connectionStringBuilder.AcquireSessionPoolAsync();

            FileLogger.Log("Prewarming session pool for stress test");
            // Prewarm step: allow up to 30 seconds for the session pool to be populated.
            var cancellationToken = new CancellationTokenSource(30000).Token;
            await pool.WhenPoolReady(_fixture.DatabaseName, cancellationToken);

            FileLogger.Log($"Prewarm complete. Pool stats: {pool.GetStatisticsSnapshot(_fixture.DatabaseName)}");

            // Now run the test.
            double latencyMs = await TestLatencyWithQps(TargetQps, TestDuration, () => func(connectionStringBuilder));
            FileLogger.Log($"Spanner latency = {latencyMs}ms");

            await SessionPoolHelpers.ShutdownPoolAsync(connectionStringBuilder);

            // Spanner latency with 100 qps simulated is usually around 75ms.
            Assert.InRange(latencyMs, 0, 150);
        }
    }
}
