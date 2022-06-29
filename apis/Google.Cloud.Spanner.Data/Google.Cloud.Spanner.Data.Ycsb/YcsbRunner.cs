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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Grpc.Core;

namespace Google.Cloud.Spanner.Data.Ycsb
{
    internal abstract class YcsbRunner
    {
        protected const string AppVersion = "v1.0";
        protected const string ClientType = "client_type";
        protected const string Operationcount = "operationcount";
        protected const string QpstestTime = "qpstesttime";
        protected const string DebugMode = "debugmode";
        protected const string NumWorker = "num_worker";
        protected const string Prewarm = "prewarm";
        protected const string TargetQps = "qpstarget";
        protected const string GrpcInline = "grpcinline";

        protected static readonly ConcurrentDictionary<string, object> Options =
            new ConcurrentDictionary<string, object>();

        private static readonly Random s_globalRandom = new Random(Environment.TickCount);

        protected static readonly ThreadLocal<Random> Rand = new ThreadLocal<Random>(
            () =>
            {
                lock (s_globalRandom)
                {
                    return new Random(s_globalRandom.Next());
                }
            });

        private static readonly ThreadLocal<byte[]> s_byteBuffer = new ThreadLocal<byte[]>(() => new byte[75]);
        private static double s_total;

        private long _totalOperations;
        private string _templateFile;

        protected static bool IsDebugMode { get; private set; }

        protected abstract List<Operation> Operations { get; }

        protected int Run(string[] args)
        {
            if (!TryParseArguments(args))
            {
                return -1;
            }
            LoadConfigFile();
            ValidateArguments();
            InitializeSettings();

            DebugMessage("prewarm...");
            Task.WhenAll(Enumerable.Range(1, GetOptionWithDefault(Prewarm, 0)).Select(x => PreWarmOneInstance()))
                .WaitWithUnwrappedExceptions();

            DebugMessage("running...");
            var overallTime = Stopwatch.StartNew();
            if (Options.ContainsKey(TargetQps))
            {
                //target qps version
                RunWorkerWithQps(GetOption<double>(TargetQps), TimeSpan.FromSeconds(GetOption<int>(QpstestTime)))
                    .WaitWithUnwrappedExceptions();
            }
            else
            {
                //target worker version
                RunWithTargetWorkers(GetOption<int>(NumWorker)).WaitWithUnwrappedExceptions();
            }
            PrintResults(overallTime.ElapsedMilliseconds);

            return 0;
        }

        protected virtual void InitializeSettings()
        {
#if NET462
            // Grpc.Core configuration
            GrpcEnvironment.SetCompletionQueueCount(GetOption<int>(NumWorker));
            GrpcEnvironment.SetThreadPoolSize(GetOption<int>(NumWorker));
            GrpcEnvironment.SetHandlerInlining(GetOptionWithDefault(GrpcInline, false));
#endif
            AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
            {
                Console.Error.WriteLine($"ERROR {eventArgs.ExceptionObject.ToString()}");
            };

            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

            foreach (var kvp in Options)
            {
                DebugMessage($"key:{kvp.Key} = {kvp.Value}");
            }
        }

        protected virtual Task PreWarmOneInstance() => Task.FromResult(0);

        /// <summary>
        /// Targets a specific QPS by executing multiple subtasks.
        /// (this is from C# spanner stress tests)
        /// </summary>
        private async Task RunWorkerWithQps(double queriesPerSecond, TimeSpan testTime)
        {
            var sw = Stopwatch.StartNew();
            var all = new List<Task>();

            while (sw.Elapsed < testTime)
            {
                if (sw.Elapsed.TotalSeconds * queriesPerSecond > all.Count)
                {
                    var operation = ChooseOperation();
                    try
                    {
                        all.Add(operation.ExecuteAsync());
                    }
                    catch (Exception e)
                    {
                        DebugMessage($"This error is being ignored and we are continuing the test: {e.Message}");
                    }
                }
                else
                {
                    await Task.Yield();
                }
            }

            var timeout = Task.Delay(TimeSpan.FromSeconds(10));
            await Task.WhenAny(Task.WhenAll(all), timeout);
            _totalOperations = all.Count;
        }

