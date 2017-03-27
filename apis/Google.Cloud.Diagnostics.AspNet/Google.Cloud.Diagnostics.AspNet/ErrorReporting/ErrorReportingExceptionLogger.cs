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
using System;
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
        private readonly IContextExceptionLogger _logger;

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
            GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
            var contextLogger = ErrorReportingContextExceptionLogger.Create(projectId, serviceName, version, options);
            return new ErrorReportingExceptionLogger(contextLogger);
        }

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingExceptionLogger"/> using credentials as
        /// defined by <see cref="GoogleCredential.GetApplicationDefaultAsync"/>.
        /// <para>
        /// Can be used when running on Google App Engine or Google Compute Engine.
        /// The Google Cloud Platform project to report errors to will detected from the
        /// current platform.
        /// </para>
        /// </summary>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job. Cannot be null.</param>
        /// <param name="version">Represents the source code version that the developer provided. Cannot be null.</param> 
        ///  <param name="options">Optional, error reporting options.</param>
        public static ErrorReportingExceptionLogger Create(
            string serviceName, string version, ErrorReportingOptions options = null)
        {
            var contextLogger = ErrorReportingContextExceptionLogger.Create(null, serviceName, version, options);
            return new ErrorReportingExceptionLogger(contextLogger);
        }

        internal ErrorReportingExceptionLogger(IContextExceptionLogger logger)
        {
            _logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));
        }

        /// <inheritdoc />
        public override Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            var contextWrapper = new ExceptionLoggerContextWrapper(context);
            return _logger.LogAsync(context.Exception, contextWrapper, cancellationToken);
        }

        /// <inheritdoc />
        public override void Log(ExceptionLoggerContext context)
        {
            var contextWrapper = new ExceptionLoggerContextWrapper(context);
            _logger.Log(context.Exception, contextWrapper);
        }

        /// <inheritdoc />
        public override bool ShouldLog(ExceptionLoggerContext context)
        {
            return context?.Exception != null;
        }

        /// <inheritdoc />
        public void Dispose() => _logger.Dispose();
    }
}
