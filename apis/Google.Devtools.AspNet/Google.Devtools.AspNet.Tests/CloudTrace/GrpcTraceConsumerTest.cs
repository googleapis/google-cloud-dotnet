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
// limitations under the License.using Microsoft.VisualStudio.TestTools.UnitTesting;


using Google.Devtools.Cloudtrace.V1;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Google.Devtools.AspNet.Tests.CloudTrace
{
    public class GrpcTraceConsumerTest
    {
        private static readonly string ProjectId = "pid";

        private Traces GetTraces()
        {
            Traces traces = new Traces();
            Trace trace = new Trace()
            {
                ProjectId = ProjectId
            };
            traces.Traces_.Add(trace);
            return traces;
        }

        [Fact]
        public void Receive()
        {
            Traces traces = GetTraces();

            Mock<TraceServiceClient> mockClient = new Mock<TraceServiceClient>();
            mockClient.Setup(c => c.PatchTracesAsync(ProjectId, traces, null));
            Task<TraceServiceClient> taskClient = Task.FromResult(mockClient.Object);
            GrpcTraceConsumer consumer = new GrpcTraceConsumer(taskClient);

            consumer.Receive(traces);
            mockClient.VerifyAll();
        }

        [Fact]
        public void Receive_NoTraces()
        {
            Mock<TraceServiceClient> mockClient = new Mock<TraceServiceClient>();
            Task<TraceServiceClient> taskClient = Task.FromResult(mockClient.Object);
            GrpcTraceConsumer consumer = new GrpcTraceConsumer(taskClient);

            consumer.Receive(new Traces());
            mockClient.Verify(c => c.PatchTracesAsync(It.IsAny<string>(), It.IsAny<Traces>(), null), Times.Never());
        }

        [Fact]
        public void Receive_ClientNotReady()
        {
            Traces traces = GetTraces();

            Mock<TraceServiceClient> mockClient = new Mock<TraceServiceClient>();
            Task<TraceServiceClient> taskClient = new Task<TraceServiceClient>(() => mockClient.Object);           
            GrpcTraceConsumer consumer = new GrpcTraceConsumer(taskClient);

            consumer.Receive(traces);
            mockClient.Verify(c => c.PatchTracesAsync(It.IsAny<string>(), It.IsAny<Traces>(), null), Times.Never());
        }
    }
}
