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
using Google.Cloud.Logging.Type;
using Google.Cloud.Logging.V2;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    ///  Google Cloud Error Reporting Logger.
    /// </summary>
    internal class ErrorReportingContextExceptionLogger : IContextExceptionLogger
    {
        // The service context in which this error has occurred.
        // See: https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.events#ServiceContext
        private readonly Struct _serviceContext;

        private readonly string _logName;

        private readonly IConsumer<LogEntry> _consumer;

        private readonly ErrorReportingOptions _options;

        internal ErrorReportingContextExceptionLogger(
            IConsumer<LogEntry> consumer, string serviceName, string version, ErrorReportingOptions options)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _options = GaxPreconditions.CheckNotNull(options, nameof(options));
            var eventTarget = options.EventTarget;
            GaxPreconditions.CheckState(eventTarget.Kind == EventTargetKind.Logging, $"Invalid {nameof(EventTarget)}");
            _logName = GaxPreconditions.CheckNotNull(eventTarget.LogTarget, nameof(eventTarget.LogTarget)).GetFullLogName(eventTarget.LogName);

            _serviceContext = new Struct
            {
                Fields =
                {
                    { "service", Value.ForString(GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName))) },
                    { "version", Value.ForString(GaxPreconditions.CheckNotNull(version, nameof(version))) }
                }
            };
        }

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingContextExceptionLogger"/>
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID. Can be null.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.
        ///     Cannot be null.</param>
        /// <param name="version">Represents the source code version that the developer provided. 
        ///     Cannot be null.</param>
        /// <param name="options">Optional, error reporting options.</param>
        internal static IContextExceptionLogger Create(string projectId, string serviceName, string version,
            ErrorReportingOptions options = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName));
            GaxPreconditions.CheckNotNullOrEmpty(version, nameof(version));

            options = options ?? ErrorReportingOptions.Create(projectId);
            var consumer = options.CreateConsumer();
            return new ErrorReportingContextExceptionLogger(consumer, serviceName, version, options);
        }

        /// <inheritdoc />
        Task IContextExceptionLogger.LogAsync(Exception exception, IContextWrapper context, CancellationToken cancellationToken)
        {
            var errorEvent = CreateReportRequest(exception, context);
            return _consumer.ReceiveAsync(new[] { errorEvent }, cancellationToken);
        }

        /// <inheritdoc />
        void IContextExceptionLogger.Log(Exception exception, IContextWrapper context)
        {
            var errorEvent = CreateReportRequest(exception, context);
            _consumer.Receive(new[] { errorEvent });
        }

        /// <inheritdoc />
        public void Dispose() => _consumer.Dispose();

        /// <summary>
        /// Gets information about the HTTP request and response when the exception occurred 
        /// and populates a <see cref="Struct"/>.
        /// </summary>
        private Struct CreateHttpRequestContext(IContextWrapper context)
        {
            return new Struct
            {
                Fields =
                {
                    { "method", Value.ForString(context?.GetHttpMethod() ?? "") },
                    { "url", Value.ForString(context?.GetUri() ?? "") },
                    { "userAgent", Value.ForString(context?.GetUserAgent() ?? "") },
                    { "responseStatusCode", Value.ForNumber(context?.GetStatusCode() ?? 0) }
                }
            };
        }

        /// <summary>
        /// Gets information about the source location where the exception occurred 
        /// and populates a <see cref="Struct"/>.
        /// </summary>
        private static Struct CreateSourceLocation(Exception exception)
        {
            if (exception == null)
            {
                return new Struct();
            }

            StackTrace stackTrace = new StackTrace(exception, true);
            StackFrame[] frames = stackTrace.GetFrames();
            if (frames == null || frames.Length == 0)
            {
                return new Struct();
            }

            StackFrame frame = frames[0];
            return new Struct
            {
                Fields =
                {
                    { "filePath", Value.ForString(frame.GetFileName() ?? "") },
                    { "lineNumber", Value.ForNumber(frame.GetFileLineNumber()) },
                    { "functionName", Value.ForString(frame.GetMethod()?.Name ?? "") }
                }
            };
        }

        /// <summary>
        /// Gets information about the exception that occurred and populates
        /// a <see cref="LogEntry"/>.
        /// </summary>
        private LogEntry CreateReportRequest(Exception exception, IContextWrapper context)
        {
            var timestamp = Timestamp.FromDateTime(DateTime.UtcNow);

            Struct errorContext = new Struct
            {
                Fields =
                {
                    { "httpRequest", Value.ForStruct(CreateHttpRequestContext(context)) },
                    { "reportLocation", Value.ForStruct(CreateSourceLocation(exception)) }
                }
            };

            Struct errorEvent = new Struct
            {
                Fields =
                {
                    { "message", Value.ForString(exception?.ToString() ?? "") },
                    { "context", Value.ForStruct(errorContext) },
                    { "serviceContext", Value.ForStruct(_serviceContext) },
                    { "eventTime", Value.ForString(timestamp.ToString()) }
                }
            };

            return new LogEntry
            {
                Resource = _options.EventTarget.MonitoredResource,
                LogName = _logName,
                Severity = LogSeverity.Error,
                Timestamp = timestamp,
                JsonPayload = errorEvent
            };
        }
    }
}
