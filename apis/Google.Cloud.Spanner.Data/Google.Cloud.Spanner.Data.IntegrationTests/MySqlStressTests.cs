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

#if NET452

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Spanner.V1.Internal.Logging;
using MySql.Data.MySqlClient;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(TestDatabaseFixture))]
    [PerformanceLog]
    public class MySqlStressTests : StressTestBase
    {
        private const string MySqlConnectionString =
            "Server=104.198.57.196;Database=books;Uid=root;Pwd=;Max Pool Size=400";

        private static readonly string s_guid = Guid.NewGuid().ToString();
        private static int s_myCounter = 1;

        private async Task<TimeSpan> TestWriteOneRow(Stopwatch sw)
        {
            using (var connection = new MySqlConnection(MySqlConnectionString))
            {
                var localCounter = Interlocked.Increment(ref s_myCounter);
                await connection.OpenAsync();
                var insertCommand = connection.CreateCommand();
                insertCommand.CommandText = "INSERT INTO bookTable (ID, Title) VALUES (@ID, @Title)";
                insertCommand.Parameters.Add(new MySqlParameter("@ID", MySqlDbType.String));
                insertCommand.Parameters.Add(new MySqlParameter("@Title", MySqlDbType.String));

                insertCommand.Parameters["@ID"].Value = $"{s_guid}{localCounter}";
                insertCommand.Parameters["@Title"].Value = "Title";
                await insertCommand.ExecuteNonQueryAsync();

                await connection.CloseAsync();
            }
            return sw.Elapsed;
        }

        // Uncomment this to run equivalent MySQL benchmarks.
        // You will need to have access to the MYSql database referenced in MySqlConnectionString.
        //[Fact]
        public async Task RunStress()
        {
            //prewarm mysql
            int countToPreWarm = Math.Min(TargetQps / 4, 800);

            var prewarm = new List<MySqlConnection>();
            //(note)mysql never got to use the 400 cap.  It failed at QPS=250 (62 connections).
            for (var i = 0; i < Math.Min(400, countToPreWarm); i++)
            {
                prewarm.Add(new MySqlConnection(MySqlConnectionString));
            }
            await Task.WhenAll(prewarm.Select(x => x.OpenAsync()));
            foreach (var preWarmCon in prewarm)
            {
                preWarmCon.Dispose();
            }

            //now run the test.
            double result = await TestWriteLatencyWithQps(TargetQps, TestDuration, TestWriteOneRow);
            Logger.DefaultLogger.Info(() => $"MySql latency= {result}ms");

            ValidatePoolInfo();

            //mysql latency with 100 qps simulated is usually around 150ms.
            Assert.InRange(result, 0, 250);
        }
    }
}

#endif