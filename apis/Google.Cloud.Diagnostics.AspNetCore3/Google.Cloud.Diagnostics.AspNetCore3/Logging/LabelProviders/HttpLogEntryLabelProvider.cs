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

using System;
using System.Collections.Generic;
using Google.Api.Gax;
using Microsoft.AspNetCore.Http;

namespace Google.Cloud.Diagnostics.AspNetCore3
{
    /// <summary>
    /// Base class for <see cref="ILogEntryLabelProvider"/> implementations which needs an <see cref="HttpContext"/> instance.
    /// </summary>
#pragma warning disable CS0618 // Type or member is obsolete
    public abstract class HttpLogEntryLabelProvider : ILogEntryLabelProvider, Common.ILogEntryLabelProvider
#pragma warning restore CS0618 // Type or member is obsolete
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// Initializes the <see cref="HttpLogEntryLabelProvider"/> base class.
        /// </summary>
        /// <param name="httpContextAccessor">The <see cref="IHttpContextAccessor"/> instance with the <see cref="HttpContext"/>.</param>
        protected HttpLogEntryLabelProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = GaxPreconditions.CheckNotNull(httpContextAccessor, nameof(httpContextAccessor));
        }

        /// <inheritdoc/>
        public void Invoke(Dictionary<string, string> labels)
        {
            if (_httpContextAccessor.HttpContext != null)
            {
                InvokeCore(labels, _httpContextAccessor.HttpContext);
            }
        }

        /// <summary>
        /// In a derived class, invokes the core logic of the <see cref="ILogEntryLabelProvider"/> using the <see cref="HttpContext"/> instance.
        /// </summary>
        /// <param name="labels">The log entry labels to augment.</param>
        /// <param name="httpContext">The <see cref="HttpContext"/> instance.</param>
        protected abstract void InvokeCore(Dictionary<string, string> labels, HttpContext httpContext);
    }
}
