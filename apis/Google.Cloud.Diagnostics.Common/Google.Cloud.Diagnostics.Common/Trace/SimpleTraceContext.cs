// Copyright 2021 Google LLC
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

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Simple implementation of <see cref="ITraceContext"/>.
    /// </summary>
    public sealed class SimpleTraceContext : ITraceContext
    {
        /// <summary>
        /// Creates a new instance of <see cref="SimpleTraceContext"/>.
        /// </summary>
        public SimpleTraceContext(string traceId, ulong? spanId, bool? shouldTrace) =>
            (TraceId, SpanId, ShouldTrace) = (traceId, spanId, shouldTrace);

        /// <inheritdoc/>
        public string TraceId { get; }

        /// <inheritdoc/>
        public ulong? SpanId { get; }

        /// <inheritdoc/>
        public bool? ShouldTrace { get; }

        internal static SimpleTraceContext FromTracer(IManagedTracer tracer) =>
            // If IManagedTracer returns a non-null traceId it's because the request should be traced.
            tracer?.GetCurrentTraceId() is string traceId ? new SimpleTraceContext(traceId, tracer.GetCurrentSpanId(), true) : null;
    }
}
