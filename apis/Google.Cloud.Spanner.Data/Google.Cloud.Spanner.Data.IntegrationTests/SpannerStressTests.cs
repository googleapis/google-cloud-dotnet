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
using Google.Cloud.Spanner.V1.Internal.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(SpannerStressTestTableFixture))]
    [PerformanceLog]
    [CommonTestDiagnostics]
    public class SpannerStressTests : StressTestBase
    {
        private static int s_rowCounter = 1;
        private static readonly string s_guid = IdGenerator.FromGuid();
        private static ThreadLocal<Random> s_rnd = new ThreadLocal<Random>(() => new Random(Environment.TickCount));
        private SpannerStressTestTableFixture _fixture;

        public SpannerStressTests(SpannerStressTestTableFixture fixture) =>
            _fixture = fixture;

        private async Task<TimeSpan> TestWriteOneRow(SpannerConnectionStringBuilder connectionStringBuilder, Stopwatch sw)
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
            return sw.Elapsed;
        }

        private async Task<TimeSpan> TestWriteTx(SpannerConnectionStringBuilder connectionStringBuilder, Stopwatch sw)
        {
            await RetryHelpers.ExecuteWithRetryAsync(async () =>
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
            });
            return sw.Elapsed;
        }

        [Fact]
        public Task RunWriteStress() => RunStress(TestWriteOneRow);

        [Fact]
        public Task RunParallelTransactionStress() => RunStress(TestWriteTx);

        private async Task RunStress(Func<SpannerConnectionStringBuilder, Stopwatch, Task<TimeSpan>> writeFunc)
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
            var logger = Logger.DefaultLogger;

            logger.Info("Prewarming session pool for stress test");
            // Prewarm step: allow up to 30 seconds for the session pool to be populated.
            var cancellationToken = new CancellationTokenSource(30000).Token;
            await pool.WaitForPoolAsync(_fixture.DatabaseName, cancellationToken);

            logger.Info($"Prewarm complete. Pool stats: {pool.GetStatisticsSnapshot(_fixture.DatabaseName)}");

            // Now run the test, with performance logging enabled, but without debug logging.
            // (Debug logging can write a lot to our log file, breaking the test.)
            var previousLogLevel = Logger.DefaultLogger.LogLevel;
            Logger.DefaultLogger.LogLevel = V1.Internal.Logging.LogLevel.Info;
            logger.LogPerformanceTraces = true;
            double latencyMs;
            try
            {
                latencyMs = await TestWriteLatencyWithQps(TargetQps, TestDuration, stopwatch => writeFunc(connectionStringBuilder, stopwatch));
                logger.LogPerformanceData();
            }
            finally
            {
                logger.LogLevel = previousLogLevel;
                logger.LogPerformanceTraces = false;
            }
            logger.Info($"Spanner latency = {latencyMs}ms");

            await SessionPoolHelpers.ShutdownPoolAsync(connectionStringBuilder);

            // Spanner latency with 100 qps simulated is usually around 75ms.
            Assert.InRange(latencyMs, 0, 150);
        }
    }
}
