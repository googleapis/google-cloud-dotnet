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
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    public sealed class CloudTraceMiddleware
    {
        private readonly RequestDelegate _next;

        public CloudTraceMiddleware(RequestDelegate next)
        {
            _next = GaxPreconditions.CheckNotNull(next, nameof(next));
        }

        public async Task Invoke(HttpContext httpContext, IManagedTracer tracer)
        {
            GaxPreconditions.CheckNotNull(tracer, nameof(tracer));

            if (tracer.GetCurrentTraceId() == null)
            {
                await _next(httpContext);
            }
            else
            {
                tracer.StartSpan(httpContext.Request.Path);
                await _next(httpContext);
                tracer.AnnotateSpan(Labels.AgentLabel);
                tracer.AnnotateSpan(Labels.FromHttpContext(httpContext));
                tracer.EndSpan();
            }
        }
    }
}
