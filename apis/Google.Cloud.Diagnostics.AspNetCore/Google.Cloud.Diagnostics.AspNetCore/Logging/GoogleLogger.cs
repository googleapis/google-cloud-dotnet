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
using Google.Api;

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

        /// <summary>The minimum log level.</summary>
        private readonly LogLevel _logLevel;

        /// <summary>The formatted log name for the project and log.</summary>
        private readonly string _logName;

        /// <summary>A clock for getting the current timestamp.</summary>
        private readonly IClock _clock;

        /// <summary>The global resource. See: https://cloud.google.com/logging/docs/api/v2/resource-list </summary>
        internal static readonly MonitoredResource _globalResource = new MonitoredResource { Type = "global" };

        internal GoogleLogger(IConsumer<LogEntry> consumer, LogLevel logLevel, string projectId, string logName, IClock clock = null)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            GaxPreconditions.CheckNotNull(logName, nameof(logName));
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _logLevel = logLevel;
            _logName = new LogName(projectId, logName).ToString();
            _clock = clock ?? SystemClock.Instance;
        }

        /// <summary>
        /// Currently unsupported, always return null.
        /// </summary>
        public IDisposable BeginScope<TState>(TState state)
        {
            // TODO(talarico): Implement.
            return null;
        }

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel) => logLevel >= _logLevel;
        

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
                Resource = _globalResource,
                LogName = _logName,
                Severity = logLevel.ToLogSeverity(),
                Timestamp = Timestamp.FromDateTime(_clock.GetCurrentDateTimeUtc()),
                TextPayload = message,
            };

            _consumer.Receive(new[] { entry });
        }
    }
}
