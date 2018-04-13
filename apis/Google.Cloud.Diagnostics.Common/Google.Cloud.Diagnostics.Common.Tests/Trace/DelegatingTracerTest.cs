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

using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class DelegatingTracerTest
    {
        [Fact]
        public async Task RunInSpanAsync_CorrectSpan()
        {
            const string traceId = "trace-id";
            const string projectId = "project-id";
            const string traceName = "trace-name";
            const int delayInSeconds = 1;

            TraceProto actualTraceProto = null;

            Mock<IConsumer<TraceProto>> mockConsumer = new Mock<IConsumer<TraceProto>>();
            mockConsumer.Setup(x => x.Receive(It.IsAny<IEnumerable<TraceProto>>()))
                .Callback<IEnumerable<TraceProto>>(arg => actualTraceProto = arg?.FirstOrDefault());

            IManagedTracer simpleTracer = SimpleManagedTracer.Create(mockConsumer.Object, projectId, traceId);
            IManagedTracer delegatingTracer = new DelegatingTracer(() => simpleTracer);

            var stopwatch = Stopwatch.StartNew();
            await delegatingTracer.RunInSpanAsync(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(delayInSeconds));
                return 0;
            }, traceName);
            stopwatch.Stop();

            Assert.NotNull(actualTraceProto);
            Assert.InRange(SpanInSeconds(actualTraceProto), delayInSeconds, stopwatch.Elapsed.Seconds);
        }

        private static long SpanInSeconds(TraceProto actualTraceProto)
        {
            var duration = actualTraceProto.Spans.First().EndTime - actualTraceProto.Spans.First().StartTime;
            return duration.Seconds;
        }
    }
}