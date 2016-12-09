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
using Moq;
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.AspNet.Tests
{
    public class BufferingTraceConsumerTest
    {
        private TraceProto CreateTrace() => new TraceProto
        { ProjectId = "some-pid", TraceId = "f05445aa7843bc8bf206b12000100000" };

        [Fact]
        public void Receive()
        {
            int bufferSize = 1024;
            Traces initialTraces = new Traces { Traces_ = { CreateTrace() } };

            Mock<ITraceConsumer> mockConsumer = new Mock<ITraceConsumer>();
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(mockConsumer.Object, bufferSize);
            consumer.Receive(initialTraces);

            // Ensure the traces have not been sent as they are not bigger then the buffer.
            mockConsumer.Verify(c => c.Receive(It.IsAny<Traces>()), Times.Never());

            // Fill up traces to be bigger then the buffer.
            Traces traces = new Traces();
            while (traces.Traces_.Count < 1000 && traces.CalculateSize() < bufferSize)
            {
                traces.Traces_.Add(CreateTrace());
            }

            // Add the initial trace the list of traces.  This ensures we verify the right 
            // traces where received.
            Traces allTraces = traces.Clone();
            allTraces.Traces_.Add(initialTraces.Traces_[0]);
            mockConsumer.Setup(c => c.Receive(allTraces));

            consumer.Receive(traces);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Flush()
        {
            Traces traces = new Traces { Traces_ = { CreateTrace() } };

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