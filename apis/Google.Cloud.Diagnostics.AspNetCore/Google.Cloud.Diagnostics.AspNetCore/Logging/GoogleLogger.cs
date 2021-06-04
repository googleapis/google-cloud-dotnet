// Copyright 2018 Google Inc. All Rights Reserved.
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
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.FormattableString;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// <see cref="ILogger"/> for Google Cloud Logging.
    /// </summary>
    public sealed class GoogleLogger : ILogger
    {
        private const string GcpConsoleLogsBaseUrl = "https://console.cloud.google.com/logs/viewer";

        /// <summary>The log name given when creating the logger.</summary>
        private readonly string _logName;

        /// <summary>The consumer to push logs to.</summary>
        private readonly IConsumer<LogEntry> _consumer;

        /// <summary>The trace target or null if non exists.</summary>
        private readonly TraceTarget _traceTarget;

        /// <summary>
        /// The log target, indicating mainly if the target is a project or an organization.
        /// </summary>
        private readonly LogTarget _logTarget;

        /// <summary>The logger options.</summary>
        private readonly LoggerOptions _loggerOptions;

        /// <summary>The formatted log name.</summary>
        private readonly string _fullLogName;

        /// <summary>A clock for getting the current timestamp.</summary>
        private readonly IClock _clock;

        /// <summary>The service provider to resolve additional services from.</summary>
        private readonly IServiceProvider _serviceProvider;

        internal GoogleLogger(IConsumer<LogEntry> consumer, LogTarget logTarget, LoggerOptions loggerOptions,
            string logName, IClock clock = null, IServiceProvider serviceProvider = null)
        {
            _logTarget = GaxPreconditions.CheckNotNull(logTarget, nameof(logTarget));
            _traceTarget = logTarget.Kind == LogTargetKind.Project ?
                TraceTarget.ForProject(logTarget.ProjectId) : null;
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _loggerOptions = GaxPreconditions.CheckNotNull(loggerOptions, nameof(loggerOptions));
            _logName = GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName));
            _fullLogName = logTarget.GetFullLogName(_loggerOptions.LogName);
            _serviceProvider = serviceProvider;
            _clock = clock ?? SystemClock.Instance;
        }

        /// <inheritdoc />
        public IDisposable BeginScope<TState>(TState state) => GoogleLoggerScope.BeginScope(state);

        /// <inheritdoc />
        public bool IsEnabled(LogLevel logLevel) => logLevel >= _loggerOptions.LogLevel;

        /// <inheritdoc />
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            try
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
                    LogName = _fullLogName,
                    Severity = logLevel.ToLogSeverity(),
                    Timestamp = Timestamp.FromDateTime(_clock.GetCurrentDateTimeUtc()),
                    JsonPayload = CreateJsonPayload(eventId, state, exception, message),
                    Labels = { CreateLabels() },
                };

                GoogleLoggerScope.Current?.ApplyFullScopeStack(entry);
                SetTraceAndSpanIfAny(entry);

                _consumer.Receive(new[] { entry });
            }
            catch (Exception) when (_loggerOptions.RetryOptions.ExceptionHandling == ExceptionHandling.Ignore) { }
        }

        private Dictionary<string, string> CreateLabels()
        {
            var labelProviders = _serviceProvider?.GetService<IEnumerable<ILogEntryLabelProvider>>();
            if (labelProviders is null)
            {
                return _loggerOptions.Labels;
            }
            using (var iterator = labelProviders.GetEnumerator())
            {
                if (!iterator.MoveNext())
                {
                    return _loggerOptions.Labels;
                }
                // By now, we know we have at least one label provider. Clone the labels from the options,
                // and invoke each provider on the clone in turn.
                var labels = _loggerOptions.Labels.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
                do
                {
                    iterator.Current.Invoke(labels);
                } while (iterator.MoveNext());
                return labels;
            }
        }

        private Struct CreateJsonPayload<TState>(EventId eventId, TState state, Exception exception, string message)
        {
            var jsonStruct = new Struct();
            jsonStruct.Fields.Add("message", Value.ForString(message));
            jsonStruct.Fields.Add("log_name", Value.ForString(_logName));

            if (_loggerOptions.ServiceContext != null)
            {
                jsonStruct.Fields.Add("serviceContext", Value.ForStruct(_loggerOptions.ServiceContext));
            }
            if (exception != null)
            {
                jsonStruct.Fields.Add("exception", Value.ForString(exception.ToString()));
            }

            if (eventId.Id != 0 || eventId.Name != null)
            {
                var eventStruct = new Struct();
                if (eventId.Id != 0)
                {
                    eventStruct.Fields.Add("id", Value.ForNumber(eventId.Id));
                }
                if (!string.IsNullOrWhiteSpace(eventId.Name))
                {
                    eventStruct.Fields.Add("name", Value.ForString(eventId.Name));
                }
                jsonStruct.Fields.Add("event_id", Value.ForStruct(eventStruct));
            }

            // If we have format params and its more than just the original message add them.
            if (state is IEnumerable<KeyValuePair<string, object>> formatParams &&
                ContainsFormatParameters(formatParams))
            {
                jsonStruct.Fields.Add("format_parameters", formatParams.ToStructValue());
            }

            return jsonStruct;

            // Checks that fields is:
            // - Non-empty
            // - Not just a single entry with a key of "{OriginalFormat}"
            // so we can decide whether or not to populate a struct with it.
            bool ContainsFormatParameters(IEnumerable<KeyValuePair<string, object>> fields)
            {
                using (var iterator = fields.GetEnumerator())
                {
                    // No fields? Nothing to format.
                    if (!iterator.MoveNext())
                    {
                        return false;
                    }
                    // If the first entry isn't the original format, we definitely want to create a struct
                    if (iterator.Current.Key != "{OriginalFormat}")
                    {
                        return true;
                    }
                    // If the first entry *is* the original format, we want to create a struct
                    // if and only if there's at least one more entry.
                    return iterator.MoveNext();
                }
            }
        }

        private void SetTraceAndSpanIfAny(LogEntry entry)
        {
            if (_traceTarget is null)
            {
                return;
            }

            // If there's currently a Google trace and span use that one.
            // This means that the Google Trace component of the diagnostics library
            // has been initialized.
            // Else attempt to use an external trace context.
            if ((TraceContextForLogEntry.FromGoogleTrace() ?? TraceContextForLogEntry.FromExternalTrace(_serviceProvider)) is TraceContextForLogEntry trace)
            {
                entry.Trace = _traceTarget.GetFullTraceName(trace.TraceId);
                entry.TraceSampled = true;
                entry.SpanId = trace.SpanId;
            }
        }

        /// <summary>
        /// For diagnostic purposes. Builds and returns the URL where the entries logged by
        /// this <see cref="GoogleLogger"/> can be seen on the Google Cloud Logging Console.
        /// </summary>
        public Uri GetGcpConsoleLogsUrl()
        {
            string target =
                _logTarget.Kind == LogTargetKind.Project ? $"project={_logTarget.ProjectId}" :
                _logTarget.Kind == LogTargetKind.Organization ? $"organizationId={_logTarget.OrganizationId}" :
                throw new InvalidOperationException($"Unrecognized LogTargetKind: {_logTarget.Kind}");

            string resourceType = _loggerOptions.MonitoredResource.Type;
            // Log ingestion converts "gke_container" into "container", but we really do need to search for "container",
            // as the UI doesn't support "gke_container". (Whereas the Monitoring API *only* supports "gke_container".)
            if (resourceType == "gke_container")
            {
                resourceType = "container";
            }
            IList<string> parameters = new List<string>
            {
                $"resource={resourceType}",
                $"minLogLevel={(int)_loggerOptions.LogLevel.ToLogSeverity()}",
                $"logName={_fullLogName}",
                target
            };

            return new UriBuilder(GcpConsoleLogsBaseUrl)
            {
                Query = string.Join("&", parameters)
            }.Uri;
        }

        internal void WriteDiagnostics(TextWriter writer)
        {
            // Explicitly not catching exceptions.
            // This should only be activated for diagnostics purposes so in that case
            // we shouldn't try to handle exceptions.

            writer.WriteLine(Invariant($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss} - GoogleLogger will write logs to: {GetGcpConsoleLogsUrl()}"));
            writer.Flush();
        }
    }
}