        /// <summary>
        /// Runs the test with multiple parallel subtasks equal to at most "numworkers"
        /// </summary>
        private async Task RunWithTargetWorkers(int numWorkers)
        {
            var parallelWorkers = new List<Task>();
            var operation = ChooseOperation();
            long operationsRemaining = _totalOperations;
            while (operationsRemaining > 0)
            {
                await Task.Yield();
                parallelWorkers.Add(operation.ExecuteAsync());
                if (operationsRemaining % 1000 == 0)
                {
                    DebugMessage($"{operationsRemaining} operations remaining.");
                }
                operation = ChooseOperation();
                if (parallelWorkers.Count == numWorkers)
                {
                    try
                    {
                        parallelWorkers.Remove(await Task.WhenAny(parallelWorkers).ConfigureAwait(false));
                    }
                    catch (Exception e)
                    {
                        DebugMessage($"This error is being ignored and we are continuing the test: {e.Message}");
                        parallelWorkers.Clear(); //start over.
                    }
                }
                operationsRemaining--;
            }
        }

        private Operation ChooseOperation()
        {
            double operationTarget = Rand.Value.NextDouble() * s_total;
            var operation = 0;
            operationTarget -= Operations[operation].Proportion;
            while (operationTarget > 0 && operation < Operations.Count)
            {
                operation++;
                if (operation < Operations.Count)
                {
                    operationTarget -= Operations[operation].Proportion;
                }
            }
            return Operations[Math.Min(operation, Operations.Count - 1)];
        }

        private void PrintResults(long totalElapsedMillis)
        {
            Console.WriteLine($"[OVERALL], RunTime(ms), {totalElapsedMillis}");
            Console.WriteLine(
                $"[OVERALL], Throughput(ops/sec), {1000 * _totalOperations / totalElapsedMillis}");

            foreach (var operation in Operations)
            {
                operation.PrintResults();
            }
            Logger.DefaultLogger.LogPerformanceData();
        }

        internal static string GenerateRandomString()
        {
            Rand.Value.NextBytes(s_byteBuffer.Value);
            return Convert.ToBase64String(s_byteBuffer.Value);
        }

        private void LoadConfigFile()
        {
            foreach (string line in File.ReadLines(_templateFile))
            {
                if (line.StartsWith("#"))
                {
                    continue;
                }
                var kvp = line.Split('=');
                if (kvp.Length == 2)
                {
                    Options[kvp[0].ToLowerInvariant()] = kvp[1];
                }
            }
            Options["AppVersion"] = AppVersion; //this is just for verification purposes if this app gets updated.
        }

        protected virtual void ValidateArguments()
        {
            s_total = Operations.Select(x => x.Proportion).Sum();
            _totalOperations = GetOption<long>(Operationcount);
            if (GetOption<string>(ClientType) != "dotnet")
            {
                Console.Error.WriteLine("Expected client_type=dotnet");
                throw new InvalidOperationException();
            }
        }

        protected static T GetOptionWithDefault<T>(string optionName, T defaultValue)
            => !Options.ContainsKey(optionName) ? defaultValue : GetOption<T>(optionName);

        protected static T GetOption<T>(string optionName)
        {
            if (!Options.ContainsKey(optionName))
            {
                throw new InvalidOperationException($"Argument {optionName} was not specified, but required.");
            }
            var value = Options[optionName];
            if (value is T)
            {
                return (T) value;
            }
            var parsedValue = (T) Convert.ChangeType(value, typeof(T));
            Options[optionName] = parsedValue;
            return parsedValue;
        }

        private bool TryParseArguments(IReadOnlyList<string> args)
        {
            if (args == null || args.Count == 0 || args[0] != "run")
            {
                PrintUsage();
                return false;
            }

            if (args[2] != "-P" || args.Count < 4)
            {
                PrintUsage();
                return false;
            }

            _templateFile = args[3];
            if (!File.Exists(_templateFile))
            {
                Console.Error.WriteLine($"File {_templateFile} does not exist!");
                PrintUsage();
                return false;
            }

            if (args.Count % 2 != 0)
            {
                //wierd error, user had a -p without another value or had an extra space in a value causing it
                //to be misread.
                Console.Error.WriteLine("Error parsing argument values.");
                PrintUsage();
                return false;
            }

            for (var i = 4; i < args.Count; i += 2)
            {
                if (args[i] != "-p")
                {
                    Console.Error.WriteLine($"Expected a '-p' at argument {(i - 1) / 2}");
                    PrintUsage();
                    return false;
                }
                var keyValue = args[i + 1].Split('=');
                if (keyValue.Length != 2)
                {
                    Console.Error.WriteLine($"Unable to parse key/value for arg {(i - 1) / 2}");
                    PrintUsage();
                    return false;
                }
                Options[keyValue[0].ToLowerInvariant()] = keyValue[1];
            }
            IsDebugMode = Options.ContainsKey(DebugMode);
            return true;
        }

