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
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Web;

namespace Google.Devtools.AspNet
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
        /// <summary>An TraceHeaderContext representing no information or invalid information from a header.</summary>
        private static readonly TraceHeaderContext InvalidTraceHeaderContext =
            new TraceHeaderContext(null, null, false);

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

        /// <summary>True if the request should be traced.</summary>
        public bool ShouldTrace { get; }

        /// <summary>
        /// Create a <see cref="TraceHeaderContext"/> from an <see cref="HttpRequest"/>. 
        /// </summary>
        public static TraceHeaderContext FromRequest(HttpRequest request)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            return FromCollection(request.Headers);
        }

        internal static TraceHeaderContext FromCollection(NameValueCollection collection)
        {
            GaxPreconditions.CheckNotNull(collection, nameof(collection));
            string header = collection.Get(TraceHeader);
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
            int traceMask = hasMask ? Convert.ToInt32(match.Groups[4].Value) : 0;
            bool shouldTrace = traceMask > 0;
            return new TraceHeaderContext(traceId, spanId, shouldTrace);
        }

        private TraceHeaderContext(string traceId, ulong? spanId, bool shouldTrace)
        {
            TraceId = traceId;
            SpanId = spanId;
            ShouldTrace = shouldTrace; 
        }
    }
}