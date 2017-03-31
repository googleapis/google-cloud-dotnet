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
using System.Web.Http.ExceptionHandling;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// An <see cref="IContextWrapper"/> for an <see cref="ExceptionLoggerContext"/>.
    /// </summary>
    internal class ExceptionLoggerContextWrapper : IContextWrapper
    {
        private readonly ExceptionLoggerContext _context;

        internal ExceptionLoggerContextWrapper(ExceptionLoggerContext context)
        {
            _context = GaxPreconditions.CheckNotNull(context, nameof(context));
        }

        /// <inheritdoc />
        public string GetHttpMethod() => _context.ExceptionContext?.Request?.Method?.ToString();

        /// <inheritdoc />
        public string GetUri() => _context.ExceptionContext?.Request?.RequestUri?.ToString();

        /// <inheritdoc />
        public string GetUserAgent() => _context.ExceptionContext?.Request?.Headers?.UserAgent?.ToString();

        /// <inheritdoc />
        public int GetStatusCode() => (int) (_context.ExceptionContext?.Response?.StatusCode ?? 0);
    }
}