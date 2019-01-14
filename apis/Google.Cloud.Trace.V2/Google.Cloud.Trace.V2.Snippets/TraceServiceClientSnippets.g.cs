// Copyright 2019 Google LLC
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
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Trace.V2;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedTraceServiceClientSnippets
    {
        /// <summary>Snippet for BatchWriteSpansAsync</summary>
        public async Task BatchWriteSpansAsync()
        {
            // Snippet: BatchWriteSpansAsync(ProjectName,IEnumerable<apis::Span>,CallSettings)
            // Additional: BatchWriteSpansAsync(ProjectName,IEnumerable<apis::Span>,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            IEnumerable<apis::Span> spans = new List<apis::Span>();
            // Make the request
            await traceServiceClient.BatchWriteSpansAsync(name, spans);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteSpans</summary>
        public void BatchWriteSpans()
        {
            // Snippet: BatchWriteSpans(ProjectName,IEnumerable<apis::Span>,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            IEnumerable<apis::Span> spans = new List<apis::Span>();
            // Make the request
            traceServiceClient.BatchWriteSpans(name, spans);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteSpansAsync</summary>
        public async Task BatchWriteSpansAsync_RequestObject()
        {
            // Snippet: BatchWriteSpansAsync(BatchWriteSpansRequest,CallSettings)
            // Additional: BatchWriteSpansAsync(BatchWriteSpansRequest,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Spans = { },
            };
            // Make the request
            await traceServiceClient.BatchWriteSpansAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteSpans</summary>
        public void BatchWriteSpans_RequestObject()
        {
            // Snippet: BatchWriteSpans(BatchWriteSpansRequest,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            BatchWriteSpansRequest request = new BatchWriteSpansRequest
            {
                ProjectName = new ProjectName("[PROJECT]"),
                Spans = { },
            };
            // Make the request
            traceServiceClient.BatchWriteSpans(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpanAsync</summary>
        public async Task CreateSpanAsync_RequestObject()
        {
            // Snippet: CreateSpanAsync(apis::Span,CallSettings)
            // Additional: CreateSpanAsync(apis::Span,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            apis::Span request = new apis::Span
            {
                SpanName = new SpanName("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "",
                DisplayName = new TruncatableString(),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            apis::Span response = await traceServiceClient.CreateSpanAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpan</summary>
        public void CreateSpan_RequestObject()
        {
            // Snippet: CreateSpan(apis::Span,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            apis::Span request = new apis::Span
            {
                SpanName = new SpanName("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "",
                DisplayName = new TruncatableString(),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            apis::Span response = traceServiceClient.CreateSpan(request);
            // End snippet
        }

    }
}
