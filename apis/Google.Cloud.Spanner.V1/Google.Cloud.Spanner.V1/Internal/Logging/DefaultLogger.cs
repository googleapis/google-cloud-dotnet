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
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Internal.Logging
{
    internal class DefaultLogger : Logger
    {
        private int _perfLoggingTaskEnabled;
        private readonly ConcurrentDictionary<string, PerformanceTimeEntry> _perfCounterDictionary = new ConcurrentDictionary<string, PerformanceTimeEntry>();
        private object _perfLogSyncObject = new object();

        protected virtual void WriteLine(string message)
        {
#if NET45 || NET451
            Trace.TraceInformation(message);
#else
            Console.Error.WriteLine(message);
#endif
        }

        public override void Debug(string message)
        {
            WriteLine(message);
        }

        public override void Info(string message)
        {
            WriteLine(message);
        }

        public override void Warn(string message)
        {
            WriteLine(message);
        }

        public override void Error(string message, Exception exception = null)
        {
            WriteLine(message);
        }

        protected override void LogPerformanceDataImpl()
        {
            lock (_perfLogSyncObject)
            {
                if (!_perfCounterDictionary.IsEmpty)
                {
                    StringBuilder message = new StringBuilder();
                    SortedList metricList = new SortedList();
                    message.AppendLine("Spanner performance metrics:");

                    foreach (var kvp in _perfCounterDictionary)
                    {
                        //to make the tavg correct, we re-record the last value at the current timestamp.
                        UpdateTimeWeightedAvg(kvp.Value, DateTime.UtcNow);

                        //log it.
                        metricList.Add(
                            kvp.Key,
                            $" {kvp.Key}({kvp.Value.Instances}) tavg={kvp.Value.TimeWeightedAverage} avg={kvp.Value.Average} max={kvp.Value.Maximum} min={kvp.Value.Minimum} last={kvp.Value.Last}");

                        //now reset to last.
                        if (ResetPerformanceTracesEachInterval)
                        {
                            lock (kvp.Value)
                            {
                                kvp.Value.Last = 0;
                                kvp.Value.Instances = 0;
                                kvp.Value.TotalTime = default(TimeSpan);
                                kvp.Value.LastMeasureTime = DateTime.UtcNow;
                                kvp.Value.Maximum = 0;
                                kvp.Value.Minimum = 0;
                                kvp.Value.Average = 0;
                                kvp.Value.TimeWeightedAverage = 0;
                            }
                        }
                    }

                    foreach (string s in metricList.GetValueList())
                    {
                        message.AppendLine(s);
                    }

                    WriteLine(message.ToString());
                }
            }
        }

        private async Task PerformanceLogAsync()
        {
            while (true)
            {
                //while this method is only started once performance logging is turned on,
                //we also allow performance logging to be turned off
                //If that happens, we'll just poll every second to see if it was turned back on.
                //TODO(benwu): if/when we expose profile stats publicly, we should end and restart
                // the task properly.
                await Task.Delay(PerformanceTraceLogInterval != TimeSpan.Zero ?
                    PerformanceTraceLogInterval
                    : TimeSpan.FromSeconds(1)
                    ).ConfigureAwait(false);
                if (PerformanceTraceLogInterval.TotalMilliseconds > 0)
                {
                    LogPerformanceDataImpl();
                }
            }
            // ReSharper disable once FunctionNeverReturns
        }

        private void RecordEntryValue(PerformanceTimeEntry entry, Func<double, double> valueFunc)
        {
            lock (entry)
            {
                var value = valueFunc(entry.Last);
                double total = entry.Instances * entry.Average;
                entry.Instances++;
                entry.Average = (total + value) / entry.Instances;
                entry.Maximum = entry.LastMeasureTime == default(DateTime) ? value : Math.Max(entry.Minimum, value);
                entry.Minimum = entry.LastMeasureTime == default(DateTime) ? value : Math.Min(entry.Minimum, value);
                var now = DateTime.UtcNow;
                UpdateTimeWeightedAvg(entry, now);
                entry.LastMeasureTime = now;
                entry.Last = value;
            }
        }

        private static void UpdateTimeWeightedAvg(PerformanceTimeEntry entry, DateTime now)
        {
            lock (entry)
            {
                if (entry.LastMeasureTime != default(DateTime))
                {
                    double milliSoFar = 0;
                    var deltaTime = (now - entry.LastMeasureTime).TotalMilliseconds;
                    milliSoFar += entry.TotalTime.TotalMilliseconds;
                    entry.TotalTime = entry.TotalTime.Add(TimeSpan.FromMilliseconds(deltaTime));
                    entry.TimeWeightedAverage = (milliSoFar * entry.TimeWeightedAverage + entry.Last * deltaTime) /
                                                entry.TotalTime.TotalMilliseconds;
                }
            }
        }

        public override void LogPerformanceCounter(string name, Func<double, double> valueFunc)
        {
            if (Interlocked.CompareExchange(ref _perfLoggingTaskEnabled, 1, 0) == 0)
            {
                //kick off perf logging.
                Task.Run(PerformanceLogAsync);
            }

            lock (_perfLogSyncObject)
            {
                RecordEntryValue(_perfCounterDictionary.GetOrAdd(name, n => new PerformanceTimeEntry()), valueFunc);
            }
        }

        private class PerformanceTimeEntry
        {
            public int Instances { get; set; }
            public double Average { get; set; }
            public double TimeWeightedAverage { get; set; }
            public TimeSpan TotalTime { get; set; }
            public double Maximum { get; set; }
            public double Minimum { get; set; }
            public double Last { get; set; }
            public DateTime LastMeasureTime { get; set; }

            /// <inheritdoc />
            public override string ToString()
            {
                return $"Recordings({Instances}) Average({Average}) TAvg({TimeWeightedAverage})";
            }
        }
    }
}