// Copyright 2020 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Diagnostics.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Primitives;
using System;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3
#elif NETSTANDARD2_0
namespace Google.Cloud.Diagnostics.AspNetCore
#else
#error unknown target framework
#endif
{
    /// <summary>
    /// Represents a trace context (Trace ID and Span ID)
    /// for a log entry.
    /// These values can be attached to a log entry to establish the
    /// relation of it and a trace.
    /// </summary>
    [Obsolete("Use Google.Cloud.Diagnostics.Common.ITraceContext instead.")]
    public sealed class TraceContextForLogEntry
    {
        /// <summary>
        /// The trace ID to associate the log entry with.
        /// Must not be null.
        /// </summary>
        public string TraceId { get; }

        /// <summary>
        /// The span ID to associate the log entry with,
        /// or null if there's currently no open span.
        /// </summary>
        /// <remarks>
        /// For this to be matched to a span being stored in Google Cloud Trace,
        /// its format should be the same that the Trace API v2 uses: a 16-character hexadecimal
        /// encoding of an 8-byte array, such as `000000000000004a`. A check is not performed
        /// to ensure this format is used, so as to allow for this value to refer to spans other
        /// than those stored in Google Cloud Trace.
        /// </remarks>
        public string SpanId { get; }

        /// <summary>
        /// Creates a new trace context.
        /// </summary>
        /// <param name="traceId">The trace ID. Must not be null.</param>
        /// <param name="spanId">The span ID, should be null if there's no span.</param>
        public TraceContextForLogEntry(string traceId, string spanId) =>
            (TraceId, SpanId) = (GaxPreconditions.CheckNotNull(traceId, nameof(traceId)), spanId);

        internal static TraceContextForLogEntry FromGoogleTrace() =>
            ContextTracerManager.GetCurrentTracer() is IManagedTracer tracer && tracer.GetCurrentTraceId() is string traceId ?
            new TraceContextForLogEntry(traceId, SpanIdToHex(tracer.GetCurrentSpanId())) :
            null;

        internal static TraceContextForLogEntry FromGoogleTraceHeader(IServiceProvider serviceProvider)
        {
            if (serviceProvider?.GetService<IHttpContextAccessor>()?
                .HttpContext.Request.Headers
                .TryGetValue(TraceHeaderContext.TraceHeader, out StringValues headerValue) == true)
            {
                var traceContext = TraceHeaderContext.FromHeader(headerValue);
                if (traceContext.ShouldTrace == true)
                {
                    return new TraceContextForLogEntry(traceContext.TraceId, SpanIdToHex(traceContext.SpanId));
                }
            }
            return null;
        }

        internal static TraceContextForLogEntry FromExternalTrace(IServiceProvider serviceProvider) =>
            serviceProvider?.GetService<IExternalTraceProvider>()?.GetCurrentTraceContext(serviceProvider);

        private static string SpanIdToHex(ulong? spanId) => spanId is null ? null : $"{spanId:x16}";
    }
}
