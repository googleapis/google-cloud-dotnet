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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Google.Cloud.Spanner.Data.StressTests
{
    internal static class Program
    {
        private const bool PreWarmSpanner = true;
        private const bool PreWarmMySql = true;

        private const int TargetQps = 100;
        private static readonly TimeSpan s_testDurationMs = TimeSpan.FromSeconds(120);

        public const string SpannerConnectionString =
            "Data Source=projects/spanneref/instances/myspanner/databases/books";

        public const string MySqlConnectionString =
            "Server=104.198.57.196;Database=books;Uid=root;Pwd=;Max Pool Size=400";

        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            //Uncomment the following lines to test session limiting.
            //            SpannerOptions.Instance.MaximumActiveSessions = 5;
            //            SpannerOptions.Instance.MaximumPooledSessions = 5;

            PreWarmInit().Wait();

            Console.WriteLine("Running Spanner...");
            var latency = new SpannerStressTests().TestWriteLatencyWithQps(TargetQps, s_testDurationMs).Result;
            Console.WriteLine("Spanner Latency ms = " + latency);

            Console.WriteLine("Running MYSQL...");
            latency = new MySqlStressTests().TestWriteLatencyWithQps(TargetQps, s_testDurationMs).Result;
            Console.WriteLine("MYSQL Latency ms = " + latency);

            LogPerfInfo();

            Console.WriteLine("press a key to log pool info.");
            Console.ReadLine();
            LogPoolInfo();
        }

        private static async Task PreWarmInit()
        {
            SpannerOptions.Instance.LogLevel = LogLevel.Error;
            var pi = typeof(SpannerOptions).GetProperty("LogPerformanceTraces",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi?.SetValue(SpannerOptions.Instance, true);

            //prewarm
            // The maximum roundtrip time for spanner (and mysql) is about 200ms per
            // write.  so if we initialize with the target sustained # sessions,
            // we shouldn't see any more sessions created.
            int countToPreWarm = Math.Min(TargetQps / 4, 800);
            SpannerOptions.Instance.MaximumActiveSessions = Math.Max(countToPreWarm + 50, 400);
            SpannerOptions.Instance.MaximumPooledSessions = Math.Max(countToPreWarm + 50, 400);
            SpannerOptions.Instance.MaximumGrpcChannels = Math.Max(4, 8 * TargetQps / 2000);

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (PreWarmSpanner)
            {
                Console.WriteLine($"SpannerOptions.Instance.MaximumActiveSessions:{SpannerOptions.Instance.MaximumActiveSessions}");
                Console.WriteLine($"SpannerOptions.Instance.MaximumGrpcChannels:{SpannerOptions.Instance.MaximumGrpcChannels}");
                var all = new List<SpannerConnection>();
                const int increment = 50;
                while (countToPreWarm > 0)
                {
                    var prewarm = new List<SpannerConnection>();
                    var localCount = Math.Min(increment, countToPreWarm);
                    Console.WriteLine($"prewarming {localCount} spanner sessions");
                    for (var i = 0; i < localCount; i++)
                    {
                        prewarm.Add(new SpannerConnection(SpannerConnectionString));
                    }
                    await Task.WhenAll(prewarm.Select(x => x.OpenAsync()));
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    all.AddRange(prewarm);
                    countToPreWarm -= increment;
                }
                foreach (var preWarmCon in all)
                {
                    preWarmCon.Dispose();
                }
            }
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (PreWarmMySql)
            {
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
            }
        }

        /// <summary>
        /// These perf statistics are gathered when LogPerformanceTraces = true.
        /// This is an internal feature for now.
        /// Important statistics here are:
        ///  SpannerTransaction.Commit.Duration: The duration to call spanner server for a commit transaction.
        ///  Transaction.Begin.Duration: The duration to call spanner to begin a transaction.  This value + commit duration should be greater than measured latency
        ///    if our transaction prewarming is working properly.
        ///  Session.CreateTime: The duration to call spanner server for a new session.  This should mostly be done at
        ///    prewarm.  If "Recordings" is more than .25 * TargetQps, then it means additional sessions had to be allocated and the server probably
        ///    started falling behind the target Qps.
        ///  SpannerClient.RawCreateCount: You are looking at "recordings" here to ensure that only `MaximumGrpcChannels` are created.
        ///  Transaction.CacheHit: How many hits we got on prewarmed transactions.
        /// </summary>
        private static void LogPerfInfo()
        {
            var loggerType = Type.GetType("Google.Cloud.Spanner.V1.Logging.Logger, Google.Cloud.Spanner.V1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0");
            var defaultLoggerType = Type.GetType("Google.Cloud.Spanner.V1.Logging.DefaultLogger, Google.Cloud.Spanner.V1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0");

            var logField = loggerType?.GetField("s_instance", BindingFlags.Static | BindingFlags.NonPublic);
            var perfCounterField = defaultLoggerType?.GetField("_perfCounterDictionary", BindingFlags.Instance | BindingFlags.NonPublic);

            var logger = logField?.GetValue(null);
            IDictionary perfCounters = (IDictionary)perfCounterField?.GetValue(logger);
            if (perfCounters != null)
            {
                foreach (var entry in perfCounters.Keys)
                {
                    Console.WriteLine($"{entry}: {perfCounters[entry]}");
                }
            }
        }

        /// <summary>
        /// The purpose of this method is to review the state of both the client (grpc channel) pool and session pool.
        /// The session pool should have sessions perfectly evenly distributed among each channel.
        /// The channel pool at test end should all have refcounts = 0.
        /// </summary>
        private static void LogPoolInfo()
        {
            var clientPool =
                Type.GetType(
                    "Google.Cloud.Spanner.Data.ClientPool, Google.Cloud.Spanner.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0");
            StringBuilder s = new StringBuilder();
            clientPool?.GetMethod("DumpPoolContents",
                    BindingFlags.Static | BindingFlags.NonPublic)
                .Invoke(null, new object[] { s });
            Console.WriteLine(s);

            var sessionPool =
                Type.GetType(
                    "Google.Cloud.Spanner.V1.SessionPool, Google.Cloud.Spanner.V1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0");
            StringBuilder s2 = new StringBuilder();
            sessionPool?.GetMethod("DumpPoolContents",
                    BindingFlags.Static | BindingFlags.NonPublic)
                .Invoke(null, new object[] { s2 });
            Console.WriteLine(s2);
        }
    }
}
