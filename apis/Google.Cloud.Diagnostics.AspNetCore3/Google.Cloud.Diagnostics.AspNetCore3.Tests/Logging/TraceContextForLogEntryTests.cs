// Copyright 2020 Google LLC
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

using Google.Cloud.Diagnostics.Common;
using Moq;
using Xunit;

#if NETCOREAPP3_1
namespace Google.Cloud.Diagnostics.AspNetCore3.Tests
#elif NETCOREAPP2_1 || NET461
namespace Google.Cloud.Diagnostics.AspNetCore.Tests
#else
#error unknown target framework
#endif
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class TraceContextForLogEntryTests
    {
        [Fact]
        public void FromGoogleTrace()
        {
            var oldTracer = ContextTracerManager.GetCurrentTracer();
            try
            {
                string traceId = "dummy_trace_id";
                ulong spanId = 0x12D687;
                // The spanId set on the log entry should confirm to x16
                // format so that the backend can really associate the log entry
                // to the span.
                string expectedSpanId = "000000000012d687";

                ContextTracerManager.SetCurrentTracer(MockTracer(traceId, spanId));

                var traceContext = TraceContextForLogEntry.FromGoogleTrace();

                Assert.Equal(traceId, traceContext.TraceId);
                Assert.Equal(expectedSpanId, traceContext.SpanId);
            }
            finally
            {
                ContextTracerManager.SetCurrentTracer(oldTracer);
            }            
        }

        [Fact]
        public void FromGoogleTrace_NoTrace()
        {
            var oldTracer = ContextTracerManager.GetCurrentTracer();
            try
            {
                ContextTracerManager.SetCurrentTracer(MockTracer());

                Assert.Null(TraceContextForLogEntry.FromGoogleTrace());
            }
            finally
            {
                ContextTracerManager.SetCurrentTracer(oldTracer);
            }
        }

        [Fact]
        public void FromGoogleTrace_NoSpan()
        {
            var oldTracer = ContextTracerManager.GetCurrentTracer();
            try
            {
                string traceId = "dummy_trace_id";

                ContextTracerManager.SetCurrentTracer(MockTracer(traceId));

                var traceContext = TraceContextForLogEntry.FromGoogleTrace();

                Assert.Equal(traceId, traceContext.TraceId);
                Assert.Null(traceContext.SpanId);
            }
            finally
            {
                ContextTracerManager.SetCurrentTracer(oldTracer);
            }
        }

        private IManagedTracer MockTracer(string traceId = null, ulong? spanId = null)
        {
            Mock<IManagedTracer> tracerMock = new Mock<IManagedTracer>(MockBehavior.Strict);
            tracerMock.Setup(t => t.GetCurrentTraceId()).Returns(traceId);
            tracerMock.Setup(t => t.GetCurrentSpanId()).Returns(spanId);

            return tracerMock.Object;
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}
