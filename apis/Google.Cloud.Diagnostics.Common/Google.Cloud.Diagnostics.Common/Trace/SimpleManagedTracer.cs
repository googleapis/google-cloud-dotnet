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
using Google.Cloud.Trace.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A simple implementation of the <see cref="IManagedTracer"/> that handles spans in a stack.
    /// </summary>
    internal sealed class SimpleManagedTracer : IManagedTracer
    {
        /// <summary>
        /// A class that represents a running trace span.
        /// </summary>
        private class Span : IDisposable
        {
            private readonly SimpleManagedTracer _tracer;
            public Span(SimpleManagedTracer tracer) { _tracer = tracer; }

            /// <summary> Ends the current span.</summary>
            public void Dispose() => _tracer.EndSpan();
        }

        /// <summary>A mutex to protect the rate limiter instance.</summary>
        private readonly object _stackLock = new object();

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
        /// <param name="consumer">The consumer to push finished traces to.</param>
        /// <param name="trace">The current trace.</param>
        /// <param name="rootSpanParentId">Optional, the parent span id of the root span of the passed in trace.</param>
        public static SimpleManagedTracer Create(IConsumer<TraceProto> consumer, TraceProto trace, ulong? rootSpanParentId = null)
            => new SimpleManagedTracer(consumer, trace, rootSpanParentId);

        /// <inheritdoc />
        public IDisposable StartSpan(string name, StartSpanOptions options = null)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            options = options ?? StartSpanOptions.Create();

            TraceSpan span = new TraceSpan();
            span.SpanId = _spanIdFactory.NextId();
            span.Kind = options.SpanKind.Convert();
            span.Name = name;
            span.StartTime = Timestamp.FromDateTime(DateTime.Now.ToUniversalTime());

            lock (_stackLock)
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
                AnnotateSpan(options.Labels);
            }

            return new Span(this);
        }

        /// <inheritdoc />
        public void RunInSpan(Action action, string name, StartSpanOptions options = null)
        {
            using (StartSpan(name, options))
            {
                try
                {
                    action();
                }
                catch (Exception e) when (SetStackTraceAndReturnFalse(e))
                {
                }
            }
        }

        /// <inheritdoc />
        public T RunInSpan<T>(Func<T> func, string name, StartSpanOptions options = null)
        {
            using (StartSpan(name, options))
            {
                try
                {
                    return func();
                }
                catch (Exception e) when (SetStackTraceAndReturnFalse(e))
                {
                    // This will never return as the condition above will always be false.
                    return default(T);
                }
            }
        }

        /// <inheritdoc />
        public async Task<T> RunInSpanAsync<T>(Func<Task<T>> func, string name, StartSpanOptions options = null)
        {
            using (StartSpan(name, options))
            {
                try
                {
                    return await func();
                }
                catch (Exception e) when (SetStackTraceAndReturnFalse(e))
                {
                    // This will never return as the condition above will always be false.
                    return await Task.FromResult(default(T));
                }
            }
        }

        /// <inheritdoc />
        public void EndSpan()
        {
            lock (_stackLock)
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

            lock (_stackLock)
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

            AnnotateSpan(TraceLabels.FromStackTrace(stackTrace));
        }

        /// <inheritdoc />
        public string GetCurrentTraceId()
        {
            return _trace.TraceId;
        }

        /// <inheritdoc />
        public ulong? GetCurrentSpanId()
        {
            lock (_stackLock)
            {
                if (_traceStack.Count != 0)
                {
                    return _traceStack.Peek().SpanId;
                }
                else if (_rootSpanParentId != null)
                {
                    return _rootSpanParentId;
                }
                return null;
            }
        }

        /// <summary>
        /// Sets a <see cref="StackTrace"/> on the current span for the given exception and
        /// returns false.  This is used for exception handling to ensure no data is lost
        /// in the stacktrace.
        /// </summary>
        private bool SetStackTraceAndReturnFalse(Exception e)
        {
            SetStackTrace(new StackTrace(e, true));
            return false;
        }

        private void CheckStackNotEmpty()
        {
            GaxPreconditions.CheckState(_traceStack.Count != 0, "No available span.");
        }

        private void Flush()
        {
            _consumer.Receive(new[] { _trace });
        }
    }
}