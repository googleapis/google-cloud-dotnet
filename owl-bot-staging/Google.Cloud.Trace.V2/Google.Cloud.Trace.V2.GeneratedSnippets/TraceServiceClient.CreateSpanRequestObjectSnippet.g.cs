// Copyright 2025 Google LLC
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

namespace GoogleCSharpSnippets
{
    // [START cloudtrace_v2_generated_TraceService_CreateSpan_sync]
    using Google.Cloud.Trace.V2;
    using Google.Protobuf.WellKnownTypes;
    using Google.Rpc;

    public sealed partial class GeneratedTraceServiceClientSnippets
    {
        /// <summary>Snippet for CreateSpan</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateSpanRequestObject()
        {
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
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
            Span response = traceServiceClient.CreateSpan(request);
        }
    }
    // [END cloudtrace_v2_generated_TraceService_CreateSpan_sync]
}
