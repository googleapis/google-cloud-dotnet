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
using System.Diagnostics;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.AspNetCore
{
    /// <summary>
    /// Middleware that will, when invoked, call the next <see cref="RequestDelegate"/>,
    /// and trace the time taken for the next delegate to run.  The time taken and metadata
    /// will be sent to the Stackdriver Trace API.
    /// </summary>
    internal sealed class CloudTraceMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IManagedTracerFactory _tracerFactory;
        private readonly IHttpContextAccessor _accessor;

        /// <summary>
        /// Create a new instance of <see cref="CloudTraceMiddleware"/>.
        /// </summary>
        /// <param name="next">The next request delegate. Cannot be null.</param>
        /// <param name="tracerFactory">A factory to create <see cref="IManagedTracer"/>s. Cannot be null.</param>
        /// <param name="accessor">Access to <see cref="HttpContext"/>. Cannot be null.</param>
        public CloudTraceMiddleware(
            RequestDelegate next, IManagedTracerFactory tracerFactory, IHttpContextAccessor accessor)
        {
            _next = GaxPreconditions.CheckNotNull(next, nameof(next));
            _tracerFactory = GaxPreconditions.CheckNotNull(tracerFactory, nameof(tracerFactory));
            _accessor = GaxPreconditions.CheckNotNull(accessor, nameof(accessor));
        }

        /// <summary>
        /// Invokes the next <see cref="RequestDelegate"/> and traces the time 
        /// taken for the next delegate to run, reporting the results to the
        /// Stackdriver Trace API.
        /// </summary>
        /// <param name="httpContext">The current HTTP context.</param>
        /// <param name="traceHeaderContext">Information from the current request header. Cannot be null.</param>
        public async Task Invoke(HttpContext httpContext, TraceHeaderContext traceHeaderContext)
        {
            GaxPreconditions.CheckNotNull(traceHeaderContext, nameof(traceHeaderContext));

            // Create a tracer for the given request and set it on the HttpContext so
            // the tracer can be used in other places.
            var tracer = _tracerFactory.CreateTracer(traceHeaderContext);
            ContextTracerManager.SetCurrentTracer(_accessor, tracer);

            if (tracer.GetCurrentTraceId() == null)
            {
                await _next(httpContext).ConfigureAwait(false);
            }
            else
            {
                if (traceHeaderContext.TraceId != null)
                {
                    // Set the trace updated trace header on the response.
                    var updatedHeaderContext = TraceHeaderContext.Create(
                        tracer.GetCurrentTraceId(), tracer.GetCurrentSpanId() ?? 0, true);
                    httpContext.Response.Headers.Add(
                        TraceHeaderContext.TraceHeader, updatedHeaderContext.ToString());
                }

                // Trace the delegate and annotate it with information from the current
                // HTTP context.
                var span = tracer.StartSpan(httpContext.Request.Path);
                try
                {
                    await _next(httpContext).ConfigureAwait(false);
                }
                catch (Exception exception)
                {
                    try
                    {
                        StackTrace stackTrace = new StackTrace(exception, true);
                        tracer.SetStackTrace(stackTrace);
                    }
                    catch (Exception innerException)
                    {
                        throw new AggregateException(innerException, exception);
                    }
                    throw;
                }
                finally
                {
                    tracer.AnnotateSpan(Labels.AgentLabel);
                    tracer.AnnotateSpan(Labels.FromHttpContext(httpContext));
                    span.Dispose();
                }
            }
        }
    }
}
