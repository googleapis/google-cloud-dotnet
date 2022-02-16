// Copyright 2022 Google LLC
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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Trace.V2.Snippets
{
    // [START cloudtrace_v2_generated_TraceService_CreateSpan_async]
    using Google.Cloud.Trace.V2;
    using Google.Protobuf.WellKnownTypes;
    using Google.Rpc;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTraceServiceClientSnippets
    {
        /// <summary>Snippet for CreateSpanAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateSpanRequestObjectAsync()
        {
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            Span request = new Span
            {
                SpanName = SpanName.FromProjectTraceSpan("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "",
                ParentSpanId = "",
                DisplayName = new TruncatableString(),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
                Attributes = new Span.Types.Attributes(),
                StackTrace = new StackTrace(),
                TimeEvents = new Span.Types.TimeEvents(),
                Links = new Span.Types.Links(),
                Status = new Status(),
                SameProcessAsParentSpan = false,
                ChildSpanCount = 0,
                SpanKind = Span.Types.SpanKind.Unspecified,
            };
            // Make the request
            Span response = await traceServiceClient.CreateSpanAsync(request);
        }
    }
    // [END cloudtrace_v2_generated_TraceService_CreateSpan_async]
}
