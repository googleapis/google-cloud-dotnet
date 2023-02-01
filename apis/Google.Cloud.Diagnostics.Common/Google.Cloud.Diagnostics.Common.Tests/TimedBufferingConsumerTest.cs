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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Diagnostics.Common.Tests
{
    public class TimedBufferingConsumerTest
    {
        private static TimeSpan _waitTime = TimeSpan.FromSeconds(5);
        
        [Fact]
        public void Receive()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            var consumer = TimedBufferingConsumer<int>.Create(mockConsumer.Object, _waitTime, null);
            consumer.Receive(new[] { 1, 2, 3, 4, 5 });
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());
        }

        [Fact]
        public void Flush()
        {
            int[] intArray = { 1, 2, 3, 4 };
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.Receive(intArray));
            var consumer = TimedBufferingConsumer<int>.Create(mockConsumer.Object, _waitTime, null);

            consumer.Receive(intArray);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());

            consumer.Flush();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public void Flush_NoTraces()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.Receive(new int[] { }));
            var consumer = TimedBufferingConsumer<int>.Create(mockConsumer.Object, _waitTime, null);

            consumer.Receive(new int[] { });
            consumer.Flush();
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());
        }

        [Fact]
        public async Task ReceiveAsync()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            var consumer = TimedBufferingConsumer<int>.Create(mockConsumer.Object, _waitTime, null);
            await consumer.ReceiveAsync(new[] { 1, 2, 3, 4, 5 }, CancellationToken.None);
            mockConsumer.Verify(c => c.ReceiveAsync(
                It.IsAny<IEnumerable<int>>(), CancellationToken.None), Times.Never());
        }


        [Fact]
        public async Task FlushAsync()
        {
            int[] intArray = { 1, 2, 3, 4 };
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.ReceiveAsync(
                intArray, CancellationToken.None)).Returns(CommonUtils.CompletedTask);
            var consumer = TimedBufferingConsumer<int>.Create(mockConsumer.Object, _waitTime, null);

            await consumer.ReceiveAsync(intArray, CancellationToken.None);
            mockConsumer.Verify(c => c.ReceiveAsync(
                It.IsAny<IEnumerable<int>>(), CancellationToken.None), Times.Never());

            await consumer.FlushAsync();
            mockConsumer.VerifyAll();
        }

        [Fact]
        public async Task FlushAsync_NoTraces()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            mockConsumer.Setup(c => c.ReceiveAsync(
                new int[] { }, CancellationToken.None));
            var consumer = TimedBufferingConsumer<int>.Create(mockConsumer.Object, _waitTime, null);

            await consumer.ReceiveAsync(new int[] { }, CancellationToken.None);
            await consumer.FlushAsync();
            mockConsumer.Verify(c => c.ReceiveAsync(
                It.IsAny<IEnumerable<int>>(), CancellationToken.None), Times.Never());
        }

        [Fact]
        public void Timer()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            var fakeTimer = new FakeThreadingTimer();
            var consumer = new TimedBufferingConsumer<int>(mockConsumer.Object, _waitTime, null, fakeTimer);

            var intArray = new[] { 1, 2, 3, 4, 5 };
            consumer.Receive(intArray);
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Never());
            fakeTimer.FullTick();
            mockConsumer.Verify(c => c.Receive(intArray), Times.Once());

            var intArrayTwo = new[] { 10, 9, 8, 7, 6 };
            consumer.Receive(intArrayTwo);
            fakeTimer.FullTick();
            mockConsumer.Verify(c => c.Receive(intArrayTwo), Times.Once());
        }

        [Fact]
        public void Timer_SwallowException()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            var fakeTimer = new FakeThreadingTimer();
            var consumer = new TimedBufferingConsumer<int>(mockConsumer.Object, _waitTime, null, fakeTimer);

            mockConsumer.Setup(c => c.Receive(It.IsAny<IEnumerable<int>>())).Throws(new Exception());
            consumer.Receive(new[] { 1, 2, 3, 4, 5 });
            fakeTimer.FullTick();
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Once());
        }

        [Fact]
        public void Timer_HandleException()
        {
            var mockConsumer = new Mock<IConsumer<int>>();
            var fakeTimer = new FakeThreadingTimer();
            int exceptionsCaught = 0;
            var consumer = new TimedBufferingConsumer<int>(mockConsumer.Object, _waitTime, HandleException, fakeTimer);

            mockConsumer.Setup(c => c.Receive(It.IsAny<IEnumerable<int>>())).Throws(new Exception());
            consumer.Receive(new[] { 1, 2, 3, 4, 5 });
            fakeTimer.FullTick();
            mockConsumer.Verify(c => c.Receive(It.IsAny<IEnumerable<int>>()), Times.Once());
            Assert.Equal(1, exceptionsCaught);

            void HandleException(Exception exception) => exceptionsCaught++;
        }
    }
}
