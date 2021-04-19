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

using Google.Api.Gax;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Class for tracing outgoing HTTP requests and propagating the trace context.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Ensures the trace context is propagated for outgoing HTTP requests and 
    /// traces the total time of the outgoing HTTP request. This is only done if tracing is initialized
    /// and tracing is enabled for the current request.
    /// </para>
    /// <para>
    /// Explicitly leaves unset the InnerHandler property so that this Handler can be used with the
    /// System.Net.Http.IHttpClientFactory defined in Microsoft.Extensions.Http.
    /// </para>
    /// </remarks>
    public class UnchainedTraceHeaderPropagatingHandler : DelegatingHandler
    {
        private readonly Func<IManagedTracer> _managedTracerFactory;
        private readonly Action<HttpRequestMessage, ITraceContext> _traceContextPropagator;

        /// <summary>
        /// Constructs a new instance using the given delegate to obtain the "current" tracer
        /// on each request.
        /// </summary>
        /// <param name="managedTracerFactory">A delegate used to obtain the "current" tracer
        /// for each request. The delegate should therefore be thread-safe.</param>
        public UnchainedTraceHeaderPropagatingHandler(Func<IManagedTracer> managedTracerFactory)
            : this(managedTracerFactory, traceContextPropagator: null)
        { }

        /// <summary>
        /// Constructs a new instance using the given delegate to obtain the "current" tracer
        /// on each request.
        /// </summary>
        /// <param name="managedTracerFactory">A delegate used to obtain the "current" tracer
        /// for each request. The delegate should therefore be thread-safe.</param>
        /// <param name="traceContextPropagator">The trace context propagator used to set the trace context on the outgoing
        /// HTTP request. May be null, in which case the Google Trace Header will be set.</param>
        public UnchainedTraceHeaderPropagatingHandler(Func<IManagedTracer> managedTracerFactory, Action<HttpRequestMessage, ITraceContext> traceContextPropagator)
        {
            _managedTracerFactory = GaxPreconditions.CheckNotNull(managedTracerFactory, nameof(managedTracerFactory));
            _traceContextPropagator = traceContextPropagator ?? PropagateGoogleTraceHeader;
        }

        /// <summary>
        /// Sends the given request. If tracing is initialized and enabled the outgoing request is traced
        /// and the trace context is propagated.
        /// </summary>
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var tracer = _managedTracerFactory();
            if (SimpleTraceContext.FromTracer(tracer) is SimpleTraceContext traceContext)
            {
                _traceContextPropagator(request, traceContext);

                return tracer.RunInSpanAsync(
                    async () =>
                    {
                        tracer.AnnotateSpan(TraceLabels.FromHttpRequestMessage(request));
                        var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
                        tracer.AnnotateSpan(TraceLabels.FromHttpResponseMessage(response));
                        return response;
                    },
                    request.RequestUri.ToString());
            }

            return base.SendAsync(request, cancellationToken);
        }

        private static void PropagateGoogleTraceHeader(HttpRequestMessage request, ITraceContext context) =>
            request.Headers.Add(TraceHeaderContext.TraceHeader, new TraceHeaderContext(context.TraceId, context.SpanId ?? 0, context.ShouldTrace).ToString());
    }
}
