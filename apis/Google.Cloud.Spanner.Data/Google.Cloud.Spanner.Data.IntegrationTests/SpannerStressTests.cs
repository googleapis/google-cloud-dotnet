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
        private static readonly ThreadLocal<Random> s_rnd = new ThreadLocal<Random>(() => new Random(Environment.TickCount));
        private readonly SpannerStressTestTableFixture _fixture;

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
            },
            // Mutations are not sent until the transaction is committed.
            // Commit does not support transaction inlining so at this point, 2 RPCs are executed,
            // one for begin transaction and one for commit.
            latencyMultiplier: 2);
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public Task RunParallelTransactionStress()
        {
            // Stress tests are flaky when running against the emulator.

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
            }),
            // Mutations are not sent until the transaction is committed.
            // Commit does not support transaction inlining so at this point, 2 RPCs are executed,
            // one for begin transaction and one for commit.
            latencyMultiplier: 2);
        }

        [Fact]
        [Trait(Constants.SupportedOnEmulator, Constants.No)]
        public async Task RunReadStress()
        {
            // Stress tests are flaky when running against the emulator.

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

            // Only the read RPC is executed here as we are not creating any explicit SpannerTransaction.
            // If no explicit SpannerTransaction is created, a read operation is executed without any
            // transaction selector, that is, no inline transaction but also no need for a begin transaction RPC.
            await RunStress(TestReadOneRow, latencyMultiplier: 1);

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

        private async Task RunStress(Func<SpannerConnectionStringBuilder, Task> func, int latencyMultiplier)
        {
            // Create a new session pool manager to eliminate the chance of a previous test altering the pool state.

            // Prewarm:
            // The maximum roundtrip time for Spanner (and MySQL) is about 200ms per
            // write. If we initialize with the target sustained # sessions,
            // we shouldn't see any more sessions created.
            var options = new ManagedSessionOptions();

            var sessionPoolManager = SessionPoolManager.Create(options);
            var connectionStringBuilder = new SpannerConnectionStringBuilder(_fixture.ConnectionString)
            {
                SessionPoolManager = sessionPoolManager,
                MaximumGrpcChannels = Math.Max(4, 8 * TargetQps / 2000)
            };
            var managedSession = await connectionStringBuilder.AcquireManagedSessionAsync();
            var logger = Logger.DefaultLogger;
            logger.ResetPerformanceData();

            logger.Info("Prewarming session pool for stress test");
            // Prewarm step: allow up to 30 seconds for the session pool to be populated.
            var cancellationToken = new CancellationTokenSource(30000).Token;

            // Now run the test, with performance logging enabled, but without debug logging.
            // (Debug logging can write a lot to our log file, breaking the test.)
            var previousLogLevel = logger.LogLevel;
            logger.LogLevel = V1.Internal.Logging.LogLevel.Info;
            logger.LogPerformanceTraces = true;
            double latencyMs;
            try
            {
                latencyMs = await TestLatencyWithQps(TargetQps, TestDuration, () => func(connectionStringBuilder));
                logger.LogPerformanceData();
            }
            finally
            {
                logger.LogLevel = previousLogLevel;
                logger.LogPerformanceTraces = false;
            }
            logger.Info($"Spanner latency = {latencyMs}ms");

            // Spanner latency with 100 qps simulated is usually around 75ms.
            // We allow for a latency multiplier from callers, because callers may be executing,
            // more than one command. In particular, with inline transactions, mutation commits
            // execute both the begin transaction and the commit RPCs, because commit does not
            // support inline transactions.
            Assert.InRange(latencyMs, 0, 150 * latencyMultiplier);
        }
    }
}
