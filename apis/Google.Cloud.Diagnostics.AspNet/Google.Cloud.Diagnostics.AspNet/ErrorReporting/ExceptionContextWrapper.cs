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
using System.Web.Mvc;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// An <see cref="IContextWrapper"/> for an <see cref="ExceptionContext"/>.
    /// </summary>
    internal class ExceptionContextWrapper : IContextWrapper
    {
        private readonly ExceptionContext _context;

        internal ExceptionContextWrapper(ExceptionContext context)
        {
            _context = GaxPreconditions.CheckNotNull(context, nameof(context));
        }

        /// <inheritdoc />
        public string GetHttpMethod() => _context.HttpContext?.Request?.HttpMethod;

        /// <inheritdoc />
        public string GetUri() => _context.HttpContext?.Request?.Url?.ToString();

        /// <inheritdoc />
        public string GetUserAgent() => _context.HttpContext?.Request?.UserAgent;

        /// <inheritdoc />
        public int GetStatusCode() => _context.HttpContext?.Response?.StatusCode ?? 0;
    }
}
