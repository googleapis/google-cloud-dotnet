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
    /// <remarks>
    /// Reports unhandled exceptions to Google Cloud Error Reporting.
    /// Docs: https://cloud.google.com/error-reporting/docs/
    /// </remarks>
    public sealed class ErrorReportingExceptionLogger
    {
        /// <summary> The Google Cloud Platform project id.</summary>
        private readonly ProjectName _projectName;

        ///<summary>
        /// The service context in which this error has occurred.
        /// See: https://cloud.google.com/error-reporting/reference/rest/v1beta1/projects.events#ServiceContext
        /// </summary>
        private readonly ServiceContext _serviceContext;

        /// <summary>The client to report errors with.</summary>
        private readonly Task<ReportErrorsServiceClient> _clientTask;

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingExceptionLogger"/>
        /// </summary>
        /// <param name="client">The Error Reporting client.</param>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.</param>
        /// <param name="version">Represents the source code version that the developer provided.</param> 
        public static ErrorReportingExceptionLogger Create(
            ReportErrorsServiceClient client, string projectId, string serviceName, string version) =>
            Create(Task.FromResult(client), projectId, serviceName, version);

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingExceptionLogger"/>
        /// </summary>
        /// <param name="clientTask">The Error Reporting client.</param>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.</param>
        /// <param name="version">Represents the source code version that the developer provided.</param> 
        public static ErrorReportingExceptionLogger Create(
            Task<ReportErrorsServiceClient> clientTask, string projectId, string serviceName, string version) =>
            new ErrorReportingExceptionLogger(clientTask, projectId, serviceName, version);

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingExceptionLogger"/> using credentials as
        /// defined by <see cref="GoogleCredential.GetApplicationDefaultAsync"/>.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.</param>
        /// <param name="version">Represents the source code version that the developer provided.</param> 
        public static ErrorReportingExceptionLogger Create(
            string projectId, string serviceName, string version) =>
            Create(ReportErrorsServiceClient.CreateAsync(), projectId, serviceName, version);

        private ErrorReportingExceptionLogger(
           Task<ReportErrorsServiceClient> clientTask, string projectId, string serviceName, string version)
        {
            GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            _clientTask = GaxPreconditions.CheckNotNull(clientTask, nameof(clientTask));
            _projectName = new ProjectName(projectId);
            _serviceContext = new ServiceContext
            {
                Service = GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName)),
                Version = GaxPreconditions.CheckNotNull(version, nameof(version)),
            };
        }

        /// <summary>
        /// Asyncronously reports an exception that occured to the Stackdriver Error Reporting API.
        /// </summary>
        public async Task<ReportErrorEventResponse> ReportAsync(HttpContext context, Exception exception)
        {
            var errorEvent = CreateReportRequest(context, exception);
            var client = await _clientTask;
            return await client.ReportErrorEventAsync(_projectName, errorEvent);
        }

        /// <summary>
        /// Reports an exception that occured to the Stackdriver Error Reporting API.
        /// </summary>
        public ReportErrorEventResponse Report(HttpContext context, Exception exception)
        {
            var errorEvent = CreateReportRequest(context, exception);
            // If the client task has faulted this will throw when accessing 'Result'
            return _clientTask.Result.ReportErrorEvent(_projectName, errorEvent);
        }

        /// <summary>
        /// Gets information about the HTTP request and response when the exception occured 
        /// and populates a <see cref="HttpRequestContext"/> object.
        /// </summary>
        private HttpRequestContext CreateHttpRequestContext(HttpContext context)
        {
            HttpRequest request = context?.Request;
            HttpResponse response = context?.Response;

            return new HttpRequestContext()
            {
                Method = request?.Method?.ToString() ?? "",
                Url = UriHelper.GetDisplayUrl(request) ?? "",
                UserAgent = request?.Headers["User-Agent"] ?? "",
                ResponseStatusCode = response?.StatusCode ?? 0,
            };
        }

        /// <summary>
        /// Gets information about the source location where the exception occured 
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
            if (frames.Length == 0)
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
        /// Gets infromation about the exception that occured and populates
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
            };
        }
    }
}
