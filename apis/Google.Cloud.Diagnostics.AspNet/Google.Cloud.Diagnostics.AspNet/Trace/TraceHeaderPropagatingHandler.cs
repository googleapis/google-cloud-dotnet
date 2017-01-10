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

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// Traces outgoing http requests and propigates the trace header.
    /// </summary>
    ///
    /// <example>
    /// <code>
    /// public void DoSomething()
    /// {
    ///     var traceHeaderHandler = TraceHeaderPropagatingHandler.Create();
    ///     using (var httpClient = HttpClientFactory.Create(traceHeaderHandler))
    ///     {
    ///         ...
    ///     }
    /// }
    /// </code>
    /// </example>
    /// <remarks>
    /// Ensures the tracer header is propagated along in the http headers for outgoing http requests and 
    /// traces the total time of the outgoing http request.  This is only done if tracing is initialized
    /// (See <see cref="CloudTrace.Initialize"/>) and tracing is enabled for the request current request
    /// (See <see cref="CloudTrace.ShouldTrace"/>).
    /// 
    /// By default when initialized a small sampling of http requests will automatically be traced.  Additional
    /// trace data can be collected manually.
    /// 
    /// Docs: https://cloud.google.com/trace/docs/
    /// </remarks>
    public class TraceHeaderPropagatingHandler : DelegatingHandler
    {
        private TraceHeaderPropagatingHandler() { }

        /// <summary>Gets a <see cref="TraceHeaderPropagatingHandler"/>.</summary>
        public static TraceHeaderPropagatingHandler Create() => new TraceHeaderPropagatingHandler();

        /// <summary>
        /// Sends the given request.  If tracing is initialized and enabled the outgoing request is
        /// traced and the trace header is added to the request.
        /// </summary>
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        { 
            if (!CloudTrace.ShouldTrace())
            {
                return await base.SendAsync(request, cancellationToken);
            }

            var tracer = CloudTrace.GetCurrentTracer();

            var traceHeader = TraceHeaderContext.Create(
                tracer.GetCurrentTraceId(), tracer.GetCurrentSpanId() ?? 0, true);
            request.Headers.Add(TraceHeaderContext.TraceHeader, traceHeader.ToString());
            
            tracer.StartSpan(request.RequestUri.AbsoluteUri);
            var tracedRequest = await base.SendAsync(request, cancellationToken);
            tracer.EndSpan();

            return tracedRequest;
        }
    }
}
