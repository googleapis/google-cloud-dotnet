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

        private static TraceProto CreateTrace(string projectId = ProjectId, string traceId = TraceId)
            => new TraceProto { ProjectId = ProjectId, TraceId = TraceId };

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
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name"))));

            tracer.StartSpan("span-name");
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Dispose()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name"))));

            using (tracer.StartSpan("span-name")) { }
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_ParentId()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace(), 123);

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name", 123))));

            tracer.StartSpan("span-name");
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Options()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name", 0, SpanKind.RpcClient)
                        && TraceUtils.IsValidAnnotation(t.ElementAt(0).Spans[0], annotation))));

            var options = StartSpanOptions.Create(SpanKind.RpcClient, annotation);
            tracer.StartSpan("span-name", options);
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Annotation()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name") &&
                        TraceUtils.IsValidAnnotation(t.ElementAt(0).Spans[0], annotation))));

            tracer.StartSpan("span-name");
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Stacktrace()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name") &&
                        !string.IsNullOrWhiteSpace(t.ElementAt(0).Spans[0].Labels[TraceLabels.StackTrace]))));

            tracer.StartSpan("span-name");
            tracer.SetStackTrace(FilledStackTrace);
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void RunInSpan_Action()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

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
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

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
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

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
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            Predicate<IEnumerable<TraceProto>> matcher = (IEnumerable<TraceProto> t) => 
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

            tracer.StartSpan("root");
            tracer.StartSpan("child-one");
            tracer.SetStackTrace(FilledStackTrace);
            tracer.EndSpan();
            tracer.StartSpan("child-two");
            tracer.StartSpan("grandchild-one", StartSpanOptions.Create(SpanKind.RpcClient));
            tracer.EndSpan();
            tracer.StartSpan("grandchild-two");
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();
            tracer.EndSpan();
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void MultipleSpans_Dispose()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            var annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            Predicate<IEnumerable<TraceProto>> matcher = (IEnumerable<TraceProto> t) =>
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
        public void IncompleteSpans()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            tracer.StartSpan("span-name-0");
            tracer.StartSpan("span-name-1");
            tracer.StartSpan("span-name-2");
            tracer.EndSpan();
            tracer.EndSpan();
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<TraceProto>>()), Times.Never());
        }

        [Fact]
        public void SpansClearedOnFlush()
        {
            var mockConsumer = new Mock<IConsumer<TraceProto>>();
            var tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            mockConsumer.Setup(c => c.Receive(
                 Match.Create<IEnumerable<TraceProto>>(
                     t => IsValidSpan(t.Single().Spans.Single(), "span-name-0"))));

            tracer.StartSpan("span-name-0");
            tracer.EndSpan();

            mockConsumer.VerifyAll();

            mockConsumer.Setup(c => c.Receive(
                Match.Create<IEnumerable<TraceProto>>(
                    t => IsValidSpan(t.Single().Spans.Single(), "span-name-1"))));

            tracer.StartSpan("span-name-1");
            tracer.EndSpan();

            mockConsumer.VerifyAll();
        }

        [Fact]
        public void EndSpan_NoAvailableSpan()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            Assert.Throws<InvalidOperationException>(() => tracer.EndSpan());
        }

        [Fact]
        public void AnnotateSpan_NoAvailableSpan()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            Assert.Throws<InvalidOperationException>(() => tracer.AnnotateSpan(EmptyDictionary));
        }

        [Fact]
        public void SetStackTrace_NoAvailableSpan()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            Assert.Throws<InvalidOperationException>(() => tracer.SetStackTrace(EmptyStackTrace));
        }

        [Fact]
        public void GetCurrentTraceId()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            Assert.Equal(tracer.GetCurrentTraceId(), TraceId);
        }

        [Fact]
        public void GetCurrentSpanId_NoSpan()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            Assert.Null(tracer.GetCurrentSpanId());
        }

        [Fact]
        public void GetCurrentSpanId_Span()
        {
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            tracer.StartSpan("span-name");
            Assert.NotNull(tracer.GetCurrentSpanId());
        }

        [Fact]
        public void GetCurrentSpanId_ParentSpan()
        {
            ulong parentSpanId = 54321;
            var tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace(), parentSpanId);
            Assert.Equal(tracer.GetCurrentSpanId(), parentSpanId);
        }
    }
}