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

using System;
using System.Collections.Generic;
using System.Linq;
using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

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

        /// <summary>The trace target or null if non exists.</summary>
        private readonly TraceTarget _traceTarget;

        /// <summary>The logger options.</summary>
        private readonly LoggerOptions _loggerOptions;

        /// <summary>The formatted log name.</summary>
        private readonly string _logName;

        /// <summary>A clock for getting the current timestamp.</summary>
        private readonly IClock _clock;

        /// <summary>An accessor to get the current <see cref="HttpContext"/>.</summary>
        private readonly IHttpContextAccessor _accessor;

        internal GoogleLogger(IConsumer<LogEntry> consumer, LogTarget logTarget, LoggerOptions loggerOptions,
            string logName, IClock clock = null, IHttpContextAccessor accessor = null)
        {
            GaxPreconditions.CheckNotNull(logTarget, nameof(logTarget));
            GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName));
            _traceTarget = logTarget.Kind == LogTargetKind.Project ?
                TraceTarget.ForProject(logTarget.ProjectId) : null;
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _loggerOptions = GaxPreconditions.CheckNotNull(loggerOptions, nameof(loggerOptions));
            _logName = logTarget.GetFullLogName(logName);
            _accessor = accessor;
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

            Dictionary<string, string> labels;
            var labelProviders = GetLabelProviders();
            if (labelProviders != null)
            {
                // Create a copy of the labels from the options and invoke each provider
                labels = _loggerOptions.Labels.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                foreach (var provider in labelProviders)
                {
                    provider.Invoke(labels);
                }
            }
            else
            {
                labels = _loggerOptions.Labels;
            }

            LogEntry entry = new LogEntry
            {
                Resource = _loggerOptions.MonitoredResource,
                LogName = _logName,
                Severity = logLevel.ToLogSeverity(),
                Timestamp = Timestamp.FromDateTime(_clock.GetCurrentDateTimeUtc()),
                TextPayload = string.Concat(GoogleLoggerScope.Current, message),
                Labels = { labels },
                Trace = GetTraceName() ?? "",
            };

            _consumer.Receive(new[] { entry });
        }

        /// <summary>
        /// Gets the full trace name if the log target is a project, we have an
        /// HTTP accessor and a valid trace header exists on the current context.
        /// If the trace name cannot be determined null is returned.
        /// See: See: https://cloud.google.com/logging/docs/reference/v2/rest/v2/LogEntry
        /// </summary>
        internal string GetTraceName()
        {
            if (_traceTarget == null || _accessor == null)
            {
                return null;
            }

            string header = _accessor.HttpContext?.Request?.Headers[TraceHeaderContext.TraceHeader];
            var traceContext = TraceHeaderContext.FromHeader(header);
            return traceContext.TraceId == null ? null : _traceTarget.GetFullTraceName(traceContext.TraceId);
        }

        internal IEnumerable<ILogEntryLabelProvider> GetLabelProviders()
        {
            var serviceProvider = _accessor?.HttpContext?.RequestServices;
            if (serviceProvider == null)
            {
                return null;
            }

            return (IEnumerable<ILogEntryLabelProvider>)serviceProvider.GetService(typeof(IEnumerable<ILogEntryLabelProvider>));
        }
    }
}
