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
    /// Class for tracing outgoing HTTP requests and propagating the trace header.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Ensures the trace header is propagated in the headers for outgoing HTTP requests and 
    /// traces the total time of the outgoing HTTP request. This is only done if tracing is initialized
    /// and tracing is enabled for the request current request.
    /// </para>
    /// <para>
    /// Explicitly leaves unset the InnerHandler property so that this Handler can be used with the
    /// System.Net.Http.IHttpClientFactory defined in Microsoft.Extensions.Http.
    /// </para>
    /// </remarks>
    public class UnchainedTraceHeaderPropagatingHandler : DelegatingHandler
    {
        private readonly Func<IManagedTracer> _managedTracerFactory;

        /// <summary>
        /// Constructs a new instance using the given delegate to obtain the "current" tracer
        /// on each request.
        /// </summary>
        /// <param name="managedTracerFactory">A delegate used to obtain the "current" tracer
        /// for each request. The delegate should therefore be thread-safe.</param>
        public UnchainedTraceHeaderPropagatingHandler(Func<IManagedTracer> managedTracerFactory)
        {
            _managedTracerFactory = GaxPreconditions.CheckNotNull(managedTracerFactory, nameof(managedTracerFactory));
        }

        /// <summary>
        /// Sends the given request. If tracing is initialized and enabled the outgoing request is
        /// traced and the trace header is added to the request.
        /// </summary>
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var tracer = _managedTracerFactory();
            if (tracer.GetCurrentTraceId() == null)
            {
                return base.SendAsync(request, cancellationToken);
            }

            var traceHeader = TraceHeaderContext.Create(
                tracer.GetCurrentTraceId(), tracer.GetCurrentSpanId() ?? 0, true);
            request.Headers.Add(TraceHeaderContext.TraceHeader, traceHeader.ToString());

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
    }
}
