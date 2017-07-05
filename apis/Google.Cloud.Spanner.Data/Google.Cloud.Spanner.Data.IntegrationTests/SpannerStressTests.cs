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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Spanner.V1.Logging;
using Xunit;
using Xunit.Abstractions;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(TestDatabaseFixture))]
    [PerformanceLog]
    public class SpannerStressTests : StressTestBase
    {
        private static int s_rowCounter = 1;
        private static readonly string s_guid = Guid.NewGuid().ToString();
        private static ThreadLocal<Random> s_rnd = new ThreadLocal<Random>(() => new Random(Environment.TickCount));
        private TestDatabaseFixture _testFixture;

        public SpannerStressTests(TestDatabaseFixture testFixture, ITestOutputHelper outputHelper)
        {
            _testFixture = testFixture;
            SpannerOptions.Instance.LogPerformanceTraces = true;
            TestLogger.TestOutputHelper = outputHelper;
        }

        protected override async Task<TimeSpan> TestWriteOneRow(Stopwatch sw)
        {
            using (var connection = await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var localCounter = Interlocked.Increment(ref s_rowCounter);
                var insertCommand = connection.CreateInsertCommand(
                    _testFixture.StressTestTable, new SpannerParameterCollection
                    {
                        {"ID", SpannerDbType.String},
                        {"Title", SpannerDbType.String}
                    });
                insertCommand.Parameters["ID"].Value = $"{s_guid}{localCounter}";
                insertCommand.Parameters["Title"].Value = "Title";

                bool retry = true;
                long delay = 0;
                while (retry)
                {
                    retry = false;
                    try
                    {
                        //The open is implicit here...
                        await insertCommand.ExecuteNonQueryAsync();
                    }
                    catch (Exception e) when (e.IsTransientSpannerFault())
                    {
                        //TODO(benwu): replace with topaz.
                        retry = true;
                        Console.WriteLine("retrying due to " + e.Message);
                        delay = delay * 2;
                        delay += s_rnd.Value.Next(100);
                        delay = Math.Min(delay, 5000);
                        await Task.Delay(TimeSpan.FromMilliseconds(delay));
                    }
                }
            }
            return sw.Elapsed;
        }

        [Fact]
        public async Task RunWriteStress()
        {
            //prewarm
            // The maximum roundtrip time for spanner (and mysql) is about 200ms per
            // write.  so if we initialize with the target sustained # sessions,
            // we shouldn't see any more sessions created.
            int countToPreWarm = Math.Min(TargetQps / 4, 800);
            SpannerOptions.Instance.MaximumActiveSessions = Math.Max(countToPreWarm + 50, 400);
            SpannerOptions.Instance.MaximumPooledSessions = Math.Max(countToPreWarm + 50, 400);
            SpannerOptions.Instance.MaximumGrpcChannels = Math.Max(4, 8 * TargetQps / 2000);

            Logger.Instance.Info($"SpannerOptions.Instance.MaximumActiveSessions:{SpannerOptions.Instance.MaximumActiveSessions}");
            Logger.Instance.Info($"SpannerOptions.Instance.MaximumGrpcChannels:{SpannerOptions.Instance.MaximumGrpcChannels}");

            //prewarm step.
            using (await _testFixture.GetTestDatabaseConnectionAsync())
            {
                var all = new List<SpannerConnection>();
                const int increment = 25;
                while (countToPreWarm > 0)
                {
                    var prewarm = new List<SpannerConnection>();
                    var localCount = Math.Min(increment, countToPreWarm);
                    Logger.Instance.Info($"prewarming {localCount} spanner sessions");
                    for (var i = 0; i < localCount; i++)
                    {
                        prewarm.Add(new SpannerConnection(_testFixture.ConnectionString));
                    }
                    await Task.WhenAll(prewarm.Select(x => x.OpenAsync()));
                    await Task.Delay(TimeSpan.FromMilliseconds(250));
                    all.AddRange(prewarm);
                    countToPreWarm -= increment;
                }

                foreach (var preWarmCon in all)
                {
                    preWarmCon.Dispose();
                }
            }

            //now run the test.
            double result = await TestWriteLatencyWithQps(TargetQps, TestDuration);
            Logger.Instance.Info($"Spanner latency= {result}ms");

            ValidatePoolInfo();

            //spanner latency with 100 qps simulated is usually around 75ms.
            Assert.InRange(result, 0, 150);
        }
    }
}