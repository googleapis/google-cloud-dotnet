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
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class GrpcLogConsumerTest
    {
        [Fact]
        public void Receive()
        {
            var logs = new[] { new LogEntry(), new LogEntry() };
            var mockClient = new Mock<LoggingServiceV2Client>();
            mockClient.Setup(c => c.WriteLogEntriesAsync(
                null, null, It.IsAny<IDictionary<string, string>>(), logs, null));
            var consumer = new GrpcLogConsumer(mockClient.Object);

            consumer.Receive(logs);
            mockClient.VerifyAll();
        }

        [Fact]
        public void Receive_EmptyEnumerableIgnored()
        {
            var mockClient = new Mock<LoggingServiceV2Client>();
            var consumer = new GrpcLogConsumer(mockClient.Object);

            consumer.Receive(new LogEntry[] { });
            mockClient.Verify(c => c.WriteLogEntriesAsync(
                null, null, It.IsAny<IDictionary<string, string>>(),
                It.IsAny<IEnumerable<LogEntry>>(), null), Times.Never());
        }
    }
}

