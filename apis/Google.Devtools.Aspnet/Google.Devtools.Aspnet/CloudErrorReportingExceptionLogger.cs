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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Clouderrorreporting.v1beta1;
using Google.Apis.Clouderrorreporting.v1beta1.Data;
using Google.Apis.Services;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.ExceptionHandling;
using static Google.Apis.Clouderrorreporting.v1beta1.ProjectsResource.EventsResource;

namespace Google.Devtools.Aspnet
{
    /// <summary>
    ///  Google Cloud Error Reporting <see cref="ExceptionLogger"/>.
    /// </summary>
    /// 
    /// <example>
    /// public static void Register(HttpConfiguration config)
    /// {
    ///   // Add a catch all for the uncaught exceptions.
    ///   config.Services.Add(typeof(IExceptionLogger),
    ///       CloudErrorReportingExceptionLogger.Create());
    /// }
    /// </example>
    /// 
    /// <remarks>
    /// Reports unhandled exceptions to Google Cloud Error Reporting.
    /// Docs: https://cloud.google.com/error-reporting/docs/
    /// </remarks>
    public sealed class CloudErrorReportingExceptionLogger : ExceptionLogger
    {
        // The format expected for the Google Cloud Platform project id.
        // See: https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.events/report. 
        private static readonly string _projectIdTemplate = "projects/{0}";

        // The formated Google Cloud Platform project id.
        private readonly string _projectId;

        // The service context in which this error has occurred.
        // See: https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.events#ServiceContext
        private readonly ServiceContext _serviceContext;

        private readonly ClouderrorreportingService _service;

        /// <summary>
        /// Creates an instance of <see cref="CloudErrorReportingExceptionLogger"/>
        /// </summary>
        /// <param name="service">The Cloud Error Reporting service.</param>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.</param>
        /// <param name="version">Represents the source code version that the developer provided.</param> 
        public static CloudErrorReportingExceptionLogger Create(
            ClouderrorreportingService service, string projectId, string serviceName, string version)
        {
            return new CloudErrorReportingExceptionLogger(service, projectId, serviceName, version);
        }

        /// <summary>
        /// Creates an instance of <see cref="CloudErrorReportingExceptionLogger"/> using credentials as
        /// defined by <see cref="GoogleCredential.GetApplicationDefaultAsync"/>.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.</param>
        /// <param name="version">Represents the source code version that the developer provided.</param> 
        public static CloudErrorReportingExceptionLogger Create(string projectId, string serviceName, string version)
        {
            return new CloudErrorReportingExceptionLogger(CreateService(), projectId, serviceName, version);
        }

        private CloudErrorReportingExceptionLogger(
            ClouderrorreportingService service, string projectId, string serviceName, string version) : base()
        {
            _service = GaxPreconditions.CheckNotNull(service, nameof(service));
            _projectId = string.Format(
                _projectIdTemplate, GaxPreconditions.CheckNotNull(projectId, nameof(projectId)));
            _serviceContext = new ServiceContext
            {
                Service = GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName)),
                Version = GaxPreconditions.CheckNotNull(version, nameof(version)),
            };
        }

        public override Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            ReportRequest request = CreateReportRequest(context);
            return request.ExecuteAsync(cancellationToken);
        }

        public override void Log(ExceptionLoggerContext context)
        {
            ReportRequest request = CreateReportRequest(context);
            request.Execute();
        }

        public override bool ShouldLog(ExceptionLoggerContext context)
        {
            return context?.Exception != null;
        }

        /// <summary>
        /// Creates an instance of <see cref="ClouderrorreportingService"/> with the needed scopes and
        /// default credentials.
        /// </summary>
        private static ClouderrorreportingService CreateService()
        {
            GoogleCredential credential = Task.Run(() => GoogleCredential.GetApplicationDefaultAsync()).Result;
            credential.CreateScoped(ClouderrorreportingService.Scope.CloudPlatform);
            ClouderrorreportingService service = new ClouderrorreportingService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
            });
            return service;
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

            HttpRequestContext requestContext = new HttpRequestContext()
            {
                Method = requestMessage?.Method?.ToString(),
                Url = requestMessage?.RequestUri?.ToString(),
                UserAgent = requestMessage?.Headers?.UserAgent?.ToString(),
            };

            if (responseMessage?.StatusCode != null)
            {
                requestContext.ResponseStatusCode = (int)responseMessage.StatusCode;
            }

            return requestContext;
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
                FilePath = frame.GetFileName(),
                LineNumber = frame.GetFileLineNumber(),
                FunctionName = frame.GetMethod()?.Name,
            };
        }

        /// <summary>
        /// Gets infromation about the exception that occured and populates
        /// a <see cref="ReportRequest"/> object.
        /// </summary>
        private ReportRequest CreateReportRequest(ExceptionLoggerContext context)
        {
            ErrorContext errorContext = new ErrorContext()
            {
                HttpRequest = CreateHttpRequestContext(context),
                ReportLocation = CreateSourceLocation(context)
            };

            ReportedErrorEvent errorEvent = new ReportedErrorEvent()
            {
                Message = context.Exception.ToString(),
                Context = errorContext,
                ServiceContext = _serviceContext,
            };
            return new ReportRequest(_service, errorEvent, _projectId);
        }
    }
}