        protected void DebugMessage(string message)
        {
            if (IsDebugMode)
            {
                Console.WriteLine(message);
            }
        }

        protected void PrintUsage()
            => Console.Error.WriteLine(
                "Usage:\n dotnet Google.Cloud.Spanner.Data.Ycsb.dll run spanner -P <relative_path_to_template_file> [-p property=value]...");

        [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
        private static double Variance(IEnumerable<double> source)
        {
            if (!source.Any())
            {
                return 0;
            }
            double mean = source.Average();
            return source.Select(d => (d - mean) * (d - mean)).Average();
        }

        protected class Operation
        {
            // Each entry is in milliseconds for one operation.
            public ConcurrentBag<double> Latencies { get; } = new ConcurrentBag<double>();

            // Name corresponds to the name printed out in results for this operation.
            public string Name { get; }

            // The fractional share of total executions that run this operation.
            // If the total of all proportions does not equal '1.0', then it will be 'normalized'
            public double Proportion => GetOption<double>(ProportionField);

            // The actual operation to execute asynchronously.
            public Func<ConcurrentBag<double>, Task> Action { get; }

            // The config property name for calculating "proportion"
            public string ProportionField { get; }

            public Operation(string proportionField, Func<ConcurrentBag<double>, Task> action)
            {
                ProportionField = proportionField;
                Name = proportionField.Replace("proportion", "").ToUpperInvariant();
                Action = action;
            }

            public Task ExecuteAsync() => Action(Latencies);

            public void PrintResults()
            {
                var sortedlatencies = Latencies.DefaultIfEmpty(0).OrderByDescending(x => x).ToList();
                Console.WriteLine($"[{Name}], Operations, {Latencies.Count}");
                Console.WriteLine(
                    $"[{Name}], AverageLatency(us), {Latencies.DefaultIfEmpty(0).Average() * 1000}");
                Console.WriteLine($"[{Name}], LatencyVariance(us), {Variance(sortedlatencies) * 1000}");
                Console.WriteLine(
                    $"[{Name}], MinLatency(us), {sortedlatencies.LastOrDefault() * 1000}");
                Console.WriteLine(
                    $"[{Name}], MaxLatency(us), {sortedlatencies.FirstOrDefault() * 1000}");
                Console.WriteLine(
                    $"[{Name}], 50thPercentileLatency(us), {sortedlatencies.Skip((int) Math.Floor(Latencies.Count * .5)).First() * 1000}");
                Console.WriteLine(
                    $"[{Name}], 95thPercentileLatency(us), {sortedlatencies.Skip((int) Math.Floor(Latencies.Count * .05)).First() * 1000}");
                Console.WriteLine(
                    $"[{Name}], 99thPercentileLatency(us), {sortedlatencies.Skip((int) Math.Floor(Latencies.Count * .01)).First() * 1000}");
                Console.WriteLine(
                    $"[{Name}], 99.9thPercentileLatency(us), {sortedlatencies.Skip((int) Math.Floor(Latencies.Count * .001)).First() * 1000}");
                Console.WriteLine($"[{Name}], Return=OK, {Latencies.Count}");
                //bucket.
                var sortedLatencies = Latencies.OrderBy(x => x).ToList();
                var latencyIndex = 0;
                var bucket = 0;
                for (; bucket < GetOptionWithDefault("histogram.buckets", 0L); bucket++)
                {
                    var count = 0;
                    while (latencyIndex < sortedLatencies.Count && sortedLatencies[latencyIndex] <= bucket)
                    {
                        count++;
                        latencyIndex++;
                    }
                    Console.WriteLine($"[{Name}], {bucket}, {count}");
                }
                Console.WriteLine($"[{Name}], >{bucket}, {sortedLatencies.Count - latencyIndex}");
            }
        }
    }
}
