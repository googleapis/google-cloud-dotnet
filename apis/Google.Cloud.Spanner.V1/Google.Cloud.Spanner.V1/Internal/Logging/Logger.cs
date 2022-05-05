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
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Google.Cloud.Spanner.V1.Internal.Logging
{
    /// <summary>
    /// Base class for Spanner diagnostic loggers.
    /// </summary>
    /// <remarks>
    /// This is an internal class intended for diagnostic purposes,
    /// and should not be used by general application code. Please read the user guide
    /// page on logging for more details.
    /// </remarks>
    public abstract class Logger
    {
        private static Logger s_defaultLogger = new DefaultLogger();
        private readonly ConcurrentDictionary<string, PerformanceTimeEntry> _perfCounterDictionary
            = new ConcurrentDictionary<string, PerformanceTimeEntry>();

        /// <summary>
        /// Retrieves the default logger.
        /// </summary>
        public static Logger DefaultLogger => Interlocked.CompareExchange(ref s_defaultLogger, null, null);

        /// <summary>
        /// Sets the default logger to be returned by future calls to <see cref="DefaultLogger"/>.
        /// (Any loggers retrieved by that property before are not affected by this method.)
        /// </summary>
        /// <param name="instance">The new default logger. Must not be null.</param>
        public static void SetDefaultLogger(Logger instance)
        {
            GaxPreconditions.CheckNotNull(instance, nameof(instance));
            Interlocked.Exchange(ref s_defaultLogger, instance);
        }

        /// <summary>
        /// Creates a <see cref="Logger"/> instance that delegates all logging requests to
        /// <paramref name="logger"/>.
        /// </summary>
        /// <param name="logger">The logger to delegate to. Must not be null.</param>
        /// <returns>A Spanner logger that delegates to <paramref name="logger"/>.</returns>
        public static Logger ForILogger(ILogger logger) => new MsLogger(logger);

        /// <summary>
        /// The level of logging this logger should perform. For example, if this is set to
        /// <see cref="LogLevel.Info"/> then messages for <see cref="LogLevel.Debug"/> will
        /// be ignored, but messages for <see cref="LogLevel.Info"/>, <see cref="LogLevel.Warn"/>
        /// and <see cref="LogLevel.Error"/> will be logged. This property defaults to
        /// <see cref="LogLevel.None"/>, so no messages are logged.
        /// </summary>
        public LogLevel LogLevel { get; set; } = LogLevel.None;

        /// <summary>
        /// Whether or not performance logging is enabled. This affects the
        /// <see cref="LogPerformanceCounter(string, double)"/> methods, as well as
        /// <see cref="LogPerformanceData"/>. This defaults to false, and should only be set
        /// to true for the purposes of benchmarks and diagnosing performance issues.
        /// </summary>
        public bool LogPerformanceTraces { get; set; }

        /// <summary>
        /// Whether or not potentially sensitive information (such as SQL queries) is recorded. This
        /// affects the behavior of the <see cref="SensitiveInfo(Func{string})"/> method.
        /// </summary>
        public virtual bool EnableSensitiveDataLogging { get; set; }

        /// <summary>
        /// Logs any recorded performance data, if <see cref="LogPerformanceTraces"/> is enabled.
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
        /// Resets all performance data previously recorded by the <see cref="LogPerformanceCounter(string, double)"/> methods.
        /// </summary>
        public void ResetPerformanceData()
        {
            _perfCounterDictionary.Clear();
        }

        /// <summary>
        /// This method is called by <see cref="LogPerformanceData"/> when <see cref="LogPerformanceTraces"/>
        /// is enabled, and should be implemented in derived classes to record performance data.
        /// </summary>
        /// <param name="entries">The entries to log. This is never null, and never empty.</param>
        protected abstract void LogPerformanceEntries(IEnumerable<string> entries);

        /// <summary>
        /// This method is called when a transaction that requested CommitStats is committed.
        /// The default implementation logs the commit stats at log level Info. Derived classes
        /// can override this method to log the statistics at a different level, or to a different
        /// destination.
        /// </summary>
        /// <param name="request">The commit request that requested commit statistics</param>
        /// <param name="response">The response with commit statistics</param>
        public virtual void LogCommitStats(CommitRequest request, CommitResponse response)
        {
            if (response.CommitStats != null)
            {
                Info(() => $"Transaction {request.TransactionId?.ToBase64() ?? ""} mutation count: {response.CommitStats.MutationCount}");
            }
        }

        /// <summary>
        /// Logs a message at a level of <see cref="LogLevel.Debug"/>.
        /// </summary>
        /// <param name="message">The message to log. May be null, in which case this method is a no-op.</param>
        public void Debug(string message) =>
            Log(LogLevel.Debug, message, null);

        /// <summary>
        /// Logs a message at a level of <see cref="LogLevel.Debug"/>.
        /// </summary>
        /// <param name="messageFunc">A function that provides the message to log. This function is only called
        /// after checking <see cref="LogLevel"/>, in order to avoid unnecessary formatting. This may be null
        /// and may return null, but in either of these cases, the call is a no-op.</param>
        public void Debug(Func<string> messageFunc) =>
            Log(LogLevel.Debug, messageFunc, null);

        /// <summary>
        /// Logs a message at a level of <see cref="LogLevel.Info"/>.
        /// </summary>
        /// <param name="message">The message to log. May be null, in which case this method is a no-op.</param>
        public void Info(string message) =>
            Log(LogLevel.Info, message, null);

        /// <summary>
        /// Logs a message at a level of <see cref="LogLevel.Info"/>.
        /// </summary>
        /// <param name="messageFunc">A function that provides the message to log. This function is only called
        /// after checking <see cref="LogLevel"/>, in order to avoid unnecessary formatting. This may be null
        /// and may return null, but in either of these cases, the call is a no-op.</param>
        public void Info(Func<string> messageFunc) =>
            Log(LogLevel.Info, messageFunc, null);

        /// <summary>
        /// Logs a message at a level of <see cref="LogLevel.Info"/>, but only if <see cref="EnableSensitiveDataLogging"/>
        /// is enabled.
        /// </summary>
        /// <param name="messageFunc">A function that provides the message to log. This function is only called
        /// after checking <see cref="LogLevel"/>, in order to avoid unnecessary formatting. This may be null
        /// and may return null, but in either of these cases, the call is a no-op.</param>
        public void SensitiveInfo(Func<string> messageFunc)
        {
            if (EnableSensitiveDataLogging)
            {
                Info(messageFunc);
            }
        }

        /// <summary>
        /// Logs a message at a level of <see cref="LogLevel.Warn"/>.
        /// </summary>
        /// <param name="message">The message to log. May be null, in which case this method is a no-op.</param>
        /// <param name="exception">The exception to log, if the logged event was caused by an exception. This may be null.</param>
        public void Warn(string message, Exception exception = null) =>
            Log(LogLevel.Warn, message, exception);

        /// <summary>
        /// Logs a message at a level of <see cref="LogLevel.Warn"/>.
        /// </summary>
        /// <param name="messageFunc">A function that provides the message to log. This function is only called
        /// after checking <see cref="LogLevel"/>, in order to avoid unnecessary formatting. This may be null
        /// and may return null, but in either of these cases, the call is a no-op.</param>
        /// <param name="exception">The exception to log, if the logged event was caused by an exception. This may be null.</param>
        public void Warn(Func<string> messageFunc, Exception exception = null) =>
            Log(LogLevel.Warn, messageFunc, exception);

        /// <summary>
        /// Logs a message at a level of <see cref="LogLevel.Error"/>.
        /// </summary>
        /// <param name="message">The message to log. May be null, in which case this method is a no-op.</param>
        /// <param name="exception">The exception to log, if the logged event was caused by an exception. This may be null.</param>
        public void Error(string message, Exception exception = null) =>
            Log(LogLevel.Error, message, exception);

        /// <summary>
        /// Logs a message at a level of <see cref="LogLevel.Error"/>.
        /// </summary>
        /// <param name="messageFunc">A function that provides the message to log. This function is only called
        /// after checking <see cref="LogLevel"/>, in order to avoid unnecessary formatting. This may be null
        /// and may return null, but in either of these cases, the call is a no-op.</param>
        /// <param name="exception">The exception to log, if the logged event was caused by an exception. This may be null.</param>
        public void Error(Func<string> messageFunc, Exception exception = null) =>
            Log(LogLevel.Error, messageFunc, exception);

        /// <summary>
        /// Logs the given message if the specified level equals or exceeds <see cref="LogLevel"/>.
        /// </summary>
        /// <param name="level">The log level of the message to log.</param>
        /// <param name="message">The message to log. This may be null, in which case this call is a no-op.</param>
        /// <param name="exception">The exception to log, if the logged event was caused by an exception. This may be null.</param>
        public void Log(LogLevel level, string message, Exception exception)
        {
            if (LogLevel >= level && message != null)
            {
                LogImpl(level, message, exception);
            }
        }

        /// <summary>
        /// Logs the result of calling the given message provider function if the specified level equals or exceeds <see cref="LogLevel"/>.
        /// </summary>
        /// <param name="level">The log level of the message to log.</param>
        /// <param name="messageFunc">A function that provides the message to log. This function is only called
        /// if <paramref name="level"/> equals or exceeds <see cref="LogLevel"/>, in order to avoid unnecessary formatting. This may be null
        /// and may return null, but in either of these cases, the call is a no-op.</param>
        /// <param name="exception">The exception to log, if the logged event was caused by an exception. This may be null.</param>
        public void Log(LogLevel level, Func<string> messageFunc, Exception exception)
        {
            if (LogLevel >= level && messageFunc != null)
            {
                string message = messageFunc();
                if (message == null)
                {
                    return;
                }
                LogImpl(level, message, exception);
            }
        }

        /// <summary>
        /// Core method to implement logging in derived classes. This method is only called
        /// if the given log level exceeds <see cref="LogLevel"/>, so implementations do not
        /// need to perform that check again.
        /// </summary>
        /// <param name="level">The log level of the message to log.</param>
        /// <param name="message">The message to log. This is never null.</param>
        /// <param name="exception">The exception to log, if the logged event was caused by an exception. This may be null.</param>
        protected abstract void LogImpl(LogLevel level, string message, Exception exception);

        /// <summary>
        /// Logs a performance counter value.
        /// </summary>
        /// <param name="name">The name of the performance counter to log. May be null, in which case this call is a no-op.</param>
        /// <param name="value">The latest value of the performance counter.</param>
        public void LogPerformanceCounter(string name, double value)
        {
            if (LogPerformanceTraces && name != null)
            {
                LogPerformanceCounterImpl(name, x => value);
            }
        }

        /// <summary>
        /// Logs a computed performance counter value.
        /// </summary>
        /// <param name="name">The name of the performance counter to log. May be null, in which case this call is a no-op.</param>
        /// <param name="valueFunc">A function to compute the latest value of the performance counter. May be null, in which case this call is a no-op.</param>
        public void LogPerformanceCounter(string name, Func<double> valueFunc)
        {
            if (LogPerformanceTraces && name != null && valueFunc != null)
            {
                LogPerformanceCounterImpl(name, x => valueFunc());
            }
        }

        /// <summary>
        /// Logs a computed performance counter value.
        /// </summary>
        /// <param name="name">The name of the performance counter to log. May be null, in which case this call is a no-op.</param>
        /// <param name="valueFunc">A function to compute the latest value of the performance counter based on the current value. May be null, in which case this call is a no-op.</param>
        public void LogPerformanceCounter(string name, Func<double, double> valueFunc)
        {
            if (LogPerformanceTraces && name != null && valueFunc != null)
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
