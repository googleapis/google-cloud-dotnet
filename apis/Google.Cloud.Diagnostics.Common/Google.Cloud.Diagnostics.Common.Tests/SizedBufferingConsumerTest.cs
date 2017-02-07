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

using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class SizedBufferingConsumerTest
    {
        private const int _bufferSize = 10;

        private IFlushableConsumer<int> GetConsumer(IConsumer<int> consumer) 
            => SizedBufferingConsumer<int>.Create(consumer, Utils.ConstantSizer<int>.GetSize, _bufferSize);

        [Fact]
        public void Receive()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            var consumer = GetConsumer(mockConsumer.Object);
            consumer.Receive(new[] { 1, 2 });

            // Ensure ints have not been sent as they are not bigger then the buffer.
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());

            // Add the initial ints the list.  This ensures we verify the right 
            // values where received.
            mockConsumer.Setup(c => c.Receive(new[] { 1, 2, 3, 4, 5 }));

            // Fill the buffer so it will be flushed.
            consumer.Receive(new[] { 3, 4, 5 });
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Flush()
        {
            int[] intArray = { 1, 2, 3, 4 };
            var mockConsumer = new Mock<IConsumer<int>>();
            var consumer = GetConsumer(mockConsumer.Object);

            consumer.Receive(intArray);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());

            mockConsumer.Setup(c => c.Receive(intArray));
            consumer.Flush();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Flush_NoTraces()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.Receive(new int[] { }));
            var consumer = GetConsumer(mockConsumer.Object);

            consumer.Receive(new int[] { });
            consumer.Flush();
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            var consumer = GetConsumer(mockConsumer.Object);
            await consumer.ReceiveAsync(new[] { 1, 2 }, CancellationToken.None);

            // Ensure ints have not been sent as they are not bigger then the buffer.
            mockConsumer.Verify(c => c.ReceiveAsync(
                It.IsAny<IEnumerable<int>>(), CancellationToken.None), Times.Never());

            // Add the initial ints the list.  This ensures we verify the right 
            // values where received.
            mockConsumer.Setup(c => c.ReceiveAsync(
                new[] { 1, 2, 3, 4, 5 }, CancellationToken.None)).Returns(CommonUtils.CompletedTask);

            // Fill the buffer so it will be flushed.
            await consumer.ReceiveAsync(new[] { 3, 4, 5 }, CancellationToken.None);
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task FlushAsync()
        {
            int[] intArray = { 1, 2, 3, 4 };
            var mockConsumer = new Mock<IConsumer<int>>();
            var consumer = GetConsumer(mockConsumer.Object);

            await consumer.ReceiveAsync(intArray);
            mockConsumer.Verify(c => c.ReceiveAsync(
                It.IsAny<IEnumerable<int>>(), CancellationToken.None), Times.Never());

            mockConsumer.Setup(c => c.ReceiveAsync(
                intArray, CancellationToken.None)).Returns(CommonUtils.CompletedTask);
            await consumer.FlushAsync();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task FlushAsync_NoTraces()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.ReceiveAsync(new int[] { }, CancellationToken.None));
            var consumer = GetConsumer(mockConsumer.Object);

            await consumer.ReceiveAsync(new int[] { });
            consumer.Flush();
            mockConsumer.Verify(c => c.ReceiveAsync(
                It.IsAny<IEnumerable<int>>(), CancellationToken.None), Times.Never());
        }
    }
}
