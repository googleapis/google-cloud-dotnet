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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
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
        private readonly ConcurrentDictionary<string, PerformanceTimeEntry> _perfCounterDictionary
            = new ConcurrentDictionary<string, PerformanceTimeEntry>();

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
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void LogPerformanceData()
        {
            if (LogPerformanceTraces)
            {
                var snapshot = _perfCounterDictionary.ToArray();
                if (snapshot.Length == 0)
                {
                    return;
                }

                LogPerformanceEntries(snapshot.OrderBy(kvp => kvp.Key).Select(kvp => kvp.Value.ToString()));
            }
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void ResetPerformanceData()
        {
            _perfCounterDictionary.Clear();
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public abstract void LogPerformanceEntries(IEnumerable<string> entries);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void Debug(string message) =>
            Log(LogLevel.Debug, message, null);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void Debug(Func<string> messageFunc) =>
            Log(LogLevel.Debug, messageFunc, null);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void Info(string message) =>
            Log(LogLevel.Info, message, null);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void Info(Func<string> messageFunc) =>
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
        public void Warn(string message, Exception exception = null) =>
            Log(LogLevel.Warn, message, exception);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void Warn(Func<string> messageFunc, Exception exception = null) =>
            Log(LogLevel.Warn, messageFunc, exception);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void Error(string message, Exception exception = null) =>
            Log(LogLevel.Error, message, exception);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void Error(Func<string> messageFunc, Exception exception = null) =>
            Log(LogLevel.Error, messageFunc, exception);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void Log(LogLevel level, string message, Exception exception)
        {
            if (LogLevel >= level)
            {
                LogImpl(level, message, exception);
            }
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void Log(LogLevel level, Func<string> messageFunc, Exception exception)
        {
            if (LogLevel >= level)
            {
                string message = messageFunc();
                LogImpl(level, message, exception);
            }
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        protected abstract void LogImpl(LogLevel level, string message, Exception exception);

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void LogPerformanceCounter(string name, double value)
        {
            if (LogPerformanceTraces)
            {
                LogPerformanceCounterImpl(name, x => value);
            }
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void LogPerformanceCounter(string name, Func<double> valueFunc)
        {
            if (LogPerformanceTraces)
            {
                LogPerformanceCounterImpl(name, x => valueFunc());
            }
        }

        /// <summary>
        /// This is an internal method and is not intended to be used by external code.
        /// </summary>
        public void LogPerformanceCounter(string name, Func<double, double> valueFunc)
        {
            if (LogPerformanceTraces)
            {
                LogPerformanceCounterImpl(name, valueFunc);
            }
        }

        private void LogPerformanceCounterImpl(string name, Func<double, double> valueFunc)
        {
            var entry = _perfCounterDictionary.GetOrAdd(name, key => new PerformanceTimeEntry(key));
            var value = valueFunc(entry.Last);
            lock (entry)
            {
                var total = entry.Instances * entry.Average;
                entry.Instances++;
                entry.Average = (total + value) / entry.Instances;
                entry.Maximum = entry.LastMeasureTime == default(DateTime) ? value : Math.Max(entry.Maximum, value);
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
                // For periodically sampled values, we take an average by weighting it with the time since the last
                // measurement, effectively assuming that the value has been "the new value" for all of the preceding
                // time. For example, consider a "number of active sessions" statistic:
                // t=0 value=0
                // t=1 value=10 (tavg=10)
                // t=2 value=15 (tavg=12.5 - we think of it as having been 10 for 1 second and 15 for 1 second)
                // t=6 value=20 (tavg=17.5 - we think of it as having been 12.5 for 2 seconds and 20 for 4 seconds)
                if (entry.LastMeasureTime != default(DateTime))
                {
                    var deltaTime = now - entry.LastMeasureTime;
                    var milliSoFar = entry.TotalTime.TotalMilliseconds;
                    entry.TotalTime += deltaTime;
                    entry.TimeWeightedAverage = (milliSoFar * entry.TimeWeightedAverage + entry.Last * deltaTime.TotalMilliseconds) /
                                                entry.TotalTime.TotalMilliseconds;
                }
            }
        }

        private class PerformanceTimeEntry
        {
            public string Name { get; set; }
            public int Instances { get; set; }
            public double Average { get; set; }
            public double TimeWeightedAverage { get; set; }
            public TimeSpan TotalTime { get; set; }
            public double Maximum { get; set; }
            public double Minimum { get; set; }
            public double Last { get; set; }
            public DateTime LastMeasureTime { get; set; }

            public PerformanceTimeEntry(string name) => Name = name;

            /// <inheritdoc />
            public override string ToString()
            {
                // Prevent updates while we're reading
                lock (this)
                {
                    return $"{Name}: ({Instances}) tavg={TimeWeightedAverage} avg={Average} max={Maximum} min={Minimum} last={Last}";
                }
            }
        }
    }
}
