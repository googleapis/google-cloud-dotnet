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

using Google.Cloud.Trace.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class SimpleManagedTracerTest
    {
        private const string TraceId = "trace-id";
        private const string ProjectId = "project-id";
        // Constanst used to check if a Timestamp is normalized.
        private const long BclSecondsAtUnixEpoch = 62135596800;
        internal const long UnixSecondsAtBclMaxValue = 253402300799;
        internal const long UnixSecondsAtBclMinValue = -BclSecondsAtUnixEpoch;

        private static readonly StackTrace FilledStackTrace = CreateStackTrace();

        private static StackTrace CreateStackTrace()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception e)
            {
                return new StackTrace(e, true);
            }
        }

        private static void AssertValidSpan(TraceSpan span, string name) =>
            AssertValidSpan(span, name, 0);

        private static void AssertValidSpan(TraceSpan span, string name, ulong parentId) =>
            AssertValidSpan(span, name, parentId, SpanKind.Unspecified);

        private static void AssertValidSpan(TraceSpan span, string name, ulong parentId, SpanKind kind)
        {
            Assert.NotEqual(0UL, span.SpanId);
            Assert.Equal(kind.Convert(), span.Kind);
            Assert.Equal(name, span.Name);
            Assert.NotNull(span.StartTime);
            Assert.Equal(parentId, span.ParentSpanId);
            Assert.NotNull(span.EndTime);
            Assert.True(span.EndTime.ToDateTime() > span.StartTime.ToDateTime());
        }

        /// <summary>
        /// Used to ensure a <see cref="TraceSpan"/>'s that starts ends immediately 
        /// has a total run time of 1ms.
        /// 
        /// This is needed as we set the length to 1ms for spans that do not have 
        /// a difference of 1ms between start and end. If we do not the Trace
        /// API will not record the span.
        /// </summary>
        private static void AssertAtLeast1MsSpan(TraceSpan span)
        {
            var duration = span.EndTime - span.StartTime;
            Assert.True(duration.Seconds >= 1 ||
                // Checking Seconds again to avoid returning true for cases
                // in which StartTime is greater than EndTime.
                (duration.Seconds == 0 && duration.Nanos >= 1_000_000));
        }

        /// <summary>
        /// Used to ensure that <see cref="Timestamp"/>s manipulated by
        /// <see cref="SimpleManagedTracer"/> are normalized after
        /// manipulation.
        /// </summary>
        private static bool IsNormalized(Timestamp timestamp) =>
            timestamp.Nanos >= 0 &&
            timestamp.Nanos < Duration.NanosecondsPerSecond &&
            timestamp.Seconds >= UnixSecondsAtBclMinValue &&
            timestamp.Seconds <= UnixSecondsAtBclMaxValue;

        [Theory]
        [InlineData(10, 10, 10, 15)]
        [InlineData(10, 999_000_000, 10, 999_000_015)]
        [InlineData(10, 999_999_900, 10, 999_999_915)]
        [InlineData(10, 999_999_999, 11, 15)]
        [InlineData(10, 15, 10, 10)]
        public void Span_EnsureVisibleDuration_ShortSpan(int startSeconds, int startNanos, int endSeconds, int endNanos)
        {
            var tracer = SimpleManagedTracer.Create(new NoOpConsumer(), ProjectId, TraceId);

            var traceSpan = new TraceSpan
            {
                StartTime = new Timestamp
                {
                    Seconds = startSeconds,
                    Nanos = startNanos
                },
                EndTime = new Timestamp
                {
                    Seconds = endSeconds,
                    Nanos = endNanos
                }
            };

            var span = new SimpleManagedTracer.Span(tracer, traceSpan);
            span.EnsureVisibleDuration();

            Assert.True(IsNormalized(span.TraceSpan.StartTime));
            Assert.True(IsNormalized(span.TraceSpan.EndTime));
            AssertAtLeast1MsSpan(span.TraceSpan);
        }

        [Theory]
        [InlineData(10, 0, 10, 1_000_000)]
        [InlineData(10, 999_000_000, 11, 0)]
        [InlineData(10, 15, 10, 999_999_915)]
        [InlineData(10, 15, 11, 250)]
        [InlineData(10, 15, 15, 10)]
        public void Span_EnsureVisibleDuration_LongSpan(int startSeconds, int startNanos, int endSeconds, int endNanos)
        {
            var tracer = SimpleManagedTracer.Create(new NoOpConsumer(), ProjectId, TraceId);

            var traceSpan = new TraceSpan
            {
                StartTime = new Timestamp
                {
                    Seconds = startSeconds,
                    Nanos = startNanos
                },
                EndTime = new Timestamp
                {
                    Seconds = endSeconds,
                    Nanos = endNanos
                }
            };

            var span = new SimpleManagedTracer.Span(tracer, traceSpan);
            span.EnsureVisibleDuration();

            Assert.Equal(startSeconds, traceSpan.StartTime.Seconds);
            Assert.Equal(startNanos, traceSpan.StartTime.Nanos);
            Assert.Equal(endSeconds, traceSpan.EndTime.Seconds);
            Assert.Equal(endNanos, traceSpan.EndTime.Nanos);
        }

        [Fact]
        public void SingleSpan()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            tracer.StartSpan("span-name").Dispose();

            var entry = Assert.Single(consumer.Items);
            var span = Assert.Single(entry.Spans);
            AssertValidSpan(span, "span-name");
            AssertAtLeast1MsSpan(span);
        }

        [Fact]
        public void SingleSpan_ParentId()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId, 123);

            tracer.StartSpan("span-name").Dispose();

            var entry = Assert.Single(consumer.Items);
            var span = Assert.Single(entry.Spans);
            AssertValidSpan(span, "span-name", 123);
            AssertAtLeast1MsSpan(span);
        }

        [Fact]
        public void SingleSpan_Options()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            var options = StartSpanOptions.Create(SpanKind.RpcClient, annotation);
            tracer.StartSpan("span-name", options).Dispose();

            var entry = Assert.Single(consumer.Items);
            var span = Assert.Single(entry.Spans);
            AssertValidSpan(span, "span-name", 0, SpanKind.RpcClient);
            Assert.True(TraceUtils.IsValidAnnotation(span, annotation));
        }

        [Fact]
        public void SingleSpan_Annotation()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            using (tracer.StartSpan("span-name"))
            {
                tracer.AnnotateSpan(annotation);
            }

            var entry = Assert.Single(consumer.Items);
            var span = Assert.Single(entry.Spans);
            AssertValidSpan(span, "span-name");
            Assert.True(TraceUtils.IsValidAnnotation(span, annotation));
        }

        [Fact]
        public void SingleSpan_Stacktrace()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            using (tracer.StartSpan("span-name"))
            {
                tracer.SetStackTrace(FilledStackTrace);
            }

            var entry = Assert.Single(consumer.Items);
            var span = Assert.Single(entry.Spans);
            AssertValidSpan(span, "span-name");
            Assert.False(string.IsNullOrWhiteSpace(span.Labels[TraceLabels.StackTrace]));
        }

        [Fact]
        public void RunInSpan_Action()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            bool hasActionRan = false;
            // Note: block-bodied lambda to ensure it isn't converted to Func
            tracer.RunInSpan(() => { hasActionRan = true; }, "span-name");

            Assert.True(hasActionRan);
            var entry = Assert.Single(consumer.Items);
            var span = Assert.Single(entry.Spans);
            AssertValidSpan(span, "span-name");
        }

        [Fact]
        public void RunInSpan_Action_Throws()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            Assert.Throws<DivideByZeroException>(
                () => tracer.RunInSpan(() => throw new DivideByZeroException(), "span-name"));

            var entry = Assert.Single(consumer.Items);
            var span = Assert.Single(entry.Spans);
            AssertValidSpan(span, "span-name");
            Assert.Contains(nameof(RunInSpan_Action_Throws), span.Labels[TraceLabels.StackTrace]);

        }

        [Fact]
        public void RunInSpan_Func()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            Assert.Equal(11, tracer.RunInSpan(() => 11, "span-name"));

            var entry = Assert.Single(consumer.Items);
            var span = Assert.Single(entry.Spans);
            AssertValidSpan(span, "span-name");
        }

        [Fact]
        public void MultipleSpans()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            using (tracer.StartSpan("root"))
            {
                using (tracer.StartSpan("child-one"))
                {
                    tracer.SetStackTrace(FilledStackTrace);
                }
                using (tracer.StartSpan("child-two"))
                {
                    using (tracer.StartSpan("grandchild-one", StartSpanOptions.Create(SpanKind.RpcClient))) { }
                    using (tracer.StartSpan("grandchild-two"))
                    {
                        tracer.AnnotateSpan(annotation);
                    }
                }
            }

            var entry = Assert.Single(consumer.Items);
            var spans = entry.Spans;
            Assert.Equal(5, spans.Count);            
            AssertValidSpan(spans[0], "child-one", spans[4].SpanId);
            Assert.False(string.IsNullOrWhiteSpace(spans[0].Labels[TraceLabels.StackTrace]));
            AssertValidSpan(spans[1], "grandchild-one", spans[3].SpanId, SpanKind.RpcClient);
            AssertValidSpan(spans[2], "grandchild-two", spans[3].SpanId);
            Assert.True(TraceUtils.IsValidAnnotation(spans[2], annotation));
            AssertValidSpan(spans[3], "child-two", spans[4].SpanId);
            AssertValidSpan(spans[4], "root");
        }

        [Fact]
        public async Task MultipleSpans_Async()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            Func<string, string, Task> op = async (childName, grandchildName) =>
            {
                using (tracer.StartSpan(childName))
                {
                    await Task.Yield();
                    using (tracer.StartSpan(grandchildName))
                    {
                        await Task.Yield();
                    }
                    await Task.Yield();
                }
            };

            using (tracer.StartSpan("root"))
            {
                await Task.WhenAll(
                    op("child-one", "grandchild-one"),
                    op("child-two", "grandchild-two"));
            }

            var entry = Assert.Single(consumer.Items);
            var spans = entry.Spans.OrderBy(s => s.Name).ToList();
            Assert.Equal(5, spans.Count);
            var rootId = spans[4].SpanId;
            var childOneId = spans[0].SpanId;
            var childTwoId = spans[1].SpanId;
            AssertValidSpan(spans[0], "child-one", parentId: rootId);
            AssertValidSpan(spans[1], "child-two", parentId: rootId);
            AssertValidSpan(spans[2], "grandchild-one", parentId: childOneId);
            AssertValidSpan(spans[3], "grandchild-two", parentId: childTwoId);
            AssertValidSpan(spans[4], "root");
        }

        [Fact]
        public async Task MultipleSpans_Threads_Started_Before_Span()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            var childThreadsReleased = new ManualResetEventSlim(initialState: false);

            Func<string, string, Task> op = async (childName, grandchildName) =>
            {
                childThreadsReleased.Wait();

                using (tracer.StartSpan(childName))
                {
                    await Task.Yield();
                    using (tracer.StartSpan(grandchildName))
                    {
                        await Task.Yield();
                    }
                    await Task.Yield();
                }
            };
            var t1 = Task.Run(() => op("child-one", "grandchild-one").Wait());
            var t2 = Task.Run(() => op("child-two", "grandchild-two").Wait());

            using (tracer.StartSpan("root"))
            {
                childThreadsReleased.Set();
                await Task.WhenAll(t1, t2);
            }

            // Verify that even though the child spans were started during the time when the root span was open, they
            // don't have it as a parent since it had not been started when their tasks were created.
            var entry = Assert.Single(consumer.Items);
            var spans = entry.Spans.OrderBy(s => s.Name).ToList();
            Assert.Equal(5, spans.Count);
            var rootId = spans[4].SpanId;
            var childOneId = spans[0].SpanId;
            var childTwoId = spans[1].SpanId;
            AssertValidSpan(spans[0], "child-one", parentId: 0);
            AssertValidSpan(spans[1], "child-two", parentId: 0);
            AssertValidSpan(spans[2], "grandchild-one", parentId: childOneId);
            AssertValidSpan(spans[3], "grandchild-two", parentId: childTwoId);
            AssertValidSpan(spans[4], "root");
        }

        [Fact]
        public async Task MultipleSpans_Threads_Started_During_Span()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            var childThreadsReleased = new ManualResetEventSlim(initialState: false);
            var startedChildSpans = 0;

            Func<string, string, Task> op = async (childName, grandchildName) =>
            {
                childThreadsReleased.Wait();

                using (tracer.StartSpan(childName))
                {
                    Interlocked.Increment(ref startedChildSpans);

                    await Task.Yield();
                    using (tracer.StartSpan(grandchildName))
                    {
                        await Task.Yield();
                    }

                    do
                    {
                        await Task.Yield();
                        // Don't allow the span to close until both are started to make sure we only
                        // get a single Receive call below instead of two. Interlocked has no way to
                        // explicitly force read from main memory, but this hack will "attempt" to
                        // update the count and always fail, returning the actual value from main
                        // memory.
                    } while (Interlocked.CompareExchange(ref startedChildSpans, -1, -1) < 2);
                }
            };

            Task t1;
            Task t2;
            using (tracer.StartSpan("root"))
            {
                t1 = Task.Run(() => op("child-one", "grandchild-one").Wait());
                t2 = Task.Run(() => op("child-two", "grandchild-two").Wait());
            }

            childThreadsReleased.Set();
            await Task.WhenAll(t1, t2);

            Assert.Equal(2, consumer.Items.Count);
            Assert.Equal(2, consumer.ReceiveCount);

            var firstEntry = consumer.Items[0];
            var rootSpan = Assert.Single(firstEntry.Spans);
            AssertValidSpan(rootSpan, "root");
            var rootId = rootSpan.SpanId;

            // Verify that even though the child spans were started after the root span was ended, they
            // still have it as a parent since it was opened when their tasks were created.
            var secondEntry = consumer.Items[1];
            var nonRootSpans = secondEntry.Spans.OrderBy(s => s.Name).ToList();
            Assert.Equal(4, nonRootSpans.Count);
            var childOneId = nonRootSpans[0].SpanId;
            var childTwoId = nonRootSpans[1].SpanId;
            AssertValidSpan(nonRootSpans[0], "child-one", parentId: rootId);
            AssertValidSpan(nonRootSpans[1], "child-two", parentId: rootId);
            AssertValidSpan(nonRootSpans[2], "grandchild-one", parentId: childOneId);
            AssertValidSpan(nonRootSpans[3], "grandchild-two", parentId: childTwoId);
        }

        [Fact]
        public async Task MultipleSpans_Threads_Running_During_Span()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            Func<string, string, Task> op = async (childName, grandchildName) =>
            {
                using (tracer.StartSpan(childName))
                {
                    await Task.Yield();
                    using (tracer.StartSpan(grandchildName))
                    {
                        await Task.Yield();
                    }
                    await Task.Yield();
                }
            };

            using (tracer.StartSpan("root"))
            {
                await Task.WhenAll(
                    Task.Run(() => op("child-one", "grandchild-one")),
                    Task.Run(() => op("child-two", "grandchild-two")));
            }

            var entry = Assert.Single(consumer.Items);
            var spans = entry.Spans.OrderBy(s => s.Name).ToList();
            Assert.Equal(5, spans.Count);
            var rootId = spans[4].SpanId;
            var childOneId = spans[0].SpanId;
            var childTwoId = spans[1].SpanId;
            AssertValidSpan(spans[0], "child-one", parentId: rootId);
            AssertValidSpan(spans[1], "child-two", parentId: rootId);
            AssertValidSpan(spans[2], "grandchild-one", parentId: childOneId);
            AssertValidSpan(spans[3], "grandchild-two", parentId: childTwoId);
            AssertValidSpan(spans[4], "root");
        }

        [Fact]
        public void MultipleSpans_Dispose()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            using (tracer.StartSpan("root"))
            {
                using (tracer.StartSpan("child-one")) { }
                using (tracer.StartSpan("child-two"))
                {
                    using (tracer.StartSpan("grandchild-one")) { };
                }
            }

            var entry = Assert.Single(consumer.Items);
            var spans = entry.Spans;
            Assert.Equal(4, spans.Count);
            AssertValidSpan(spans[0], "child-one", spans[3].SpanId);
            AssertValidSpan(spans[1], "grandchild-one", spans[2].SpanId);
            AssertValidSpan(spans[2], "child-two", spans[3].SpanId);
            AssertValidSpan(spans[3], "root");
        }

        [Fact]
        public async Task DisjointThreads()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            ISpan span = null;
            await RunInDisjointThreads(() => span = tracer.StartSpan("span-name"), () => span.Dispose());

            var entry = Assert.Single(consumer.Items);
            var resultSpan = Assert.Single(entry.Spans);
            AssertValidSpan(resultSpan, "span-name");
        }

        [Fact]
        public async Task DisjointThreads_Annotate()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            var annotation = new Dictionary<string, string> { { "new", "label" } };

            ISpan span = null;
            await RunInDisjointThreads(() => span = tracer.StartSpan("span-name"),
                () =>
                {
                    span.SetStackTrace(FilledStackTrace);
                    span.AnnotateSpan(annotation);
                    span.Dispose();
                });

            var entry = Assert.Single(consumer.Items);
            var resultSpan = Assert.Single(entry.Spans);
            AssertValidSpan(resultSpan, "span-name");
            Assert.False(string.IsNullOrWhiteSpace(resultSpan.Labels[TraceLabels.StackTrace]));
            // Note: we can't easily use TraceUtils.IsValidAnnotation as the stack trace is also a label.
            Assert.Equal("label", resultSpan.Labels["new"]);
        }

        [Fact]
        public async Task DisjointThreads_Annotate_Fail()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            ISpan span = null;
            await RunInDisjointThreads(() => span = tracer.StartSpan("span-name"), () =>
            {
                tracer.SetStackTrace(FilledStackTrace);
                span.Dispose();
            }, new InvalidOperationException());

            Assert.Empty(consumer.Items);
        }

        /// <summary>
        /// Runs two actions in separate disjoint threads.  The first thread will always finish before
        /// the second.
        /// </summary>
        /// <param name="actionOne">The first action to run.</param>
        /// <param name="actionTwo">The second action to run.  If expectedException is not null, this action
        ///     is expected to throw an exception with the type of expectedException.</param>
        /// <param name="expectedException">Optional, an exception excepted to be thrown in actionTwo.</param>
        private async Task RunInDisjointThreads(Action actionOne, Action actionTwo, Exception expectedException = null)
        {
            var tcs1 = new TaskCompletionSource<bool>();
            var tcs2 = new TaskCompletionSource<bool>();
            Exception ex = null;
            Thread t = new Thread(() =>
            {
                try
                {
                    actionOne();
                }
                catch (Exception e)
                {
                    ex = e;
                    throw;
                }
                finally
                {
                    tcs1.SetResult(true);
                }
            });
            Thread t2 = new Thread(() =>
            {
                try
                {
                    if (expectedException == null)
                    {
                        tcs1.Task.Wait();
                        actionTwo();
                    }
                    else
                    {
                        Assert.Throws(expectedException.GetType(), actionTwo);
                    }
                }
                catch (Exception e)
                {
                    ex = e;
                    throw;
                }
                finally
                {
                    tcs2.SetResult(true);
                }
            });

            t.Start();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            t2.Start();

            await Task.WhenAll(tcs1.Task, tcs2.Task);
            if (expectedException == null)
            {
                Assert.Null(ex);
            }
        }

        [Fact]
        public void IncompleteSpans()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            tracer.StartSpan("span-name-0");
            using (tracer.StartSpan("span-name-1"))
            {
                using (tracer.StartSpan("span-name-2")) { }
            }
            Assert.Empty(consumer.Items);
        }

        [Fact]
        public void SpansClearedOnFlush()
        {
            var consumer = new SimpleConsumer<TraceProto>();
            var tracer = SimpleManagedTracer.Create(consumer, ProjectId, TraceId);

            tracer.StartSpan("span-name-0").Dispose();

            var firstEntry = Assert.Single(consumer.Items);
            var firstSpan = Assert.Single(firstEntry.Spans);
            AssertValidSpan(firstSpan, "span-name-0");

            // Just to make it easier to make assertions about the single new span.
            consumer.Items.Clear();

            tracer.StartSpan("span-name-1").Dispose();

            var secondEntry = Assert.Single(consumer.Items);
            var secondSpan = Assert.Single(secondEntry.Spans);
            AssertValidSpan(secondSpan, "span-name-1");
        }

        [Fact]
        public void Dispose_Twice_NoAvailableSpan()
        {
            var tracer = SimpleManagedTracer.Create(new SimpleConsumer<TraceProto>(), ProjectId, TraceId);
            var span = tracer.StartSpan("span");
            span.Dispose();
            Assert.Throws<InvalidOperationException>(() => span.Dispose());
        }

        [Fact]
        public void AnnotateSpan_NoAvailableSpan()
        {
            var tracer = SimpleManagedTracer.Create(new SimpleConsumer<TraceProto>(), ProjectId, TraceId);
            Assert.Throws<InvalidOperationException>(() => tracer.AnnotateSpan(new Dictionary<string, string>()));
        }

        [Fact]
        public void SetStackTrace_NoAvailableSpan()
        {
            var tracer = SimpleManagedTracer.Create(new SimpleConsumer<TraceProto>(), ProjectId, TraceId);
            var emptyStackTrace = new StackTrace(new Exception(), false);
            Assert.Throws<InvalidOperationException>(() => tracer.SetStackTrace(emptyStackTrace));
        }

        [Fact]
        public void GetCurrentTraceId()
        {
            var tracer = SimpleManagedTracer.Create(new SimpleConsumer<TraceProto>(), ProjectId, TraceId);
            Assert.Equal(TraceId, tracer.GetCurrentTraceId());
        }

        [Fact]
        public void GetCurrentSpanId_NoSpan()
        {
            var tracer = SimpleManagedTracer.Create(new SimpleConsumer<TraceProto>(), ProjectId, TraceId);
            Assert.Null(tracer.GetCurrentSpanId());
        }

        [Fact]
        public void GetCurrentSpanId_Span()
        {
            var tracer = SimpleManagedTracer.Create(new SimpleConsumer<TraceProto>(), ProjectId, TraceId);
            tracer.StartSpan("span-name");
            Assert.NotNull(tracer.GetCurrentSpanId());
        }

        [Fact]
        public void GetCurrentSpanId_ParentSpan()
        {
            ulong parentSpanId = 54321;
            var tracer = SimpleManagedTracer.Create(new SimpleConsumer<TraceProto>(), ProjectId, TraceId, parentSpanId);
            Assert.Equal(parentSpanId, tracer.GetCurrentSpanId());
        }
    }
}
