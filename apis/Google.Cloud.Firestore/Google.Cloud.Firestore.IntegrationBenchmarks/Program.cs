// Copyright 2019, Google LLC
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

using Google.Cloud.Storage.V1;
using HdrHistogram;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Firestore.IntegrationBenchmarks
{
    internal static class Program
    {
        private static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine($"Please specify a configuration JSON file");
                return 1;
            }
            string configJson = File.ReadAllText(args[0]);
            var config = JsonConvert.DeserializeObject<Configuration>(configJson);
            var run = new RunInfo { Configuration = config };
            run.Start = DateTime.UtcNow;
            run.Id = run.Start.ToString("yyyyMMddTHHmmss");
            run.Collection = $"{config.CollectionPrefix}-{run.Id}";

            Log("Running test");
            var histogram = RunTest(run);
            run.End = DateTime.UtcNow;
            run.ActualQps = config.Batches / (run.End - run.Start).TotalSeconds;

            var valueAt99 = histogram.GetValueAtPercentile(99.0) / OutputScalingFactor.TimeStampToMilliseconds;

            Log($"Write results for run ID {run.Id}");
            WriteResults(run, histogram);
            Log("Done");
            Console.WriteLine();
            Console.WriteLine("Summary:");
            Console.WriteLine($"Pool size: {config.PoolSize}");
            Console.WriteLine($"Target QPS: {config.TargetQps}");
            Console.WriteLine($"Tasks: {config.TaskCount}");
            Log($"99%: {valueAt99}ms");
            return 0;
        }

        private static LongConcurrentHistogram RunTest(RunInfo run)
        {
            var config = run.Configuration;
            var pool = new RoundRobinPool(config.PoolSize, config.ProjectId);
            var histogram = new LongConcurrentHistogram(1L, TimeStamp.Minutes(10), 4);

            long documentCounter = 0;
            var data = new byte[config.DataSize];
            RandomNumberGenerator.Create().GetBytes(data);

            // Warm the pool up with no throttling
            SemaphoreSlim qpsThrottle = new SemaphoreSlim(config.PoolSize);
            for (int i = 0; i < config.PoolSize; i++)
            {
                WriteBatchAsync().GetAwaiter().GetResult();
            }
            // Discard the warm-up results
            histogram.Reset();

            long batchesLeft = config.Batches;
            long completed = 0;

            var tasks = Enumerable
                .Range(0, config.TaskCount)
                .Select(_ => Task.Run(WriteBatchesAsync))
                .ToArray();

            // Start tasks that we don't need to wait for at the end. (They will complete,
            // but possibly not immediately, and that's fine.)
            Task.Run(PrintDiagnosticsAsync);
            Task.Run(ReleaseThrottleAsync);

            Task.WaitAll(tasks);
            Interlocked.Increment(ref completed);
            return histogram;

            async Task WriteBatchesAsync()
            {
                while (Interlocked.Decrement(ref batchesLeft) >= 0)
                {
                    await WriteBatchAsync();
                }
            }

            async Task WriteBatchAsync()
            {
                var db = pool.GetFirestoreDb();
                var batch = db.StartBatch();
                for (int i = 0; i < config.BatchSize; i++)
                {
                    var documentRef = db.Collection(run.Collection).Document();
                    var document = new SampleDocument
                    {
                        Id = Interlocked.Increment(ref documentCounter),
                        Data = data
                    };
                    batch.Create(documentRef, document);
                }
                await qpsThrottle.WaitAsync();
                long start = Stopwatch.GetTimestamp();
                await batch.CommitAsync();
                long end = Stopwatch.GetTimestamp();
                histogram.RecordValue(Math.Max(1L, end - start));
            }

            async Task ReleaseThrottleAsync()
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                long released = 0;
                // Every ~50ms, see how many more batches we should release
                while (Interlocked.Read(ref completed) == 0)
                {
                    await Task.Delay(50);
                    long targetRelease = (stopwatch.ElapsedTicks * config.TargetQps) / Stopwatch.Frequency;
                    qpsThrottle.Release((int) (targetRelease - released));
                    released = targetRelease;
                }
            }

            async Task PrintDiagnosticsAsync()
            {
                while (Interlocked.Read(ref completed) == 0)
                {
                    Log($"Batches left to start: {Interlocked.Read(ref batchesLeft)}");
                    await Task.Delay(1000);
                }
            }
        }

        private static void WriteResults(RunInfo run, HistogramBase histogram)
        {
            var writer = new StringWriter();
            histogram.OutputPercentileDistribution(writer, outputValueUnitScalingRatio: OutputScalingFactor.TimeStampToMilliseconds);
            Write("hgrm", "text/plain", writer.ToString());
            Write("json", "application/json", JsonConvert.SerializeObject(run, Formatting.Indented));

            void Write(string extension, string contentType, string text)
            {
                string filename = $"run-{run.Id}.{extension}";
                if (run.Configuration.StorageBucket != null)
                {
                    var stream = new MemoryStream(Encoding.UTF8.GetBytes(text));
                    var client = StorageClient.Create();
                    client.UploadObject(run.Configuration.StorageBucket, filename, contentType, stream);
                }
                File.WriteAllText(filename, text);
            }
        }

        private static void Log(string message) =>
            Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: {message}");
    }
}
