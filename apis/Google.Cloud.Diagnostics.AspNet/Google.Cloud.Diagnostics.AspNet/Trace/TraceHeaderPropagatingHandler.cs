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

using Google.Cloud.Diagnostics.Common;
using System.Net.Http;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// Traces outgoing HTTP requests and propagates the trace header.
    /// </summary>
    ///
    /// <example>
    /// <code>
    /// public void DoSomething()
    /// {
    ///     var traceHeaderHandler = TraceHeaderPropagatingHandler.Create();
    ///     using (var httpClient = new HttpClient(traceHeaderHandler))
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
    public class TraceHeaderPropagatingHandler : AbstractTraceHeaderPropagatingHandler
    {
        private TraceHeaderPropagatingHandler(HttpMessageHandler innerHandler) : base(innerHandler) { }
        
        /// <summary>
        /// Creates a <see cref="TraceHeaderPropagatingHandler"/>.
        /// </summary>
        /// <param name="innerHandler">Optional message handler.  If non is set an
        ///     <see cref="HttpClientHandler"/>will be used.</param>
        public static TraceHeaderPropagatingHandler Create(HttpMessageHandler innerHandler = null) =>
            new TraceHeaderPropagatingHandler(innerHandler ?? new HttpClientHandler());

        /// <inheritdoc />
        internal override IManagedTracer GetCurrentTracer() => CloudTrace.CurrentTracer;
    }
}
