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
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// Google Cloud Error Reporting Logger. Reports exceptions to Stackdriver Error Reporting API.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// string projectId = "[Google Cloud Platform project ID]";
    /// string serviceName = "[Name of service]";
    /// string version = "[Version of service]";
    /// var exceptionLogger = GoogleExceptionLogger.Create(projectId, serviceName, version);
    ///
    /// try
    /// {
    ///     string scores = File.ReadAllText(@"C:\Scores.txt");
    ///     Console.WriteLine(scores);
    /// }
    /// catch (IOException e)
    /// {
    ///     exceptionLogger.Log(e);
    /// }
    /// </code>
    /// </example>
    public class GoogleExceptionLogger : IExceptionLogger, IDisposable
    {
        private readonly IContextExceptionLogger _logger;

        internal GoogleExceptionLogger(IContextExceptionLogger logger) {
            _logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));
        }

        /// <summary>
        /// Creates an instance of <see cref="GoogleExceptionLogger"/>.
        /// </summary>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        /// <param name="serviceName">An identifier of the service, such as the name of the executable or job.
        ///     Cannot be null.</param>
        /// <param name="version">Represents the source code version that the developer provided. 
        ///     Cannot be null.</param>
        /// <param name="options">Optional, error reporting options.</param>
        public static GoogleExceptionLogger Create(string projectId, string serviceName, string version,
            ErrorReportingOptions options = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId));
            var contextLogger = ErrorReportingContextExceptionLogger.Create(projectId, serviceName, version, options);
            return new GoogleExceptionLogger(contextLogger);
        }

        /// <summary>
        /// Creates an instance of <see cref="GoogleExceptionLogger"/>.
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
        public static GoogleExceptionLogger Create(string serviceName, string version,
            ErrorReportingOptions options = null)
        {
            var contextLogger = ErrorReportingContextExceptionLogger.Create(null, serviceName, version, options);
            return new GoogleExceptionLogger(contextLogger);
        }

        /// <inheritdoc />
        public void Log(Exception exception, HttpContext context = null)
        {
            context = context ?? HttpContext.Current;
            var contextWrapper = new HttpContextWrapper(context);
            _logger.Log(exception, contextWrapper);
        }

        /// <inheritdoc />
        public Task LogAsync(Exception exception, HttpContext context = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            context = context ?? HttpContext.Current;
            var contextWrapper = new HttpContextWrapper(context);
            return _logger.LogAsync(exception, contextWrapper, cancellationToken);
        }

        /// <inheritdoc />
        public void Dispose() => _logger.Dispose();
    }
}
