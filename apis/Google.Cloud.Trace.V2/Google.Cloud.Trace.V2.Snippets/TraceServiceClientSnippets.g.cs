// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Trace.V2;
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

namespace Google.Cloud.Trace.V2.Snippets
{
    /// <summary>Generated snippets</summary>
    public class GeneratedTraceServiceClientSnippets
    {
        /// <summary>Snippet for BatchWriteSpansAsync</summary>
        public async Task BatchWriteSpansAsync()
        {
            // Snippet: BatchWriteSpansAsync(ProjectName,IEnumerable<Span>,CallSettings)
            // Additional: BatchWriteSpansAsync(ProjectName,IEnumerable<Span>,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            IEnumerable<Span> spans = new List<Span>();
            // Make the request
            await traceServiceClient.BatchWriteSpansAsync(name, spans);
            // End snippet
        }

        /// <summary>Snippet for BatchWriteSpans</summary>
        public void BatchWriteSpans()
        {
            // Snippet: BatchWriteSpans(ProjectName,IEnumerable<Span>,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = new ProjectName("[PROJECT]");
            IEnumerable<Span> spans = new List<Span>();
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
            // Snippet: CreateSpanAsync(Span,CallSettings)
            // Additional: CreateSpanAsync(Span,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            Span request = new Span
            {
                SpanName = new SpanName("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "",
                DisplayName = new TruncatableString(),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            Span response = await traceServiceClient.CreateSpanAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpan</summary>
        public void CreateSpan_RequestObject()
        {
            // Snippet: CreateSpan(Span,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            Span request = new Span
            {
                SpanName = new SpanName("[PROJECT]", "[TRACE]", "[SPAN]"),
                SpanId = "",
                DisplayName = new TruncatableString(),
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
            };
            // Make the request
            Span response = traceServiceClient.CreateSpan(request);
            // End snippet
        }

    }
}
