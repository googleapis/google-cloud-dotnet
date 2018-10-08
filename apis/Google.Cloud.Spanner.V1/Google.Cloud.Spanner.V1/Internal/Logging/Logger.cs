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

using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1.Internal.Logging
{
    // TODO: Clearer separation between default implementation and interface.
    // (Use the EF provider and default logger to drive the design.)

    /// <summary>
    /// This is an internal class and is not intended to be used by external code.
    /// </summary>
    public abstract class Logger
    {
        private static Logger s_defaultLogger = new DefaultLogger();
        private int _perfLoggingTaskEnabled;
        private readonly Dictionary<string, PerformanceTimeEntry> _perfCounterDictionary
            = new Dictionary<string, PerformanceTimeEntry>();

        /// <summary>
        /// This is an internal property and is not intended to be used by external code.
        /// </summary>
        public static Logger DefaultLogger => Interlocked.CompareExchange(ref s_defaultLogger, null, null);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        /// <param name="instance">The new default logger. Must not be null.</param>
        public static void SetDefaultLogger(Logger instance)
        {
            GaxPreconditions.CheckNotNull(instance, nameof(instance));
            Interlocked.Exchange(ref s_defaultLogger, instance);
        }

        /// <summary>
        /// This is an internal property and is not intended to be used by external code.
        /// </summary>
        public LogLevel LogLevel { get; set; } = LogLevel.None;

        /// <summary>
        /// This is an internal property and is not intended to be used by external code.
        /// </summary>
        public bool LogPerformanceTraces { get; set; }

        /// <summary>
        /// This is an internal property and is not intended to be used by external code.
        /// </summary>
        public virtual bool EnableSensitiveDataLogging { get; set; }

        /// <summary>
        /// This is an internal property and is not intended to be used by external code.
        /// </summary>
        public TimeSpan PerformanceTraceLogInterval { get; set; } = TimeSpan.Zero;

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void LogPerformanceData()
        {
            if (LogPerformanceTraces)
            {
                LogPerformanceDataImpl();
            }
        }

        /// <summary>
        /// Performs the real performance logging.
        /// </summary>
        private void LogPerformanceDataImpl()
        {
            lock (_perfCounterDictionary)
            {
                if (_perfCounterDictionary.Count == 0)
                {
                    return;
                }
                var message = new StringBuilder();
                var metricList = new SortedList<string, string>();
                message.AppendLine("Spanner performance metrics:");

                foreach (var kvp in _perfCounterDictionary)
                {
                    //to make the tavg correct, we re-record the last value at the current timestamp.
                    UpdateTimeWeightedAvg(kvp.Value, DateTime.UtcNow);

                    //log it.
                    metricList.Add(
                        kvp.Key,
                        $" {kvp.Key}({kvp.Value.Instances}) tavg={kvp.Value.TimeWeightedAverage} " +
                        $"avg={kvp.Value.Average} max={kvp.Value.Maximum} min={kvp.Value.Minimum}" +
                        $" last={kvp.Value.Last}");

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

                foreach (string s in metricList.Values)
                {
                    message.AppendLine(s);
                }

                LogPerformanceMessage(message.ToString());
            }
        }

        /// <summary>
        /// This is an internal property and is not intended to be used by external code.
        /// </summary>
        public bool ResetPerformanceTracesEachInterval { get; set; } = true;

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public abstract void LogPerformanceMessage(string message);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public virtual void Debug(string message) =>
            Log(LogLevel.Debug, message, null);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public virtual void Debug(Func<string> messageFunc) =>
            Log(LogLevel.Debug, messageFunc, null);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public virtual void Info(string message) =>
            Log(LogLevel.Info, message, null);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public virtual void Info(Func<string> messageFunc) =>
            Log(LogLevel.Info, messageFunc, null);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void SensitiveInfo(Func<string> messageFunc)
        {
            if (EnableSensitiveDataLogging)
            {
                Info(messageFunc);
            }
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public virtual void Warn(string message, Exception exception = null) =>
            Log(LogLevel.Warn, message, exception);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public virtual void Warn(Func<string> messageFunc, Exception exception = null) =>
            Log(LogLevel.Warn, messageFunc, exception);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public virtual void Error(string message, Exception exception = null) =>
            Log(LogLevel.Error, message, exception);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public virtual void Error(Func<string> messageFunc, Exception exception = null) =>
            Log(LogLevel.Error, messageFunc, exception);

        private void Log(LogLevel level, string message, Exception exception)
        {
            if (LogLevel >= level)
            {
                WriteLine(level, exception == null ? message : $"{message}, Exception = {exception}");
            }
        }

        private void Log(LogLevel level, Func<string> messageFunc, Exception exception)
        {
            if (LogLevel >= level)
            {
                string message = messageFunc();
                WriteLine(level, exception == null ? message : $"{message}, Exception = {exception}");
            }
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void LogPerformanceCounter(string name, Func<double> valueFunc)
        {
            if (LogPerformanceTraces)
            {
                LogPerformanceCounter(name, x => valueFunc());
            }
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void LogPerformanceCounterFn(string name, Func<double, double> valueFunc)
        {
            if (LogPerformanceTraces)
            {
                LogPerformanceCounter(name, valueFunc);
            }
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        protected abstract void WriteLine(LogLevel level, string message);

        private async Task PerformanceLogAsync()
        {
            while (true)
            {
                // While this method is only started once performance logging is turned on,
                // we also allow performance logging to be turned off.
                // If that happens, we'll just poll every second to see if it was turned back on.
                // TODO: if/when we expose profile stats publicly, we should end and restart
                // the task properly.
                var delay = PerformanceTraceLogInterval != TimeSpan.Zero ? PerformanceTraceLogInterval : TimeSpan.FromSeconds(1);
                await Task.Delay(delay).ConfigureAwait(false);

                // FIXME: Should be LogPerformanceTraces, but we never disable that...
                if (PerformanceTraceLogInterval != TimeSpan.Zero)
                {
                    LogPerformanceDataImpl();
                }
            }
        }

        private void RecordEntryValue(PerformanceTimeEntry entry, Func<double, double> valueFunc)
        {
            lock (entry)
            {
                var value = valueFunc(entry.Last);
                var total = entry.Instances * entry.Average;
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

        private void UpdateTimeWeightedAvg(PerformanceTimeEntry entry, DateTime now)
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

        private void LogPerformanceCounter(string name, Func<double, double> valueFunc)
        {
            if (Interlocked.CompareExchange(ref _perfLoggingTaskEnabled, 1, 0) == 0)
            {
                //kick off perf logging.
                Task.Run(PerformanceLogAsync);
            }

            lock (_perfCounterDictionary)
            {
                if (!_perfCounterDictionary.TryGetValue(name, out PerformanceTimeEntry entry))
                {
                    entry = new PerformanceTimeEntry();
                    _perfCounterDictionary[name] = entry;
                }
                RecordEntryValue(entry, valueFunc);
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
