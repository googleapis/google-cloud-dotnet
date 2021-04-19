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
    /// A trace context.
    /// </summary>
    public interface ITraceContext
    {
        /// <summary>The trace id or null if none is available.</summary>
        /// <remarks>
        /// This corresponds to the trace_id field of the Trace message in the API.
        /// See https://cloud.google.com/trace/docs/reference/v2/rpc/google.devtools.cloudtrace.v1#trace
        /// for more information.
        /// </remarks>
        string TraceId { get; }

        /// <summary>The span id or null if none is available.</summary>
        /// <remarks>
        /// This corresponds to the span_id field of the TraceSpan message in the API.
        /// See https://cloud.google.com/trace/docs/reference/v2/rpc/google.devtools.cloudtrace.v1#tracespan
        /// for more information.
        /// </remarks>
        ulong? SpanId { get; }

        /// <summary>
        /// Whether this request should be traced or not.
        /// May be null, which means that there's not enough information to know
        /// whether this request should be traced or not.
        /// </summary>
        bool? ShouldTrace { get; }
    }
}
