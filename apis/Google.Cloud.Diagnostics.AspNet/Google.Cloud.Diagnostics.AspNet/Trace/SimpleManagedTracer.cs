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
using Google.Cloud.Diagnostics.Common;
using Google.Cloud.Trace.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// A simple implementation of the <see cref="IManagedTracer"/> that handles spans in a stack.
    /// </summary>
    internal sealed class SimpleManagedTracer : IManagedTracer
    {
        /// <summary>A mutex to protect the rate limiter instance.</summary>
        private static object _stackMutex = new object();

        /// <summary>The trace consumer to push the trace to when completed.</summary>
        private readonly IConsumer<TraceProto> _consumer;

        /// <summary>The current trace.</summary>
        private readonly TraceProto _trace;

        /// <summary>A stack of trace spans.</summary>
        private readonly Stack<TraceSpan> _traceStack;

        /// <summary>The span id factory to generate new span ids.</summary>
        private readonly SpanIdFactory _spanIdFactory;

        /// <summary>The span id of the parent span of the root span of this trace.</summary>
        private readonly ulong? _rootSpanParentId;

        private SimpleManagedTracer(IConsumer<TraceProto> consumer, TraceProto trace, ulong? rootSpanParentId = null)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _trace = GaxPreconditions.CheckNotNull(trace, nameof(trace));
            _traceStack = new Stack<TraceSpan>();
            _spanIdFactory = SpanIdFactory.Create();
            _rootSpanParentId = rootSpanParentId;
        }

        /// <summary>
        /// Creates a <see cref="SimpleManagedTracer"/>>
        /// </summary>
        /// <param name="consumer">The consumer to push finised traces to.</param>
        /// <param name="trace">The current trace.</param>
        /// <param name="rootSpanParentId">Optional, the parent span id of the root span of the passed in trace.</param>
        public static SimpleManagedTracer Create(IConsumer<TraceProto> consumer, TraceProto trace, ulong? rootSpanParentId = null)
        {
            return new SimpleManagedTracer(consumer, trace, rootSpanParentId);
        }

        /// <inheritdoc />
        public void StartSpan(string name, StartSpanOptions options = null)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            options = options ?? StartSpanOptions.Create();

            TraceSpan span = new TraceSpan();
            span.SpanId = _spanIdFactory.NextId();
            span.Kind = options.SpanKind.Convert();
            span.Name = name;
            span.StartTime = Timestamp.FromDateTime(DateTime.Now.ToUniversalTime());

            lock (_stackMutex)
            {
                if (_traceStack.Count != 0)
                {
                    span.ParentSpanId = _traceStack.Peek().SpanId;
                }
                else if (_rootSpanParentId != null)
                {
                    span.ParentSpanId = (ulong)_rootSpanParentId;
                }

                _traceStack.Push(span);
            }
        }

        /// <inheritdoc />
        public void EndSpan()
        {
            lock (_stackMutex)
            {
                CheckStackNotEmpty();

                TraceSpan span = _traceStack.Pop();
                span.EndTime = Timestamp.FromDateTime(DateTime.Now.ToUniversalTime());

                _trace.Spans.Add(span);

                if (_traceStack.Count == 0)
                {
                    Flush();
                }
            }
        }

        /// <inheritdoc />
        public void AnnotateSpan(Dictionary<string, string> labels)
        {
            GaxPreconditions.CheckNotNull(labels, nameof(labels));

            lock (_stackMutex)
            {
                CheckStackNotEmpty();

                TraceSpan span = _traceStack.Peek();
                foreach (var l in labels)
                {
                    span.Labels.Add(l.Key, l.Value);
                }
            }
        }

        /// <inheritdoc />
        public void SetStackTrace(StackTrace stackTrace)
        {
            GaxPreconditions.CheckNotNull(stackTrace, nameof(stackTrace));
            CheckStackNotEmpty();

            AnnotateSpan(Labels.FromStackTrace(stackTrace));
        }

        /// <inheritdoc />
        public string GetCurrentTraceId()
        {
            return _trace.TraceId;
        }

        private void CheckStackNotEmpty()
        {
            GaxPreconditions.CheckState(_traceStack.Count != 0, "No available span.");
        }

        private void Flush()
        {
            _consumer.Receive(new[] { _trace  });
        }
    }
}