using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Logging
{
    internal class DefaultLogger : Logger
    {
        private int _perfLoggingTaskEnabled;
        private readonly ConcurrentDictionary<string, PerformanceTimeEntry> _perfCounterDictionary = new ConcurrentDictionary<string, PerformanceTimeEntry>();

        public override void Debug(string message)
        {
#if NET45 || NET451
            Trace.TraceInformation(message);
#else
            Console.Error.WriteLine(message);
#endif
        }

        public override void Info(string message)
        {
#if NET45 || NET451
            Trace.TraceInformation(message);
#else
            Console.Error.WriteLine(message);
#endif
        }

        public override void Warn(string message)
        {
#if NET45 || NET451
            Trace.TraceWarning(message);
#else
            Console.Error.WriteLine(message);
#endif
        }

        public override void Error(string message, Exception exception = null)
        {
#if NET45 || NET451
            Trace.TraceError(message);
#else
            Console.Error.WriteLine(message);
#endif
        }

        private async Task PerformanceLogAsync()
        {
            StringBuilder message = new StringBuilder();
            SortedList metricList = new SortedList();
            while (true)
            {
                message.Clear();
                metricList.Clear();
                await Task.Delay(PerformanceTraceLogInterval);
                message.AppendLine("Spanner performance metrics:");
                foreach (var kvp in _perfCounterDictionary)
                {
                    //to make the tavg correct, we re-record the last value at the current timestamp.
                    UpdateTimeWeightedAvg(kvp.Value, DateTime.UtcNow);

                    //log it.
                    metricList.Add(kvp.Key,
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

#if NET45 || NET451
                Trace.TraceInformation(message.ToString());
#else
                Console.Error.WriteLine(message.ToString());
#endif
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

            RecordEntryValue(_perfCounterDictionary.GetOrAdd(name, n => new PerformanceTimeEntry()), valueFunc);
        }

        class PerformanceTimeEntry
        {
            public int Instances { get; set; }
            public double Average { get; set; }
            public double TimeWeightedAverage { get; set; }
            public TimeSpan TotalTime { get; set; }
            public double Maximum { get; set; }
            public double Minimum { get; set; }
            public double Last { get; set; }
            public DateTime LastMeasureTime { get; set; }
        }
    }
}