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
using System.Text.RegularExpressions;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// Context from the Cloud Trace Header.
    /// </summary>
    /// 
    /// <remarks>
    /// A trace can be forced by passing information along in the trace header ("X-Cloud-Trace-Context").
    /// The trace id, parent span id and whether or not to trace can be set.
    /// See: https://cloud.google.com/trace/docs/faq#how_do_i_force_a_request_to_be_traced
    /// </remarks>
    internal sealed class TraceHeaderContext
    {
        private static readonly TraceIdFactory _traceIdFactory = TraceIdFactory.Create();

        /// <summary>An TraceHeaderContext representing no information or invalid information from a header.</summary>
        private static readonly TraceHeaderContext InvalidTraceHeaderContext =
            new TraceHeaderContext(null, null, null);

        /// <summary>The trace header.</summary>
        internal const string TraceHeader = "X-Cloud-Trace-Context";

        /// <summary>
        /// A regex to match the trace header. 
        /// - ([A-Fa-f0-9]{32}): The trace id, a 32 character hex value.
        /// - ([0-9]+): The span id, a 64 bit integer.
        /// - (o=([0-3])): The trace mask, 1-3 denote it should be traced.
        /// </summary>
        internal static readonly Regex TraceHeaderRegex =
            new Regex(@"^([A-Fa-f0-9]{32})/([0-9]+);(o=([0-3]))?$", RegexOptions.Compiled);

        /// <summary>Gets the trace id or null if none is available.</summary>
        public string TraceId { get; }

        /// <summary>Gets the span id or null if none is available.</summary>
        public ulong? SpanId { get; }

        /// <summary>
        /// True if the request should be traced, false if it should not be.
        /// Null if the trace header does not indicate whether or not it should be traced.
        /// </summary>
        public bool? ShouldTrace { get; }

        /// <summary>
        /// Creates a <see cref="TraceHeaderContext"/> from a trace and span id.
        /// </summary>
        public static TraceHeaderContext Create(string traceId, ulong? spanId, bool? shouldTrace) =>
            new TraceHeaderContext(traceId, spanId, shouldTrace);

        /// <summary>
        /// Creates a <see cref="TraceHeaderContext"/> from a header. 
        /// </summary>
        /// <param name="header">The string value of the trace header. Can be null.
        ///     See: https://cloud.google.com/trace/docs/faq </param>
        public static TraceHeaderContext FromHeader(string header)
        {
            if (header == null)
            {
                return InvalidTraceHeaderContext;
            }

            Match match = TraceHeaderRegex.Match(header);
            if (!match.Success)
            {
                return InvalidTraceHeaderContext;
            }

            string traceId = match.Groups[1].Value;
            ulong spanId;
            if (!ulong.TryParse(match.Groups[2].Value, out spanId))
            {
                return InvalidTraceHeaderContext;
            }
            bool hasMask = match.Groups.Count > 4 && match.Groups[4].Success;
            bool? shouldTrace = hasMask ? Convert.ToInt32(match.Groups[4].Value) > 0 : (bool?) null;
            return new TraceHeaderContext(traceId, spanId, shouldTrace);
        }

        /// <summary>
        /// Creates a <see cref="TraceHeaderContext"/> from a header. 
        /// </summary>
        /// <param name="header">The string value of the trace header. Can be null.
        ///     See: https://cloud.google.com/trace/docs/faq </param>
        /// <param name="traceFallbackPredicate">Optional function to override and trace requests. Can be null.</param>
        public static TraceHeaderContext FromHeader(string header, Func<bool?> traceFallbackPredicate)
        {
            var traceHeaderContext = FromHeader(header);
            if (traceHeaderContext.ShouldTrace == null && traceFallbackPredicate != null)
            {
                bool? shouldTrace = traceFallbackPredicate();
                if (shouldTrace == true)
                {
                    return new TraceHeaderContext(
                        traceHeaderContext.TraceId ?? _traceIdFactory.NextId(),
                        traceHeaderContext.SpanId ?? 0, shouldTrace);
                }
                else if (shouldTrace == false)
                {
                    return new TraceHeaderContext(
                        traceHeaderContext.TraceId, traceHeaderContext.SpanId, shouldTrace);
                }
            }
            return traceHeaderContext;
        }

        internal TraceHeaderContext(string traceId, ulong? spanId, bool? shouldTrace)
        {
            TraceId = traceId;
            SpanId = spanId;
            ShouldTrace = shouldTrace;
        }

        /// <summary>
        /// Gets the <see cref="TraceHeaderContext"/> as a string.
        /// Formatted as "[trace-id]/[span-id];o=[should-trace]"
        /// where "should-trace" is 1 to trace and 0 otherwise.
        /// </summary>
        public override string ToString()
        {
            var header = $"{TraceId}/{SpanId};";
            if (ShouldTrace != null)
            {
                header += ShouldTrace.Value ? "o=1" : "o=0";
            }
            return header;
        }
    }
}