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
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    internal class ErrorReportingExceptionLoggerBase : IDisposable
    {
        // The service context in which this error has occurred.
        // See: https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.events#ServiceContext
        private readonly ServiceContext _serviceContext;

        private readonly IConsumer<ReportedErrorEvent> _consumer;

        internal ErrorReportingExceptionLoggerBase(IConsumer<ReportedErrorEvent> consumer, string serviceName, string version)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _serviceContext = new ServiceContext
            {
                Service = GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName)),
                Version = GaxPreconditions.CheckNotNull(version, nameof(version)),
            };
        }

        internal static ErrorReportingExceptionLoggerBase Create(string projectId, string serviceName, string version,
            ErrorReportingOptions options = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName));
            GaxPreconditions.CheckNotNullOrEmpty(version, nameof(version));

            options = options ?? ErrorReportingOptions.Create(projectId);
            var consumer = options.CreateConsumer();
            return new ErrorReportingExceptionLoggerBase(consumer, serviceName, version);
        }

        internal Task LogAsync(Exception exception, IContextWrapper context, CancellationToken cancellationToken = default(CancellationToken))
        {
            var errorEvent = CreateReportRequest(exception, context);
            return _consumer.ReceiveAsync(new[] { errorEvent }, cancellationToken);
        }

        internal void Log(Exception exception, IContextWrapper context)
        {
            var errorEvent = CreateReportRequest(exception, context);
            _consumer.Receive(new[] { errorEvent });
        }

        /// <inheritdoc />
        public void Dispose() => _consumer.Dispose();

        /// <summary>
        /// Gets information about the HTTP request and response when the exception occured 
        /// and populates a <see cref="HttpRequestContext"/> object.
        /// </summary>
        private HttpRequestContext CreateHttpRequestContext(IContextWrapper context)
        {
            return new HttpRequestContext()
            {
                Method = context?.GetMethod() ?? "",
                Url = context?.GetUri() ?? "",
                UserAgent = context?.GetUserAgent() ?? "",
                ResponseStatusCode = context?.GetStatusCode() ?? 0,
            };
        }

        /// <summary>
        /// Gets information about the source location where the exception occured 
        /// and populates a <see cref="SourceLocation"/> object.
        /// </summary>
        private static SourceLocation CreateSourceLocation(Exception exception)
        {
            if (exception == null)
            {
                return new SourceLocation();
            }

            StackTrace stackTrace = new StackTrace(exception, true);
            StackFrame[] frames = stackTrace.GetFrames();
            if (frames == null || frames.Length == 0)
            {
                return new SourceLocation();
            }

            StackFrame frame = frames[0];
            return new SourceLocation
            {
                FilePath = frame.GetFileName() ?? "",
                LineNumber = frame.GetFileLineNumber(),
                FunctionName = frame.GetMethod()?.Name ?? "",
            };
        }

        /// <summary>
        /// Gets infromation about the exception that occured and populates
        /// a <see cref="ReportedErrorEvent"/> object.
        /// </summary>
        internal ReportedErrorEvent CreateReportRequest(Exception exception, IContextWrapper context)
        {
            ErrorContext errorContext = new ErrorContext()
            {
                HttpRequest = CreateHttpRequestContext(context),
                ReportLocation = CreateSourceLocation(exception)
            };

            return new ReportedErrorEvent()
            {
                Message = exception.ToString() ?? "",
                Context = errorContext,
                ServiceContext = _serviceContext,
                EventTime = Timestamp.FromDateTime(DateTime.UtcNow),
            };
        }
    }
}
