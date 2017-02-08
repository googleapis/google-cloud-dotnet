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

using Google.Api.Gax;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Traces outgoing HTTP requests and propagates the trace header.
    /// </summary>
    ///
    /// <example>
    /// <code>
    /// public void DoSomething(IManagedTracer tracer)
    /// {
    ///     var traceHeaderHandler = TraceHeaderPropagatingHandler.Create(tracer);
    ///     using (var httpClient = HttpClientFactory.Create(traceHeaderHandler))
    ///     {
    ///         ...
    ///     }
    /// }
    /// </code>
    /// </example>
    /// <remarks>
    /// Ensures the trace header is propagated in the headers for outgoing HTTP requests and 
    /// traces the total time of the outgoing HTTP request.  This is only done if tracing is initialized
    /// and tracing is enabled for the request current request.
    /// </remarks>
    public class TraceHeaderPropagatingHandler : DelegatingHandler
    {
        private readonly IManagedTracer _tracer;

        private TraceHeaderPropagatingHandler(IManagedTracer tracer)
        {
            _tracer = GaxPreconditions.CheckNotNull(tracer, nameof(tracer));
        }

        /// <summary>
        /// Gets a <see cref="TraceHeaderPropagatingHandler"/>.
        /// </summary>
        /// <param name="tracer">The tracer to trace with. Cannot be null.</param>
        public static TraceHeaderPropagatingHandler Create(IManagedTracer tracer) =>
            new TraceHeaderPropagatingHandler(tracer);

        /// <summary>
        /// Sends the given request.  If tracing is initialized and enabled the outgoing request is
        /// traced and the trace header is added to the request.
        /// </summary>
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (_tracer.GetCurrentTraceId() == null)
            {
                return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }

            var traceHeader = TraceHeaderContext.Create(
                _tracer.GetCurrentTraceId(), _tracer.GetCurrentSpanId() ?? 0, true);
            request.Headers.Add(TraceHeaderContext.TraceHeader, traceHeader.ToString());

            _tracer.StartSpan(request.RequestUri.ToString());
            try
            {
                return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                StackTrace stackTrace = new StackTrace(e, true);
                _tracer.SetStackTrace(stackTrace);
                throw;
            }
            finally
            {
                _tracer.EndSpan();
            }
        }
    }
}
