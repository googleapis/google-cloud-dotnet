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

using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    ///  Google Cloud Error Reporting Exception Logger.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// public void Configure(IApplicationBuilder app)
    /// {
    ///     // Use first to ensure all unhandled exceptions are reported.
    ///     string projectId = "[Google Cloud Platform project ID]";
    ///     string serviceName = "[Name of service]";
    ///     string version = "[Version of service]";
    ///     app.UseGoogleExceptionLogging(projectId, serviceName, version);
    ///     ...
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Reports unhandled exceptions to Google Cloud Error Reporting.
    /// See <see cref="ErrorReportingExceptionLoggerExtension"/>.
    /// Docs: https://cloud.google.com/error-reporting/docs/
    /// </remarks>
    internal sealed class ErrorReportingExceptionLogger : IExceptionLogger
    {
        ///<summary>
        /// The service context in which this error has occurred.
        /// See: https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.events#ServiceContext
        /// </summary>
        private readonly ServiceContext _serviceContext;

        /// <summary>The consumer to report errors to.</summary>
        private readonly IConsumer<ReportedErrorEvent> _consumer;

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingExceptionLogger"/>
        /// </summary>
        /// <param name="consumer">The consumer to report errors to. Cannot be null.</param>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the 
        ///     executable or job. Cannot be null.</param>
        /// <param name="version">Represents the source code version that the developer
        ///     provided. Cannot be null.</param> 
        internal static ErrorReportingExceptionLogger Create(
            IConsumer<ReportedErrorEvent> consumer, string serviceName, string version) =>
            new ErrorReportingExceptionLogger(consumer, serviceName, version);

        private ErrorReportingExceptionLogger(
           IConsumer<ReportedErrorEvent> consumer, string serviceName, string version)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _serviceContext = new ServiceContext
            {
                Service = GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName)),
                Version = GaxPreconditions.CheckNotNull(version, nameof(version)),
            };
        }

        /// <summary>
        /// Asynchronously logs an exception that occurred.
        /// </summary>
        /// <returns>A task containing an empty response on success.</returns>
        public async Task LogAsync(HttpContext context, Exception exception)
        {
            var errorEvent = CreateReportRequest(context, exception);
            await _consumer.ReceiveAsync(new[] { errorEvent });
        }

        /// <summary>
        /// Gets information about the HTTP request and response when the exception occurred 
        /// and populates a <see cref="HttpRequestContext"/> object.
        /// </summary>
        private HttpRequestContext CreateHttpRequestContext(HttpContext context)
        {
            HttpRequest request = context?.Request;
            HttpResponse response = context?.Response;

            return new HttpRequestContext()
            {
                Method = request?.Method?.ToString() ?? "",
                Url = request?.GetDisplayUrl() ?? "",
                UserAgent = request?.Headers["User-Agent"].ToString() ?? "",
                ResponseStatusCode = response?.StatusCode ?? 0,
            };
        }

        /// <summary>
        /// Gets information about the source location where the exception occurred 
        /// and populates a <see cref="SourceLocation"/> object.
        /// </summary>
        private SourceLocation CreateSourceLocation(Exception exception)
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
            return new SourceLocation()
            {
                FilePath = frame.GetFileName() ?? "",
                LineNumber = frame.GetFileLineNumber(),
                FunctionName = frame.GetMethod()?.Name ?? "",
            };
        }

        /// <summary>
        /// Gets information about the exception that occurred and populates
        /// a <see cref="ReportedErrorEvent"/> object.
        /// </summary>
        private ReportedErrorEvent CreateReportRequest(HttpContext context, Exception exception)
        {
            ErrorContext errorContext = new ErrorContext()
            {
                HttpRequest = CreateHttpRequestContext(context),
                ReportLocation = CreateSourceLocation(exception)
            };

            return new ReportedErrorEvent()
            {
                Message = exception?.ToString() ?? "",
                Context = errorContext,
                ServiceContext = _serviceContext,
                EventTime = Timestamp.FromDateTime(DateTime.UtcNow),
            };
        }
    }
}
