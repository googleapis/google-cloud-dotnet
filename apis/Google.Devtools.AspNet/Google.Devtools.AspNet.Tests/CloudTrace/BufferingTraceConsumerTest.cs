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
        public void Recieve()
        {
            int bufferSize = 1024;
            Traces traces = new Traces();
            traces.Traces_.Add(CreateTrace());

            FakeConsumer fakeConsumer = new FakeConsumer();
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(fakeConsumer, bufferSize);
            consumer.Recieve(traces);
            Assert.Equal(fakeConsumer.ReceiveCalls, 0);

            traces = new Traces();
            while (traces.Traces_.Count < 1000 && traces.CalculateSize() < bufferSize)
            {
                traces.Traces_.Add(CreateTrace());
            }

            consumer.Recieve(traces);
            Assert.Equal(fakeConsumer.ReceiveCalls, 1);
        }

        [Fact]
        public void Flush()
        {
            Traces traces = new Traces();
            Trace trace = new Trace();
            traces.Traces_.Add(trace);

            FakeConsumer fakeConsumer = new FakeConsumer();
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(fakeConsumer, int.MaxValue);
            consumer.Recieve(traces);
            Assert.Equal(fakeConsumer.ReceiveCalls, 0);

            consumer.Flush();
            Assert.Equal(fakeConsumer.ReceiveCalls, 1);
        }

        [Fact]
        public void Flush_NoTraces()
        {
            FakeConsumer fakeConsumer = new FakeConsumer();
            BufferingTraceConsumer consumer = BufferingTraceConsumer.Create(fakeConsumer, int.MaxValue);
            consumer.Recieve(new Traces());
            Assert.Equal(fakeConsumer.ReceiveCalls, 0);
        }

        private class FakeConsumer : ITraceConsumer
        {
            public int ReceiveCalls { get; private set; }
            public void Recieve(Traces traces)
            {
                ReceiveCalls++;
            }
        }
    }
}
