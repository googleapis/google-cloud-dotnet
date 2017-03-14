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
using System.Threading.Tasks;
using System.Web;

namespace Google.Cloud.Diagnostics.AspNet
{
    internal class GoogleExceptionLogger : IExceptionLogger
    {
        private readonly ErrorReportingExceptionLoggerBase _logger;

        internal GoogleExceptionLogger(ErrorReportingExceptionLoggerBase logger) {
            _logger = GaxPreconditions.CheckNotNull(logger, nameof(logger));
        }

        public Task LogAsync(Exception exception, HttpContext context = null)
        {
            context = context ?? HttpContext.Current;
            var contextWrapper = HttpContextWrapper.FromHttpContext(context);
            return _logger.LogAsync(exception, contextWrapper);
        }

        public void Log(Exception exception, HttpContext context = null)
        {
            context = context ?? HttpContext.Current;
            var contextWrapper = HttpContextWrapper.FromHttpContext(context);
            _logger.Log(exception, contextWrapper);
        }
    }
}
