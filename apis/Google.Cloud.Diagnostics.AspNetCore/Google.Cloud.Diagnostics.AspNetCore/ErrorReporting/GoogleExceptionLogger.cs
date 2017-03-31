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
using Microsoft.AspNetCore.Http;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Google Cloud Error Reporting Logger. Reports exceptions to the Stackdriver Error Reporting API.
    /// </summary>
    /// 
    /// <example>
    /// <code>
    /// public void ReadFile(IExceptionLogger exceptionLogger)
    /// {
    ///     try
    ///     {
    ///         string scores = File.ReadAllText(@"C:\Scores.txt");
    ///         Console.WriteLine(scores);
    ///     }
    ///     catch (IOException e)
    ///     {
    ///         exceptionLogger.Log(e);
    ///     }
    /// }
    /// </code>
    /// </example>
    internal sealed class GoogleExceptionLogger : IExceptionLogger
    {
        private readonly IContextExceptionLogger _logger;
        private readonly IHttpContextAccessor _accesor;

        internal GoogleExceptionLogger(
           IContextExceptionLogger logger, IHttpContextAccessor accesor)   
        {
            _logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));
            _accesor = GaxPreconditions.CheckNotNull(accesor, nameof(accesor));
        }

        /// <inheritdoc />
        public Task LogAsync(Exception exception, HttpContext context = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            context = context ?? _accesor.HttpContext;
            var contextWrapper = new HttpContextWrapper(context);
            return _logger.LogAsync(exception, contextWrapper, cancellationToken);
        }

        /// <inheritdoc />
        public void Log(Exception exception, HttpContext context = null)
        {
            context = context ?? _accesor.HttpContext;
            var contextWrapper = new HttpContextWrapper(context);
            _logger.Log(exception, contextWrapper);
        }
    }
}
