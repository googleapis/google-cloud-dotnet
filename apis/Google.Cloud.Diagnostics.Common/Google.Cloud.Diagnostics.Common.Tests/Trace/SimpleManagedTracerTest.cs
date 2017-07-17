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
using Xunit;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class SimpleManagedTracerTest
    {
        private const string TraceId = "trace-id";
        private const string ProjectId = "project-id";

        private static readonly IConsumer<TraceProto> UnusedConsumer = (new Mock<IConsumer<TraceProto>>()).Object;
        private static readonly Dictionary<string, string> EmptyDictionary = new Dictionary<string, string>();
        private static readonly StackTrace EmptyStackTrace = new StackTrace(new Exception(), false);
        private static readonly StackTrace FilledStackTrace = CreateStackTrace();

        private static bool IsValidSpan(TraceSpan span, string name)
            => IsValidSpan(span, name, 0);

        private static bool IsValidSpan(TraceSpan span, string name, ulong parentId)
            => IsValidSpan(span, name, parentId, SpanKind.Unspecified);

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

        private static bool IsValidSpan(TraceSpan span, string name, ulong parentId, SpanKind kind)
        {
            return span.SpanId != 0 &&
                kind.Convert() == span.Kind &&
                name.Equals(span.Name) &&
                span.StartTime != null &&
                parentId == span.ParentSpanId &&
                span.EndTime != null &&
                span.StartTime.ToDateTime() <= span.EndTime.ToDateTime();
        }

        [Fact]
        public void SingleSpan()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name"))));

            tracer.StartSpan("span-name").Dispose();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Dispose()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name"))));

            tracer.StartSpan("span-name").Dispose();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_ParentId()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId, 123);

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name", 123))));

            tracer.StartSpan("span-name").Dispose();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Options()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name", 0, SpanKind.RpcClient)
                        && TraceUtils.IsValidAnnotation(t.ElementAt(0).Spans[0], annotation))));

            var options = StartSpanOptions.Create(SpanKind.RpcClient, annotation);
            tracer.StartSpan("span-name", options).Dispose();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Annotation()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name") &&
                        TraceUtils.IsValidAnnotation(t.ElementAt(0).Spans[0], annotation))));

            using (tracer.StartSpan("span-name"))
            {
                tracer.AnnotateSpan(annotation);
            }               
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Stacktrace()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name") &&
                        !string.IsNullOrWhiteSpace(t.ElementAt(0).Spans[0].Labels[TraceLabels.StackTrace]))));

            using (tracer.StartSpan("span-name"))
            {
                tracer.SetStackTrace(FilledStackTrace);
            }                
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void RunInSpan_Action()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name"))));

            bool hasActionRan = false;
            tracer.RunInSpan(() => { hasActionRan = true; }, "span-name");
            Assert.True(hasActionRan);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void RunInSpan_Action_Throws()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name") &&
                    !string.IsNullOrWhiteSpace(t.ElementAt(0).Spans[0].Labels[TraceLabels.StackTrace]) &&
                    t.ElementAt(0).Spans[0].Labels[TraceLabels.StackTrace].Contains(nameof(RunInSpan_Action_Throws)))));

            Assert.Throws<DivideByZeroException>(
                () => tracer.RunInSpan(
                    () => { throw new DivideByZeroException(); }, "span-name"));
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void RunInSpan_Func()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name"))));

            Assert.Equal(11, tracer.RunInSpan(() => { return 11; }, "span-name"));
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void MultipleSpans()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            Predicate<IEnumerable<TraceProto>> matcher = t =>
            {
                var spans = t.Single().Spans;
                return spans.Count == 5 &&
                    IsValidSpan(spans[0], "child-one", spans[4].SpanId) &&
                    IsValidSpan(spans[1], "grandchild-one", spans[3].SpanId, SpanKind.RpcClient) &&
                    IsValidSpan(spans[2], "grandchild-two", spans[3].SpanId) &&
                    TraceUtils.IsValidAnnotation(spans[2], annotation) &&
                    IsValidSpan(spans[3], "child-two", spans[4].SpanId) &&
                    !string.IsNullOrWhiteSpace(spans[0].Labels[TraceLabels.StackTrace]) &&
                    IsValidSpan(spans[4], "root");
            };
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));

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
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task MultipleSpans_Async()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            Predicate<IEnumerable<TraceProto>> matcher = t =>
            {
                var spans = t.Single().Spans.OrderBy(s => s.Name).ToList();
                var rootId = spans[4].SpanId;
                var childOneId = spans[0].SpanId;
                var childTwoId = spans[1].SpanId;
                return spans.Count == 5 &&
                    IsValidSpan(spans[0], "child-one", parentId: rootId) &&
                    IsValidSpan(spans[1], "child-two", parentId: rootId) &&
                    IsValidSpan(spans[2], "grandchild-one", parentId: childOneId) &&
                    IsValidSpan(spans[3], "grandchild-two", parentId: childTwoId) &&
                    IsValidSpan(spans[4], "root");
            };
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));

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
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task MultipleSpans_Threads_Started_Before_Span()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            Predicate<IEnumerable<TraceProto>> rootMatcher = t =>
            {
                // Verify that even though the child spans were started during the time when the root span was open, they
                // don't have it as a parent since it had not been started when their tasks were created.
                var spans = t.Single().Spans.OrderBy(s => s.Name).ToList();
                var childOneId = spans[0].SpanId;
                var childTwoId = spans[1].SpanId;
                return spans.Count == 5 &&
                    IsValidSpan(spans[0], "child-one", parentId: 0) &&
                    IsValidSpan(spans[1], "child-two", parentId: 0) &&
                    IsValidSpan(spans[2], "grandchild-one", parentId: childOneId) &&
                    IsValidSpan(spans[3], "grandchild-two", parentId: childTwoId) &&
                    IsValidSpan(spans[4], "root");
            };
            mockConsumer.Setup(c => c.Receive(Match.Create(rootMatcher)));

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

            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task MultipleSpans_Threads_Started_During_Span()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            ulong rootId = 0;
            Predicate<IEnumerable<TraceProto>> rootMatcher = t =>
            {
                var spans = t.Single().Spans;
                rootId = spans[0].SpanId;
                return spans.Count == 1 && IsValidSpan(spans[0], "root");
            };
            mockConsumer.Setup(c => c.Receive(Match.Create(rootMatcher)));

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

            Predicate<IEnumerable<TraceProto>> childMatcher = t =>
            {
                // Verify that even though the child spans were started after the root span was ended, they
                // still have it as a parent since it was opened when their tasks were created.
                var spans = t.Single().Spans.OrderBy(s => s.Name).ToList();
                var childOneId = spans[0].SpanId;
                var childTwoId = spans[1].SpanId;
                return spans.Count == 4 &&
                    IsValidSpan(spans[0], "child-one", parentId: rootId) &&
                    IsValidSpan(spans[1], "child-two", parentId: rootId) &&
                    IsValidSpan(spans[2], "grandchild-one", parentId: childOneId) &&
                    IsValidSpan(spans[3], "grandchild-two", parentId: childTwoId);
            };
            mockConsumer.Setup(c => c.Receive(Match.Create(childMatcher)));

            childThreadsReleased.Set();
            await Task.WhenAll(t1, t2);

            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task MultipleSpans_Threads_Running_During_Span()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            Predicate<IEnumerable<TraceProto>> matcher = t =>
            {
                var spans = t.Single().Spans.OrderBy(s => s.Name).ToList();
                var rootId = spans[4].SpanId;
                var childOneId = spans[0].SpanId;
                var childTwoId = spans[1].SpanId;
                return spans.Count == 5 &&
                    IsValidSpan(spans[0], "child-one", parentId: rootId) &&
                    IsValidSpan(spans[1], "child-two", parentId: rootId) &&
                    IsValidSpan(spans[2], "grandchild-one", parentId: childOneId) &&
                    IsValidSpan(spans[3], "grandchild-two", parentId: childTwoId) &&
                    IsValidSpan(spans[4], "root");
            };
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));

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
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void MultipleSpans_Dispose()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            Predicate<IEnumerable<TraceProto>> matcher = t =>
            {
                var spans = t.Single().Spans;
                return spans.Count == 4 &&
                    IsValidSpan(spans[0], "child-one", spans[3].SpanId) &&
                    IsValidSpan(spans[1], "grandchild-one", spans[2].SpanId) &&
                    IsValidSpan(spans[2], "child-two", spans[3].SpanId) &&
                    IsValidSpan(spans[3], "root");
            };
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));

            using (tracer.StartSpan("root"))
            {
                using (tracer.StartSpan("child-one")) { }
                using (tracer.StartSpan("child-two"))
                {
                    using (tracer.StartSpan("grandchild-one")) { } ;
                }
            }
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task DisjointThreads()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);
            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    tProto => IsValidSpan(tProto.Single().Spans.Single(), "span-name"))));

            ISpan span = null;
            await RunInDisjointThreads(() => span = tracer.StartSpan("span-name"), () => span.Dispose());
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task DisjointThreads_Annotate()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);
            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    tProto => IsValidSpan(tProto.Single().Spans.Single(), "span-name"))));

            var annotation = new Dictionary<string, string> { { "new", "label" } };

            Predicate<IEnumerable<TraceProto>> matcher = t =>
            {
                var singleSpan = t.Single().Spans.Single();
                return IsValidSpan(singleSpan, "span-name") &&
                    string.IsNullOrWhiteSpace(singleSpan.Labels[TraceLabels.StackTrace]) &&
                    TraceUtils.IsValidAnnotation(singleSpan, annotation);
            };
            mockConsumer.Setup(c => c.Receive(Match.Create(matcher)));

            ISpan span = null;
            await RunInDisjointThreads(() => span = tracer.StartSpan("span-name"), 
                () =>
                {
                    span.SetStackTrace(FilledStackTrace);
                    span.AnnotateSpan(annotation);
                    span.Dispose();
                });
            mockConsumer.Verify();
        }

        [Fact]
        public async Task DisjointThreads_Annotate_Fail()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            ISpan span = null;
            await RunInDisjointThreads(() => span = tracer.StartSpan("span-name"), () =>
            {
                tracer.SetStackTrace(FilledStackTrace);
                span.Dispose();
            }, new InvalidOperationException());
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<TraceProto>>()), Times.Never);
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
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            tracer.StartSpan("span-name-0");
            using (tracer.StartSpan("span-name-1"))
            {
                using (tracer.StartSpan("span-name-2")) { }
            }
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<TraceProto>>()), Times.Never());
        }

        [Fact]
        public void SpansClearedOnFlush()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, ProjectId, TraceId);

            mockConsumer.Setup(c => c.Receive(
                 Match.Create<IEnumerable<TraceProto>>(
                     t => IsValidSpan(t.Single().Spans.Single(), "span-name-0"))));

            tracer.StartSpan("span-name-0").Dispose();

            mockConsumer.VerifyAll();

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name-1"))));

            tracer.StartSpan("span-name-1").Dispose();

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Dispose_Twice_NoAvailableSpan()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, ProjectId, TraceId);
            var span = tracer.StartSpan("span");
            span.Dispose();
            Assert.Throws<InvalidOperationException>(() => span.Dispose());
        }

        [Fact]
        public void AnnotateSpan_NoAvailableSpan()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, ProjectId, TraceId);
            Assert.Throws<InvalidOperationException>(() => tracer.AnnotateSpan(EmptyDictionary));
        }

        [Fact]
        public void SetStackTrace_NoAvailableSpan()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, ProjectId, TraceId);
            Assert.Throws<InvalidOperationException>(() => tracer.SetStackTrace(EmptyStackTrace));
        }

        [Fact]
        public void GetCurrentTraceId()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, ProjectId, TraceId);
            Assert.Equal(tracer.GetCurrentTraceId(), TraceId);
        }

        [Fact]
        public void GetCurrentSpanId_NoSpan()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, ProjectId, TraceId);
            Assert.Null(tracer.GetCurrentSpanId());
        }

        [Fact]
        public void GetCurrentSpanId_Span()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, ProjectId, TraceId);
            tracer.StartSpan("span-name");
            Assert.NotNull(tracer.GetCurrentSpanId());
        }

        [Fact]
        public void GetCurrentSpanId_ParentSpan()
        {
            ulong parentSpanId = 54321;
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, ProjectId, TraceId, parentSpanId);
            Assert.Equal(tracer.GetCurrentSpanId(), parentSpanId);
        }
    }
}