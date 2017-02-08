// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.ErrorReporting.V1Beta1;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class GrpcErrorEventConsumerTest
    {
        private const string _projectId = "pid";
        private static readonly ProjectName _projectName = new ProjectName(_projectId);

        [Fact]
        public void Receive()
        {
            var errorEvents = new[] { new ReportedErrorEvent(), new ReportedErrorEvent() };
            var mockClient = new Mock<ReportErrorsServiceClient>();
            mockClient.Setup(c => c.ReportErrorEvent(_projectName, errorEvents[0], null));
            mockClient.Setup(c => c.ReportErrorEvent(_projectName, errorEvents[1], null));
            var consumer = new GrpcErrorEventConsumer(mockClient.Object, _projectId);

            consumer.Receive(errorEvents);
            mockClient.VerifyAll();
        }

        [Fact]
        public void Receive_EmptyEnumerableIgnored()
        {
            var mockClient = new Mock<ReportErrorsServiceClient>();
            var consumer = new GrpcErrorEventConsumer(mockClient.Object, _projectId);

            consumer.Receive(new ReportedErrorEvent[] { });
            mockClient.Verify(c => c.ReportErrorEvent(
                It.IsAny<ProjectName>(), It.IsAny<ReportedErrorEvent>(), null), Times.Never());
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var errorEvents = new[] { new ReportedErrorEvent(), new ReportedErrorEvent() };
            var mockClient = new Mock<ReportErrorsServiceClient>();
            var task = Task.FromResult(new ReportErrorEventResponse());
            mockClient.Setup(c => c.ReportErrorEventAsync(
                _projectName, errorEvents[0], default(CancellationToken))).Returns(task);
            mockClient.Setup(c => c.ReportErrorEventAsync(
                _projectName, errorEvents[1], default(CancellationToken))).Returns(task);
            var consumer = new GrpcErrorEventConsumer(mockClient.Object, _projectId);

            await consumer.ReceiveAsync(errorEvents, default(CancellationToken));
            mockClient.VerifyAll();
        }

        [Fact]
        public async Task ReceiveAsync_EmptyEnumerableIgnored()
        {
            var mockClient = new Mock<ReportErrorsServiceClient>();
            var consumer = new GrpcErrorEventConsumer(mockClient.Object, _projectId);

            await consumer.ReceiveAsync(new ReportedErrorEvent[] { }, default(CancellationToken));
            mockClient.Verify(c => c.ReportErrorEventAsync(
                It.IsAny<ProjectName>(), It.IsAny<ReportedErrorEvent>(), null), Times.Never());
        }
    }
}
