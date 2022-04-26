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

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Middleware that will, when invoked, call the next <see cref="RequestDelegate"/>,
    /// and trace the time taken for the next delegate to run.  The time taken and metadata
    /// will be sent to the Google Cloud Trace API.
    /// </summary>
    internal sealed class CloudTraceMiddleware
    {
        private readonly ICloudTraceNameProvider _nameProvider;
        private readonly RequestDelegate _next;
        private readonly Func<ITraceContext, IManagedTracer> _tracerFactory;

        /// <summary>
        /// Create a new instance of <see cref="CloudTraceMiddleware"/>.
        /// </summary>
        /// <param name="next">The next request delegate. Must not be null.</param>
        /// <param name="tracerFactory">A factory to create <see cref="IManagedTracer"/>s. Must not be null.</param>
        /// <param name="nameProvider">The cloud trace name provider used for naming the root trace span</param>
        public CloudTraceMiddleware(
            RequestDelegate next, Func<ITraceContext, IManagedTracer> tracerFactory, ICloudTraceNameProvider nameProvider)
        {
            _next = GaxPreconditions.CheckNotNull(next, nameof(next));
            _tracerFactory = GaxPreconditions.CheckNotNull(tracerFactory, nameof(tracerFactory));
            _nameProvider = nameProvider;
        }

        /// <summary>
        /// Invokes the next <see cref="RequestDelegate"/> and traces the time 
        /// taken for the next delegate to run, reporting the results to the
        /// Google Cloud Trace API.
        /// </summary>
        /// <param name="httpContext">The current HTTP context.</param>
        /// <param name="traceContext">Trace information from the current request. Must not be null.</param>
        /// <param name="fallback">Predicate to be used if the trace context has no information about whether
        /// the request should be traced or not.</param>
        /// <param name="traceContextPropagator">Trace context propagator to be used to set the trace context
        /// on the <see cref="HttpResponse"/>. Must not be null.</param>
        public async Task Invoke(
            HttpContext httpContext, ITraceContext traceContext, TraceDecisionPredicate fallback, Action<HttpResponse, ITraceContext> traceContextPropagator)
        {
            GaxPreconditions.CheckNotNull(traceContext, nameof(traceContext));
            GaxPreconditions.CheckNotNull(traceContextPropagator, nameof(traceContextPropagator));

            // Applies the trace decision fallback, if needed.
            traceContext = WithShouldTraceFallback(traceContext, fallback.ShouldTrace(httpContext.Request));

            // Create a tracer for the given request and set it on the context manager so
            // the tracer can be used in other places.
            var tracer = _tracerFactory(traceContext);
            ContextTracerManager.SetCurrentTracer(tracer);

            if (tracer.GetCurrentTraceId() == null)
            {
                await _next(httpContext).ConfigureAwait(false);
            }
            else
            {
                if (traceContext.TraceId != null)
                {
                    // Set the current trace context on the response.
                    var currentTraceContext = ContextTracerManager.GetCurrentTraceContext();
                    traceContextPropagator.Invoke(httpContext.Response, currentTraceContext);
                }

                // Trace the delegate and annotate it with information from the current
                // HTTP context.
                var traceName = await _nameProvider.GetTraceNameAsync(httpContext).ConfigureAwait(false);
                var span = tracer.StartSpan(traceName);
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

        private ITraceContext WithShouldTraceFallback(ITraceContext context, bool? fallback) =>
            context.ShouldTrace is null && fallback is bool ? new SimpleTraceContext(context.TraceId, context.SpanId, fallback) : context;
    }
}
