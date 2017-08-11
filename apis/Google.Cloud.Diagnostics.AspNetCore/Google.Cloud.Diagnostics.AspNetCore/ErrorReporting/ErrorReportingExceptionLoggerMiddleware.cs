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
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Middleware that will, when invoked, call the next <see cref="RequestDelegate"/>,
    /// catch any exception that it may throw, send that exception to the
    /// Stackdriver Error Reporting API and rethrow the given exception.
    /// </summary>
    public sealed class ErrorReportingExceptionLoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IExceptionLogger _logger;

        /// <summary>
        /// Create a new instance of <see cref="ErrorReportingExceptionLoggerMiddleware"/>.
        /// </summary>
        /// <param name="next">The next request delegate. Cannot be null.</param>
        /// <param name="logger">A logger that will report exceptions. Cannot be null.</param>
        public ErrorReportingExceptionLoggerMiddleware(RequestDelegate next, IExceptionLogger logger)
        {
            _next = GaxPreconditions.CheckNotNull(next, nameof(next));
            _logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));
        }

        /// <summary>
        /// Invokes the next <see cref="RequestDelegate"/>, catches any exception thrown,
        /// reports the exception to the  Stackdriver Error Reporting API and rethrows
        /// the exception.
        /// </summary>
        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext).ConfigureAwait(false);
            }
            catch (Exception exception)
            {
                try
                {
                    await _logger.LogAsync(exception, httpContext).ConfigureAwait(false);
                }
                catch (Exception innerException)
                {
                    throw new AggregateException(innerException, exception);
                }
                throw;
            }
        }
    }
}
