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
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.ErrorReporting.V1Beta1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    ///  Google Cloud Error Reporting <see cref="ExceptionLogger"/>.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// public static void Register(HttpConfiguration config)
    /// {
    ///   // Add a catch all for the uncaught exceptions.
    ///   string projectId = "[Google Cloud Platform project ID]";
    ///   string serviceName = "[Name of service]";
    ///   string version = "[Version of service]";
    ///   // Add a catch all for the uncaught exceptions.
    ///   config.Services.Add(typeof(IExceptionLogger),
    ///       ErrorReportingExceptionLogger.Create(projectId, serviceName, version));
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Reports unhandled exceptions to Google Cloud Error Reporting.
    /// Docs: https://cloud.google.com/error-reporting/docs/
    /// </remarks>
    public sealed class ErrorReportingExceptionLogger : ExceptionLogger, IDisposable
    {
        // The service context in which this error has occurred.
        // See: https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.events#ServiceContext
        private readonly ServiceContext _serviceContext;

        private readonly IConsumer<ReportedErrorEvent> _consumer;

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingExceptionLogger"/> using credentials as
        /// defined by <see cref="GoogleCredential.GetApplicationDefaultAsync"/>.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job. Cannot be null.</param>
        /// <param name="version">Represents the source code version that the developer provided. Cannot be null.</param> 
        ///  <param name="options">Optional, error reporting options.</param>
        public static ErrorReportingExceptionLogger Create(string projectId, string serviceName, string version,
            ErrorReportingOptions options = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName));
            GaxPreconditions.CheckNotNullOrEmpty(version, nameof(version));

            options = options ?? ErrorReportingOptions.Create(projectId);
            var consumer = options.CreateConsumer(options.EventTarget?.LogTarget.ProjectId);
            return new ErrorReportingExceptionLogger(consumer, serviceName, version);
        }

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingExceptionLogger"/> using credentials as
        /// defined by <see cref="GoogleCredential.GetApplicationDefaultAsync"/>.
        /// <para />
        /// Can be used when running on Google App Engine or Google Compute Engine.
        /// The Google Cloud Platform project to report error to will detected from the
        /// current platform.
        /// </summary>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job. Cannot be null.</param>
        /// <param name="version">Represents the source code version that the developer provided. Cannot be null.</param> 
        ///  <param name="options">Optional, error reporting options.</param>
        public static ErrorReportingExceptionLogger Create(
            string serviceName, string version, ErrorReportingOptions options = null) =>
                Create(null, serviceName, version, options);

        internal ErrorReportingExceptionLogger(
            IConsumer<ReportedErrorEvent> consumer, string serviceName, string version)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _serviceContext = new ServiceContext
            {
                Service = GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName)),
                Version = GaxPreconditions.CheckNotNull(version, nameof(version)),
            };
        }

        /// <inheritdoc />
        public override Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            var errorEvent = CreateReportRequest(context);
            return _consumer.ReceiveAsync(new[] { errorEvent }, cancellationToken);
        }

        /// <inheritdoc />
        public override void Log(ExceptionLoggerContext context)
        {
            var errorEvent = CreateReportRequest(context);
            _consumer.Receive(new[] { errorEvent });
        }

        /// <inheritdoc />
        public override bool ShouldLog(ExceptionLoggerContext context)
        {
            return context?.Exception != null;
        }

        /// <inheritdoc />
        public void Dispose() => _consumer.Dispose();

        /// <summary>
        /// Gets information about the HTTP request and response when the exception occured 
        /// and populates a <see cref="HttpRequestContext"/> object.
        /// </summary>
        private HttpRequestContext CreateHttpRequestContext(ExceptionLoggerContext exceptionLoggerContext)
        {
            ExceptionContext exceptionContext = exceptionLoggerContext.ExceptionContext;
            HttpRequestMessage requestMessage = exceptionContext?.Request;
            HttpResponseMessage responseMessage = exceptionContext?.Response;

            return new HttpRequestContext()
            {
                Method = requestMessage?.Method?.ToString() ?? "",
                Url = requestMessage?.RequestUri?.ToString() ?? "",
                UserAgent = requestMessage?.Headers?.UserAgent?.ToString() ?? "",
                ResponseStatusCode = (int) (responseMessage?.StatusCode ?? 0),
            };
        }

        /// <summary>
        /// Gets infromation about the exception that occured and populates
        /// a <see cref="ReportedErrorEvent"/> object.
        /// </summary>
        private ReportedErrorEvent CreateReportRequest(ExceptionLoggerContext context)
        {
            ErrorContext errorContext = new ErrorContext()
            {
                HttpRequest = CreateHttpRequestContext(context),
                ReportLocation = ErrorReportingUtils.CreateSourceLocation(context.Exception)
            };

            return new ReportedErrorEvent()
            {
                Message = context.Exception.ToString() ?? "",
                Context = errorContext,
                ServiceContext = _serviceContext,
                EventTime = Timestamp.FromDateTime(DateTime.UtcNow),
            };
        }
    }
}
