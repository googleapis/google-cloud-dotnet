// Copyright 2018 Google Inc. All Rights Reserved.
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

using Google.Cloud.Diagnostics.Common;
using System.Web.Http.Controllers;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// An <see cref="IContextWrapper"/> for an <see cref="HttpActionContext"/>.
    /// </summary>
    internal class HttpActionContextWrapper : IContextWrapper
    {
        private readonly HttpActionContext _context;

        internal HttpActionContextWrapper(HttpActionContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public string GetHttpMethod() => _context?.Request?.Method?.Method;

        /// <inheritdoc />
        public string GetUri() => _context?.Request?.RequestUri?.ToString();

        /// <inheritdoc />
        public string GetUserAgent() => _context?.Request?.Headers?.UserAgent?.ToString();
    }
}
