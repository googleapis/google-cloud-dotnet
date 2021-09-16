// Copyright 2016 Google Inc. All Rights Reserved.
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
using System.Net.Http;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Traces outgoing HTTP requests and propagates the trace header.
    /// </summary>
    /// <remarks>
    /// Ensures the trace header is propagated in the headers for outgoing HTTP requests and 
    /// traces the total time of the outgoing HTTP request. This is only done if tracing is initialized
    /// and tracing is enabled for the current request.
    /// </remarks>
    [Obsolete(
        "Use Google.Cloud.Diagnostics.Common.HttpClientBuilderExtensions.AddOutgoingGoogleTraceHandler insted. " +
        "For more information see " +
        "https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests")]
    public class TraceHeaderPropagatingHandler : UnchainedTraceHeaderPropagatingHandler
    {
        /// <summary>
        /// Constructs a new instance using the given delegate to obtain the "current" tracer
        /// on each request.
        /// </summary>
        /// <param name="managedTracerFactory">A delegate used to obtain the "current" tracer
        /// for each request. The delegate should therefore be thread-safe.</param>
        /// <param name="innerHandler">The inner handler to delegate to. May be null, in which
        /// case a new <see cref="HttpClientHandler"/> will be used.</param>
        public TraceHeaderPropagatingHandler(Func<IManagedTracer> managedTracerFactory, HttpMessageHandler innerHandler = null)
            :this(managedTracerFactory, null, innerHandler)
        { }

        /// <summary>
        /// Constructs a new instance using the given delegate to obtain the "current" tracer
        /// on each request.
        /// </summary>
        /// <param name="managedTracerFactory">A delegate used to obtain the "current" tracer
        /// for each request. The delegate should therefore be thread-safe.</param>
        /// <param name="traceContextPropagator">The trace context propagator used to set the trace context on the outgoing
        /// HTTP request. May be null, in which case the Google Trace Header will be set.</param>
        /// <param name="innerHandler">The inner handler to delegate to. May be null, in which
        /// case a new <see cref="HttpClientHandler"/> will be used.</param>
        public TraceHeaderPropagatingHandler(
            Func<IManagedTracer> managedTracerFactory, Action<HttpRequestMessage, ITraceContext> traceContextPropagator, HttpMessageHandler innerHandler = null)
            : base(managedTracerFactory, traceContextPropagator) =>
            InnerHandler = innerHandler ?? new HttpClientHandler();
    }
}
