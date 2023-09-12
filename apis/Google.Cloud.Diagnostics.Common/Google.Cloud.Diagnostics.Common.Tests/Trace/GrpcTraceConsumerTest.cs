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


using Google.Cloud.Trace.V1;
using NSubstitute;
using NSubstitute.Extensions;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class GrpcTraceConsumerTest
    {
        private static readonly string ProjectId = "pid";

        private Traces GetTraces() => new Traces
        { Traces_ = { new TraceProto() { ProjectId = ProjectId } } };

        [Fact]
        public void Receive()
        {
            Traces traces = GetTraces();

            var mockClient = Substitute.ForPartsOf<TraceServiceClient>();
            mockClient.When(c => c.PatchTraces(ProjectId, traces, null)).DoNotCallBase();
            var consumer = new GrpcTraceConsumer(mockClient);

            consumer.Receive(traces.Traces_);
            mockClient.Received(1).PatchTraces(ProjectId, traces, null);
        }

        [Fact]
        public void Receive_EmptyTracesIgnored()
        {
            var mockClient = Substitute.ForPartsOf<TraceServiceClient>();
            var consumer = new GrpcTraceConsumer(mockClient);

            consumer.Receive(new List<TraceProto>());
            Assert.Empty(mockClient.ReceivedCalls());
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            Traces traces = GetTraces();

            var mockClient = Substitute.ForPartsOf<TraceServiceClient>();
            mockClient.Configure().PatchTracesAsync(ProjectId, traces, CancellationToken.None)
                .Returns(CommonUtils.CompletedTask);
            var consumer = new GrpcTraceConsumer(mockClient);

            await consumer.ReceiveAsync(traces.Traces_, CancellationToken.None);
            _ = mockClient.Received(1).PatchTracesAsync(ProjectId, traces, CancellationToken.None);
        }

        [Fact]
        public async Task ReceiveAsync_EmptyTracesIgnored()
        {
            var mockClient = Substitute.ForPartsOf<TraceServiceClient>();
            var consumer = new GrpcTraceConsumer(mockClient);

            await consumer.ReceiveAsync(new List<TraceProto>());
            Assert.Empty(mockClient.ReceivedCalls());
        }
    }
}
