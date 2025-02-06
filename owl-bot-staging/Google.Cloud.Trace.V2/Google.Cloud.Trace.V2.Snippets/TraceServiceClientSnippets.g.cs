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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Trace.V2;
    using Google.Protobuf.WellKnownTypes;
    using Google.Rpc;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTraceServiceClientSnippets
    {
        /// <summary>Snippet for BatchWriteSpans</summary>
        public void BatchWriteSpansRequestObject()
        {
            // Snippet: BatchWriteSpans(BatchWriteSpansRequest, CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                Spans = { new Span(), },
            };
            // Make the request
            traceServiceClient.BatchWriteSpans(request);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteSpansAsync</summary>
        public async Task BatchWriteSpansRequestObjectAsync()
        {
            // Snippet: BatchWriteSpansAsync(BatchWriteSpansRequest, CallSettings)
            // Additional: BatchWriteSpansAsync(BatchWriteSpansRequest, CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                Spans = { new Span(), },
            };
            // Make the request
            await traceServiceClient.BatchWriteSpansAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteSpans</summary>
        public void BatchWriteSpans()
        {
            // Snippet: BatchWriteSpans(string, IEnumerable<Span>, CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            IEnumerable<Span> spans = new Span[] { new Span(), };
            // Make the request
            traceServiceClient.BatchWriteSpans(name, spans);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteSpansAsync</summary>
        public async Task BatchWriteSpansAsync()
        {
            // Snippet: BatchWriteSpansAsync(string, IEnumerable<Span>, CallSettings)
            // Additional: BatchWriteSpansAsync(string, IEnumerable<Span>, CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            IEnumerable<Span> spans = new Span[] { new Span(), };
            // Make the request
            await traceServiceClient.BatchWriteSpansAsync(name, spans);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteSpans</summary>
        public void BatchWriteSpansResourceNames()
        {
            // Snippet: BatchWriteSpans(ProjectName, IEnumerable<Span>, CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IEnumerable<Span> spans = new Span[] { new Span(), };
            // Make the request
            traceServiceClient.BatchWriteSpans(name, spans);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteSpansAsync</summary>
        public async Task BatchWriteSpansResourceNamesAsync()
        {
            // Snippet: BatchWriteSpansAsync(ProjectName, IEnumerable<Span>, CallSettings)
            // Additional: BatchWriteSpansAsync(ProjectName, IEnumerable<Span>, CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            IEnumerable<Span> spans = new Span[] { new Span(), };
            // Make the request
            await traceServiceClient.BatchWriteSpansAsync(name, spans);
            // End snippet
        }

        /// <summary>Snippet for CreateSpan</summary>
        public void CreateSpanRequestObject()
        {
            // Snippet: CreateSpan(Span, CallSettings)
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
            // End snippet
        }

        /// <summary>Snippet for CreateSpanAsync</summary>
        public async Task CreateSpanRequestObjectAsync()
        {
            // Snippet: CreateSpanAsync(Span, CallSettings)
            // Additional: CreateSpanAsync(Span, CancellationToken)
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
            // End snippet
        }
    }
}
