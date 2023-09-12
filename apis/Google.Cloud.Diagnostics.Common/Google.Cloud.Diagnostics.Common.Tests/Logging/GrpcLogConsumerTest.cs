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

using Google.Cloud.Logging.V2;
using NSubstitute;
using NSubstitute.Extensions;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class GrpcLogConsumerTest
    {
        [Fact]
        public void Receive()
        {
            var logs = new[] { new LogEntry(), new LogEntry() };
            var mockClient = Substitute.ForPartsOf<LoggingServiceV2Client>();
            mockClient.When(mock => mock.WriteLogEntries((LogName) null, null, null, logs, null)).DoNotCallBase();
            var consumer = new GrpcLogConsumer(mockClient);

            consumer.Receive(logs);
            mockClient.Received(1).WriteLogEntries((LogName) null, null, null, logs, null);
        }

        [Fact]
        public void Receive_EmptyEnumerableIgnored()
        {
            var mockClient = Substitute.ForPartsOf<LoggingServiceV2Client>();
            var consumer = new GrpcLogConsumer(mockClient);

            consumer.Receive(new LogEntry[] { });
            mockClient.DidNotReceiveWithAnyArgs().WriteLogEntries((LogName) null, null, null, null, null);
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var logs = new[] { new LogEntry(), new LogEntry() };
            var mockClient = Substitute.ForPartsOf<LoggingServiceV2Client>();
            mockClient.Configure().WriteLogEntriesAsync((LogName) null, null, null, logs, CancellationToken.None)
                .Returns(Task.FromResult(new WriteLogEntriesResponse()));
            var consumer = new GrpcLogConsumer(mockClient);

            await consumer.ReceiveAsync(logs, CancellationToken.None);
            _ = mockClient.Received(1).WriteLogEntriesAsync((LogName) null, null, null, logs, CancellationToken.None);
        }

        [Fact]
        public async Task ReceiveAsync_EmptyEnumerableIgnored()
        {
            var mockClient = Substitute.ForPartsOf<LoggingServiceV2Client>();
            var consumer = new GrpcLogConsumer(mockClient);

            await consumer.ReceiveAsync(new LogEntry[] { }, CancellationToken.None);
            _ = mockClient.DidNotReceiveWithAnyArgs().WriteLogEntriesAsync((LogName) null, null, null, null, CancellationToken.None);
        }
    }
}

