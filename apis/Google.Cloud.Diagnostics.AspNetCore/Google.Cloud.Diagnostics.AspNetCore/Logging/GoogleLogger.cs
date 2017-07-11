// Copyright 2016 Google Inc. All Rights Reserved.
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

using Google.Cloud.Logging.V2;
using Google.Cloud.Diagnostics.Common;
using Google.Protobuf.WellKnownTypes;
using Google.Api.Gax;
using Microsoft.Extensions.Logging;
using System;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// <see cref="ILogger"/> for Google Stackdriver Logging.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// public void Configure(ILoggerFactory loggerFactory)
    /// {
    ///     string projectId = "[Google Cloud Platform project ID]";
    ///     loggerFactory.AddGoogle(projectId);
    ///     ...
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Logs to Google Stackdriver Cloud Logging.
    /// Docs: https://cloud.google.com/logging/docs/
    /// </remarks>
    /// <seealso cref="GoogleLoggerFactoryExtensions"/>
    public sealed class GoogleLogger : ILogger
    {
        /// <summary>The consumer to push logs to.</summary>
        private readonly IConsumer<LogEntry> _consumer;

        /// <summary>The logger options.</summary>
        private readonly LoggerOptions _loggerOptions;

        /// <summary>The formatted log name.</summary>
        private readonly string _logName;

        /// <summary>A clock for getting the current timestamp.</summary>
        private readonly IClock _clock;

        internal GoogleLogger(IConsumer<LogEntry> consumer, LogTarget logTarget, LoggerOptions loggerOptions, 
            string logName, IClock clock = null)
        {
            GaxPreconditions.CheckNotNull(logTarget, nameof(logTarget));
            GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName));
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _loggerOptions = GaxPreconditions.CheckNotNull(loggerOptions, nameof(loggerOptions)); ;
            _logName = logTarget.GetFullLogName(logName);
            _clock = clock ?? SystemClock.Instance;
        }

        /// <inheritdoc />
        public IDisposable BeginScope<TState>(TState state) => new GoogleLoggerScope(state);

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel) => logLevel >= _loggerOptions.LogLevel;

        /// <inheritdoc />
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            GaxPreconditions.CheckNotNull(formatter, nameof(formatter));

            if (!IsEnabled(logLevel))
            {
                return;
            }

            string message = formatter(state, exception);
            if (string.IsNullOrEmpty(message))
            {
                return;
            }

            LogEntry entry = new LogEntry
            {
                Resource = _loggerOptions.MonitoredResource,
                LogName = _logName,
                Severity = logLevel.ToLogSeverity(),
                Timestamp = Timestamp.FromDateTime(_clock.GetCurrentDateTimeUtc()),
                TextPayload = string.Concat(GoogleLoggerScope.Current, message),
                Labels = { _loggerOptions.Labels },
            };

            _consumer.Receive(new[] { entry });
        }
    }
}
