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
using Google.Cloud.Diagnostics.Common;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.ErrorReporting.V1Beta1;
using System.Web;
using System.Web.Mvc;
using Google.Protobuf.WellKnownTypes;
using System;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    ///  Google Cloud Error Reporting <see cref="IExceptionFilter"/>.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    /// {
    ///   // Add a catch all for the uncaught exceptions.
    ///   string projectId = "[Google Cloud Platform project ID]";
    ///   string serviceName = "[Name of service]";
    ///   string version = "[Version of service]";
    ///   // Add a catch all for the uncaught exceptions.
    ///   filters.Add(ErrorReportingExceptionFilter.Create(projectId, serviceName, version));
    /// }
    /// </code>
    /// </example>
    /// 
    /// <remarks>
    /// Reports unhandled exceptions to Google Cloud Error Reporting.
    /// The filter should be registered first in ASP.NET MVC versions 1 and 2 and last
    /// in ASP.NET MVC versions 3 and higher. See:
    /// https://msdn.microsoft.com/en-us/library/system.web.mvc.iexceptionfilter.onexception(v=vs.118).aspx
    /// Docs: https://cloud.google.com/error-reporting/docs/
    /// </remarks>
    public class ErrorReportingExceptionFilter : IExceptionFilter, IDisposable
    {
        private readonly ErrorReportingExceptionLoggerBase _logger;

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingExceptionFilter"/> using credentials as
        /// defined by <see cref="GoogleCredential.GetApplicationDefaultAsync"/>.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.
        ///     Cannot be null.</param>
        /// <param name="version">Represents the source code version that the developer provided. 
        ///     Cannot be null.</param>
        /// <param name="options">Optional, error reporting options.</param>
        public static ErrorReportingExceptionFilter Create(string projectId, string serviceName, string version,
            ErrorReportingOptions options = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
            return CreateBase(projectId, serviceName, version, options);
        }

        /// <summary>
        /// Creates an instance of <see cref="ErrorReportingExceptionFilter"/> using credentials as
        /// defined by <see cref="GoogleCredential.GetApplicationDefaultAsync"/>.
        /// <para>
        /// Can be used when running on Google App Engine or Google Compute Engine.
        /// The Google Cloud Platform project to report errors to will detected from the
        /// current platform.
        /// </para>
        /// </summary>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.
        ///     Cannot be null.</param>
        /// <param name="version">Represents the source code version that the developer provided. 
        ///     Cannot be null.</param>
        /// <param name="options">Optional, error reporting options.</param>
        public static ErrorReportingExceptionFilter Create(
            string serviceName, string version, ErrorReportingOptions options = null) =>
                CreateBase(null, serviceName, version, options);

        /// <summary>
        /// Shared code for creating <see cref="ErrorReportingExceptionFilter"/>.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID. If null the project Id will be auto detected.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.
        ///     Cannot be null.</param>
        /// <param name="version">Represents the source code version that the developer provided. 
        ///     Cannot be null.</param>
        /// <param name="options">Optional, error reporting options.</param>
        private static ErrorReportingExceptionFilter CreateBase(string projectId, string serviceName, string version,
            ErrorReportingOptions options = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(serviceName, nameof(serviceName));
            GaxPreconditions.CheckNotNullOrEmpty(version, nameof(version));

            options = options ?? ErrorReportingOptions.Create(projectId);
            var consumer = options.CreateConsumer();
            var logger = new ErrorReportingExceptionLoggerBase(consumer, serviceName, version);
            return new ErrorReportingExceptionFilter(logger);
        }

        internal ErrorReportingExceptionFilter(ErrorReportingExceptionLoggerBase logger)
        {
            _logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));
        }

        /// <inheritdoc />
        public void OnException(ExceptionContext context)
        {
            var contextWrapper = ExceptionContextWrapper.FromExceptionContext(context);
            _logger.Log(context.Exception, contextWrapper);
        }

        /// <inheritdoc />
        public void Dispose() => _logger.Dispose();
    }
}
