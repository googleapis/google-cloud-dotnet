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

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Google.Cloud.Diagnostics.AspNetCore3
{
    /// <summary>
    /// A <see cref="ILogEntryLabelProvider"/> implementation which adds the <see cref="HttpContext.TraceIdentifier"/> to the log entry labels.
    /// </summary>
    public class TraceIdLogEntryLabelProvider : HttpLogEntryLabelProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TraceIdLogEntryLabelProvider"/> class.
        /// </summary>
        /// <param name="httpContextAccessor">The <see cref="IHttpContextAccessor"/> instance with the <see cref="HttpContext"/>.</param>
        public TraceIdLogEntryLabelProvider(IHttpContextAccessor httpContextAccessor)
            : base(httpContextAccessor)
        {
        }

        /// <inheritdoc />
        protected override void InvokeCore(Dictionary<string, string> labels, HttpContext httpContext)
        {
            if (!string.IsNullOrEmpty(httpContext.TraceIdentifier))
            {
                labels["trace_identifier"] = httpContext.TraceIdentifier;
            }
        }
    }
}
