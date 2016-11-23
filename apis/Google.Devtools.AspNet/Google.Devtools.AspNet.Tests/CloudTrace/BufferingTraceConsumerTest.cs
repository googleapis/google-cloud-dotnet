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

using Google.Devtools.Cloudtrace.V1;
using Moq;
using Xunit;

namespace Google.Devtools.AspNet.Tests.CloudTrace
{
    public class BufferingTraceConsumerTest
    {
        private Trace CreateTrace()
        {
            return new Trace()
            {
                ProjectId = "some-pid",
                TraceId = "f05445aa7843bc8bf206b12000100000"
            };
        }

        [Fact]
        public void Receive()
        {
            int bufferSize = 1024;
            Traces traces = new Traces();
            traces.Traces_.Add(CreateTrace());

            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(mockConsumer.Object, bufferSize);
            consumer.Receive(traces);
            mockConsumer.Verify(c => c.Receive(It.IsAny<Traces>()), Times.Never());

            traces = new Traces();
            while (traces.Traces_.Count < 1000 && traces.CalculateSize() < bufferSize)
            {
                traces.Traces_.Add(CreateTrace());
            }

            // Add the initial trace to the current list.
            Traces combined = traces;
            combined.Traces_.Add(CreateTrace());
            mockConsumer.Setup(c => c.Receive(traces));

            consumer.Receive(traces);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Flush()
        {
            Traces traces = new Traces();
            Trace trace = new Trace();
            traces.Traces_.Add(trace);

            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            mockConsumer.Setup(c => c.Receive(traces));
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(mockConsumer.Object, int.MaxValue);
            consumer.Receive(traces);
            mockConsumer.Verify(c => c.Receive(It.IsAny<Traces>()), Times.Never());

            consumer.Flush();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Flush_NoTraces()
        {
            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(mockConsumer.Object, int.MaxValue);
            consumer.Receive(new Traces());
            consumer.Flush();
            mockConsumer.Verify(c => c.Receive(It.IsAny<Traces>()), Times.Never());
        }
    }
}