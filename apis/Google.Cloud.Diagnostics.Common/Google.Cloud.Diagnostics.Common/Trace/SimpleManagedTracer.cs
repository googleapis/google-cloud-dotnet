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
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
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

        /// <summary>The trace consumer to push the trace to when completed.</summary>
        private readonly IConsumer<TraceProto> _consumer;

        /// <summary>The current trace.</summary>
        private TraceProto _trace;

        /// <summary>The id of the current trace.</summary>
        private readonly string _traceId;

        /// <summary>The Google Cloud Platform project ID.</summary>
        private readonly string _projectId;

        private readonly object _traceLock = new object();

        /// <summary>The number of spans currently open on any thread.</summary>
        private int _openSpanCount;

        /// <summary>The span id factory to generate new span ids.</summary>
        private readonly SpanIdFactory _spanIdFactory;

        /// <summary>The span id of the parent span of the root span of this trace.</summary>
        private readonly ulong? _rootSpanParentId;

        private SimpleManagedTracer(IConsumer<TraceProto> consumer, string projectId, string traceId, ulong? rootSpanParentId = null)
        {
            _consumer = GaxPreconditions.CheckNotNull(consumer, nameof(consumer));
            _traceId = GaxPreconditions.CheckNotNull(traceId, nameof(traceId));
            _projectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            _trace = CreateTraceProto();
            _spanIdFactory = SpanIdFactory.Create();
            _rootSpanParentId = rootSpanParentId;
        }

        /// <summary>
        /// Creates a <see cref="SimpleManagedTracer"/>>
        /// </summary>
        /// <param name="consumer">The consumer to push finished traces to. Cannot be null.</param>
        /// <param name="projectId">The Google Cloud Platform project ID. Cannot be null.</param>
        /// <param name="traceId">The id of the current trace. Cannot be null.</param>
        /// <param name="rootSpanParentId">Optional, the parent span id of the root span of the passed in trace.</param>
        public static SimpleManagedTracer Create(IConsumer<TraceProto> consumer, string projectId,
            string traceId, ulong? rootSpanParentId = null)
            => new SimpleManagedTracer(consumer, projectId, traceId, rootSpanParentId);

        /// <inheritdoc />
        public IDisposable StartSpan(string name, StartSpanOptions options = null)
        {
            GaxPreconditions.CheckNotNull(name, nameof(name));
            options = options ?? StartSpanOptions.Create();

            var currentStack = TraceStack;
            var span = new TraceSpan
            {
                SpanId = _spanIdFactory.NextId(),
                Kind = options.SpanKind.Convert(),
                Name = name,
                StartTime = Timestamp.FromDateTime(DateTime.UtcNow),
                ParentSpanId = GetCurrentSpanId(currentStack).GetValueOrDefault()
            };
            AnnotateSpan(span, options.Labels);

            TraceStack = currentStack.Push(span);

            Interlocked.Increment(ref _openSpanCount);
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
                    return await func().ConfigureAwait(false);
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
            var currentStack = TraceStack;
            CheckStackNotEmpty(currentStack);

            TraceSpan span;
            currentStack = currentStack.Pop(out span);
            TraceStack = currentStack;
            span.EndTime = Timestamp.FromDateTime(DateTime.UtcNow);

            lock (_traceLock)
            {
                _trace.Spans.Add(span);

                var newOpenSpanCount = Interlocked.Decrement(ref _openSpanCount);
                Debug.Assert(newOpenSpanCount >= 0, "Invalid open span count");
                if (newOpenSpanCount <= 0)
                {
                    Flush();
                }
            }
        }

        /// <inheritdoc />
        public void AnnotateSpan(Dictionary<string, string> labels)
        {
            GaxPreconditions.CheckNotNull(labels, nameof(labels));

            var currentStack = TraceStack;
            CheckStackNotEmpty(currentStack);

            AnnotateSpan(currentStack.Peek(), labels);
        }

        /// <summary>
        /// Annotates the specified span with the given labels. 
        /// </summary>
        private void AnnotateSpan(TraceSpan span, Dictionary<string, string> labels)
        {
            foreach (var l in labels)
            {
                span.Labels.Add(l.Key, l.Value);
            }
        }

        /// <inheritdoc />
        public void SetStackTrace(StackTrace stackTrace)
        {
            GaxPreconditions.CheckNotNull(stackTrace, nameof(stackTrace));
            var currentStack = TraceStack;
            CheckStackNotEmpty(currentStack);

            AnnotateSpan(currentStack.Peek(), TraceLabels.FromStackTrace(stackTrace));
        }

        /// <inheritdoc />
        public string GetCurrentTraceId()
        {
            return _trace.TraceId;
        }

        /// <inheritdoc />
        public ulong? GetCurrentSpanId() => GetCurrentSpanId(TraceStack);

        /// <summary>
        /// Gets the current span id of the specified stack or null if none exists.
        /// </summary>
        private ulong? GetCurrentSpanId(ImmutableStack<TraceSpan> traceStack)
            => traceStack.IsEmpty ? _rootSpanParentId : traceStack.Peek().SpanId;

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

        private void CheckStackNotEmpty(ImmutableStack<TraceSpan> traceStack)
        {
            GaxPreconditions.CheckState(!traceStack.IsEmpty, "No available span.");
        }

        private void Flush()
        {
            var old = _trace;
            _trace = CreateTraceProto();
            _consumer.Receive(new[] { old });
        }

        /// <summary>
        /// Creates a new <see cref="TraceProto"/> with the project id and trace id set.
        /// </summary>
        private TraceProto CreateTraceProto() =>
             new TraceProto { TraceId = _traceId, ProjectId = _projectId };

        /// <summary>
        /// The stack of trace spans for the current logical call context. Note that this is logically cloned when each async
        /// block is entered and each thread is spawned, so it will contain the spans which were open previously and those spans
        /// will never be removed in the context of that async block/thread. Do not rely on the stack contents to know the state
        /// of things on other threads. It may contain previously closed spans.
        /// </summary>
#if NET45
        private readonly string _callContextName = Guid.NewGuid().ToString("N");
        private ImmutableStack<TraceSpan> TraceStack
        {
            get
            {
                var ret = System.Runtime.Remoting.Messaging.CallContext.LogicalGetData(_callContextName) as ImmutableStack<TraceSpan>;
                return ret ?? ImmutableStack<TraceSpan>.Empty;
            }
            set
            {
                System.Runtime.Remoting.Messaging.CallContext.LogicalSetData(_callContextName, value);
            }
        }
#else
        private readonly AsyncLocal<ImmutableStack<TraceSpan>> _traceStack = new AsyncLocal<ImmutableStack<TraceSpan>>();
        private ImmutableStack<TraceSpan> TraceStack
        {
            get
            {
                return _traceStack.Value ?? ImmutableStack<TraceSpan>.Empty;
            }
            set
            {
                _traceStack.Value = value;
            }
        }
#endif
    }
}
