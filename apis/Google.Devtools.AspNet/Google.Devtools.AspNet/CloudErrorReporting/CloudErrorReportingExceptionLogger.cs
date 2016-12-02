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
using Google.Cloud.ErrorReporting.V1Beta1;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;

namespace Google.Devtools.AspNet
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
    ///       CloudErrorReportingExceptionLogger.Create(projectId, serviceName, version));
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Reports unhandled exceptions to Google Cloud Error Reporting.
    /// Docs: https://cloud.google.com/error-reporting/docs/
    /// </remarks>
    public sealed class CloudErrorReportingExceptionLogger : ExceptionLogger
    {
        // The formated Google Cloud Platform project id.
        private readonly string _projectResourceName;

        // The service context in which this error has occurred.
        // See: https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.events#ServiceContext
        private readonly ServiceContext _serviceContext;

        private readonly Task<ReportErrorsServiceClient> _clientTask;

        /// <summary>
        /// Creates an instance of <see cref="CloudErrorReportingExceptionLogger"/>
        /// </summary>
        /// <param name="clientTask">The Error Reporting client.</param>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.</param>
        /// <param name="version">Represents the source code version that the developer provided.</param> 
        public static CloudErrorReportingExceptionLogger Create(
            ReportErrorsServiceClient client, string projectId, string serviceName, string version) =>
                new CloudErrorReportingExceptionLogger(Task.FromResult(client), projectId, serviceName, version);

        /// <summary>
        /// Creates an instance of <see cref="CloudErrorReportingExceptionLogger"/>
        /// </summary>
        /// <param name="clientTask">The Error Reporting client.</param>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.</param>
        /// <param name="version">Represents the source code version that the developer provided.</param> 
        public static CloudErrorReportingExceptionLogger Create(
            Task<ReportErrorsServiceClient> clientTask, string projectId, string serviceName, string version) =>
                new CloudErrorReportingExceptionLogger(clientTask, projectId, serviceName, version);

        /// <summary>
        /// Creates an instance of <see cref="CloudErrorReportingExceptionLogger"/> using credentials as
        /// defined by <see cref="GoogleCredential.GetApplicationDefaultAsync"/>.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.</param>
        /// <param name="version">Represents the source code version that the developer provided.</param> 
        public static CloudErrorReportingExceptionLogger Create(string projectId, string serviceName, string version) =>
            new CloudErrorReportingExceptionLogger(ReportErrorsServiceClient.CreateAsync(), projectId, serviceName, version);

        private CloudErrorReportingExceptionLogger(
            Task<ReportErrorsServiceClient> clientTask, string projectId, string serviceName, string version) : base()
        {
            _clientTask = GaxPreconditions.CheckNotNull(clientTask, nameof(clientTask));
            _projectResourceName = new ProjectName(GaxPreconditions.CheckNotNull(projectId, nameof(projectId))).ToString();

            _serviceContext = new ServiceContext
            {
                Service = GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName)),
                Version = GaxPreconditions.CheckNotNull(version, nameof(version)),
            };
        }

        /// <inheritdoc />
        public override async Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            ReportedErrorEvent errorEvent = CreateReportRequest(context);
            ReportErrorsServiceClient client = await _clientTask;
            await client.ReportErrorEventAsync(_projectResourceName, errorEvent);
        }

        /// <inheritdoc />
        public override void Log(ExceptionLoggerContext context)
        {
            ReportedErrorEvent errorEvent = CreateReportRequest(context);
            // If the client task has faulted this will throw when accessing 'Result'
            _clientTask.Result.ReportErrorEvent(_projectResourceName, errorEvent);
        }

        /// <inheritdoc />
        public override bool ShouldLog(ExceptionLoggerContext context)
        {
            return context?.Exception != null;
        }

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
        /// Gets information about the source location where the exception occured 
        /// and populates a <see cref="SourceLocation"/> object.
        /// </summary>
        private SourceLocation CreateSourceLocation(ExceptionLoggerContext exceptionLoggerContext)
        {
            Exception ex = exceptionLoggerContext?.Exception;
            if (ex == null)
            {
                return new SourceLocation();
            }

            StackTrace stackTrace = new StackTrace(ex, true);
            if (stackTrace.FrameCount == 0)
            {
                return new SourceLocation();
            }

            StackFrame frame = stackTrace.GetFrame(0);
            return new SourceLocation()
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
        private ReportedErrorEvent CreateReportRequest(ExceptionLoggerContext context)
        {
            ErrorContext errorContext = new ErrorContext()
            {
                HttpRequest = CreateHttpRequestContext(context),
                ReportLocation = CreateSourceLocation(context)
            };

            return new ReportedErrorEvent()
            {
                Message = context.Exception.ToString() ?? "",
                Context = errorContext,
                ServiceContext = _serviceContext,
            };
        }
    }
}
