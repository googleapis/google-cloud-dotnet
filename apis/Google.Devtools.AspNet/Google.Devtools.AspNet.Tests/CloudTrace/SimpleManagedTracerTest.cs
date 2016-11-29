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
using Google.Protobuf.Collections;

using Trace = Google.Cloud.Trace.V1.Trace;

namespace Google.Devtools.AspNet.Tests
{
    public class SimpleManagedTracerTest
    {
        private const string TraceId = "trace-id";
        private const string ProjectId = "project-id";

        private static readonly ITraceConsumer UnusedConsumer = (new Mock<ITraceConsumer>()).Object;
        private static readonly Dictionary<string, string> EmptyDictionary = new Dictionary<string, string>();
        private static readonly StackTrace EmptyStackTrace = new StackTrace();

        private static Trace CreateTrace(string projectId = ProjectId, string traceId = TraceId)
            => new Trace { ProjectId = ProjectId, TraceId = TraceId };
        

        private static bool IsValidSpan(TraceSpan span, string name)
            => IsValidSpan(span, name, 0);

        private static bool IsValidSpan(TraceSpan span, string name, ulong parentId)
            => IsValidSpan(span, name, parentId, SpanKind.Unspecified);

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

        private static bool IsValidAnnotation(TraceSpan span, Dictionary<string, string> annotation)
        {
            MapField<string, string> labels = span.Labels;
            if (labels.Count != annotation.Count)
            {
                return false;
            }

            foreach (KeyValuePair<string, string> label in labels)
            {
                if (annotation[label.Key] != label.Value)
                {
                    return false;
                }
            }
            return true;
        }

        [Fact]
        public void SingleSpan()
        {
            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            IManagedTracer tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            mockConsumer.Setup(c => c.Receive(
                Match.Create<Traces>(
                    t => t.Traces_.Count == 1 &&
                        t.Traces_[0].Spans.Count == 1 &&
                        IsValidSpan(t.Traces_[0].Spans[0], "span-name"))));

            tracer.StartSpan("span-name");
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_ParentId()
        {
            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            IManagedTracer tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace(), 123);

            mockConsumer.Setup(c => c.Receive(
                Match.Create<Traces>(
                    t => t.Traces_.Count == 1 &&
                        t.Traces_[0].Spans.Count == 1 &&
                        IsValidSpan(t.Traces_[0].Spans[0], "span-name", 123))));

            tracer.StartSpan("span-name");
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Options()
        {
            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            IManagedTracer tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            mockConsumer.Setup(c => c.Receive(
                Match.Create<Traces>(
                    t => t.Traces_.Count == 1 &&
                        t.Traces_[0].Spans.Count == 1 &&
                        IsValidSpan(t.Traces_[0].Spans[0], "span-name", 0, SpanKind.RpcClient))));

            StartSpanOptions options = StartSpanOptions.Create(SpanKind.RpcClient);
            tracer.StartSpan("span-name", options);
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Annotation()
        {
            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            IManagedTracer tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            Dictionary<string, string> annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            mockConsumer.Setup(c => c.Receive(
                Match.Create<Traces>(
                    t => t.Traces_.Count == 1 &&
                        t.Traces_[0].Spans.Count == 1 &&
                        IsValidSpan(t.Traces_[0].Spans[0], "span-name") &&
                        IsValidAnnotation(t.Traces_[0].Spans[0], annotation))));

            tracer.StartSpan("span-name");
            tracer.AnnotateSpan(annotation);
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void SingleSpan_Stacktrace()
        {
            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            IManagedTracer tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            Dictionary<string, string> annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            mockConsumer.Setup(c => c.Receive(
                Match.Create<Traces>(
                    t => t.Traces_.Count == 1 &&
                        t.Traces_[0].Spans.Count == 1 &&
                        IsValidSpan(t.Traces_[0].Spans[0], "span-name") &&
                        !string.IsNullOrWhiteSpace(t.Traces_[0].Spans[0].Labels[Labels.StackTrace]))));

            tracer.StartSpan("span-name");
            tracer.SetStackTrace(EmptyStackTrace);
            tracer.EndSpan();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void MultipleSpans()
        {
            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            IManagedTracer tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            Dictionary<string, string> annotation = new Dictionary<string, string>();
            annotation.Add("annotation-key", "annotation-value");

            mockConsumer.Setup(c => c.Receive(
                Match.Create<Traces>(
                    t => t.Traces_.Count == 1 &&
                        t.Traces_[0].Spans.Count == 5 &&
                        IsValidSpan(t.Traces_[0].Spans[0], "child-one", t.Traces_[0].Spans[4].SpanId) &&
                        IsValidSpan(t.Traces_[0].Spans[1], "grandchild-one", t.Traces_[0].Spans[3].SpanId, SpanKind.RpcClient) &&
                        IsValidSpan(t.Traces_[0].Spans[2], "grandchild-two", t.Traces_[0].Spans[3].SpanId) &&
                        IsValidAnnotation(t.Traces_[0].Spans[2], annotation) &&
                        IsValidSpan(t.Traces_[0].Spans[3], "child-two", t.Traces_[0].Spans[4].SpanId) &&
                        !string.IsNullOrWhiteSpace(t.Traces_[0].Spans[0].Labels[Labels.StackTrace]) &&
                        IsValidSpan(t.Traces_[0].Spans[4], "root"))));

            tracer.StartSpan("root");
            tracer.StartSpan("child-one");
            tracer.SetStackTrace(EmptyStackTrace);
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
        public void IncompleteSpans()
        {
            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            IManagedTracer tracer = SimpleManagedTracer.Create(mockConsumer.Object, CreateTrace());

            tracer.StartSpan("span-name-0");
            tracer.StartSpan("span-name-1");
            tracer.StartSpan("span-name-2");
            tracer.EndSpan();
            tracer.EndSpan();
            mockConsumer.Verify(c => c.Receive(It.IsAny<Traces>()), Times.Never());
        }

        [Fact]
        public void EndSpan_NoAvailableSpan()
        {
            IManagedTracer tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            Assert.Throws<InvalidOperationException>(() => tracer.EndSpan());
        }

        [Fact]
        public void AnnotateSpan_NoAvailableSpan()
        {
            IManagedTracer tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            Assert.Throws<InvalidOperationException>(() => tracer.AnnotateSpan(EmptyDictionary));
        }

        [Fact]
        public void SetStackTrace_NoAvailableSpan()
        {
            IManagedTracer tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            Assert.Throws<InvalidOperationException>(() => tracer.SetStackTrace(EmptyStackTrace));
        }

        [Fact]
        public void GetCurrentTraceId()
        {
            IManagedTracer tracer = SimpleManagedTracer.Create(UnusedConsumer, CreateTrace());
            Assert.Equal(tracer.GetCurrentTraceId(), TraceId);
        }
    }
}