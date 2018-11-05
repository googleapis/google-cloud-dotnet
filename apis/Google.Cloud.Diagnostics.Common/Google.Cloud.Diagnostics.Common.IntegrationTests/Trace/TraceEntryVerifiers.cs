// Copyright 2018 Google Inc. All Rights Reserved.
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
using System.Collections.Generic;
using System.Linq;
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    public static class TraceEntryVerifiers
    {
        /// <summary>
        /// Checks a trace for the following:
        /// <list type="bullet">
        /// <term>The trace is not null.</term>
        /// <term>The trace has one span.</term>
        /// <term>The span name is spanName</term>
        /// </list>
        /// </summary>
        /// <param name="trace">The trace to check.</param>
        /// <param name="spanName">The expected name of the span.</param>
        public static void AssertSingleSpan(TraceProto trace, string spanName)
        {
            Assert.NotNull(trace);
            var span = trace.Spans.Single();
            Assert.Equal(spanName, span.Name);
        }

        /// <summary>
        /// Checks a trace for the following:
        /// <list type="bullet">
        /// <term>The trace is not null.</term>
        /// <term>The trace has <code>2 + <paramref name="subsequentDescendants"/>.Length</code> spans.</term>
        /// <term>The trace has a root span with name rootSpanName</term>
        /// <term>The root span has a single child span with name childSpanName</term>
        /// <term>Subsequent descendants are present (in depth, not width) in the same order as they are present on <paramref name="subsequentDescendants"/>.</term>
        /// </list>
        /// </summary>
        /// <param name="trace">The trace to check.</param>
        /// <param name="rootSpanName">The name of the root span.</param>
        /// <param name="childSpanName">The name of the child span.</param>
        /// <param name="subsequentDescendants">The names of extra descendtans of child span.</param>
        public static void AssertParentChildSpan(TraceProto trace, string rootSpanName, string childSpanName, params string[] subsequentDescendants)
        {
            Assert.NotNull(trace);
            var spans = trace.Spans;
            Assert.Equal(2 + subsequentDescendants?.Length ?? 0, spans.Count);
            var mainSpan = spans.Single(s => s.Name == rootSpanName);
            var innerSpan = spans.Single(s => s.Name == childSpanName);
            Assert.Equal(mainSpan.SpanId, innerSpan.ParentSpanId);
            if (subsequentDescendants != null)
            {
                mainSpan = innerSpan;
                foreach (string spanName in subsequentDescendants)
                {
                    innerSpan = spans.Single(s => s.Name == spanName);
                    Assert.Equal(mainSpan.SpanId, innerSpan.ParentSpanId);
                    mainSpan = innerSpan;
                }
            }
        }

        /// <summary>
        /// Verifies that the span has the exact set of expected labels.
        /// </list>
        /// </summary>
        /// <param name="span">The spna to check.</param>
        /// <param name="expectedLabels">The set of labels expected to be present on the span.</param>
        public static void AssertSpanLabelsExact(TraceSpan span, IDictionary<string, string> expectedLabels)
        {
            Assert.Equal(expectedLabels.Count, span.Labels.Count);
            AssertSpanLabelsContains(span, expectedLabels);
        }

        /// <summary>
        /// Verifies that the span contains the set of expected labels.
        /// The span can have other labels.
        /// </list>
        /// </summary>
        /// <param name="span">The span to check.</param>
        /// <param name="expectedLabels">The set of labels expected to be present on the span.</param>
        public static void AssertSpanLabelsContains(TraceSpan span, IDictionary<string, string> expectedLabels)
        {
            foreach (var keyValue in expectedLabels)
            {
                Assert.Equal(keyValue.Value, span.Labels[keyValue.Key]);
            }
        }

        /// <summary>
        /// Verifies that a span contains a StackTrace label whose value contains
        /// the specified texts.
        /// </summary>
        public static void AssertContainsStackTrace(TraceSpan span, params string[] textContained)
        {
            var labelValue = span.Labels[TraceLabels.StackTrace];
            Assert.False(string.IsNullOrWhiteSpace(labelValue));
            foreach (var text in textContained)
            {
                labelValue.Contains(text);
            }
        }
    }
}
